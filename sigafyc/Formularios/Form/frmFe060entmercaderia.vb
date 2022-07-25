Imports System.ComponentModel
Imports System.Globalization
Public Class frmFe060entmercaderia
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "numtransaccion", "coddeposito", "fecoperacion", "fecvigencia", "orgtransaccion"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msCodMoneda_mb As String = ""
    Private miDecimales_mb As Integer = 0
    Private msCulture_mb As String = ""
    Private mdCompNeta As Decimal = 0.00D
    Private mdCompImpuesto As Decimal = 0.00D
    Private mdGastNeto As Decimal = 0.00D
    Private mdGastImpuesto As Decimal = 0.00D
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
                txtCodDeposito_NE.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ee060entmercaderia
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.coddeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                        loDatos.orgtransaccion = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                        loDatos.fecoperacion = txtFecOperacion_FE.Text.ToString
                        loDatos.fecvigencia = txtFecVigencia_FE.Text.ToString
                        loDatos.compneta_mb = Decimal.Parse(Decimal.Parse(txtCompNeta_mb_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.compimpuesto_mb = Decimal.Parse(Decimal.Parse(txtCompImpuesto_mb_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.gastneto_mb = Decimal.Parse(Decimal.Parse(txtGastNeto_mb_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.gastimpuesto_mb = Decimal.Parse(Decimal.Parse(txtGastImpuesto_mb_ND.Text.ToString).ToString(sFormatF_))
                        loDatos.estado = cmbEstado.Text
                        Try
                            loDatos.Put(sSi_, sSi_, sAGREGAR_)
                            LPGeneraDetalleE061(Integer.Parse(txtCodEmpresa_NE.Text.ToString), Integer.Parse(txtCodDeposito_NE.Text.ToString), Integer.Parse(txtOrgTransaccion_NE.Text.ToString))

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
                        Dim loDatos As New Ee060entmercaderia
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                            loDatos.coddeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                            loDatos.orgtransaccion = Integer.Parse(txtOrgTransaccion_NE.Text.ToString)
                            loDatos.fecoperacion = txtFecOperacion_FE.Text.ToString
                            loDatos.fecvigencia = txtFecVigencia_FE.Text.ToString
                            loDatos.compneta_mb = Decimal.Parse(Decimal.Parse(txtCompNeta_mb_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.compimpuesto_mb = Decimal.Parse(Decimal.Parse(txtCompImpuesto_mb_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.gastneto_mb = Decimal.Parse(Decimal.Parse(txtGastNeto_mb_ND.Text.ToString).ToString(sFormatF_))
                            loDatos.gastimpuesto_mb = Decimal.Parse(Decimal.Parse(txtGastImpuesto_mb_ND.Text.ToString).ToString(sFormatF_))
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
                Dim loDatos As New Ee060entmercaderia
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
                Case "fecoperacion"
                    lsValorInicial = Today.ToString(sFormatoFecha1_)
                Case "fecvigencia"
                    lsValorInicial = txtFecOperacion_FE.Text.ToString
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
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

                Case "fecvigencia"
                    If Not IsDate(txtFecVigencia_FE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtFecVigencia_FE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                        Exit Sub
                    Else
                        Dim ldFecVigencia As Date = Date.Parse(txtFecVigencia_FE.Text.ToString)
                        txtFecVigencia_FE.Text = ldFecVigencia.ToString("yyyy-MM-dd")
                    End If

                    If txtFecVigencia_FE.Text < txtFecOperacion_FE.Text Then
                        Dim loParametros As New Dictionary(Of String, String)
                        loParametros.Add("&fecoperacion", txtFecOperacion_FE.Text.ToString)
                        loParametros.Add("&FecVigencia", txtFecVigencia_FE.Text.ToString)
                        Dim lsMensaje As String = GFsGeneraMSG("msg_e060_error_FecVigencia", loParametros)
                        GFsAvisar(lsMensaje, sMENSAJE_, "por favor verifique el dato y vuelta a intentarlo.")
                        e.Cancel = True
                        Exit Sub
                    End If

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
                            Else
                                e.Cancel = True
                                Exit Sub
                            End If
                        Else
                            If loE050.estado <> sActivo_ Then
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
                            Else
                                Dim loE051 As New Ee051compras
                                Dim lsSQL As String = GFsGeneraSQL("e051compras_conteo")
                                lsSQL = lsSQL.Replace("&codempresa", Integer.Parse(txtCodEmpresa_NE.Text.ToString).ToString)
                                lsSQL = lsSQL.Replace("&numtransaccion", Integer.Parse(txtOrgTransaccion_NE.Text.ToString).ToString)
                                Dim liCantidad As Integer = loE051.CantidadRegistro(lsSQL)
                                If liCantidad = 0 Then
                                    Dim loParametros As New Dictionary(Of String, String)
                                    loParametros.Add("&codempresa", lblNomEmpresa.Text.ToString)
                                    loParametros.Add("&numtransaccion", txtOrgTransaccion_NE.Text.ToString)
                                    loParametros.Add("&timbrado", loE050.timbrado)
                                    loParametros.Add("&fecoperacion", loE050.fecoperacion)
                                    loParametros.Add("&numero", loE050.prefijo & "-" & loE050.numcompra.ToString(sFormatD_ & "7"))
                                    loParametros.Add("&estado", loE050.estado)
                                    Dim lsMensaje As String = GFsGeneraMSG("msg_e060_error_detalle051", loParametros)
                                    GFsAvisar(lsMensaje, sMENSAJE_, "por favor verifique el dato y vuelta a intentarlo.")
                                    e.Cancel = True
                                    Exit Sub
                                End If
                            End If
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
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles Me.Load
        LPInicializaMaxLength()
        LPInicializaControles()

        ' Inicializa los controles de edición con los valores pertinentes
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        msEntidad = "Compra Bien o Servicio"
        lblTituloImporte.Tag = lblTituloImporte.Text
        lblTituloImporte.Text = LFsTituloImporte("importe")
        DesplegarMensaje()

        lblCompNeta_mb_ND.AutoSize = False
        lblCompNeta_mb_ND.Top = txtCompNeta_mb_ND.Top
        lblCompNeta_mb_ND.Left = txtCompNeta_mb_ND.Left
        lblCompNeta_mb_ND.Width = txtCompNeta_mb_ND.Width
        lblCompNeta_mb_ND.Height = txtCompNeta_mb_ND.Height
        lblCompNeta_mb_ND.TextAlign = ContentAlignment.MiddleRight
        lblCompNeta_mb_ND.Visible = False
        txtCompNeta_mb_ND.TextAlign = HorizontalAlignment.Right

        lblCompImpuesto_mb_ND.AutoSize = False
        lblCompImpuesto_mb_ND.Top = txtCompImpuesto_mb_ND.Top
        lblCompImpuesto_mb_ND.Left = txtCompImpuesto_mb_ND.Left
        lblCompImpuesto_mb_ND.Width = txtCompImpuesto_mb_ND.Width
        lblCompImpuesto_mb_ND.Height = txtCompImpuesto_mb_ND.Height
        lblCompImpuesto_mb_ND.TextAlign = ContentAlignment.MiddleRight
        lblCompImpuesto_mb_ND.Visible = False
        txtCompImpuesto_mb_ND.TextAlign = HorizontalAlignment.Right

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

        lblTotalGeneral_mb.AutoSize = False
        lblTotalGeneral_mb.Top = txtTotalGeneral_mb.Top
        lblTotalGeneral_mb.Left = txtTotalGeneral_mb.Left
        lblTotalGeneral_mb.Width = txtTotalGeneral_mb.Width
        lblTotalGeneral_mb.Height = txtTotalGeneral_mb.Height
        lblTotalGeneral_mb.TextAlign = ContentAlignment.MiddleRight
        lblTotalGeneral_mb.Visible = False
        txtTotalGeneral_mb.TextAlign = HorizontalAlignment.Right

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ee060entmercaderia
                txtCodEmpresa_NE.Text = CType(entidad, Ee060entmercaderia).codempresa.ToString
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Text = loDatos.ReservarRegistro(Integer.Parse(txtCodEmpresa_NE.Text.ToString)).ToString
                txtNumTransaccion_NE.Tag = sOk_
                txtCodDeposito_NE.Text = CType(entidad, Ee060entmercaderia).coddeposito.ToString
                txtCodDeposito_NE.Tag = sOk_
                txtCompNeta_mb_ND.Text = mdCompNeta.ToString(sFormatF_)
                txtCompNeta_mb_ND.Tag = sOk_
                txtCompImpuesto_mb_ND.Text = mdCompImpuesto.ToString(sFormatF_)
                txtCompImpuesto_mb_ND.Tag = sOk_
                txtGastNeto_mb_ND.Text = mdGastNeto.ToString(sFormatF_)
                txtGastNeto_mb_ND.Tag = sOk_
                txtGastImpuesto_mb_ND.Text = mdGastImpuesto.ToString(sFormatF_)
                txtGastImpuesto_mb_ND.Tag = sOk_
                txtTotalGeneral_mb.Tag = sOk_
                cmbEstado.Text = sActivo_
                cmbEstado.Tag = sOk_
                loDatos.CerrarConexion()

            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ee060entmercaderia).codempresa.ToString
                txtNumTransaccion_NE.Text = CType(entidad, Ee060entmercaderia).numtransaccion.ToString
                txtCodDeposito_NE.Text = CType(entidad, Ee060entmercaderia).coddeposito.ToString
                txtOrgTransaccion_NE.Text = CType(entidad, Ee060entmercaderia).orgtransaccion.ToString
                txtFecOperacion_FE.Text = CType(entidad, Ee060entmercaderia).fecoperacion.ToString
                txtFecVigencia_FE.Text = CType(entidad, Ee060entmercaderia).fecvigencia.ToString
                txtCompNeta_mb_ND.Text = CType(entidad, Ee060entmercaderia).compneta_mb.ToString
                txtCompImpuesto_mb_ND.Text = CType(entidad, Ee060entmercaderia).compimpuesto_mb.ToString
                txtGastNeto_mb_ND.Text = CType(entidad, Ee060entmercaderia).gastneto_mb.ToString
                txtGastImpuesto_mb_ND.Text = CType(entidad, Ee060entmercaderia).gastimpuesto_mb.ToString
                cmbEstado.Text = CType(entidad, Ee060entmercaderia).estado

                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Tag = sOk_
                txtCodDeposito_NE.Tag = sOk_
                txtOrgTransaccion_NE.Tag = sOk_
                txtFecOperacion_FE.Tag = sOk_
                txtFecVigencia_FE.Tag = sOk_
                txtCompNeta_mb_ND.Tag = sOk_
                txtCompImpuesto_mb_ND.Tag = sOk_
                txtGastNeto_mb_ND.Tag = sOk_
                txtGastImpuesto_mb_ND.Tag = sOk_
                txtTotalGeneral_mb.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtNumTransaccion_NE.Enabled = True
        txtCodDeposito_NE.Enabled = True
        txtFecOperacion_FE.Enabled = True
        txtFecVigencia_FE.Enabled = True
        txtOrgTransaccion_NE.Enabled = True
        txtCompNeta_mb_ND.Enabled = False
        txtCompImpuesto_mb_ND.Enabled = False
        txtGastNeto_mb_ND.Enabled = False
        txtGastImpuesto_mb_ND.Enabled = False
        txtTotalGeneral_mb.Enabled = False

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtNumTransaccion_NE.AccessibleName = "numtransaccion"
        txtCodDeposito_NE.AccessibleName = "coddeposito"
        txtFecOperacion_FE.AccessibleName = "fecoperacion"
        txtFecVigencia_FE.AccessibleName = "fecvigencia"
        txtOrgTransaccion_NE.AccessibleName = "orgtransaccion"
        txtCompNeta_mb_ND.AccessibleName = "compneta"
        txtCompImpuesto_mb_ND.AccessibleName = "compimpuesto"
        txtGastNeto_mb_ND.AccessibleName = "gastneto"
        txtGastImpuesto_mb_ND.AccessibleName = "gastimpuesto"
        txtTotalGeneral_mb.AccessibleName = "totalgeneral"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtCodDeposito_NE.Enabled = False
                txtFecOperacion_FE.Select()

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtCodDeposito_NE.Enabled = False
                txtFecOperacion_FE.Select()

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
        Dim liNumTransaccion As Integer
        Dim liCodDeposito As Integer
        Dim lsNomMoneda_mb As String = ""

        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            lblNomEmpresa.Text = ""
            If Not IsNumeric(txtCodEmpresa_NE.Text) Then Exit Sub
            liCodEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString)

            Dim loFK As New Ec001empresas
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNomEmpresa.Text = loFK.nombre
                msCodMoneda_mb = loFK.codMoneda
                Dim loFK1 As New Ea010monedas
                loFK1.codMoneda = msCodMoneda_mb
                If loFK1.GetPK = sOk_ Then
                    miDecimales_mb = loFK1.decimales
                    msCulture_mb = loFK1.culture
                    lsNomMoneda_mb = loFK1.nombre
                End If
            End If
            loFK.CerrarConexion()
        End If

        If txtNumTransaccion_NE.Text.Trim.Length > 0 Then
            liNumTransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
            txtNumTransaccion_NE.Text = liNumTransaccion.ToString(sFormatD_ & txtNumTransaccion_NE.MaxLength.ToString)
        End If

        If txtCodDeposito_NE.Text.Trim.Length > 0 Then
            If IsNumeric(txtCodDeposito_NE.Text) Then
                liCodDeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                lblNomDeposito.Text = ""
                If txtCodDeposito_NE.Text.Trim.Length > 0 Then
                    Dim loFK As New Eb040depositos
                    loFK.codEmpresa = liCodEmpresa
                    loFK.coddeposito = liCodDeposito
                    If loFK.GetPK = sOk_ Then
                        lblNomDeposito.Text = loFK.nombre
                    End If
                    loFK.CerrarConexion()
                    txtCodDeposito_NE.Text = liCodDeposito.ToString(sFormatD_ & txtCodDeposito_NE.MaxLength.ToString)
                End If
            End If
        End If

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
        Dim ldCompNeta As Decimal = 0.00D
        Dim ldCompImpuesto As Decimal = 0.00D
        Dim ldGastNeto As Decimal = 0.00D
        Dim ldGastImpuesto As Decimal = 0.00D
        If txtCompNeta_mb_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCompNeta_mb_ND.Text) Then
                ldValor = Decimal.Parse(txtCompNeta_mb_ND.Text)
                ldCompNeta = ldValor
                lblCompNeta_mb_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblCompNeta_mb_ND.Visible = True
            End If
        End If
        If txtCompImpuesto_mb_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCompImpuesto_mb_ND.Text) Then
                ldValor = Decimal.Parse(txtCompImpuesto_mb_ND.Text)
                ldCompImpuesto = ldValor
                lblCompImpuesto_mb_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblCompImpuesto_mb_ND.Visible = True
            End If
        End If
        If txtGastNeto_mb_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtGastNeto_mb_ND.Text) Then
                ldValor = Decimal.Parse(txtGastNeto_mb_ND.Text)
                ldGastNeto = ldValor
                lblGastNeto_mb_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblGastNeto_mb_ND.Visible = True
            End If
        End If
        If txtGastImpuesto_mb_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtGastImpuesto_mb_ND.Text) Then
                ldValor = Decimal.Parse(txtGastImpuesto_mb_ND.Text)
                ldGastImpuesto = ldValor
                lblGastImpuesto_mb_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblGastImpuesto_mb_ND.Visible = True
            End If
        End If
        Dim ldTotalGeneral As Decimal = ldCompNeta + ldCompImpuesto + ldGastNeto + ldGastImpuesto
        txtTotalGeneral_mb.Text = ldTotalGeneral.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
        If txtTotalGeneral_mb.Text.Trim.Length > 0 Then
            If IsNumeric(txtTotalGeneral_mb.Text) Then
                ldValor = Decimal.Parse(txtTotalGeneral_mb.Text)
                lblTotalGeneral_mb.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblTotalGeneral_mb.Visible = True
            End If
        End If

        Select Case Me.Tag.ToString
            Case sAGREGAR_, sMODIFICAR_
                lblTituloImporte.Text = LFsTituloImporte("Importes netos en " & lsNomMoneda_mb)
                lblCompNeta_mb_ND.BackColor = txtCompNeta_mb_ND.BackColor
                lblCompImpuesto_mb_ND.BackColor = txtCompImpuesto_mb_ND.BackColor
                lblGastNeto_mb_ND.BackColor = txtGastNeto_mb_ND.BackColor
                lblGastImpuesto_mb_ND.BackColor = txtGastImpuesto_mb_ND.BackColor
                lblTotalGeneral_mb.BackColor = txtTotalGeneral_mb.BackColor

            Case sCONSULTAR_, sBORRAR_
                lblTituloImporte.Text = LFsTituloImporte("Importes netos en " & lsNomMoneda_mb, True)
                lblCompNeta_mb_ND.BackColor = Me.BackColor
                lblCompImpuesto_mb_ND.BackColor = Me.BackColor
                lblGastNeto_mb_ND.BackColor = Me.BackColor
                lblGastImpuesto_mb_ND.BackColor = Me.BackColor
                lblTotalGeneral_mb.BackColor = Me.BackColor
        End Select
        Me.Refresh()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtNumTransaccion_NE.MaxLength = 6
        txtCodDeposito_NE.MaxLength = 3
        txtFecOperacion_FE.MaxLength = 10
        txtFecVigencia_FE.MaxLength = 10
        txtOrgTransaccion_NE.MaxLength = 6
        txtCompNeta_mb_ND.MaxLength = 17
        txtCompImpuesto_mb_ND.MaxLength = 17
        txtGastNeto_mb_ND.MaxLength = 17
        txtGastImpuesto_mb_ND.MaxLength = 17
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
                            AddHandler loControl.KeyPress, AddressOf ManejoEvento_KeyPress
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
                                        AddHandler loControl.KeyPress, AddressOf ManejoEvento_KeyPress
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

        Dim loDatos As New Ee060entmercaderia
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
    End Sub
    Private Sub TextBox_Click(sender As Object, e As EventArgs)
        CType(sender, TextBox).SelectAll()
    End Sub
    Private Sub lblCompNeta_mb_ND_Click(sender As Object, e As EventArgs) Handles lblCompNeta_mb_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblCompNeta_mb_ND.Visible = False
        txtCompNeta_mb_ND.Focus()
        txtCompNeta_mb_ND.SelectAll()
    End Sub
    Private Sub txtCompNeta_mb_ND_GotFocus(sender As Object, e As EventArgs) Handles txtCompNeta_mb_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblCompNeta_mb_ND.Visible = False
        txtCompNeta_mb_ND.Focus()
        txtCompNeta_mb_ND.SelectAll()
    End Sub
    Private Sub lblCompImpuesto_mb_ND_Click(sender As Object, e As EventArgs) Handles lblCompImpuesto_mb_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblCompImpuesto_mb_ND.Visible = False
        txtCompImpuesto_mb_ND.Focus()
        txtCompImpuesto_mb_ND.SelectAll()
    End Sub
    Private Sub txtCompImpuesto_mb_ND_GotFocus(sender As Object, e As EventArgs) Handles txtCompImpuesto_mb_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblCompImpuesto_mb_ND.Visible = False
        txtCompImpuesto_mb_ND.Focus()
        txtCompImpuesto_mb_ND.SelectAll()
    End Sub
    Private Sub lblGastNeto_mb_ND_Click(sender As Object, e As EventArgs) Handles lblGastNeto_mb_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblGastNeto_mb_ND.Visible = False
        txtGastNeto_mb_ND.Focus()
        txtGastNeto_mb_ND.SelectAll()
    End Sub
    Private Sub txtGastNeto_mb_ND_GotFocus(sender As Object, e As EventArgs) Handles txtGastNeto_mb_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblGastNeto_mb_ND.Visible = False
        txtCompImpuesto_mb_ND.Focus()
        txtCompImpuesto_mb_ND.SelectAll()
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
    Private Sub lblTotalGeneral_mb_Click(sender As Object, e As EventArgs)
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblTotalGeneral_mb.Visible = False
        txtTotalGeneral_mb.Focus()
        txtTotalGeneral_mb.SelectAll()
    End Sub
    Private Sub txtTotalGeneral_mb_GotFocus(sender As Object, e As EventArgs) Handles txtTotalGeneral_mb.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Or Me.Tag.ToString = sAGREGAR_ Or Me.Tag.ToString = sMODIFICAR_ Then Exit Sub
        lblTotalGeneral_mb.Visible = False
        txtTotalGeneral_mb.Focus()
        txtTotalGeneral_mb.SelectAll()
    End Sub
    Private Function LFsTituloImporte(ByVal psTitulo As String, Optional ByVal pbUpperCase As Boolean = False) As String
        Dim lsResultado As String
        Dim lsSeparador As String = lblTituloImporte.Tag.ToString
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
    Private Sub LPGeneraDetalleE061(ByVal piCodEmpresa As Integer, ByVal piCodDeposito As Integer, ByVal piNumTransaccion As Integer)
        Dim lsUbicaciones As String = ""
        Dim loDatos As New Ee051compras
        Dim lsSQL As String = GFsGeneraSQL("GeneraDetalleE061")
        lsSQL = lsSQL.Replace("&codempresa", piCodEmpresa.ToString)
        lsSQL = lsSQL.Replace("&numtransaccion", piNumTransaccion.ToString)
        Dim loDataReader As Common.DbDataReader = loDatos.RecuperarConsulta(lsSQL)
        Dim loE061 As New Ee061entmercaderia
        Dim liNumOrden As Integer
        Dim loB040 As New Eb040depositos
        loB040.codEmpresa = piCodEmpresa
        loB040.coddeposito = piCodDeposito
        If loB040.GetPK = sOk_ Then
            lsUbicaciones = loB040.ubicaciones
        End If
        loB040.CerrarConexion()
        Dim ldCompNeta As Decimal = 0.00D
        Dim ldCompImpuesto As Decimal = 0.00D
        Dim loFrmProcesamiento As New frmProcesamiento
        loFrmProcesamiento.TopMost = True
        loFrmProcesamiento.Show()
        loFrmProcesamiento.lblTitulo.Text = "generando detalle de entradas..."
        loFrmProcesamiento.lblTitulo.Refresh()
        While loDataReader.Read()
            liNumOrden = loE061.ReservarRegistro(piCodEmpresa, piNumTransaccion)
            Dim lsMostrar As String = loDataReader.Item("nommercaderia").ToString & sSF_ & loDataReader.Item("codunidad").ToString & sSF_ & Decimal.Parse(Decimal.Parse(loDataReader.Item("cantentrada").ToString).ToString(sFormatF_))
            loFrmProcesamiento.lblRegistroLeido.Text = lsMostrar
            loFrmProcesamiento.lblRegistroLeido.Refresh()

            loE061.codempresa = piCodEmpresa
            loE061.numtransaccion = piNumTransaccion
            loE061.numorden = liNumOrden
            loE061.codubicacion = sNOAPLICA_
            If lsUbicaciones = sSi_ Then
                loE061.codubicacion = GFsParametroObtener(sGeneral_, "Ubicacion predeterminada por Deposito - Empresa:" & piCodEmpresa.ToString & ", Deposito:" & piCodDeposito.ToString)
            End If
            loE061.codmercaderia = loDataReader.Item("codmercaderia").ToString
            loE061.nommercaderia = loDataReader.Item("nommercaderia").ToString
            loE061.iva = loDataReader.Item("iva").ToString
            loE061.codunidad = loDataReader.Item("codunidad").ToString
            loE061.cantentrada = Decimal.Parse(Decimal.Parse(loDataReader.Item("cantentrada").ToString).ToString(sFormatF_))
            loE061.cantsalida = Decimal.Parse(Decimal.Parse(loDataReader.Item("cantsalida").ToString).ToString(sFormatF_))
            loE061.costo_mb = Decimal.Parse(Decimal.Parse(loDataReader.Item("costo_mb").ToString).ToString(sFormatF_))
            loE061.costoimpuesto_mb = Decimal.Parse(Decimal.Parse(loDataReader.Item("costoimpuesto_mb").ToString).ToString(sFormatF_))
            loE061.compneta_mb = Decimal.Parse(Decimal.Parse(loDataReader.Item("compneta_mb").ToString).ToString(sFormatF_))
            loE061.compimpuesto_mb = Decimal.Parse(Decimal.Parse(loDataReader.Item("compimpuesto_mb").ToString).ToString(sFormatF_))
            loE061.gastneto_mb = Decimal.Parse(Decimal.Parse(loDataReader.Item("gastneto_mb").ToString).ToString(sFormatF_))
            loE061.gastimpuesto_mb = Decimal.Parse(Decimal.Parse(loDataReader.Item("gastimpuesto_mb").ToString).ToString(sFormatF_))
            loE061.estado = sActivo_
            ldCompNeta += loE061.compneta_mb
            ldCompImpuesto += loE061.compimpuesto_mb
            Try
                loE061.Put(sNo_, sSi_, sAGREGAR_)
                lsMostrar = loDataReader.Item("nommercaderia").ToString & sSF_ & loDataReader.Item("codunidad").ToString & sSF_ & Decimal.Parse(Decimal.Parse(loDataReader.Item("cantentrada").ToString).ToString(sFormatF_))
                loFrmProcesamiento.lblRegistroProcesado.Text = lsMostrar
                loFrmProcesamiento.lblRegistroProcesado.Refresh()
            Catch ex As Exception
                GFsAvisar("Error al agregar detalle en E061", sMENSAJE_, "Por favor avise al Dpto. de Informatica.")
            End Try
            loFrmProcesamiento.Refresh()
        End While
        Dim loE060 As New Ee060entmercaderia
        loE060.codempresa = piCodEmpresa
        loE060.numtransaccion = piNumTransaccion
        If loE060.GetPK = sOk_ Then
            loE060.codempresa = piCodEmpresa
            loE060.numtransaccion = piNumTransaccion
            loE060.compneta_mb = ldCompNeta
            loE060.compimpuesto_mb = ldCompImpuesto
            loE060.estado = sEnCosteo_
            loE060.Put(sNo_, sSi_)
        End If
        loFrmProcesamiento.Close()
        loFrmProcesamiento.Dispose()
        loDataReader.Close()
        loDatos.CerrarConexion()
    End Sub
End Class