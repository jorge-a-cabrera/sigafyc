Imports System.ComponentModel

Public Class frmFb110undalternativas
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "codmercaderia", "codunidad", "nomunidad", "cantidad", "estado"}
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
                txtCodUnidad_AN.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Eb110undalternativas
                        LPTruncaSegunLongitud()
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.tipo = cmbTipo.Text
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
                        loDatos.nomunidad = txtNomUnidad_AN.Text
                        loDatos.cantidad = Decimal.Parse(txtCantidad_ND.Text)
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
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Eb110undalternativas
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.tipo = cmbTipo.Text
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.tipo = cmbTipo.Text
                            loDatos.codmercaderia = txtCodMercaderia_AN.Text
                            loDatos.codunidad = txtCodUnidad_AN.Text
                            loDatos.nomunidad = txtNomUnidad_AN.Text
                            loDatos.cantidad = Decimal.Parse(txtCantidad_ND.Text)
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
                Me.AccessibleName = txtCodUnidad_AN.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Eb110undalternativas
                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.tipo = cmbTipo.Text
                loDatos.codmercaderia = txtCodMercaderia_AN.Text
                loDatos.codunidad = txtCodUnidad_AN.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.tipo = cmbTipo.Text
                    loDatos.codmercaderia = txtCodMercaderia_AN.Text
                    loDatos.codunidad = txtCodUnidad_AN.Text
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
                Case "cantidad"
                    lsValorInicial = "1.00"
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
            Exit Sub
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "cantidad"
                    If Decimal.Parse(CType(sender, Control).Text) = 0.00D Then
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
        LPInicializaControles()
        ' Inicializa los controles de edición con los valores pertinentes
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        msEntidad = "unidades medidas alternativas"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Eb110undalternativas
                txtCodEmpresa_NE.Text = CType(entidad, Eb110undalternativas).codEmpresa.ToString
                cmbTipo.Text = CType(entidad, Eb110undalternativas).tipo
                txtCodMercaderia_AN.Text = CType(entidad, Eb110undalternativas).codmercaderia
                loDatos.CerrarConexion()

            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Eb110undalternativas).codEmpresa.ToString
                cmbTipo.Text = CType(entidad, Eb110undalternativas).tipo
                txtCodMercaderia_AN.Text = CType(entidad, Eb110undalternativas).codmercaderia
                txtCodUnidad_AN.Text = CType(entidad, Eb110undalternativas).codunidad
                txtNomUnidad_AN.Text = CType(entidad, Eb110undalternativas).nomunidad
                txtCantidad_ND.Text = CType(entidad, Eb110undalternativas).cantidad.ToString
                cmbEstado.Text = CType(entidad, Eb110undalternativas).estado

                txtCodEmpresa_NE.Tag = sOk_
                cmbTipo.Tag = sOk_
                txtCodMercaderia_AN.Tag = sOk_
                txtCodUnidad_AN.Tag = sOk_
                txtNomUnidad_AN.Tag = sOk_
                txtCantidad_ND.Tag = sOk_
                cmbEstado.Tag = sOk_

        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        cmbTipo.Enabled = True
        txtCodMercaderia_AN.Enabled = True
        txtCodUnidad_AN.Enabled = True
        txtNomUnidad_AN.Enabled = True
        txtCantidad_ND.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        cmbTipo.AccessibleName = "tipo"
        txtCodMercaderia_AN.AccessibleName = "codmercaderia"
        txtCodUnidad_AN.AccessibleName = "codunidad"
        txtNomUnidad_AN.AccessibleName = "nomunidad"
        txtCantidad_ND.AccessibleName = "cantidad"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                cmbTipo.Enabled = False
                cmbTipo.Tag = sOk_
                txtCodMercaderia_AN.Enabled = False
                txtCodMercaderia_AN.Tag = sOk_

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                cmbTipo.Enabled = False
                cmbTipo.Tag = sOk_
                txtCodMercaderia_AN.Enabled = False
                txtCodMercaderia_AN.Tag = sOk_
                txtCodUnidad_AN.Enabled = False
                txtCodUnidad_AN.Tag = sOk_

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
                txtCodUnidad_AN.Focus()
            Case sMODIFICAR_
                txtNomUnidad_AN.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub LPDespliegaDescripciones()
        Dim ldValorInicial As Decimal = 0.00D

        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString("D" & txtCodEmpresa_NE.MaxLength.ToString)
            txtCodEmpresa_NE.Refresh()
            Dim loPK As New Ec001empresas
            loPK.codEmpresa = liCodEmpresa
            If loPK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loPK.nombre
                lblNombreEmpresa.Refresh()
            End If
            loPK.CerrarConexion()
        End If

        lblNombreMercaderia.Text = ""
        Dim lsCodUnidad As String = ""
        Select Case cmbTipo.Text
            Case sEntrada_
                Dim loPK As New Ed020mercentrada
                loPK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loPK.codmercaderia = txtCodMercaderia_AN.Text
                If loPK.GetPK = sOk_ Then
                    lblNombreMercaderia.Text = loPK.nombre
                    lsCodUnidad = loPK.codunidad
                End If
                loPK.CerrarConexion()
            Case sSalida_
                Dim loPK As New Ed030mercsalida
                loPK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loPK.codmercaderia = txtCodMercaderia_AN.Text
                If loPK.GetPK = sOk_ Then
                    lblNombreMercaderia.Text = loPK.nombre
                    lsCodUnidad = loPK.codunidad
                End If
                loPK.CerrarConexion()
        End Select
        lblNombreMercaderia.Refresh()

        lblUndBasica.Text = ""
        Dim loFK As New Ea050unidades
        loFK.codunidad = lsCodUnidad
        If loFK.GetPK = sOk_ Then
            lblUndBasica.Text = loFK.nombre
            lblUndBasica.Refresh()
        End If
        loFK.CerrarConexion()

        If txtCantidad_ND.Text.Trim.Length = 0 Then
            txtCantidad_ND.Text = ldValorInicial.ToString(sFormatF_)
            txtCantidad_ND.Refresh()
        End If

        If IsNumeric(txtCantidad_ND.Text) = True Then
            Dim ldValor As Decimal = Decimal.Parse(txtCantidad_ND.Text)
            txtCantidad_ND.Text = ldValor.ToString(sFormatF_)
            txtCantidad_ND.Refresh()
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        cmbTipo.MaxLength = 15
        txtCodMercaderia_AN.MaxLength = 20
        txtCodUnidad_AN.MaxLength = 6
        txtNomUnidad_AN.MaxLength = 15
        txtCantidad_ND.MaxLength = 17
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
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If Not (Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sMODIFICAR_) Then Exit Sub
        Dim loBrowseDetalle As New frmBe020listaprecio
        loBrowseDetalle.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
        loBrowseDetalle.codmercaderia = txtCodMercaderia_AN.Text
        loBrowseDetalle.codunidad = txtCodUnidad_AN.Text
        loBrowseDetalle.codmercaderia = txtCodMercaderia_AN.Text
        GPCargar(loBrowseDetalle)
    End Sub
End Class