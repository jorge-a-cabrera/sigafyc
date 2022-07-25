Imports System.Globalization
Imports System.ComponentModel
Public Class frmFe062entmercaderia
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "numtransaccion", "numorden", "orgtransaccion", "gastneto_mb", "gastimpuesto_mb"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msCodMoneda_mb As String = ""
    Private msNomMoneda_mb As String = ""
    Private miDecimales_mb As Integer
    Private msCulture_mb As String
    Private msIva As String = ""
    Private msLinea As String = ""
    Private miNumCompraMaxLength As Integer = 6
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
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ee062entmercaderia
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                        loDatos.orgtransaccion = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                        loDatos.gastneto_mb = Decimal.Parse(Decimal.Parse(txtGastNeto_mb_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.gastimpuesto_mb = Decimal.Parse(Decimal.Parse(txtGastImpuesto_mb_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.estado = sEnCosteo_
                        Try
                            loDatos.Put(sSi_, sSi_, sAGREGAR_)
                            Dim loE050 As New Ee050compras
                            loE050.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loE050.numtransaccion = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                            If loE050.GetPK = sOk_ Then
                                loE050.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                                loE050.numtransaccion = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                                loE050.estado = sEnCosteo_
                                loE050.Put(sNo_, sSi_)
                            End If
                            loE050.CerrarConexion()
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                    Case sMODIFICAR_
                        Dim loDatos As New Ee062entmercaderia
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                            loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                            loDatos.orgtransaccion = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                            loDatos.gastneto_mb = Decimal.Parse(Decimal.Parse(txtGastNeto_mb_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.gastimpuesto_mb = Decimal.Parse(Decimal.Parse(txtGastImpuesto_mb_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.estado = cmbEstado.Text
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
                Dim loDatos As New Ee061entmercaderia
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
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "orgtransaccion"
                    If IsNumeric(txtOrgTransaccion_NE.Text.ToString) Then
                        Dim liOrgTransaccion As Integer = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                        Dim loE050 As New Ee050compras
                        loE050.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loE050.numtransaccion = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                        If loE050.GetPK <> sOk_ Then
                            Dim loLookUp As New frmBe050compras
                            loLookUp.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loLookUp.Tag = sELEGIR_
                            GPCargar(loLookUp)
                            If loLookUp.entidad IsNot Nothing Then
                                txtOrgTransaccion_NE.Text = CType(loLookUp.entidad, Ee050compras).numtransaccion.ToString
                                txtOrgTransaccion_NE.Refresh()
                                Dim ldTotExenta As Decimal = CType(loLookUp.entidad, Ee050compras).totexenta_mb
                                Dim ldTotGrav05 As Decimal = CType(loLookUp.entidad, Ee050compras).totgrav05_mb
                                Dim ldTotGrav10 As Decimal = CType(loLookUp.entidad, Ee050compras).totgrav10_mb
                                Dim ldIvaGrav05 As Decimal = CType(loLookUp.entidad, Ee050compras).ivagrav05_mb
                                Dim ldIvaGrav10 As Decimal = CType(loLookUp.entidad, Ee050compras).ivagrav10_mb
                                txtGastNeto_mb_ND.Text = (ldTotExenta + ldTotGrav05 + ldTotGrav10).ToString(sFormatF_)
                                txtGastImpuesto_mb_ND.Text = (ldIvaGrav05 + ldIvaGrav10).ToString(sFormatF_)
                                txtTotGeneral_mb.Text = (ldTotExenta + ldTotGrav05 + ldTotGrav10 + ldIvaGrav05 + ldIvaGrav10).ToString(sFormatF_)
                                txtGastNeto_mb_ND.Tag = sOk_
                                txtGastImpuesto_mb_ND.Tag = sOk_
                                txtTotGeneral_mb.Tag = sOk_
                            Else
                                e.Cancel = True
                                Exit Sub
                            End If
                        Else
                            If loE050.estado <> sActivo_ Then
                                If Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then
                                    Dim loParametros As New Dictionary(Of String, String)
                                    loParametros.Add("&codempresa", lblNomEmpresa.Text.ToString)
                                    loParametros.Add("&numtransaccion", txtOrgTransaccion_NE.Text.ToString)
                                    loParametros.Add("&timbrado", loE050.timbrado)
                                    loParametros.Add("&fecoperacion", loE050.fecoperacion)
                                    loParametros.Add("&numero", loE050.prefijo & "-" & loE050.numcompra.ToString(sFormatD_ & "7"))
                                    loParametros.Add("&estado", loE050.estado)
                                    Dim lsMensaje As String = GFsGeneraMSG("msg_e060_error_entmercaderia", loParametros)
                                    GFsAvisar(lsMensaje, sMENSAJE_, "por favor verifique el dato y vuelta a intentarlo.")
                                    e.Cancel = True
                                    Exit Sub
                                End If
                            Else
                                Dim loE051 As New Ee051compras
                                Dim lsSQL As String = GFsGeneraSQL("e051compras_conteo")
                                lsSQL = lsSQL.Replace("&codempresa", Integer.Parse(txtCodEmpresa_NE.Text.ToString).ToString)
                                lsSQL = lsSQL.Replace("&numtransaccion", Integer.Parse(txtOrgTransaccion_NE.Text.ToString).ToString)
                                Dim liCantidad As Integer = loE051.CantidadRegistro(lsSQL)
                                If liCantidad > 0 Then
                                    Dim loParametros As New Dictionary(Of String, String)
                                    loParametros.Add("&codempresa", lblNomEmpresa.Text.ToString)
                                    loParametros.Add("&numtransaccion", txtOrgTransaccion_NE.Text.ToString)
                                    loParametros.Add("&timbrado", loE050.timbrado)
                                    loParametros.Add("&fecoperacion", loE050.fecoperacion)
                                    loParametros.Add("&numero", loE050.prefijo & "-" & loE050.numcompra.ToString(sFormatD_ & "7"))
                                    loParametros.Add("&estado", loE050.estado)
                                    Dim lsMensaje As String = GFsGeneraMSG("msg_e060_error2_detalle051", loParametros)
                                    GFsAvisar(lsMensaje, sMENSAJE_, "por favor verifique el dato y vuelta a intentarlo.")
                                    e.Cancel = True
                                    Exit Sub
                                End If
                            End If
                            txtGastNeto_mb_ND.Text = (loE050.totexenta_mb + loE050.totgrav05_mb + loE050.totgrav10_mb).ToString(sFormatF_)
                            txtGastImpuesto_mb_ND.Text = (loE050.ivagrav05_mb + loE050.ivagrav10_mb).ToString(sFormatF_)
                            txtTotGeneral_mb.Text = (loE050.totexenta_mb + loE050.totgrav05_mb + loE050.totgrav10_mb + loE050.ivagrav05_mb + loE050.ivagrav10_mb).ToString(sFormatF_)
                            txtGastNeto_mb_ND.Tag = sOk_
                            txtGastImpuesto_mb_ND.Tag = sOk_
                            txtTotGeneral_mb.Tag = sOk_
                        End If
                        txtOrgTransaccion_NE.Tag = sOk_
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
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LPInicializaMaxLength()
        LPInicializaControles()
        ' Inicializa los controles de edición con los valores pertinentes
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        msEntidad = "entrada mercaderia o servicio"
        msLinea = lblTituloImporte.Text.ToString

        DesplegarMensaje()


        lblGastNeto_mb_ND.AutoSize = False
        lblGastNeto_mb_ND.Top = txtGastNeto_mb_ND.Top
        lblGastNeto_mb_ND.Left = txtGastNeto_mb_ND.Left
        lblGastNeto_mb_ND.Width = txtGastNeto_mb_ND.Width
        lblGastNeto_mb_ND.Height = txtGastNeto_mb_ND.Height
        lblGastNeto_mb_ND.TextAlign = ContentAlignment.MiddleRight
        lblGastNeto_mb_ND.Visible = False
        txtGastNeto_mb_ND.TextAlign = HorizontalAlignment.Right

        lblGastImpuesto_mb_ND.AutoSize = False
        lblGastImpuesto_mb_ND.Top = txtGastImpuesto_mb_ND.Top
        lblGastImpuesto_mb_ND.Left = txtGastImpuesto_mb_ND.Left
        lblGastImpuesto_mb_ND.Width = txtGastImpuesto_mb_ND.Width
        lblGastImpuesto_mb_ND.Height = txtGastImpuesto_mb_ND.Height
        lblGastImpuesto_mb_ND.TextAlign = ContentAlignment.MiddleRight
        lblGastImpuesto_mb_ND.Visible = False
        txtGastImpuesto_mb_ND.TextAlign = HorizontalAlignment.Right

        lblTotGeneral_mb.AutoSize = False
        lblTotGeneral_mb.Top = txtTotGeneral_mb.Top
        lblTotGeneral_mb.Left = txtTotGeneral_mb.Left
        lblTotGeneral_mb.Width = txtTotGeneral_mb.Width
        lblTotGeneral_mb.Height = txtTotGeneral_mb.Height
        lblTotGeneral_mb.TextAlign = ContentAlignment.MiddleRight
        lblTotGeneral_mb.Visible = False
        txtTotGeneral_mb.TextAlign = HorizontalAlignment.Right

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ee062entmercaderia
                txtCodEmpresa_NE.Text = CType(entidad, Ee062entmercaderia).codempresa.ToString
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Text = CType(entidad, Ee062entmercaderia).numtransaccion.ToString
                txtNumTransaccion_NE.Tag = sOk_
                txtNumOrden_NE.Text = loDatos.ReservarRegistro(Integer.Parse(txtCodEmpresa_NE.Text.ToString), CType(entidad, Ee062entmercaderia).numtransaccion).ToString
                txtNumOrden_NE.Tag = sOk_
                loDatos.CerrarConexion()
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ee062entmercaderia).codempresa.ToString
                txtNumTransaccion_NE.Text = CType(entidad, Ee062entmercaderia).numtransaccion.ToString
                txtNumOrden_NE.Text = CType(entidad, Ee062entmercaderia).numorden.ToString
                txtOrgTransaccion_NE.Text = CType(entidad, Ee062entmercaderia).orgtransaccion.ToString
                txtGastNeto_mb_ND.Text = CType(entidad, Ee062entmercaderia).gastneto_mb.ToString(sFormatF_)
                txtGastImpuesto_mb_ND.Text = CType(entidad, Ee062entmercaderia).gastimpuesto_mb.ToString(sFormatF_)
                Dim ldNeto As Decimal = Decimal.Parse(txtGastNeto_mb_ND.Text.ToString)
                Dim ldImpuesto As Decimal = Decimal.Parse(txtGastImpuesto_mb_ND.Text.ToString)
                txtTotGeneral_mb.Text = (ldNeto + ldImpuesto).ToString(sFormatF_)
                cmbEstado.Text = CType(entidad, Ee062entmercaderia).estado
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Tag = sOk_
                txtNumOrden_NE.Tag = sOk_
                txtOrgTransaccion_NE.Tag = sOk_
                txtGastNeto_mb_ND.Tag = sOk_
                txtGastImpuesto_mb_ND.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtNumTransaccion_NE.Enabled = True
        txtNumOrden_NE.Enabled = True
        txtOrgTransaccion_NE.Enabled = True
        txtGastNeto_mb_ND.Enabled = True
        txtGastImpuesto_mb_ND.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtNumTransaccion_NE.AccessibleName = "numtransaccion"
        txtNumOrden_NE.AccessibleName = "numorden"
        txtOrgTransaccion_NE.AccessibleName = "orgtransaccion"
        txtGastNeto_mb_ND.AccessibleName = "gastneto_mb"
        txtGastImpuesto_mb_ND.AccessibleName = "gastimpuesto_mb"
        txtTotGeneral_mb.AccessibleName = "totgeneral_mb"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtNumOrden_NE.Enabled = False
                txtGastNeto_mb_ND.Enabled = False
                txtGastImpuesto_mb_ND.Enabled = False
                txtTotGeneral_mb.Enabled = False

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtNumOrden_NE.Enabled = False
                txtOrgTransaccion_NE.Enabled = False
                txtGastNeto_mb_ND.Enabled = False
                txtGastImpuesto_mb_ND.Enabled = False
                txtTotGeneral_mb.Enabled = False

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
        txtOrgTransaccion_NE.Select()
    End Sub
    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LPDespliegaDescripciones()
    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer
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
                    msNomMoneda_mb = loFK1.nombre
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

        lblNomProveedor.Text = ""
        lblIdentificacion.Text = ""
        lblDocumento.Text = ""
        If txtOrgTransaccion_NE.Text.Trim.Length > 0 Then
            If IsNumeric(txtOrgTransaccion_NE.Text) Then
                Dim liOrgTransaccion As Integer = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                txtOrgTransaccion_NE.Text = liOrgTransaccion.ToString(sFormatD_ & txtOrgTransaccion_NE.MaxLength.ToString)
                Dim loE050 As New Ee050compras
                loE050.codempresa = liCodEmpresa
                loE050.numtransaccion = liOrgTransaccion
                If loE050.GetPK = sOk_ Then
                    Dim loA030 As New Ea030personas
                    loA030.tipoDocumento = loE050.tipodocumento
                    loA030.nroDocumento = loE050.numdocumento
                    If loA030.GetPK = sOk_ Then
                        lblNomProveedor.Text = loA030.nombre
                        lblIdentificacion.Text = loE050.tipodocumento & ": " & loE050.numdocumento
                        Dim loC020 As New Ec020documentos
                        loC020.codempresa = liCodEmpresa
                        loC020.coddocumento = loE050.coddocumento
                        If loC020.GetPK = sOk_ Then
                            lblDocumento.Text = loC020.abreviado & ": " & loE050.prefijo & "-" & loE050.numcompra.ToString(sFormatD_ & miNumCompraMaxLength.ToString)
                        End If
                    End If
                End If
            End If
        End If

        Dim ldValor As Decimal

        If txtGastNeto_mb_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtGastNeto_mb_ND.Text) Then
                ldValor = Decimal.Parse(txtGastNeto_mb_ND.Text)
                lblGastNeto_mb_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblGastNeto_mb_ND.Visible = True
                txtGastNeto_mb_ND.SendToBack()
            End If
        End If

        If txtGastImpuesto_mb_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtGastImpuesto_mb_ND.Text) Then
                ldValor = Decimal.Parse(txtGastImpuesto_mb_ND.Text)
                lblGastImpuesto_mb_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblGastImpuesto_mb_ND.Visible = True
                txtGastImpuesto_mb_ND.SendToBack()
            End If
        End If

        If txtTotGeneral_mb.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotGeneral_mb.Text) Then
                ldValor = Decimal.Parse(txtTotGeneral_mb.Text)
                lblTotGeneral_mb.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblTotGeneral_mb.Visible = True
                txtTotGeneral_mb.SendToBack()
            End If
        End If

        lblTituloImporte.Text = LFsTituloImporte("Importes en " & msNomMoneda_mb & " - c/IVA " & msIva)
        Select Case Me.Tag.ToString
            Case sAGREGAR_, sMODIFICAR_
                lblGastNeto_mb_ND.BackColor = txtGastNeto_mb_ND.BackColor
                lblGastImpuesto_mb_ND.BackColor = txtGastImpuesto_mb_ND.BackColor

            Case sCONSULTAR_, sBORRAR_
                lblGastNeto_mb_ND.BackColor = Me.BackColor
                lblGastImpuesto_mb_ND.BackColor = Me.BackColor
        End Select
        Me.Refresh()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtNumTransaccion_NE.MaxLength = 6
        txtNumOrden_NE.MaxLength = 4
        txtOrgTransaccion_NE.MaxLength = 6
        txtGastNeto_mb_ND.MaxLength = 17
        txtGastImpuesto_mb_ND.MaxLength = 17
        txtTotGeneral_mb.MaxLength = 17
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

        Dim loDatos As New Ee062entmercaderia
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


    Private Sub lblGastNeto_mb_ND_Click(sender As Object, e As EventArgs) Handles lblGastNeto_mb_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblGastNeto_mb_ND.Visible = False
        txtGastNeto_mb_ND.Focus()
        txtGastNeto_mb_ND.SelectAll()
    End Sub
    Private Sub txtGastNeto_mb_ND_GotFocus(sender As Object, e As EventArgs) Handles txtGastNeto_mb_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblGastNeto_mb_ND.Visible = False
        txtGastNeto_mb_ND.Focus()
        txtGastNeto_mb_ND.SelectAll()
    End Sub

    Private Sub lblGastImpuesto_mb_ND_Click(sender As Object, e As EventArgs) Handles lblGastImpuesto_mb_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblGastImpuesto_mb_ND.Visible = False
        txtGastImpuesto_mb_ND.Focus()
        txtGastImpuesto_mb_ND.SelectAll()
    End Sub
    Private Sub txtGastImpuesto_mb_ND_GotFocus(sender As Object, e As EventArgs) Handles txtGastImpuesto_mb_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblGastImpuesto_mb_ND.Visible = False
        txtGastImpuesto_mb_ND.Focus()
        txtGastImpuesto_mb_ND.SelectAll()
    End Sub
    Private Function LFsTituloImporte(ByVal psTitulo As String, Optional ByVal pbUpperCase As Boolean = False) As String
        Dim lsResultado As String
        Dim lsSeparador As String = msLinea
        Dim liLongNeto As Integer = lsSeparador.Trim.Length - psTitulo.Trim.Length
        Dim liLongitud As Integer = liLongNeto \ 2
        Dim lsLadoIzquierdo As String = lsSeparador.Substring(0, liLongitud)
        Dim lsLadoDerecho As String = lsSeparador.Substring(0, liLongNeto - liLongitud)

        If Not pbUpperCase Then
            lsResultado = lsLadoIzquierdo & psTitulo.ToLower & lsLadoDerecho
        Else
            lsResultado = lsLadoIzquierdo & psTitulo.ToUpper & lsLadoDerecho
        End If
        Return lsResultado
    End Function
End Class