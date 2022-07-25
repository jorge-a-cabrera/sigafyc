Imports System.ComponentModel
Imports System.Globalization

Public Class frmBe060entmercaderia
    Private moFormulario As frmFe060entmercaderia
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer
    Private miCodDeposito As Integer
    Private msFecOperacion As String
    Private miDecimales As Integer = 0
    Private msCulture As String = ""
    Private msMaxLength As String = "6"
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
    Public Property coddeposito As Integer
        Get
            Return miCoddeposito
        End Get
        Set(value As Integer)
            miCoddeposito = value
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
        btnDetalle.Enabled = False

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
        AddHandler txtCodDeposito_NE.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtCodDeposito_NE.KeyDown, AddressOf ManejoEvento_KeyDown
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
        lblNomEmpresa.Text = ""
        If miCodEmpresa > 0 Then
            txtCodEmpresa_NE.Text = miCodEmpresa.ToString
            txtCodEmpresa_NE.Enabled = False
            If miCodDeposito > 0 Then
                txtCodDeposito_NE.Text = miCodDeposito.ToString
                txtCodDeposito_NE.Enabled = False
                LPDespliegaDescripciones()
                LPCargarDatos()
            End If
        End If
    End Sub
    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub
    Private Sub LPCargarDatos()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        If txtCodDeposito_NE.Text.Trim.Length = 0 Then Exit Sub

        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liCodDeposito As Integer = Integer.Parse(txtCodDeposito_NE.Text.ToString)

        Dim lsSQL As String
        Dim loDatos As New Ee060entmercaderia
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "transaccion, deposito, trans_origen, fec_operacion, fec_vigencia, moneda, estado"
        Dim lsCamposOcultos As String = ""
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
            msLocalizar = ""
        End If
        lsSQL = GFsGeneraSQL("frmBe060entmercaderia")
        lsSQL = lsSQL.Replace("&codempresa", liCodEmpresa.ToString)
        lsSQL = lsSQL.Replace("&coddeposito", liCodDeposito.ToString)
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDataSet = loDatos.RecuperarTabla(lsSQL)

        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName

        DataGridView1.Columns.Item("importe").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("importe").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns.Item("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        DataGridView1.Columns.Item("impuesto").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("impuesto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
        DataGridView1.Columns.Item("impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        DataGridView1.Columns.Item("total").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("total").HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
        DataGridView1.Columns.Item("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        If lsCamposOcultos.Trim.Length > 0 Then
            Dim lsCampoOculto() As String = lsCamposOcultos.Split(","c)
            For I As Integer = 0 To lsCampoOculto.Length - 1
                DataGridView1.Columns.Item(lsCampoOculto(I).Trim).Visible = False
            Next
        End If

        DataGridView1.Sort(DataGridView1.Columns(sCLAVE_), ListSortDirection.Ascending)
        DataGridView1.Refresh()

        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDatos.CerrarConexion()
        LPSinRegistro_AbrirForm()
        btnDetalle.Enabled = False
        LPHabilitaControles()
        If miCantidad > 0 Then
            btnDetalle.Enabled = True
        End If
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtCodDeposito_NE.MaxLength = 3
    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim lsCodMoneda As String = ""
        lblNomEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Ec001empresas
            loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            If loFK.GetPK = sOk_ Then
                lblNomEmpresa.Text = loFK.nombre
                lsCodMoneda = loFK.codMoneda
            End If
            loFK.CerrarConexion()
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)

            Dim loA010 As New Ea010monedas
            loA010.codMoneda = lsCodMoneda
            If loA010.GetPK = sOk_ Then
                miDecimales = loA010.decimales
                msCulture = loA010.culture
            End If
            loA010.CerrarConexion()
        End If
        lblNomDeposito.Text = ""
        If txtCodDeposito_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Eb040depositos
            loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loFK.coddeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
            If loFK.GetPK = sOk_ Then
                lblNomDeposito.Text = loFK.nombre
            End If
            loFK.CerrarConexion()
            Dim liCoddeposito As Integer = Integer.Parse(txtCodDeposito_NE.Text.ToString)
            txtCodDeposito_NE.Text = liCoddeposito.ToString(sFormatD_ & txtCodDeposito_NE.MaxLength)
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
    Private Sub txtCodDeposito_NE_Validating(sender As Object, e As CancelEventArgs) Handles txtCodDeposito_NE.Validating
        Dim loFK As New Eb040depositos
        If txtCodDeposito_NE.Text.Trim.Length = 0 Then
            GFsAvisar("Debe ingresar codigo de deposito valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtCodDeposito_NE.Text = "0"
            btnSalir.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtCodDeposito_NE.Text) Then
            txtCodDeposito_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liCodDeposito As Integer = Integer.Parse(txtCodDeposito_NE.Text.ToString)

        loFK.codEmpresa = liCodEmpresa
        loFK.coddeposito = liCodDeposito
        If loFK.GetPK = sSinRegistros_ Then
            Dim loLookUp As New frmBb040depositos
            loLookUp.codEmpresa = liCodEmpresa
            loLookUp.Tag = sELEGIR_
            GPCargar(loLookUp)
            If loLookUp.entidad IsNot Nothing Then
                txtCodDeposito_NE.Text = CType(loLookUp.entidad, Eb040depositos).coddeposito.ToString
            Else
                e.Cancel = True
                Exit Sub
            End If
            loLookUp = Nothing
        End If
        loFK.CerrarConexion()

        If GFsPuedeUsar("Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength) & ", Deposito No." & liCodDeposito.ToString(sFormatD_ & txtCodDeposito_NE.MaxLength), "Puede gestionar la Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)) <> sSi_ Then
            e.Cancel = True
            Exit Sub
        End If
        LPDespliegaDescripciones()
        mbabrirform = False
        LPCargarDatos()
    End Sub
    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ee060entmercaderia
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                loDatos.coddeposito = Integer.Parse(txtCodDeposito_NE.Text.ToString)
                moFormulario = New frmFe060entmercaderia
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
                        moFormulario = New frmFe060entmercaderia
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
                Dim loDatos As New Ee060entmercaderia
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
        Dim loColTransaccion As DataGridViewColumn = DataGridView1.Columns.Item("transaccion")
        Dim loColTransOrigen As DataGridViewColumn = DataGridView1.Columns.Item("trans_origen")
        Dim loColImporte As DataGridViewColumn = DataGridView1.Columns.Item("importe")
        Dim loColImpuesto As DataGridViewColumn = DataGridView1.Columns.Item("impuesto")
        Dim loColTotal As DataGridViewColumn = DataGridView1.Columns.Item("total")
        Dim lsFormato As String = sFormatD_ & msMaxLength

        If e.ColumnIndex = loColTransaccion.Index Then
            e.Value = CInt(e.Value).ToString(lsFormato)
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColTransOrigen.Index Then
            e.Value = CInt(e.Value).ToString(lsFormato)
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColImporte.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColImpuesto.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColTotal.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub frmBe060entmercaderia_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtCodEmpresa_NE.Select()
    End Sub

    Private Sub DetalleDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeComprasToolStripMenuItem.Click
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(DataGridView1.Item("transaccion", DataGridView1.CurrentRow.Index).Value.ToString)
        Dim loBrowseDetalle As New frmBe061entmercaderia
        loBrowseDetalle.codEmpresa = liCodEmpresa
        loBrowseDetalle.numtransaccion = liNumTransaccion
        GPCargar(loBrowseDetalle)
        msLocalizar = loBrowseDetalle.AccessibleName
        LPCargarDatos()
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        mnuDetalle.Show(MousePosition)
    End Sub

    Private Sub DetalleDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeGastosToolStripMenuItem.Click
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(DataGridView1.Item("transaccion", DataGridView1.CurrentRow.Index).Value.ToString)
        Dim loBrowseDetalle As New frmBe062entmercaderia
        loBrowseDetalle.codEmpresa = liCodEmpresa
        loBrowseDetalle.numtransaccion = liNumTransaccion
        GPCargar(loBrowseDetalle)
        msLocalizar = loBrowseDetalle.AccessibleName
        LPCargarDatos()
    End Sub

    Private Sub ProcesoDeCosteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesoDeCosteoToolStripMenuItem.Click
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(DataGridView1.Item("transaccion", DataGridView1.CurrentRow.Index).Value.ToString)
        Dim ldCompNeta As Decimal
        Dim ldGastNeto As Decimal
        Dim ldGastImpuesto As Decimal
        Dim loParametros As New Dictionary(Of String, String)
        loParametros.Add("&codempresa", lblNomEmpresa.Text.ToString)
        loParametros.Add("&numtransaccion", liNumTransaccion.ToString)
        Dim loE060 As New Ee060entmercaderia
        loE060.codempresa = liCodEmpresa
        loE060.numtransaccion = liNumTransaccion
        If loE060.GetPK = sOk_ Then
            If loE060.estado = sCosteado_ Then
                GFsAvisar("La Transaccion No. [" & liNumTransaccion.ToString & "] ya ha sido costeado.", sMENSAJE_, "No podrá continuar con la accion solicitada.")
                Exit Sub
            End If
            ldCompNeta = loE060.compneta_mb
            ldGastNeto = loE060.gastneto_mb
            ldGastImpuesto = loE060.gastimpuesto_mb
            loParametros.Add("&coddeposito", lblNomDeposito.Text.ToString)
            loParametros.Add("&fecoperacion", loE060.fecoperacion)
            loParametros.Add("&fecvigencia", loE060.fecvigencia)
            loParametros.Add("&compneta", loE060.compneta_mb.ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture)))
            loParametros.Add("&compimpuesto", loE060.compimpuesto_mb.ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture)))
            loParametros.Add("&gastneto", loE060.compneta_mb.ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture)))
            loParametros.Add("&gastimpuesto", loE060.compimpuesto_mb.ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture)))
            loParametros.Add("&estado", loE060.estado)
        End If

        Dim lsMensaje As String = GFsGeneraMSG("msg_e060_costeo_confirmación", loParametros)
        Dim lsRespuesta As String = GFsConfirmacion(sCosteado_, lsMensaje)
        If lsRespuesta = sCancelar_ Then Exit Sub

        If LFsProcesaDetalle061(liCodEmpresa, liNumTransaccion, ldGastNeto, ldGastImpuesto, ldCompNeta, loE060.coddeposito) = sError_ Then Exit Sub
        If LFsProcesaDetalle062(liCodEmpresa, liNumTransaccion) = sError_ Then Exit Sub


        loE060.codempresa = liCodEmpresa
        loE060.numtransaccion = liNumTransaccion
        If loE060.GetPK = sOk_ Then
            loE060.codempresa = liCodEmpresa
            loE060.numtransaccion = liNumTransaccion
            loE060.estado = sCosteado_
            Try
                loE060.Put(sNo_, sSi_)
                Dim loE050 As New Ee050compras
                loE050.codempresa = liCodEmpresa
                loE050.numtransaccion = loE060.orgtransaccion
                If loE050.GetPK = sOk_ Then
                    loE050.codempresa = liCodEmpresa
                    loE050.numtransaccion = loE060.orgtransaccion
                    loE050.estado = sCosteado_
                    Try
                        loE050.Put(sNo_, sSi_)
                    Catch ex As Exception
                        GFsAvisar("Error durante actualizacion ESTADO de E050 AL FINAL", sMENSAJE_, "Por favor comuniquese con el Dpto. Informatica")
                    End Try
                End If
            Catch ex As Exception
                GFsAvisar("Error durante actualizacion ESTADO de E060", sMENSAJE_, "Por favor comuniquese con el Dpto. Informatica")
            End Try
        End If
        loE060.CerrarConexion()
    End Sub
    Private Function LFsProcesaDetalle061(ByVal piCodEmpresa As Integer, ByVal piNumTransaccion As Integer, ByVal pdGastNeto As Decimal, ByVal pdGastImpuesto As Decimal, ByVal pdCompNeta As Decimal, ByVal piCodDeposito As Integer) As String
        Dim lsRespuesta As String = sError_
        Dim ldGastNeto_dist As Decimal
        Dim ldGastImpuesto_dist As Decimal
        ldGastNeto_dist = pdGastNeto
        ldGastImpuesto_dist = pdGastImpuesto

        Dim lsSQL As String = GFsGeneraSQL("e061entmercaderia_costear")
        lsSQL = lsSQL.Replace("&codempresa", piCodEmpresa.ToString)
        lsSQL = lsSQL.Replace("&numtransaccion", piNumTransaccion.ToString)
        Dim loDatos As New Ee061entmercaderia
        Dim loDetalle As Common.DbDataReader = loDatos.RecuperarConsulta(lsSQL)
        Dim loE061 As New Ee061entmercaderia
        loE061.ComenzarTransaccion()
        Dim ldGastNeto_lin As Decimal
        Dim ldGastImpuesto_lin As Decimal
        While loDetalle.Read()
            Dim liNumOrden As Integer = Integer.Parse(loDetalle("numorden").ToString)
            Dim ldCompNeta_lin As Decimal = Decimal.Parse(loDetalle("compneta").ToString)
            loE061.codempresa = piCodEmpresa
            loE061.numtransaccion = piNumTransaccion
            loE061.numorden = liNumOrden
            If loE061.GetPK = sOk_ Then
                loE061.codempresa = piCodEmpresa
                loE061.numtransaccion = piNumTransaccion
                loE061.numorden = liNumOrden
                ldGastNeto_lin = Math.Round(pdGastNeto * (ldCompNeta_lin / pdCompNeta), miDecimales)
                ldGastImpuesto_lin = Math.Round(pdGastImpuesto * (ldCompNeta_lin / pdCompNeta), miDecimales)
                If ldGastNeto_lin < ldGastNeto_dist Then
                    ldGastNeto_lin = ldGastNeto_dist
                    ldGastImpuesto_lin = ldGastImpuesto_dist
                End If
                ldGastNeto_dist -= ldGastNeto_lin
                ldGastImpuesto_dist -= ldGastImpuesto_lin

                loE061.gastneto_mb = Decimal.Parse(ldGastNeto_lin.ToString(sFormatF_))
                loE061.gastimpuesto_mb = Decimal.Parse(ldGastImpuesto_lin.ToString(sFormatF_))
                Dim ldTotalNeto As Decimal = loE061.compneta_mb + loE061.gastneto_mb
                Dim ldTotalImpuesto As Decimal = loE061.compimpuesto_mb + loE061.gastimpuesto_mb
                loE061.costo_mb = Decimal.Parse(Math.Round(ldTotalNeto / loE061.cantentrada, miDecimales).ToString(sFormatF_))
                loE061.costoimpuesto_mb = Decimal.Parse(Math.Round(ldTotalImpuesto / loE061.cantentrada, miDecimales).ToString(sFormatF_))
                loE061.estado = sCosteado_
                Try
                    loE061.Put(sNo_, sSi_)
                    lsRespuesta = GFsProcesaInventarioSaldo(piCodEmpresa, loDetalle("codmercaderia").ToString, loDetalle("fecvigencia").ToString, piCodDeposito, loDetalle("codubicacion").ToString, sEntrada_, loE061.cantentrada, loE061.compneta_mb + loE061.gastneto_mb, loE061.compimpuesto_mb + loE061.gastimpuesto_mb)
                Catch ex As Exception
                    loE061.CancelarTransaccion()
                    GFsAvisar("Error durante actualizacion costo", sMENSAJE_, "Por favor comuniquese con el Dpto. Informatica")
                End Try
            End If
        End While
        loE061.ConfirmarTransaccion()
        loE061.CerrarConexion()
        loDetalle.Close()
        loDatos.CerrarConexion()
        Return lsRespuesta
    End Function
    Private Function LFsProcesaDetalle062(ByVal piCodEmpresa As Integer, ByVal piNumTransaccion As Integer) As String
        Dim lsRespuesta As String = sError_
        Dim lsSQL As String = GFsGeneraSQL("e062entmercaderia_costear")
        lsSQL = lsSQL.Replace("&codempresa", piCodEmpresa.ToString)
        lsSQL = lsSQL.Replace("&numtransaccion", piNumTransaccion.ToString)
        Dim loDatos As New Ee062entmercaderia
        Dim loDetalle As Common.DbDataReader = loDatos.RecuperarConsulta(lsSQL)
        Dim loE062 As New Ee062entmercaderia
        loE062.ComenzarTransaccion()
        While loDetalle.Read()
            Dim liNumOrden As Integer = Integer.Parse(loDetalle("numorden").ToString)
            loE062.codempresa = piCodEmpresa
            loE062.numtransaccion = piNumTransaccion
            loE062.numorden = liNumOrden
            If loE062.GetPK = sOk_ Then
                loE062.codempresa = piCodEmpresa
                loE062.numtransaccion = piNumTransaccion
                loE062.numorden = liNumOrden
                loE062.estado = sCosteado_
                Try
                    loE062.Put(sNo_, sSi_)
                    Dim loE050 As New Ee050compras
                    loE050.codempresa = piCodEmpresa
                    loE050.numtransaccion = loE062.orgtransaccion
                    If loE050.GetPK = sOk_ Then
                        loE050.codempresa = piCodEmpresa
                        loE050.numtransaccion = loE062.orgtransaccion
                        loE050.estado = sCosteado_
                        Try
                            loE050.Put(sNo_, sSi_)
                            lsRespuesta = sOk_
                        Catch ex As Exception
                            GFsAvisar("Error durante actualizacion estado E050 - Gastos", sMENSAJE_, "Por favor comuniquese con el Dpto. Informatica")
                        End Try
                    End If
                    loE050.CerrarConexion()
                Catch ex As Exception
                    loE062.CancelarTransaccion()
                    GFsAvisar("Error durante actualizacion estados E062", sMENSAJE_, "Por favor comuniquese con el Dpto. Informatica")
                End Try
            End If
        End While
        loE062.ConfirmarTransaccion()
        loE062.CerrarConexion()
        loDetalle.Close()
        loDatos.CerrarConexion()
        Return lsRespuesta
    End Function
End Class