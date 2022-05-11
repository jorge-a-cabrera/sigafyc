Imports System.ComponentModel

Public Class frmFc040mercimpuestos
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "operacion", "codmercaderia", "codimpuesto"}
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
                cmbOperacion.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ec040mercimpuestos
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loDatos.operacion = cmbOperacion.Text
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.codImpuesto = txtCodImpuesto_AN.Text
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        loDatos.Add()
                        loDatos.CerrarConexion()
                        loDatos = Nothing
                    Case sMODIFICAR_
                        Dim loDatos As New Ec040mercimpuestos
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loDatos.operacion = cmbOperacion.Text
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text
                        loDatos.codImpuesto = txtCodImpuesto_AN.Text
                        If loDatos.GetPK = sOk_ Then
                            loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                            loDatos.operacion = cmbOperacion.Text
                            loDatos.codmercaderia = txtCodMercaderia_AN.Text
                            loDatos.codImpuesto = txtCodImpuesto_AN.Text
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
                Me.AccessibleName = txtCodImpuesto_AN.Text
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ec040mercimpuestos
                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loDatos.operacion = cmbOperacion.Text
                loDatos.codmercaderia = txtCodMercaderia_AN.Text
                loDatos.codImpuesto = txtCodImpuesto_AN.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loDatos.operacion = cmbOperacion.Text
                    loDatos.codmercaderia = txtCodMercaderia_AN.Text
                    loDatos.codImpuesto = txtCodImpuesto_AN.Text
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
                Case "operacion"
                    lsValorInicial = cmbOperacion.Items(0).ToString
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
            Exit Sub
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codimpuesto"
                    Dim loPk As New Ec040mercimpuestos
                    loPk.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loPk.operacion = cmbOperacion.Text
                    loPk.codmercaderia = txtCodMercaderia_AN.Text
                    loPk.codImpuesto = txtCodImpuesto_AN.Text
                    If loPk.GetPK = sOk_ Then
                        GFsAvisar("Empresa[" & txtCodEmpresa_NE.Text & "] Operacion[" & cmbOperacion.Text & "] Mercaderia[" & txtCodMercaderia_AN.Text & "] Impuesto[" & txtCodImpuesto_AN.Text & "]", sMENSAJE_, "ya existe! Y no puede duplicarse.")
                        e.Cancel = True
                        Exit Sub
                    End If
                    loPk.CerrarConexion()

                    Dim loFK As New Ea040impuestos
                    loFK.operacion = cmbOperacion.Text
                    loFK.codImpuesto = txtCodImpuesto_AN.Text
                    Dim lsResultado As String = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBa040impuestos
                        loLookUp.operacion = cmbOperacion.Text
                        loLookUp.entidad = loFK
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodImpuesto_AN.Text = CType(loLookUp.entidad, Ea040impuestos).codImpuesto
                            txtCodImpuesto_AN.Tag = sOk_
                            e.Cancel = True
                            Exit Sub

                        Else
                            txtCodMercaderia_AN.Tag = sCancelar_
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
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        LPInicializaMaxLength()
        LPInicializaControles()
        ' Inicializa los controles de edición con los valores pertinentes
        msEntidad = "documentos/impuestos"
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                txtCodEmpresa_NE.Text = CType(entidad, Ec040mercimpuestos).codEmpresa.ToString
                cmbOperacion.Text = CType(entidad, Ec040mercimpuestos).operacion
                txtCodMercaderia_AN.Text = CType(entidad, Ec040mercimpuestos).codmercaderia
                txtCodEmpresa_NE.Tag = sOk_
                cmbOperacion.Tag = sOk_
                txtCodMercaderia_AN.Tag = sOk_
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ec040mercimpuestos).codEmpresa.ToString
                cmbOperacion.Text = CType(entidad, Ec040mercimpuestos).operacion
                txtCodMercaderia_AN.Text = CType(entidad, Ec040mercimpuestos).codmercaderia
                txtCodImpuesto_AN.Text = CType(entidad, Ec040mercimpuestos).codImpuesto
                cmbEstado.Text = CType(entidad, Ec040mercimpuestos).estado

                txtCodEmpresa_NE.Tag = sOk_
                cmbOperacion.Tag = sOk_
                txtCodMercaderia_AN.Tag = sOk_
                txtCodImpuesto_AN.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        cmbOperacion.Enabled = True
        txtCodMercaderia_AN.Enabled = True
        txtCodImpuesto_AN.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        cmbOperacion.AccessibleName = "operacion"
        txtCodMercaderia_AN.AccessibleName = "codmercaderia"
        txtCodImpuesto_AN.AccessibleName = "codimpuesto"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                cmbOperacion.Enabled = False
                txtCodMercaderia_AN.Enabled = False

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                cmbOperacion.Enabled = False
                txtCodMercaderia_AN.Enabled = False
                txtCodImpuesto_AN.Enabled = False

            Case sCONSULTAR_, sBORRAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.Substring(0, 3)) > 0 Then
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
                txtCodImpuesto_AN.Focus()
        End Select
    End Sub

    Private Sub LPDespliegaDescripciones()
        lblNomEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim loFK1 As New Ec001empresas
            loFK1.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            If loFK1.GetPK = sOk_ Then
                lblNomEmpresa.Text = loFK1.nombre
            End If
            loFK1.CerrarConexion()
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)
        End If

        lblNomMercaderia.Text = ""
        If txtCodMercaderia_AN.Text.Trim.Length > 0 Then
            Select Case cmbOperacion.Text
                Case sCompra_
                    Dim loFK1 As New Ed020mercentrada
                    loFK1.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK1.codmercaderia = txtCodMercaderia_AN.Text
                    If loFK1.GetPK = sOk_ Then
                        lblNomMercaderia.Text = loFK1.nombre
                    End If
                    loFK1.CerrarConexion()
                Case sVenta_
                    Dim loFK1 As New Ed030mercsalida
                    loFK1.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK1.codmercaderia = txtCodMercaderia_AN.Text
                    If loFK1.GetPK = sOk_ Then
                        lblNomMercaderia.Text = loFK1.nombre
                    End If
                    loFK1.CerrarConexion()
            End Select
        End If

        lblNomImpuesto.Text = ""
        If txtCodImpuesto_AN.Text.Trim.Length > 0 Then
            Dim loFK1 As New Ea040impuestos
            loFK1.operacion = cmbOperacion.Text
            loFK1.codImpuesto = txtCodImpuesto_AN.Text
            If loFK1.GetPK = sOk_ Then
                lblNomImpuesto.Text = loFK1.nombre
            End If
            loFK1.CerrarConexion()
        End If
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        cmbOperacion.MaxLength = 15
        txtCodMercaderia_AN.MaxLength = 20
        txtCodImpuesto_AN.MaxLength = 15
        cmbEstado.MaxLength = 15
    End Sub

    Private Sub LPInicializaControles()
        For Each loTabPage As TabPage In TabControl1.TabPages
            If loTabPage.AccessibleName = sActivo_ Then
                For Each loControl As Control In loTabPage.Controls
                    loControl.Tag = sCancelar_
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
                            AddHandler loControl.Validating, AddressOf ManejoEvento_Validating
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                        Case sPrefijoGroupBox_
                            For Each loControl1 As Control In loControl.Controls
                                loControl1.Tag = sCancelar_
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
                                        AddHandler loControl1.Validating, AddressOf ManejoEvento_Validating
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

        lsClave = "c040mercimpuestos.operacion"
        lsValor = sCompra_ & sSF_ & sVenta_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbOperacion.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbOperacion.Items.Add(lsValor)
        Next
    End Sub
End Class