Imports System.ComponentModel

Public Class frmFd020mercentrada
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "codmercaderia", "nombre", "abreviado", "codunidad", "codclasificacion", "tipobien", "tipocosto", "inventario", "codbarra", "estado"}
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
                        Dim loDatos As New Ed020mercentrada
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.nombre = txtNombre_AN.Text
                        loDatos.abreviado = txtAbreviado_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
                        loDatos.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text)
                        loDatos.tipobien = cmbTipoBien.Text
                        loDatos.tipocosto = cmbTipoCosto.Text
                        loDatos.inventario = cmbInventario.Text
                        loDatos.codbarra = txtCodBarra_AN.Text
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        Try
                            loDatos.Add()
                            LPAddUnidadesAlternativas()
                            LPAddMercaderiaSalida()
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Ed020mercentrada
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
                            loDatos.tipobien = cmbTipoBien.Text
                            loDatos.tipocosto = cmbTipoCosto.Text
                            loDatos.inventario = cmbInventario.Text
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
                Dim loDatos As New Ed020mercentrada
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
                            txtCodUnidad_AN.Tag = sOk_
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
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

                    loFK.tipo = sEntrada_
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
                            txtCodClasificacion_NE.Tag = sOk_
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
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
                Dim loDatos As New Ed020mercentrada
                txtCodEmpresa_NE.Text = CType(entidad, Ed020mercentrada).codempresa.ToString
                loDatos.CerrarConexion()
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ed020mercentrada).codempresa.ToString
                txtCodMercaderia_AN.Text = CType(entidad, Ed020mercentrada).codmercaderia
                txtNombre_AN.Text = CType(entidad, Ed020mercentrada).nombre
                txtAbreviado_AN.Text = CType(entidad, Ed020mercentrada).abreviado
                txtCodUnidad_AN.Text = CType(entidad, Ed020mercentrada).codunidad
                txtCodClasificacion_NE.Text = CType(entidad, Ed020mercentrada).codclasificacion.ToString
                cmbTipoBien.Text = CType(entidad, Ed020mercentrada).tipobien
                cmbTipoCosto.Text = CType(entidad, Ed020mercentrada).tipocosto
                cmbInventario.Text = CType(entidad, Ed020mercentrada).inventario
                txtCodBarra_AN.Text = CType(entidad, Ed020mercentrada).codbarra
                cmbEstado.Text = CType(entidad, Ed020mercentrada).estado

                txtNombre_AN.Tag = sOk_
                txtAbreviado_AN.Tag = sOk_
                txtCodUnidad_AN.Tag = sOk_
                txtCodClasificacion_NE.Tag = sOk_
                cmbTipoBien.Tag = sOk_
                cmbTipoCosto.Tag = sOk_
                cmbInventario.Tag = sOk_
                txtCodBarra_AN.Tag = sOk_
                cmbEstado.Tag = sOk_

                If Me.Tag.ToString = sMODIFICAR_ Or Me.Tag.ToString = sCONSULTAR_ Then
                    btnDetalle.Visible = True
                End If

        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtCodMercaderia_AN.Enabled = True
        txtNombre_AN.Enabled = True
        txtAbreviado_AN.Enabled = True
        txtCodUnidad_AN.Enabled = True
        txtCodClasificacion_NE.Enabled = True
        cmbTipoBien.Enabled = True
        cmbTipoCosto.Enabled = True
        cmbInventario.Enabled = True
        txtCodBarra_AN.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtCodMercaderia_AN.AccessibleName = "codmercaderia"
        txtNombre_AN.AccessibleName = "nombre"
        txtAbreviado_AN.AccessibleName = "abreviado"
        txtCodUnidad_AN.AccessibleName = "codunidad"
        txtCodClasificacion_NE.AccessibleName = "codclasificacion"
        cmbTipoBien.AccessibleName = "tipobien"
        cmbTipoCosto.AccessibleName = "tipocosto"
        cmbInventario.AccessibleName = "inventario"
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
            loFK.tipo = sEntrada_
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
        cmbTipoBien.MaxLength = 15
        cmbTipoCosto.MaxLength = 15
        cmbInventario.MaxLength = 2
        txtCodBarra_AN.MaxLength = 64
        cmbEstado.MaxLength = 15
    End Sub

    Private Sub LPInicializaControles()
        btnDetalle.Visible = False

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

        lsClave = "d020mercentrada.tipobien"
        lsValor = sBienCambio_ & sSF_ & sBienUso_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipoBien.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipoBien.Items.Add(lsValor)
        Next
        If Me.Tag.ToString = sAGREGAR_ Then
            cmbTipoBien.Text = cmbTipoBien.Items(0).ToString
        End If

        '--------------------------------------------------------------------------------------------------------------------------------
        ' Public Const sPEPS_ As String = "PEPS"
        ' Public Const sUEPS_ As String = "UEPS"
        ' Public Const sUltimaCompra1_ As String = "UltimaCompra"
        ' Public Const sUltimaCompra2_ As String = "UltimaCompraPromedio"
        ' Public Const sCostoPromedio_ As String = "CostoPromedio"
        ' Public Const sCostoFijo_ As String = "CostoFijo"
        '--------------------------------------------------------------------------------------------------------------------------------
        lsClave = "d020mercentrada.tipocosto"
        lsValor = sUltimaCompra1_ & sSF_ & sCostoPromedio_ & sSF_ & sCostoFijo_ & sSF_ & sPEPS_ & sSF_ & sUEPS_ & sSF_ & sUltimaCompra2_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipoCosto.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipoCosto.Items.Add(lsValor)
        Next
        If Me.Tag.ToString = sAGREGAR_ Then
            cmbTipoCosto.Text = cmbTipoCosto.Items(0).ToString
        End If

        lsClave = "d020mercentrada.inventario"
        lsValor = sSi_ & sSF_ & sNo_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbInventario.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbInventario.Items.Add(lsValor)
        Next
        If Me.Tag.ToString = sAGREGAR_ Then
            cmbInventario.Text = cmbInventario.Items(0).ToString
        End If
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        Dim loDetalleUnidades As New frmBb110undalternativas
        loDetalleUnidades.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
        loDetalleUnidades.tipo = sEntrada_
        loDetalleUnidades.codmercaderia = txtCodMercaderia_AN.Text
        GPCargar(loDetalleUnidades)
    End Sub

    Private Sub btnDetalleImpuestos_Click(sender As Object, e As EventArgs) Handles btnDetalleImpuestos.Click
        Dim loDetalleImpuestos As New frmBc040mercimpuestos
        loDetalleImpuestos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
        loDetalleImpuestos.operacion = sCompra_
        loDetalleImpuestos.codmercaderia = txtCodMercaderia_AN.Text.ToString
        GPCargar(loDetalleImpuestos)
    End Sub

    Private Sub LPAddUnidadesAlternativas(Optional ByVal psTipo As String = sEntrada_)
        Dim loA050 As New Ea050unidades
        loA050.codunidad = txtCodUnidad_AN.Text
        If loA050.GetPK = sOk_ Then
            Dim loB110 As New Eb110undalternativas
            loB110.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loB110.tipo = psTipo
            loB110.codmercaderia = txtCodMercaderia_AN.Text
            loB110.codunidad = txtCodUnidad_AN.Text
            If loB110.GetPK <> sOk_ Then
                loB110.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loB110.tipo = psTipo
                loB110.codmercaderia = txtCodMercaderia_AN.Text
                loB110.codunidad = txtCodUnidad_AN.Text
                loB110.nomunidad = loA050.nombre
                loB110.cantidad = Decimal.Parse("1,00")
                loB110.estado = sActivo_
                Try
                    loB110.Add(sNo_)
                Catch ex As Exception
                    GFsAvisar("Problema inicializar Unidades Medidas Alternativas", sMENSAJE_, "Por favor verifique lo acontecido")
                End Try
            End If
        End If
    End Sub

    Private Sub LPAddMercaderiaSalida()
        If cmbTipoBien.Text = sBienUso_ Then Exit Sub

        Dim loA0601 As New Ea060clasmerc
        loA0601.tipo = sSalida_
        loA0601.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text)
        If loA0601.GetPK <> sOk_ Then
            Dim loA0602 As New Ea060clasmerc
            loA0602.tipo = sEntrada_
            loA0602.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text)
            If loA0602.GetPK = sOk_ Then
                loA0601.tipo = sSalida_
                loA0601.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text)
                loA0601.nombre = loA0602.nombre
                loA0601.abreviado = loA0602.abreviado
                loA0601.listaprecio = loA0602.listaprecio
                loA0601.estado = loA0602.estado
                Try
                    loA0601.Add(sNo_)
                Catch ex As Exception
                    GFsAvisar("Problema Inicializar Clasificacion de Salida", sMENSAJE_, "Por favor verifique lo acontecido")
                End Try
            End If
            loA0602.CerrarConexion()
        End If
        loA0601.CerrarConexion()
        LPMercaderiaSalida2()
        LPAddMercaderiasVinculadas()
    End Sub

    Private Sub LPMercaderiaSalida2()
        Dim loD030 As New Ed030mercsalida
        loD030.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
        loD030.codmercaderia = txtCodMercaderia_AN.Text
        If loD030.GetPK <> sOk_ Then
            loD030.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loD030.codmercaderia = txtCodMercaderia_AN.Text
            loD030.nombre = txtNombre_AN.Text
            loD030.abreviado = txtAbreviado_AN.Text
            loD030.codunidad = txtCodUnidad_AN.Text
            loD030.codclasificacion = Integer.Parse(txtCodClasificacion_NE.Text)
            loD030.listaprecio = sNo_
            loD030.codbarra = txtCodBarra_AN.Text
            If cmbEstado.Text.Trim.Length > 0 Then
                loD030.estado = cmbEstado.Text
            Else
                loD030.estado = sActivo_
            End If
            Try
                loD030.Add(sNo_)
                LPAddUnidadesAlternativas(sSalida_)
            Catch ex As Exception
                GFsAvisar("Problema inicializar Mercaderia de salidas", sMENSAJE_, "Por favor verifique lo acontecido")
            End Try
        Else
            GFsAvisar("Ya existe en Mercaderias de Salida, Cod. Mercaderia[" & txtCodMercaderia_AN.Text & " -> " & loD030.nombre & "]", sMENSAJE_, "Por lo cual si desea venderlo debe crear maualmente la vinculación. Por favor verifique lo acontecido")
        End If
        loD030.CerrarConexion()
    End Sub

    Private Sub LPAddMercaderiasVinculadas()
        Dim loC050 As New Ec050mercvinculadas
        loC050.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
        loC050.codsalida = txtCodMercaderia_AN.Text
        loC050.codentrada = txtCodMercaderia_AN.Text
        loC050.codunidad = txtCodUnidad_AN.Text
        loC050.cantidad = Decimal.Parse("1,00")
        loC050.estado = cmbEstado.Text
        Try
            loC050.Add(sNo_)
        Catch ex As Exception
            GFsAvisar("Problema inicializar Mercaderia Vinculadas", sMENSAJE_, "Por favor verifique lo acontecido")
        End Try
        loC050.CerrarConexion()
    End Sub

End Class