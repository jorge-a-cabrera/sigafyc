Imports System.ComponentModel
Imports System.Globalization
Public Class frmBe062entmercaderia
    Private moFormulario As frmFe062entmercaderia
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private msFecOperacion As String
    Private miDecimales As Integer = 0
    Private msCulture As String = ""
    Private msMaxLength As String = "6"
    Private Const sCLAVE_ As String = "orden"
    Private Shared mbabrirform As Boolean = False
    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property
    Public Property numtransaccion As Integer
        Get
            Return miNumTransaccion
        End Get
        Set(value As Integer)
            miNumTransaccion = value
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
        AddHandler txtNumTransaccion_NE.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtNumTransaccion_NE.KeyDown, AddressOf ManejoEvento_KeyDown
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
            If miNumTransaccion > 0 Then
                txtNumTransaccion_NE.Text = miNumTransaccion.ToString
                txtNumTransaccion_NE.Enabled = False
                Me.AccessibleName = miNumTransaccion.ToString
                LPDespliegaDescripciones()
                mbabrirform = False
                LPCargarDatos()
            End If
        End If
    End Sub
    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub
    Private Sub LPCargarDatos()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        If txtNumTransaccion_NE.Text.Trim.Length = 0 Then Exit Sub

        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)

        Dim lsSQL As String
        Dim loDatos As New Ee061entmercaderia
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "orden, origen_trans, proveedor, documento, neto, impuesto, total, estado"
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
        lsSQL = GFsGeneraSQL("frmBe062entmercaderia")
        lsSQL = lsSQL.Replace("&codempresa", liCodEmpresa.ToString)
        lsSQL = lsSQL.Replace("&numtransaccion", liNumTransaccion.ToString)
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDataSet = loDatos.RecuperarTabla(lsSQL)

        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName

        DataGridView1.Columns.Item("neto").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("neto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns.Item("neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DataGridView1.Columns.Item("impuesto").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("impuesto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns.Item("impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DataGridView1.Columns.Item("total").HeaderCell.Value.ToString.Trim()
        DataGridView1.Columns.Item("total").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns.Item("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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

        lblGastImpuesto.Text = ""
        lblGastImpuesto.Text = ""
        lblTotGeneral.Text = ""
        If miCantidad > 0 Then
            '--En esta parte se realiza una consulta para obtener la sumatoria del detalle
            '--a fin de calcular los totales de Exentas, Gravadas y Total General.
            '--Tambien en esta porción se actualiza los valores de la cabecera.
            lsSQL = GFsGeneraSQL("frmBe062entmercaderia_totales")
            lsSQL = lsSQL.Replace("&codempresa", liCodEmpresa.ToString)
            lsSQL = lsSQL.Replace("&numtransaccion", txtNumTransaccion_NE.Text.ToString)
            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            Dim loTotales As Dictionary(Of String, String) = loDatos.RecuperaRegistro(lsSQL)

            Dim ldGastNeto As Decimal = Decimal.Parse(loTotales("&gastneto_mb"))
            Dim ldGastImpuesto As Decimal = Decimal.Parse(loTotales("&gastimpuesto_mb"))
            Dim ldTotGeneral As Decimal = ldGastNeto + ldGastImpuesto

            lblGastNeto.Text = ldGastNeto.ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture))
            lblGastImpuesto.Text = ldGastImpuesto.ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture))
            lblTotGeneral.Text = ldTotGeneral.ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture))

            Dim loE060 As New Ee060entmercaderia
            loE060.codempresa = liCodEmpresa
            loE060.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
            If loE060.GetPK = sOk_ Then
                loE060.codempresa = liCodEmpresa
                loE060.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)

                loE060.gastneto_mb = ldGastNeto
                loE060.gastimpuesto_mb = ldGastImpuesto
                Try
                    loE060.Put(sNo_, sNo_)
                Catch ex As Exception
                    GFsAvisar("Error durante actualizacion Cabecera", sMENSAJE_, "Por favor comunique al Dpto. Informatica")
                End Try
            End If
            loDatos.CerrarConexion()
        End If
        LPSinRegistro_AbrirForm()
        LPVerificaEstado()
        LPHabilitaControles()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtNumTransaccion_NE.MaxLength = 6
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
        lblFecOperacion.Text = ""
        lblFecVigencia.Text = ""
        lblOrgTransaccion.Text = ""
        lblNomProveedor.Text = ""
        lblIdentificacion.Text = ""
        lblDocumento.Text = ""
        If txtNumTransaccion_NE.Text.Trim.Length > 0 Then
            Dim loE060 As New Ee060entmercaderia
            loE060.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            loE060.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
            If loE060.GetPK = sOk_ Then
                Dim loB040 As New Eb040depositos
                loB040.codEmpresa = loE060.codempresa
                loB040.coddeposito = loE060.coddeposito
                If loB040.GetPK = sOk_ Then
                    lblNomDeposito.Text = loB040.nombre
                End If
                loB040.CerrarConexion()
                lblFecOperacion.Text = loE060.fecoperacion
                lblFecVigencia.Text = loE060.fecvigencia
                lblOrgTransaccion.Text = loE060.orgtransaccion.ToString(sFormatD_ & txtNumTransaccion_NE.MaxLength.ToString)
                Dim loE050 As New Ee050compras
                loE050.codempresa = loE060.codempresa
                loE050.numtransaccion = loE060.orgtransaccion
                If loE050.GetPK = sOk_ Then
                    Dim loC020 As New Ec020documentos
                    loC020.codempresa = loE050.codempresa
                    loC020.coddocumento = loE050.coddocumento
                    If loC020.GetPK = sOk_ Then
                        lblDocumento.Text = loC020.abreviado & ": " & loE050.prefijo & "-" & loE050.numcompra.ToString(sFormatD_ & msMaxLength)
                    End If
                    loC020.CerrarConexion()
                    lblIdentificacion.Text = loE050.tipodocumento & ": " & loE050.numdocumento
                    Dim loA030 As New Ea030personas
                    loA030.tipoDocumento = loE050.tipodocumento
                    loA030.nroDocumento = loE050.numdocumento
                    If loA030.GetPK = sOk_ Then
                        lblNomProveedor.Text = loA030.nombre
                    End If
                End If
                loE050.CerrarConexion()
            End If
            loE060.CerrarConexion()
            Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
            txtNumTransaccion_NE.Text = liNumTransaccion.ToString(sFormatD_ & txtNumTransaccion_NE.MaxLength)
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
    Private Sub txtnumtransaccion_NE_Validating(sender As Object, e As CancelEventArgs) Handles txtNumTransaccion_NE.Validating
        If txtNumTransaccion_NE.Text.Trim.Length = 0 Then
            GFsAvisar("Debe ingresar un numero de transaccion.", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtNumTransaccion_NE.Text = "0"
            btnSalir.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtNumTransaccion_NE.Text) Then
            GFsAvisar("Debe ingresar un numero de transaccion valido.", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtNumTransaccion_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)

        Dim loE060 As New Ee060entmercaderia
        loE060.codempresa = liCodEmpresa
        loE060.numtransaccion = liNumTransaccion
        If loE060.GetPK = sSinRegistros_ Then
            GFsAvisar("Debe ingresar un numero de transaccion existente.", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtNumTransaccion_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        loE060.CerrarConexion()

        LPDespliegaDescripciones()
        mbabrirform = False
        LPCargarDatos()
    End Sub
    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ee062entmercaderia
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFe062entmercaderia
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
                    loDatos.numorden = Integer.Parse(lsCodigo)
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFe062entmercaderia
                        moFormulario.AccessibleName = "Empresa: " & loDatos.codempresa & ", Transaccion: " & loDatos.numtransaccion & ", Orden: " & loDatos.numorden
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                        '-->  esto será usado para realizar la localización del registro en el DataGridView
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Orden [" & loDatos.numorden & "], Transaccion [" & loDatos.numtransaccion & "], Empresa [" & loDatos.codempresa & "]" & ControlChars.CrLf & ex.Message)
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
                Dim loDatos As New Ee062entmercaderia
                loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
                loDatos.numorden = Integer.Parse(psCodigo)
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
        Dim loColGastNeto As DataGridViewColumn = DataGridView1.Columns.Item("neto")
        Dim loColGastImpuesto As DataGridViewColumn = DataGridView1.Columns.Item("impuesto")
        Dim loColTotal As DataGridViewColumn = DataGridView1.Columns.Item("total")
        Dim lsFormato As String = sFormatD_ & msMaxLength

        If e.ColumnIndex = loColGastNeto.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales.ToString, CultureInfo.CreateSpecificCulture(msCulture))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColGastImpuesto.Index Then
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
    Private Sub LPVerificaEstado()
        If miCodEmpresa = 0 Then Exit Sub
        If miNumTransaccion = 0 Then Exit Sub

        Dim loE060 As New Ee060entmercaderia
        loE060.codempresa = miCodEmpresa
        loE060.numtransaccion = miNumTransaccion
        If loE060.GetPK = sOk_ Then
            Select Case loE060.estado
                Case sEnCosteo_
                    mbAgregar = False
                    mbModificar = False
                    mbBorrar = False
                Case sCosteado_
                    mbAgregar = False
                    mbModificar = False
                    mbBorrar = False
            End Select
            Me.Refresh()
        End If
        loE060.CerrarConexion()
    End Sub
End Class