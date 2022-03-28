Imports System.ComponentModel
Imports System.Globalization

Public Class frmBb060perautgest
    Private moFormulario As frmFb060perautgest
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar As String = ""
    Private msTipoPerfil As String = ""
    Private miCodEmpresa As Integer
    Private Const sCodigo1_ As String = "tipo_documento"
    Private Const sCodigo2_ As String = "nro_documento"
    Private Shared mbabrirform As Boolean = False
    Private msDecimales As String = ""
    Private msCulture As String = ""

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property tipoPerfil As String
        Get
            Return msTipoPerfil
        End Get
        Set(value As String)
            msTipoPerfil = value
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
        AddHandler txtCodEmpresa_NE.KeyDown, AddressOf ManejoEvento_KeyDown
        AddHandler cmbTipoPerfil.KeyDown, AddressOf ManejoEvento_KeyDown
        AddHandler DataGridView1.KeyDown, AddressOf DataGrid_KeyDown
        AddHandler DataGridView1.CellContentDoubleClick, AddressOf DataGrid_DoubleClick

        DataGridView1.ContextMenuStrip = mnuExportarExcel

        AddHandler MenuItem_ExportarExcel.Click, AddressOf ExportarExcel_Click
        AddHandler MenuItem_ExportarTexto.Click, AddressOf ExportarTexto_Click

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
            txtCodEmpresa_NE.Enabled = False
            If msTipoPerfil.Trim.Length > 0 Then
                cmbTipoPerfil.Enabled = False
                LPCargarDatos()
            End If
        End If
    End Sub

    Private Sub BuscarClave(sender As Object, e As EventArgs)
        LPCargarDatos()
    End Sub

    Private Sub LPCargarDatos()
        Dim lsSQL As String = GFsGeneraSQL("frmBb060perautgest")
        Dim loCN As New BaseDatos
        Dim loDataTable As DataTable
        Dim lsCamposConcat As String = "x.tipo_documento, x.nro_documento, x.nombre, x.dias, x.moneda, x.limite_credito, x.sucursal, x.direccion, x.telefono
