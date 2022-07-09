Imports System.Globalization
Imports System.ComponentModel
Public Class frmFe051compras
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "numtransaccion", "numorden", "codmercaderia", "nommercaderia", "codunidad", "cantcompra", "cantcompra_real", "precunitario_mo"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msCodMoneda_mb As String = ""
    Private miDecimales_mb As Integer
    Private msCulture_mb As String
    Private msCodMoneda_mo As String = ""
    Private miDecimales_mo As Integer = 0
    Private msCulture_mo As String = ""
    Private msCodUnidad As String = ""
    Private msAplicacion As String = ""
    Private msIva As String = ""
    Private mdCantidad As Decimal = 0D
    Private msFecOperacion As String = ""
    Private miCotizacion As Integer = 0
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
                txtCodMercaderia_AN.Select()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ee051compras
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text.ToString
                        loDatos.nommercaderia = lblNomMercaderia.Text.ToString
                        loDatos.codunidad = txtCodUnidad_AN.Text.ToString
                        loDatos.cantcompra = Decimal.Parse(Decimal.Parse(txtCantCompra_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.cantcompra_real = Math.Round(loDatos.cantcompra * mdCantidad, iCantDecimal_)
                        loDatos.precunitario_in = Decimal.Parse(Decimal.Parse(txtPrecUnitario_in_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.imptotal_in = Decimal.Parse(Math.Round(loDatos.cantcompra * loDatos.precunitario_in, miDecimales_mo).ToString(sFormatF_))
                        loDatos.precunitario_mo = loDatos.precunitario_in
                        loDatos.iva = msIva
                        Select Case msAplicacion
                            Case sLinea_
                                Select Case msIva
                                    Case sGravada05_
                                        loDatos.precunitario_mo = Decimal.Parse(Math.Round((loDatos.precunitario_in * d100_) / d105_, miDecimales_mo).ToString(sFormatF_))
                                    Case sGravada10_
                                        loDatos.precunitario_mo = Decimal.Parse(Math.Round((loDatos.precunitario_in * d100_) / d110_, miDecimales_mo).ToString(sFormatF_))
                                End Select
                                loDatos.precunitaiva_mo = loDatos.precunitario_in - loDatos.precunitario_mo
                            Case sTotales_
                                Select Case msIva
                                    Case sGravada05_
                                        loDatos.precunitaiva_mo = Decimal.Parse(Math.Round(loDatos.precunitario_in * d005_, miDecimales_mo).ToString(sFormatF_))
                                    Case sGravada10_
                                        loDatos.precunitaiva_mo = Decimal.Parse(Math.Round(loDatos.precunitario_in * d010_, miDecimales_mo).ToString(sFormatF_))
                                End Select
                        End Select
                        loDatos.precunitario_mb = Decimal.Parse(Math.Round(loDatos.precunitario_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                        loDatos.precunitaiva_mb = Decimal.Parse(Math.Round(loDatos.precunitaiva_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                        loDatos.impexenta_mo = 0.00D
                        loDatos.impexenta_mb = 0.00D
                        loDatos.impgrav05_mo = 0.00D
                        loDatos.impgrav05_mb = 0.00D
                        loDatos.impgrav10_mo = 0.00D
                        loDatos.impgrav10_mb = 0.00D
                        loDatos.ivagrav05_mo = 0.00D
                        loDatos.ivagrav05_mb = 0.00D
                        loDatos.ivagrav10_mo = 0.00D
                        loDatos.ivagrav10_mb = 0.00D
                        Select Case msIva
                            Case sExenta_
                                loDatos.impexenta_mo = loDatos.imptotal_in
                                loDatos.impexenta_mb = Decimal.Parse(Math.Round(loDatos.impexenta_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                            Case sGravada05_
                                loDatos.impgrav05_mo = Decimal.Parse(Math.Round(loDatos.cantcompra * loDatos.precunitario_mo, miDecimales_mb).ToString(sFormatF_))
                                loDatos.impgrav05_mb = Decimal.Parse(Math.Round(loDatos.impgrav05_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                                loDatos.ivagrav05_mo = Decimal.Parse(Math.Round((loDatos.cantcompra * loDatos.precunitario_in) - loDatos.impgrav05_mo, miDecimales_mb).ToString(sFormatF_))
                                loDatos.ivagrav05_mb = Decimal.Parse(Math.Round(loDatos.ivagrav05_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                            Case sGravada10_
                                loDatos.impgrav10_mo = Decimal.Parse(Math.Round(loDatos.cantcompra * loDatos.precunitario_mo, miDecimales_mb).ToString(sFormatF_))
                                loDatos.impgrav10_mb = Decimal.Parse(Math.Round(loDatos.impgrav10_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                                loDatos.ivagrav10_mo = Decimal.Parse(Math.Round((loDatos.cantcompra * loDatos.precunitario_in) - loDatos.impgrav10_mo, miDecimales_mb).ToString(sFormatF_))
                                loDatos.ivagrav10_mb = Decimal.Parse(Math.Round(loDatos.ivagrav10_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                        End Select
                        loDatos.estado = sActivo_
                        Try
                            loDatos.Put(sSi_, sSi_, sAGREGAR_)
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                    Case sMODIFICAR_
                        Dim loDatos As New Ee051compras
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                            loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                            loDatos.codmercaderia = txtCodMercaderia_AN.Text.ToString
                            loDatos.nommercaderia = lblNomMercaderia.Text.ToString
                            loDatos.codunidad = txtCodUnidad_AN.Text.ToString
                            loDatos.cantcompra = Decimal.Parse(Decimal.Parse(txtCantCompra_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.cantcompra_real = Math.Round(loDatos.cantcompra * mdCantidad, iCantDecimal_)
                            loDatos.precunitario_in = Decimal.Parse(Decimal.Parse(txtPrecUnitario_in_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.imptotal_in = Decimal.Parse(Math.Round(loDatos.cantcompra * loDatos.precunitario_in, miDecimales_mo).ToString(sFormatF_))
                            loDatos.precunitario_mo = loDatos.precunitario_in
                            loDatos.iva = msIva
                            Select Case msAplicacion
                                Case sLinea_
                                    Select Case msIva
                                        Case sGravada05_
                                            loDatos.precunitario_mo = Decimal.Parse(Math.Round((loDatos.precunitario_in * d100_) / d105_, miDecimales_mo).ToString(sFormatF_))
                                        Case sGravada10_
                                            loDatos.precunitario_mo = Decimal.Parse(Math.Round((loDatos.precunitario_in * d100_) / d110_, miDecimales_mo).ToString(sFormatF_))
                                    End Select
                                    loDatos.precunitaiva_mo = loDatos.precunitario_in - loDatos.precunitario_mo
                                Case sTotales_
                                    Select Case msIva
                                        Case sGravada05_
                                            loDatos.precunitaiva_mo = Decimal.Parse(Math.Round(loDatos.precunitario_in * d005_, miDecimales_mo).ToString(sFormatF_))
                                        Case sGravada10_
                                            loDatos.precunitaiva_mo = Decimal.Parse(Math.Round(loDatos.precunitario_in * d010_, miDecimales_mo).ToString(sFormatF_))
                                    End Select
                            End Select
                            loDatos.precunitario_mb = Decimal.Parse(Math.Round(loDatos.precunitario_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                            loDatos.precunitaiva_mb = Decimal.Parse(Math.Round(loDatos.precunitaiva_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                            loDatos.impexenta_mo = 0.00D
                            loDatos.impexenta_mb = 0.00D
                            loDatos.impgrav05_mo = 0.00D
                            loDatos.impgrav05_mb = 0.00D
                            loDatos.impgrav10_mo = 0.00D
                            loDatos.impgrav10_mb = 0.00D
                            loDatos.ivagrav05_mo = 0.00D
                            loDatos.ivagrav05_mb = 0.00D
                            loDatos.ivagrav10_mo = 0.00D
                            loDatos.ivagrav10_mb = 0.00D
                            Select Case msIva
                                Case sExenta_
                                    loDatos.impexenta_mo = loDatos.imptotal_in
                                    loDatos.impexenta_mb = Decimal.Parse(Math.Round(loDatos.impexenta_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                                Case sGravada05_
                                    loDatos.impgrav05_mo = Decimal.Parse(Math.Round(loDatos.cantcompra * loDatos.precunitario_mo, miDecimales_mb).ToString(sFormatF_))
                                    loDatos.impgrav05_mb = Decimal.Parse(Math.Round(loDatos.impgrav05_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                                    loDatos.ivagrav05_mo = Decimal.Parse(Math.Round((loDatos.cantcompra * loDatos.precunitario_in) - loDatos.impgrav05_mo, miDecimales_mb).ToString(sFormatF_))
                                    loDatos.ivagrav05_mb = Decimal.Parse(Math.Round(loDatos.ivagrav05_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                                Case sGravada10_
                                    loDatos.impgrav10_mo = Decimal.Parse(Math.Round(loDatos.cantcompra * loDatos.precunitario_mo, miDecimales_mb).ToString(sFormatF_))
                                    loDatos.impgrav10_mb = Decimal.Parse(Math.Round(loDatos.impgrav10_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                                    loDatos.ivagrav10_mo = Decimal.Parse(Math.Round((loDatos.cantcompra * loDatos.precunitario_in) - loDatos.impgrav10_mo, miDecimales_mb).ToString(sFormatF_))
                                    loDatos.ivagrav10_mb = Decimal.Parse(Math.Round(loDatos.ivagrav10_mo * miCotizacion, miDecimales_mb).ToString(sFormatF_))
                            End Select
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
                Dim loDatos As New Ee051compras
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                If loDatos.GetPK = sOk_ Then
                    loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                    loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                    loDatos.Del()
                End If
                loDatos.CerrarConexion()
                loDatos = Nothing
            Else
                Dim liNumOrden As Integer = Integer.Parse(txtNumOrden_NE.Text.ToString)
                Me.AccessibleName = liNumOrden.ToString
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
                Case "codunidad"
                    lsValorInicial = msCodUnidad
                Case "cantcompra"
                    lsValorInicial = "1"
                Case "precunitario_in"
                    lsValorInicial = "0"
                Case "imptotal_in"
                    lsValorInicial = "0"
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codmercaderia"
                    Dim loFK As New Ed020mercentrada
                    Dim lsResultado As String

                    loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.codmercaderia = txtCodMercaderia_AN.Text.ToString
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBd020mercentrada
                        loLookUp.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodMercaderia_AN.Text = CType(loLookUp.entidad, Ed020mercentrada).codmercaderia
                            msIva = CType(loLookUp.entidad, Ed020mercentrada).iva
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    Else
                        msIva = loFK.iva
                    End If
                    txtCodMercaderia_AN.Tag = sOk_
                    loFK.CerrarConexion()

                Case "codunidad"
                    Dim loFK As New Eb110undalternativas
                    Dim lsResultado As String
                    loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.tipo = sEntrada_
                    loFK.codmercaderia = txtCodMercaderia_AN.Text.ToString
                    loFK.codunidad = txtCodUnidad_AN.Text.ToString
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBb110undalternativas
                        loLookUp.Tag = sELEGIR_
                        loLookUp.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.tipo = sEntrada_
                        loLookUp.codmercaderia = txtCodMercaderia_AN.Text.ToString
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodUnidad_AN.Text = CType(loLookUp.entidad, Eb110undalternativas).codunidad
                            mdCantidad = CType(loLookUp.entidad, Eb110undalternativas).cantidad
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    Else
                        mdCantidad = loFK.cantidad
                    End If
                    txtCodUnidad_AN.Tag = sOk_
                    loFK.CerrarConexion()

                Case "precunitario_in"
                    If Not IsNumeric(txtPrecUnitario_in_ND.Text.ToString) Then
                        GFsAvisar("El valor a ingresar debe ser numerico", sMENSAJE_, "Por favor corrija y vuelva intentarlo")
                        e.Cancel = True
                        Exit Sub
                    End If
                    If Decimal.Parse(txtPrecUnitario_in_ND.Text.ToString) > 0D Then
                        txtImpTotal_in_ND.Text = Math.Round(Decimal.Parse(txtCantCompra_ND.Text.ToString) * Decimal.Parse(txtPrecUnitario_in_ND.Text.ToString), miDecimales_mo).ToString(sFormatF_)
                        txtImpTotal_in_ND.Tag = sOk_
                        txtImpTotal_in_ND.Enabled = True
                    Else
                        If Decimal.Parse(txtImpTotal_in_ND.Text.ToString) = 0D Then
                            txtImpTotal_in_ND.Enabled = False
                            txtImpTotal_in_ND.Tag = sCancelar_
                            txtPrecUnitario_in_ND.Select()
                            e.Cancel = True
                            Exit Sub
                        End If
                        txtImpTotal_in_ND.Enabled = True
                        txtImpTotal_in_ND.Select()
                    End If
                Case "imptotal_in"
                    If Not IsNumeric(txtImpTotal_in_ND.Text.ToString) Then
                        GFsAvisar("El valor a ingresar debe ser numerico", sMENSAJE_, "Por favor corrija y vuelva intentarlo")
                        e.Cancel = True
                        Exit Sub
                    End If
                    If Decimal.Parse(txtImpTotal_in_ND.Text.ToString) > 0D Then
                        txtPrecUnitario_in_ND.Text = Math.Round(Decimal.Parse(txtImpTotal_in_ND.Text.ToString) / Decimal.Parse(txtCantCompra_ND.Text.ToString), miDecimales_mo).ToString(sFormatF_)
                        txtPrecUnitario_in_ND.Enabled = True
                        txtPrecUnitario_in_ND.Tag = sOk_
                    Else
                        txtImpTotal_in_ND.Tag = sCancelar_
                        txtPrecUnitario_in_ND.Tag = sCancelar_
                        txtPrecUnitario_in_ND.Text = sCero1_
                        txtPrecUnitario_in_ND.Select()
                    End If
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
        DesplegarMensaje()

        lblCantCompra_ND.AutoSize = False
        lblCantCompra_ND.Top = txtCantCompra_ND.Top
        lblCantCompra_ND.Left = txtCantCompra_ND.Left
        lblCantCompra_ND.Width = txtCantCompra_ND.Width
        lblCantCompra_ND.Height = txtCantCompra_ND.Height
        lblCantCompra_ND.TextAlign = ContentAlignment.MiddleRight
        lblCantCompra_ND.Visible = False
        txtCantCompra_ND.TextAlign = HorizontalAlignment.Right

        lblPrecUnitario_in_ND.AutoSize = False
        lblPrecUnitario_in_ND.Top = txtPrecUnitario_in_ND.Top
        lblPrecUnitario_in_ND.Left = txtPrecUnitario_in_ND.Left
        lblPrecUnitario_in_ND.Width = txtPrecUnitario_in_ND.Width
        lblPrecUnitario_in_ND.Height = txtPrecUnitario_in_ND.Height
        lblPrecUnitario_in_ND.TextAlign = ContentAlignment.MiddleRight
        lblPrecUnitario_in_ND.Visible = False
        txtPrecUnitario_in_ND.TextAlign = HorizontalAlignment.Right

        lblImpTotal_in_ND.AutoSize = False
        lblImpTotal_in_ND.Top = txtImpTotal_in_ND.Top
        lblImpTotal_in_ND.Left = txtImpTotal_in_ND.Left
        lblImpTotal_in_ND.Width = txtImpTotal_in_ND.Width
        lblImpTotal_in_ND.Height = txtImpTotal_in_ND.Height
        lblImpTotal_in_ND.TextAlign = ContentAlignment.MiddleRight
        lblImpTotal_in_ND.Visible = False
        txtImpTotal_in_ND.TextAlign = HorizontalAlignment.Right

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ee051compras
                txtCodEmpresa_NE.Text = CType(entidad, Ee051compras).codempresa.ToString
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Text = CType(entidad, Ee051compras).numtransaccion.ToString
                txtNumTransaccion_NE.Tag = sOk_
                txtNumOrden_NE.Text = loDatos.ReservarRegistro(Integer.Parse(txtCodEmpresa_NE.Text.ToString), CType(entidad, Ee051compras).numtransaccion).ToString
                txtNumOrden_NE.Tag = sOk_
                txtPrecUnitario_in_ND.Text = sCero1_
                txtImpTotal_in_ND.Text = sCero1_
                loDatos.CerrarConexion()
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ee051compras).codempresa.ToString
                txtNumTransaccion_NE.Text = CType(entidad, Ee051compras).numtransaccion.ToString
                txtNumOrden_NE.Text = CType(entidad, Ee051compras).numorden.ToString
                txtCodMercaderia_AN.Text = CType(entidad, Ee051compras).codmercaderia
                lblNomMercaderia.Text = CType(entidad, Ee051compras).nommercaderia
                txtCodUnidad_AN.Text = CType(entidad, Ee051compras).codunidad
                txtCantCompra_ND.Text = CType(entidad, Ee051compras).cantcompra.ToString
                txtPrecUnitario_in_ND.Text = CType(entidad, Ee051compras).precunitario_in.ToString
                txtImpTotal_in_ND.Text = CType(entidad, Ee051compras).imptotal_in.ToString
                cmbEstado.Text = CType(entidad, Ee051compras).estado
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Tag = sOk_
                txtNumOrden_NE.Tag = sOk_
                txtCodMercaderia_AN.Tag = sOk_
                lblNomMercaderia.Tag = sOk_
                txtCodUnidad_AN.Tag = sOk_
                txtCantCompra_ND.Tag = sOk_
                txtPrecUnitario_in_ND.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtNumTransaccion_NE.Enabled = True
        txtNumOrden_NE.Enabled = True
        txtCodMercaderia_AN.Enabled = True
        txtCodUnidad_AN.Enabled = True
        txtCantCompra_ND.Enabled = True
        txtPrecUnitario_in_ND.Enabled = True
        txtImpTotal_in_ND.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtNumTransaccion_NE.AccessibleName = "numtransaccion"
        txtNumOrden_NE.AccessibleName = "numorden"
        txtCodMercaderia_AN.AccessibleName = "codmercaderia"
        txtCodUnidad_AN.AccessibleName = "codunidad"
        txtCantCompra_ND.AccessibleName = "cantcompra"
        txtPrecUnitario_in_ND.AccessibleName = "precunitario_in"
        txtImpTotal_in_ND.AccessibleName = "imptotal_in"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtNumOrden_NE.Enabled = False

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtNumOrden_NE.Enabled = False

            Case sCONSULTAR_, sBORRAR_
                For Each loTabPage As TabPage In TabControl1.TabPages
                    If loTabPage.AccessibleName = sActivo_ Then
                        For Each loControl As Control In loTabPage.Controls
                            loControl.Tag = sCancelar_
                            If InStr("txt|cmb", loControl.Name.Substring(0, 3)) > 0 Then
                                loControl.Enabled = False
                            End If
                            If loControl.Name.Substring(0, 3) = "gbx" Then
                                For Each loControlNested As Control In loControl.Controls
                                    If InStr("txt|cmb", loControlNested.Name.Substring(0, 3)) > 0 Then
                                        loControlNested.Enabled = False
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
        End Select
        '--Primer campo seleccionado al ingresar.
        txtCodMercaderia_AN.Select()
    End Sub
    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LPDespliegaDescripciones()
    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer
        Dim liCodDocumento As Integer
        Dim liNumTransaccion As Integer
        Dim liNumOrden As Integer

        lblNomEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If Not IsNumeric(txtCodEmpresa_NE.Text) Then Exit Sub
            liCodEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

            Dim loFK As New Ec001empresas
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNomEmpresa.Text = loFK.nombre
                msCodMoneda_mb = loFK.codMoneda
                Dim loFK1 As New Ea010monedas
                loFK1.codMoneda = msCodMoneda_mb
                If loFK1.GetPK = sOk_ Then
                    msCodMoneda_mb = loFK1.codMoneda
                    miDecimales_mb = loFK1.decimales
                    msCulture_mb = loFK1.culture
                End If
            End If
            loFK.CerrarConexion()
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString)
        End If

        liNumTransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        txtNumTransaccion_NE.Text = liNumTransaccion.ToString(sFormatD_ & txtNumTransaccion_NE.MaxLength.ToString)

        liNumOrden = Integer.Parse(txtNumOrden_NE.Text.ToString)
        txtNumOrden_NE.Text = liNumOrden.ToString(sFormatD_ & txtNumOrden_NE.MaxLength.ToString)

        If txtNumTransaccion_NE.Text.Trim.Length > 0 Then
            If Not IsNumeric(txtNumTransaccion_NE.Text.ToString) Then Exit Sub
            liNumTransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)

            Dim loE050 As New Ee050compras
            loE050.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loE050.numtransaccion = liNumTransaccion
            If loE050.GetPK = sOk_ Then
                msFecOperacion = loE050.fecoperacion
                msAplicacion = loE050.aplicacion
                miCotizacion = loE050.cotizacion
                liCodDocumento = loE050.coddocumento
                Dim loC020 As New Ec020documentos
                loC020.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loC020.coddocumento = liCodDocumento
                If loC020.GetPK = sOk_ Then
                    msCodMoneda_mo = loC020.codmoneda
                    Dim loA010 As New Ea010monedas
                    loA010.codMoneda = msCodMoneda_mo
                    If loA010.GetPK = sOk_ Then
                        miDecimales_mo = loA010.decimales
                        msCulture_mo = loA010.culture
                    End If
                    loA010.CerrarConexion()
                End If
                loC020.CerrarConexion()
            End If
            loE050.CerrarConexion()
        End If

        lblNomMercaderia.Text = ""
        lblTitImporteTotal.Text = "Importe total: "
        If txtCodMercaderia_AN.Text.Trim.Length > 0 Then
            Dim loD020 As New Ed020mercentrada
            loD020.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loD020.codmercaderia = txtCodMercaderia_AN.Text
            If loD020.GetPK = sOk_ Then
                lblNomMercaderia.Text = loD020.nombre
                msIva = loD020.iva
                msCodUnidad = loD020.codunidad
                lblTitImporteTotal.Text = "Importe " & msIva.ToUpper & " en " & msCodMoneda_mo & ": "
            End If
            loD020.CerrarConexion()
        End If

        lblNomUnidad.Text = ""
        If txtCodUnidad_AN.Text.Trim.Length > 0 Then
            Dim loB110 As New Eb110undalternativas
            loB110.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loB110.tipo = sEntrada_
            loB110.codmercaderia = txtCodMercaderia_AN.Text.ToString
            loB110.codunidad = txtCodUnidad_AN.Text.ToString
            If loB110.GetPK = sOk_ Then
                lblNomUnidad.Text = loB110.nomunidad
                mdCantidad = loB110.cantidad
            End If
        End If

        lblCantCompra_real.Text = ""
        If txtCantCompra_ND.Text.Trim.Length > 0 Then
            Dim ldCantCompra As Decimal = Decimal.Parse(Math.Round(Decimal.Parse(txtCantCompra_ND.Text.ToString) * mdCantidad, iCantDecimal_).ToString(sFormatF_))
            lblCantCompra_real.Text = ldCantCompra.ToString(sFormatF_) & " " & msCodUnidad
        End If

        Dim ldValor As Decimal
        If txtCantCompra_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCantCompra_ND.Text) Then
                ldValor = Decimal.Parse(txtCantCompra_ND.Text)
                lblCantCompra_ND.Text = ldValor.ToString(sFormatF_)
                lblCantCompra_ND.Visible = True
            End If
        End If

        If txtPrecUnitario_in_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtPrecUnitario_in_ND.Text) Then
                ldValor = Decimal.Parse(txtPrecUnitario_in_ND.Text)
                lblPrecUnitario_in_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblPrecUnitario_in_ND.Visible = True
            End If
        End If

        If txtImpTotal_in_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtImpTotal_in_ND.Text) Then
                ldValor = Decimal.Parse(txtImpTotal_in_ND.Text)
                lblImpTotal_in_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
                lblImpTotal_in_ND.Visible = True
            End If
        End If

        Select Case Me.Tag.ToString
            Case sAGREGAR_, sMODIFICAR_
                lblCantCompra_ND.BackColor = txtCantCompra_ND.BackColor
                lblPrecUnitario_in_ND.BackColor = txtPrecUnitario_in_ND.BackColor
                lblImpTotal_in_ND.BackColor = txtImpTotal_in_ND.BackColor
            Case sCONSULTAR_, sBORRAR_
                lblCantCompra_ND.BackColor = Me.BackColor
                lblPrecUnitario_in_ND.BackColor = Me.BackColor
                lblImpTotal_in_ND.BackColor = Me.BackColor
        End Select

        Me.Refresh()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtNumTransaccion_NE.MaxLength = 6
        txtNumOrden_NE.MaxLength = 4
        txtCodMercaderia_AN.MaxLength = 20
        txtCodUnidad_AN.MaxLength = 6
        txtCantCompra_ND.MaxLength = 17
        txtPrecUnitario_in_ND.MaxLength = 17
        txtImpTotal_in_ND.MaxLength = 17
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
                            AddHandler loControl.KeyPress, AddressOf ManejoEvento_KeyPress
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
                                        AddHandler loControl1.Validating, AddressOf ManejoEvento_Validating
                                        AddHandler loControl1.Validated, AddressOf ManejoEvento_Validated
                                        AddHandler loControl1.KeyDown, AddressOf ManejoEvento_KeyDown
                                        AddHandler loControl1.KeyPress, AddressOf ManejoEvento_KeyPress
                                    Case sPrefijoRadioButton_
                                        AddHandler loControl1.Validated, AddressOf ManejoEvento_Validated
                                        AddHandler loControl1.KeyDown, AddressOf ManejoEvento_KeyDown
                                End Select
                            Next
                    End Select
                Next
            End If
        Next
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

        Dim loDatos As New Ee051compras
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        Dim liNumOrden As Integer = Integer.Parse(txtNumOrden_NE.Text.ToString)
        loDatos.codempresa = liCodEmpresa
        loDatos.numtransaccion = liNumTransaccion
        loDatos.numorden = liNumOrden
        If loDatos.GetPK = sOk_ Then
            loDatos.codempresa = liCodEmpresa
            loDatos.numtransaccion = liNumTransaccion
            loDatos.numorden = liNumOrden
            loDatos.Del(sNo_, sNo_)
        End If
        loDatos.CerrarConexion()
        loDatos = Nothing
    End Sub
    Private Sub TextBox_Click(sender As Object, e As EventArgs)
        CType(sender, TextBox).SelectAll()
    End Sub
    Private Sub lblCantCompra_ND_Click(sender As Object, e As EventArgs) Handles lblCantCompra_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCantCompra_ND.Visible = False
        txtCantCompra_ND.Focus()
        txtCantCompra_ND.SelectAll()
    End Sub
    Private Sub txtCantCompra_ND_GotFocus(sender As Object, e As EventArgs) Handles txtCantCompra_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCantCompra_ND.Visible = False
        txtCantCompra_ND.Focus()
        txtCantCompra_ND.SelectAll()
    End Sub
    Private Sub lblPrecUnitario_mo_ND_Click(sender As Object, e As EventArgs) Handles lblPrecUnitario_in_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblPrecUnitario_in_ND.Visible = False
        txtPrecUnitario_in_ND.Focus()
        txtPrecUnitario_in_ND.SelectAll()
    End Sub
    Private Sub txtPrecUnitario_mo_ND_GotFocus(sender As Object, e As EventArgs) Handles txtPrecUnitario_in_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblPrecUnitario_in_ND.Visible = False
        txtPrecUnitario_in_ND.Focus()
        txtPrecUnitario_in_ND.SelectAll()
    End Sub
    Private Sub lblimptotal_in_ND_Click(sender As Object, e As EventArgs) Handles lblImpTotal_in_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblImpTotal_in_ND.Visible = False
        txtImpTotal_in_ND.Focus()
        txtImpTotal_in_ND.SelectAll()
    End Sub
    Private Sub txtimptotal_in_ND_GotFocus(sender As Object, e As EventArgs) Handles txtPrecUnitario_in_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblImpTotal_in_ND.Visible = False
        txtImpTotal_in_ND.Focus()
        txtImpTotal_in_ND.SelectAll()
    End Sub
End Class