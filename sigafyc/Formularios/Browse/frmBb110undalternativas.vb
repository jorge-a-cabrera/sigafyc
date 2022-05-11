Imports System.ComponentModel

Public Class frmBb110undalternativas
    Private moFormulario As frmFb110undalternativas
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer
    Private msTipo As String
    Private msCodMercaderia As String
    Private Shared mbabrirform As Boolean = False

    Public Property codempresa As Integer
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

    Public Property codmercaderia As String
        Get
            Return msCodMercaderia
        End Get
        Set(value As String)
            msCodMercaderia = value
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
        LPInicializaParametros()
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
        AddHandler DataGridView1.KeyDown, AddressOf DataGrid_KeyDown
        AddHandler DataGridView1.CellContentDoubleClick, AddressOf DataGrid_DoubleClick


        If Me.Tag.ToString = sELEGIR_ Then
            If Me.Name <> "frmBa010monedas" Then
                Dim lofrmBase As New frmBa010monedas
                txtBuscar.Width = lofrmBase.txtBuscar.Width
                DataGridView1.Location = New Point(lofrmBase.DataGridView1.Location.X, lofrmBase.DataGridView1.Location.Y + txtBuscar.Location.Y + 5)
                DataGridView1.Height = lofrmBase.DataGridView1.Height - (txtCodEmpresa_NE.Height + cmbTipo.Height + txtCodMercaderia_AN.Height + txtBuscar.Height) - 10
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
        mbabrirform = False
        If miCodEmpresa > 0 Then
            txtCodEmpresa_NE.Text = miCodEmpresa.ToString
            txtCodEmpresa_NE.Enabled = False
            If msTipo.Trim.Length > 0 Then
                cmbTipo.Text = msTipo
                cmbTipo.Enabled = False
                If msCodMercaderia.Trim.Length > 0 Then
                    txtCodMercaderia_AN.Text = msCodMercaderia
                    txtCodMercaderia_AN.Enabled = False
                End If
            End If
        End If
        LPCargarDatos()
        LPDespliegaDescripciones()
    End Sub

    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub

    Private Sub LPCargarDatos()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        If cmbTipo.Text.Trim.Length = 0 Then Exit Sub
        If txtCodMercaderia_AN.Text.Trim.Length = 0 Then Exit Sub

        Dim lsSQL As String = GFsGeneraSQL("frmBb110undalternativas")
        Dim loDatos As New Eb110undalternativas
        Dim loDataSet As DataSet
        Dim lsJoinMercaderia As String = ""
        Select Case cmbTipo.Text
            Case sEntrada_
                lsJoinMercaderia = GFsGeneraSQL("d020mercentrada")
            Case sSalida_
                lsJoinMercaderia = GFsGeneraSQL("d030mercsalida")
        End Select
        Dim lsCamposConcat As String = "codigo, nombre, cantidad, undbasica, estado"
        Dim lsCamposOcultos As String = "codempresa, tipo, codmercaderia"
        Dim lsConcatFiltro As String = lsCamposConcat

        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If

        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        lsSQL = lsSQL.Replace("@innerjoin1", lsJoinMercaderia)
        lsSQL = lsSQL.Replace("&codempresa", Integer.Parse(txtCodEmpresa_NE.Text).ToString)
        lsSQL = lsSQL.Replace("&tipo", cmbTipo.Text)
        lsSQL = lsSQL.Replace("&codmercaderia", txtCodMercaderia_AN.Text)

        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName
        Dim lsCampoOculto() As String = lsCamposOcultos.Split(","c)
        For i As Integer = 0 To lsCampoOculto.Length - 1
            DataGridView1.Columns(lsCampoOculto(i).Trim).Visible = False
        Next

        DataGridView1.Sort(DataGridView1.Columns("nombre"), ListSortDirection.Ascending)
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
        txtCodMercaderia_AN.MaxLength = 20
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

        lblNombreMercaderia.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If txtCodMercaderia_AN.Text.Trim.Length > 0 Then
                Select Case cmbTipo.Text
                    Case sEntrada_
                        Dim loFK As New Ed020mercentrada
                        loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loFK.codmercaderia = txtCodMercaderia_AN.Text
                        If loFK.GetPK = sOk_ Then
                            lblNombreMercaderia.Text = loFK.nombre
                        End If
                        loFK.CerrarConexion()
                    Case sSalida_
                        Dim loFK As New Ed030mercsalida
                        loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                        loFK.codmercaderia = txtCodMercaderia_AN.Text
                        If loFK.GetPK = sOk_ Then
                            lblNombreMercaderia.Text = loFK.nombre
                        End If
                        loFK.CerrarConexion()
                End Select
            End If
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
            DataGridView1.CurrentCell = DataGridView1.Rows(liIndex).Cells(0)
        End If
    End Sub

    Private Sub txtCodEmpresa_NE_Validating(sender As Object, e As CancelEventArgs) Handles txtCodEmpresa_NE.Validating
        Dim loFK As New Ec001empresas
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
        Dim loFK As New Ed030mercsalida
        If txtCodMercaderia_AN.Text.Trim.Length = 0 Then
            GFsAvisar("Debe ingresar codigo de mercaderia/servicio valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtCodMercaderia_AN.Text = "0"
            btnSalir.Focus()
            Exit Sub
        End If

        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text)

        Select Case cmbTipo.Text
            Case sEntrada_
                loFK.codempresa = liCodEmpresa
                loFK.codmercaderia = txtCodMercaderia_AN.Text
                If loFK.GetPK = sSinRegistros_ Then
                    Dim loLookUp As New frmBd020mercentrada
                    loLookUp.codEmpresa = liCodEmpresa
                    loLookUp.Tag = sELEGIR_
                    GPCargar(loLookUp)
                    If loLookUp.entidad IsNot Nothing Then
                        txtCodMercaderia_AN.Text = CType(loLookUp.entidad, Ed020mercentrada).codmercaderia.ToString
                    Else
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
                loFK.CerrarConexion()
            Case sSalida_
                loFK.codempresa = liCodEmpresa
                loFK.codmercaderia = txtCodMercaderia_AN.Text
                If loFK.GetPK = sSinRegistros_ Then
                    Dim loLookUp As New frmBd030mercsalida
                    loLookUp.codEmpresa = liCodEmpresa
                    loLookUp.Tag = sELEGIR_
                    GPCargar(loLookUp)
                    If loLookUp.entidad IsNot Nothing Then
                        txtCodMercaderia_AN.Text = CType(loLookUp.entidad, Ed030mercsalida).codmercaderia.ToString
                    Else
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
                loFK.CerrarConexion()
        End Select
        LPDespliegaDescripciones()
        LPCargarDatos()
    End Sub

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Eb110undalternativas
        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.tipo = cmbTipo.Text
        loDatos.codmercaderia = txtCodMercaderia_AN.Text
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFb110undalternativas
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
                Try
                    loDatos.codunidad = lsCodigo
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFb110undalternativas
                        moFormulario.AccessibleName = "Empresa: " & loDatos.codEmpresa.ToString & ", Tipo: " & cmbTipo.Text & ", Merc/Servicio: " & loDatos.codmercaderia
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                        '-->  esto será usado para realizar la localización del registro en el DataGridView
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Codigo [" & loDatos.codunidad & "], Mercaderia [" & loDatos.codmercaderia & "], Tipo [" & cmbTipo.Text & "], Empresa [" & loDatos.codEmpresa & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
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
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If psCodigo.Trim.Length > 0 Then
                Dim loPK As New Eb110undalternativas
                loPK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loPK.tipo = cmbTipo.Text
                loPK.codmercaderia = txtCodMercaderia_AN.Text
                loPK.codunidad = psCodigo
                Try
                    If loPK.GetPK(sSi_) = sOk_ Then
                        lsResultado = loPK.tableName & sSF_ & loPK.hash_Pk
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
        txtCodMercaderia_AN.Focus()
    End Sub

    Friend Sub LPSinRegistro_AbrirForm()
        If miCantidad = 0 Then
            If mbabrirform = False Then
                mbabrirform = True
                SendKeys.Send("%(a)")
            End If
        End If
    End Sub

    Private Sub LPInicializaParametros()
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String
        Dim lsValor As String
        Dim lsCodigo As String

        lsClave = "a060clasmerc.tipo"
        lsValor = sEntrada_ & sSF_ & sSalida_
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