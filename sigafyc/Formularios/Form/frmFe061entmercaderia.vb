Imports System.Globalization
Imports System.ComponentModel
Public Class frmFe061entmercaderia
    Private msValidado() As String
    Private msRequeridos As String() = {"codempresa", "numtransaccion", "numorden", "codubicacion", "codmercaderia", "nommercaderia", "codunidad", "cantentrada", "cantsalida", "costo_mb", "costoimpuesto_mb", "compneta_mb", "compimpuesto_mb", "gastneta_mb", "gastimpuesto_mb"}
    Private moRequeridos As New ArrayList(msRequeridos)
    Private msCodMoneda_mb As String = ""
    Private msNomMoneda_mb As String = ""
    Private miDecimales_mb As Integer
    Private msCulture_mb As String
    Private msCodUnidad As String = ""
    Private msIva As String = ""
    Private msLinea As String = ""
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
                txtCodMercaderia_AN.Select()
            Else
                Select Case Me.Tag.ToString
                    Case sAGREGAR_
                        Dim loDatos As New Ee061entmercaderia
                        LPTruncaSegunLongitud()
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                        loDatos.codubicacion = txtCodUbicacion_AN.Text
                        loDatos.codmercaderia = txtCodMercaderia_AN.Text.ToString
                        loDatos.nommercaderia = lblNomMercaderia.Text.ToString
                        loDatos.codunidad = txtCodUnidad_AN.Text.ToString
                        loDatos.cantentrada = Decimal.Parse(Decimal.Parse(txtCantEntrada_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.cantsalida = Decimal.Parse(Decimal.Parse(txtCantSalida_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.costo_mb = Decimal.Parse(Decimal.Parse(txtCosto_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.costoimpuesto_mb = Decimal.Parse(Decimal.Parse(txtCostoImpuesto_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.compneta_mb = Decimal.Parse(Decimal.Parse(txtCompNeta_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.compimpuesto_mb = Decimal.Parse(Decimal.Parse(txtCompImpuesto_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.gastneto_mb = Decimal.Parse(Decimal.Parse(txtGastNeto_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.gastimpuesto_mb = Decimal.Parse(Decimal.Parse(txtGastImpuesto_ND.Text.ToString()).ToString(sFormatF_))
                        loDatos.estado = sActivo_
                        Try
                            loDatos.Put(sSi_, sSi_, sAGREGAR_)
                        Catch ex As Exception
                            LPOperacionCancelada()
                            Exit Sub
                        End Try
                        loDatos.CerrarConexion()
                    Case sMODIFICAR_
                        Dim loDatos As New Ee061entmercaderia
                        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                        loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                        If loDatos.GetPK = sOk_ Then
                            LPTruncaSegunLongitud()
                            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                            loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                            loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                            loDatos.codubicacion = txtCodUbicacion_AN.Text
                            loDatos.codmercaderia = txtCodMercaderia_AN.Text.ToString
                            loDatos.nommercaderia = lblNomMercaderia.Text.ToString
                            loDatos.codunidad = txtCodUnidad_AN.Text.ToString
                            loDatos.cantentrada = Decimal.Parse(Decimal.Parse(txtCantEntrada_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.cantsalida = Decimal.Parse(Decimal.Parse(txtCantSalida_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.costo_mb = Decimal.Parse(Decimal.Parse(txtCosto_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.costoimpuesto_mb = Decimal.Parse(Decimal.Parse(txtCostoImpuesto_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.compneta_mb = Decimal.Parse(Decimal.Parse(txtCompNeta_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.compimpuesto_mb = Decimal.Parse(Decimal.Parse(txtCompImpuesto_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.gastneto_mb = Decimal.Parse(Decimal.Parse(txtGastNeto_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.gastimpuesto_mb = Decimal.Parse(Decimal.Parse(txtGastImpuesto_ND.Text.ToString()).ToString(sFormatF_))
                            loDatos.estado = cmbEstado.Text
                            loDatos.Put()
                        End If
                        loDatos.CerrarConexion()
                End Select
                Me.Tag = sOk_
                '-->  .AccesibleName envia al Browse la información del codigo que luego deberia 
                '-->  ser usado para la localización del registro en el DataGridView
                Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                Me.AccessibleName = liNumTransaccion.ToString
                GPBitacoraRegistrar(sSALIO_, Me.Text & ", haciendo click en ACEPTAR.")
                Me.Close()
            End If
        Else
            If Me.Tag.ToString = sBORRAR_ Then
                Dim loDatos As New Ee061entmercaderia
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                If loDatos.GetPK = sOk_ Then
                    loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                    loDatos.numorden = Integer.Parse(txtNumOrden_NE.Text.ToString)
                    loDatos.Del()
                End If
                loDatos.CerrarConexion()
                loDatos = Nothing
            Else
                Dim liNumOrden As Integer = Integer.Parse(txtNumOrden_NE.Text.ToString)
                Me.AccessibleName = liNumOrden.ToString
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
        Else
            Select Case CType(sender, Control).AccessibleName
                Case "codmercaderia"
                    Dim loFK As New Ed020mercentrada
                    Dim lsResultado As String

                    loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.codmercaderia = txtCodMercaderia_AN.Text.ToString
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBd020mercentrada
                        loLookUp.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodMercaderia_AN.Text = CType(loLookUp.entidad, Ed020mercentrada).codmercaderia
                        Else
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                    txtCodMercaderia_AN.Tag = sOk_
                    loFK.CerrarConexion()

                Case "codunidad"
                    Dim loFK As New Eb110undalternativas
                    Dim lsResultado As String
                    loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.tipo = sEntrada_
                    loFK.codmercaderia = txtCodMercaderia_AN.Text.ToString
                    loFK.codunidad = txtCodUnidad_AN.Text.ToString
                    lsResultado = loFK.GetPK
                    If lsResultado = sSinRegistros_ Then
                        Dim loLookUp As New frmBb110undalternativas
                        loLookUp.Tag = sELEGIR_
                        loLookUp.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.tipo = sEntrada_
                        loLookUp.codmercaderia = txtCodMercaderia_AN.Text.ToString
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
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LPInicializaMaxLength()
        LPInicializaControles()
        ' Inicializa los controles de edición con los valores pertinentes
        Dim loControls As TabPage.ControlCollection = Me.TabPage1.Controls
        msEntidad = "entrada mercaderia o servicio"
        msLinea = lblTituloImporte.Text.ToString

        DesplegarMensaje()

        lblCosto_ND.AutoSize = False
        lblCosto_ND.Top = txtCosto_ND.Top
        lblCosto_ND.Left = txtCosto_ND.Left
        lblCosto_ND.Width = txtCosto_ND.Width
        lblCosto_ND.Height = txtCosto_ND.Height
        lblCosto_ND.TextAlign = ContentAlignment.MiddleRight
        lblCosto_ND.Visible = False
        txtCosto_ND.TextAlign = HorizontalAlignment.Right

        lblCostoImpuesto_ND.AutoSize = False
        lblCostoImpuesto_ND.Top = txtCostoImpuesto_ND.Top
        lblCostoImpuesto_ND.Left = txtCostoImpuesto_ND.Left
        lblCostoImpuesto_ND.Width = txtCostoImpuesto_ND.Width
        lblCostoImpuesto_ND.Height = txtCostoImpuesto_ND.Height
        lblCostoImpuesto_ND.TextAlign = ContentAlignment.MiddleRight
        lblCostoImpuesto_ND.Visible = False
        txtCostoImpuesto_ND.TextAlign = HorizontalAlignment.Right

        lblCompNeta_ND.AutoSize = False
        lblCompNeta_ND.Top = txtCompNeta_ND.Top
        lblCompNeta_ND.Left = txtCompNeta_ND.Left
        lblCompNeta_ND.Width = txtCompNeta_ND.Width
        lblCompNeta_ND.Height = txtCompNeta_ND.Height
        lblCompNeta_ND.TextAlign = ContentAlignment.MiddleRight
        lblCompNeta_ND.Visible = False
        txtCompNeta_ND.TextAlign = HorizontalAlignment.Right

        lblCompImpuesto_ND.AutoSize = False
        lblCompImpuesto_ND.Top = txtCompImpuesto_ND.Top
        lblCompImpuesto_ND.Left = txtCompImpuesto_ND.Left
        lblCompImpuesto_ND.Width = txtCompImpuesto_ND.Width
        lblCompImpuesto_ND.Height = txtCompImpuesto_ND.Height
        lblCompImpuesto_ND.TextAlign = ContentAlignment.MiddleRight
        lblCompImpuesto_ND.Visible = False
        txtCompImpuesto_ND.TextAlign = HorizontalAlignment.Right

        lblGastNeto_ND.AutoSize = False
        lblGastNeto_ND.Top = txtGastNeto_ND.Top
        lblGastNeto_ND.Left = txtGastNeto_ND.Left
        lblGastNeto_ND.Width = txtGastNeto_ND.Width
        lblGastNeto_ND.Height = txtGastNeto_ND.Height
        lblGastNeto_ND.TextAlign = ContentAlignment.MiddleRight
        lblGastNeto_ND.Visible = False
        txtGastNeto_ND.TextAlign = HorizontalAlignment.Right

        lblGastImpuesto_ND.AutoSize = False
        lblGastImpuesto_ND.Top = txtGastImpuesto_ND.Top
        lblGastImpuesto_ND.Left = txtGastImpuesto_ND.Left
        lblGastImpuesto_ND.Width = txtGastImpuesto_ND.Width
        lblGastImpuesto_ND.Height = txtGastImpuesto_ND.Height
        lblGastImpuesto_ND.TextAlign = ContentAlignment.MiddleRight
        lblGastImpuesto_ND.Visible = False
        txtGastImpuesto_ND.TextAlign = HorizontalAlignment.Right

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                For liNDX As Integer = 0 To loControls.Count - 1
                    If InStr("txt|cmb", loControls.Item(liNDX).Name.ToLower) > 0 Then
                        loControls.Item(liNDX).Text = ""
                    End If
                Next
                Dim loDatos As New Ee061entmercaderia
                txtCodEmpresa_NE.Text = CType(entidad, Ee061entmercaderia).codempresa.ToString
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Text = CType(entidad, Ee061entmercaderia).numtransaccion.ToString
                txtNumTransaccion_NE.Tag = sOk_
                txtNumOrden_NE.Text = loDatos.ReservarRegistro(Integer.Parse(txtCodEmpresa_NE.Text.ToString), CType(entidad, Ee061entmercaderia).numtransaccion).ToString
                txtNumOrden_NE.Tag = sOk_
                loDatos.CerrarConexion()
            Case Else
                txtCodEmpresa_NE.Text = CType(entidad, Ee061entmercaderia).codempresa.ToString
                txtNumTransaccion_NE.Text = CType(entidad, Ee061entmercaderia).numtransaccion.ToString
                txtNumOrden_NE.Text = CType(entidad, Ee061entmercaderia).numorden.ToString
                txtCodUbicacion_AN.Text = CType(entidad, Ee061entmercaderia).codubicacion
                txtCodMercaderia_AN.Text = CType(entidad, Ee061entmercaderia).codmercaderia
                lblNomMercaderia.Text = CType(entidad, Ee061entmercaderia).nommercaderia
                txtCodUnidad_AN.Text = CType(entidad, Ee061entmercaderia).codunidad
                txtCantEntrada_ND.Text = CType(entidad, Ee061entmercaderia).cantentrada.ToString(sFormatF_)
                txtCantSalida_ND.Text = CType(entidad, Ee061entmercaderia).cantsalida.ToString(sFormatF_)
                txtCosto_ND.Text = CType(entidad, Ee061entmercaderia).costo_mb.ToString(sFormatF_)
                txtCostoImpuesto_ND.Text = CType(entidad, Ee061entmercaderia).costoimpuesto_mb.ToString(sFormatF_)
                txtCompNeta_ND.Text = CType(entidad, Ee061entmercaderia).compneta_mb.ToString(sFormatF_)
                txtCompImpuesto_ND.Text = CType(entidad, Ee061entmercaderia).compimpuesto_mb.ToString(sFormatF_)
                txtGastNeto_ND.Text = CType(entidad, Ee061entmercaderia).gastneto_mb.ToString(sFormatF_)
                txtGastImpuesto_ND.Text = CType(entidad, Ee061entmercaderia).gastimpuesto_mb.ToString(sFormatF_)
                cmbEstado.Text = CType(entidad, Ee061entmercaderia).estado
                txtCodEmpresa_NE.Tag = sOk_
                txtNumTransaccion_NE.Tag = sOk_
                txtNumOrden_NE.Tag = sOk_
                txtCodUbicacion_AN.Tag = sOk_
                txtCodMercaderia_AN.Tag = sOk_
                txtCodUnidad_AN.Tag = sOk_
                txtCantEntrada_ND.Tag = sOk_
                txtCantSalida_ND.Tag = sOk_
                txtCosto_ND.Tag = sOk_
                txtCostoImpuesto_ND.Tag = sOk_
                txtCompNeta_ND.Tag = sOk_
                txtCompImpuesto_ND.Tag = sOk_
                txtGastNeto_ND.Tag = sOk_
                txtGastImpuesto_ND.Tag = sOk_
                cmbEstado.Tag = sOk_
        End Select
        ' Habilita o deshabilita los controles de edición
        txtCodEmpresa_NE.Enabled = True
        txtNumTransaccion_NE.Enabled = True
        txtNumOrden_NE.Enabled = True
        txtCodUbicacion_AN.Enabled = True
        txtCodMercaderia_AN.Enabled = True
        lblNomMercaderia.Enabled = True
        txtCodUnidad_AN.Enabled = True
        txtCantEntrada_ND.Enabled = True
        txtCantSalida_ND.Enabled = True
        txtCosto_ND.Enabled = True
        txtCostoImpuesto_ND.Enabled = True
        txtCompNeta_ND.Enabled = True
        txtCompImpuesto_ND.Enabled = True
        txtGastNeto_ND.Enabled = True
        txtGastImpuesto_ND.Enabled = True
        cmbEstado.Enabled = True

        txtCodEmpresa_NE.AccessibleName = "codempresa"
        txtNumTransaccion_NE.AccessibleName = "numtransaccion"
        txtNumOrden_NE.AccessibleName = "numorden"
        txtCodUbicacion_AN.AccessibleName = "codubicacion"
        txtCodMercaderia_AN.AccessibleName = "codmercaderia"
        lblNomMercaderia.AccessibleName = "nommercaderia"
        txtCodUnidad_AN.AccessibleName = "codunidad"
        txtCantEntrada_ND.AccessibleName = "cantentrada"
        txtCantSalida_ND.AccessibleName = "cantsalida"
        txtCosto_ND.AccessibleName = "costo"
        txtCostoImpuesto_ND.AccessibleName = "costoimpuesto"
        txtCompNeta_ND.AccessibleName = "compneta"
        txtCompImpuesto_ND.AccessibleName = "compimpuesto"
        txtGastNeto_ND.AccessibleName = "gastneto"
        txtGastImpuesto_ND.AccessibleName = "gastimpuesto"
        cmbEstado.AccessibleName = "estado"

        Select Case Me.Tag.ToString
            Case sAGREGAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtNumOrden_NE.Enabled = False

            Case sMODIFICAR_
                txtCodEmpresa_NE.Enabled = False
                txtNumTransaccion_NE.Enabled = False
                txtNumOrden_NE.Enabled = False
                txtCodUbicacion_AN.Enabled = False
                txtCodMercaderia_AN.Enabled = False
                lblNomMercaderia.Enabled = False
                txtCodUnidad_AN.Enabled = False

            Case sCONSULTAR_, sBORRAR_
                For Each loTabPage As TabPage In TabControl1.TabPages
                    If loTabPage.AccessibleName = sActivo_ Then
                        For Each loControl As Control In loTabPage.Controls
                            loControl.Tag = sCancelar_
                            If InStr("txt|cmb", loControl.Name.Substring(0, 3)) > 0 Then
                                loControl.Enabled = False
                            End If
                            If loControl.Name.Substring(0, 3) = "gbx" Then
                                For Each loControlNested As Control In loControl.Controls
                                    If InStr("txt|cmb", loControlNested.Name.Substring(0, 3)) > 0 Then
                                        loControlNested.Enabled = False
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
        End Select
        '--Primer campo seleccionado al ingresar.
        txtCodMercaderia_AN.Select()
    End Sub
    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LPDespliegaDescripciones()
    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim liCodEmpresa As Integer
        Dim liNumTransaccion As Integer
        Dim liNumOrden As Integer

        lblNomEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If Not IsNumeric(txtCodEmpresa_NE.Text) Then Exit Sub
            liCodEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

            Dim loFK As New Ec001empresas
            loFK.codEmpresa = liCodEmpresa
            If loFK.GetPK = sOk_ Then
                lblNomEmpresa.Text = loFK.nombre
                msCodMoneda_mb = loFK.codMoneda
                Dim loFK1 As New Ea010monedas
                loFK1.codMoneda = msCodMoneda_mb
                If loFK1.GetPK = sOk_ Then
                    msCodMoneda_mb = loFK1.codMoneda
                    msNomMoneda_mb = loFK1.nombre
                    miDecimales_mb = loFK1.decimales
                    msCulture_mb = loFK1.culture
                End If
            End If
            loFK.CerrarConexion()
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString)
        End If

        liNumTransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        txtNumTransaccion_NE.Text = liNumTransaccion.ToString(sFormatD_ & txtNumTransaccion_NE.MaxLength.ToString)

        liNumOrden = Integer.Parse(txtNumOrden_NE.Text.ToString)
        txtNumOrden_NE.Text = liNumOrden.ToString(sFormatD_ & txtNumOrden_NE.MaxLength.ToString)

        lblNomMercaderia.Text = ""
        If txtCodMercaderia_AN.Text.Trim.Length > 0 Then
            Dim loD020 As New Ed020mercentrada
            loD020.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loD020.codmercaderia = txtCodMercaderia_AN.Text
            If loD020.GetPK = sOk_ Then
                lblNomMercaderia.Text = loD020.nombre
                msCodUnidad = loD020.codunidad
                msIva = loD020.iva
            End If
            loD020.CerrarConexion()
        End If

        lblNomUnidad.Text = ""
        If txtCodUnidad_AN.Text.Trim.Length > 0 Then
            Dim loB110 As New Eb110undalternativas
            loB110.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loB110.tipo = sEntrada_
            loB110.codmercaderia = txtCodMercaderia_AN.Text.ToString
            loB110.codunidad = txtCodUnidad_AN.Text.ToString
            If loB110.GetPK = sOk_ Then
                lblNomUnidad.Text = loB110.nomunidad
            End If
        End If

        Dim loE060 As New Ee060entmercaderia
        loE060.codempresa = liCodEmpresa
        loE060.numtransaccion = liNumTransaccion
        If loE060.GetPK = sOk_ Then
            lblNomUbicacion.Text = ""
            Dim loB040 As New Eb040depositos
            loB040.codEmpresa = liCodEmpresa
            loB040.coddeposito = loE060.coddeposito
            If loB040.GetPK = sOk_ Then
                If loB040.ubicaciones = sSi_ Then
                    If txtCodUbicacion_AN.Text.Trim.Length > 0 Then
                        If txtCodUbicacion_AN.Text <> sNOAPLICA_ Then
                            Dim loC030 As New Ec030ubicaciones
                            loC030.codEmpresa = liCodEmpresa
                            loC030.codDeposito = loE060.coddeposito
                            If loC030.GetPK = sOk_ Then
                                lblNomUbicacion.Text = loB040.abreviado.Trim & " / " & loC030.nombre
                            End If
                            loC030.CerrarConexion()
                        End If
                    End If
                Else
                    lblNomUbicacion.Text = loB040.abreviado.Trim & " / *** SIN UBICACIONES ***"
                End If
            End If
            loB040.CerrarConexion()
        End If
        loE060.CerrarConexion()

        Dim ldValor As Decimal
        If txtCantEntrada_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCantEntrada_ND.Text) Then
                ldValor = Decimal.Parse(txtCantEntrada_ND.Text)
                txtCantEntrada_ND.Text = ldValor.ToString(sFormatF_)
            End If
        End If

        If txtCosto_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCosto_ND.Text) Then
                ldValor = Decimal.Parse(txtCosto_ND.Text)
                lblCosto_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblCosto_ND.Visible = True
                txtCosto_ND.SendToBack()
            End If
        End If

        If txtCostoImpuesto_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCostoImpuesto_ND.Text) Then
                ldValor = Decimal.Parse(txtCostoImpuesto_ND.Text)
                lblCostoImpuesto_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblCostoImpuesto_ND.Visible = True
                txtCostoImpuesto_ND.SendToBack()
            End If
        End If

        If txtCompNeta_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCompNeta_ND.Text) Then
                ldValor = Decimal.Parse(txtCompNeta_ND.Text)
                lblCompNeta_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblCompNeta_ND.Visible = True
                txtCompNeta_ND.SendToBack()
            End If
        End If

        If txtCompImpuesto_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtCompImpuesto_ND.Text) Then
                ldValor = Decimal.Parse(txtCompImpuesto_ND.Text)
                lblCompImpuesto_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblCompImpuesto_ND.Visible = True
                txtCompImpuesto_ND.SendToBack()
            End If
        End If

        If txtGastNeto_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtGastNeto_ND.Text) Then
                ldValor = Decimal.Parse(txtGastNeto_ND.Text)
                lblGastNeto_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblGastNeto_ND.Visible = True
                txtGastNeto_ND.SendToBack()
            End If
        End If

        If txtGastImpuesto_ND.Text.Trim.Length > 0 Then
            If IsNumeric(txtGastImpuesto_ND.Text) Then
                ldValor = Decimal.Parse(txtGastImpuesto_ND.Text)
                lblGastImpuesto_ND.Text = ldValor.ToString(sFormatC_ & miDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(msCulture_mb))
                lblGastImpuesto_ND.Visible = True
                txtGastImpuesto_ND.SendToBack()
            End If
        End If

        lblTituloImporte.Text = LFsTituloImporte("Importes en " & msNomMoneda_mb & " - c/IVA " & msIva)
        Select Case Me.Tag.ToString
            Case sAGREGAR_, sMODIFICAR_
                lblCosto_ND.BackColor = txtCosto_ND.BackColor
                lblCostoImpuesto_ND.BackColor = txtCostoImpuesto_ND.BackColor
                lblCompNeta_ND.BackColor = txtCompNeta_ND.BackColor
                lblCompImpuesto_ND.BackColor = txtCompImpuesto_ND.BackColor
                lblGastNeto_ND.BackColor = txtGastNeto_ND.BackColor
                lblGastImpuesto_ND.BackColor = txtGastImpuesto_ND.BackColor

            Case sCONSULTAR_, sBORRAR_
                lblCosto_ND.BackColor = Me.BackColor
                lblCostoImpuesto_ND.BackColor = Me.BackColor
                lblCompNeta_ND.BackColor = Me.BackColor
                lblCompImpuesto_ND.BackColor = Me.BackColor
                lblGastNeto_ND.BackColor = Me.BackColor
                lblGastImpuesto_ND.BackColor = Me.BackColor
        End Select

        Me.Refresh()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtNumTransaccion_NE.MaxLength = 6
        txtNumOrden_NE.MaxLength = 4
        txtCodUbicacion_AN.MaxLength = 15
        txtCodMercaderia_AN.MaxLength = 20
        txtCodUnidad_AN.MaxLength = 6
        txtCantEntrada_ND.MaxLength = 17
        txtCantSalida_ND.MaxLength = 17
        txtCosto_ND.MaxLength = 17
        txtCostoImpuesto_ND.MaxLength = 17
        txtCompNeta_ND.MaxLength = 17
        txtCompImpuesto_ND.MaxLength = 17
        txtGastNeto_ND.MaxLength = 17
        txtGastImpuesto_ND.MaxLength = 17
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
                            AddHandler loControl.Click, AddressOf TextBox_Click
                        Case sPrefijoComboBox_
                            AddHandler loControl.Validating, AddressOf ManejoEvento_Validating
                            AddHandler loControl.Validated, AddressOf ManejoEvento_Validated
                            AddHandler loControl.KeyDown, AddressOf ManejoEvento_KeyDown
                            AddHandler loControl.KeyPress, AddressOf ManejoEvento_KeyPress
                        Case sPrefijoRadioButton_
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
                                        AddHandler loControl1.Click, AddressOf TextBox_Click
                                    Case sPrefijoComboBox_
                                        AddHandler loControl1.Validating, AddressOf ManejoEvento_Validating
                                        AddHandler loControl1.Validated, AddressOf ManejoEvento_Validated
                                        AddHandler loControl1.KeyDown, AddressOf ManejoEvento_KeyDown
                                        AddHandler loControl1.KeyPress, AddressOf ManejoEvento_KeyPress
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

        Dim loDatos As New Ee061entmercaderia
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        Dim liNumOrden As Integer = Integer.Parse(txtNumOrden_NE.Text.ToString)
        loDatos.codempresa = liCodEmpresa
        loDatos.numtransaccion = liNumTransaccion
        loDatos.numorden = liNumOrden
        If loDatos.GetPK = sOk_ Then
            loDatos.codempresa = liCodEmpresa
            loDatos.numtransaccion = liNumTransaccion
            loDatos.numorden = liNumOrden
            loDatos.Del(sNo_, sNo_)
        End If
        loDatos.CerrarConexion()
        loDatos = Nothing
    End Sub
    Private Sub TextBox_Click(sender As Object, e As EventArgs)
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub lblcosto_ND_Click(sender As Object, e As EventArgs) Handles lblCosto_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCosto_ND.Visible = False
        txtCosto_ND.Focus()
        txtCosto_ND.SelectAll()
    End Sub
    Private Sub txtcosto_ND_GotFocus(sender As Object, e As EventArgs) Handles txtCosto_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCosto_ND.Visible = False
        txtCosto_ND.Focus()
        txtCosto_ND.SelectAll()
    End Sub

    Private Sub lblcostoimpuesto_ND_Click(sender As Object, e As EventArgs) Handles lblCostoImpuesto_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCostoImpuesto_ND.Visible = False
        txtCostoImpuesto_ND.Focus()
        txtCostoImpuesto_ND.SelectAll()
    End Sub
    Private Sub txtcostoimpuesto_ND_GotFocus(sender As Object, e As EventArgs) Handles txtCostoImpuesto_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCostoImpuesto_ND.Visible = False
        txtCostoImpuesto_ND.Focus()
        txtCostoImpuesto_ND.SelectAll()
    End Sub

    Private Sub lblcompneta_ND_Click(sender As Object, e As EventArgs) Handles lblCompNeta_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCompNeta_ND.Visible = False
        txtCompNeta_ND.Focus()
        txtCompNeta_ND.SelectAll()
    End Sub
    Private Sub txtcompneta_ND_GotFocus(sender As Object, e As EventArgs) Handles txtCompNeta_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCompNeta_ND.Visible = False
        txtCompNeta_ND.Focus()
        txtCompNeta_ND.SelectAll()
    End Sub

    Private Sub lblcompimpuesto_ND_Click(sender As Object, e As EventArgs) Handles lblCompImpuesto_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCompImpuesto_ND.Visible = False
        txtCompImpuesto_ND.Focus()
        txtCompImpuesto_ND.SelectAll()
    End Sub
    Private Sub txtcompimpuesto_ND_GotFocus(sender As Object, e As EventArgs) Handles txtCompImpuesto_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblCompImpuesto_ND.Visible = False
        txtCompImpuesto_ND.Focus()
        txtCompImpuesto_ND.SelectAll()
    End Sub

    Private Sub lblgastneto_ND_Click(sender As Object, e As EventArgs) Handles lblGastNeto_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblGastNeto_ND.Visible = False
        txtGastNeto_ND.Focus()
        txtGastNeto_ND.SelectAll()
    End Sub
    Private Sub txtgastneto_ND_GotFocus(sender As Object, e As EventArgs) Handles txtGastNeto_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblGastNeto_ND.Visible = False
        txtGastNeto_ND.Focus()
        txtGastNeto_ND.SelectAll()
    End Sub

    Private Sub lblgastimpuesto_ND_Click(sender As Object, e As EventArgs) Handles lblGastImpuesto_ND.Click
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblGastImpuesto_ND.Visible = False
        txtGastImpuesto_ND.Focus()
        txtGastImpuesto_ND.SelectAll()
    End Sub
    Private Sub txtgastimpuesto_ND_GotFocus(sender As Object, e As EventArgs) Handles txtGastImpuesto_ND.GotFocus
        If Me.Tag.ToString = sCONSULTAR_ Or Me.Tag.ToString = sBORRAR_ Then Exit Sub
        lblGastImpuesto_ND.Visible = False
        txtGastImpuesto_ND.Focus()
        txtGastImpuesto_ND.SelectAll()
    End Sub
    Private Function LFsTituloImporte(ByVal psTitulo As String, Optional ByVal pbUpperCase As Boolean = False) As String
        Dim lsResultado As String
        Dim lsSeparador As String = msLinea
        Dim liLongNeto As Integer = lsSeparador.Trim.Length - psTitulo.Trim.Length
        Dim liLongitud As Integer = liLongNeto \ 2
        Dim lsLadoIzquierdo As String = lsSeparador.Substring(0, liLongitud)
        Dim lsLadoDerecho As String = lsSeparador.Substring(0, liLongNeto - liLongitud)

        If Not pbUpperCase Then
            lsResultado = lsLadoIzquierdo & psTitulo.ToLower & lsLadoDerecho
        Else
            lsResultado = lsLadoIzquierdo & psTitulo.ToUpper & lsLadoDerecho
        End If
        Return lsResultado
    End Function

End Class