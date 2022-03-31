Imports System.ComponentModel

Public Class frmFd030mercsalida
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "codmercaderia", "nombre", "abreviado", "codunidad", "codclasificacion", "listaprecio", "codbarra", "estado"}
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
                        Dim loDatos As New Ed030mercsalida
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.nombre = txtNombre_AN.Text
                        loDatos.abreviado = txtAbreviado_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
                        loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text)
                        loDatos.listaprecio = cmbListaPrecio.Text
                        loDatos.codbarra = txtCodBarra_AN.Text
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
                        Dim loDatos As New Ed030mercsalida
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.codmercaderia = txtCodMercaderia_AN.Text
                            loDatos.nombre = txtNombre_AN.Text
                            loDatos.abreviado = txtAbreviado_AN.Text
                            loDatos.codunidad = txtCodUnidad_AN.Text
                            loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text)
                            loDatos.listaprecio = cmbListaPrecio.Text
                            loDatos.codbarra = txtCodBarra_AN.Text
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
                Me.AccessibleName = txtCodMercaderia_AN.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ed030mercsalida
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.codmercaderia = txtCodMercaderia_AN.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.codmercaderia = txtCodMercaderia_AN.Text
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
                    lsValorInicial = "Mercaderia Cod.: " & txtCodMercaderia_AN.Text
                Case "abreviado"
                    If txtNombre_AN.Text.Trim.Length > txtAbreviado_AN.MaxLength Then
                        lsValorInicial = txtNombre_AN.Text.Substring(0, txtAbreviado_AN.MaxLength - 1)
                    Else
                        lsValorInicial = txtNombre_AN.Text
                    End If
                Case "codbarra"
                    lsValorInicial = txtCodMercaderia_AN.Text
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
            Exit Sub
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codunidad"
                    Dim loFK As New Ea050unidades
                    Dim lsResultado As String
                    loFK.codunidad = txtCodUnidad_AN.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBa050unidades
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodUnidad_AN.Text = CType(loLookUp.entidad, Ea050unidades).codunidad
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodUnidad_AN.Tag = sOk_
                    loFK.CerrarConexion()
                Case "codclasificacion"
                    If Not IsNumeric(txtCodClasificacion_NE.Text) Then Exit Sub
                    Dim liCodClasificacion As Integer = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
                    If liCodClasificacion = 0 Then
                        e.Cancel = True
                        Exit Sub
                    End If

                    Dim loFK As New Ea060clasmerc
                    Dim lsResultado As String

                    loFK.tipo = sSalida_
                    loFK.codclasificacion = liCodClasificacion
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBa060clasmerc
                        loLookUp.tipo = sEntrada_
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodClasificacion_NE.Text = CType(loLookUp.entidad, Ea060clasmerc).codclasificacion.ToString
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodClasificacion_NE.Tag = sOk_
                    loFK.CerrarConexion()
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
        msEntidad = "mercaderia entrada"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ed030mercsalida
                txtCodEmpresa_NE.Text = CType(entidad, Ed030mercsalida).codempresa.ToString
                loDatos.CerrarConexion()
                loDatos = Nothing
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ed030mercsalida).codempresa.ToString
                txtCodMercaderia_AN.Text = CType(entidad, Ed030mercsalida).codmercaderia
                txtNombre_AN.Text = CType(entidad, Ed030mercsalida).nombre
                txtAbreviado_AN.Text = CType(entidad, Ed030mercsalida).abreviado
                txtCodUnidad_AN.Text = CType(entidad, Ed030mercsalida).codunidad
                txtCodClasificacion_NE.Text = CType(entidad, Ed030mercsalida).codclasificacion.ToString
                cmbListaPrecio.Text = CType(entidad, Ed030mercsalida).listaprecio
                txtCodBarra_AN.Text = CType(entidad, Ed030mercsalida).codbarra
                cmbEstado.Text = CType(entidad, Ed030mercsalida).estado

                txtNombre_AN.Tag = sOk_
                txtAbreviado_AN.Tag = sOk_
                txtCodUnidad_AN.Tag = sOk_
                txtCodClasificacion_NE.Tag = sOk_
                cmbListaPrecio.Tag = sOk_
                txtCodBarra_AN.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtCodMercaderia_AN.Enabled = True
        txtNombre_AN.Enabled = True
        txtAbreviado_AN.Enabled = True
        txtCodUnidad_AN.Enabled = True
        txtCodClasificacion_NE.Enabled = True
        cmbListaPrecio.Enabled = True
        txtCodBarra_AN.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtCodMercaderia_AN.AccessibleName = "codmercaderia"
        txtNombre_AN.AccessibleName = "nombre"
        txtAbreviado_AN.AccessibleName = "abreviado"
        txtCodUnidad_AN.AccessibleName = "codunidad"
        txtCodClasificacion_NE.AccessibleName = "codclasificacion"
        cmbListaPrecio.AccessibleName = "listaprecio"
        txtCodBarra_AN.AccessibleName = "codbarra"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodMercaderia_AN.Enabled = False
                txtCodMercaderia_AN.Tag = sOk_

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
                txtCodMercaderia_AN.Focus()
            Case sMODIFICAR_
                txtNombre_AN.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub
    Private Sub LPDespliegaDescripciones()
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
        lblNombreUnidad.Text = ""
        If txtCodUnidad_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Ea050unidades
            loFK.codunidad = txtCodUnidad_AN.Text
            If loFK.GetPK = sOk_ Then
                lblNombreUnidad.Text = loFK.nombre
                lblNombreUnidad.Refresh()
            End If
            loFK.CerrarConexion()
        End If
        lblNombreClasificacion.Text = ""
        If txtCodClasificacion_NE.Text.Trim.Length > 0 Then
            Dim liCodClasificacion As Integer = Integer.Parse(txtCodClasificacion_NE.Text.ToString)
            txtCodClasificacion_NE.Text = liCodClasificacion.ToString("D" & txtCodClasificacion_NE.MaxLength.ToString)
            txtCodClasificacion_NE.Refresh()
            Dim loFK As New Ea060clasmerc
            loFK.tipo = sSalida_
            loFK.codclasificacion = liCodClasificacion
            If loFK.GetPK = sOk_ Then
                lblNombreClasificacion.Text = loFK.nombre
                lblNombreClasificacion.Refresh()
            End If
            loFK.CerrarConexion()
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodMercaderia_AN.MaxLength = 20
        txtNombre_AN.MaxLength = 120
        txtAbreviado_AN.MaxLength = 40
        txtCodUnidad_AN.MaxLength = 6
        txtCodClasificacion_NE.MaxLength = 3
        cmbListaPrecio.MaxLength = 2
        txtCodBarra_AN.MaxLength = 64
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

        lsClave = "d030mercsalida.listaprecio"
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
        If Me.Tag.ToString = sAGREGAR_ Then
            cmbListaPrecio.Text = cmbListaPrecio.Items(0).ToString
        End If
    End Sub

End Class