"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text.Trim = txtBuscar.Tag.ToString.Trim Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
        End If
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        lsSQL = lsSQL.Replace("@codempresa", txtCodEmpresa_NE.Text)
        lsSQL = lsSQL.Replace("@tipoperfil", cmbTipoPerfil.Text)

        loCN.SetearParametrosConexion(sRegistryTablasPrincipal_)
        loCN.Conectar()
        loCN.CrearComando(lsSQL)
        loDataTable = loCN.EjecutarConsultaTable()
        loDataTable.TableName = "Temporal"
        DataGridView1.DataSource = loDataTable

        DataGridView1.Columns.Item("limite_credito").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        DataGridView1.Columns.Item("limite_credito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DataGridView1.Columns.Item("codempresa").Visible = False
        DataGridView1.Columns.Item("tipoperfil").Visible = False

        DataGridView1.Sort(DataGridView1.Columns(sCodigo2_), ListSortDirection.Ascending)

        If msLocalizar IsNot Nothing Then LPLocalizaRegistro(msLocalizar)

        msTabla = loDataTable.TableName
        miCantidad = loDataTable.Rows.Count
        loCN.Desconectar()
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
                Dim loMoneda As New Ea010monedas
                loMoneda.codMoneda = loFK.codMoneda
                If loMoneda.GetPK = sOk_ Then
                    msDecimales = loMoneda.decimales.ToString
                    msCulture = loMoneda.culture
                End If
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
            If row.Cells(sCodigo2_).Value.ToString = psCodigo Then
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
            GFsAvisar("Debe ingresar codigo de empresa valido", sMENSAJE_, "Por favor intentelo de nuevo.")
            txtCodEmpresa_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        If Not IsNumeric(txtCodEmpresa_NE.Text) Then
            txtCodEmpresa_NE.Text = "0"
            e.Cancel = True
            Exit Sub
        End If
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)

        Dim loFK As New Ec001empresas
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

    Private Sub cmbTipoPerfil_Validating(sender As Object, e As CancelEventArgs) Handles cmbTipoPerfil.Validating
        If cmbTipoPerfil.Text.Trim.Length = 0 Then
            cmbTipoPerfil.Text = cmbTipoPerfil.Items(0).ToString
            e.Cancel = True
            Exit Sub
        End If
        If Not cmbTipoPerfil.Items.Contains(cmbTipoPerfil.Text) Then
            e.Cancel = True
            Exit Sub
        End If
        LPCargarDatos()
    End Sub

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Eb060perautgest
        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDatos.tipoPerfil = cmbTipoPerfil.Text
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                moFormulario = New frmFb060perautgest
                moFormulario.Tag = CType(sender, Button).AccessibleName
                moFormulario.entidad = loDatos
                GPCargar(moFormulario)
                msLocalizar = moFormulario.AccessibleName
                moFormulario = Nothing
            Case Else
                If DataGridView1.CurrentRow Is Nothing Then Exit Sub
                '---------------------------------------------------------------------------------------------
                Dim lsCodigo As String = DataGridView1.Item(sCodigo2_, DataGridView1.CurrentRow.Index).Value.ToString
                If lsCodigo.Trim.Length = 0 Then Exit Sub

                Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                If lsTablaHash.Trim.Length = 0 Then Exit Sub

                '---------------------------------------------------------------------------------------------
                Dim lsParte() As String = lsTablaHash.Split(sSF_)
                If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                Try
                    loDatos.tipoDocumento = DataGridView1.Item(sCodigo1_, DataGridView1.CurrentRow.Index).Value.ToString
                    loDatos.nroDocumento = lsCodigo
                    If loDatos.GetPK = sOk_ Then
                        If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                            entidad = loDatos
                            SendKeys.Send("%(s)")
                            Exit Sub
                        End If
                        moFormulario = New frmFb060perautgest
                        moFormulario.AccessibleName = "Empresa: " & loDatos.codEmpresa & ", Perfil: " & loDatos.tipoPerfil & ", Tipo Documento:" & loDatos.tipoDocumento & ", Numero:" & loDatos.nroDocumento
                        moFormulario.Tag = CType(sender, Button).AccessibleName
                        moFormulario.entidad = loDatos
                        GPCargar(moFormulario)
                        msLocalizar = moFormulario.AccessibleName
                        moFormulario = Nothing
                    End If
                Catch ex As Exception
                    GFsAvisar("Error en Browse", sError_, "No existe datos para Empresa [" & loDatos.codEmpresa.ToString & "], Perfil [" & loDatos.tipoPerfil & "], Tipo Documento [" & loDatos.tipoDocumento & ", Nro. Documento [" & loDatos.nroDocumento & ControlChars.CrLf & ex.Message)
                End Try
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
        LPCargarDatos()
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        Dim lsCodigo As String = DataGridView1.Item(sCodigo2_, DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length = 0 Then Exit Sub

        Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
        GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
            If psCodigo.Trim.Length > 0 Then
                Dim loDatos As New Eb060perautgest
                loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                loDatos.tipoPerfil = cmbTipoPerfil.Text
                loDatos.tipoDocumento = DataGridView1.Item(sCodigo1_, DataGridView1.CurrentRow.Index).Value.ToString
                loDatos.nroDocumento = psCodigo
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
        If GFsPuedeUsar(Me.Name & ":Importar->Texto delimitado", "Permite importar el contenido de " & Me.Name & " a la tabla CONCEPTOS") = sSi_ Then
            Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
            GPImportarConceptos(liCodEmpresa)
        End If

    End Sub

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LPHabilitaControles()
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
        Dim loColumna1 As DataGridViewColumn = DataGridView1.Columns.Item("limite_credito")
        Dim lsDecimales As String = DataGridView1.Item("decimales", e.RowIndex).Value.ToString
        Dim lsCulture As String = DataGridView1.Item("culture", e.RowIndex).Value.ToString

        If e.ColumnIndex = loColumna1.Index Then
            If Decimal.Parse(e.Value.ToString) = 0.00D Then
                e.Value = ""
            Else
                e.Value = CDec(e.Value).ToString(sFormatC_ & lsDecimales, CultureInfo.CreateSpecificCulture(lsCulture))
            End If
            e.FormattingApplied = True
        End If

    End Sub

    Private Sub LPInicializaParametros()
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String = ""
        Dim lsValor As String = ""
        Dim lsCodigo As String = ""

        lsClave = "b060perautgest.tipoperfil"
        lsValor = "CLIENTES" & sSF_ & "PROVEEDORES"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsCodigo)
        End If
        cmbTipoPerfil.Items.Clear()
        For Each lsValor In lsCodigo.Split(sSF_)
            cmbTipoPerfil.Items.Add(lsValor)
        Next
    End Sub
End Class