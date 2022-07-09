Imports System.IO

Module modGPImportarUnidades
    Public Sub GPImportarUnidades(ByVal piCodEmpresa As Integer)
        Dim lsEntidad As String = "unidades de medidas"
        Dim loElegirArchivo As New OpenFileDialog
        Dim lsFileName As String = ""

        Dim loResultado As DialogResult = loElegirArchivo.ShowDialog()
        If loResultado = DialogResult.OK Then
            lsFileName = loElegirArchivo.FileName
        Else
            GFsAvisar("Usted no ha seleccionado ningun archivo para la importación", sMENSAJE_, "Por lo cual este proceso será cancelado.")
            Exit Sub
        End If
        Dim lsSeparador As String = InputBox("Ingrese separador deseado", "Importación Unidades de Medida", sSF_)
        Dim lcSeparador() As Char = lsSeparador.Trim.ToArray

        If String.IsNullOrEmpty(lsSeparador) Then
            GFsAvisar("Usted no ha seleccionado un separador, de hecho cancelo", sMENSAJE_, "Por lo cual este proceso será cancelado.")
            Exit Sub
        End If
        Dim lsMensaje As String
        lsMensaje = "Importacion de &entidad. Empresa: &codempresa, Archivo: &filename, Separador: &separador"
        lsMensaje = lsMensaje.Replace("&entidad", lsEntidad)
        lsMensaje = lsMensaje.Replace("&codempresa", piCodEmpresa.ToString)
        lsMensaje = lsMensaje.Replace("&filename", lsFileName)
        lsMensaje = lsMensaje.Replace("&separador", lsSeparador)
        GPBitacoraRegistrar(sENTRO_, lsMensaje)
        Dim loFrmProcesamiento As New frmProcesamiento
        loFrmProcesamiento.Show()
        loFrmProcesamiento.lblTitulo.Text = "Importando Archivo Texto " & lsFileName & "..."

        Dim loDataReader As StreamReader
        If InStr(lsFileName, sDS_) = 0 Then
            lsFileName = lsFileName.Replace("\", sDS_)
        End If
        loDataReader = My.Computer.FileSystem.OpenTextFileReader(lsFileName)

        Dim loTabla As New Ea050unidades
        Dim lsLinea As String = ""
        Dim lsMensajeError As String = ""
        Dim lsCabecera() As String = Nothing
        Dim lsValor() As String = Nothing
        Dim lsNombre As String = ""
        Dim loDato As New Hashtable

        lsLinea = loDataReader.ReadLine()
        lcSeparador(0) = GFcDeterminaSeparador(lsLinea, lcSeparador(0))

        lsCabecera = lsLinea.Split(lcSeparador(0))
        While True
            lsLinea = loDataReader.ReadLine()
            If String.IsNullOrEmpty(lsLinea) Then Exit While
            loFrmProcesamiento.lblRegistroLeido.Text = "Procesando [" & lsLinea & "]"

            lsValor = lsLinea.Split(lcSeparador(0))
            If loDato IsNot Nothing Then loDato.Clear()

            For I As Integer = 0 To lsCabecera.Length - 1
                loDato(lsCabecera(I)) = lsValor(I)
            Next
            loTabla.codempresa = piCodEmpresa
            loTabla.codunidad = loDato.Item("codunidad").ToString
            If loTabla.GetPK = sSinRegistros_ Then
                loTabla.codempresa = piCodEmpresa
                loTabla.codunidad = loDato.Item("codunidad").ToString
                loTabla.nombre = loDato.Item("nombre").ToString
                loTabla.estado = sImportado_
                loTabla.Add(sNo_)
                loFrmProcesamiento.lblRegistroProcesado.Text = "Procesando [" & lsLinea & "]"
                loFrmProcesamiento.Refresh()
            Else
                If lsMensajeError.Trim.Length = 0 Then
                    lsMensajeError = "Log de Importacion Archivo: " & lsFileName & ControlChars.CrLf
                    lsMensajeError &= "Fecha/hora proceso: " & Now.ToString(sFormatoFechaHora1_) & ControlChars.CrLf
                    lsMensajeError &= "Usuario: " & SesionActiva.usuario & " - " & SesionActiva.loginAcceso & ControlChars.CrLf
                    lsMensajeError &= "Equipo: " & SesionActiva.equipo & " - " & SesionActiva.ip & " - " & SesionActiva.mac & ControlChars.CrLf
                    lsMensajeError &= "------------------------------------------------------------------------------------------" & ControlChars.CrLf
                End If
                lsMensajeError &= Now.ToString(sFormatoFechaHora2_) & ": Codigo existente --> Codigo: " & loDato.Item("codunidad").ToString & ", Nombre: " & loDato.Item("nombre").ToString & ", Estado: " & loDato.Item("estado").ToString & ControlChars.CrLf
            End If
        End While
        loTabla.CerrarConexion()
        loTabla = Nothing

        loFrmProcesamiento.Close()
        loFrmProcesamiento = Nothing

        If lsMensajeError.Trim.Length > 0 Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(lsMensajeError)
            GFsAvisar(lsMensajeError, sMENSAJE_, "Tambien se ha copiado al Portapapeles.")
        Else
            GFsAvisar("La importacion del archivo " & lsFileName & " ha concluido exitosamente!", sMENSAJE_, "Acepte para continuar!")
        End If
        lsMensaje = "Importacion de &entidad. Empresa: &codempresa, Archivo: &filename, Separador: &separador"
        lsMensaje = lsMensaje.Replace("&entidad", lsEntidad)
        lsMensaje = lsMensaje.Replace("&codempresa", piCodEmpresa.ToString)
        lsMensaje = lsMensaje.Replace("&filename", lsFileName)
        lsMensaje = lsMensaje.Replace("&separador", lsSeparador)
        GPBitacoraRegistrar(sSALIO_, lsMensaje)
    End Sub

End Module