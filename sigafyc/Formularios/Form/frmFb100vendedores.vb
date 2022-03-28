Imports System.ComponentModel

Public Class frmFb100vendedores

    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "codvendedor", "nombre", "abreviado", "password"}
    Private moRequeridos As New ArrayList(msRequeridos)

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
                txtCodigo_NE.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Eb100vendedores
                        LPTruncaSegunLongitud()
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codVendedor = Integer.Parse(txtCodigo_NE.Text.ToString)
                        loDatos.nombre = txtNombre_AN.Text
                        loDatos.abreviado = txtAbreviado_AN.Text
                        loDatos.password = GFsSHA256(txtPassword_AN.Text)
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        Try
                            loDatos.Put(sSi_, sSi_, sAGREGAR_)
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Eb100vendedores
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codVendedor = Integer.Parse(txtCodigo_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.codVendedor = Integer.Parse(txtCodigo_NE.Text.ToString)
                            loDatos.nombre = txtNombre_AN.Text
                            loDatos.abreviado = txtAbreviado_AN.Text
                            If txtPassword_AN.Text.ToString.Trim.Length > 0 Then
                                loDatos.password = GFsSHA256(txtPassword_AN.Text)
                            End If
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
                Me.AccessibleName = txtCodigo_NE.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Eb100vendedores
                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.codVendedor = Integer.Parse(txtCodigo_NE.Text.ToString)
                If loDatos.GetPK = sOk_ Then
                    loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.codVendedor = Integer.Parse(txtCodigo_NE.Text.ToString)
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
                Case "nombre"
                    lsValorInicial = "Nombre Empresa No. " & txtCodigo_NE.Text
                Case "abreviado"
                    If txtNombre_AN.Text.Trim.Length > 0 Then
                        lsValorInicial = txtNombre_AN.Text
                    Else
                        lsValorInicial = "Empresa No. " & txtCodigo_NE.Text
                    End If
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "password2"
                    If txtPassword_AN.Text <> txtPassword2_AN.Text Then
                        GFsAvisar("Los passwords deben coincidir", sMENSAJE_, "reintentelo de nuevo")
                        txtPassword_AN.Text = ""
                        txtPassword2_AN.Text = ""
                        txtPassword_AN.Focus()
                    End If
            End Select
            If CType(sender, Control).Name.Substring(0, 3) = sPrefijoComboBox_ Then
                If CType(sender, ComboBox).Items.Contains(CType(sender, ComboBox).Text) = False Then
                    e.Cancel = True
                    CType(sender, Control).Tag = sCancelar_
                End If
            End If
        End If
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
        msEntidad = "registro del Vendedor"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Eb100vendedores
                txtCodEmpresa_NE.Text = CType(entidad, Eb100vendedores).codEmpresa.ToString
                txtCodigo_NE.Text = loDatos.ReservarRegistro(Integer.Parse(txtCodEmpresa_NE.Text.ToString)).ToString
                loDatos.CerrarConexion()
                loDatos = Nothing
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Eb100vendedores).codEmpresa.ToString
                txtCodigo_NE.Text = CType(entidad, Eb100vendedores).codVendedor.ToString
                txtNombre_AN.Text = CType(entidad, Eb100vendedores).nombre
                txtAbreviado_AN.Text = CType(entidad, Eb100vendedores).abreviado
                txtPassword_AN.Text = ""
                txtPassword2_AN.Text = ""
                cmbEstado.Text = CType(entidad, Eb100vendedores).estado
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtCodigo_NE.Enabled = True
        txtNombre_AN.Enabled = True
        txtAbreviado_AN.Enabled = True
        txtPassword_AN.Enabled = True
        txtPassword2_AN.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codEmpresa"
        txtCodigo_NE.AccessibleName = "codigo"
        txtNombre_AN.AccessibleName = "nombre"
        txtAbreviado_AN.AccessibleName = "abreviado"
        txtPassword_AN.AccessibleName = "password"
        txtPassword2_AN.AccessibleName = "password2"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodigo_NE.Enabled = False
                txtCodigo_NE.Tag = sOk_

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodigo_NE.Enabled = False
                txtCodigo_NE.Tag = sOk_

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
        '--> AQUI DEBE INGRESARSE EL FOCUS DEL PRIMER ELEMENTO DEL FORMULARIO
        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtNombre_AN.Focus()
            Case sMODIFICAR_
                txtNombre_AN.Focus()
        End Select
        LPDespliegaDescripciones()

    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liCodigo As Integer = Integer.Parse(txtCodigo_NE.Text.ToString)
        txtCodEmpresa_NE.Text = liCodEmpresa.ToString("D6")
        txtCodigo_NE.Text = liCodigo.ToString("D3")
        lblNombreEmpresa.Text = ""
        Dim loFK As New Ec001empresas
        loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        If loFK.GetPK = sOk_ Then
            lblNombreEmpresa.Text = loFK.nombre
        End If
        loFK.CerrarConexion()
        loFK = Nothing
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodigo_NE.MaxLength = 3
        txtNombre_AN.MaxLength = 120
        txtAbreviado_AN.MaxLength = 40
        txtPassword_AN.MaxLength = 15
        txtPassword2_AN.MaxLength = 15
        cmbEstado.MaxLength = 15
    End Sub

    Private Sub LPInicializaControles()
        For Each loTabPage As TabPage In TabControl1.TabPages
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

        Dim loDatos As New Eb100vendedores
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liCodigo As Integer = Integer.Parse(txtCodigo_NE.Text.ToString)
        loDatos.codEmpresa = liCodEmpresa
        loDatos.codVendedor = liCodigo
        If loDatos.GetPK = sOk_ Then
            loDatos.codEmpresa = liCodEmpresa
            loDatos.codVendedor = liCodigo
            loDatos.Del(sNo_, sNo_)
        End If
        loDatos.CerrarConexion()
        loDatos = Nothing
    End Sub

End Class