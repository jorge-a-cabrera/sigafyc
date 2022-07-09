Imports System.ComponentModel
Imports System.Globalization
Public Class frmBe051compras
    Private moFormulario As frmFe051compras
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar As String = ""
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private msMaxLength7 As String = "7"
    Private msCodMoneda_mo As String = ""
    Private miDecimales_mo As Integer = 0
    Private msCulture_mo As String = ""
    Private msAplicacion As String = ""
    Private Const sCLAVE_ As String = "orden"
    Private Shared mbabrirform As Boolean = False
    Public Property codempresa As Integer
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
        lblNombreEmpresa.Text = ""
        If miCodEmpresa > 0 Then
            txtCodEmpresa_NE.Enabled = False
            txtCodEmpresa_NE.Text = miCodEmpresa.ToString
            If miNumTransaccion > 0 Then
                txtNumTransaccion_NE.Enabled = False
                txtNumTransaccion_NE.Text = miNumTransaccion.ToString
                Me.AccessibleName = miNumTransaccion.ToString
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
        If txtNumTransaccion_NE.Text.Trim.Length = 0 Then Exit Sub

        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

        Dim lsSQL As String
        Dim loDatos As New Ee051compras
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "orden, codigo, mercaderia, unidad, cantidad, iva, prec_unitario, imp_total"
        '***MCO:Manejo Campos Ocultos***
        '---En la linea de abajo debe descomentar si en este Browse va manejar campos ocultos
        '---e indicar los nombres de campos conforme al query de generacion como valoores del
        '---campo lsCamposOcultos
        'Dim lsCamposOcultos As String = "moneda, decimales, culture"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
            msLocalizar = ""
        End If
        lsSQL = GFsGeneraSQL("frmBe051compras")
        lsSQL = lsSQL.Replace("&codempresa", liCodEmpresa.ToString)
        lsSQL = lsSQL.Replace("&numtransaccion", txtNumTransaccion_NE.Text.ToString)
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName

        DataGridView1.Columns.Item("cantidad").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        DataGridView1.Columns.Item("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DataGridView1.Columns.Item("prec_unitario").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        DataGridView1.Columns.Item("prec_unitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DataGridView1.Columns.Item("imp_neto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        DataGridView1.Columns.Item("imp_neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DataGridView1.Columns.Item("impuesto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        DataGridView1.Columns.Item("impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        DataGridView1.Columns.Item("imp_total").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        DataGridView1.Columns.Item("imp_total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        '***MCO:Manejo Campos Ocultos***
        '---Si este Browse tiene definido campos ocultos debe descomentar las lineas de abajo
        '---a fin estos puedan ocultarse en el DataGridView
        'Dim lsCampoOculto() As String = lsCamposOcultos.Split(","c)
        'For I As Integer = 0 To lsCampoOculto.Length - 1
        '    DataGridView1.Columns.Item(lsCampoOculto(I).Trim).Visible = False
        'Next

        DataGridView1.Sort(DataGridView1.Columns(sCLAVE_), ListSortDirection.Ascending)
        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        If miCantidad > 0 Then
            '--En esta parte se realiza una consulta para obtener la sumatoria del detalle
            '--a fin de calcular los totales de Exentas, Gravadas y Total General.
            '--Tambien en esta porción se actualiza los valores de la cabecera.
            lsSQL = GFsGeneraSQL("frmBe051compras_totales")
            lsSQL = lsSQL.Replace("&codempresa", liCodEmpresa.ToString)
            lsSQL = lsSQL.Replace("&numtransaccion", txtNumTransaccion_NE.Text.ToString)
            loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            Dim loTotales As Dictionary(Of String, String) = loDatos.RecuperaRegistro(lsSQL)

            Dim ldTotExenta_mo As Decimal = Decimal.Parse(loTotales("&totexenta_mo"))
            Dim ldTotGrav05_mo As Decimal = Decimal.Parse(loTotales("&totgrav05_mo"))
            Dim ldTotGrav10_mo As Decimal = Decimal.Parse(loTotales("&totgrav10_mo"))
            Dim ldIvaGrav05_mo As Decimal = Decimal.Parse(loTotales("&ivagrav05_mo"))
            Dim ldIvaGrav10_mo As Decimal = Decimal.Parse(loTotales("&ivagrav10_mo"))
            Dim ldTotGenera_mo As Decimal = Decimal.Parse(loTotales("&totgenera_mo"))

            Dim ldTotExenta_mb As Decimal = Decimal.Parse(loTotales("&totexenta_mb"))
            Dim ldTotGrav05_mb As Decimal = Decimal.Parse(loTotales("&totgrav05_mb"))
            Dim ldTotGrav10_mb As Decimal = Decimal.Parse(loTotales("&totgrav10_mb"))
            Dim ldIvaGrav05_mb As Decimal = Decimal.Parse(loTotales("&ivagrav05_mb"))
            Dim ldIvaGrav10_mb As Decimal = Decimal.Parse(loTotales("&ivagrav10_mb"))
            Dim ldTotGenera_mb As Decimal = Decimal.Parse(loTotales("&totgenera_mb"))

            lblTotExenta.Text = ldTotExenta_mo.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            lblTotGrav05.Text = ldTotGrav05_mo.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            lblTotGrav10.Text = ldTotGrav10_mo.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            lblIvaGrav05.Text = ldIvaGrav05_mo.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            lblIvaGrav10.Text = ldIvaGrav10_mo.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            lblTotGenera.Text = ldTotGenera_mo.ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            Dim loE050 As New Ee050compras
            loE050.codempresa = liCodEmpresa
            loE050.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
            If loE050.GetPK = sOk_ Then
                loE050.codempresa = liCodEmpresa
                loE050.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)

                Dim ldTotExenta_in As Decimal = ldTotExenta_mo
                Dim ldTotGrav05_in As Decimal = 0.00D
                Dim ldTotGrav10_in As Decimal = 0.00D
                Dim ldIvaGrav05_in As Decimal = 0.00D
                Dim ldIvaGrav10_in As Decimal = 0.00D
                Dim ldTotGenera_in As Decimal = 0.00D
                Select Case msAplicacion
                    Case sLinea_
                        ldTotGrav05_in = ldTotGrav05_mo + ldIvaGrav05_mo
                        ldTotGrav10_in = ldTotGrav10_mo + ldIvaGrav10_mo
                    Case sTotales_
                        ldTotGrav05_in = ldTotGrav05_mo
                        ldTotGrav10_in = ldTotGrav10_mo
                        ldIvaGrav05_in = ldIvaGrav05_mo
                        ldIvaGrav10_in = ldIvaGrav10_mo
                End Select
                loE050.totexenta_in = ldTotExenta_in
                loE050.totgrav05_in = ldTotGrav05_in
                loE050.totgrav10_in = ldTotGrav10_in
                loE050.ivagrav05_in = ldIvaGrav05_in
                loE050.ivagrav10_in = ldIvaGrav10_in

                loE050.totexenta_mo = ldTotExenta_mo
                loE050.totgrav05_mo = ldTotGrav05_mo
                loE050.totgrav10_mo = ldTotGrav10_mo
                loE050.ivagrav05_mo = ldIvaGrav05_mo
                loE050.ivagrav10_mo = ldIvaGrav10_mo

                loE050.totexenta_mb = ldTotExenta_mb
                loE050.totgrav05_mb = ldTotGrav05_mb
                loE050.totgrav10_mb = ldTotGrav10_mb
                loE050.ivagrav05_mb = ldIvaGrav05_mb
                loE050.ivagrav10_mb = ldIvaGrav10_mb
                Try
                    loE050.Put(sNo_, sNo_)
                Catch ex As Exception
                    GFsAvisar("Error durante actualizacion Cabecera", sMENSAJE_, "Por favor comunique al Dpto. Informatica")
                End Try
            End If

        End If

        loDatos.CerrarConexion()
        LPSinRegistro_AbrirForm()
        LPHabilitaControles()
    End Sub
    Private Sub LPInicializaMaxLength()
        txtCodEmpresa_NE.MaxLength = 6
        txtNumTransaccion_NE.MaxLength = 6
    End Sub
    Private Sub LPDespliegaDescripciones()
        Dim liDecimales_mb As Integer = 0
        Dim lsCulture_mb As String = ""

        lblNombreEmpresa.Text = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            Dim loFK As New Ec001empresas
            loFK.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            If loFK.GetPK = sOk_ Then
                lblNombreEmpresa.Text = loFK.nombre.Trim
            End If
            loFK.CerrarConexion()
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            txtCodEmpresa_NE.Text = liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)

            Dim loA010 As New Ea010monedas
            loA010.codMoneda = loFK.codMoneda
            If loA010.GetPK = sOk_ Then
                lblCodMoneda.Text = loA010.nombre
                liDecimales_mb = loA010.decimales
                lsCulture_mb = loA010.culture
            End If
            loA010.CerrarConexion()
        End If

        Dim loE050 As New Ee050compras
        Dim liNumTransaccion As Integer = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        txtNumTransaccion_NE.Text = liNumTransaccion.ToString(sFormatD_ & txtNumTransaccion_NE.MaxLength.ToString)

        loE050.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loE050.numtransaccion = liNumTransaccion
        If loE050.GetPK = sOk_ Then
            msAplicacion = loE050.aplicacion
            lblNomDocumento.Text = ""
            Dim loC020 As New Ec020documentos
            loC020.codempresa = loE050.codempresa
            loC020.coddocumento = loE050.coddocumento
            If loC020.GetPK = sOk_ Then
                lblNomDocumento.Text = "Tipo: " & loC020.nombre.Trim
            End If
            loC020.CerrarConexion()
            lblNumTimbrado.Text = "Timbrado No.: " & loE050.timbrado

            Dim loA030 As New Ea030personas
            loA030.tipoDocumento = loE050.tipodocumento
            loA030.nroDocumento = loE050.numdocumento
            If loA030.GetPK = sOk_ Then
                lblRazonSocial.Text = loE050.tipodocumento.ToUpper & ": " & loE050.numdocumento & vbCrLf & loA030.nombre.Trim
            End If
            loA030.CerrarConexion()

            Dim loA010 As New Ea010monedas
            loA010.codMoneda = loE050.codmoneda_mo
            If loA010.GetPK = sOk_ Then
                lblCodMoneda.Text = loA010.nombre
                msCodMoneda_mo = loA010.codMoneda
                miDecimales_mo = loA010.decimales
                msCulture_mo = loA010.culture
            End If
            loA010.CerrarConexion()

            lblFecOperacion.Text = "Operación: " & loE050.fecoperacion
            lblFecRendicion.Text = "Rendición: " & loE050.fecrendicion
            lblNumComprobante.Text = "No.: " & loE050.prefijo & "-" & loE050.numcompra.ToString(sFormatD_ & msMaxLength7)

            lblCotizacion.Text = "Cotizacion: " & loE050.cotizacion.ToString(sFormatC_ & liDecimales_mb.ToString, CultureInfo.CreateSpecificCulture(lsCulture_mb)) & "/" & loE050.codmoneda_mo
            lblCondOperacion.Text = "Cond. operacion: " & loE050.condoperacion
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
    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ee051compras
        loDatos.codempresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.numtransaccion = Integer.Parse(txtNumTransaccion_NE.Text.ToString)
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFe051compras
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
                        moFormulario = New frmFe051compras
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
                Dim loDatos As New Ee051compras
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
        Dim loColPrecUnitario As DataGridViewColumn = DataGridView1.Columns.Item("prec_unitario")
        Dim loColImpNeto As DataGridViewColumn = DataGridView1.Columns.Item("imp_neto")
        Dim loColImpuesto As DataGridViewColumn = DataGridView1.Columns.Item("impuesto")
        Dim loColImpTotal As DataGridViewColumn = DataGridView1.Columns.Item("imp_total")

        If e.ColumnIndex = loColPrecUnitario.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColImpNeto.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColImpuesto.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColImpTotal.Index Then
            e.Value = CDec(e.Value).ToString(sFormatC_ & miDecimales_mo.ToString, CultureInfo.CreateSpecificCulture(msCulture_mo))
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            e.FormattingApplied = True
        End If
    End Sub

End Class