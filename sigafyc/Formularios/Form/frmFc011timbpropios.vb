Imports System.ComponentModel
Public Class frmFc011timbpropios
    Private miTiempoVigenciaTimbrado As Integer = 1
    Private msValidado As String = ""
    Private msRequeridos As String() = {"codsucursal", "prefijo", "desdenumero", "hastanumero"}
    Private moRequeridos As New ArrayList(msRequeridos)
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
                    If msValidado.Length = 0 Then
                        msValidado = loControl.Name.Trim & "->" & loControl.Tag.ToString
                    Else
                        msValidado &= vbCrLf & loControl.Name.Trim & "->" & loControl.Tag.ToString
                    End If
                End If
            Next

            If InStr(msValidado, sCancelar_) > 0 Then
                GFsAvisar("Validacion final" & vbCrLf & msValidado, sMENSAJE_, "No han sido ingresado correctamente todos los datos")
                txtNumTimbrado_NE.Focus()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ec011timbpropios
                        loDatos.numTimbrado = txtNumTimbrado_NE.Text
                        loDatos.codSucursal = Integer.Parse(txtCodSucursal_NE.Text.ToString)
                        loDatos.prefijo = txtPrefijo_AN.Text
                        loDatos.desdeNumero = Integer.Parse(txtDesdeNumero_NE.Text)
                        loDatos.hastaNumero = Integer.Parse(txtHastaNumero_NE.Text)
                        If cmbEstado.Text.Trim.Length > 0 Then
                            loDatos.estado = cmbEstado.Text
                        End If
                        loDatos.Add()
                        loDatos.CerrarConexion()
                    Case sMODIFICAR_
                        Dim loDatos As New Ec011timbpropios
                        loDatos.numTimbrado = txtNumTimbrado_NE.Text
                        loDatos.codSucursal = Integer.Parse(txtCodSucursal_NE.Text)
                        loDatos.prefijo = txtPrefijo_AN.Text
                        If loDatos.GetPK = sOk_ Then
                            loDatos.numTimbrado = txtNumTimbrado_NE.Text
                            loDatos.codSucursal = Integer.Parse(txtCodSucursal_NE.Text.ToString)
                            loDatos.prefijo = txtPrefijo_AN.Text
                            loDatos.desdeNumero = Integer.Parse(txtDesdeNumero_NE.Text)
                            loDatos.hastaNumero = Integer.Parse(txtHastaNumero_NE.Text)
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
                Me.AccessibleName = txtPrefijo_AN.Text
                LPGuardaValoresPredeterminados()
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ec011timbpropios
                loDatos.numTimbrado = txtNumTimbrado_NE.Text
                loDatos.codSucursal = Integer.Parse(txtCodSucursal_NE.Text)
                loDatos.prefijo = txtPrefijo_AN.Text
                If loDatos.GetPK = sOk_ Then
                    loDatos.numTimbrado = txtNumTimbrado_NE.Text
                    loDatos.codSucursal = Integer.Parse(txtCodSucursal_NE.Text)
                    loDatos.prefijo = txtPrefijo_AN.Text
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
                Case "codsucursal"
                    lsValorInicial = GFsParametroObtener(sUsuario_, txtCodSucursal_NE.AccessibleName)
                    If lsValorInicial = sRESERVADO_ Then
                        lsValorInicial = "0"
                    End If
            End Select
            CType(sender, Control).Text = lsValorInicial
            CType(sender, Control).Tag = sCancelar_
            e.Cancel = True
        Else
            Dim liCodEmpresa As Integer = 0
            Dim liCodSucursal As Integer = 0
            Select Case CType(sender, Control).AccessibleName
                Case "codsucursal"
                    If Not IsNumeric(txtCodSucursal_NE.Text) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    liCodSucursal = Integer.Parse(txtCodSucursal_NE.Text)
                    If liCodSucursal = 0 Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    txtCodSucursal_NE.Text = liCodSucursal.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength)
                    If Me.Tag.ToString = sAGREGAR_ Then
                        liCodEmpresa = CType(entidad, Ec010timbpropios).codEmpresa
                    Else
                        Dim lsNumTimbrado = CType(entidad, Ec011timbpropios).numTimbrado
                        Dim loC010 As New Ec010timbpropios
                        loC010.numTimbrado = lsNumTimbrado
                        If loC010.GetPK = sOk_ Then
                            liCodEmpresa = loC010.codEmpresa
                        End If
                        loC010.CerrarConexion()
                    End If
                    liCodSucursal = Integer.Parse(txtCodSucursal_NE.Text.ToString)
                    Dim loFK As New Eb070sucursales
                    Dim lsResultado As String = ""
                    loFK.codEmpresa = liCodEmpresa
                    loFK.codSucursal = liCodSucursal
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBb070sucursales
                        loLookUp.codEmpresa = liCodEmpresa
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodSucursal_NE.Text = CType(loLookUp.entidad, Eb070sucursales).codSucursal.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength)
                            txtCodSucursal_NE.Refresh()
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    If txtPrefijo_AN.Text.Length = 0 Then
                        txtPrefijo_AN.Text = txtCodSucursal_NE.Text & "-"
                        txtPrefijo_AN.Refresh()
                    End If
                    loFK.CerrarConexion()

                Case "prefijo"
                    If txtPrefijo_AN.Text.ToString.Length <> txtPrefijo_AN.MaxLength Then
                        GFsAvisar("El prefijo no cumple con los requerimientos definidos", sMENSAJE_, "Favor intentelo de nuevo.")
                        If txtPrefijo_AN.Text.Length > txtCodSucursal_NE.Text.Length + 1 Then
                            Dim liPuntoExped As Integer = Integer.Parse(txtPrefijo_AN.Text.Substring(txtCodSucursal_NE.Text.Length + 1, txtPrefijo_AN.Text.Length - (txtCodSucursal_NE.Text.Length + 1)))
                            txtPrefijo_AN.Text = txtPrefijo_AN.Text.Substring(0, txtCodSucursal_NE.Text.Length + 1) & liPuntoExped.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength)
                        End If
                        e.Cancel = True
                        Exit Sub
                    End If
                    If txtPrefijo_AN.Text.Substring(0, txtCodSucursal_NE.MaxLength) <> txtCodSucursal_NE.Text Then
                        Dim lsPrefijo As String = txtPrefijo_AN.Text.Substring(txtPrefijo_AN.MaxLength - txtCodSucursal_NE.MaxLength, txtCodSucursal_NE.MaxLength)
                        txtPrefijo_AN.Text = txtCodSucursal_NE.Text & "-" & lsPrefijo
                        txtPrefijo_AN.Refresh()
                        GFsAvisar("El prefijo su primera parte debe ser [" & txtCodSucursal_NE.Text & "]", sMENSAJE_, "Favor intentelo de nuevo.")
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim loPk As New Ec011timbpropios
                    loPk.numTimbrado = txtNumTimbrado_NE.Text
                    loPk.codSucursal = Integer.Parse(txtCodSucursal_NE.Text)
                    loPk.prefijo = txtPrefijo_AN.Text
                    If loPk.GetPK = sOk_ Then
                        GFsAvisar("Timbrado No. [" & txtNumTimbrado_NE.Text & "], Sucursal [" & txtCodSucursal_NE.Text & "], Prefijo [" & txtPrefijo_AN.Text & "]", sMENSAJE_, "ya existe! Y no puede duplicarse.")
                        e.Cancel = True
                    End If
                    loPk.CerrarConexion()

                    If GFsPuedeUsar("Empresa[" & liCodEmpresa.ToString(sFormatD_ & "6") & "], Sucursal[" & liCodSucursal.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength) & "], Prefijo[" & txtPrefijo_AN.Text & "]", "Empresa[" & liCodEmpresa.ToString(sFormatD_ & "6") & "], Sucursal[" & liCodSucursal.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength) & "], Prefijo[" & txtPrefijo_AN.Text & "]") <> sSi_ Then
                        GFsAvisar("Usted no esta autorizado para Gestinar con Empresa[" & liCodEmpresa.ToString(sFormatD_ & "6") & "], Sucursal[" & liCodSucursal.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength) & ", Prefijo[" & txtPrefijo_AN.Text & "]", sMENSAJE_, "Consulte con el Administrador del Sistema")
                        e.Cancel = True
                        Exit Sub
                    End If

                Case "desdenumero"
                    If Not IsNumeric(txtDesdeNumero_NE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtDesdeNumero_NE.Text & "] no es un NUMERO ENTERO valido", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim liNumero As Integer = Integer.Parse(txtDesdeNumero_NE.Text.ToString)
                    txtDesdeNumero_NE.Text = liNumero.ToString(sFormatD_ & txtDesdeNumero_NE.MaxLength)
                    txtDesdeNumero_NE.Refresh()

                Case "hastanumero"
                    If Not IsNumeric(txtHastaNumero_NE.Text) Then
                        GFsAvisar("El dato ingresado [" & txtHastaNumero_NE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
                        e.Cancel = True
                        Exit Sub
                    End If
                    Dim liNumero As Integer = Integer.Parse(txtHastaNumero_NE.Text.ToString)
                    txtHastaNumero_NE.Text = liNumero.ToString(sFormatD_ & txtHastaNumero_NE.MaxLength)

                    If txtHastaNumero_NE.Text < txtDesdeNumero_NE.Text Then
                        Dim lsAuxiliar As String = txtHastaNumero_NE.Text
                        txtHastaNumero_NE.Text = txtDesdeNumero_NE.Text
                        txtDesdeNumero_NE.Text = lsAuxiliar
                        txtDesdeNumero_NE.Refresh()
                        txtHastaNumero_NE.Refresh()
                        txtDesdeNumero_NE.Focus()
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
        Dim lsNumTimbrado As String = ""
        Dim liCodEmpresa As Integer = 0
        Dim liCodSucursal As Integer = 0

        lblNombreSucursal.Text = ""
        If Me.Tag.ToString <> sAGREGAR_ Then
            If txtCodSucursal_NE.Text.Trim.Length > 0 Then
                lsNumTimbrado = CType(entidad, Ec011timbpropios).numTimbrado
                Dim loC010 As New Ec010timbpropios
                loC010.numTimbrado = lsNumTimbrado
                If loC010.GetPK = sOk_ Then
                    liCodEmpresa = loC010.codEmpresa
                End If
                Dim loFK As New Eb070sucursales
                liCodSucursal = Integer.Parse(txtCodSucursal_NE.Text)
                loFK.codEmpresa = liCodEmpresa
                loFK.codSucursal = liCodSucursal
                If loFK.GetPK = sOk_ Then
                    lblNombreSucursal.Text = loFK.abreviado
                End If
                loFK.CerrarConexion()
                txtCodSucursal_NE.Text = liCodSucursal.ToString(sFormatD_ & txtCodSucursal_NE.MaxLength)
            End If
        End If
        lblNombreEmpresa.Text = ""
        Dim loC001 As New Ec001empresas
        If liCodEmpresa = 0 Then ' then 
            loC001.codEmpresa = CType(entidad, Ec010timbpropios).codEmpresa
        Else
            loC001.codEmpresa = liCodEmpresa
        End If
        If loC001.GetPK = sOk_ Then
            lblNombreEmpresa.Text = loC001.nombre
        End If
        loC001.CerrarConexion()

    End Sub

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim lsClave As String = "Timbrado - tiempo vigencia en años"
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
        msEntidad = "registro Timbrado propio"
        lblNombreSucursal.Text = ""
        DesplegarMensaje()

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                lblNombreEmpresa.Text = ""
                txtNumTimbrado_NE.Text = CType(entidad, Ec010timbpropios).numTimbrado
                Dim loC001 As New Ec001empresas
                loC001.codEmpresa = CType(entidad, Ec010timbpropios).codEmpresa
                If loC001.GetPK = sOk_ Then
                    lblNombreEmpresa.Text = loC001.nombre
                End If
                loC001.CerrarConexion()

            Case Else
                Dim loDatos As New Ec011timbpropios
                loDatos.numTimbrado = CType(entidad, Ec011timbpropios).numTimbrado
                loDatos.codSucursal = CType(entidad, Ec011timbpropios).codSucursal
                loDatos.prefijo = CType(entidad, Ec011timbpropios).prefijo
                If loDatos.GetPK() = sOk_ Then
                    txtNumTimbrado_NE.Text = loDatos.numTimbrado
                    txtCodSucursal_NE.Text = loDatos.codSucursal.ToString
                    txtPrefijo_AN.Text = loDatos.prefijo
                    txtDesdeNumero_NE.Text = loDatos.desdeNumero.ToString
                    txtHastaNumero_NE.Text = loDatos.hastaNumero.ToString
                    cmbEstado.Text = loDatos.estado
                End If
                loDatos.CerrarConexion()
                loDatos = Nothing
        End Select
        ' Habilita o deshabilita los controles de edición
        txtNumTimbrado_NE.Enabled = False
        txtCodSucursal_NE.Enabled = True
        txtPrefijo_AN.Enabled = True
        txtDesdeNumero_NE.Enabled = True
        txtHastaNumero_NE.Enabled = True
        cmbEstado.Enabled = True

        txtNumTimbrado_NE.AccessibleName = "numtimbrado"
        txtCodSucursal_NE.AccessibleName = "codsucursal"
        txtPrefijo_AN.AccessibleName = "prefijo"
        txtDesdeNumero_NE.AccessibleName = "desdenumero"
        txtHastaNumero_NE.AccessibleName = "hastanumero"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtNumTimbrado_NE.Tag = sOk_

            Case sMODIFICAR_
                txtCodSucursal_NE.Enabled = False
                txtPrefijo_AN.Enabled = False
                txtNumTimbrado_NE.Tag = sOk_
                txtCodSucursal_NE.Tag = sOk_
                txtPrefijo_AN.Tag = sOk_
                'txtDesdeNumero_NE.Tag = sOk_
                'txtHastaNumero_NE.Tag = sOk_
                'cmbEstado.Tag = sOk_

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
                txtCodSucursal_NE.Focus()
            Case sMODIFICAR_
                txtCodSucursal_NE.Focus()
        End Select

    End Sub

    Private Sub LPInicializaMaxLength()
        txtNumTimbrado_NE.MaxLength = 15
        txtCodSucursal_NE.MaxLength = 3
        txtPrefijo_AN.MaxLength = 7
        txtDesdeNumero_NE.MaxLength = 7
        txtHastaNumero_NE.MaxLength = 7
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