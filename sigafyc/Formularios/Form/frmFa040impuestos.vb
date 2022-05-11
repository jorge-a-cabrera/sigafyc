Imports System.ComponentModel
Imports System.Globalization
Public Class frmFa040impuestos
    Private msValidado() As String
    Private msRequeridos As String() = {"operacion", "codimpuesto", "nombre", "porcbaseimpo", "aplicacion", "tipovalor", "valor"}
    Private moRequeridos As New ArrayList(msRequeridos)

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Tag = sCancelar_
        GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en CANCELAR.")
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If InStr(sAGREGAR_ & sMODIFICAR_, Me.Tag.ToString) > 0 Then
            msValidado = GFsValidacionFinal(TabControl1).Split(sSF_)
            If InStr(msValidado(0), sCancelar_) > 0 Then
                GFsAvisar("Validacion final" & ControlChars.CrLf & msValidado(1), sMENSAJE_, "No han sido ingresado correctamente todos los datos")
                txtCodigo_AN.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ea040impuestos
                        LPTruncaSegunLongitud()
                        loDatos.operacion = cmbOperacion.Text
                        loDatos.codImpuesto = txtCodigo_AN.Text
                        loDatos.nombre = txtNombre_AN.Text
                        loDatos.porcBaseImpo = Decimal.Parse(txtPorcBaseImpo_ND.Text)
                        loDatos.tipoValor = cmbTipoValor.Text.Substring(0, 1)
                        loDatos.codMoneda = txtCodMoneda_AN.Text
                        loDatos.valor = Decimal.Parse(txtValor_ND.Text.ToString)
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        loDatos.Add()
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Ea040impuestos
                        loDatos.operacion = cmbOperacion.Text
                        loDatos.codImpuesto = txtCodigo_AN.Text
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.operacion = cmbOperacion.Text
                            loDatos.codImpuesto = txtCodigo_AN.Text
                            loDatos.nombre = txtNombre_AN.Text
                            loDatos.porcBaseImpo = Decimal.Parse(txtPorcBaseImpo_ND.Text)
                            loDatos.tipoValor = cmbTipoValor.Text.Substring(0, 1)
                            loDatos.codMoneda = txtCodMoneda_AN.Text
                            loDatos.valor = Decimal.Parse(txtValor_ND.Text.ToString)
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
                Me.AccessibleName = txtCodigo_AN.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ea040impuestos
                loDatos.operacion = cmbOperacion.Text
                loDatos.codImpuesto = txtCodigo_AN.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.operacion = cmbOperacion.Text
                    loDatos.codImpuesto = txtCodigo_AN.Text
                    loDatos.Del()
                End If
                loDatos.CerrarConexion()
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
                Case "nombre"
                    lsValorInicial = "Impuesto Codigo " & txtCodigo_AN.Text
                Case "porcbaseimpo"
                    lsValorInicial = "100.00"
                Case "operacion", "tipovalor"
                    lsValorInicial = CType(sender, ComboBox).Items(0).ToString
                Case "valor"
                    Select Case cmbTipoValor.Text.Substring(0, 1)
                        Case sPorcentaje_
                            lsValorInicial = "100.00"
                        Case sImporte_
                            lsValorInicial = "1.00"
                    End Select
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
            Exit Sub
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codimpuesto"
                    Dim loFK As New Ea040impuestos
                    Dim lsResultado As String = ""
                    loFK.operacion = cmbOperacion.Text
                    loFK.codImpuesto = txtCodigo_AN.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    loFK = Nothing
                    If lsResultado = sOk_ Then
                        GFsAvisar(cmbOperacion.Text & ": " & txtCodigo_AN.Text & ", ya existe. Favor verifique los datos ingresados", sMENSAJE_, "La operación y codigo de impuesto no pueden repetirse")
                        e.Cancel = True
                        Exit Sub
                    End If

                Case "porcbaseimpo"
                    If Not IsNumeric(txtPorcBaseImpo_ND.Text) Then
                        GFsAvisar("El campo valor debe ser numerico", sMENSAJE_, "Por favor corrijalo para proseguir.")
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim ldPorcBaseImpo As Decimal = Decimal.Parse(txtPorcBaseImpo_ND.Text.ToString)
                    If ldPorcBaseImpo > 100 Then
                        ldPorcBaseImpo = 100
                    End If
                    If ldPorcBaseImpo < 0 Then
                        ldPorcBaseImpo = 0
                    End If
                    txtPorcBaseImpo_ND.Text = ldPorcBaseImpo.ToString(sFormatF_)

                Case "tipovalor"
                    Select Case cmbTipoValor.Text
                        Case sPorcentaje_
                            txtCodMoneda_AN.Text = ""
                            txtCodMoneda_AN.ReadOnly = True
                        Case sImporte_
                            txtCodMoneda_AN.ReadOnly = False
                    End Select

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
                    End If
                    loFK.CerrarConexion()

                Case "valor"
                    If Not IsNumeric(txtValor_ND.Text) Then
                        GFsAvisar("El campo valor debe ser numerico", sMENSAJE_, "Por favor corrijalo para proseguir.")
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim ldValor As Decimal = Decimal.Parse(txtValor_ND.Text.ToString)
                    Select Case cmbTipoValor.Text
                        Case sPorcentaje_
                            If ldValor > 100 Then
                                ldValor = 100
                            End If
                            If ldValor < 0 Then
                                ldValor = 0
                            End If
                        Case sImporte_
                            If ldValor < 0 Then
                                ldValor = 1
                            End If
                    End Select
                    txtValor_ND.Text = ldValor.ToString(sFormatF_)
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

        msEntidad = "Impuesto"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                LPLimpiaControlesEntrada()
                cmbOperacion.Text = CType(entidad, Ea040impuestos).operacion
                cmbOperacion.Tag = sOk_
            Case Else
                cmbOperacion.Text = CType(entidad, Ea040impuestos).operacion
                txtCodigo_AN.Text = CType(entidad, Ea040impuestos).codImpuesto
                txtNombre_AN.Text = CType(entidad, Ea040impuestos).nombre
                Select Case CType(entidad, Ea040impuestos).tipoValor
                    Case sPorcentaje_.Substring(0, 1)
                        cmbTipoValor.Text = sPorcentaje_
                    Case sImporte_.Substring(0, 1)
                        cmbTipoValor.Text = sImporte_
                End Select
                txtPorcBaseImpo_ND.Text = CType(entidad, Ea040impuestos).porcBaseImpo.ToString
                txtCodMoneda_AN.Text = CType(entidad, Ea040impuestos).codMoneda
                txtValor_ND.Text = CType(entidad, Ea040impuestos).valor.ToString
                cmbEstado.Text = CType(entidad, Ea040impuestos).estado

                cmbOperacion.Tag = sOk_
                txtCodigo_AN.Tag = sOk_
                txtNombre_AN.Tag = sOk_
                txtPorcBaseImpo_ND.Tag = sOk_
                cmbTipoValor.Tag = sOk_
                txtCodMoneda_AN.Tag = sOk_
                txtValor_ND.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select

        'Habilita o deshabilita los controles de edición
        cmbOperacion.Enabled = True
        txtCodigo_AN.Enabled = True
        txtNombre_AN.Enabled = True
        txtPorcBaseImpo_ND.Enabled = True
        cmbTipoValor.Enabled = True
        txtCodMoneda_AN.Enabled = True
        txtValor_ND.Enabled = True
        cmbEstado.Enabled = True

        cmbOperacion.AccessibleName = "operacion"
        txtCodigo_AN.AccessibleName = "codimpuesto"
        txtNombre_AN.AccessibleName = "nombre"
        txtPorcBaseImpo_ND.AccessibleName = "porcbaseimpo"
        cmbTipoValor.AccessibleName = "tipovalor"
        txtCodMoneda_AN.AccessibleName = "codmoneda"
        txtValor_ND.AccessibleName = "valor"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                'CONDICIONANTE ANTES DE CARGAR EL FORMULARIO CUANDO LA ACCION ES AGREGAR
                cmbOperacion.Enabled = False
                txtCodMoneda_AN.ReadOnly = True

            Case sMODIFICAR_
                cmbOperacion.Enabled = False
                txtCodigo_AN.Enabled = False
                txtCodMoneda_AN.ReadOnly = True
                If cmbTipoValor.Text = sImporte_ Then
                    txtCodMoneda_AN.ReadOnly = False
                End If

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
    End Sub

    Private Sub LPInicializaParametros()
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String = ""
        Dim lsValor As String = ""
        Dim lsCodigo As String = ""

        lsClave = "a040impuestos.operacion"
        lsValor = sVenta_ & sSF_ & sCompra_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbOperacion.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbOperacion.Items.Add(lsValor)
        Next

        lsClave = "a040impuestos.tipovalor"
        lsValor = sPorcentaje_ & sSF_ & sImporte_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipoValor.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipoValor.Items.Add(lsValor)
        Next
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
                cmbOperacion.Focus()
            Case sMODIFICAR_
                cmbOperacion.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub LPDespliegaDescripciones()
        Dim lsCodMoneda As String = ""
        Dim lsDecimales As String = ""
        Dim lsCulture As String = ""

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
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        cmbOperacion.MaxLength = 15
        txtCodigo_AN.MaxLength = 15
        txtNombre_AN.MaxLength = 45
        txtPorcBaseImpo_ND.MaxLength = 5
        cmbTipoValor.MaxLength = 1
        txtCodMoneda_AN.MaxLength = 3
        txtValor_ND.MaxLength = 16
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
End Class