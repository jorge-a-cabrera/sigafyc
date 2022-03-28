Imports System.ComponentModel

Public Class frmFb080timbotros
    Private miTiempoVigenciaTimbrado As Integer = 1
    Private msValidado As String = ""
    Private msRequeridos As String() = {"numtimbrado", "tipodocumento", "nrodocumento", "valido", "expira"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msValido As String
    Private msExpira As String

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Tag = sCancelar_
        GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en CANCELAR.")
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If InStr(sAGREGAR_ & sMODIFICAR_, Me.Tag.ToString) > 0 Then
            msValidado = ""
            For Each loControl As Control In Me.TabPage1.Controls
                If InStr(sDEControles_, loControl.Name.Substring(0, 3)) > 0 Then
                    msValidado &= loControl.Tag.ToString
                End If
            Next

            If InStr(msValidado, sCancelar_) > 0 Then
                GFsAvisar("Validacion final", sMENSAJE_, "No han sido ingresado correctamente todos los datos")
                txtNumTimbrado_NE.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Eb080timbotros
                        loDatos.numTimbrado = txtNumTimbrado_NE.Text
                        loDatos.tipodocumento = cmbTipoDocumento.Text
                        loDatos.nrodocumento = txtNroDocumento_AN.Text
                        loDatos.valido = txtValido_FE.Text
                        loDatos.expira = txtExpira_FE.Text
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        loDatos.Add()
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Eb080timbotros
                        loDatos.numTimbrado = txtNumTimbrado_NE.Text
                        If loDatos.GetPK = sOk_ Then
                            loDatos.numTimbrado = txtNumTimbrado_NE.Text
                            loDatos.tipodocumento = cmbTipoDocumento.Text
                            loDatos.nrodocumento = txtNroDocumento_AN.Text
                            loDatos.valido = txtValido_FE.Text
                            loDatos.expira = txtExpira_FE.Text
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
                Me.AccessibleName = txtNumTimbrado_NE.Text
                LPGuardaValoresPredeterminados()
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ec010timbpropios
                loDatos.numTimbrado = txtNumTimbrado_NE.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.numTimbrado = txtNumTimbrado_NE.Text
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
                Case "valido"
                    lsValorInicial = Today.ToString("yyyy-MM-dd")
                Case "expira"
                    lsValorInicial = Today.AddYears(miTiempoVigenciaTimbrado).ToString("yyyy-MM-dd")
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "numtimbrado"
                    Dim loPk As New Eb080timbotros
                    loPk.numTimbrado = txtNumTimbrado_NE.Text
                    If loPk.GetPK = sOk_ Then
                        Dim loA030 As New Ea030personas
                        loA030.tipoDocumento = loPk.tipodocumento
                        loA030.nroDocumento = loPk.nrodocumento
                        If loA030.GetPK = sOk_ Then
                            GFsAvisar("Timbrado No. [" & txtNumTimbrado_NE.Text & "] vinculado con [" & loA030.tipoDocumento & "-" & loA030.nroDocumento & " / " & loA030.nombre.Trim & "] Periodo:[" & loPk.valido & " / " & loPk.expira & "]", sMENSAJE_, "Y no puede duplicarse.")
                        End If
                        loA030.CerrarConexion()
                        e.Cancel = True
                    End If
                    loPk.CerrarConexion()
                    msValido = loPk.valido
                    msExpira = loPk.expira

                Case "nrodocumento"
                    Dim loFK As New Ea030personas
                    loFK.tipoDocumento = cmbTipoDocumento.Text
                    loFK.nroDocumento = txtNroDocumento_AN.Text
                    If loFK.GetPK = sSinRegistros_ Then
                        Dim loLookUp As New frmBa030personas
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            cmbTipoDocumento.Text = CType(loLookUp.entidad, Ea030personas).tipoDocumento
                            txtNroDocumento_AN.Text = CType(loLookUp.entidad, Ea030personas).nroDocumento
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    loFK.CerrarConexion()

                Case "valido"
                    If Not IsDate(txtValido_FE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtValido_FE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                        Exit Sub
                    Else
                        Dim ldFecha As Date = Date.Parse(txtValido_FE.Text.ToString)
                        txtValido_FE.Text = ldFecha.ToString("yyyy-MM-dd")
                    End If

                    If txtValido_FE.Text > Today.ToString("yyyy-MM-dd") Then
                        GFsAvisar("La validez no puede ser diferida", sMENSAJE_, "reintentelo de nuevo")
                        txtValido_FE.Text = Today.ToString("yyyy-MM-dd")
                        e.Cancel = True
                        Exit Sub
                    End If

                Case "expira"
                    If Not IsDate(txtExpira_FE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtExpira_FE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                        Exit Sub
                    Else
                        Dim ldFecha As Date = Date.Parse(txtExpira_FE.Text.ToString)
                        txtExpira_FE.Text = ldFecha.ToString("yyyy-MM-dd")
                    End If

                    If txtExpira_FE.Text < txtValido_FE.Text Then
                        Dim lsAuxiliar As String = txtExpira_FE.Text
                        txtExpira_FE.Text = txtValido_FE.Text
                        txtValido_FE.Text = lsAuxiliar
                        txtValido_FE.Focus()
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

    Private Sub LPDespliegaDescripciones()
        lblNombre.Text = ""
        If cmbTipoDocumento.Text.Trim.Length > 0 And txtNroDocumento_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Ea030personas
            loFK.tipoDocumento = cmbTipoDocumento.Text
            loFK.nroDocumento = txtNroDocumento_AN.Text
            If loFK.GetPK = sOk_ Then
                lblNombre.Text = loFK.abreviado
            End If
            loFK.CerrarConexion()
        End If
    End Sub

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim lsClave As String = "Timbrado - tiempo vigencia en años"
        LPInicializaParametros()
        LPInicializaMaxLength()
        LPInicializaControles()
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls

        ' Inicializa los controles de edición con los valores pertinentes
        Dim lsTiempoVigenciaTimbrado = GFsParametroObtener(sGeneral_, lsClave)
        If lsTiempoVigenciaTimbrado = sRESERVADO_ Then
            GPParametroGuardar(sGeneral_, lsClave, miTiempoVigenciaTimbrado.ToString, sNo_)
        Else
            If IsNumeric(lsTiempoVigenciaTimbrado) Then
                miTiempoVigenciaTimbrado = Integer.Parse(lsTiempoVigenciaTimbrado)
            Else
                GPParametroGuardar(sGeneral_, lsClave, miTiempoVigenciaTimbrado.ToString, sNo_)
            End If
        End If
        msEntidad = "registro Timbrado de terceros"
        lblNombre.Text = ""
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
            Case Else
                Dim loDatos As New Eb080timbotros
                loDatos.numTimbrado = CType(entidad, Eb080timbotros).numTimbrado
                If loDatos.GetPK() = sOk_ Then
                    txtNumTimbrado_NE.Text = loDatos.numTimbrado
                    cmbTipoDocumento.Text = loDatos.tipodocumento
                    txtNroDocumento_AN.Text = loDatos.nrodocumento
                    txtValido_FE.Text = loDatos.valido
                    txtExpira_FE.Text = loDatos.expira
                    cmbEstado.Text = loDatos.estado
                End If
                loDatos.CerrarConexion()
                loDatos = Nothing
        End Select
        ' Habilita o deshabilita los controles de edición
        txtNumTimbrado_NE.Enabled = True
        cmbTipoDocumento.Enabled = True
        txtNroDocumento_AN.Enabled = True
        txtValido_FE.Enabled = True
        txtExpira_FE.Enabled = True
        cmbEstado.Enabled = True

        txtNumTimbrado_NE.AccessibleName = "numtimbrado"
        cmbTipoDocumento.AccessibleName = "tipodocumento"
        txtNroDocumento_AN.AccessibleName = "nrodocumento"
        txtValido_FE.AccessibleName = "valido"
        txtExpira_FE.AccessibleName = "expira"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_

            Case sMODIFICAR_
                txtNumTimbrado_NE.Enabled = False
                txtNumTimbrado_NE.Tag = sOk_
                cmbTipoDocumento.Tag = sOk_
                txtNroDocumento_AN.Tag = sOk_
                txtValido_FE.Tag = sOk_
                txtExpira_FE.Tag = sOk_
                cmbEstado.Tag = sOk_

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
                txtNumTimbrado_NE.Focus()
            Case sMODIFICAR_
                txtNumTimbrado_NE.Focus()
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


    Private Sub LPInicializaMaxLength()
        txtNumTimbrado_NE.MaxLength = 15
        cmbTipoDocumento.MaxLength = 15
        txtNroDocumento_AN.MaxLength = 15
        txtValido_FE.MaxLength = 10
        txtExpira_FE.MaxLength = 10
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

    Private Sub LPInicializarPredeterminados()
        Dim lsValor As String = ""
        For Each loTabPage As TabPage In TabControl1.TabPages
            If loTabPage.AccessibleName = sActivo_ Then
                For Each loControl As Control In loTabPage.Controls
                    Select Case loControl.Name.Substring(0, 3)
                        Case sPrefijoTextBox_
                            lsValor = GFsParametroObtener(sUsuario_, loControl.AccessibleName)
                            If lsValor <> sRESERVADO_ Then
                                loControl.Text = lsValor
                                loControl.Tag = sOk_
                            End If
                        Case sPrefijoComboBox_
                        Case sPrefijoGroupBox_
                            For Each loControl1 As Control In loControl.Controls
                                Select Case loControl1.Name.Substring(0, 3)
                                    Case sPrefijoTextBox_
                                        lsValor = GFsParametroObtener(sUsuario_, loControl1.AccessibleName)
                                        If lsValor <> sRESERVADO_ Then
                                            loControl1.Text = lsValor
                                            loControl1.Tag = sOk_
                                        End If
                                End Select
                            Next
                    End Select
                Next
            End If
        Next
    End Sub

    Private Sub LPGuardaValoresPredeterminados()
        For Each loTabPage As TabPage In TabControl1.TabPages
            If loTabPage.AccessibleName = sActivo_ Then
                For Each loControl As Control In loTabPage.Controls
                    Select Case loControl.Name.Substring(0, 3)
                        Case sPrefijoTextBox_
                            GPParametroGuardar(sUsuario_, Me.Name & "_" & loControl.Name, loControl.Text)
                        Case sPrefijoComboBox_
                        Case sPrefijoGroupBox_
                            For Each loControl1 As Control In loControl.Controls
                                Select Case loControl1.Name.Substring(0, 3)
                                    Case sPrefijoTextBox_
                                        GPParametroGuardar(sUsuario_, loControl1.AccessibleName, loControl1.Text)
                                End Select
                            Next
                    End Select
                Next
            End If
        Next
    End Sub

End Class