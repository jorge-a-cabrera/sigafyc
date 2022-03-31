﻿Imports System.ComponentModel

Public Class frmFc030ubicaciones
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "coddeposito", "codubicacion", "nombre", "estado"}
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
                txtCodUbicacion_AN.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ec030ubicaciones
                        LPTruncaSegunLongitud()
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codDeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                        loDatos.codUbicacion = txtCodUbicacion_AN.Text
                        loDatos.nombre = txtNombre_AN.Text
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

                    Case sMODIFICAR_
                        Dim loDatos As New Ec030ubicaciones
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codDeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                        loDatos.codUbicacion = txtCodUbicacion_AN.Text
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.codDeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                            loDatos.codUbicacion = txtCodUbicacion_AN.Text
                            loDatos.nombre = txtNombre_AN.Text
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
                Me.AccessibleName = txtCodUbicacion_AN.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ec030ubicaciones
                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.codDeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                loDatos.codUbicacion = txtCodUbicacion_AN.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.codDeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                    loDatos.codUbicacion = txtCodUbicacion_AN.Text
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
                    lsValorInicial = "Ubicacion " & txtCodUbicacion_AN.Text.Trim
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
        msEntidad = "Ubicaciones"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ec030ubicaciones
                txtCodEmpresa_NE.Text = CType(entidad, Ec030ubicaciones).codEmpresa.ToString
                txtCodDeposito_NE.Text = CType(entidad, Ec030ubicaciones).codDeposito.ToString
                txtCodEmpresa_NE.Tag = sOk_
                txtCodDeposito_NE.Tag = sOk_
                loDatos.CerrarConexion()
                loDatos = Nothing
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ec030ubicaciones).codEmpresa.ToString
                txtCodDeposito_NE.Text = CType(entidad, Ec030ubicaciones).codDeposito.ToString
                txtCodUbicacion_AN.Text = CType(entidad, Ec030ubicaciones).codUbicacion
                txtNombre_AN.Text = CType(entidad, Ec030ubicaciones).nombre
                cmbEstado.Text = CType(entidad, Ec030ubicaciones).estado
                txtCodEmpresa_NE.Tag = sOk_
                txtCodDeposito_NE.Tag = sOk_
                txtCodUbicacion_AN.Tag = sOk_
                txtNombre_AN.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtCodDeposito_NE.Enabled = True
        txtCodUbicacion_AN.Enabled = True
        txtNombre_AN.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codEmpresa"
        txtCodDeposito_NE.AccessibleName = "codDeposito"
        txtCodUbicacion_AN.AccessibleName = "codUbicacion"
        txtNombre_AN.AccessibleName = "nombre"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodDeposito_NE.Enabled = False
                txtCodDeposito_NE.Tag = sOk_

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodDeposito_NE.Enabled = False
                txtCodDeposito_NE.Tag = sOk_
                txtCodUbicacion_AN.Enabled = False
                txtCodUbicacion_AN.Tag = sOk_

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
                txtCodUbicacion_AN.Focus()
            Case sMODIFICAR_
                txtNombre_AN.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Ec001empresas
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loFK.nombre
            End If
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString)
            loFK.CerrarConexion()
        End If

        Dim liCodDeposito As Integer = Integer.Parse(txtCodDeposito_NE.Text.ToString)
        lblNombreDeposito.Text = ""
        If txtCodDeposito_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Eb040depositos
            loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loFK.coddeposito = Integer.Parse(txtCodDeposito_NE.Text)
            If loFK.GetPK = sOk_ Then
                lblNombreDeposito.Text = loFK.nombre
            End If
            loFK.CerrarConexion()
            txtCodDeposito_NE.Text = liCodDeposito.ToString(sFormatD_ & txtCodDeposito_NE.MaxLength.ToString)
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodDeposito_NE.MaxLength = 3
        txtCodUbicacion_AN.MaxLength = 15
        txtNombre_AN.MaxLength = 100
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
    End Sub
End Class