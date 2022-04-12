﻿Imports System.ComponentModel

Public Class frmBe020listaprecio
    Private moFormulario As frmFe020listaprecio
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer
    Private msCodMercaderia As String
    Private msCodUnidad As String
    Private Shared mbabrirform As Boolean = False

    Public Property codempresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property codmercaderia As String
        Get
            Return msCodMercaderia
        End Get
        Set(value As String)
            msCodMercaderia = value
        End Set
    End Property

    Public Property codunidad As String
        Get
            Return msCodUnidad
        End Get
        Set(value As String)
            msCodUnidad = value
        End Set
    End Property

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Point)
        DataGridView1.AllowUserToResizeColumns = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        LPSetDoubleBuffered(DataGridView1)

        LPInicializaMaxLength()

        mbAgregar = btnAgregar.Enabled
        mbModificar = btnModificar.Enabled
        mbBorrar = btnBorrar.Enabled
        mbConsultar = btnConsultar.Enabled
        mbAuditoria = btnAuditoria.Enabled

        btnAgregar.AccessibleName = sAGREGAR_
        btnModificar.AccessibleName = sMODIFICAR_
        btnBorrar.AccessibleName = sBORRAR_
        btnConsultar.AccessibleName = sCONSULTAR_

        AddHandler txtBuscar.TextChanged, AddressOf BuscarClave
        AddHandler btnAgregar.Click, AddressOf Botones_Click
        AddHandler btnModificar.Click, AddressOf Botones_Click
        AddHandler btnBorrar.Click, AddressOf Botones_Click
        AddHandler btnConsultar.Click, AddressOf Botones_Click
        AddHandler txtCodEmpresa_NE.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtCodEmpresa_NE.KeyDown, AddressOf ManejoEvento_KeyDown
        AddHandler txtCodMercaderia_AN.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtCodMercaderia_AN.KeyDown, AddressOf ManejoEvento_KeyDown
        AddHandler txtCodUnidad_AN.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtCodUnidad_AN.KeyDown, AddressOf ManejoEvento_KeyDown
        AddHandler DataGridView1.KeyDown, AddressOf DataGrid_KeyDown
        AddHandler DataGridView1.CellContentDoubleClick, AddressOf DataGrid_DoubleClick

        If Me.Tag.ToString = sELEGIR_ Then
            If Me.Name <> "frmBa010monedas" Then
                Dim lofrmBase As New frmBa010monedas
                txtBuscar.Width = lofrmBase.txtBuscar.Width
                DataGridView1.Location = New Point(lofrmBase.DataGridView1.Location.X, lofrmBase.DataGridView1.Location.Y + txtBuscar.Height + 10)
                DataGridView1.Height = lofrmBase.DataGridView1.Height - lofrmBase.txtBuscar.Height - 10
                DataGridView1.Width = lofrmBase.DataGridView1.Width
                btnAgregar.Location = lofrmBase.btnAgregar.Location
                btnModificar.Location = lofrmBase.btnModificar.Location
                btnBorrar.Location = lofrmBase.btnBorrar.Location
                btnConsultar.Location = lofrmBase.btnConsultar.Location
                btnAuditoria.Location = lofrmBase.btnAuditoria.Location
                btnSalir.Location = lofrmBase.btnSalir.Location
                Me.Size = lofrmBase.Size
                lofrmBase = Nothing
                txtCodEmpresa_NE.Text = miCodEmpresa.ToString
            End If
        End If

        lblNombreEmpresa.Text = ""
        mbabrirform = False
        If miCodEmpresa > 0 Then
            txtCodEmpresa_NE.Text = miCodEmpresa.ToString
            txtCodEmpresa_NE.Enabled = False
            If msCodMercaderia.Trim.Length > 0 Then
                txtCodMercaderia_AN.Text = msCodMercaderia
                txtCodMercaderia_AN.Enabled = False
                If msCodUnidad.Trim.Length > 0 Then
                    txtCodUnidad_AN.Text = msCodUnidad
                    txtCodUnidad_AN.Enabled = False
                End If
            End If
            LPCargarDatos()
        End If
        LPDespliegaDescripciones()
    End Sub

    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub
    Private Sub LPCargarDatos()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub

        Dim lsSQL As String = GFsGeneraSQL("frmBe020listaprecio")
        Dim loDatos As New Ee020listaprecio
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "vigencia, tipoprecio, valor, codmoneda, estado, codmercaderia, codunidad"
        Dim lsCamposOcultos As String = "codmercaderia, codunidad"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If

        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        lsSQL = lsSQL.Replace("&codempresa", Integer.Parse(txtCodEmpresa_NE.Text).ToString)
        lsSQL = lsSQL.Replace("&codmercaderia", txtCodMercaderia_AN.Text)
        lsSQL = lsSQL.Replace("&codunidad", txtCodUnidad_AN.Text)

        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName
        If lsCamposOcultos.Trim.Length > 0 Then
            Dim lsCampoOculto() As String = lsCamposOcultos.Split(","c)
            For i As Integer = 0 To lsCampoOculto.Length - 1
                DataGridView1.Columns(lsCampoOculto(i).Trim).Visible = False
            Next
        End If

        DataGridView1.Sort(DataGridView1.Columns("vigencia"), ListSortDirection.Ascending)
        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDatos.CerrarConexion()

        LPSinRegistro_AbrirForm()
        LPHabilitaControles()
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodMercaderia_AN.MaxLength = 20
        txtCodUnidad_AN.MaxLength = 6
    End Sub

    Private Sub LPDespliegaDescripciones()
        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Ec001empresas
            loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            If loFK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loFK.nombre
            End If
            loFK.CerrarConexion()
            loFK = Nothing
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)
        End If

        lblNombreMercaderia.Text = ""
        If txtCodMercaderia_AN.Text.Trim.Length > 0 Then
            If txtCodMercaderia_AN.Text.Trim.ToUpper = sTodas_.Trim.ToUpper Then
                lblNombreMercaderia.Text = sTodas_ & " LAS MERCADERIAS"
            Else
                Dim loFK As New Ed030mercsalida
                loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loFK.codmercaderia = txtCodMercaderia_AN.Text
                If loFK.GetPK = sOk_ Then
                    lblNombreMercaderia.Text = loFK.nombre
                End If
                loFK.CerrarConexion()
            End If
            lblNombreMercaderia.Refresh()
        End If

        lblNombreUnidad.Text = ""
        If txtCodUnidad_AN.Text.Trim.Length > 0 Then
            If txtCodUnidad_AN.Text.Trim.ToUpper = sTodas_ Then
                lblNombreUnidad.Text = sTodas_ & " LAS UNIDADES"
            Else
                Dim loFK As New Eb110undalternativas
                loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loFK.tipo = sEntrada_
                loFK.codmercaderia = txtCodMercaderia_AN.Text
                loFK.codunidad = txtCodUnidad_AN.Text
                If loFK.GetPK = sOk_ Then
                    lblNombreUnidad.Text = loFK.nomunidad
                End If
                loFK.CerrarConexion()
            End If
            lblNombreUnidad.Refresh()
        End If
    End Sub

    Private Sub LPLocalizaRegistro(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub

        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("vigencia").Value.ToString = psCodigo Then
                DataGridView1.ClearSelection()
                ' Aqui se selecciona la fila que contiene el codigo buscado
                DataGridView1.Rows(row.Index).Selected = True
                liIndex = row.Index
                Exit For
            End If
        Next
        ' Aqui es donde se mueve el DataGridView para que se pueda visualizar 
        ' la fila seleccionada.
        If liIndex > -1 Then
            DataGridView1.CurrentCell = DataGridView1.Rows(liIndex).Cells(0)
        End If
    End Sub

    Private Sub txtCodEmpresa_NE_Validating(sender As Object, e As CancelEventArgs) Handles txtCodEmpresa_NE.Validating
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then
            GFsAvisar("Debe ingresar codigo de empresa valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtCodEmpresa_NE.Text = "0"
            btnSalir.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtCodEmpresa_NE.Text) Then
            txtCodEmpresa_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

        Dim loFK As New Ec001empresas
        loFK.codEmpresa = liCodEmpresa
        If loFK.GetPK = sSinRegistros_ Then
            Dim loLookUp As New frmBc001empresas
            loLookUp.Tag = sELEGIR_
            GPCargar(loLookUp)
            If loLookUp.entidad IsNot Nothing Then
                txtCodEmpresa_NE.Text = CType(loLookUp.entidad, Ec001empresas).codEmpresa.ToString
            Else
                e.Cancel = True
                Exit Sub
            End If
            loLookUp = Nothing
        End If
        loFK.CerrarConexion()
        loFK = Nothing

        If GFsPuedeUsar("Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength), "Puede gestionar la Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)) <> sSi_ Then
            e.Cancel = True
            Exit Sub
        End If

        LPDespliegaDescripciones()
    End Sub

    Private Sub txtCodMercaderia_AN_Validating(sender As Object, e As CancelEventArgs) Handles txtCodMercaderia_AN.Validating
        If txtCodMercaderia_AN.Text.Trim.Length = 0 Then
            txtCodMercaderia_AN.Text = sTodas_
            e.Cancel = True
        Else
            If txtCodMercaderia_AN.Text <> sTodas_ Then
                Dim loFK As New Ed030mercsalida
                If txtCodMercaderia_AN.Text.Trim.ToUpper <> sTodas_ Then
                    loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loFK.codmercaderia = txtCodMercaderia_AN.Text
                    If loFK.GetPK = sSinRegistros_ Then
                        Dim loLookUp As New frmBd030mercsalida
                        loLookUp.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                        loLookUp.Tag = sELEGIR_
                        GPCargar(loLookUp)
                        If loLookUp.entidad IsNot Nothing Then
                            txtCodMercaderia_AN.Text = CType(loLookUp.entidad, Ed030mercsalida).codmercaderia.ToString
                        End If
                        e.Cancel = True
                        Exit Sub
                    End If
                    loFK.CerrarConexion()
                Else
                    txtCodUnidad_AN.Text = sTodas_
                    txtCodUnidad_AN.Enabled = False
                    txtCodUnidad_AN.Refresh()
                End If
            End If
        End If
        LPDespliegaDescripciones()
    End Sub
    Private Sub txtCodUnidad_AN_Validating(sender As Object, e As CancelEventArgs) Handles txtCodUnidad_AN.Validating
        If txtCodUnidad_AN.Text.Trim.Length = 0 Then
            txtCodUnidad_AN.Text = sTodas_
            e.Cancel = True
        Else
            If txtCodUnidad_AN.Text <> sTodas_ Then
                Dim loFK As New Eb110undalternativas
                Dim lsResultado As String
                loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loFK.tipo = sSalida_
                loFK.codmercaderia = txtCodMercaderia_AN.Text
                loFK.codunidad = txtCodUnidad_AN.Text
                lsResultado = loFK.GetPK
                loFK.CerrarConexion()
                If lsResultado = sSinRegistros_ Then
                    Dim loLookUp As New frmBb110undalternativas
                    loLookUp.Tag = sELEGIR_
                    loLookUp.codempresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loLookUp.tipo = sSalida_
                    loLookUp.codmercaderia = txtCodMercaderia_AN.Text
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
            End If
        End If
        LPDespliegaDescripciones()
        LPCargarDatos()
    End Sub

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ee020listaprecio
        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.codmercaderia = txtCodMercaderia_AN.Text
        loDatos.codunidad = txtCodUnidad_AN.Text
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFe020listaprecio
                moFormulario.Tag = CType(sender, Button).AccessibleName
                moFormulario.entidad = loDatos
                GPCargar(moFormulario)
                '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                '-->  esto será usado para realizar la localización del registro en el DataGridView
                msLocalizar = moFormulario.AccessibleName
                moFormulario = Nothing
            Case Else
                If DataGridView1.CurrentRow Is Nothing Then Exit Sub
                '---------------------------------------------------------------------------------------------
                Dim lsCodigo As String = DataGridView1.Item("vigencia", DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.codmercaderia = DataGridView1.Item("codmercaderia", DataGridView1.CurrentRow.Index).Value.ToString
                    loDatos.codunidad = DataGridView1.Item("codunidad", DataGridView1.CurrentRow.Index).Value.ToString
                    loDatos.vigencia = lsCodigo
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFe020listaprecio
                        moFormulario.AccessibleName = "Empresa: " & loDatos.codEmpresa & ", Mercaderia/Servicio: " & loDatos.codmercaderia & ", Unidad:" & loDatos.codunidad
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                        '-->  esto será usado para realizar la localización del registro en el DataGridView
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Mercaderia/servicio [" & loDatos.codmercaderia & "], Empresa [" & loDatos.codempresa & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        LPCargarDatos()
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsCodigo As String = DataGridView1.Item("vigencia", DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim lsCodMercaderia As String = DataGridView1.Item("codmercaderia", DataGridView1.CurrentRow.Index).Value.ToString
            If lsCodMercaderia.Trim.Length > 0 Then
                Dim lsCodUnidad As String = DataGridView1.Item("codunidad", DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodUnidad.Trim.Length > 0 Then
                    If psCodigo.Trim.Length > 0 Then
                        Dim loDatos As New Ee020listaprecio
                        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loDatos.codmercaderia = lsCodMercaderia
                        loDatos.codunidad = lsCodUnidad
                        loDatos.vigencia = psCodigo
                        Try
                            If loDatos.GetPK(sSi_) = sOk_ Then
                                lsResultado = loDatos.tableName & sSF_ & loDatos.hash_Pk
                            End If
                        Catch ex As Exception
                            GFsAvisar("LFsTablaHashPk", sError_, ex.Message)
                        End Try
                    End If
                End If
            End If
        End If
        Return lsResultado
    End Function

    Private Sub ExportarExcel_Click(sender As Object, e As EventArgs)
        If GFsPuedeUsar(Me.Name & ":Exportar->Excel", "Permite exportar el contenido de " & Me.Name & " a un archivo Excel") = sSi_ Then
            GPExportarGridToExcel(DataGridView1, Me.Name)
        End If
    End Sub

    Private Sub ExportarTexto_Click(sender As Object, e As EventArgs)
        If GFsPuedeUsar(Me.Name & ":Exportar->Texto delimitado", "Permite exportar el contenido de " & Me.Name & " a un archivo de texto delimitado") = sSi_ Then
            GPExportarGridToTexto(DataGridView1, Me.Name)
        End If
    End Sub

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtCodEmpresa_NE.Focus()
    End Sub

    Friend Sub LPSinRegistro_AbrirForm()
        If miCantidad = 0 Then
            If mbabrirform = False Then
                mbabrirform = True
                SendKeys.Send("%(a)")
            End If
        End If
    End Sub
End Class