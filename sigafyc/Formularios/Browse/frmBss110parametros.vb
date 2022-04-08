Imports System.ComponentModel

Public Class frmBss110parametros
    Private moFormulario As frmFss110parametros
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar As String
    Private msSS010_codigo As String
    Private msTipo As String
    Private msPrefijo As String
    Private Shared mbabrirform As Boolean = False

    Public Property s010_codigo As String
        Get
            Return msSS010_codigo
        End Get
        Set(value As String)
            msSS010_codigo = value
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
        msSS010_codigo = My.Application.Info.AssemblyName.ToUpper

        LPSetDoubleBuffered(DataGridView1)
        LPInicializaMaxLength()
        LPInicializaParametros()

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
        mbabrirform = False
        LPDespliegaDescripciones()
    End Sub

    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub

    Private Sub LPCargarDatos()
        Dim lsSQL As String
        Dim loDatos As New Ess110parametros
        Dim loDataSet As DataSet
        Dim lsWhere As String = "ss010_codigo = @ss010_codigo and tipo = @tipo"
        Dim lsCampos As String = "prefijo, clave, case when right(clave,1) = '_' then '***ENCRIPTADO***' else valor end as valor, tipo"
        Dim lsCamposDesplegar As String = "prefijo, clave, valor, tipo"
        Dim lsConcatFiltro As String = "prefijo, clave, valor"
        Dim lsCamposOcultos As String = "tipo"
        If cmbTipo.Text = sGeneral_ Then
            lsCamposOcultos = "prefijo, tipo"
        End If
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If
        msSS010_codigo = msSS010_codigo.ToUpper
        loDatos.ss010_codigo = msSS010_codigo
        loDatos.tipo = cmbTipo.Text
        lsSQL = loDatos.GenerarSQL(lsCampos, lsFiltro, lsWhere)
        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName
        Dim lsCampo() As String = lsCamposDesplegar.Split(","c)
        For i As Integer = 0 To lsCampo.Length - 1
            DataGridView1.Columns(lsCampo(i).Trim).Visible = True
        Next
        Dim lsCampoOculto() As String = lsCamposOcultos.Split(","c)
        For i As Integer = 0 To lsCampoOculto.Length - 1
            DataGridView1.Columns(lsCampoOculto(i).Trim).Visible = False
        Next
        If cmbTipo.Text = sGeneral_ Then
            DataGridView1.Sort(DataGridView1.Columns("clave"), ListSortDirection.Ascending)
        Else
            DataGridView1.Sort(DataGridView1.Columns("prefijo"), ListSortDirection.Ascending)
        End If
        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDatos.CerrarConexion()
        LPSinRegistro_AbrirForm()
        LPHabilitaControles()
    End Sub
    Private Sub LPInicializaMaxLength()
        cmbTipo.MaxLength = 15
    End Sub

    Private Sub LPDespliegaDescripciones()
    End Sub

    Private Sub LPLocalizaRegistro(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub

        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("clave").Value.ToString = psCodigo Then
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

    Private Sub cmbTipo_Validating(sender As Object, e As CancelEventArgs) Handles cmbTipo.Validating
        LPDespliegaDescripciones()
        LPCargarDatos()
    End Sub

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        If cmbTipo.Text.Trim.Length = 0 Then Exit Sub

        Dim loDatos As New Ess110parametros
        loDatos.ss010_codigo = msSS010_codigo
        loDatos.tipo = cmbTipo.Text
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFss110parametros
                moFormulario.Tag = CType(sender, Button).AccessibleName
                Select Case cmbTipo.Text
                    Case sGeneral_
                        loDatos.prefijo = sGeneral_
                    Case sLocal_
                        loDatos.prefijo = SesionActiva.equipo
                    Case sUsuario_
                        loDatos.prefijo = SesionActiva.usuario
                    Case sFecha_
                        loDatos.prefijo = Today.ToString(sFormatoFecha1_)
                    Case sModulo_
                        Dim lsModulos() As String = SesionActiva.modulos.Split(sSF_)
                        loDatos.prefijo = lsModulos(0)
                End Select
                moFormulario.entidad = loDatos
                GPCargar(moFormulario)
                msLocalizar = moFormulario.AccessibleName
                moFormulario = Nothing
            Case Else
                If DataGridView1.CurrentRow Is Nothing Then Exit Sub
                If cmbTipo.Text.Trim.Length = 0 Then Exit Sub
                '---------------------------------------------------------------------------------------------

                msTipo = cmbTipo.Text
                msPrefijo = DataGridView1.Item("prefijo", DataGridView1.CurrentRow.Index).Value.ToString
                Dim lsCodigo As String = DataGridView1.Item("clave", DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub
                '---------------------------------------------------------------------------------------------

                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.tipo = msTipo
                    loDatos.prefijo = msPrefijo
                    loDatos.clave = lsCodigo
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFss110parametros
                        moFormulario.AccessibleName = "sistema: " & loDatos.ss010_codigo & "/tipo: " & loDatos.tipo & "/prefijo:" & loDatos.prefijo & "/clave:" & loDatos.clave
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para la clave [" & loDatos.clave & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
        LPCargarDatos()
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        If cmbTipo.Text.Trim.Length = 0 Then Exit Sub

        msTipo = cmbTipo.Text
        msPrefijo = DataGridView1.Item("prefijo", DataGridView1.CurrentRow.Index).Value.ToString
        Dim lsCodigo As String = DataGridView1.Item("clave", DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        If cmbTipo.Text.Trim.Length > 0 Then
            If psCodigo.Trim.Length > 0 Then
                Dim loDatos As New Ess110parametros
                loDatos.ss010_codigo = msSS010_codigo
                loDatos.tipo = cmbTipo.Text
                loDatos.prefijo = msPrefijo
                loDatos.clave = psCodigo
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

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbTipo.Focus()
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

    Private Sub LPInicializaParametros()
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String
        Dim lsValor As String
        Dim lsCodigo As String

        lsClave = "ss110parametros.tipo"
        lsValor = sGeneral_ & sSF_ & sLocal_ & sSF_ & sUsuario_ & sSF_ & sFecha_ & sSF_ & sModulo_
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipo.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipo.Items.Add(lsValor)
        Next
    End Sub

End Class