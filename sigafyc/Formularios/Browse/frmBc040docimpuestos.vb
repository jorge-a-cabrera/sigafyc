Imports System.ComponentModel

Public Class frmBc040docimpuestos
    Private moFormulario As frmFc040docimpuestos
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar As String = ""
    Private Shared mbabrirform As Boolean = False

    Private Sub Browse_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        AddHandler txtCodDocumento_NE.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtCodDocumento_NE.KeyDown, AddressOf ManejoEvento_KeyDown
        AddHandler DataGridView1.KeyDown, AddressOf DataGrid_KeyDown
        AddHandler DataGridView1.CellContentDoubleClick, AddressOf DataGrid_DoubleClick

        DataGridView1.ContextMenuStrip = mnuExportarExcel

        AddHandler MenuItem_ExportarExcel.Click, AddressOf ExportarExcel_Click
        AddHandler MenuItem_ExportarTexto.Click, AddressOf ExportarTexto_Click

        lblNomEmpresa.Text = ""
        lblNomDocumento.Text = ""
        mbabrirform = False
    End Sub

    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub

    Private Sub LPCargarDatos()
        Dim lsSQL As String
        Dim loDatos As New Ec040docimpuestos
        Dim loDataSet As DataSet
        Dim lsWhere As String = "codempresa = @codempresa and coddocumento = @coddocumento"
        Dim lsCampos As String = "operacion, codimpuesto, aplicacion, estado"
        Dim lsCamposConcat As String = "operacion, codimpuesto, aplicacion"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If
        lsSQL = loDatos.GenerarSQL(lsCampos, lsFiltro, lsWhere)
        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
        loDatos.codDocumento = Integer.Parse(txtCodDocumento_NE.Text)
        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName
        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDatos.CerrarConexion()

        LPSinRegistro_AbrirForm()
        LPHabilitaControles()
    End Sub

    Private Sub Formulario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtCodEmpresa_NE.Focus()
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


        lblNomDocumento.Text = ""
        If txtCodDocumento_NE.Text.Trim.Length > 0 Then
            Dim loFK1 As New Ec020documentos
            loFK1.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loFK1.codDocumento = Integer.Parse(txtCodDocumento_NE.Text)
            If loFK1.GetPK = sOk_ Then
                lblNomDocumento.Text = loFK1.nombre
            End If
            loFK1.CerrarConexion()
            Dim liCodDocumento As Integer = Integer.Parse(txtCodDocumento_NE.Text.ToString)
            txtCodDocumento_NE.Text = liCodDocumento.ToString(sFormatD_ & txtCodDocumento_NE.MaxLength)
        End If
    End Sub

    Private Sub LPLocalizaRegistro(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub

        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("codimpuesto").Value.ToString = psCodigo Then
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
            GFsAvisar("Debe ingresar codigo EMPRESA valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            btnSalir.Focus()
            Exit Sub
        End If

        Dim loFK As New Ec001empresas
        loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
        If loFK.GetPK = sSinRegistros_ Then
            Dim loLookUp As New frmBc001empresas
            loLookUp.Tag = sELEGIR_
            GPCargar(loLookUp)
            If loLookUp.entidad IsNot Nothing Then
                txtCodEmpresa_NE.Text = CType(loLookUp.entidad, Ec001empresas).codEmpresa.ToString
            End If
            e.Cancel = True
        End If
        loFK.CerrarConexion()
        LPDespliegaDescripciones()
    End Sub

    Private Sub txtCodDocumento_NE_Validating(sender As Object, e As CancelEventArgs) Handles txtCodDocumento_NE.Validating
        Dim loFK As New Ec020documentos
        If txtCodDocumento_NE.Text.Trim.Length = 0 Then
            GFsAvisar("Debe ingresar codigo DOCUMENTO valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            btnSalir.Focus()
            Exit Sub
        End If
        loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
        loFK.codDocumento = Integer.Parse(txtCodDocumento_NE.Text)
        If loFK.GetPK = sSinRegistros_ Then
            Dim loLookUp As New frmBc020documentos
            loLookUp.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loLookUp.Tag = sELEGIR_
            GPCargar(loLookUp)
            If loLookUp.entidad IsNot Nothing Then
                txtCodDocumento_NE.Text = CType(loLookUp.entidad, Ec020documentos).codDocumento.ToString
            End If
            e.Cancel = True
        End If
        loFK.CerrarConexion()
        LPDespliegaDescripciones()
        LPCargarDatos()
    End Sub

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ec040docimpuestos
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFc040docimpuestos
                moFormulario.Tag = CType(sender, Button).AccessibleName
                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                loDatos.codDocumento = Integer.Parse(txtCodDocumento_NE.Text)
                moFormulario.entidad = loDatos
                GPCargar(moFormulario)
                msLocalizar = moFormulario.AccessibleName
                moFormulario = Nothing
            Case Else
                If DataGridView1.CurrentRow Is Nothing Then Exit Sub
                '---------------------------------------------------------------------------------------------
                Dim lsOperacion As String = DataGridView1.Item("operacion", DataGridView1.CurrentRow.Index).Value.ToString
                If lsOperacion.Trim.Length = 0 Then Exit Sub
                Dim lsCodigo As String = DataGridView1.Item("codimpuesto", DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
                    loDatos.codDocumento = Integer.Parse(txtCodDocumento_NE.Text)
                    loDatos.operacion = lsOperacion
                    loDatos.codImpuesto = lsCodigo
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFc040docimpuestos
                        moFormulario.AccessibleName = "Empresa:" & loDatos.codEmpresa.ToString & " - Documento:" & loDatos.codDocumento.ToString & " - Operacion:" & loDatos.operacion & " - Impuesto:" & loDatos.codImpuesto
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Empresa[" & loDatos.codEmpresa & "] Documento[" & loDatos.codDocumento & "] Operacion[" & loDatos.operacion & "] Impuesto[" & loDatos.codImpuesto & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        LPCargarDatos()
    End Sub

    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodDocumento_NE.MaxLength = 3
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsOperacion As String = DataGridView1.Item("operacion", DataGridView1.CurrentRow.Index).Value.ToString
        If lsOperacion.Trim.Length = 0 Then Exit Sub
        Dim lsCodigo As String = DataGridView1.Item("codimpuesto", DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String

        Dim lsResultado As String = ""
        If psCodigo.Trim.Length > 0 Then
            Dim loDatos As New Ec040docimpuestos
            loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text)
            loDatos.codDocumento = Integer.Parse(txtCodDocumento_NE.Text)
            loDatos.operacion = DataGridView1.Item("operacion", DataGridView1.CurrentRow.Index).Value.ToString
            loDatos.codImpuesto = psCodigo
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

End Class