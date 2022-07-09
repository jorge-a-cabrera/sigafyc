Imports System.ComponentModel

Public Class frmFc050mercvinculadas
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "codsalida", "codentrada", "codunidad", "cantidad", "estado"}
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
                txtCodEntrada_AN.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ec050mercvinculadas
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codsalida = txtCodSalida_AN.Text
                        loDatos.codentrada = txtCodEntrada_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
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
                        Dim loDatos As New Ec050mercvinculadas
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codsalida = txtCodSalida_AN.Text
                        loDatos.codentrada = txtCodEntrada_AN.Text
                        loDatos.codunidad = txtCodUnidad_AN.Text
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.codsalida = txtCodSalida_AN.Text
                            loDatos.codentrada = txtCodEntrada_AN.Text
                            loDatos.codunidad = txtCodUnidad_AN.Text
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
                Me.AccessibleName = txtCodEntrada_AN.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ec050mercvinculadas
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.codsalida = txtCodSalida_AN.Text
                loDatos.codentrada = txtCodEntrada_AN.Text
                loDatos.codunidad = txtCodUnidad_AN.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.codsalida = txtCodSalida_AN.Text
                    loDatos.codentrada = txtCodEntrada_AN.Text
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
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
            Exit Sub
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codunidad"
                    Dim loFK As New Eb110undalternativas
                    Dim lsResultado As String
                    loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.tipo = sEntrada_
                    loFK.codmercaderia = txtCodEntrada_AN.Text
                    loFK.codunidad = txtCodUnidad_AN.Text
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBb110undalternativas
                        loLookUp.Tag = sELEGIR_
                        loLookUp.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.tipo = sEntrada_
                        loLookUp.codmercaderia = txtCodEntrada_AN.Text
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodUnidad_AN.Text = CType(loLookUp.entidad, Eb110undalternativas).codunidad
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodUnidad_AN.Tag = sOk_
                    loFK.CerrarConexion()

                Case "codentrada"
                    Dim loFK As New Ed020mercentrada
                    Dim lsResultado As String

                    loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.codmercaderia = txtCodEntrada_AN.Text
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBd020mercentrada
                        loLookUp.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodEntrada_AN.Text = CType(loLookUp.entidad, Ed020mercentrada).codmercaderia
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodEntrada_AN.Tag = sOk_
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
        msEntidad = "merc./servicios vinculados"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ec050mercvinculadas
                txtCodEmpresa_NE.Text = CType(entidad, Ec050mercvinculadas).codempresa.ToString
                txtCodSalida_AN.Text = CType(entidad, Ec050mercvinculadas).codsalida
                loDatos.CerrarConexion()

            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ec050mercvinculadas).codempresa.ToString
                txtCodSalida_AN.Text = CType(entidad, Ec050mercvinculadas).codsalida
                txtCodEntrada_AN.Text = CType(entidad, Ec050mercvinculadas).codentrada
                txtCodUnidad_AN.Text = CType(entidad, Ec050mercvinculadas).codunidad
                txtCantidad_ND.Text = CType(entidad, Ec050mercvinculadas).cantidad.ToString
                cmbEstado.Text = CType(entidad, Ec050mercvinculadas).estado

                txtCodEmpresa_NE.Tag = sOk_
                txtCodSalida_AN.Tag = sOk_
                txtCodEntrada_AN.Tag = sOk_
                txtCodUnidad_AN.Tag = sOk_
                txtCantidad_ND.Tag = sOk_
                cmbEstado.Tag = sOk_

        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtCodSalida_AN.Enabled = True
        txtCodEntrada_AN.Enabled = True
        txtCodUnidad_AN.Enabled = True
        txtCantidad_ND.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtCodSalida_AN.AccessibleName = "codsalida"
        txtCodEntrada_AN.AccessibleName = "codentrada"
        txtCodUnidad_AN.AccessibleName = "codunidad"
        txtCantidad_ND.AccessibleName = "cantidad"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodSalida_AN.Enabled = False
                txtCodSalida_AN.Tag = sOk_

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtCodEmpresa_NE.Tag = sOk_
                txtCodSalida_AN.Enabled = False
                txtCodSalida_AN.Tag = sOk_
                txtCodEntrada_AN.Enabled = False
                txtCodEntrada_AN.Tag = sOk_

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
                txtCodEntrada_AN.Focus()
            Case sMODIFICAR_
                txtCantidad_ND.Focus()
        End Select
        LPDespliegaDescripciones()
    End Sub

    Private Sub LPDespliegaDescripciones()
        Dim ldValorInicial As Decimal = 0.00D
        Dim ldEquivalente As Decimal
        Dim lsUnidad As String = ""
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

        lblNombreSalida.Text = ""
        If txtCodSalida_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Ed030mercsalida
            loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loFK.codmercaderia = txtCodSalida_AN.Text
            If loFK.GetPK = sOk_ Then
                lblNombreSalida.Text = loFK.nombre
                lblNombreSalida.Refresh()
            End If
            loFK.CerrarConexion()
        End If

        lblNombreEntrada.Text = ""
        If txtCodEntrada_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Ed020mercentrada
            loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loFK.codmercaderia = txtCodEntrada_AN.Text
            If loFK.GetPK = sOk_ Then
                lsUnidad = loFK.codunidad
                lblNombreEntrada.Text = loFK.nombre
                lblNombreEntrada.Refresh()
            End If
            loFK.CerrarConexion()
        End If
        If txtCantidad_ND.Text.Trim.Length = 0 Then
            txtCantidad_ND.Text = ldValorInicial.ToString(sFormatF_)
            txtCantidad_ND.Refresh()
        End If
        If IsNumeric(txtCantidad_ND.Text) = True Then
            Dim ldValor As Decimal = Decimal.Parse(txtCantidad_ND.Text)
            txtCantidad_ND.Text = ldValor.ToString(sFormatF_)
            txtCantidad_ND.Refresh()
        End If

        lblNombreUnidad.Text = ""
        If txtCodUnidad_AN.Text.Trim.Length > 0 Then
            Dim loFK As New Eb110undalternativas
            loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loFK.tipo = sEntrada_
            loFK.codmercaderia = txtCodEntrada_AN.Text
            loFK.codunidad = txtCodUnidad_AN.Text
            If loFK.GetPK = sOk_ Then
                ldEquivalente = loFK.cantidad
                lblNombreUnidad.Text = loFK.nomunidad
                lblNombreUnidad.Refresh()
            End If
            loFK.CerrarConexion()
        End If

        lblCantidadReal.Text = ""
        If txtCantidad_ND.Text.Length > 0 Then
            If IsNumeric(txtCantidad_ND.Text) = True Then
                Dim ldCantidad As Decimal = Decimal.Parse(txtCantidad_ND.Text)
                Dim ldValor As Decimal = ldCantidad * ldEquivalente
                lblCantidadReal.Text = "Equivalente a: " & ldValor.ToString(sFormatF_) & " " & lsUnidad
            End If
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodSalida_AN.MaxLength = 20
        txtCodEntrada_AN.MaxLength = 20
        txtCodUnidad_AN.MaxLength = 6
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
    End Sub
End Class