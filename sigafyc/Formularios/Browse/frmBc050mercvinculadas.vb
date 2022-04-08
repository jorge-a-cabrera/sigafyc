﻿Imports System.ComponentModel

Public Class frmBc050mercvinculadas
    Private moFormulario As frmFc050mercvinculadas
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer
    Private msCodSalida As String
    Private msTipo As String
    Private Shared mbabrirform As Boolean = False

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property codsalida As String
        Get
            Return mscodsalida
        End Get
        Set(value As String)
            mscodsalida = value
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
            If msCodSalida.Trim.Length > 0 Then
                txtCodSalida_AN.Text = msCodSalida
                txtCodSalida_AN.Enabled = False
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
        If txtCodSalida_AN.Text.Trim.Length = 0 Then Exit Sub

        Dim lsSQL As String = GFsGeneraSQL("frmBc050mercvinculadas")
        Dim loDatos As New Ec050mercvinculadas
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "codigo, nombre, nomunidad, estado"
        Dim lsCamposOcultos As String = "codsalida, nomsalida, codunidad"
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
        lsSQL = lsSQL.Replace("&tipo", sEntrada_)
        lsSQL = lsSQL.Replace("&codsalida", txtCodSalida_AN.Text)

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
        txtCodSalida_AN.MaxLength = 20
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
            If txtCodSalida_AN.Text.Trim.Length > 0 Then
                Dim loFK As New Ed030mercsalida
                loFK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loFK.codmercaderia = txtCodSalida_AN.Text
                If loFK.GetPK = sOk_ Then
                    lblNombreMercaderia.Text = loFK.nombre
                End If
                loFK.CerrarConexion()
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

    Private Sub txtCodSalida_AN_Validating(sender As Object, e As CancelEventArgs) Handles txtCodSalida_AN.Validating
        Dim loFK As New Ed030mercsalida
        If txtCodSalida_AN.Text.Trim.Length = 0 Then
            GFsAvisar("Debe ingresar codigo de mercaderia/servicio valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtCodSalida_AN.Text = "0"
            btnSalir.Focus()
            Exit Sub
        End If

        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text)

        loFK.codempresa = liCodEmpresa
        loFK.codmercaderia = txtCodSalida_AN.Text
        If loFK.GetPK = sSinRegistros_ Then
            Dim loLookUp As New frmBd030mercsalida
            loLookUp.codEmpresa = liCodEmpresa
            loLookUp.Tag = sELEGIR_
            GPCargar(loLookUp)
            If loLookUp.entidad IsNot Nothing Then
                txtCodSalida_AN.Text = CType(loLookUp.entidad, Ed030mercsalida).codmercaderia.ToString
            Else
                e.Cancel = True
                Exit Sub
            End If
            loLookUp = Nothing
        End If
        loFK.CerrarConexion()
        loFK = Nothing
        LPDespliegaDescripciones()
        LPCargarDatos()
    End Sub

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ec050mercvinculadas
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.codsalida = txtCodSalida_AN.Text
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFc050mercvinculadas
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

                Dim lsCodUnidad As String = DataGridView1.Item("codunidad", DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodUnidad.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.codentrada = lsCodigo
                    loDatos.codunidad = lsCodUnidad
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFc050mercvinculadas
                        moFormulario.AccessibleName = "Empresa: " & loDatos.codempresa.ToString & ", Merc/Servicio: " & loDatos.codsalida
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                        '-->  esto será usado para realizar la localización del registro en el DataGridView
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Codigo [" & loDatos.codsalida & "], Empresa [" & loDatos.codempresa & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
        LPCargarDatos()
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsCodigo As String = DataGridView1.Item("codigo", DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsCodUnidad As String = DataGridView1.Item("codunidad", DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodUnidad.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsCodUnidad As String = DataGridView1.Item("codunidad", DataGridView1.CurrentRow.Index).Value.ToString

        Dim lsResultado As String = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If psCodigo.Trim.Length > 0 Then
                Dim loPK As New Ec050mercvinculadas
                loPK.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loPK.codsalida = txtCodSalida_AN.Text
                loPK.codentrada = psCodigo
                loPK.codunidad = lsCodUnidad
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


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim loRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim loColEquivale As DataGridViewColumn = DataGridView1.Columns.Item("equivale")

        If e.ColumnIndex = loColEquivale.Index Then
            If Decimal.Parse(e.Value.ToString) = 0 Then
                e.Value = ""
            Else
                e.Value = CDec(e.Value).ToString(sFormatF_)
            End If
            e.FormattingApplied = True
        End If
    End Sub

End Class