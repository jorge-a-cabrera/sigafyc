Public Class frmBc011timbpropios
    Private moFormulario As frmFc011timbpropios
    Private msLocalizar As String = ""
    Public Property numTimbrado As String
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

        btnAgregar.AccessibleName = sAGREGAR_
        btnModificar.AccessibleName = sMODIFICAR_
        btnBorrar.AccessibleName = sBORRAR_
        btnConsultar.AccessibleName = sCONSULTAR_

        AddHandler txtBuscar.TextChanged, AddressOf BuscarClave
        AddHandler btnAgregar.Click, AddressOf Botones_Click
        AddHandler btnModificar.Click, AddressOf Botones_Click
        AddHandler btnBorrar.Click, AddressOf Botones_Click
        AddHandler btnConsultar.Click, AddressOf Botones_Click
        LPCargarDatos()
    End Sub

    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub

    Private Sub LPCargarDatos()
        Dim lsSQL As String
        Dim liCodEmpresa As Integer = 0
        Dim loDatos As New Ec011timbpropios
        Dim loEc010 As New Ec010timbpropios
        loEc010.numTimbrado = numTimbrado
        If loEc010.GetPK = sOk_ Then
            liCodEmpresa = loEc010.codEmpresa
        End If
        loEc010.CerrarConexion()

        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "numtimbrado, sucursal, prefijo, desde, hasta"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If
        loDatos.numTimbrado = numTimbrado
        lsSQL = GFsGeneraSQL("frmBc011timbpropios")
        lsSQL = lsSQL.Replace("&numtimbrado", numTimbrado)
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName
        DataGridView1.Refresh()

        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDatos.CerrarConexion()
        LPSinRegistro_AbrirForm()
        LPHabilitaControles()
    End Sub

    Private Sub LPLocalizaRegistro(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub

        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("prefijo").Value.ToString = psCodigo Then
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

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ec011timbpropios
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                Dim loC010 As New Ec010timbpropios
                loC010.numTimbrado = numTimbrado
                If loC010.GetPK <> sOk_ Then
                    Exit Sub
                End If
                moFormulario = New frmFc011timbpropios
                moFormulario.Tag = CType(sender, Button).AccessibleName
                moFormulario.entidad = loC010
                GPCargar(moFormulario)
                msLocalizar = moFormulario.AccessibleName
                moFormulario = Nothing
                loC010.CerrarConexion()
            Case Else
                If DataGridView1.CurrentRow Is Nothing Then Exit Sub
                '---------------------------------------------------------------------------------------------
                Dim lsNumTimbrado As String = DataGridView1.Item("numtimbrado", DataGridView1.CurrentRow.Index).Value.ToString
                Dim liCodSucursal As Integer = Integer.Parse(DataGridView1.Item("prefijo", DataGridView1.CurrentRow.Index).Value.ToString.Substring(0, 3))
                Dim lsCodigo As String = DataGridView1.Item("prefijo", DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.numTimbrado = lsNumTimbrado
                    loDatos.codSucursal = liCodSucursal
                    loDatos.prefijo = lsCodigo
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFc011timbpropios
                        moFormulario.AccessibleName = "codigo: " & loDatos.numTimbrado
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para el Numero Timbrado [" & loDatos.numTimbrado & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
        LPCargarDatos()
        DataGridView1.Focus()
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsCodigo As String = DataGridView1.Item("numtimbrado", DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        If psCodigo.Trim.Length > 0 Then
            Dim loDatos As New Ec011timbpropios
            Dim lsNumTimbrado As String = DataGridView1.Item("numtimbrado", DataGridView1.CurrentRow.Index).Value.ToString
            Dim liCodSucursal As Integer = Integer.Parse(DataGridView1.Item("prefijo", DataGridView1.CurrentRow.Index).Value.ToString.Substring(0, 3))
            loDatos.numTimbrado = lsNumTimbrado
            loDatos.codSucursal = liCodSucursal
            loDatos.prefijo = psCodigo
            Try
                If loDatos.GetPK(sSi_) = sOk_ Then
                    lsResultado = loDatos.tableName & sSF_ & loDatos.hash_Pk
                End If
            Catch ex As Exception
                GFsAvisar("LFsTablaHashPk", sError_, ex.Message)
            End Try
        End If

        Return lsResultado
    End Function

End Class