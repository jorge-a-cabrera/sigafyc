﻿Imports System.ComponentModel
Public Class frmFc020documentos
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "coddocumento", "tipo", "abreviado", "nombre", "timbrado", "codmoneda", "lineas"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msCodMoneda As String = ""
    Private moColor As Color
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
                        Dim loDatos As New Ec020documentos
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.coddocumento = Integer.Parse(txtCodigo_NE.Text.ToString)
                        loDatos.tipo = cmbTipo.Text
                        loDatos.abreviado = txtAbreviado_AN.Text
                        loDatos.nombre = txtNombre_AN.Text
                        loDatos.timbrado = cmbTimbrado.Text
                        loDatos.codmoneda = txtCodMoneda_AN.Text
                        loDatos.cotizacion = LFsTipoCotizacion()
                        loDatos.lineas = Integer.Parse(txtLineas_NE.Text.ToString)
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        loDatos.aplicacion = cmbAplicacion.Text
                        Try
                            loDatos.Put(sSi_, sSi_, sAGREGAR_)
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Ec020documentos
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.coddocumento = Integer.Parse(txtCodigo_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.coddocumento = Integer.Parse(txtCodigo_NE.Text.ToString)
                            loDatos.tipo = cmbTipo.Text
                            loDatos.nombre = txtNombre_AN.Text
                            loDatos.abreviado = txtAbreviado_AN.Text
                            loDatos.timbrado = cmbTimbrado.Text
                            loDatos.codmoneda = txtCodMoneda_AN.Text
                            loDatos.cotizacion = LFsTipoCotizacion()
                            loDatos.lineas = Integer.Parse(txtLineas_NE.Text.ToString)
                            If cmbEstado.Text.Trim.Length > 0 Then
                                loDatos.estado = cmbEstado.Text
                            End If
                            loDatos.aplicacion = cmbAplicacion.Text
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
                Dim loDatos As New Ec020documentos
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.coddocumento = Integer.Parse(txtCodigo_NE.Text.ToString)
                If loDatos.GetPK = sOk_ Then
                    loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.coddocumento = Integer.Parse(txtCodigo_NE.Text.ToString)
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
                    lsValorInicial = "Abrev. No." & txtCodigo_NE.Text
                Case "nombre"
                    lsValorInicial = "Nombre No." & txtCodigo_NE.Text
                Case "tipo"
                    lsValorInicial = sDocPropio_
                Case "timbrado"
                    lsValorInicial = sNo_
                Case "codmoneda"
                    lsValorInicial = msCodMoneda
                Case "lineas"
                    lsValorInicial = "0"
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codmoneda"
                    Dim loFK As New Ea010monedas
                    Dim lsResultado As String = ""
                    loFK.codMoneda = txtCodMoneda_AN.Text
                    lsResultado = loFK.GetPK
                    loFK.CerrarConexion()
                    loFK = Nothing
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
                        loLookUp = Nothing
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

        moColor = rbtCompra.BackColor
        ' Inicializa los controles de edición con los valores pertinentes
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        msEntidad = "Documento"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ec020documentos
                txtCodEmpresa_NE.Text = CType(entidad, Ec020documentos).codempresa.ToString
                txtCodigo_NE.Text = loDatos.ReservarRegistro(Integer.Parse(txtCodEmpresa_NE.Text.ToString)).ToString
                cmbTipo.Text = CType(entidad, Ec020documentos).tipo
                loDatos.CerrarConexion()
                loDatos = Nothing
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ec020documentos).codempresa.ToString
                txtCodigo_NE.Text = CType(entidad, Ec020documentos).coddocumento.ToString
                cmbTipo.Text = CType(entidad, Ec020documentos).tipo
                txtAbreviado_AN.Text = CType(entidad, Ec020documentos).abreviado
                txtNombre_AN.Text = CType(entidad, Ec020documentos).nombre
                cmbTimbrado.Text = CType(entidad, Ec020documentos).timbrado
                txtCodMoneda_AN.Text = CType(entidad, Ec020documentos).codmoneda
                Select Case CType(entidad, Ec020documentos).cotizacion
                    Case sCompra_
                        rbtCompra.Checked = True
                    Case sVenta_
                        rbtVenta.Checked = True
                    Case sSemisuma_
                        rbtSemisuma.Checked = True
                End Select
                txtLineas_NE.Text = CType(entidad, Ec020documentos).lineas.ToString
                cmbAplicacion.Text = CType(entidad, Ec020documentos).aplicacion.ToString
                cmbEstado.Text = CType(entidad, Ec020documentos).estado
                txtCodEmpresa_NE.Tag = sOk_
                txtCodigo_NE.Tag = sOk_
                cmbTipo.Tag = sOk_
                txtAbreviado_AN.Tag = sOk_
                txtNombre_AN.Tag = sOk_
                cmbTimbrado.Tag = sOk_
                txtCodMoneda_AN.Tag = sOk_
                txtLineas_NE.Tag = sOk_
                cmbAplicacion.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtCodigo_NE.Enabled = True
        cmbTipo.Enabled = True
        txtAbreviado_AN.Enabled = True
        txtNombre_AN.Enabled = True
        cmbTimbrado.Enabled = True
        txtCodMoneda_AN.Enabled = True
        gbxCotizacion.Enabled = True
        txtLineas_NE.Enabled = True
        cmbAplicacion.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codEmpresa"
        txtCodigo_NE.AccessibleName = "codigo"
        cmbTipo.AccessibleName = "tipo"
        txtAbreviado_AN.AccessibleName = "abreviado"
        txtNombre_AN.AccessibleName = "nombre"
        cmbTimbrado.AccessibleName = "timbrado"
        txtCodMoneda_AN.AccessibleName = "codmoneda"
        gbxCotizacion.AccessibleName = "cotizacion"
        txtLineas_NE.AccessibleName = "lineas"
        cmbAplicacion.AccessibleName = "aplicacion"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodigo_NE.Enabled = False
                cmbTipo.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodigo_NE.Tag = sOk_
                cmbTipo.Tag = sOk_

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodigo_NE.Enabled = False
                cmbTipo.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodigo_NE.Tag = sOk_
                cmbTipo.Tag = sOk_

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
                cmbTipo.Focus()
            Case sMODIFICAR_
                cmbTipo.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liCodigo As Integer = Integer.Parse(txtCodigo_NE.Text.ToString)
        txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString)
        txtCodigo_NE.Text = liCodigo.ToString(sFormatD_ & txtCodigo_NE.MaxLength.ToString)

        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Ec001empresas
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loFK.nombre
                msCodMoneda = loFK.codMoneda
            End If
            loFK.CerrarConexion()
            loFK = Nothing
        End If

        lblNombreMoneda.Text = ""
        If txtCodMoneda_AN.Text.Trim.Length > 0 Then
            Dim loFK1 As New Ea010monedas
            loFK1.codMoneda = txtCodMoneda_AN.Text
            If loFK1.GetPK = sOk_ Then
                lblNombreMoneda.Text = loFK1.nombre
            End If
            loFK1.CerrarConexion()
            loFK1 = Nothing
        End If
        LPDespliegaTipoCotizacion()

    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodigo_NE.MaxLength = 3
        cmbTipo.MaxLength = 15
        txtAbreviado_AN.MaxLength = 15
        txtNombre_AN.MaxLength = 45
        cmbTimbrado.MaxLength = 2
        txtCodMoneda_AN.MaxLength = 3
        txtLineas_NE.MaxLength = 4
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
    Private Sub LPBorrarAlCancelar()
        If Me.Tag.ToString <> sAGREGAR_ Then Exit Sub

        Dim loDatos As New Ec020documentos
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liCodigo As Integer = Integer.Parse(txtCodigo_NE.Text.ToString)
        loDatos.codempresa = liCodEmpresa
        loDatos.coddocumento = liCodigo
        If loDatos.GetPK = sOk_ Then
            loDatos.codempresa = liCodEmpresa
            loDatos.coddocumento = liCodigo
            loDatos.Del(sNo_, sNo_)
        End If
        loDatos.CerrarConexion()
        loDatos = Nothing
    End Sub
    Private Function LFsTipoCotizacion() As String
        Dim lsResultado As String = rbtCompra.Text

        If rbtCompra.Checked Then
            lsResultado = rbtCompra.Text
        End If
        If rbtVenta.Checked Then
            lsResultado = rbtVenta.Text
        End If
        If rbtSemisuma.Checked Then
            lsResultado = rbtSemisuma.Text
        End If

        Return lsResultado
    End Function
    Private Sub TipoCotizacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCompra.CheckedChanged, rbtVenta.CheckedChanged, rbtSemisuma.CheckedChanged
        LPDespliegaTipoCotizacion()
    End Sub
    Private Sub LPDespliegaTipoCotizacion()
        rbtCompra.BackColor = moColor
        rbtVenta.BackColor = moColor
        rbtSemisuma.BackColor = moColor

        If rbtCompra.Checked = True Then
            rbtCompra.BackColor = Color.LightBlue
        End If
        If rbtVenta.Checked = True Then
            rbtVenta.BackColor = Color.LightBlue
        End If
        If rbtSemisuma.Checked = True Then
            rbtSemisuma.BackColor = Color.LightBlue
        End If
    End Sub
    Private Sub LPInicializaParametros()
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String = ""
        Dim lsValor As String = ""
        Dim lsCodigo As String = ""

        lsClave = "c020documentos.aplicacion"
        lsValor = sLinea_ & sSF_ & sTotales_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbAplicacion.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbAplicacion.Items.Add(lsValor)
        Next
        If Me.Tag.ToString = sAGREGAR_ Then
            cmbAplicacion.Text = cmbAplicacion.Items(0).ToString
        End If
    End Sub
End Class