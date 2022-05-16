Imports System.ComponentModel
Imports System.Globalization

Public Class frmBe010asientoscabeceras
    Private Delegate Sub Buscar()
    Private moFormulario As frmFe010asientoscabeceras
    Private moFormulario2 As frmFd010asientosdetalles
    Private msTabla As String = ""
    Private msPk_Hash As String = ""
    Private mbEntro As Boolean = True
    Private mbAgregar As Boolean
    Private mbModificar As Boolean
    Private mbBorrar As Boolean
    Private mbImprimir As Boolean
    Private mbConsultar As Boolean
    Private mbAuditoria As Boolean
    Private msLocalizar1 As String = ""
    Private msLocalizar2 As String = ""
    Private msCodigo As String = "asiento"
    Private msCodigo2 As String = "orden"
    Private miCantidad2 As Integer = 0

    Private miCodEmpresa As Integer = 0
    Private miNroAsiento As Integer = 0
    Private msCodMoneda As String = ""
    Private msCulture As String = ""
    Private msDecimales As String = ""
    Private Shared mbabrirform As Boolean = False

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles Me.Load
        LPInicializaDataGridView()
        LPInicializaMaxLength()
        LPInicializaBotones()
        LPInicializaEventos()

        If Me.Tag.ToString = sELEGIR_ Then
            If Me.Name <> "frmBa010monedas" Then
                Dim lofrmBase As New frmBa010monedas
                txtBuscar.Width = lofrmBase.txtBuscar.Width
                DataGridView1.Size = lofrmBase.DataGridView1.Size
                DataGridView2.Size = DataGridView1.Size
                btnAgregar.Location = lofrmBase.btnAgregar.Location
                btnModificar.Location = lofrmBase.btnModificar.Location
                btnBorrar.Location = lofrmBase.btnBorrar.Location
                btnConsultar.Location = lofrmBase.btnConsultar.Location
                btnAuditoria.Location = lofrmBase.btnAuditoria.Location
                btnSalir.Location = lofrmBase.btnSalir.Location
                Me.Size = lofrmBase.Size
                lofrmBase = Nothing
            End If
        End If
        lblNombreEmpresa.Text = ""
        mbabrirform = False
    End Sub

    Private Sub BuscarClave(sender As Object, e As EventArgs)
        Dim loBuscarClave As Buscar
        If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
            loBuscarClave = AddressOf BuscarCabecera
        Else
            loBuscarClave = AddressOf BuscarDetalle
        End If
        loBuscarClave.Invoke
    End Sub

    Private Sub BuscarCabecera()
        LPCargarCabecera()
    End Sub

    Private Sub BuscarDetalle()
        LPCargarDetalles()
    End Sub

    Private Sub LPCargarCabecera()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub

        Dim lsSQL As String
        Dim loDatos As New Ee010asientoscabeceras
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "e010.nroasiento, e010.fecha, b070.abreviado, c020.abreviado, e010.nrodocumento, e010.codmoneda_o, e010.concepto"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
            msLocalizar1 = ""
        End If
        lsSQL = GFsGeneraSQL("frmBe010asientoscabeceras")
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        loDataSet = loDatos.RecuperarTabla(lsSQL)
        DataGridView1.DataSource = loDataSet
        DataGridView1.DataMember = loDatos.tableName

        DataGridView1.Columns.Item("codempresa").Visible = False
        DataGridView1.Sort(DataGridView1.Columns(msCodigo), ListSortDirection.Ascending)
        If msLocalizar1 IsNot Nothing Then LPLocalizaCabecera(msLocalizar1)

        msTabla = loDatos.tableName
        miCantidad = loDataSet.Tables.Item(0).Rows.Count
        loDataSet = Nothing
        loDatos.CerrarConexion()
        loDatos = Nothing
        LPSinRegistro_AbrirForm()
        LPHabilitaControles2()
    End Sub

    Private Sub LPCargarDetalles()
        If txtCodEmpresa_NE.Text.Trim.Length = 0 Then Exit Sub
        If DataGridView1.CurrentRow Is Nothing Then Exit Sub

        Dim lsSQL As String
        Dim loDatos As New Ed010asientosdetalles
        Dim loDataSet As DataSet
        Dim lsCamposConcat As String = "d010.nrosecuencia, d010.codcuenta, b050.nombre, d010.concepto"
        Dim lsConcatFiltro As String = lsCamposConcat
        Dim lsFiltro As String = sFiltroSentencia_
        lsFiltro = lsFiltro.Replace(sFiltroCampo_, lsConcatFiltro)
        If txtBuscar.Text = txtBuscar.Tag.ToString Then
            lsFiltro = lsFiltro.Replace(sFiltroValor_, "")
        Else
            lsFiltro = lsFiltro.Replace(sFiltroValor_, txtBuscar.Text)
            msLocalizar2 = ""
        End If
        'lsSQL = loDatos.GenerarSQL(lsCampos, lsFiltro, lsWhere)
        lsSQL = GFsGeneraSQL("frmBe010asientoscabeceras_Detalle")
        lsSQL = lsSQL.Replace("@filtro", lsFiltro)
        miCodEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        miNroAsiento = Integer.Parse(DataGridView1.Item(msCodigo, DataGridView1.CurrentRow.Index).Value.ToString)
        TabControl1.TabPages.Item(1).Text = "Detalle movimientos Asiento No." & miNroAsiento.ToString
        TabControl1.TabPages.Item(1).Refresh()
        msCodMoneda = DataGridView1.Item("moneda", DataGridView1.CurrentRow.Index).Value.ToString
        loDatos.codEmpresa = miCodEmpresa
        loDatos.nroAsiento = miNroAsiento
        loDataSet = loDatos.RecuperarTabla(lsSQL)

        DataGridView2.DataSource = loDataSet
        DataGridView2.DataMember = loDatos.tableName

        DataGridView2.Columns.Item("debito").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        DataGridView2.Columns.Item("credito").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight

        DataGridView2.Columns.Item("debito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Columns.Item("credito").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DataGridView2.Columns.Item("debito").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView2.Columns.Item("credito").SortMode = DataGridViewColumnSortMode.NotSortable

        DataGridView2.Columns.Item("codempresa").Visible = False
        DataGridView2.Columns.Item("nroasiento").Visible = False
        DataGridView2.Columns.Item("movimiento").Visible = False

        DataGridView2.Sort(DataGridView2.Columns(msCodigo2), ListSortDirection.Ascending)
        If msLocalizar2 IsNot Nothing Then LPLocalizaDetalle(msLocalizar2)

        msTabla = loDatos.tableName
        miCantidad2 = loDataSet.Tables.Item(0).Rows.Count
        loDataSet = Nothing
        loDatos.CerrarConexion()
        loDatos = Nothing
        Dim loFK As New Ea010monedas
        loFK.codMoneda = msCodMoneda
        If loFK.GetPK = sOk_ Then
            msCulture = loFK.culture
            msDecimales = loFK.decimales.ToString
        End If
        loFK.CerrarConexion()
        loFK = Nothing

        Dim loFK1 As New Ee010asientoscabeceras
        loFK1.codEmpresa = miCodEmpresa
        loFK1.nroAsiento = miNroAsiento
        If loFK1.GetPK = sOk_ Then
            Dim lsCulture As String = ""
            Dim lsDecimales As String = ""
            Dim loFK2 As New Ea010monedas
            loFK2.codMoneda = loFK1.codMoneda_o
            If loFK2.GetPK = sOk_ Then
                lsCulture = loFK2.culture
                lsDecimales = loFK2.decimales.ToString
            End If
            lblTotalDebitos.Text = loFK1.debito_o.ToString(sFormatC_ & lsDecimales, CultureInfo.CreateSpecificCulture(lsCulture))
            lblTotalCreditos.Text = loFK1.credito_o.ToString(sFormatC_ & lsDecimales, CultureInfo.CreateSpecificCulture(lsCulture))
            loFK2.CerrarConexion()
            loFK2 = Nothing
        End If
        loFK1.CerrarConexion()
        loFK1 = Nothing

        LPSinRegistro_AbrirForm()
        LPHabilitaControles2()
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

    Private Sub LPLocalizaCabecera(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub
        If IsNumeric(psCodigo) = False Then Exit Sub
        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim liCodigo As Integer = Integer.Parse(psCodigo)
            If Integer.Parse(row.Cells(msCodigo).Value.ToString) = liCodigo Then
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
            DataGridView1.CurrentCell = DataGridView1.Rows(liIndex).Cells(msCodigo)
            LPVerificarCargarDetalles()
        End If
    End Sub

    Private Sub LPLocalizaDetalle(ByVal psCodigo As String)
        ' Este procedimiento realiza la busqueda del parametro
        ' a fin de ubicarlo dentro del DataGridView
        '--------------------------------------------------------------------
        If psCodigo.Trim.Length = 0 Then Exit Sub
        If IsNumeric(psCodigo) = False Then Exit Sub
        Dim liIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim liCodigo As Integer = Integer.Parse(psCodigo)
            If Integer.Parse(row.Cells(msCodigo2).Value.ToString) = liCodigo Then
                DataGridView2.ClearSelection()
                ' Aqui se selecciona la fila que contiene el codigo buscado
                DataGridView2.Rows(row.Index).Selected = True
                liIndex = row.Index
                Exit For
            End If
        Next
        ' Aqui es donde se mueve el DataGridView para que se pueda visualizar 
        ' la fila seleccionada.
        If liIndex > -1 Then
            DataGridView2.CurrentCell = DataGridView2.Rows(liIndex).Cells(0)
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
        Else
            If loFK.periodoInicio.Trim.Length = 0 Then
                GFsAvisar("La empresa:" & loFK.nombre & ", aun no tiene definido su periodo fiscal.", sMENSAJE_, "Debe realizar esta parametrización para poder ingresar asientos.")
                e.Cancel = True
                Exit Sub
            End If
        End If
        loFK.CerrarConexion()
        loFK = Nothing

        If GFsPuedeUsar("Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength), "Puede gestionar la Empresa No." & liCodEmpresa.ToString(sFormatD_ & txtCodEmpresa_NE.MaxLength)) <> sSi_ Then
            e.Cancel = True
            Exit Sub
        End If
        LPDespliegaDescripciones()
        LPCargarCabecera()
        LPVerificarCargarDetalles()
    End Sub

    Private Sub Botones_Click(sender As Object, e As EventArgs)
        Dim loDatos As New Ee010asientoscabeceras
        Dim loDatos2 As New Ed010asientosdetalles
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNroAsiento As Integer = 0
        loDatos.codEmpresa = liCodEmpresa
        loDatos2.codEmpresa = liCodEmpresa
        If DataGridView1.CurrentRow IsNot Nothing Then
            liNroAsiento = Integer.Parse(DataGridView1.Item(msCodigo, DataGridView1.CurrentRow.Index).Value.ToString)
            loDatos.nroAsiento = liNroAsiento
            loDatos2.nroAsiento = liNroAsiento
        End If
        Select Case CType(sender, Button).AccessibleName
            Case sAGREGAR_
                If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
                    moFormulario = New frmFe010asientoscabeceras
                    moFormulario.Tag = CType(sender, Button).AccessibleName
                    moFormulario.entidad = loDatos
                    GPCargar(moFormulario)
                    '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                    '-->  esto será usado para realizar la localización del registro en el DataGridView
                    msLocalizar1 = moFormulario.AccessibleName
                    moFormulario = Nothing
                Else
                    moFormulario2 = New frmFd010asientosdetalles
                    If loDatos.GetPK = sOk_ Then
                        moFormulario2.entidadCabecera = loDatos
                    End If
                    moFormulario2.Tag = CType(sender, Button).AccessibleName
                    moFormulario2.entidad = loDatos2
                    GPCargar(moFormulario2)
                    '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                    '-->  esto será usado para realizar la localización del registro en el DataGridView
                    msLocalizar2 = moFormulario2.AccessibleName
                    moFormulario2 = Nothing
                End If
            Case Else
                If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
                    If DataGridView1.CurrentRow Is Nothing Then Exit Sub
                    '---------------------------------------------------------------------------------------------
                    Dim lsCodigo As String = DataGridView1.Item(msCodigo, DataGridView1.CurrentRow.Index).Value.ToString
                    If lsCodigo.Trim.Length = 0 Then Exit Sub

                    Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                    If lsTablaHash.Trim.Length = 0 Then Exit Sub

                    '---------------------------------------------------------------------------------------------
                    Dim lsParte() As String = lsTablaHash.Split(sSF_)
                    If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                    If CType(sender, Button).AccessibleName <> sCONSULTAR_ Then
                        If GFsTieneMovimientos(liCodEmpresa, liNroAsiento) = sSi_ Then
                            GFsAvisar("El asiento No. " & liNroAsiento & ", tiene movimientos vinculados", sMENSAJE_, "Por lo cual no podrá " & CType(sender, Button).AccessibleName & "LO.")
                            Exit Sub
                        End If
                    End If
                    Try
                        loDatos.nroAsiento = Integer.Parse(lsCodigo)
                        If loDatos.GetPK = sOk_ Then
                            If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                                entidad = loDatos
                                SendKeys.Send("%(s)")
                                Exit Sub
                            End If
                            moFormulario = New frmFe010asientoscabeceras
                            moFormulario.AccessibleName = "Empresa: " & loDatos.codEmpresa & ", Asiento No.: " & loDatos.nroAsiento
                            moFormulario.Tag = CType(sender, Button).AccessibleName
                            moFormulario.entidad = loDatos
                            GPCargar(moFormulario)
                            '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                            '-->  esto será usado para realizar la localización del registro en el DataGridView
                            msLocalizar1 = moFormulario.AccessibleName
                            moFormulario = Nothing
                        End If
                    Catch ex As Exception
                        GFsAvisar("Error en Browse", sError_, "No existe datos para Asiento No. [" & loDatos.nroAsiento & "], Empresa [" & loDatos.codEmpresa & "]" & ControlChars.CrLf & ex.Message)
                    End Try
                Else
                    If DataGridView2.CurrentRow Is Nothing Then Exit Sub
                    '---------------------------------------------------------------------------------------------
                    Dim lsCodigo As String = DataGridView2.Item(msCodigo2, DataGridView2.CurrentRow.Index).Value.ToString
                    If lsCodigo.Trim.Length = 0 Then Exit Sub

                    Dim lsTablaHash As String = LFsTablaHashPk(lsCodigo)
                    If lsTablaHash.Trim.Length = 0 Then Exit Sub

                    '---------------------------------------------------------------------------------------------
                    Dim lsParte() As String = lsTablaHash.Split(sSF_)
                    If GFbPuedeModificarBorrar(CType(sender, Button).AccessibleName, lsParte(0), lsParte(1), lsCodigo) = False Then Exit Sub
                    Try
                        loDatos2.nroSecuencia = Integer.Parse(lsCodigo)
                        If loDatos2.GetPK = sOk_ Then
                            If Me.Tag.ToString = sELEGIR_ And CType(sender, Button).AccessibleName = sCONSULTAR_ Then
                                entidad = loDatos
                                SendKeys.Send("%(s)")
                                Exit Sub
                            End If
                            moFormulario2 = New frmFd010asientosdetalles
                            If loDatos.GetPK = sOk_ Then
                                moFormulario2.entidadCabecera = loDatos
                            End If
                            moFormulario2.AccessibleName = "Empresa: " & loDatos2.codEmpresa & ", Asiento No.: " & loDatos2.nroAsiento & ", Secuencia: " & loDatos2.nroSecuencia
                            moFormulario2.Tag = CType(sender, Button).AccessibleName
                            moFormulario2.entidad = loDatos2
                            GPCargar(moFormulario2)
                            '-->  moFormulario.AccesibleName debe asignarse con el codigo en el formulario de carga
                            '-->  esto será usado para realizar la localización del registro en el DataGridView
                            msLocalizar2 = moFormulario2.AccessibleName
                            moFormulario2 = Nothing
                        End If
                    Catch ex As Exception
                        GFsAvisar("Error en Browse", sError_, "No existe datos para Asiento No. [" & loDatos2.nroAsiento & "/" & loDatos2.nroSecuencia & "], Empresa [" & loDatos2.codEmpresa & "]" & ControlChars.CrLf & ex.Message)
                    End Try
                End If
        End Select
        loDatos.CerrarConexion()
        loDatos = Nothing
        If TabControl1.SelectedTab.TabIndex = 0 Then
            LPCargarCabecera()
        Else
            LPCargarDetalles()
        End If
    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click
        If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
            Dim lsCodigo As String = DataGridView1.Item(msCodigo, DataGridView1.CurrentRow.Index).Value.ToString
            If lsCodigo.Trim.Length = 0 Then Exit Sub

            Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
            GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
        Else
            Dim lsCodigo As String = DataGridView2.Item(msCodigo2, DataGridView2.CurrentRow.Index).Value.ToString
            If lsCodigo.Trim.Length = 0 Then Exit Sub

            Dim lsTablaHash() As String = LFsTablaHashPk(lsCodigo).Split(sSF_)
            GPDespliegaBitacoraDatos(lsTablaHash(0), lsTablaHash(1))
        End If
    End Sub

    Private Function LFsTablaHashPk(ByVal psCodigo As String) As String
        Dim lsResultado As String = ""
        If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
            If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
                If psCodigo.Trim.Length > 0 Then
                    Dim loDatos As New Ee010asientoscabeceras
                    loDatos.codEmpresa = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    loDatos.nroAsiento = Integer.Parse(psCodigo)
                    Try
                        If loDatos.GetPK(sSi_) = sOk_ Then
                            lsResultado = loDatos.tableName & sSF_ & loDatos.hash_Pk
                        End If
                    Catch ex As Exception
                        GFsAvisar("LFsTablaHashPk.Ee010asientoscabeceras", sError_, ex.Message)
                    End Try
                End If
            End If
        Else
            If txtCodEmpresa_NE.Text.Trim.Length > 0 Then
                If psCodigo.Trim.Length > 0 Then
                    Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
                    Dim liNroAsiento As Integer = Integer.Parse(DataGridView2.Item("nroasiento", DataGridView2.CurrentRow.Index).Value.ToString)
                    Dim loDatos2 As New Ed010asientosdetalles
                    loDatos2.codEmpresa = liCodEmpresa
                    loDatos2.nroAsiento = liNroAsiento
                    loDatos2.nroSecuencia = Integer.Parse(psCodigo)
                    Try
                        If loDatos2.GetPK(sSi_) = sOk_ Then
                            lsResultado = loDatos2.tableName & sSF_ & loDatos2.hash_Pk
                        End If
                    Catch ex As Exception
                        GFsAvisar("LFsTablaHashPk.Ed010asientosdetalles", sError_, ex.Message)
                    End Try
                End If
            End If

        End If
        Return lsResultado
    End Function

    Private Sub ExportarExcel_Click(sender As Object, e As EventArgs)
        If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
            If GFsPuedeUsar(Me.Name & "_Asiento" & ":Exportar->Excel", "Permite exportar el contenido de " & Me.Name & " a un archivo Excel") = sSi_ Then
                GPExportarGridToExcel(DataGridView1, Me.Name)
            End If
        Else
            If GFsPuedeUsar(Me.Name & "_Detalle" & ":Exportar->Excel", "Permite exportar el contenido de " & Me.Name & " a un archivo Excel") = sSi_ Then
                GPExportarGridToExcel(DataGridView2, Me.Name)
            End If
        End If
    End Sub

    Private Sub ExportarTexto_Click(sender As Object, e As EventArgs)
        If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
            If GFsPuedeUsar(Me.Name & "_Asiento" & ":Exportar->Texto delimitado", "Permite exportar el contenido de " & Me.Name & " a un archivo de texto delimitado") = sSi_ Then
                GPExportarGridToTexto(DataGridView1, Me.Name)
            End If
        Else
            If GFsPuedeUsar(Me.Name & "_Detalle" & ":Exportar->Texto delimitado", "Permite exportar el contenido de " & Me.Name & " a un archivo de texto delimitado") = sSi_ Then
                GPExportarGridToTexto(DataGridView2, Me.Name)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        LPVerificarCargarDetalles()
    End Sub

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LPHabilitaControles2()
        If mbEntro Then
            mbEntro = False
            txtCodEmpresa_NE.Focus()
        End If
        If TabControl1.SelectedTab.TabIndex = 0 Then
            If DataGridView1.CurrentRow IsNot Nothing Then
                LPVerificarCargarDetalles()
            End If
        End If

    End Sub

    Private Sub LPVerificarCargarDetalles()
        If DataGridView1.CurrentRow Is Nothing Then Exit Sub

        Dim lsCodigo As String = DataGridView1.Item(msCodigo, DataGridView1.CurrentRow.Index).Value.ToString
        If lsCodigo.Trim.Length > 0 Then
            msLocalizar1 = lsCodigo
            LPCargarDetalles()
        End If
    End Sub

    Private Sub LPHabilitaControles2()
        btnAgregar.Enabled = False
        btnBorrar.Enabled = False
        btnModificar.Enabled = False
        btnConsultar.Enabled = False
        btnImprimir.Enabled = False
        btnAuditoria.Enabled = False
        If TabControl1.TabPages.Item(TabControl1.SelectedIndex).Name = "TabPage1" Then
            If txtCodEmpresa_NE.Text <> "" Then
                If miCantidad <= 0 Then
                    btnAgregar.Enabled = mbAgregar
                Else
                    btnAgregar.Enabled = mbAgregar
                    btnBorrar.Enabled = mbBorrar
                    btnModificar.Enabled = mbModificar
                    btnConsultar.Enabled = mbConsultar
                    btnImprimir.Enabled = mbImprimir
                    btnAuditoria.Enabled = mbAuditoria
                End If
            End If
        Else
            If miCantidad2 <= 0 And txtCodEmpresa_NE.Text <> "" Then
                btnAgregar.Enabled = mbAgregar
            Else
                btnAgregar.Enabled = mbAgregar
                btnBorrar.Enabled = mbBorrar
                btnModificar.Enabled = mbModificar
                btnConsultar.Enabled = mbConsultar
                btnAuditoria.Enabled = mbAuditoria
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        LPHabilitaControles2()
    End Sub

    Private Sub LPInicializaDataGridView()
        DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Point)
        DataGridView1.AllowUserToResizeColumns = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.MultiSelect = False
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        LPSetDoubleBuffered(DataGridView1)

        DataGridView2.DefaultCellStyle.Font = New Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Point)
        DataGridView2.AllowUserToResizeColumns = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView2.MultiSelect = False
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.ReadOnly = True
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        LPSetDoubleBuffered(DataGridView2)
    End Sub

    Private Sub LPInicializaBotones()
        mbAgregar = btnAgregar.Enabled
        mbModificar = btnModificar.Enabled
        mbBorrar = btnBorrar.Enabled
        mbConsultar = btnConsultar.Enabled
        mbImprimir = btnImprimir.Enabled
        mbAuditoria = btnAuditoria.Enabled

        btnAgregar.AccessibleName = sAGREGAR_
        btnModificar.AccessibleName = sMODIFICAR_
        btnBorrar.AccessibleName = sBORRAR_
        btnConsultar.AccessibleName = sCONSULTAR_
    End Sub

    Private Sub LPInicializaEventos()
        AddHandler txtBuscar.TextChanged, AddressOf BuscarClave
        AddHandler btnAgregar.Click, AddressOf Botones_Click
        AddHandler btnModificar.Click, AddressOf Botones_Click
        AddHandler btnBorrar.Click, AddressOf Botones_Click
        AddHandler btnConsultar.Click, AddressOf Botones_Click
        AddHandler txtCodEmpresa_NE.KeyPress, AddressOf ManejoEvento_KeyPress
        AddHandler txtCodEmpresa_NE.KeyDown, AddressOf ManejoEvento_KeyDown

        AddHandler DataGridView1.KeyDown, AddressOf DataGrid_KeyDown
        AddHandler DataGridView1.CellContentDoubleClick, AddressOf DataGrid_DoubleClick
        AddHandler DataGridView2.KeyDown, AddressOf DataGrid_KeyDown
        AddHandler DataGridView2.CellContentDoubleClick, AddressOf DataGrid_DoubleClick

        DataGridView1.ContextMenuStrip = mnuExportarExcel
        DataGridView2.ContextMenuStrip = mnuExportarExcel
        AddHandler MenuItem_ExportarExcel.Click, AddressOf ExportarExcel_Click
        AddHandler MenuItem_ExportarTexto.Click, AddressOf ExportarTexto_Click
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim loRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim loCol As DataGridViewColumn = DataGridView1.Columns.Item("observacion")
        If e.ColumnIndex = loCol.Index Then
            If e.Value.ToString <> "" Then
                loRow.DefaultCellStyle.BackColor = Color.IndianRed
            Else
                loRow.DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        Dim loRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
        Dim loColDebito As DataGridViewColumn = DataGridView2.Columns.Item("debito")
        Dim loColCredito As DataGridViewColumn = DataGridView2.Columns.Item("credito")

        If e.ColumnIndex = loColDebito.Index Then
            If Decimal.Parse(e.Value.ToString) = 0.00D Then
                e.Value = ""
            Else
                e.Value = CDec(e.Value).ToString(sFormatC_ & msDecimales, CultureInfo.CreateSpecificCulture(msCulture))
                loRow.DefaultCellStyle.ForeColor = Color.RoyalBlue
            End If
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = loColCredito.Index Then
            If Decimal.Parse(e.Value.ToString) = 0.00D Then
                e.Value = ""
            Else
                e.Value = CDec(e.Value).ToString(sFormatC_ & msDecimales, CultureInfo.CreateSpecificCulture(msCulture))
                loRow.DefaultCellStyle.ForeColor = Color.IndianRed
            End If
            e.FormattingApplied = True
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim liCodEmpresa As Integer = Integer.Parse(txtCodEmpresa_NE.Text.ToString)
        Dim liNroAsiento As Integer = Integer.Parse(DataGridView1.Item(msCodigo, DataGridView1.CurrentRow.Index).Value.ToString)
        GRAsientoDiario(liCodEmpresa, 0, liNroAsiento, liNroAsiento)
    End Sub

    Private Sub btnImprimir_MouseMove(sender As Object, e As EventArgs) Handles btnImprimir.MouseMove
        btnImprimir.Image = My.Resources.Resources.icons8_color_print_48
        btnImprimir.Text = ""
    End Sub

    Private Sub btnImprimir_MouseLeave(sender As Object, e As EventArgs) Handles btnImprimir.MouseLeave, btnImprimir.LostFocus
        btnImprimir.Image = My.Resources.Resources.icons8_color_print_32
        btnImprimir.Text = btnImprimir.Tag.ToString
    End Sub

    Friend Sub LPSinRegistro_AbrirForm()
        If miCantidad = 0 Then
            If mbAbrirForm = False Then
                mbAbrirForm = True
                SendKeys.Send("%(a)")
            End If
        End If
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedTab.TabIndex = 0 Then
            LPCargarCabecera()
        Else
            LPCargarDetalles()
        End If
    End Sub
End Class