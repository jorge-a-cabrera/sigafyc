Imports System.ComponentModel
Imports System.Globalization
Public Class frmBe050compras
    Private moFormulario As frmFe050compras
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer = 0
    Private msFecOperacion As String = ""
    Private Const sCLAVE_ As String = "transaccion"
    Private Shared mbabrirform As Boolean = False
    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property
    Public Property fecoperacion As String
        Get
            Return msFecOperacion
        End Get
        Set(value As String)
            msFecOperacion = value
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
        AddHandler txtFecOperacion_FE.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtFecOperacion_FE.KeyDown, AddressOf ManejoEvento_KeyDown
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
        If miCodEmpresa > 0 Then
            txtCodEmpresa_NE.Text = miCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength.ToString)
            txtCodEmpresa_NE.Enabled = False
            If msFecOperacion.Trim.Length > 0 Then
                txtFecOperacion_FE.Text = msFecOperacion
                txtFecOperacion_FE.Enabled = False
                LPCargarDatos()
                LPDespliegaDescripciones()
            End If
        End If
    End Sub
    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub
    Private Sub LPCargarDatos()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        If txtFecOperacion_FE.Text.Trim.Length = 0 Then Exit Sub

        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

        Dim lsSQL As String
        Dim loDatos As New Ee050compras
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "transaccion, timbrado, numero, proveedor, operacion, rendicion, cotizacion, condicion, moneda, imp_bruto, imp_neto, impuesto"
        Dim lsCamposOcultos As String = "moneda, decimales, culture"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
            msLocalizar = ""
        End If
        lsSQL = GFsGeneraSQL("frmBe050compras")
        lsSQL = lsSQL.Replace("&codempresa", liCodEmpresa.ToString)
        lsSQL = lsSQL.Replace("&fecoperacion", txtFecOperacion_FE.Text.ToString)
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDataSet = loDatos.RecuperarTabla(lsSQL)

        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName

        DataGridView1.Columns.Item("cotizacion").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("cotizacion").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns.Item("cotizacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight


        DataGridView1.Columns.Item("imp_bruto").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("imp_bruto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
        DataGridView1.Columns.Item("imp_bruto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        DataGridView1.Columns.Item("imp_neto").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("imp_neto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
        DataGridView1.Columns.Item("imp_neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        DataGridView1.Columns.Item("impuesto").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("impuesto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
        DataGridView1.Columns.Item("impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        Dim lsCampoOculto() As String = lsCamposOcultos.Split(","c)
        For I As Integer = 0 To lsCampoOculto.Length - 1
            DataGridView1.Columns.Item(lsCampoOculto(I).Trim).Visible = False
        Next

        DataGridView1.Sort(DataGridView1.Columns(sCLAVE_), ListSortDirection.Ascending)
        DataGridView1.Refresh()

        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDatos.CerrarConexion()
        LPSinRegistro_AbrirForm()
        LPHabilitaControles()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
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
    End Sub
    Private Sub LPLocalizaRegistro(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub

        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(sCLAVE_).Value.ToString = psCodigo Then
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
            DataGridView1.CurrentCell = DataGridView1.Rows(liIndex).Cells(sCLAVE_)
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
        End If
        loFK.CerrarConexion()
        If GFsPuedeUsar("Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength), "Puede gestionar la Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)) <> sSi_ Then
            e.Cancel = True
            Exit Sub
        End If

        LPDespliegaDescripciones()
    End Sub
    Private Sub txtFecOperacion_FE_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFecOperacion_FE.Validating
        Dim lsFechaMinima As String
        If txtFecOperacion_FE.Text.Trim.Length = 0 Then
            txtFecOperacion_FE.Text = Today.ToString(sFormatoFecha1_)
            e.Cancel = True
            Exit Sub
        End If
        If Not IsDate(txtFecOperacion_FE.Text) Then
            GFsAvisar("El dato ingresado [" & txtFecOperacion_FE.Text & "] no es una fecha valida", sMENSAJE_, "reintentelo de nuevo")
            e.Cancel = True
            Exit Sub
        End If
        Dim ldFecha As Date = Date.Parse(txtFecOperacion_FE.Text.ToString)
        txtFecOperacion_FE.Text = ldFecha.ToString(sFormatoFecha1_)
        If txtFecOperacion_FE.Text > Today.ToString(sFormatoFecha1_) Then
            GFsAvisar("La fecha ingresada [" & txtFecOperacion_FE.Text & "] no puede ser postdatada.", sMENSAJE_, "reintentelo de nuevo")
            e.Cancel = True
            Exit Sub
        End If
        Dim lsDiasAnteriores As String = GFsParametroObtener(sUsuario_, "Dias anteriores para carga de Compras", sNo_)
        If Not IsNumeric(lsDiasAnteriores) Then
            lsDiasAnteriores = "0"
        End If
        If txtFecOperacion_FE.Text > Today.ToString(sFormatoFecha1_) Then
            GFsAvisar("La fecha ingresada [" & txtFecOperacion_FE.Text & "] no puede ser postdatada.", sMENSAJE_, "reintentelo de nuevo")
            e.Cancel = True
            Exit Sub
        End If
        lsFechaMinima = DateAdd(DateInterval.Day, Double.Parse(lsDiasAnteriores) * -1, Today).ToString(sFormatoFecha1_)
        If txtFecOperacion_FE.Text < lsFechaMinima Then
            GFsAvisar("La fecha ingresada [" & txtFecOperacion_FE.Text & "] no puede ser previa a [" & lsFechaMinima & "]", sMENSAJE_, "reintentelo de nuevo")
            e.Cancel = True
            txtFecOperacion_FE.Text = lsFechaMinima
            Exit Sub
        End If
        LPDespliegaDescripciones()
        mbabrirform = False
        LPCargarDatos()
    End Sub
    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ee050compras
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.fecoperacion = txtFecOperacion_FE.Text
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFe050compras
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
                Dim lsCodigo As String = DataGridView1.Item(sCLAVE_, DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.numtransaccion = Integer.Parse(lsCodigo)
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFe050compras
                        moFormulario.AccessibleName = "Empresa: " & loDatos.codempresa & ", Transaccion: " & loDatos.numtransaccion
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                        '-->  esto será usado para realizar la localización del registro en el DataGridView
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Transaccion [" & loDatos.numtransaccion & "], Empresa [" & loDatos.codempresa & "]" & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
        LPCargarDatos()
    End Sub
    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsCodigo As String = DataGridView1.Item(sCLAVE_, DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub
    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If psCodigo.Trim.Length > 0 Then
                Dim loDatos As New Ee050compras
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.numtransaccion = Integer.Parse(psCodigo)
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
    Private Sub ImportarTexto_Click(sender As Object, e As EventArgs)
        If GFsPuedeUsar(Me.Name & ":Importar->Texto delimitado", "Permite importar el contenido de " & Me.Name & " a la tabla DOCUMENTOS") = sSi_ Then
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            GPImportarDocumentos(liCodEmpresa)
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
    Private Sub DataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim liRow As Integer = e.RowIndex
        Dim liDecimales As Integer = Integer.Parse(DataGridView1.Item("decimales", liRow).Value.ToString)
        Dim lsCulture As String = DataGridView1.Item("culture", liRow).Value.ToString
        Dim loColImpBruto As DataGridViewColumn = DataGridView1.Columns.Item("imp_bruto")
        Dim loColImpNeto As DataGridViewColumn = DataGridView1.Columns.Item("imp_neto")
        Dim loColImpuesto As DataGridViewColumn = DataGridView1.Columns.Item("impuesto")

        If e.ColumnIndex = loColImpBruto.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & liDecimales.ToString, CultureInfo.CreateSpecificCulture(lsCulture))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColImpNeto.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & liDecimales.ToString, CultureInfo.CreateSpecificCulture(lsCulture))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColImpuesto.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & liDecimales.ToString, CultureInfo.CreateSpecificCulture(lsCulture))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
    End Sub
    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(DataGridView1.Item("transaccion", DataGridView1.CurrentRow.Index).Value.ToString)
        Dim loE050 As New Ee050compras
        loE050.codempresa = liCodEmpresa
        loE050.numtransaccion = liNumTransaccion
        If loE050.GetPK = sOk_ Then
            Dim loC020 As New Ec020documentos
            loC020.codempresa = liCodEmpresa
            loC020.coddocumento = loE050.coddocumento
            If loC020.GetPK = sOk_ Then
                If loC020.lineas = 0 Then
                    GFsAvisar("La Transacción No. " & liNumTransaccion.ToString & ", es un documento que no permite cargar detalles", sMENSAJE_, "Por favor verifique esto para poder continuar.")
                    Exit Sub
                End If
            End If
        End If
        Dim loBrowseDetalle As New frmBe051compras
        loBrowseDetalle.codempresa = liCodEmpresa
        loBrowseDetalle.numtransaccion = liNumTransaccion
        GPCargar(loBrowseDetalle)
        msLocalizar = loBrowseDetalle.AccessibleName
        LPCargarDatos()
    End Sub
End Class