Imports System.ComponentModel
Imports System.Globalization
Public Class frmFe050compras
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "numtransaccion", "timbrado", "prefijo", "tipodocumento", "numdocumento", "coddocumento", "numcompra", "fecoperacion", "fecrendicion", "codmoneda_mo", "cotizacion", "condoperacion", "totexenta_in", "totgrav05_in", "totgrav10_in", "ivagrav05_in", "ivagrav10_in", "totexenta_mo", "totgrav05_mo", "totgrav10_mo", "ivagrav05_mo", "ivagrav10_mo"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msCodMoneda_mb As String = ""
    Private miDecimales_mb As Integer = 0
    Private miDecimales_mo As Integer = 0
    Private msCulture_mb As String = ""
    Private msCulture_mo As String = ""
    Private msPeriodoInicial As String = ""
    Private msPeriodoFinal As String = ""
    Private miDesdeNumero As Integer = 0
    Private miHastaNumero As Integer = 0
    Private msCotizacion As String
    Private miNumCompra As Integer = 0
    Private msAplicacion As String = ""
    Private mdTotExenta As Decimal = 0D
    Private mdTotGrav05 As Decimal = 0D
    Private mdTotGrav10 As Decimal = 0D
    Private mdIvaGrav05 As Decimal = 0D
    Private mdIvaGrav10 As Decimal = 0D
    Private mdTotExenta_mo As Decimal = 0D
    Private mdTotGrav05_mo As Decimal = 0D
    Private mdTotGrav10_mo As Decimal = 0D
    Private mdIvaGrav05_mo As Decimal = 0D
    Private mdIvaGrav10_mo As Decimal = 0D

    Private miLineas As Integer = 0

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LPOperacionCancelada()
    End Sub
    Private Sub LPOperacionCancelada()
        LPBorrarAlCancelar()
        Me.Tag = sCancelar_
        GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en CANCELAR.")
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If InStr(sAGREGAR_ & sMODIFICAR_, Me.Tag.ToString) > 0 Then
            msValidado = GFsValidacionFinal(TabControl1).Split(sSF_)

            If InStr(msValidado(0), sCancelar_) > 0 Then
                GFsAvisar("Validacion final" & ControlChars.CrLf & msValidado(1), sMENSAJE_, "No han sido ingresado correctamente todos los datos")
                txtTimbrado_NE.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ee050compras
                        LPTruncaSegunLongitud()
                        Dim liFactor() As Integer = GFiCotizacion(txtCodMoneda_mo_AN.Text, msCodMoneda_mb, txtFecOperacion_FE.Text)
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.timbrado = txtTimbrado_NE.Text.ToString
                        loDatos.prefijo = txtPrefijo_AN.Text.ToString
                        loDatos.tipodocumento = cmbTipoDocumento.Text.ToString
                        loDatos.numdocumento = txtNumDocumento_SR.Text.ToString
                        loDatos.coddocumento = Integer.Parse(txtCodDocumento_NE.Text.ToString)
                        loDatos.numcompra = Integer.Parse(txtNumCompra_NE.Text)
                        loDatos.fecoperacion = txtFecOperacion_FE.Text.ToString
                        loDatos.fecrendicion = txtFecRendicion_FE.Text.ToString
                        loDatos.codmoneda_mo = txtCodMoneda_mo_AN.Text.ToString
                        loDatos.cotizacion = Integer.Parse(txtCotizacion_NE.Text.ToString)
                        loDatos.condoperacion = cmbCondOperacion.Text.ToString
                        loDatos.totexenta_in = Decimal.Parse(Decimal.Parse(txtTotExenta_in_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.totgrav05_in = Decimal.Parse(Decimal.Parse(txtTotGrav05_in_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.totgrav10_in = Decimal.Parse(Decimal.Parse(txtTotGrav10_in_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.ivagrav05_in = Decimal.Parse(Decimal.Parse(txtIvaGrav05_in_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.ivagrav10_in = Decimal.Parse(Decimal.Parse(txtIvaGrav10_in_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.aplicacion = msAplicacion
                        loDatos.totexenta_in = Decimal.Parse(Decimal.Parse(txtTotExenta_in_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.totexenta_mo = Decimal.Parse(Decimal.Parse(txtTotExenta_mo_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.totgrav05_mo = Decimal.Parse(Decimal.Parse(txtTotGrav05_mo_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.totgrav10_mo = Decimal.Parse(Decimal.Parse(txtTotGrav10_mo_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.ivagrav05_mo = Decimal.Parse(Decimal.Parse(txtIvaGrav05_mo_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.ivagrav10_mo = Decimal.Parse(Decimal.Parse(txtIvaGrav10_mo_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.totexenta_mb = Decimal.Parse(Math.Round(loDatos.totexenta_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                        loDatos.totgrav05_mb = Decimal.Parse(Math.Round(loDatos.totgrav05_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                        loDatos.totgrav10_mb = Decimal.Parse(Math.Round(loDatos.totgrav10_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                        loDatos.ivagrav05_mb = Decimal.Parse(Math.Round(loDatos.ivagrav05_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                        loDatos.ivagrav10_mb = Decimal.Parse(Math.Round(loDatos.ivagrav10_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                        loDatos.estado = sActivo_
                        Try
                            loDatos.Put(sSi_, sSi_, sAGREGAR_)
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                    Case sMODIFICAR_
                        Dim loDatos As New Ee050compras
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                            loDatos.timbrado = txtTimbrado_NE.Text.ToString
                            loDatos.prefijo = txtPrefijo_AN.Text.ToString
                            loDatos.tipodocumento = cmbTipoDocumento.Text.ToString
                            loDatos.numdocumento = txtNumDocumento_SR.Text.ToString
                            loDatos.coddocumento = Integer.Parse(txtCodDocumento_NE.Text.ToString)
                            loDatos.numcompra = Integer.Parse(txtNumCompra_NE.Text)
                            loDatos.fecoperacion = txtFecOperacion_FE.Text.ToString
                            loDatos.fecrendicion = txtFecRendicion_FE.Text.ToString
                            loDatos.codmoneda_mo = txtCodMoneda_mo_AN.Text.ToString
                            loDatos.cotizacion = Integer.Parse(txtCotizacion_NE.Text.ToString)
                            loDatos.condoperacion = cmbCondOperacion.Text.ToString
                            loDatos.aplicacion = msAplicacion
                            loDatos.totexenta_in = Decimal.Parse(Decimal.Parse(txtTotExenta_in_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.totgrav05_in = Decimal.Parse(Decimal.Parse(txtTotGrav05_in_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.totgrav10_in = Decimal.Parse(Decimal.Parse(txtTotGrav10_in_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.ivagrav05_in = Decimal.Parse(Decimal.Parse(txtIvaGrav05_in_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.ivagrav10_in = Decimal.Parse(Decimal.Parse(txtIvaGrav10_in_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.aplicacion = msAplicacion
                            loDatos.totexenta_in = Decimal.Parse(Decimal.Parse(txtTotExenta_in_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.totexenta_mo = Decimal.Parse(Decimal.Parse(txtTotExenta_mo_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.totgrav05_mo = Decimal.Parse(Decimal.Parse(txtTotGrav05_mo_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.totgrav10_mo = Decimal.Parse(Decimal.Parse(txtTotGrav10_mo_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.ivagrav05_mo = Decimal.Parse(Decimal.Parse(txtIvaGrav05_mo_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.ivagrav10_mo = Decimal.Parse(Decimal.Parse(txtIvaGrav10_mo_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.totexenta_mb = Decimal.Parse(Math.Round(loDatos.totexenta_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                            loDatos.totgrav05_mb = Decimal.Parse(Math.Round(loDatos.totgrav05_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                            loDatos.totgrav10_mb = Decimal.Parse(Math.Round(loDatos.totgrav10_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                            loDatos.ivagrav05_mb = Decimal.Parse(Math.Round(loDatos.ivagrav05_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                            loDatos.ivagrav10_mb = Decimal.Parse(Math.Round(loDatos.ivagrav10_mo * loDatos.cotizacion, miDecimales_mb).ToString(sFormatF_))
                            loDatos.estado = sActivo_
                            loDatos.Put()
                        End If
                        loDatos.CerrarConexion()
                End Select
                Me.Tag = sOk_
                '-->  .AccesibleName envia al Browse la información del codigo que luego deberia 
                '-->  ser usado para la localización del registro en el DataGridView
                Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                Me.AccessibleName = liNumTransaccion.ToString
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ee050compras
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                If loDatos.GetPK = sOk_ Then
                    loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                    loDatos.Del()
                End If
                loDatos.CerrarConexion()
                loDatos = Nothing
            Else
                Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                Me.AccessibleName = liNumTransaccion.ToString
            End If
            Me.Tag = sOk_
            GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
            Me.Close()
        End If
    End Sub
    Private Sub ManejoEvento_Validating(sender As Object, e As CancelEventArgs)
        If CType(sender, Control).Text.Trim.Length = 0 Then
            If LFsExiste(CType(sender, Control).AccessibleName) = sNo_ Then Exit Sub
            Dim lsValorInicial As String = ""
            Select Case CType(sender, Control).AccessibleName
                Case "codsucursal"
                    lsValorInicial = "1"
                Case "fecoperacion"
                    lsValorInicial = Today.ToString(sFormatoFecha1_)
                Case "fecrendicion"
                    lsValorInicial = txtFecOperacion_FE.Text.ToString
                Case "codmoneda_mo"
                    lsValorInicial = GFsMonedaBase(Integer.Parse(txtCodEmpresa_NE.Text.ToString))
                Case "condoperacion"
                    lsValorInicial = cmbCondOperacion.Items(0).ToString
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "timbrado"
                    If Not IsNumeric(txtCodEmpresa_NE.Text) Then Exit Sub
                    Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    If liCodEmpresa = 0 Then Exit Sub
                    If Not IsNumeric(txtTimbrado_NE.Text) Then Exit Sub
                    Dim loFK As New Eb080timbotros
                    Dim lsResultado As String
                    loFK.numTimbrado = txtTimbrado_NE.Text.ToString
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBb080timbotros
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtTimbrado_NE.Text = CType(loLookUp.entidad, Eb080timbotros).numTimbrado
                            txtTimbrado_NE.Refresh()
                            cmbTipoDocumento.Text = CType(loLookUp.entidad, Eb080timbotros).tipodocumento
                            cmbTipoDocumento.Refresh()
                            cmbTipoDocumento.Tag = sOk_
                            txtNumDocumento_SR.Text = CType(loLookUp.entidad, Eb080timbotros).nrodocumento
                            txtNumDocumento_SR.Tag = sOk_
                            txtNumDocumento_SR.Refresh()
                            msPeriodoInicial = CType(loLookUp.entidad, Eb080timbotros).valido
                            msPeriodoFinal = CType(loLookUp.entidad, Eb080timbotros).expira
                            cmbTipoDocumento.Enabled = False
                            txtNumDocumento_SR.Enabled = False
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    Else
                        txtTimbrado_NE.Text = loFK.numTimbrado
                        txtTimbrado_NE.Refresh()
                        cmbTipoDocumento.Text = loFK.tipodocumento
                        cmbTipoDocumento.Tag = sOk_
                        cmbTipoDocumento.Refresh()
                        txtNumDocumento_SR.Text = loFK.nrodocumento
                        txtNumDocumento_SR.Tag = sOk_
                        txtNumDocumento_SR.Refresh()
                        msPeriodoInicial = loFK.valido
                        msPeriodoFinal = loFK.expira
                        cmbTipoDocumento.Enabled = False
                        txtNumDocumento_SR.Enabled = False
                        txtPrefijo_AN.Select()
                    End If
                    loFK.CerrarConexion()
                    If txtFecOperacion_FE.Text.Trim.Length > 0 Then
                        If IsDate(txtFecOperacion_FE.Text) Then
                            If Not (txtFecOperacion_FE.Text >= msPeriodoInicial And txtFecOperacion_FE.Text <= msPeriodoFinal) Then
                                Dim loParametros As New Dictionary(Of String, String)
                                loParametros.Add("&fecoperacion", txtFecOperacion_FE.Text.ToString)
                                loParametros.Add("&periodoinicial", msPeriodoInicial)
                                loParametros.Add("&periodofinal", msPeriodoFinal)
                                loParametros.Add("&timbrado", txtTimbrado_NE.Text.ToString)
                                Dim lsMensaje As String = GFsGeneraMSG("msg_frmFe050compras_error_vigencia", loParametros)
                                GFsAvisar(lsMensaje, sMENSAJE_, "Por favor verifique los datos del documento fuente.")
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If
                    End If

                Case "prefijo"
                    If txtPrefijo_AN.Text.Length < txtPrefijo_AN.MaxLength Then
                        GFsAvisar("El prefijo [" & txtPrefijo_AN.Text & "], no tiene la longitud esperada", sMENSAJE_, "Favor intentelo de nuevo.")
                        e.Cancel = True
                        Exit Sub
                    End If
                    If txtPrefijo_AN.Text.Substring(3, 1) <> "-" Then
                        GFsAvisar("El prefijo [" & txtPrefijo_AN.Text & "], no tiene el formato esperado", sMENSAJE_, "Favor intentelo de nuevo.")
                        e.Cancel = True
                        txtPrefijo_AN.Text = "000-000"
                        txtPrefijo_AN.Refresh()
                        Exit Sub
                    End If
                    miDesdeNumero = 0
                    miHastaNumero = 0
                    Dim loPk As New Eb081timbotros
                    loPk.numtimbrado = txtTimbrado_NE.Text
                    loPk.prefijo = txtPrefijo_AN.Text
                    If loPk.GetPK <> sOk_ Then
                        Dim loLookUp As New frmBb081timbotros
                        loLookUp.numTimbrado = txtTimbrado_NE.Text.ToString
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtTimbrado_NE.Text = CType(loLookUp.entidad, Eb081timbotros).numtimbrado
                            txtTimbrado_NE.Refresh()
                            txtTimbrado_NE.Tag = sOk_
                            txtPrefijo_AN.Text = CType(loLookUp.entidad, Eb081timbotros).prefijo
                            txtPrefijo_AN.Refresh()
                            txtPrefijo_AN.Tag = sOk_
                            If CType(loLookUp.entidad, Eb081timbotros).tipo = "Pre-impreso" Then
                                miDesdeNumero = CType(loLookUp.entidad, Eb081timbotros).desdenumero
                                miHastaNumero = CType(loLookUp.entidad, Eb081timbotros).hastanumero
                            End If
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    Else
                        If loPk.tipo = "Pre-impreso" Then
                            miDesdeNumero = loPk.desdenumero
                            miHastaNumero = loPk.hastanumero
                        End If
                    End If
                    loPk.CerrarConexion()

                Case "coddocumento"
                    If Not IsNumeric(txtCodEmpresa_NE.Text) Then Exit Sub
                    Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    If liCodEmpresa = 0 Then Exit Sub

                    If Not IsNumeric(txtCodDocumento_NE.Text) Then Exit Sub
                    Dim liCodDocumento As Integer = Integer.Parse(txtCodDocumento_NE.Text.ToString)
                    If liCodDocumento = 0 Then
                        e.Cancel = True
                        Exit Sub
                    End If

                    Dim lsResultado As String = ""
                    Dim loFK As New Ec020documentos
                    loFK.codempresa = liCodEmpresa
                    loFK.coddocumento = liCodDocumento
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBc020documentos
                        loLookUp.codempresa = liCodEmpresa
                        loLookUp.tipo = sDocTerceros_
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            msCotizacion = CType(loLookUp.entidad, Ec020documentos).cotizacion
                            txtCodDocumento_NE.Text = CType(loLookUp.entidad, Ec020documentos).coddocumento.ToString
                            txtCodMoneda_mo_AN.Text = CType(loLookUp.entidad, Ec020documentos).codmoneda
                            msAplicacion = CType(loLookUp.entidad, Ec020documentos).aplicacion
                            txtCodMoneda_mo_AN.Enabled = False
                            txtCodMoneda_mo_AN.Tag = sOk_
                            msCotizacion = CType(loLookUp.entidad, Ec020documentos).cotizacion
                            miLineas = CType(loLookUp.entidad, Ec020documentos).lineas
                        Else
                            txtCodDocumento_NE.Tag = sCancelar_
                            e.Cancel = True
                            Exit Sub
                        End If
                    Else
                        msAplicacion = loFK.aplicacion
                        If loFK.tipo <> sDocTerceros_ Then
                            Dim loParametros As New Dictionary(Of String, String)
                            loParametros.Add("&coddocumento", txtCodDocumento_NE.Text.ToString)
                            loParametros.Add("&nomdocumento", loFK.nombre)
                            loParametros.Add("&tipo", loFK.tipo)
                            Dim lsMensaje As String = GFsGeneraMSG("msg_e050_error_coddocumento", loParametros)
                            GFsAvisar(lsMensaje, sMENSAJE_, "Favor verifique si corresponder el dato ingresado.")
                            e.Cancel = True
                            Exit Sub
                        End If
                        txtCodMoneda_mo_AN.Text = loFK.codmoneda
                        txtCodMoneda_mo_AN.Enabled = False
                        txtCodMoneda_mo_AN.Tag = sOk_
                        msCotizacion = loFK.cotizacion
                        miLineas = loFK.lineas
                    End If
                    loFK.CerrarConexion()

                    If miLineas > 0 Then
                        txtTotExenta_in_ND.Enabled = False
                        txtTotGrav05_in_ND.Enabled = False
                        txtTotGrav10_in_ND.Enabled = False
                    Else
                        txtTotExenta_in_ND.Enabled = True
                        txtTotGrav05_in_ND.Enabled = True
                        txtTotGrav10_in_ND.Enabled = True
                    End If

                    If txtCodMoneda_mo_AN.Text.Trim.Length > 0 And msCodMoneda_mb.Trim.Length > 0 Then
                        Dim liCotizacion As Integer = GFiCotizacion(txtCodMoneda_mo_AN.Text, msCodMoneda_mb, txtFecOperacion_FE.Text, msCotizacion)
                        If liCotizacion = 0 Then
                            GFsAvisar("No existe cotizacion disponible para [" & txtCodMoneda_mo_AN.Text & " - " & msCodMoneda_mb & "]", sMENSAJE_, "Favor ingrese una cotización con vigencia [" & txtFecOperacion_FE.Text & "]")
                            Dim loFrmCotizacion As New frmBb030cotizaciones
                            GPCargar(loFrmCotizacion)
                            e.Cancel = True
                            Exit Sub
                        Else
                            txtCotizacion_NE.Text = liCotizacion.ToString()
                            txtCotizacion_NE.Enabled = False
                            txtCotizacion_NE.Tag = sOk_
                        End If
                    End If

                Case "numcompra"
                    If miDesdeNumero + miHastaNumero > 0 Then
                        Dim liNumCompra As Integer = Integer.Parse(txtNumCompra_NE.Text.ToString)
                        If Not (liNumCompra >= miDesdeNumero And liNumCompra <= miHastaNumero) Then
                            GFsAvisar("El numero ingresado [" & liNumCompra.ToString(sFormatD_ & txtNumCompra_NE.MaxLength.ToString) & "] no se encuentra dentro del rango definido [" & miDesdeNumero.ToString(sFormatD_ & txtNumCompra_NE.MaxLength.ToString) & "-" & miHastaNumero.ToString(sFormatD_ & txtNumCompra_NE.MaxLength.ToString) & "] para el Timbrado.", sMENSAJE_, "Favor verifique y vuelva a intentarlo.")
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    Dim loE050 As New Ee050compras
                    Dim lsSQL As String = GFsGeneraSQL("e050_ndx_numcompra")
                    lsSQL = lsSQL.Replace("&tipodocumento", cmbTipoDocumento.Text.ToString)
                    lsSQL = lsSQL.Replace("&numdocumento", txtNumDocumento_SR.Text.ToString)
                    lsSQL = lsSQL.Replace("&timbrado", txtTimbrado_NE.Text.ToString)
                    lsSQL = lsSQL.Replace("&prefijo", txtPrefijo_AN.Text.ToString)
                    lsSQL = lsSQL.Replace("&numcompra", txtNumCompra_NE.Text.ToString)

                    If loE050.CantidadRegistro(lsSQL) > 0 Then
                        lsSQL = GFsGeneraSQL("e050_datos_ndx_numcompra")
                        lsSQL = lsSQL.Replace("&tipodocumento", cmbTipoDocumento.Text.ToString)
                        lsSQL = lsSQL.Replace("&numdocumento", txtNumDocumento_SR.Text.ToString)
                        lsSQL = lsSQL.Replace("&timbrado", txtTimbrado_NE.Text.ToString)
                        lsSQL = lsSQL.Replace("&prefijo", txtPrefijo_AN.Text.ToString)
                        lsSQL = lsSQL.Replace("&numcompra", txtNumCompra_NE.Text.ToString)

                        Dim liNumCompra As Integer = Integer.Parse(txtNumCompra_NE.Text.ToString)
                        Dim loParametros As Dictionary(Of String, String) = loE050.RecuperaRegistro(lsSQL)
                        Dim lsMensaje As String = GFsGeneraMSG("msg_frmFe050compras_error_numcompra", loParametros)
                        Select Case Me.Tag.ToString
                            Case sAGREGAR_
                                GFsAvisar(lsMensaje, sMENSAJE_, "Por favor verifique los datos del documento fuente.")
                                e.Cancel = True
                                Exit Sub
                            Case sMODIFICAR_
                                If miNumCompra <> liNumCompra Then
                                    GFsAvisar(lsMensaje, sMENSAJE_, "Por favor verifique los datos del documento fuente.")
                                    e.Cancel = True
                                    Exit Sub
                                End If
                        End Select
                    End If

                Case "fecoperacion"
                    If Not IsDate(txtFecOperacion_FE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtFecOperacion_FE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                        Exit Sub
                    End If
                    If txtFecOperacion_FE.Text > Today.ToString("yyyy-MM-dd") Then
                        GFsAvisar("La fecha de operación no puede ser post-datada", sMENSAJE_, "reintentelo de nuevo")
                        txtFecOperacion_FE.Text = Today.ToString("yyyy-MM-dd")
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim ldFecOperacion As Date = Date.Parse(txtFecOperacion_FE.Text.ToString)
                    txtFecOperacion_FE.Text = ldFecOperacion.ToString(sFormatoFecha1_)
                    If Not (txtFecOperacion_FE.Text >= msPeriodoInicial And txtFecOperacion_FE.Text <= msPeriodoFinal) Then
                        GFsAvisar("La fecha ingresada [" & txtFecOperacion_FE.Text & "] esta fuera del rango del periodo de vigencia del Timbrado No. " & txtTimbrado_NE.Text, sMENSAJE_, "Periodo vigente [" & msPeriodoInicial & " - " & msPeriodoFinal & "]")
                        e.Cancel = True
                        Exit Sub
                    End If

                Case "fecrendicion"
                    If Not IsDate(txtFecRendicion_FE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtFecRendicion_FE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                        Exit Sub
                    Else
                        Dim ldFecRendicion As Date = Date.Parse(txtFecRendicion_FE.Text.ToString)
                        txtFecRendicion_FE.Text = ldFecRendicion.ToString("yyyy-MM-dd")
                    End If

                    If txtFecRendicion_FE.Text < txtFecOperacion_FE.Text Then
                        Dim loParametros As New Dictionary(Of String, String)
                        loParametros.Add("&fecoperacion", txtFecOperacion_FE.Text.ToString)
                        loParametros.Add("&fecrendicion", txtFecRendicion_FE.Text.ToString)
                        Dim lsMensaje As String = GFsGeneraMSG("msg_e050_error_fecrendicion", loParametros)
                        GFsAvisar(lsMensaje, sMENSAJE_, "por favor verifique el dato y vuelta a intentarlo.")
                        e.Cancel = True
                        Exit Sub
                    End If

                Case "codmoneda_mo"
                    Dim loFK As New Ea010monedas
                    Dim lsResultado As String = ""
                    loFK.codMoneda = txtCodMoneda_mo_AN.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    loFK = Nothing
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBa010monedas
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodMoneda_mo_AN.Text = CType(loLookUp.entidad, Ea010monedas).codMoneda
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                        loLookUp = Nothing
                    End If
                    loFK.CerrarConexion()

            End Select
            If CType(sender, Control).Name.Substring(0, 3) = sPrefijoComboBox_ Then
                If CType(sender, ComboBox).Items.Contains(CType(sender, ComboBox).Text) = False Then
                    e.Cancel = True
                    CType(sender, Control).Tag = sCancelar_
                End If
            End If
        End If
        LPDespliegaDescripciones()
    End Sub
    Private Sub ManejoEvento_Validated(sender As Object, e As EventArgs)
        CType(sender, Control).Tag = sOk_
        Select Case CType(sender, Control).Name
        End Select
    End Sub
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles Me.Load
        LPInicializaMaxLength()
        LPInicializaControles()

        ' Inicializa los controles de edición con los valores pertinentes
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        msEntidad = "Compra Bien o Servicio"
        lblTituloImporte.Tag = lblTituloImporte.Text
        lblTituloImporte.Text = LFsTituloImporte("importe")
        DesplegarMensaje()

        lblCotizacion_NE.AutoSize = False
        lblCotizacion_NE.Top = txtCotizacion_NE.Top
        lblCotizacion_NE.Left = txtCotizacion_NE.Left
        lblCotizacion_NE.Width = txtCotizacion_NE.Width
        lblCotizacion_NE.Height = txtCotizacion_NE.Height
        lblCotizacion_NE.TextAlign = ContentAlignment.MiddleRight
        lblCotizacion_NE.Visible = False
        txtCotizacion_NE.TextAlign = HorizontalAlignment.Right

        lblTotExenta_in_ND.AutoSize = False
        lblTotExenta_in_ND.Top = txtTotExenta_in_ND.Top
        lblTotExenta_in_ND.Left = txtTotExenta_in_ND.Left
        lblTotExenta_in_ND.Width = txtTotExenta_in_ND.Width
        lblTotExenta_in_ND.Height = txtTotExenta_in_ND.Height
        lblTotExenta_in_ND.TextAlign = ContentAlignment.MiddleRight
        lblTotExenta_in_ND.Visible = False
        txtTotExenta_in_ND.TextAlign = HorizontalAlignment.Right

        lblTotGrav05_in_ND.AutoSize = False
        lblTotGrav05_in_ND.Top = txtTotGrav05_in_ND.Top
        lblTotGrav05_in_ND.Left = txtTotGrav05_in_ND.Left
        lblTotGrav05_in_ND.Width = txtTotGrav05_in_ND.Width
        lblTotGrav05_in_ND.Height = txtTotGrav05_in_ND.Height
        lblTotGrav05_in_ND.TextAlign = ContentAlignment.MiddleRight
        lblTotGrav05_in_ND.Visible = False
        txtTotGrav05_in_ND.TextAlign = HorizontalAlignment.Right

        lblTotGrav10_in_ND.AutoSize = False
        lblTotGrav10_in_ND.Top = txtTotGrav10_in_ND.Top
        lblTotGrav10_in_ND.Left = txtTotGrav10_in_ND.Left
        lblTotGrav10_in_ND.Width = txtTotGrav10_in_ND.Width
        lblTotGrav10_in_ND.Height = txtTotGrav10_in_ND.Height
        lblTotGrav10_in_ND.TextAlign = ContentAlignment.MiddleRight
        lblTotGrav10_in_ND.Visible = False
        txtTotGrav10_in_ND.TextAlign = HorizontalAlignment.Right

        lblIvaGrav05_in_ND.AutoSize = False
        lblIvaGrav05_in_ND.Top = txtIvaGrav05_in_ND.Top
        lblIvaGrav05_in_ND.Left = txtIvaGrav05_in_ND.Left
        lblIvaGrav05_in_ND.Width = txtIvaGrav05_in_ND.Width
        lblIvaGrav05_in_ND.Height = txtIvaGrav05_in_ND.Height
        lblIvaGrav05_in_ND.TextAlign = ContentAlignment.MiddleRight
        lblIvaGrav05_in_ND.Visible = False
        txtIvaGrav05_in_ND.TextAlign = HorizontalAlignment.Right

        lblIvaGrav10_in_ND.AutoSize = False
        lblIvaGrav10_in_ND.Top = txtIvaGrav10_in_ND.Top
        lblIvaGrav10_in_ND.Left = txtIvaGrav10_in_ND.Left
        lblIvaGrav10_in_ND.Width = txtIvaGrav10_in_ND.Width
        lblIvaGrav10_in_ND.Height = txtIvaGrav10_in_ND.Height
        lblIvaGrav10_in_ND.TextAlign = ContentAlignment.MiddleRight
        lblIvaGrav10_in_ND.Visible = False
        txtIvaGrav10_in_ND.TextAlign = HorizontalAlignment.Right

        lblTotExenta_mo_ND.AutoSize = False
        lblTotExenta_mo_ND.Top = txtTotExenta_mo_ND.Top
        lblTotExenta_mo_ND.Left = txtTotExenta_mo_ND.Left
        lblTotExenta_mo_ND.Width = txtTotExenta_mo_ND.Width
        lblTotExenta_mo_ND.Height = txtTotExenta_mo_ND.Height
        lblTotExenta_mo_ND.TextAlign = ContentAlignment.MiddleRight
        lblTotExenta_mo_ND.Visible = False
        txtTotExenta_mo_ND.TextAlign = HorizontalAlignment.Right

        lblTotGrav05_mo_ND.AutoSize = False
        lblTotGrav05_mo_ND.Top = txtTotGrav05_mo_ND.Top
        lblTotGrav05_mo_ND.Left = txtTotGrav05_mo_ND.Left
        lblTotGrav05_mo_ND.Width = txtTotGrav05_mo_ND.Width
        lblTotGrav05_mo_ND.Height = txtTotGrav05_mo_ND.Height
        lblTotGrav05_mo_ND.TextAlign = ContentAlignment.MiddleRight
        lblTotGrav05_mo_ND.Visible = False
        txtTotGrav05_mo_ND.TextAlign = HorizontalAlignment.Right

        lblTotGrav10_mo_ND.AutoSize = False
        lblTotGrav10_mo_ND.Top = txtTotGrav10_mo_ND.Top
        lblTotGrav10_mo_ND.Left = txtTotGrav10_mo_ND.Left
        lblTotGrav10_mo_ND.Width = txtTotGrav10_mo_ND.Width
        lblTotGrav10_mo_ND.Height = txtTotGrav10_mo_ND.Height
        lblTotGrav10_mo_ND.TextAlign = ContentAlignment.MiddleRight
        lblTotGrav10_mo_ND.Visible = False
        txtTotGrav10_mo_ND.TextAlign = HorizontalAlignment.Right

        lblIvaGrav05_mo_ND.AutoSize = False
        lblIvaGrav05_mo_ND.Top = txtIvaGrav05_mo_ND.Top
        lblIvaGrav05_mo_ND.Left = txtIvaGrav05_mo_ND.Left
        lblIvaGrav05_mo_ND.Width = txtIvaGrav05_mo_ND.Width
        lblIvaGrav05_mo_ND.Height = txtIvaGrav05_mo_ND.Height
        lblIvaGrav05_mo_ND.TextAlign = ContentAlignment.MiddleRight
        lblIvaGrav05_mo_ND.Visible = False
        txtIvaGrav05_mo_ND.TextAlign = HorizontalAlignment.Right

        lblIvaGrav10_mo_ND.AutoSize = False
        lblIvaGrav10_mo_ND.Top = txtIvaGrav10_mo_ND.Top
        lblIvaGrav10_mo_ND.Left = txtIvaGrav10_mo_ND.Left
        lblIvaGrav10_mo_ND.Width = txtIvaGrav10_mo_ND.Width
        lblIvaGrav10_mo_ND.Height = txtIvaGrav10_mo_ND.Height
        lblIvaGrav10_mo_ND.TextAlign = ContentAlignment.MiddleRight
        lblIvaGrav10_mo_ND.Visible = False
        txtIvaGrav10_mo_ND.TextAlign = HorizontalAlignment.Right

        lblTituloSubTotales.Visible = False
        txtIvaGrav05_in_ND.Visible = False
        txtIvaGrav10_in_ND.Visible = False

        lblTituloSubTotalesNeto.Visible = False
        txtIvaGrav05_mo_ND.Visible = False
        txtIvaGrav10_mo_ND.Visible = False

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                txtTotExenta_in_ND.Text = mdTotExenta.ToString(sFormatF_)
                txtTotGrav05_in_ND.Text = mdTotGrav05.ToString(sFormatF_)
                txtTotGrav10_in_ND.Text = mdTotGrav10.ToString(sFormatF_)
                txtIvaGrav05_in_ND.Text = mdIvaGrav05.ToString(sFormatF_)
                txtIvaGrav10_in_ND.Text = mdIvaGrav10.ToString(sFormatF_)
                txtTotExenta_mo_ND.Text = mdTotExenta_mo.ToString(sFormatF_)
                txtTotGrav05_mo_ND.Text = mdTotGrav05_mo.ToString(sFormatF_)
                txtTotGrav10_mo_ND.Text = mdTotGrav10_mo.ToString(sFormatF_)
                txtIvaGrav05_mo_ND.Text = mdIvaGrav05_mo.ToString(sFormatF_)
                txtIvaGrav10_mo_ND.Text = mdIvaGrav10_mo.ToString(sFormatF_)

                Dim loDatos As New Ee050compras
                txtCodEmpresa_NE.Text = CType(entidad, Ee050compras).codempresa.ToString
                txtCodEmpresa_NE.Tag = sOk_
                txtFecOperacion_FE.Text = CType(entidad, Ee050compras).fecoperacion.ToString
                txtFecOperacion_FE.Tag = sOk_
                txtNumTransaccion_NE.Text = loDatos.ReservarRegistro(Integer.Parse(txtCodEmpresa_NE.Text.ToString)).ToString
                txtNumTransaccion_NE.Tag = sOk_
                loDatos.CerrarConexion()

            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ee050compras).codempresa.ToString
                txtNumTransaccion_NE.Text = CType(entidad, Ee050compras).numtransaccion.ToString
                txtTimbrado_NE.Text = CType(entidad, Ee050compras).timbrado.ToString
                cmbTipoDocumento.Text = CType(entidad, Ee050compras).tipodocumento.ToString
                txtNumDocumento_SR.Text = CType(entidad, Ee050compras).numdocumento.ToString
                txtCodDocumento_NE.Text = CType(entidad, Ee050compras).coddocumento.ToString
                txtPrefijo_AN.Text = CType(entidad, Ee050compras).prefijo.ToString
                txtNumCompra_NE.Text = CType(entidad, Ee050compras).numcompra.ToString
                txtFecOperacion_FE.Text = CType(entidad, Ee050compras).fecoperacion
                txtFecRendicion_FE.Text = CType(entidad, Ee050compras).fecrendicion
                txtCodMoneda_mo_AN.Text = CType(entidad, Ee050compras).codmoneda_mo
                txtCotizacion_NE.Text = CType(entidad, Ee050compras).cotizacion.ToString
                cmbCondOperacion.Text = CType(entidad, Ee050compras).condoperacion
                txtTotExenta_in_ND.Text = CType(entidad, Ee050compras).totexenta_in.ToString
                txtTotGrav05_in_ND.Text = CType(entidad, Ee050compras).totgrav05_in.ToString
                txtTotGrav10_in_ND.Text = CType(entidad, Ee050compras).totgrav10_in.ToString
                txtIvaGrav05_in_ND.Text = CType(entidad, Ee050compras).ivagrav05_in.ToString
                txtIvaGrav10_in_ND.Text = CType(entidad, Ee050compras).ivagrav10_in.ToString
                txtTotExenta_mo_ND.Text = CType(entidad, Ee050compras).totexenta_mo.ToString
                txtTotGrav05_mo_ND.Text = CType(entidad, Ee050compras).totgrav05_mo.ToString
                txtTotGrav10_mo_ND.Text = CType(entidad, Ee050compras).totgrav10_mo.ToString
                txtIvaGrav05_mo_ND.Text = CType(entidad, Ee050compras).ivagrav05_mo.ToString
                txtIvaGrav10_mo_ND.Text = CType(entidad, Ee050compras).ivagrav10_mo.ToString

                miNumCompra = Integer.Parse(CType(entidad, Ee050compras).numcompra.ToString)
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Tag = sOk_
                txtTimbrado_NE.Tag = sOk_
                txtPrefijo_AN.Tag = sOk_
                cmbTipoDocumento.Tag = sOk_
                txtNumDocumento_SR.Tag = sOk_
                txtCodDocumento_NE.Tag = sOk_
                txtNumCompra_NE.Tag = sOk_
                txtFecOperacion_FE.Tag = sOk_
                txtFecRendicion_FE.Tag = sOk_
                txtCodMoneda_mo_AN.Tag = sOk_
                txtCotizacion_NE.Tag = sOk_
                cmbCondOperacion.Tag = sOk_
                txtTotExenta_in_ND.Tag = sOk_
                txtTotGrav05_in_ND.Tag = sOk_
                txtTotGrav10_in_ND.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtNumTransaccion_NE.Enabled = True
        txtTimbrado_NE.Enabled = True
        txtPrefijo_AN.Enabled = True
        cmbTipoDocumento.Enabled = True
        txtNumDocumento_SR.Enabled = True
        txtCodDocumento_NE.Enabled = True
        txtNumCompra_NE.Enabled = True
        txtFecOperacion_FE.Enabled = True
        txtFecRendicion_FE.Enabled = True
        txtCodMoneda_mo_AN.Enabled = True
        txtCotizacion_NE.Enabled = True
        cmbCondOperacion.Enabled = True
        txtTotExenta_in_ND.Enabled = True
        txtTotGrav05_in_ND.Enabled = True
        txtTotGrav10_in_ND.Enabled = True
        txtIvaGrav05_in_ND.Enabled = False
        txtIvaGrav10_in_ND.Enabled = False

        txtTotExenta_mo_ND.Enabled = False
        txtTotGrav05_mo_ND.Enabled = False
        txtTotGrav10_mo_ND.Enabled = False
        txtIvaGrav05_mo_ND.Enabled = False
        txtIvaGrav10_mo_ND.Enabled = False
        txtTotalLinea_mo.Enabled = False

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtNumTransaccion_NE.AccessibleName = "numtransaccion"
        txtTimbrado_NE.AccessibleName = "timbrado"
        txtPrefijo_AN.AccessibleName = "prefijo"
        cmbTipoDocumento.AccessibleName = "tipodocumento"
        txtNumDocumento_SR.AccessibleName = "numdocumento"
        txtCodDocumento_NE.AccessibleName = "coddocumento"
        txtNumCompra_NE.AccessibleName = "numcompra"
        txtFecOperacion_FE.AccessibleName = "fecoperacion"
        txtFecRendicion_FE.AccessibleName = "fecrendicion"
        txtCodMoneda_mo_AN.AccessibleName = "codmoneda_mo"
        txtCotizacion_NE.AccessibleName = "cotizacion"
        cmbCondOperacion.AccessibleName = "condoperacion"

        txtTotExenta_in_ND.AccessibleName = "totexenta_in"
        txtTotGrav05_in_ND.AccessibleName = "totgrav05_in"
        txtTotGrav10_in_ND.AccessibleName = "totgrav10_in"
        txtIvaGrav05_in_ND.AccessibleName = "ivagrav05_in"
        txtIvaGrav10_in_ND.AccessibleName = "ivagrav10_in"
        txtTotExenta_mo_ND.AccessibleName = "totexenta_mo"
        txtTotGrav05_mo_ND.AccessibleName = "totgrav05_mo"
        txtTotGrav10_mo_ND.AccessibleName = "totgrav10_mo"
        txtIvaGrav05_mo_ND.AccessibleName = "ivagrav05_mo"
        txtIvaGrav10_mo_ND.AccessibleName = "ivagrav10_mo"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtFecOperacion_FE.Enabled = False
                txtCodDocumento_NE.Select()

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtFecOperacion_FE.Enabled = False
                cmbTipoDocumento.Enabled = False
                txtNumDocumento_SR.Enabled = False
                txtCodMoneda_mo_AN.Enabled = False
                txtCodDocumento_NE.Select()

            Case sCONSULTAR_, sBORRAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.Substring(0, 3)) > 0 Then
                        loControls.Item(liNDX).Enabled = False
                    End If
                Next
                loControls = Me.TabPage2.Controls
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.Substring(0, 3)) > 0 Then
                        loControls.Item(liNDX).Enabled = False
                    End If
                Next
        End Select
    End Sub
    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LPDespliegaDescripciones()
    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer = 0
        Dim liCodDocumento As Integer
        Dim liNumTransaccion As Integer
        Dim lsNomMoneda_mo As String = ""
        Dim lsAplicacion As String = ""
        Dim liCantLineas As Integer = 0

        liNumTransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        txtNumTransaccion_NE.Text = liNumTransaccion.ToString(sFormatD_ & txtNumTransaccion_NE.MaxLength.ToString)

        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If Not IsNumeric(txtCodEmpresa_NE.Text) Then Exit Sub
            liCodEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

            Dim loFK As New Ec001empresas
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loFK.nombre
                msCodMoneda_mb = loFK.codMoneda
                Dim loFK1 As New Ea010monedas
                loFK1.codMoneda = msCodMoneda_mb
                If loFK1.GetPK = sOk_ Then
                    miDecimales_mb = loFK1.decimales
                    msCulture_mb = loFK1.culture
                End If
            End If
            loFK.CerrarConexion()
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString)
        End If
        lblRazonSocial.Text = ""
        If cmbTipoDocumento.Text.Trim.Length > 0 And txtNumDocumento_SR.Text.Trim.Length > 0 Then
            Dim loFK As New Ea030personas
            loFK.tipoDocumento = cmbTipoDocumento.Text
            loFK.nroDocumento = txtNumDocumento_SR.Text
            If loFK.GetPK = sOk_ Then
                lblRazonSocial.Text = loFK.abreviado
            End If
            loFK.CerrarConexion()
        End If
        lblNomDocumento.Text = ""
        If txtCodDocumento_NE.Text.Trim.Length > 0 Then
            If Not IsNumeric(txtCodDocumento_NE.Text) Then Exit Sub
            liCodDocumento = Integer.Parse(txtCodDocumento_NE.Text.ToString)
            If liCodDocumento = 0 Then Exit Sub

            Dim loFK As New Ec020documentos
            loFK.codempresa = liCodEmpresa
            loFK.coddocumento = liCodDocumento
            If loFK.GetPK = sOk_ Then
                lblNomDocumento.Text = loFK.nombre
                msCotizacion = loFK.cotizacion
                lsAplicacion = loFK.aplicacion
                liCantLineas = loFK.lineas
            End If
            loFK.CerrarConexion()
            txtCodDocumento_NE.Text = liCodDocumento.ToString(sFormatD_ & txtCodDocumento_NE.MaxLength.ToString)
        End If
        lblNomMoneda.Text = ""
        lblCodMoneda_mo.Text = ""
        If txtCodMoneda_mo_AN.Text.Trim.Length > 0 Then
            lblCodMoneda_mo.Text = "/" & txtCodMoneda_mo_AN.Text
            Dim loFK1 As New Ea010monedas
            loFK1.codMoneda = txtCodMoneda_mo_AN.Text
            If loFK1.GetPK = sOk_ Then
                lblNomMoneda.Text = loFK1.nombre
                lsNomMoneda_mo = loFK1.nombre
                miDecimales_mo = loFK1.decimales
                msCulture_mo = loFK1.culture
            End If
            loFK1.CerrarConexion()
        End If
        Dim ldValor As Decimal
        If lsAplicacion = sLinea_ Then
            lblTituloImporte.Text = LFsTituloImporte("importe(IVA incluido) en " & lsNomMoneda_mo.Trim)
        Else
            lblTituloImporte.Text = LFsTituloImporte("importe en " & lsNomMoneda_mo.Trim)
        End If
        lblTituloImporteNeto.Text = LFsTituloImporte("importe neto en " & lsNomMoneda_mo.Trim)

        lblNumComprobante.Text = ""
        If txtPrefijo_AN.Text.Trim.Length > 0 And txtNumCompra_NE.Text.Trim.Length > 0 Then
            If IsNumeric(txtNumCompra_NE.Text) Then
                Dim liNumCompra As Integer = Integer.Parse(txtNumCompra_NE.Text.ToString)
                lblNumComprobante.Text = txtPrefijo_AN.Text.Trim & "-" & liNumCompra.ToString(sFormatD_ & "7")
                txtNumCompra_NE.Text = liNumCompra.ToString(sFormatD_ & txtNumCompra_NE.MaxLength.ToString)
            End If
        End If
        If txtCotizacion_NE.Text.Trim.Length > 0 Then
            If IsNumeric(txtCotizacion_NE.Text) Then
                ldValor = Decimal.Parse(txtCotizacion_NE.Text)
                lblCotizacion_NE.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblCotizacion_NE.Visible = True
            End If
        End If
        If txtTotExenta_in_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotExenta_in_ND.Text) Then
                ldValor = Decimal.Parse(txtTotExenta_in_ND.Text)
                mdTotExenta = ldValor
                lblTotExenta_in_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblTotExenta_in_ND.Visible = True
            End If
        End If
        If txtTotGrav05_in_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotGrav05_in_ND.Text) Then
                ldValor = Decimal.Parse(txtTotGrav05_in_ND.Text)
                mdTotGrav05 = ldValor
                lblTotGrav05_in_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblTotGrav05_in_ND.Visible = True
            End If
        End If
        If txtTotGrav10_in_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotGrav10_in_ND.Text) Then
                ldValor = Decimal.Parse(txtTotGrav10_in_ND.Text)
                mdTotGrav10 = ldValor
                lblTotGrav10_in_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblTotGrav10_in_ND.Visible = True
            End If
        End If
        If txtTotGrav05_in_ND.Text.Trim.Length > 0 Then
            Select Case msAplicacion
                Case sTotales_
                    mdIvaGrav05 = Math.Round(mdTotGrav05 * 0.05D, miDecimales_mo)
                    txtIvaGrav05_in_ND.Text = mdIvaGrav05.ToString(sFormatF_)
            End Select
        End If
        If txtTotGrav10_in_ND.Text.Trim.Length > 0 Then
            Select Case msAplicacion
                Case sTotales_
                    mdIvaGrav10 = Math.Round(mdTotGrav10 * 0.1D, miDecimales_mo)
                    txtIvaGrav10_in_ND.Text = mdIvaGrav10.ToString(sFormatF_)
            End Select
        End If
        If txtIvaGrav05_in_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtIvaGrav05_in_ND.Text) Then
                ldValor = Decimal.Parse(txtIvaGrav05_in_ND.Text)
                mdIvaGrav05 = ldValor
                lblIvaGrav05_in_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblIvaGrav05_in_ND.Visible = True
            End If
        End If
        If txtIvaGrav10_in_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtIvaGrav10_in_ND.Text) Then
                ldValor = Decimal.Parse(txtIvaGrav10_in_ND.Text)
                mdIvaGrav10 = ldValor
                lblIvaGrav10_in_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblIvaGrav10_in_ND.Visible = True
            End If
        End If
        Dim ldTotalLinea As Decimal = mdTotExenta + mdTotGrav05 + mdTotGrav10 + mdIvaGrav05 + mdIvaGrav10
        txtTotalLinea.Text = ldTotalLinea.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
        Select Case Me.Tag.ToString
            Case sAGREGAR_, sMODIFICAR_
                lblCotizacion_NE.BackColor = txtCotizacion_NE.BackColor
                lblTotExenta_in_ND.BackColor = txtTotExenta_in_ND.BackColor
                lblTotGrav05_in_ND.BackColor = txtTotGrav05_in_ND.BackColor
                lblTotGrav10_in_ND.BackColor = txtTotGrav10_in_ND.BackColor
            Case sCONSULTAR_, sBORRAR_
                lblCotizacion_NE.BackColor = Me.BackColor
                lblTotExenta_in_ND.BackColor = Me.BackColor
                lblTotGrav05_in_ND.BackColor = Me.BackColor
                lblTotGrav10_in_ND.BackColor = Me.BackColor
                lblCotizacion_NE.ForeColor = Me.ForeColor
                lblTotExenta_in_ND.ForeColor = Me.ForeColor
                lblTotGrav05_in_ND.ForeColor = Me.ForeColor
                lblTotGrav10_in_ND.ForeColor = Me.ForeColor
        End Select
        If txtTotExenta_in_ND.Text.Trim.Length > 0 Then
            mdTotExenta_mo = mdTotExenta
        End If
        If txtTotGrav05_in_ND.Text.Trim.Length > 0 Then
            Select Case msAplicacion
                Case sLinea_
                    mdTotGrav05_mo = Math.Round((mdTotGrav05 * 100D) / 105D, miDecimales_mo)
                    mdIvaGrav05_mo = Math.Round(mdTotGrav05 - mdTotGrav05_mo, miDecimales_mo)
                Case sTotales_
                    mdTotGrav05_mo = mdTotGrav05
                    mdIvaGrav05_mo = Math.Round(mdTotGrav05_mo * 0.05D, miDecimales_mo)
            End Select
        End If
        If txtTotGrav10_in_ND.Text.Trim.Length > 0 Then
            Select Case msAplicacion
                Case sLinea_
                    mdTotGrav10_mo = Math.Round((mdTotGrav10 * 100D) / 110D, miDecimales_mo)
                    mdIvaGrav10_mo = Math.Round(mdTotGrav10 - mdTotGrav10_mo, miDecimales_mo)
                Case sTotales_
                    mdTotGrav10_mo = mdTotGrav10
                    mdIvaGrav10_mo = Math.Round(mdTotGrav10_mo * 0.1D, miDecimales_mo)
            End Select
        End If
        If Me.Tag.ToString = sAGREGAR_ Then
            txtTotExenta_mo_ND.Text = mdTotExenta_mo.ToString(sFormatF_)
            txtTotGrav05_mo_ND.Text = mdTotGrav05_mo.ToString(sFormatF_)
            txtTotGrav10_mo_ND.Text = mdTotGrav10_mo.ToString(sFormatF_)
            txtIvaGrav05_mo_ND.Text = mdIvaGrav05_mo.ToString(sFormatF_)
            txtIvaGrav10_mo_ND.Text = mdIvaGrav10_mo.ToString(sFormatF_)
        End If

        If txtTotExenta_mo_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotExenta_mo_ND.Text) Then
                ldValor = Decimal.Parse(txtTotExenta_mo_ND.Text)
                mdTotExenta_mo = ldValor
                lblTotExenta_mo_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblTotExenta_mo_ND.Visible = True
            End If
        End If
        If txtTotGrav05_mo_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotGrav05_mo_ND.Text) Then
                ldValor = Decimal.Parse(txtTotGrav05_mo_ND.Text)
                mdTotGrav05_mo = ldValor
                lblTotGrav05_mo_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblTotGrav05_mo_ND.Visible = True
            End If
        End If
        If txtTotGrav10_mo_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotGrav10_mo_ND.Text) Then
                ldValor = Decimal.Parse(txtTotGrav10_mo_ND.Text)
                mdTotGrav10_mo = ldValor
                lblTotGrav10_mo_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblTotGrav10_mo_ND.Visible = True
            End If
        End If
        If txtIvaGrav05_mo_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtIvaGrav05_mo_ND.Text) Then
                ldValor = Decimal.Parse(txtIvaGrav05_mo_ND.Text)
                mdIvaGrav05_mo = ldValor
                lblIvaGrav05_mo_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblIvaGrav05_mo_ND.Visible = True
            End If
        End If
        If txtIvaGrav10_mo_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtIvaGrav10_mo_ND.Text) Then
                ldValor = Decimal.Parse(txtIvaGrav10_mo_ND.Text)
                mdIvaGrav10_mo = ldValor
                lblIvaGrav10_mo_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblIvaGrav10_mo_ND.Visible = True
            End If
        End If
        Dim ldTotalLinea_mo As Decimal = mdTotExenta_mo + mdTotGrav05_mo + mdTotGrav10_mo + mdIvaGrav05_mo + mdIvaGrav10_mo
        txtTotalLinea_mo.Text = ldTotalLinea_mo.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
        Me.Refresh()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtNumTransaccion_NE.MaxLength = 6
        txtTimbrado_NE.MaxLength = 8
        txtPrefijo_AN.MaxLength = 7
        cmbTipoDocumento.MaxLength = 15
        txtNumDocumento_SR.MaxLength = 15
        txtCodDocumento_NE.MaxLength = 3
        txtNumCompra_NE.MaxLength = 7
        txtFecOperacion_FE.MaxLength = 10
        txtFecRendicion_FE.MaxLength = 10
        txtCodMoneda_mo_AN.MaxLength = 3
        txtCotizacion_NE.MaxLength = 6
        cmbCondOperacion.MaxLength = 15
        txtTotExenta_in_ND.MaxLength = 17
        txtTotGrav05_in_ND.MaxLength = 17
        txtTotGrav10_in_ND.MaxLength = 17
        txtIvaGrav05_in_ND.MaxLength = 17
        txtIvaGrav10_in_ND.MaxLength = 17
    End Sub
    Private Sub LPInicializaControles()
        For Each loTabPage As TabPage In TabControl1.TabPages
            If loTabPage.AccessibleName = sActivo_ Then
                For Each loControl As Control In loTabPage.Controls
                    loControl.Tag = sCancelar_
                    Select Case loControl.Name.Substring(0, 3)
                        Case sPrefijoTextBox_
                            AddHandler loControl.Validating, AddressOf ManejoEvento_Validating
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                            AddHandler loControl.KeyPress, AddressOf ManejoEvento_KeyPress
                            AddHandler loControl.Click, AddressOf TextBox_Click
                        Case sPrefijoComboBox_
                            AddHandler loControl.Validating, AddressOf ManejoEvento_Validating
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                        Case sPrefijoRadioButton_
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                        Case sPrefijoGroupBox_
                            For Each loControl1 As Control In loControl.Controls
                                loControl1.Tag = sCancelar_
                                Select Case loControl1.Name.Substring(0, 3)
                                    Case sPrefijoTextBox_
                                        AddHandler loControl1.Validating, AddressOf ManejoEvento_Validating
                                        AddHandler loControl1.Validated, AddressOf ManejoEvento_Validated
                                        AddHandler loControl1.KeyDown, AddressOf ManejoEvento_KeyDown
                                        AddHandler loControl1.KeyPress, AddressOf ManejoEvento_KeyPress
                                        AddHandler loControl1.Click, AddressOf TextBox_Click
                                    Case sPrefijoComboBox_
                                        AddHandler loControl.Validating, AddressOf ManejoEvento_Validating
                                        AddHandler loControl1.Validated, AddressOf ManejoEvento_Validated
                                        AddHandler loControl1.KeyDown, AddressOf ManejoEvento_KeyDown
                                    Case sPrefijoRadioButton_
                                        AddHandler loControl1.Validated, AddressOf ManejoEvento_Validated
                                        AddHandler loControl1.KeyDown, AddressOf ManejoEvento_KeyDown
                                End Select
                            Next
                    End Select
                Next
            End If
        Next
        AddHandler btnSiguiente.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler btnAnterior.KeyPress, AddressOf ManejoEvento_KeyPress
    End Sub
    Private Function LFsExiste(ByVal psCampo As String) As String
        Dim lsResultado As String = sNo_
        For Each lsCampo As String In moRequeridos
            If psCampo = lsCampo Then
                lsResultado = sSi_
                Exit For
            End If
        Next
        Return lsResultado
    End Function
    Private Sub LPBorrarAlCancelar()
        If Me.Tag.ToString <> sAGREGAR_ Then Exit Sub

        Dim loDatos As New Ee050compras
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        loDatos.codempresa = liCodEmpresa
        loDatos.numtransaccion = liNumTransaccion
        If loDatos.GetPK = sOk_ Then
            loDatos.codempresa = liCodEmpresa
            loDatos.numtransaccion = liNumTransaccion
            loDatos.Del(sNo_, sNo_)
        End If
        loDatos.CerrarConexion()
        loDatos = Nothing
    End Sub
    Private Sub TextBox_Click(sender As Object, e As EventArgs)
        CType(sender, TextBox).SelectAll()
    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub
    Private Sub lblCotizacion_NE_Click(sender As Object, e As EventArgs) Handles lblCotizacion_NE.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCotizacion_NE.Visible = False
        txtCotizacion_NE.Focus()
        txtCotizacion_NE.SelectAll()
    End Sub
    Private Sub txtCotizacion_NE_GotFocus(sender As Object, e As EventArgs) Handles txtCotizacion_NE.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCotizacion_NE.Visible = False
        txtCotizacion_NE.Focus()
        txtCotizacion_NE.SelectAll()
    End Sub
    Private Sub lblImpBruto_mo_ND_Click(sender As Object, e As EventArgs) Handles lblTotExenta_in_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        If miLineas > 0 Then Exit Sub
        lblTotExenta_in_ND.Visible = False
        txtTotExenta_in_ND.Focus()
        txtTotExenta_in_ND.SelectAll()
    End Sub
    Private Sub txtImpBruto_mo_ND_GotFocus(sender As Object, e As EventArgs) Handles txtTotExenta_in_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        If miLineas > 0 Then Exit Sub
        lblTotExenta_in_ND.Visible = False
        txtTotExenta_in_ND.Focus()
        txtTotExenta_in_ND.SelectAll()
    End Sub
    Private Sub lblImpNeto_mo_ND_Click(sender As Object, e As EventArgs) Handles lblTotGrav05_in_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        If miLineas > 0 Then Exit Sub
        lblTotGrav05_in_ND.Visible = False
        txtTotGrav05_in_ND.Focus()
        txtTotGrav05_in_ND.SelectAll()
    End Sub
    Private Sub txtImpNeto_mo_ND_GotFocus(sender As Object, e As EventArgs) Handles txtTotGrav05_in_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        If miLineas > 0 Then Exit Sub
        lblTotGrav05_in_ND.Visible = False
        txtTotGrav05_in_ND.Focus()
        txtTotGrav05_in_ND.SelectAll()
    End Sub
    Private Sub lblImpuesto_mo_ND_Click(sender As Object, e As EventArgs) Handles lblTotGrav10_in_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        If miLineas > 0 Then Exit Sub
        lblTotGrav10_in_ND.Visible = False
        txtTotGrav10_in_ND.Focus()
        txtTotGrav10_in_ND.SelectAll()
    End Sub
    Private Sub txtImpuesto_mo_ND_GotFocus(sender As Object, e As EventArgs) Handles txtTotGrav10_in_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        If miLineas > 0 Then Exit Sub
        lblTotGrav10_in_ND.Visible = False
        txtTotGrav10_in_ND.Focus()
        txtTotGrav10_in_ND.SelectAll()
    End Sub
    Private Function LFsTituloImporte(ByVal psTitulo As String) As String
        Dim lsResultado As String
        Dim lsSeparador As String = lblTituloImporte.Tag.ToString
        Dim liLongNeto As Integer = lsSeparador.Trim.Length - psTitulo.Trim.Length
        Dim liLongitud As Integer = liLongNeto \ 2
        Dim lsLadoIzquierdo As String = lsSeparador.Substring(0, liLongitud)
        Dim lsLadoDerecho As String = lsSeparador.Substring(0, liLongNeto - liLongitud)
        lsResultado = lsLadoIzquierdo & psTitulo.ToLower & lsLadoDerecho
        Return lsResultado
    End Function
End Class