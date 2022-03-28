Imports System.Text
Imports System.Security.Cryptography

Public Module Herramientas
    Public Function GFsSHA256(ByVal value As String, Optional ByVal psConSal As Boolean = True) As String
        Dim loSha256 As SHA256 = SHA256Managed.Create()
        Dim lsSalt As String = ""
        Dim lbBytes As Byte()
        If psConSal Then
            Dim lsSetupSalt = GFsGetRegistry(sEncriptacion_, sSetupSalt_)
            Dim lsForcedSalt = GFsGetRegistry(sSeguridad_, sForcedSalt_)

            lsSalt = lsSetupSalt
            If lsForcedSalt <> sRESERVADO_ Then
                If SesionActiva.AutorizadoResetear(sSeguridad_, sForcedSalt_, lsForcedSalt) = sSi_ Then
                    lsSalt = lsForcedSalt
                    GPSavRegistry(sEncriptacion_, sSetupSalt_, lsSalt)
                    GPSavRegistry(sSeguridad_, sForcedSalt_, sRESERVADO_)
                End If
            End If
            lbBytes = Encoding.UTF8.GetBytes(value & lsSalt)
        Else
            lbBytes = Encoding.UTF8.GetBytes(value)
        End If
        Dim lbHash As Byte() = loSha256.ComputeHash(lbBytes)
        Dim loStringBuilder As New StringBuilder()

        For i As Integer = 0 To lbHash.Length - 1
            loStringBuilder.Append(lbHash(i).ToString("X2"))
        Next

        Return loStringBuilder.ToString()
    End Function

    Public Function GFsSHA512(ByVal value As String, Optional ByVal psConSal As Boolean = True) As String
        Dim loSha512 As SHA512 = SHA512Managed.Create()
        Dim lbBytes As Byte()
        Dim lsSalt As String = ""
        If psConSal Then
            Dim lsSetupSalt = GFsGetRegistry(sEncriptacion_, sSetupSalt_)
            Dim lsForcedSalt = GFsGetRegistry(sSeguridad_, sForcedSalt_)

            lsSalt = lsSetupSalt
            If lsForcedSalt <> sRESERVADO_ Then
                If SesionActiva.AutorizadoResetear(sSeguridad_, sForcedSalt_, lsForcedSalt) = sSi_ Then
                    lsSalt = lsForcedSalt
                    GPSavRegistry(sEncriptacion_, sSetupSalt_, lsSalt)
                    GPSavRegistry(sSeguridad_, sForcedSalt_, sRESERVADO_)
                End If
            End If
            lbBytes = Encoding.UTF8.GetBytes(value & lsSalt)
        Else
            lbBytes = Encoding.UTF8.GetBytes(value)
        End If
        Dim lbHash As Byte() = loSha512.ComputeHash(lbBytes)
        Dim loStringBuilder As New StringBuilder()

        For i As Integer = 0 To lbHash.Length - 1
            loStringBuilder.Append(lbHash(i).ToString("X2"))
        Next

        Return loStringBuilder.ToString()
    End Function

    Public Function GFiAleatorio(Optional ByVal piDesde As Integer = 1, Optional ByVal piHasta As Integer = 9999) As Integer
        Dim liNumero As Integer
        Dim liWatchDog As Integer = 0
        Randomize()
        Do
            liWatchDog += 1
            liNumero = CInt(Math.Ceiling(Rnd() * piHasta)) + piDesde
            If liWatchDog = 100 Then Exit Do
        Loop Until liNumero >= piDesde And liNumero <= piHasta
        Return liNumero
    End Function

    Public Sub GPBitacoraRegistrar(ByVal psAccion As String, ByVal psAccionDetalle As String)
        Dim loBitacoraProceso As New BitacoraProceso
        loBitacoraProceso.Registrar(psAccion, psAccionDetalle)
        loBitacoraProceso = Nothing
    End Sub

    Public Function GFsGetRegistry(ByVal psRama As String, ByVal psClave As String) As String
        Dim lsResultado As String = ""
        Dim loRegistry As New Registry
        lsResultado = loRegistry.GetRegistry(psRama, psClave)
        loRegistry = Nothing
        Return lsResultado
    End Function

    Public Sub GPSavRegistry(ByVal psRama As String, ByVal psClave As String, ByVal psValor As String)
        Dim loRegistry As New Registry
        loRegistry.SavRegistry(psRama, psClave, psValor)
        loRegistry = Nothing
    End Sub

    Public Function GFsParametroObtener(ByVal psTipo As String, ByVal psClave As String, Optional ByVal psEscalando As String = sSi_) As String
        Dim lsResultado As String = ""
        Dim loParametroSistema As New ParametroSistema
        lsResultado = loParametroSistema.Obtener(psTipo, psClave, psEscalando)
        If lsResultado.Trim.Length > 0 Then
            If lsResultado.Last = ControlChars.CrLf Then lsResultado.Substring(0, lsResultado.Length - 1)
        End If
        loParametroSistema = Nothing
        Return lsResultado
    End Function

    Public Sub GPParametroGuardar(ByVal psTipo As String, ByVal psClave As String, ByVal psValor As String, Optional ByVal psEscalando As String = sSi_)
        Dim loParametroSistema As New ParametroSistema
        loParametroSistema.Guardar(psTipo, psClave, psValor, psEscalando)
        loParametroSistema = Nothing
    End Sub

    Public Function GFsGeneraSQL(ByVal psCodigo As String, Optional ByVal psTipo As String = sGeneral_) As String
        Dim lsResultado As String = ""
        Dim lsClave As String = "Tabla general - SQL del sistema"
        Dim lsSS030_codigo As String = GFsParametroObtener(psTipo, lsClave)

        Dim loDatos As New Ess040tabdet
        loDatos.ss010_codigo = SesionActiva.sistema
        loDatos.ss030_codigo = lsSS030_codigo
        loDatos.codigo = psCodigo
        If loDatos.GetPK = sSinRegistros_ Then
            loDatos.ss010_codigo = SesionActiva.sistema
            loDatos.ss030_codigo = lsSS030_codigo
            loDatos.codigo = psCodigo
            loDatos.nombre = "Descripcion " & psCodigo
            loDatos.detalle = GFsRecuperaSQLArchivo(psCodigo)
            Try
                loDatos.Add(sNo_, sNo_)
            Catch ex As Exception
                GFsAvisar("Herramientas.GfsGeneraSQL", sMENSAJE_, ex.Message)
            End Try
        End If

        lsResultado = loDatos.detalle
        loDatos.CerrarConexion()
        loDatos = Nothing
        Return lsResultado
    End Function

    Public Sub GPTablaGeneralObtener(ByVal psCodigo As String, Optional ByVal psSS010_codigo As String = "")
        Dim lsResultado As String = ""
        Dim loSS030 As New Ess030tabcab
        Dim lsSS010_codigo As String = psSS010_codigo
        If lsSS010_codigo.Trim.Length = 0 Then
            lsSS010_codigo = SesionActiva.sistema
        End If

        loSS030.ss010_codigo = lsSS010_codigo
        loSS030.codigo = psCodigo
        If loSS030.GetPK = sSinRegistros_ Then
            loSS030.ss010_codigo = lsSS010_codigo
            loSS030.codigo = psCodigo
            loSS030.nombre = "Descripcion " & psCodigo
            Try
                loSS030.Add(sNo_, sNo_)
            Catch ex As Exception
                GFsAvisar("Herramientas.GFsTablaGeneralObtener", sMENSAJE_, ex.Message)
            End Try
        End If
        loSS030.CerrarConexion()
        loSS030 = Nothing
    End Sub

    Public Function GFsRecuperaSQLArchivo(ByVal psFileName As String) As String
        Dim lsResultado As String = sRESERVADO_
        Dim lsUbicacion As String = GFsParametroObtener(sLocal_, "Ubicacion - SQL")
        Dim lsFile As String = lsUbicacion & sDS_ & psFileName & sExtensionSQL_
        Try
            If System.IO.File.Exists(lsFile) Then
                lsResultado = System.IO.File.ReadAllText(lsFile)
            Else
                lsFile = lsUbicacion & sDS_ & psFileName & sExtensionBitacora_
                If System.IO.File.Exists(lsFile) Then
                    lsResultado = System.IO.File.ReadAllText(lsFile)
                Else
                    GPDirectoryCheck(lsUbicacion)
                End If
            End If
        Catch ex As Exception
            GFsAvisar("GFsFileReadAllOnce", sMENSAJE_, ex.Message)
        End Try
        Return lsResultado
    End Function

    Public Sub GPDirectoryCheck(ByVal psUbicacion As String)
        If psUbicacion.Trim.Length = 0 Then Exit Sub

        If Not System.IO.Directory.Exists(psUbicacion) Then
            System.IO.Directory.CreateDirectory(psUbicacion)
        End If
    End Sub

    Public Sub GPActualizaUltimoAcceso()
        Dim loArchivoControl As New ArchivoControl
        loArchivoControl.Actualizar()
        loArchivoControl = Nothing
        Dim lsClave As String = "Sesion - Fecha/Hora ultimo acceso_"
        Dim lsValor As String = Now.ToString(sFormatoFechaHora1_)
        GPParametroGuardar(sLocal_, lsClave, lsValor, sNo_)
    End Sub

    Public Function GFbValidarCuentaEmail(ByVal psEmail As String) As Boolean
        Dim lbResultado As Boolean = True

        If InStr(psEmail, "@") = 0 Then
            lbResultado = False
        Else
            If InStr(psEmail, ".") = 0 Then
                lbResultado = False
            Else
                Try
                    Dim loEmailAddress As New System.Net.Mail.MailAddress(psEmail)
                Catch ex As Exception
                    lbResultado = False
                End Try
            End If
        End If
        Return lbResultado
    End Function
End Module
