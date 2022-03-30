Imports System.ComponentModel

Public Class frmFa060clasmerc
    Private msValidado() As String
    Private msRequeridos As String() = {"tipo", "codclasificacion", "abreviado", "nombre", "listaprecio", "estado"}
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
                txtCodClasificacion_NE.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ea060clasmerc
                        LPTruncaSegunLongitud()
                        loDatos.tipo = cmbTipo.Text
                        loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
                        loDatos.abreviado = txtAbreviado_AN.Text
                        loDatos.nombre = txtNombre_AN.Text
                        loDatos.listaprecio = cmbListaPrecio.Text
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
                        Dim loDatos As New Ea060clasmerc
                        loDatos.tipo = cmbTipo.Text
                        loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.tipo = cmbTipo.Text
                            loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
                            loDatos.nombre = txtNombre_AN.Text
                            loDatos.abreviado = txtAbreviado_AN.Text
                            loDatos.listaprecio = cmbListaPrecio.Text
                            If cmbEstado.Text.Trim.Length > 0 Then
                                loDatos.estado = cmbEstado.Text
                            End If
                            loDatos.Put()
                        End If
                        loDatos.CerrarConexion()
                End Select
                Me.Tag = sOk_
                '-->  .AccesibleName envia al Browse la información del codigo que luego deberia 
                '-->  ser usado para la localización del registro en el DataGridView
                Me.AccessibleName = txtCodClasificacion_NE.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ea060clasmerc
                loDatos.tipo = cmbTipo.Text
                loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
                If loDatos.GetPK = sOk_ Then
                    loDatos.tipo = cmbTipo.Text
                    loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
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
                Case "tipo"
                    lsValorInicial = sEntrada_
                Case "abreviado"
                    lsValorInicial = "Abreviado No." & txtCodClasificacion_NE.Text
                Case "nombre"
                    lsValorInicial = txtAbreviado_AN.Text
                Case "listaprecio"
                    lsValorInicial = cmbListaPrecio.Items(1).ToString
                    If cmbTipo.Text = sSalida_ Then
                        lsValorInicial = cmbListaPrecio.Items(0).ToString
                    End If
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
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
        msEntidad = "Clasificacion"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ea060clasmerc
                cmbTipo.Text = CType(entidad, Ea060clasmerc).tipo
                txtCodClasificacion_NE.Text = loDatos.ReservarRegistro(cmbTipo.Text).ToString
                cmbTipo.Tag = sOk_
                txtCodClasificacion_NE.Tag = sOk_
                cmbListaPrecio.Text = cmbListaPrecio.Items(1).ToString
                If cmbTipo.Text = sSalida_ Then
                    cmbListaPrecio.Text = cmbListaPrecio.Items(0).ToString
                End If
                loDatos.CerrarConexion()
            Case Else
                cmbTipo.Text = CType(entidad, Ea060clasmerc).tipo
                txtCodClasificacion_NE.Text = CType(entidad, Ea060clasmerc).codclasificacion.ToString
                txtAbreviado_AN.Text = CType(entidad, Ea060clasmerc).abreviado
                txtNombre_AN.Text = CType(entidad, Ea060clasmerc).nombre
                cmbEstado.Text = CType(entidad, Ea060clasmerc).estado
                cmbListaPrecio.Text = CType(entidad, Ea060clasmerc).listaprecio
                cmbTipo.Tag = sOk_
                txtCodClasificacion_NE.Tag = sOk_
                txtAbreviado_AN.Tag = sOk_
                txtNombre_AN.Tag = sOk_
                cmbListaPrecio.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        cmbTipo.Enabled = True
        txtCodClasificacion_NE.Enabled = True
        txtAbreviado_AN.Enabled = True
        txtNombre_AN.Enabled = True
        cmbEstado.Enabled = True

        cmbTipo.AccessibleName = "tipo"
        txtCodClasificacion_NE.AccessibleName = "codigo"
        txtAbreviado_AN.AccessibleName = "abreviado"
        txtNombre_AN.AccessibleName = "nombre"
        cmbEstado.AccessibleName = "estado"

        lblListaPrecio.Visible = False
        cmbListaPrecio.Visible = False
        cmbListaPrecio.AccessibleName = ""
        If cmbTipo.Text = sSalida_ Then
            lblListaPrecio.Visible = True
            cmbListaPrecio.Visible = True
            cmbListaPrecio.AccessibleName = "listaprecio"
        End If

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                cmbTipo.Enabled = False
                cmbTipo.Tag = sOk_
                txtCodClasificacion_NE.Enabled = False
                txtCodClasificacion_NE.Tag = sOk_

            Case sMODIFICAR_
                cmbTipo.Enabled = False
                cmbTipo.Tag = sOk_
                txtCodClasificacion_NE.Enabled = False
                txtCodClasificacion_NE.Tag = sOk_

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
    End Sub

    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '--> AQUI DEBE INGRESARSE EL FOCUS DEL PRIMER ELEMENTO DEL FORMULARIO
        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtAbreviado_AN.Focus()
            Case sMODIFICAR_
                txtAbreviado_AN.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub LPDespliegaDescripciones()
    End Sub

    Private Sub LPInicializaMaxLength()
        cmbTipo.MaxLength = 15
        txtCodClasificacion_NE.MaxLength = 4
        txtAbreviado_AN.MaxLength = 15
        txtNombre_AN.MaxLength = 45
        cmbEstado.MaxLength = 15
        cmbListaPrecio.MaxLength = 2
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

    Private Sub LPBorrarAlCancelar()
        If Me.Tag.ToString <> sAGREGAR_ Then Exit Sub

        Dim loDatos As New Ea060clasmerc
        Dim lsTipo As String = cmbTipo.Text
        Dim liCodigo As Integer = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
        loDatos.tipo = lsTipo
        loDatos.codclasificacion = liCodigo
        If loDatos.GetPK = sOk_ Then
            loDatos.tipo = lsTipo
            loDatos.codclasificacion = liCodigo
            loDatos.Del(sNo_, sNo_)
        End If
        loDatos.CerrarConexion()
        loDatos = Nothing
    End Sub

    Private Sub LPInicializaParametros()
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String = ""
        Dim lsValor As String = ""
        Dim lsCodigo As String = ""

        lsClave = "a060clasmerc.tipo"
        lsValor = sEntrada_ & sSF_ & sSalida_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipo.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipo.Items.Add(lsValor)
        Next

        lsClave = "a060clasmerc.listaprecio"
        lsValor = sSi_ & sSF_ & sNo_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbListaPrecio.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbListaPrecio.Items.Add(lsValor)
        Next
    End Sub
End Class