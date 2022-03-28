Imports System.ComponentModel

Public Class frmFa030personas
    Private msValidado() As String
    Private msRequeridos As String() = {"tipodocumento", "nrodocumento", "nombre", "abreviado", "direccion", "ciudad", "telefono", "email"}
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
                txtCodigo_SR.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ea030personas
                        LPTruncaSegunLongitud()
                        loDatos.tipoDocumento = cmbTipoDocumento.Text
                        loDatos.nroDocumento = txtCodigo_SR.Text
                        loDatos.nombre = txtNombre_AN.Text
                        loDatos.abreviado = txtAbreviado_AN.Text
                        loDatos.direccion = txtDireccion_AN.Text
                        loDatos.ciudad = txtCiudad_AN.Text
                        loDatos.telefono = txtTelefono_AN.Text
                        loDatos.email = txtEmail_AN.Text
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        loDatos.Add()
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Ea030personas
                        loDatos.tipoDocumento = cmbTipoDocumento.Text
                        loDatos.nroDocumento = txtCodigo_SR.Text
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.tipoDocumento = cmbTipoDocumento.Text
                            loDatos.nroDocumento = txtCodigo_SR.Text
                            loDatos.nombre = txtNombre_AN.Text
                            loDatos.abreviado = txtAbreviado_AN.Text
                            loDatos.direccion = txtDireccion_AN.Text
                            loDatos.ciudad = txtCiudad_AN.Text
                            loDatos.telefono = txtTelefono_AN.Text
                            loDatos.email = txtEmail_AN.Text
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
                Me.AccessibleName = txtCodigo_SR.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ea030personas
                loDatos.tipoDocumento = cmbTipoDocumento.Text
                loDatos.nroDocumento = txtCodigo_SR.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.tipoDocumento = cmbTipoDocumento.Text
                    loDatos.nroDocumento = txtCodigo_SR.Text
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
                Case "abreviado"
                    lsValorInicial = txtNombre_AN.Text
                Case "tipodocumento"
                    lsValorInicial = CType(sender, ComboBox).Items(0).ToString
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
                    loFK.nroDocumento = txtCodigo_SR.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    loFK = Nothing
                    If lsResultado = sOk_ Then
                        GFsAvisar(cmbTipoDocumento.Text & ": " & txtCodigo_SR.Text & ", ya existe. Favor verifique los datos ingresados", sMENSAJE_, "El Tipo documento y numero no pueden repetirse")
                        e.Cancel = True
                        Exit Sub
                    End If
                Case "email"
                    If GFbValidarCuentaEmail(txtEmail_AN.Text) = False Then
                        GFsAvisar("La cuenta introducida [" & txtEmail_AN.Text & "] no es valida como dirección de email.", sMENSAJE_, "Corrija para poder proseguir con la acción.")
                        e.Cancel = True
                        Exit Sub
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
        LPInicializaControles(TabControl1)

        msEntidad = "Persona Física o Juridica"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                LPLimpiaControlesEntrada()
            Case Else
                cmbTipoDocumento.Text = CType(entidad, Ea030personas).tipoDocumento
                txtCodigo_SR.Text = CType(entidad, Ea030personas).nroDocumento
                txtNombre_AN.Text = CType(entidad, Ea030personas).nombre
                txtAbreviado_AN.Text = CType(entidad, Ea030personas).abreviado
                txtDireccion_AN.Text = CType(entidad, Ea030personas).direccion
                txtCiudad_AN.Text = CType(entidad, Ea030personas).ciudad
                txtTelefono_AN.Text = CType(entidad, Ea030personas).telefono
                txtEmail_AN.Text = CType(entidad, Ea030personas).email
                cmbEstado.Text = CType(entidad, Ea030personas).estado
        End Select
        ' Habilita o deshabilita los controles de edición
        cmbTipoDocumento.Enabled = True
        txtCodigo_SR.Enabled = True
        txtNombre_AN.Enabled = True
        txtAbreviado_AN.Enabled = True
        txtDireccion_AN.Enabled = True
        txtCiudad_AN.Enabled = True
        txtTelefono_AN.Enabled = True
        txtEmail_AN.Enabled = True
        cmbEstado.Enabled = True

        cmbTipoDocumento.AccessibleName = "tipodocumento"
        txtCodigo_SR.AccessibleName = "nrodocumento"
        txtNombre_AN.AccessibleName = "nombre"
        txtAbreviado_AN.AccessibleName = "abreviado"
        txtDireccion_AN.AccessibleName = "direccion"
        txtCiudad_AN.AccessibleName = "ciudad"
        txtTelefono_AN.AccessibleName = "telefono"
        txtEmail_AN.AccessibleName = "email"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                ' CONDICIONANTE ANTES DE CARGAR EL FORMULARIO CUANDO LA ACCION ES AGREGAR

            Case sMODIFICAR_
                cmbTipoDocumento.Enabled = False
                cmbTipoDocumento.Tag = sOk_
                txtCodigo_SR.Enabled = False
                txtCodigo_SR.Tag = sOk_

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
        Dim lsTipoDocumento As String = ""

        lsClave = "a030personas.tipodocumento"
        lsValor = "CI" & sSF_ & "RUC" & sSF_ & "PAS" & sSF_ & "DNI"
        lsTipoDocumento = GFsParametroObtener(lsTipo, lsClave)
        If lsTipoDocumento = sRESERVADO_ Then
            lsTipoDocumento = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsTipoDocumento)
        End If
        cmbTipoDocumento.Items.Clear()
        For Each lsValor In lsTipoDocumento.Split(sSF_)
            cmbTipoDocumento.Items.Add(lsValor)
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
                cmbTipoDocumento.Focus()
            Case sMODIFICAR_
                cmbTipoDocumento.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub LPDespliegaDescripciones()
        '--> AQUI DEBE INGRESARSE EL CODIGO QUE PERMITE RECUPERAR DATOS RELACIONADOS CON LOS FKs
    End Sub

    Private Sub LPInicializaMaxLength()
        cmbTipoDocumento.MaxLength = 15
        txtCodigo_SR.MaxLength = 15
        txtNombre_AN.MaxLength = 100
        txtAbreviado_AN.MaxLength = 30
        txtDireccion_AN.MaxLength = 128
        txtCiudad_AN.MaxLength = 64
        txtTelefono_AN.MaxLength = 64
        txtEmail_AN.MaxLength = 128
        cmbEstado.MaxLength = 15
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

    Private Sub LPInicializaControles(ByRef poTabControl As TabControl)
        For Each loTabPage As TabPage In poTabControl.TabPages
            If loTabPage.AccessibleName = sActivo_ Then
                For Each loControl As Control In loTabPage.Controls
                    Select Case Me.Tag.ToString
                        Case sAGREGAR_
                            loControl.Tag = sCancelar_
                        Case sMODIFICAR_
                            loControl.Tag = sOk_
                    End Select
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
                                Select Case Me.Tag.ToString
                                    Case sAGREGAR_
                                        loControl1.Tag = sCancelar_
                                    Case sMODIFICAR_
                                        loControl1.Tag = sOk_
                                End Select
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

End Class