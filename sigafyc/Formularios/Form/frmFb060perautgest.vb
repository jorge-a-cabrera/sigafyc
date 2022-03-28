Imports System.ComponentModel
Imports System.Globalization

Public Class frmFb060perautgest
    Private msValidado() As String
    Private msRequeridos As String() = {"tipoperfil", "tipodocumento", "nrodocumento"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msCodMoneda As String = ""
    Private mdPorcentaje As Decimal = 0.00D
    Private mdLimiteCredito As Decimal = 0.00D
    Private mdLimiteHabilitacion As Decimal = 0.00D

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Tag = sCancelar_
        GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en CANCELAR.")
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim liCodigo As Integer = 0
        Dim liValor As Integer = 0
        Dim ldImporte As Decimal = 0.00D
        If InStr(sAGREGAR_ & sMODIFICAR_, Me.Tag.ToString) > 0 Then
            msValidado = GFsValidacionFinal(TabControl1).Split(sSF_)

            If InStr(msValidado(0), sCancelar_) > 0 Then
                GFsAvisar("Validacion final" & ControlChars.CrLf & msValidado(1), sMENSAJE_, "No han sido ingresado correctamente todos los datos")
                cmbTipoDocumento.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Eb060perautgest
                        LPTruncaSegunLongitud()
                        liCodigo = Integer.Parse(txtCodEmpresa_NE.Text)
                        loDatos.codEmpresa = liCodigo
                        loDatos.tipoPerfil = cmbTipoPerfil.Text.Trim
                        loDatos.tipoDocumento = cmbTipoDocumento.Text.Trim
                        loDatos.nroDocumento = txtNroDocumento_SR.Text.Trim
                        loDatos.codMoneda = txtCodMoneda_AN.Text
                        liValor = Integer.Parse(txtDiasVencimiento_NE.Text.ToString)
                        loDatos.diasVencimiento = liValor
                        ldImporte = Decimal.Parse(txtLimiteCredito_ND.Text.ToString)
                        loDatos.limiteCredito = Decimal.Parse(ldImporte.ToString(sFormatF_))
                        ldImporte = Decimal.Parse(txtLimiteHabilitacion_ND.Text)
                        loDatos.limiteHabilitacion = Decimal.Parse(ldImporte.ToString(sFormatF_))
                        liCodigo = Integer.Parse(txtCodSucursal_NE.Text)
                        loDatos.codSucursal = liCodigo
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        loDatos.Add()
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Eb060perautgest
                        liCodigo = Integer.Parse(txtCodEmpresa_NE.Text)
                        loDatos.codEmpresa = liCodigo
                        loDatos.tipoPerfil = cmbTipoPerfil.Text.Trim
                        loDatos.tipoDocumento = cmbTipoDocumento.Text.Trim
                        loDatos.nroDocumento = txtNroDocumento_SR.Text.Trim
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codEmpresa = liCodigo
                            loDatos.tipoPerfil = cmbTipoPerfil.Text.Trim
                            loDatos.tipoDocumento = cmbTipoDocumento.Text.Trim
                            loDatos.nroDocumento = txtNroDocumento_SR.Text.Trim
                            loDatos.codMoneda = txtCodMoneda_AN.Text
                            liValor = Integer.Parse(txtDiasVencimiento_NE.Text.ToString)
                            loDatos.diasVencimiento = liValor
                            ldImporte = Decimal.Parse(txtLimiteCredito_ND.Text.ToString)
                            loDatos.limiteCredito = Decimal.Parse(ldImporte.ToString(sFormatF_))
                            ldImporte = Decimal.Parse(txtLimiteHabilitacion_ND.Text)
                            loDatos.limiteHabilitacion = Decimal.Parse(ldImporte.ToString(sFormatF_))
                            liCodigo = Integer.Parse(txtCodSucursal_NE.Text)
                            loDatos.codSucursal = liCodigo
                            If cmbEstado.Text.Trim.Length > 0 Then
                                loDatos.estado = cmbEstado.Text
                            End If
                            loDatos.Put()
                        End If
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                End Select
                Me.Tag = sOk_
                '-->  .AccesibleName envia al Browse la información del codigo que luego deberia 
                '-->  ser usado para la localización del registro en el DataGridView
                Me.AccessibleName = txtNroDocumento_SR.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Eb060perautgest
                liCodigo = Integer.Parse(txtCodEmpresa_NE.Text)
                loDatos.codEmpresa = liCodigo
                loDatos.tipoPerfil = cmbTipoPerfil.Text
                loDatos.tipoDocumento = cmbTipoDocumento.Text
                loDatos.nroDocumento = txtNroDocumento_SR.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.codEmpresa = liCodigo
                    loDatos.tipoPerfil = cmbTipoPerfil.Text
                    loDatos.tipoDocumento = cmbTipoDocumento.Text
                    loDatos.nroDocumento = txtNroDocumento_SR.Text
                    loDatos.Del()
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
                Case "tipodocumento"
                    lsValorInicial = CType(sender, ComboBox).Items(0).ToString
                Case "codmoneda"
                    lsValorInicial = msCodMoneda
                Case "limitehabilitacion"
                    mdLimiteHabilitacion = mdLimiteCredito * (mdPorcentaje / 100)
                    lsValorInicial = mdLimiteHabilitacion.ToString(sFormatF_)
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
            Exit Sub
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "nrodocumento"
                    Dim loFK As New Ea030personas
                    Dim lsResultado As String = ""
                    loFK.tipoDocumento = cmbTipoDocumento.Text
                    loFK.nroDocumento = txtNroDocumento_SR.Text
                    If loFK.GetPK = sSinRegistros_ Then
                        Dim loLookUp As New frmBa030personas
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            cmbTipoDocumento.Text = CType(loLookUp.entidad, Ea030personas).tipoDocumento
                            txtNroDocumento_SR.Text = CType(loLookUp.entidad, Ea030personas).nroDocumento
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                        loLookUp = Nothing
                    End If
                    loFK.CerrarConexion()
                    loFK = Nothing
                    Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text)
                    Dim loFK1 As New Eb060perautgest
                    loFK1.codEmpresa = liCodEmpresa
                    loFK1.tipoPerfil = cmbTipoPerfil.Text
                    loFK1.tipoDocumento = cmbTipoDocumento.Text
                    loFK1.nroDocumento = txtNroDocumento_SR.Text.Trim
                    If loFK1.GetPK = sOk_ Then
                        GFsAvisar(cmbTipoDocumento.Text & " No.:" & txtNroDocumento_SR.Text.Trim & ", " & cmbTipoPerfil.Text & " para Empresa:" & txtCodEmpresa_NE.Text, sMENSAJE_, "Ya existe, y no puede duplicarse. Favor verifique los datos ingresado sin son los correctos.")
                        e.Cancel = True
                        Exit Sub
                    End If
                Case "codmoneda"
                    If txtCodMoneda_AN.Text.Trim.Length = 0 Then
                        GFsAvisar("Debe ingresar codigo de moneda valido", sMENSAJE_, "Por favor intentelo de nuevo.")
                        e.Cancel = True
                        Exit Sub
                    End If

                    Dim loFK As New Ea010monedas
                    loFK.codMoneda = txtCodMoneda_AN.Text
                    If loFK.GetPK = sSinRegistros_ Then
                        Dim loLookUp As New frmBa010monedas
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodMoneda_AN.Text = CType(loLookUp.entidad, Ea010monedas).codMoneda
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                        loLookUp = Nothing
                    End If
                    loFK.CerrarConexion()
                    loFK = Nothing

                Case "limitecredito"
                    If IsNumeric(txtLimiteCredito_ND.Text) = False Then
                        txtLimiteCredito_ND.Tag = sCancelar_
                        e.Cancel = True
                        Exit Sub
                    End If
                    mdLimiteCredito = Decimal.Parse(txtLimiteCredito_ND.Text.ToString)

                Case "limitehabilitacion"
                    If IsNumeric(txtLimiteHabilitacion_ND.Text) = False Then
                        txtLimiteHabilitacion_ND.Tag = sCancelar_
                        e.Cancel = True
                        Exit Sub
                    End If
                    mdLimiteCredito = Decimal.Parse(txtLimiteCredito_ND.Text.ToString)
                    mdLimiteHabilitacion = Decimal.Parse(txtLimiteHabilitacion_ND.Text.ToString)

                    If mdLimiteCredito > 0 And mdLimiteHabilitacion = 0 Then
                        mdLimiteHabilitacion = mdLimiteCredito * (mdPorcentaje / 100)
                        txtLimiteHabilitacion_ND.Text = mdLimiteHabilitacion.ToString(sFormatF_)
                    End If

                    If mdLimiteHabilitacion > mdLimiteCredito Then
                        mdLimiteHabilitacion = mdLimiteCredito * (mdPorcentaje / 100)
                        txtLimiteHabilitacion_ND.Text = mdLimiteHabilitacion.ToString(sFormatF_)
                    End If


                Case "codsucursal"
                    If IsNumeric(txtCodSucursal_NE.Text) = False Then
                        txtCodSucursal_NE.Tag = sCancelar_
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    Dim liCodSucursal As Integer = Integer.Parse(txtCodSucursal_NE.Text.ToString)
                    If liCodSucursal > 0 Then
                        Dim loSucursal As New Eb070sucursales
                        loSucursal.codEmpresa = liCodEmpresa
                        loSucursal.codSucursal = liCodSucursal
                        If loSucursal.GetPK = sSinRegistros_ Then
                            Dim loLookUp As New frmBb070sucursales
                            loLookUp.codEmpresa = liCodEmpresa
                            loLookUp.Tag = sELEGIR_
                            GPCargar(loLookUp)
                            If loLookUp.entidad IsNot Nothing Then
                                txtCodSucursal_NE.Text = CType(loLookUp.entidad, Eb070sucursales).codSucursal.ToString
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

        msEntidad = "Perfil autorizado de gestión"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                LPLimpiaControlesEntrada()
                txtCodEmpresa_NE.Text = CType(entidad, Eb060perautgest).codEmpresa.ToString
                cmbTipoPerfil.Text = CType(entidad, Eb060perautgest).tipoPerfil
                txtCodEmpresa_NE.Tag = sOk_
                cmbTipoPerfil.Tag = sOk_
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Eb060perautgest).codEmpresa.ToString
                cmbTipoPerfil.Text = CType(entidad, Eb060perautgest).tipoPerfil
                cmbTipoDocumento.Text = CType(entidad, Eb060perautgest).tipoDocumento
                txtNroDocumento_SR.Text = CType(entidad, Eb060perautgest).nroDocumento
                txtCodMoneda_AN.Text = CType(entidad, Eb060perautgest).codMoneda
                txtDiasVencimiento_NE.Text = CType(entidad, Eb060perautgest).diasVencimiento.ToString
                txtLimiteCredito_ND.Text = CType(entidad, Eb060perautgest).limiteCredito.ToString
                txtLimiteHabilitacion_ND.Text = CType(entidad, Eb060perautgest).limiteHabilitacion.ToString
                txtCodSucursal_NE.Text = CType(entidad, Eb060perautgest).codSucursal.ToString
                cmbEstado.Text = CType(entidad, Eb060perautgest).estado
                txtCodEmpresa_NE.Tag = sOk_
                cmbTipoPerfil.Tag = sOk_
                cmbTipoDocumento.Tag = sOk_
                txtNroDocumento_SR.Tag = sOk_
                txtCodMoneda_AN.Tag = sOk_
                txtDiasVencimiento_NE.Tag = sOk_
                txtLimiteCredito_ND.Tag = sOk_
                txtLimiteHabilitacion_ND.Tag = sOk_
                txtCodSucursal_NE.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        LPInicializaPredeterminado()
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        cmbTipoPerfil.Enabled = True
        cmbTipoDocumento.Enabled = True
        txtNroDocumento_SR.Enabled = True
        txtDiasVencimiento_NE.Enabled = True
        txtLimiteCredito_ND.Enabled = True
        txtLimiteHabilitacion_ND.Enabled = True
        txtCodSucursal_NE.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        cmbTipoPerfil.AccessibleName = "tipoperfil"
        cmbTipoDocumento.AccessibleName = "tipodocumento"
        txtNroDocumento_SR.AccessibleName = "nrodocumento"
        txtCodMoneda_AN.AccessibleName = "codmoneda"
        txtDiasVencimiento_NE.AccessibleName = "diasvencimiento"
        txtLimiteCredito_ND.AccessibleName = "limitecredito"
        txtLimiteHabilitacion_ND.AccessibleName = "limitehabilitacion"
        txtCodSucursal_NE.AccessibleName = "codsucursal"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                ' CONDICIONANTE ANTES DE CARGAR EL FORMULARIO CUANDO LA ACCION ES AGREGAR

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                cmbTipoPerfil.Enabled = False
                cmbTipoDocumento.Enabled = False
                txtNroDocumento_SR.Enabled = False

            Case sCONSULTAR_, sBORRAR_
                For Each loTabPage As TabPage In TabControl1.TabPages
                    For Each loControl As Control In loTabPage.Controls
                        Select Case loControl.Name.Substring(0, 3)
                            Case sPrefijoTextBox_
                                loControl.Enabled = False
                            Case sPrefijoComboBox_
                                loControl.Enabled = False
                            Case sPrefijoGroupBox_
                                For Each loControl1 As Control In loControl.Controls
                                    Select Case loControl1.Name.Substring(0, 3)
                                        Case sPrefijoTextBox_
                                            loControl.Enabled = False
                                        Case sPrefijoComboBox_
                                            loControl.Enabled = False
                                    End Select
                                Next
                        End Select
                    Next

                Next
        End Select
        lblNombreEmpresa.Text = ""
        lblNombreSucursal.Text = ""
        lblLimiteCredito.Size = txtLimiteCredito_ND.Size
        lblLimiteCredito.Location = txtLimiteCredito_ND.Location
        lblLimiteCredito.BackColor = Me.BackColor

        lblLimiteHabilitacion.Size = txtLimiteHabilitacion_ND.Size
        lblLimiteHabilitacion.Location = txtLimiteHabilitacion_ND.Location
        lblLimiteHabilitacion.BackColor = Me.BackColor
    End Sub

    Private Sub LPLimpiaControlesEntrada()
        For Each loControl As Control In TabControl1.Controls
            Select Case loControl.Name.ToString.ToLower.Substring(0, 3)
                Case sPrefijoTextBox_
                    loControl.Text = ""
                Case sPrefijoComboBox_
                    loControl.Text = ""
                Case sPrefijoGroupBox_
                    For Each loControl1 As Control In loControl.Controls
                        Select Case loControl1.Name.ToString.ToLower.Substring(0, 3)
                            Case sPrefijoTextBox_
                                loControl1.Text = ""
                            Case sPrefijoComboBox_
                                loControl1.Text = ""
                        End Select
                    Next
            End Select
        Next
    End Sub

    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '--> AQUI DEBE INGRESARSE EL FOCUS DEL PRIMER ELEMENTO DEL FORMULARIO
        Select Case Me.Tag.ToString
            Case sAGREGAR_
                cmbTipoDocumento.Focus()
            Case sMODIFICAR_
                cmbTipoDocumento.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer = 0
        Dim liCodSucursal As Integer = 0
        Dim lsCodMoneda As String = ""
        Dim lsDecimales As String = ""
        Dim lsCulture As String = ""

        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Ec001empresas
            liCodEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loFK.nombre
                msCodMoneda = loFK.codMoneda
            End If
            loFK.CerrarConexion()
            loFK = Nothing
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)
        End If

        lblNombreSucursal.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If txtCodSucursal_NE.Text.Trim.Length > 0 Then
                If Not IsNumeric(txtCodSucursal_NE.Text) Then Exit Sub
                liCodSucursal = Integer.Parse(txtCodSucursal_NE.Text.ToString)

                If liCodSucursal = 0 Then
                    lblNombreSucursal.Text = "TODAS LAS SUCURSALES"
                Else
                    Dim loFK As New Eb070sucursales
                    loFK.codEmpresa = liCodEmpresa
                    loFK.codSucursal = liCodSucursal
                    If loFK.GetPK = sOk_ Then
                        lblNombreSucursal.Text = loFK.nombre
                    End If
                    loFK.CerrarConexion()
                    loFK = Nothing
                End If
            End If
            txtCodSucursal_NE.Text = liCodSucursal.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength)
        End If

        lblNombreMoneda.Text = ""
        If txtCodMoneda_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Ea010monedas
            lsCodMoneda = txtCodMoneda_AN.Text
            loFK.codMoneda = lsCodMoneda
            If loFK.GetPK = sOk_ Then
                lblNombreMoneda.Text = loFK.nombre
                Dim loFK1 As New Ea010monedas
                loFK1.codMoneda = lsCodMoneda
                If loFK1.GetPK = sOk_ Then
                    lsDecimales = loFK1.decimales.ToString
                    lsCulture = loFK1.culture
                End If
            End If
            loFK.CerrarConexion()
            loFK = Nothing
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)
        End If

        txtNombre_AN.Text = ""
        txtAbreviado_AN.Text = ""
        txtDireccion_AN.Text = ""
        txtCiudad_AN.Text = ""
        txtTelefono_AN.Text = ""
        txtEmail_AN.Text = ""
        If txtNroDocumento_SR.Text.Trim.Length > 0 Then
            Dim loPersona As New Ea030personas
            loPersona.tipoDocumento = cmbTipoDocumento.Text
            loPersona.nroDocumento = txtNroDocumento_SR.Text.Trim
            If loPersona.GetPK = sOk_ Then
                txtNombre_AN.Text = loPersona.nombre
                txtAbreviado_AN.Text = loPersona.abreviado
                txtDireccion_AN.Text = loPersona.direccion
                txtCiudad_AN.Text = loPersona.ciudad
                txtTelefono_AN.Text = loPersona.telefono
                txtEmail_AN.Text = loPersona.email
            End If
        End If

        If txtLimiteCredito_ND.Text.Trim.Length > 0 Then
            Dim ldLimiteCredito As Decimal = 0.00D
            If IsNumeric(txtLimiteCredito_ND.Text) Then
                ldLimiteCredito = Decimal.Parse(txtLimiteCredito_ND.Text.ToString)
                lblLimiteCredito.Text = ldLimiteCredito.ToString(sFormatC_ & lsDecimales, CultureInfo.CreateSpecificCulture(lsCulture))
                txtLimiteCredito_ND.ReadOnly = True
                lblLimiteCredito.Visible = True
            End If
        End If

        If txtLimiteHabilitacion_ND.Text.Trim.Length > 0 Then
            Dim ldLimiteHabilitacion As Decimal = 0.00D
            If IsNumeric(txtLimiteHabilitacion_ND.Text) Then
                ldLimiteHabilitacion = Decimal.Parse(txtLimiteHabilitacion_ND.Text.ToString)
                lblLimiteHabilitacion.Text = ldLimiteHabilitacion.ToString(sFormatC_ & lsDecimales, CultureInfo.CreateSpecificCulture(lsCulture))
                txtLimiteHabilitacion_ND.ReadOnly = True
                lblLimiteHabilitacion.Visible = True
            End If
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        cmbTipoPerfil.MaxLength = 20
        cmbTipoDocumento.MaxLength = 15
        txtNroDocumento_SR.MaxLength = 15
        txtCodMoneda_AN.MaxLength = 3
        txtDiasVencimiento_NE.MaxLength = 3
        txtLimiteCredito_ND.MaxLength = 17
        txtLimiteHabilitacion_ND.MaxLength = 17
        txtCodSucursal_NE.MaxLength = 3
        cmbEstado.MaxLength = 15
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
                                    Case sPrefijoComboBox_
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
        Dim lsClave As String = ""
        Dim lsValor As String = ""
        Dim lsCodigo As String = ""

        lsClave = "a030personas.tipodocumento"
        lsValor = "CI" & sSF_ & "RUC" & sSF_ & "PAS" & sSF_ & "DNI"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipoDocumento.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipoDocumento.Items.Add(lsValor)
        Next

        lsClave = "b060perautgest.tipoperfil"
        lsValor = "CLIENTES" & sSF_ & "PROVEEDORES"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipoPerfil.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipoPerfil.Items.Add(lsValor)
        Next
    End Sub

    Private Sub LPInicializaPredeterminado()
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String = ""
        Dim lsValor As String = ""
        Dim lsCodigo As String = ""

        If Me.Tag.ToString = sAGREGAR_ Then
            lsClave = "Empresa:" & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString) & " - Perfil:" & cmbTipoPerfil.Text & " / predeterminado / Dias para vencimiento"
            lsValor = "30"
            lsCodigo = GFsParametroObtener(lsTipo, lsClave)
            If lsCodigo = sRESERVADO_ Then
                lsCodigo = lsValor
                GPParametroGuardar(lsTipo, lsClave, lsCodigo)
            End If
            txtDiasVencimiento_NE.Text = lsCodigo

            lsClave = "Empresa:" & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString) & " - Perfil:" & cmbTipoPerfil.Text & " / predeterminado / Limite Credito"
            lsValor = "0"
            lsCodigo = GFsParametroObtener(lsTipo, lsClave)
            If lsCodigo = sRESERVADO_ Then
                lsCodigo = lsValor
                GPParametroGuardar(lsTipo, lsClave, lsCodigo)
            End If
            txtLimiteCredito_ND.Text = lsCodigo

            lsClave = "Empresa:" & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString) & " - Perfil:" & cmbTipoPerfil.Text & " / predeterminado / Limite para desbloqueo"
            lsValor = "0"
            lsCodigo = GFsParametroObtener(lsTipo, lsClave)
            If lsCodigo = sRESERVADO_ Then
                lsCodigo = lsValor
                GPParametroGuardar(lsTipo, lsClave, lsCodigo)
            End If
            txtLimiteHabilitacion_ND.Text = lsCodigo

            lsCodigo = ""
            Dim loEmpresa As New Ec001empresas
            loEmpresa.codEmpresa = liCodEmpresa
            If loEmpresa.GetPK = sOk_ Then
                lsCodigo = loEmpresa.codMoneda
            End If
            txtCodMoneda_AN.Text = lsCodigo

            loEmpresa.CerrarConexion()
            loEmpresa = Nothing
        End If

        mdPorcentaje = 0.00D
        lsClave = "Empresa:" & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString) & " - Perfil:" & cmbTipoPerfil.Text & " / predeterminado / % del limite credito para desbloqueo"
        lsValor = "50"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        If IsNumeric(lsCodigo) Then
            mdPorcentaje = Decimal.Parse(lsCodigo)
        End If
    End Sub

    Private Sub lblLimiteCredito_Click(sender As Object, e As EventArgs) Handles lblLimiteCredito.Click
        lblLimiteCredito.Visible = False
        txtLimiteCredito_ND.ReadOnly = False
        txtLimiteCredito_ND.Focus()
    End Sub

    Private Sub lblLimiteHabilitacion_Click(sender As Object, e As EventArgs) Handles lblLimiteHabilitacion.Click
        lblLimiteHabilitacion.Visible = False
        txtLimiteHabilitacion_ND.ReadOnly = False
        txtLimiteHabilitacion_ND.Focus()

    End Sub

    Private Sub txtLimiteCredito_ND_GotFocus(sender As Object, e As EventArgs) Handles txtLimiteCredito_ND.GotFocus
        lblLimiteCredito.Visible = False
        lblLimiteCredito.Refresh()
        txtLimiteCredito_ND.ReadOnly = False
        txtLimiteCredito_ND.Refresh()
        txtLimiteCredito_ND.SelectAll()
    End Sub

    Private Sub txtLimiteHabilitacion_ND_GotFocus(sender As Object, e As EventArgs) Handles txtLimiteHabilitacion_ND.GotFocus
        lblLimiteHabilitacion.Visible = False
        lblLimiteHabilitacion.Refresh()
        txtLimiteHabilitacion_ND.ReadOnly = False
        txtLimiteHabilitacion_ND.Refresh()
        txtLimiteHabilitacion_ND.SelectAll()
    End Sub

End Class