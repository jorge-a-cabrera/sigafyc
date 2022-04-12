Imports System.ComponentModel
Imports System.Globalization

Public Class frmFe020listaprecio
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "codmercaderia", "codunidad", "vigencia", "tipoprecio", "valor", "codmoneda", "estado"}
    Private moRequeridos As New ArrayList(msRequeridos)

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LPOperacionCancelada()
    End Sub

    Private Sub LPOperacionCancelada()
        Me.Tag = sCancelar_
        GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en CANCELAR.")
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If InStr(sAGREGAR_ & sMODIFICAR_, Me.Tag.ToString) > 0 Then
            msValidado = GFsValidacionFinal(TabControl1).Split(sSF_)

            If InStr(msValidado(0), sCancelar_) > 0 Then
                GFsAvisar("Validacion final" & ControlChars.CrLf & msValidado(1), sMENSAJE_, "No han sido ingresado correctamente todos los datos")
                txtCodMercaderia_AN.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ee020listaprecio
                        LPTruncaSegunLongitud()
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
                        loDatos.vigencia = txtVigencia_FE.Text
                        loDatos.tipoprecio = cmbTipoPrecio.Text
                        loDatos.valor = Decimal.Parse(Decimal.Parse(txtValor_ND.Text).ToString(sFormatF_))
                        loDatos.codmoneda = txtCodMoneda_AN.Text
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        Try
                            loDatos.Add()
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                    Case sMODIFICAR_
                        Dim loDatos As New Ee020listaprecio
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
                        loDatos.vigencia = txtVigencia_FE.Text
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            Try
                                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                                loDatos.codmercaderia = txtCodMercaderia_AN.Text
                                loDatos.codunidad = txtCodUnidad_AN.Text
                                loDatos.vigencia = txtVigencia_FE.Text
                                loDatos.tipoprecio = cmbTipoPrecio.Text
                                loDatos.valor = Decimal.Parse(Decimal.Parse(txtValor_ND.Text).ToString(sFormatF_))
                                loDatos.codmoneda = txtCodMoneda_AN.Text
                                If cmbEstado.Text.Trim.Length > 0 Then
                                    loDatos.estado = cmbEstado.Text
                                End If
                                loDatos.Put()
                            Catch ex As Exception
                                GFsAvisar("Problema durante la actualización lista precio. Error: " & ex.Message, sMENSAJE_, "Favor verificar lo acontecido.")
                            End Try
                        End If
                        loDatos.CerrarConexion()
                End Select
                Me.Tag = sOk_
                '-->  .AccesibleName envia al Browse la información del codigo que luego deberia 
                '-->  ser usado para la localización del registro en el DataGridView
                Me.AccessibleName = txtCodMercaderia_AN.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ee020listaprecio
                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.codmercaderia = txtCodMercaderia_AN.Text
                loDatos.codunidad = txtCodUnidad_AN.Text
                loDatos.vigencia = txtVigencia_FE.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.codmercaderia = txtCodMercaderia_AN.Text
                    loDatos.codunidad = txtCodUnidad_AN.Text
                    loDatos.vigencia = txtVigencia_FE.Text
                    Try
                        loDatos.Del()
                    Catch ex As Exception
                        GFsAvisar("Problema durante la eliminación.", sMENSAJE_, "Favor verificar lo acontecido.")
                    End Try
                End If
                loDatos.CerrarConexion()
                loDatos = Nothing
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
                Case "vigencia"
                    lsValorInicial = Now.ToString(sFormatoFechaHora1_)
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
            Exit Sub
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codmercaderia"
                    Dim loFK As New Ed030mercsalida
                    Dim lsResultado As String
                    loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.codmercaderia = txtCodMercaderia_AN.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBd030mercsalida
                        loLookUp.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodMercaderia_AN.Text = CType(loLookUp.entidad, Ed030mercsalida).codmercaderia
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodMercaderia_AN.Tag = sOk_
                    loFK.CerrarConexion()

                Case "codunidad"
                    Dim loFK As New Eb110undalternativas
                    Dim lsResultado As String
                    loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.tipo = sEntrada_
                    loFK.codmercaderia = txtCodMercaderia_AN.Text
                    loFK.codunidad = txtCodUnidad_AN.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBb110undalternativas
                        loLookUp.Tag = sELEGIR_
                        loLookUp.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.tipo = sEntrada_
                        loLookUp.codmercaderia = txtCodMercaderia_AN.Text
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodUnidad_AN.Text = CType(loLookUp.entidad, Eb110undalternativas).codunidad
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodUnidad_AN.Tag = sOk_
                    loFK.CerrarConexion()

                Case "codunidad"
                    Dim loFK As New Eb110undalternativas
                    Dim lsResultado As String
                    loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.tipo = sSalida_
                    loFK.codmercaderia = txtCodMercaderia_AN.Text
                    loFK.codunidad = txtCodUnidad_AN.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBb110undalternativas
                        loLookUp.Tag = sELEGIR_
                        loLookUp.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.tipo = sSalida_
                        loLookUp.codmercaderia = txtCodMercaderia_AN.Text
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodUnidad_AN.Text = CType(loLookUp.entidad, Eb110undalternativas).codunidad
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodUnidad_AN.Tag = sOk_
                    loFK.CerrarConexion()

                Case "vigencia"
                    If Not IsDate(txtVigencia_FE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtVigencia_FE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                    Else
                        Dim ldFecha As Date = Date.Parse(txtVigencia_FE.Text.ToString)
                        txtVigencia_FE.Text = ldFecha.ToString(sFormatoFechaHora1_)
                    End If
                    If txtVigencia_FE.Text < Today.ToString(sFormatoFechaHora1_) Then
                        GFsAvisar("La validez no puede ser retroactivo", sMENSAJE_, "reintentelo de nuevo")
                        txtVigencia_FE.Text = Now.ToString(sFormatoFechaHora1_)
                        e.Cancel = True
                    End If

                Case "tipoprecio"
                    If cmbTipoPrecio.Text = sPorcentaje_ Then
                        lblCodMoneda.Visible = False
                        lblNombreMoneda.Visible = False
                        txtCodMoneda_AN.Visible = False
                    Else
                        lblCodMoneda.Visible = True
                        txtCodMoneda_AN.Visible = True
                        lblNombreMoneda.Visible = True
                    End If

                Case "valor"
                    If IsNumeric(txtValor_ND.Text) Then
                        Dim ldValor As Decimal = Decimal.Parse(txtValor_ND.Text)
                        Select Case cmbTipoPrecio.Text
                            Case sPorcentaje_
                                If Not (ldValor >= 1D And ldValor <= 100D) Then
                                    GFsAvisar("Debe ingresar un valor entre [1 - 100]", sMENSAJE_, "reintentelo de nuevo")
                                    e.Cancel = True
                                    Exit Sub
                                End If
                            Case sImporte_
                                If ldValor < 0.00D Then
                                    GFsAvisar("Debe ingresar mayor a 1", sMENSAJE_, "reintentelo de nuevo")
                                    e.Cancel = True
                                    Exit Sub
                                End If
                        End Select
                    End If

                Case "codmoneda"
                    If txtCodMoneda_AN.Text <> "***" Then
                        Dim loFK As New Ea010monedas
                        Dim lsResultado As String
                        loFK.codMoneda = txtCodMoneda_AN.Text
                        lsResultado = loFK.GetPK
                        loFK.CerrarConexion()
                        If lsResultado = sSinRegistros_ Then
                            Dim loLookUp As New frmBa010monedas
                            loLookUp.Tag = sELEGIR_
                            GPCargar(loLookUp)
                            If loLookUp.entidad IsNot Nothing Then
                                txtCodMoneda_AN.Text = CType(loLookUp.entidad, Ea010monedas).codMoneda
                            Else
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If
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
        LPInicializaParametros()
        LPInicializaMaxLength()
        LPInicializaControles()
        ' Inicializa los controles de edición con los valores pertinentes
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        msEntidad = "lista de precio"
        DesplegarMensaje()

        lblValor_ND.AutoSize = False
        lblValor_ND.Top = txtValor_ND.Top
        lblValor_ND.Left = txtValor_ND.Left
        lblValor_ND.Width = txtValor_ND.Width
        lblValor_ND.Height = txtValor_ND.Height
        lblValor_ND.Visible = False

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                txtCodEmpresa_NE.Text = CType(entidad, Ee020listaprecio).codEmpresa.ToString
                txtCodMercaderia_AN.Text = CType(entidad, Ee020listaprecio).codmercaderia
                If txtCodMercaderia_AN.Text = sTodas_.Trim.ToUpper Then
                    txtCodMercaderia_AN.Text = ""
                End If
                txtCodUnidad_AN.Text = CType(entidad, Ee020listaprecio).codunidad
                If txtCodUnidad_AN.Text = sTodas_.Trim.ToUpper Then
                    txtCodUnidad_AN.Text = ""
                End If

            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ee020listaprecio).codEmpresa.ToString
                txtCodMercaderia_AN.Text = CType(entidad, Ee020listaprecio).codmercaderia
                txtCodUnidad_AN.Text = CType(entidad, Ee020listaprecio).codunidad
                txtVigencia_FE.Text = CType(entidad, Ee020listaprecio).vigencia
                cmbTipoPrecio.Text = CType(entidad, Ee020listaprecio).tipoprecio
                txtValor_ND.Text = CType(entidad, Ee020listaprecio).valor.ToString
                txtValor_ND.AccessibleDescription = CType(entidad, Ee020listaprecio).valor.ToString
                txtCodMoneda_AN.Text = CType(entidad, Ee020listaprecio).codmoneda
                cmbEstado.Text = CType(entidad, Ee020listaprecio).estado

                txtCodEmpresa_NE.Tag = sOk_
                txtCodMercaderia_AN.Tag = sOk_
                txtCodUnidad_AN.Tag = sOk_
                txtVigencia_FE.Tag = sOk_
                cmbTipoPrecio.Tag = sOk_
                txtValor_ND.Tag = sOk_
                txtCodMoneda_AN.Tag = sOk_
                cmbEstado.Tag = sOk_

        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtCodMercaderia_AN.Enabled = True
        txtCodUnidad_AN.Enabled = True
        txtVigencia_FE.Enabled = True
        cmbTipoPrecio.Enabled = True
        txtValor_ND.Enabled = True
        txtCodMoneda_AN.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtCodMercaderia_AN.AccessibleName = "codmercaderia"
        txtCodUnidad_AN.AccessibleName = "codunidad"
        txtVigencia_FE.AccessibleName = "vigencia"
        cmbTipoPrecio.AccessibleName = "tipoprecio"
        txtValor_ND.AccessibleName = "valor"
        txtCodMoneda_AN.AccessibleName = "codmoneda"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                If txtCodMercaderia_AN.Text.Trim.Length > 0 Then
                    txtCodMercaderia_AN.Enabled = False
                    txtCodMercaderia_AN.Tag = sOk_
                End If
                If txtCodUnidad_AN.Text.Trim.Length > 0 Then
                    txtCodUnidad_AN.Enabled = False
                    txtCodUnidad_AN.Tag = sOk_
                End If

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodMercaderia_AN.Enabled = False
                txtCodMercaderia_AN.Tag = sOk_
                txtCodUnidad_AN.Enabled = False
                txtCodUnidad_AN.Tag = sOk_
                txtVigencia_FE.Enabled = False
                txtVigencia_FE.Tag = sOk_

            Case sCONSULTAR_, sBORRAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb|gbx", loControls.Item(liNDX).Name.Substring(0, 3)) > 0 Then
                        loControls.Item(liNDX).Enabled = False
                    End If
                Next
                loControls = Me.TabPage2.Controls
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb|gbx", loControls.Item(liNDX).Name.Substring(0, 3)) > 0 Then
                        loControls.Item(liNDX).Enabled = False
                    End If
                Next
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '--> AQUI DEBE INGRESARSE EL FOCUS DEL PRIMER ELEMENTO DEL FORMULARIO
        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodMercaderia_AN.Focus()
            Case sMODIFICAR_
                cmbTipoPrecio.Focus()
        End Select
    End Sub

    Private Sub LPDespliegaDescripciones()
        Dim ldValorInicial As Decimal = 0.00D
        Dim ldEquivalente As Decimal
        Dim lsUnidad As String = ""

        If cmbTipoPrecio.Text = sPorcentaje_ Then
            txtCodMoneda_AN.Text = sCero3_.Replace("0", "*")
            txtCodMoneda_AN.Tag = sOk_
            lblCodMoneda.Visible = False
            lblNombreMoneda.Visible = False
            txtCodMoneda_AN.Visible = False
        Else
            lblCodMoneda.Visible = True
            txtCodMoneda_AN.Visible = True
            lblNombreMoneda.Visible = True
        End If

        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString("D" & txtCodEmpresa_NE.MaxLength.ToString)
            txtCodEmpresa_NE.Refresh()
            Dim loFK As New Ec001empresas
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loFK.nombre
                lblNombreEmpresa.Refresh()
            End If
            loFK.CerrarConexion()
        End If

        lblNombreMercaderia.Text = ""
        If txtCodMercaderia_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Ed030mercsalida
            loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loFK.codmercaderia = txtCodMercaderia_AN.Text
            If loFK.GetPK = sOk_ Then
                lblNombreMercaderia.Text = loFK.nombre
                lblNombreMercaderia.Refresh()
            End If
            loFK.CerrarConexion()
        End If

        lblNombreUnidad.Text = ""
        If txtCodUnidad_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Eb110undalternativas
            loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loFK.tipo = sSalida_
            loFK.codmercaderia = txtCodMercaderia_AN.Text
            loFK.codunidad = txtCodUnidad_AN.Text
            If loFK.GetPK = sOk_ Then
                ldEquivalente = loFK.cantidad
                lblNombreUnidad.Text = loFK.nomunidad
                lblNombreUnidad.Refresh()
            End If
            loFK.CerrarConexion()
        End If

        Dim lsDecimales As String = ""
        Dim lsCulture As String = ""
        lblNombreMoneda.Text = ""
        If txtCodMoneda_AN.Text.Trim.Length > 0 Then
            Dim loFK1 As New Ea010monedas
            loFK1.codMoneda = txtCodMoneda_AN.Text
            If loFK1.GetPK = sOk_ Then
                lblNombreMoneda.Text = loFK1.nombre
                lsDecimales = loFK1.decimales.ToString
                lsCulture = loFK1.culture
            End If
            loFK1.CerrarConexion()
        End If

        If txtValor_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtValor_ND.Text) Then
                Dim ldValor As Decimal = Decimal.Parse(txtValor_ND.Text)
                Select Case cmbTipoPrecio.Text
                    Case sImporte_
                        lblValor_ND.Text = ldValor.ToString(sFormatC_ & lsDecimales, CultureInfo.CreateSpecificCulture(lsCulture))
                    Case sPorcentaje_
                        lblValor_ND.Text = ldValor.ToString(sFormatF_)
                End Select
                Select Case Me.Tag.ToString
                    Case sAGREGAR_, sMODIFICAR_
                        lblValor_ND.BackColor = txtValor_ND.BackColor
                    Case sCONSULTAR_, sBORRAR_
                        lblValor_ND.BackColor = Me.BackColor
                        lblValor_ND.ForeColor = Me.ForeColor
                End Select
                lblValor_ND.Visible = True
            End If
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodMercaderia_AN.MaxLength = 20
        txtCodUnidad_AN.MaxLength = 6
        txtVigencia_FE.MaxLength = 19
        cmbTipoPrecio.MaxLength = 15
        txtValor_ND.MaxLength = 17
        txtCodMoneda_AN.MaxLength = 3
        cmbEstado.MaxLength = 15
    End Sub

    Private Sub LPInicializaControles()
        For Each loTabPage As TabPage In TabControl1.TabPages
            If loTabPage.AccessibleName = sActivo_ Then
                For Each loControl As Control In loTabPage.Controls
                    Select Case loControl.Name.Substring(0, 3)
                        Case sPrefijoTextBox_
                            loControl.Tag = sCancelar_
                            AddHandler loControl.Validating, AddressOf ManejoEvento_Validating
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                            AddHandler loControl.KeyPress, AddressOf ManejoEvento_KeyPress
                        Case sPrefijoComboBox_
                            loControl.Tag = sCancelar_
                            AddHandler loControl.Validating, AddressOf ManejoEvento_Validating
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                        Case sPrefijoRadioButton_
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                        Case sPrefijoGroupBox_
                            For Each loControl1 As Control In loControl.Controls
                                Select Case loControl1.Name.Substring(0, 3)
                                    Case sPrefijoTextBox_
                                        loControl1.Tag = sCancelar_
                                        AddHandler loControl1.Validating, AddressOf ManejoEvento_Validating
                                        AddHandler loControl1.Validated, AddressOf ManejoEvento_Validated
                                        AddHandler loControl1.KeyDown, AddressOf ManejoEvento_KeyDown
                                        AddHandler loControl1.KeyPress, AddressOf ManejoEvento_KeyPress
                                    Case sPrefijoComboBox_
                                        loControl1.Tag = sCancelar_
                                        AddHandler loControl1.Validating, AddressOf ManejoEvento_Validating
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

    Private Sub LPInicializaParametros()
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String
        Dim lsValor As String
        Dim lsCodigo As String

        lsClave = "e020listaprecio.tipoprecio"
        lsValor = sPorcentaje_ & sSF_ & sImporte_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipoPrecio.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipoPrecio.Items.Add(lsValor)
        Next
        If Me.Tag.ToString = sAGREGAR_ Then
            cmbTipoPrecio.Text = cmbTipoPrecio.Items(0).ToString
        End If

    End Sub

    Private Sub lblValor_ND_Click(sender As Object, e As EventArgs) Handles lblValor_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblValor_ND.Visible = False
        txtValor_ND.Focus()
        txtValor_ND.SelectAll()
    End Sub
End Class