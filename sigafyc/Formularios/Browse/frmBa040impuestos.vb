Public Class frmBa040impuestos
    Private moFormulario As frmFa040impuestos
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private msLocalizar As String = ""
    Private msCodigo1 As String = "operacion"
    Private msCodigo2 As String = "codimpuesto"

    Private Sub frmBa040impuestos_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        Dim datos As New Ea040impuestos
        Dim loDataSet As DataSet = Nothing
        Dim lsWhere As String = ""
        Dim lsCampos As String = "operacion, codimpuesto, nombre, porcbaseimpo, tipovalor, codmoneda, valor"
        Dim lsConcatFiltro As String = lsCampos
        Dim lsFiltro As String = sFiltroSentencia_
        If entidad IsNot Nothing Then
            datos.operacion = CType(entidad, Ea040impuestos).operacion
            lsWhere = "operacion = " & Chr(39) & datos.operacion & Chr(39)
        End If
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If
        lsSQL = datos.GenerarSQL(lsCampos, lsFiltro, lsWhere)
        Try
            loDataSet = datos.RecuperarTabla(lsSQL)
        Catch ex As Exception
            GFsAvisar(Me.Name & ": LPCargarDatos", sMENSAJE_, ex.Message)
        End Try
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = datos.tableName
        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = datos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDataSet = Nothing
        datos.CerrarConexion()
        datos = Nothing
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
            If row.Cells(msCodigo2).Value.ToString = psCodigo Then
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
        Dim loDatos As New Ea040impuestos
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFa040impuestos
                moFormulario.Tag = CType(sender, Button).AccessibleName
                moFormulario.entidad = loDatos
                GPCargar(moFormulario)
                msLocalizar = moFormulario.AccessibleName
                moFormulario = Nothing
            Case Else
                If DataGridView1.CurrentRow Is Nothing Then Exit Sub
                Dim lsOperacion As String = DataGridView1.Item(msCodigo1, DataGridView1.CurrentRow.Index).Value.ToString
                If lsOperacion.Trim.Length = 0 Then Exit Sub
                '---------------------------------------------------------------------------------------------
                Dim lsCodigo As String = DataGridView1.Item(msCodigo2, DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.operacion = lsOperacion
                    loDatos.codImpuesto = lsCodigo
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFa040impuestos
                        moFormulario.AccessibleName = "Operacion: " & loDatos.operacion & ", Cod. Impuesto:" & loDatos.codImpuesto
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para la Operacion [" & loDatos.operacion & "], Cod. Impuesto:[" & loDatos.codImpuesto & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
        LPCargarDatos()
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsTipoDocumento As String = DataGridView1.Item(msCodigo1, DataGridView1.CurrentRow.Index).Value.ToString
        If lsTipoDocumento.Trim.Length = 0 Then Exit Sub
        Dim lsCodigo As String = DataGridView1.Item(msCodigo2, DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        Dim lsOperacion As String = DataGridView1.Item(msCodigo1, DataGridView1.CurrentRow.Index).Value.ToString
        If psCodigo.Trim.Length > 0 Then
            Dim loDatos As New Ea040impuestos
            loDatos.operacion = lsOperacion
            loDatos.codImpuesto = psCodigo
            Try
                If loDatos.GetPK(sSi_) = sOk_ Then
                    lsResultado = loDatos.tableName & sSF_ & loDatos.hash_Pk
                End If
            Catch ex As Exception
                GFsAvisar(Me.Name & ": LFsTablaHashPk", sError_, ex.Message)
            End Try
        End If

        Return lsResultado
    End Function
End Class