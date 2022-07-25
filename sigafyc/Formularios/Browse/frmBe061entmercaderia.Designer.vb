<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBe061entmercaderia
    Inherits frmBrowseSinGrid

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.lblNomProveedor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblNomDeposito = New System.Windows.Forms.Label()
        Me.txtNumTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFecOperacion = New System.Windows.Forms.Label()
        Me.lblFecVigencia = New System.Windows.Forms.Label()
        Me.lblOrgTransaccion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblGastNeto = New System.Windows.Forms.Label()
        Me.lblCompNeta = New System.Windows.Forms.Label()
        Me.lblTotGeneral = New System.Windows.Forms.Label()
        Me.lblTotGeneralImp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblGastNetoImp = New System.Windows.Forms.Label()
        Me.lblCompNetaImp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 179)
        Me.txtBuscar.Size = New System.Drawing.Size(966, 22)
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(982, 569)
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Location = New System.Drawing.Point(982, 482)
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(982, 275)
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(982, 188)
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(982, 101)
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(982, 14)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 207)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(966, 379)
        Me.DataGridView1.TabIndex = 25
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Navy
        Me.lblDocumento.Location = New System.Drawing.Point(455, 132)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(125, 16)
        Me.lblDocumento.TabIndex = 223
        Me.lblDocumento.Text = "<tipo>: <numero>"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacion.ForeColor = System.Drawing.Color.Navy
        Me.lblIdentificacion.Location = New System.Drawing.Point(455, 112)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(166, 16)
        Me.lblIdentificacion.TabIndex = 222
        Me.lblIdentificacion.Text = "<doc>: <identificacion>"
        '
        'lblNomProveedor
        '
        Me.lblNomProveedor.AutoSize = True
        Me.lblNomProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblNomProveedor.Location = New System.Drawing.Point(455, 92)
        Me.lblNomProveedor.Name = "lblNomProveedor"
        Me.lblNomProveedor.Size = New System.Drawing.Size(192, 16)
        Me.lblNomProveedor.TabIndex = 221
        Me.lblNomProveedor.Text = "<razon_social_proveedor>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Origen Trans. No.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 219
        Me.Label10.Text = "Vigencia:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 218
        Me.Label13.Text = "Operación:"
        '
        'lblNomDeposito
        '
        Me.lblNomDeposito.AutoSize = True
        Me.lblNomDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomDeposito.ForeColor = System.Drawing.Color.Navy
        Me.lblNomDeposito.Location = New System.Drawing.Point(14, 70)
        Me.lblNomDeposito.Name = "lblNomDeposito"
        Me.lblNomDeposito.Size = New System.Drawing.Size(159, 18)
        Me.lblNomDeposito.TabIndex = 217
        Me.lblNomDeposito.Text = "<nombre_deposito>"
        '
        'txtNumTransaccion_NE
        '
        Me.txtNumTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTransaccion_NE.Location = New System.Drawing.Point(165, 38)
        Me.txtNumTransaccion_NE.Name = "txtNumTransaccion_NE"
        Me.txtNumTransaccion_NE.Size = New System.Drawing.Size(86, 24)
        Me.txtNumTransaccion_NE.TabIndex = 208
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Transacción No.:"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(257, 10)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(159, 18)
        Me.lblNomEmpresa.TabIndex = 214
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(165, 8)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(86, 24)
        Me.txtCodEmpresa_NE.TabIndex = 207
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "Empresa:"
        '
        'lblFecOperacion
        '
        Me.lblFecOperacion.AutoSize = True
        Me.lblFecOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecOperacion.ForeColor = System.Drawing.Color.Navy
        Me.lblFecOperacion.Location = New System.Drawing.Point(162, 100)
        Me.lblFecOperacion.Name = "lblFecOperacion"
        Me.lblFecOperacion.Size = New System.Drawing.Size(153, 18)
        Me.lblFecOperacion.TabIndex = 224
        Me.lblFecOperacion.Text = "<fecha_operacion>"
        '
        'lblFecVigencia
        '
        Me.lblFecVigencia.AutoSize = True
        Me.lblFecVigencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecVigencia.ForeColor = System.Drawing.Color.Navy
        Me.lblFecVigencia.Location = New System.Drawing.Point(162, 130)
        Me.lblFecVigencia.Name = "lblFecVigencia"
        Me.lblFecVigencia.Size = New System.Drawing.Size(139, 18)
        Me.lblFecVigencia.TabIndex = 225
        Me.lblFecVigencia.Text = "<fecha_vigencia>"
        '
        'lblOrgTransaccion
        '
        Me.lblOrgTransaccion.AutoSize = True
        Me.lblOrgTransaccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrgTransaccion.ForeColor = System.Drawing.Color.Navy
        Me.lblOrgTransaccion.Location = New System.Drawing.Point(162, 158)
        Me.lblOrgTransaccion.Name = "lblOrgTransaccion"
        Me.lblOrgTransaccion.Size = New System.Drawing.Size(172, 18)
        Me.lblOrgTransaccion.TabIndex = 226
        Me.lblOrgTransaccion.Text = "<transaccion_origen>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 16)
        Me.Label3.TabIndex = 227
        Me.Label3.Text = "Datos del proveedor/documento:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(214, 610)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 20)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "Totales netos:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGastNeto
        '
        Me.lblGastNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastNeto.ForeColor = System.Drawing.Color.Navy
        Me.lblGastNeto.Location = New System.Drawing.Point(596, 610)
        Me.lblGastNeto.Name = "lblGastNeto"
        Me.lblGastNeto.Size = New System.Drawing.Size(187, 20)
        Me.lblGastNeto.TabIndex = 229
        Me.lblGastNeto.Text = "Gravada10%"
        Me.lblGastNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompNeta
        '
        Me.lblCompNeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompNeta.ForeColor = System.Drawing.Color.Navy
        Me.lblCompNeta.Location = New System.Drawing.Point(403, 610)
        Me.lblCompNeta.Name = "lblCompNeta"
        Me.lblCompNeta.Size = New System.Drawing.Size(187, 20)
        Me.lblCompNeta.TabIndex = 228
        Me.lblCompNeta.Text = "Gravada5%"
        Me.lblCompNeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotGeneral
        '
        Me.lblTotGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGeneral.ForeColor = System.Drawing.Color.Navy
        Me.lblTotGeneral.Location = New System.Drawing.Point(789, 609)
        Me.lblTotGeneral.Name = "lblTotGeneral"
        Me.lblTotGeneral.Size = New System.Drawing.Size(187, 20)
        Me.lblTotGeneral.TabIndex = 231
        Me.lblTotGeneral.Text = "Gravada10%"
        Me.lblTotGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotGeneralImp
        '
        Me.lblTotGeneralImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGeneralImp.ForeColor = System.Drawing.Color.Navy
        Me.lblTotGeneralImp.Location = New System.Drawing.Point(789, 629)
        Me.lblTotGeneralImp.Name = "lblTotGeneralImp"
        Me.lblTotGeneralImp.Size = New System.Drawing.Size(187, 20)
        Me.lblTotGeneralImp.TabIndex = 235
        Me.lblTotGeneralImp.Text = "Gravada10%"
        Me.lblTotGeneralImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(214, 630)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 20)
        Me.Label6.TabIndex = 234
        Me.Label6.Text = "Totales c/Impuestos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGastNetoImp
        '
        Me.lblGastNetoImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastNetoImp.ForeColor = System.Drawing.Color.Navy
        Me.lblGastNetoImp.Location = New System.Drawing.Point(596, 630)
        Me.lblGastNetoImp.Name = "lblGastNetoImp"
        Me.lblGastNetoImp.Size = New System.Drawing.Size(187, 20)
        Me.lblGastNetoImp.TabIndex = 233
        Me.lblGastNetoImp.Text = "Gravada10%"
        Me.lblGastNetoImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompNetaImp
        '
        Me.lblCompNetaImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompNetaImp.ForeColor = System.Drawing.Color.Navy
        Me.lblCompNetaImp.Location = New System.Drawing.Point(403, 630)
        Me.lblCompNetaImp.Name = "lblCompNetaImp"
        Me.lblCompNetaImp.Size = New System.Drawing.Size(187, 20)
        Me.lblCompNetaImp.TabIndex = 232
        Me.lblCompNetaImp.Text = "Gravada5%"
        Me.lblCompNetaImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(789, 589)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 14)
        Me.Label5.TabIndex = 238
        Me.Label5.Text = "General"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(596, 589)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 14)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "Gastos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(407, 589)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 14)
        Me.Label9.TabIndex = 236
        Me.Label9.Text = "Compras"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmBe061entmercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 660)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotGeneralImp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblGastNetoImp)
        Me.Controls.Add(Me.lblCompNetaImp)
        Me.Controls.Add(Me.lblTotGeneral)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblGastNeto)
        Me.Controls.Add(Me.lblCompNeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOrgTransaccion)
        Me.Controls.Add(Me.lblFecVigencia)
        Me.Controls.Add(Me.lblFecOperacion)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.lblNomProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblNomDeposito)
        Me.Controls.Add(Me.txtNumTransaccion_NE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNomEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmBe061entmercaderia"
        Me.Tag = ""
        Me.Text = "Browse detalle entrada y costeo mercaderia"
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtCodEmpresa_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomEmpresa, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNumTransaccion_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomDeposito, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblNomProveedor, 0)
        Me.Controls.SetChildIndex(Me.lblIdentificacion, 0)
        Me.Controls.SetChildIndex(Me.lblDocumento, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.lblFecOperacion, 0)
        Me.Controls.SetChildIndex(Me.lblFecVigencia, 0)
        Me.Controls.SetChildIndex(Me.lblOrgTransaccion, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblCompNeta, 0)
        Me.Controls.SetChildIndex(Me.lblGastNeto, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.lblTotGeneral, 0)
        Me.Controls.SetChildIndex(Me.lblCompNetaImp, 0)
        Me.Controls.SetChildIndex(Me.lblGastNetoImp, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.lblTotGeneralImp, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents lblNomProveedor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblNomDeposito As Label
    Friend WithEvents txtNumTransaccion_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFecOperacion As Label
    Friend WithEvents lblFecVigencia As Label
    Friend WithEvents lblOrgTransaccion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblGastNeto As Label
    Friend WithEvents lblCompNeta As Label
    Friend WithEvents lblTotGeneral As Label
    Friend WithEvents lblTotGeneralImp As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblGastNetoImp As Label
    Friend WithEvents lblCompNetaImp As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
