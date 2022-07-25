Imports System.ComponentModel
Public Class frmBa060clasmerc
    Private moFormulario As frmFa060clasmerc
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer
    Private msTipo As String = ""
    Private Shared mbabrirform As Boolean = False
    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property
    Public Property tipo As String
        Get
            Return msTipo
        End Get
        Set(value As String)
            msTipo = value
        End Set
    End Property

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        AddHandler cmbTipo.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler cmbTipo.KeyDown, AddressOf ManejoEvento_KeyDown
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
                cmbTipo.Text = msTipo
            End If
        End If
        lblNombreEmpresa.Text = ""
        If miCodEmpresa > 0 Then
            txtCodEmpresa_NE.Text = miCodEmpresa.ToString
            txtCodEmpresa_NE.Enabled = False
            If msTipo.Trim.Length > 0 Then
                cmbTipo.Enabled = False
                LPCargarDatos()
                LPDespliegaDescripciones()
            End If
        End If
    End Sub
    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
        LPDespliegaDescripciones()
    End Sub
    Private Sub LPCargarDatos()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        If cmbTipo.Text.Trim.Length = 0 Then Exit Sub

        Dim lsSQL As String
        Dim loDatos As New Ea060clasmerc
        Dim loDataSet As DataSet
        Dim lsWhere As String = "codempresa = &codempresa and tipo = '&tipo' and nombre <> " & Chr(39) & sRESERVADO_ & Chr(39)
        lsWhere = lsWhere.Replace("&codempresa", Integer.Parse(txtCodEmpresa_NE.Text.ToString).ToString)
        lsWhere = lsWhere.Replace("&tipo", cmbTipo.Text)
        Dim lsCampos As String = ""
        Dim lsCamposConcat As String = ""
        msTipo = cmbTipo.Text
        If msTipo = sEntrada_ Then
            lsCampos = "codclasificacion as codigo, abreviado, nombre, estado"
            lsCamposConcat = "codclasificacion, abreviado, nombre, estado"
        ElseIf msTipo = sSalida_ Then
            lsCampos = "codclasificacion as codigo, abreviado, nombre, listaprecio"
            lsCamposConcat = "codclasificacion, abreviado, nombre, listaprecio, estado"
        End If
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If
        lsSQL = loDatos.GenerarSQL(lsCampos, lsFiltro, lsWhere)
        loDatos.tipo = cmbTipo.Text
        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName

        'DataGridView1.Columns.Item("codempresa").Visible = False
        DataGridView1.Sort(DataGridView1.Columns("codigo"), ListSortDirection.Ascending)
        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDatos.CerrarConexion()

        LPSinRegistro_AbrirForm()
        LPHabilitaControles()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        cmbTipo.MaxLength = 15
    End Sub
    Private Sub txtCodEmpresa_NE_Validating(sender As Object, e As CancelEventArgs) Handles txtCodEmpresa_NE.Validating
        Dim loFK As New Ec001empresas
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then
            GFsAvisar("Debe ingresar codigo de empresa valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtCodEmpresa_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        If Not IsNumeric(txtCodEmpresa_NE.Text) Then
            txtCodEmpresa_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

        loFK.codEmpresa = liCodEmpresa
        If loFK.GetPK = sSinRegistros_ Then
            Dim loLookUp As New frmBc001empresas
            loLookUp.Tag = sELEGIR_
            GPCargar(loLookUp)
            If loLookUp.entidad IsNot Nothing Then
                txtCodEmpresa_NE.Text = CType(loLookUp.entidad, Ec001empresas).codEmpresa.ToString
                e.Cancel = True
                Exit Sub
            End If
        End If
        loFK.CerrarConexion()

        If GFsPuedeUsar("Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength), "Puede gestionar la Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)) <> sSi_ Then
            e.Cancel = True
            Exit Sub
        End If
        LPDespliegaDescripciones()
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
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)
        End If
    End Sub
    Private Sub LPLocalizaRegistro(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub

        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("codigo").Value.ToString = psCodigo Then
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
            DataGridView1.CurrentCell = DataGridView1.Rows(liIndex).Cells("codigo")
        End If
    End Sub
    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ea060clasmerc
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.tipo = cmbTipo.Text
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFa060clasmerc
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
                Dim lsCodigo As String = DataGridView1.Item("codigo", DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                If CType(sender, Button).AccessibleName = sBORRAR_ Then
                    Dim liCantidad As Integer = LFiCantidadDetalle(cmbTipo.Text, Integer.Parse(lsCodigo))
                    If liCantidad > 0 Then
                        GFsAvisar("Tipo[" & cmbTipo.Text & "], Clasificacion[" & lsCodigo & "] tiene [" & liCantidad.ToString & "] registros asociados", sMENSAJE_, "Por lo cual no lo podrá eliminar.")
                        Exit Sub
                    End If
                End If

                Try
                    loDatos.codclasificacion = Integer.Parse(lsCodigo)
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFa060clasmerc
                        If loDatos.tipo = sEntrada_ Then
                            moFormulario.AccessibleName = "Tipo: ENTRADA DE MERCADERIAS"
                        Else
                            moFormulario.AccessibleName = "Tipo: SALIDA DE MERCADERIAS"
                        End If
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                        '-->  esto será usado para realizar la localización del registro en el DataGridView
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Tipo [" & loDatos.tipo & "], Codigo [" & loDatos.codclasificacion & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        LPCargarDatos()
    End Sub
    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsCodigo As String = DataGridView1.Item("codigo", DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub
    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        If cmbTipo.Text.Trim.Length > 0 Then
            If psCodigo.Trim.Length > 0 Then
                Dim loDatos As New Ea060clasmerc
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.tipo = cmbTipo.Text
                loDatos.codclasificacion = Integer.Parse(psCodigo)
                Try
                    If loDatos.GetPK(sSi_) = sOk_ Then
                        lsResultado = loDatos.tableName & sSF_ & loDatos.hash_Pk
                    End If
                Catch ex As Exception
                    GFsAvisar("LFsTablaHashPk", sError_, ex.Message)
                End Try
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
    Friend Sub LPSinRegistro_AbrirForm()
        If miCantidad = 0 Then
            If mbabrirform = False Then
                mbabrirform = True
                SendKeys.Send("%(a)")
            End If
        End If
    End Sub
    Private Function LFiCantidadDetalle(ByVal psTipo As String, ByVal piCodigo As Integer) As Integer
        Dim liCantidad As Integer = 0
        Select Case psTipo
            Case sEntrada_
                Dim loDatos As New Ed020mercentrada
                Dim lsSQL As String = GFsGeneraSQL("Ed020mercentrada_conteo2")
                lsSQL = lsSQL.Replace("&codigo", piCodigo.ToString)
                loDatos.CrearComando(lsSQL)
                liCantidad = loDatos.EjecutarEscalar
                loDatos.CerrarConexion()
            Case sSalida_
                Dim loDatos As New Ed030mercsalida
                Dim lsSQL As String = GFsGeneraSQL("Ed030mercsalida_conteo")
                lsSQL = lsSQL.Replace("&codigo", piCodigo.ToString)
                loDatos.CrearComando(lsSQL)
                liCantidad = loDatos.EjecutarEscalar
                loDatos.CerrarConexion()
        End Select
        Return liCantidad
    End Function
    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        LPDespliegaDescripciones()
        mbabrirform = False
        LPCargarDatos()
    End Sub
End Class