Imports System.IO
Imports System.Data.Common
Imports System.Text

Public Class BitacoraProceso
    Shared mbGeneroCabecera As Boolean = False
    Shared msUbicacion As String = ""
    Shared msFileName As String = ""
    Shared msArchivoBitacora As String = ""
    Shared msFechaHoraEntrada As String = ""

    Shared ReadOnly Property archivoBitacora As String
        Get
            Return msArchivoBitacora
        End Get
    End Property

    Shared ReadOnly Property fileName As String
        Get
            Return msFileName
        End Get
    End Property

    Public Sub Inicializa()
        If msArchivoBitacora.Trim.Length > 0 Then Exit Sub

        Dim lsFechaHora As String = Now.ToString(sFormatoFechaHora2_)
        msUbicacion = GFsGetRegistry(sSeguridad_, sUbicacionBitacora_)
        msFileName = SesionActiva.sessionId & sExtensionBitacora_
        msArchivoBitacora = msUbicacion & sDS_ & msFileName

        If Not Directory.Exists(msUbicacion) Then
            Directory.CreateDirectory(msUbicacion)
        End If
        If Not File.Exists(msArchivoBitacora) Then
            Dim loEncoding As Encoding = New UTF8Encoding(False)
            Dim loArchivoBitacora As New StreamWriter(msArchivoBitacora, True, loEncoding)
            Try
                msFechaHoraEntrada = Now.ToString(sFormatoFechaHora1_)
                loArchivoBitacora.WriteLine("-CABECERA INICIO----------------------------------------------------------------------------------------")
            Catch ex As Exception
                MessageBox.Show("BitacoraProceso / Cabecera -> Error:" & ex.Message)
            End Try
            loArchivoBitacora.Close()
            loEncoding = Nothing
            loArchivoBitacora = Nothing
        End If

        Dim ss010 As New Ess010sistemas
        ss010.codigo = SesionActiva.sistema
        If ss010.GetPK <> sOk_ Then
            ss010.codigo = SesionActiva.sistema
            ss010.nombre = "Descripcion sistema [" & SesionActiva.sistema & "]"
            Try
                ss010.Add(sNo_, sNo_)
            Catch ex As Exception
                MessageBox.Show("BitacoraProceso / Ess010sistemas -> Error:" & ex.Message)
            End Try
        End If
        ss010.CerrarConexion()
        ss010 = Nothing

        Dim ss060 As New Ess060equipos
        ss060.codigo = SesionActiva.equipo
        If ss060.GetPK <> sOk_ Then
            ss060.codigo = SesionActiva.equipo
            ss060.valido = Today.ToString("yyyy-MM-dd")
            ss060.expira = Today.AddYears(iYearsLimit_).ToString("yyyy-MM-dd")
            ss060.mac = SesionActiva.mac
            ss060.ip = SesionActiva.ip
            ss060.ubicacion = sRESERVADO_
            Try
                ss060.Add(sNo_, sNo_)
            Catch ex As Exception
                MessageBox.Show("BitacoraProceso / Ess060equipos -> Error:" & ex.Message)
            End Try
        End If
        ss060.CerrarConexion()
        ss060 = Nothing

        Dim lsTipo As String = sLocal_
        Dim lsClave As String = "Tabla general - Registro Envio Bitacora"
        Dim lsValor As String = "RegistroEnvioBitacora_" & SesionActiva.serialHDD.Trim.ToLower
        Dim lsCodigo As String = GFsParametroObtener(lsTipo, lsClave, sNo_)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If
        Dim lsSS030_codigo As String = GFsParametroObtener(sLocal_, lsClave, sNo_)
        Dim loSS030 As New Ess030tabcab
        loSS030.ss010_codigo = SesionActiva.sistema
        loSS030.codigo = lsSS030_codigo
        If loSS030.GetPK = sSinRegistros_ Then
            loSS030.ss010_codigo = SesionActiva.sistema
            loSS030.codigo = lsSS030_codigo
            loSS030.nombre = lsClave
            loSS030.estado = sActivo_
            Try
                loSS030.Add(sNo_, sNo_)
            Catch ex As Exception
                MessageBox.Show("BitacoraProceso / Ess030tabcab -> Error:" & ex.Message)
            End Try
        End If
        loSS030.CerrarConexion()
        loSS030 = Nothing

        Dim loSS040 As New Ess040tabdet
        loSS040.ss010_codigo = SesionActiva.sistema
        loSS040.ss030_codigo = lsSS030_codigo
        loSS040.codigo = msFileName
        loSS040.nombre = sEnviarMail_
        loSS040.detalle = msArchivoBitacora
        Try
            loSS040.Add(sNo_, sNo_)
        Catch ex As Exception
            MessageBox.Show("BitacoraProceso / Ess040tabdet -> Error:" & ex.Message)
        End Try
        loSS040.CerrarConexion()
        loSS040 = Nothing
    End Sub

    Public Sub Registrar(ByVal psAccion As String, ByVal psAccionDetalle As String)
        If SesionActiva.loggeado Then
            If mbGeneroCabecera = False Then
                mbGeneroCabecera = True
                LPGeneraBitacoraCabecera()
                LPBitacoraDetalleLogout()
            End If
            LPGeneraBitacoraDetalle(psAccion, psAccionDetalle)
        Else
            SesionActiva.AgregarLogRegistro(Now.ToString(sFormatoFechaHora2_) & sSF_ & psAccion & sSF_ & psAccionDetalle)
        End If
    End Sub

    Public Sub Cerrar()
        LPCierreBitacora()
    End Sub

    Private Sub LPGeneraBitacoraCabecera()
        Dim loEncoding As Encoding = New UTF8Encoding(False)
        Dim loArchivoBitacora As New StreamWriter(msArchivoBitacora, True, loEncoding)
        loArchivoBitacora.WriteLine("Id Sesion...: " & SesionActiva.sessionId)
        loArchivoBitacora.WriteLine("Sistema.....: " & SesionActiva.sistema)
        loArchivoBitacora.WriteLine("Fecha/hora..: " & msFechaHoraEntrada)
        loArchivoBitacora.WriteLine("Usuario.....: " & SesionActiva.usuario)
        loArchivoBitacora.WriteLine("Login acceso: " & SesionActiva.loginAcceso)
        loArchivoBitacora.WriteLine("Equipo......: " & SesionActiva.equipo)
        loArchivoBitacora.WriteLine("HDD serial..: " & SesionActiva.serialHDD)
        loArchivoBitacora.WriteLine("IpV4........: " & SesionActiva.ip)
        loArchivoBitacora.WriteLine("-CABECERA FINAL-----------------------------------------------------------------------------------------")
        loArchivoBitacora.WriteLine("-DETALLE INICIO-----------------------------------------------------------------------------------------")
        loArchivoBitacora.Close()
        loEncoding = Nothing
        loArchivoBitacora = Nothing

        Dim ss140 As New Ess140bitsescab
        ss140.codigo = SesionActiva.sessionId
        ss140.fechaHora = msFechaHoraEntrada
        ss140.ss050_codigo = SesionActiva.usuario
        ss140.ss010_codigo = SesionActiva.sistema
        ss140.ss060_codigo = SesionActiva.equipo
        ss140.login = SesionActiva.loginAcceso
        ss140.mac = SesionActiva.mac
        ss140.ip = SesionActiva.ip
        Try
            ss140.Add(sNo_, sNo_)
        Catch ex As Exception
            MessageBox.Show("BitacoraProceso / Ess140bitsescab -> Error:" & ex.Message)
        End Try
        ss140.CerrarConexion()
        ss140 = Nothing
    End Sub

    Private Sub LPBitacoraDetalleLogout()
        For liNDX As Integer = 0 To SesionActiva.logRegistro.Count - 1
            Dim lsParte() As String = SesionActiva.logRegistro.Item(liNDX).ToString.Split(sSF_)
            LPGeneraBitacoraDetalle(lsParte(1), lsParte(2), lsParte(0))
        Next
        SesionActiva.LimpiarLogRegistro()
    End Sub

    Private Sub LPGeneraBitacoraDetalle(ByVal psAccion As String, ByVal psAccionDetalle As String, Optional psFechaHora As String = "")
        If SesionActiva.loggeado = False Then Exit Sub

        Dim lsFechaHora As String = ""
        If psFechaHora.Trim.Length > 0 Then
            lsFechaHora = psFechaHora
        Else
            lsFechaHora = Now.ToString(sFormatoFechaHora2_)
        End If

        Dim ss150 As New Ess150bitsesdet
        ss150.ss140_codigo = SesionActiva.sessionId
        ss150.fechaHora = lsFechaHora
        ss150.operacion = psAccion
        ss150.detalle = psAccionDetalle
        ss150.Add(sNo_, sNo_)
        ss150.CerrarConexion()
        ss150 = Nothing

        Dim lsLinea As String = lsFechaHora & sBS_ & psAccion & sBS_ & psAccionDetalle
        Dim loEncoding As Encoding = New UTF8Encoding(False)
        Dim loArchivoBitacora As New StreamWriter(archivoBitacora, True, loEncoding)
        loArchivoBitacora.WriteLine(lsLinea)
        loArchivoBitacora.Close()
        loArchivoBitacora = Nothing

    End Sub

    Private Sub LPCierreBitacora()
        Dim loEncoding As Encoding = New UTF8Encoding(False)
        Dim loArchivoBitacora As New StreamWriter(archivoBitacora, True, loEncoding)
        loArchivoBitacora.WriteLine("-DETALLE FINAL------------------------------------------------------------------------------------------")
        loArchivoBitacora.Flush()
        loArchivoBitacora.Close()
        loArchivoBitacora.Dispose()
        loArchivoBitacora = Nothing
        loEncoding = Nothing
    End Sub

End Class
