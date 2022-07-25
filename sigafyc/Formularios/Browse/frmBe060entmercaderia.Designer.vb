<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBe060entmercaderia
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomDeposito = New System.Windows.Forms.Label()
        Me.txtCodDeposito_NE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.mnuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetalleDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleDeGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesoDeCosteoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 76)
        Me.txtBuscar.Size = New System.Drawing.Size(1095, 22)
        Me.txtBuscar.TabIndex = 10
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1111, 569)
        Me.btnSalir.TabIndex = 8
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Location = New System.Drawing.Point(1111, 482)
        Me.btnAuditoria.TabIndex = 7
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(1111, 275)
        Me.btnConsultar.TabIndex = 5
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(1111, 188)
        Me.btnBorrar.TabIndex = 4
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(1111, 101)
        Me.btnModificar.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(1111, 14)
        Me.btnAgregar.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 104)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1095, 546)
        Me.DataGridView1.TabIndex = 9
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(203, 14)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(188, 20)
        Me.lblNomEmpresa.TabIndex = 140
        Me.lblNomEmpresa.Text = "<nombre de empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(123, 12)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(74, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Empresa:"
        '
        'lblNomDeposito
        '
        Me.lblNomDeposito.AutoSize = True
        Me.lblNomDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomDeposito.ForeColor = System.Drawing.Color.Navy
        Me.lblNomDeposito.Location = New System.Drawing.Point(203, 46)
        Me.lblNomDeposito.Name = "lblNomDeposito"
        Me.lblNomDeposito.Size = New System.Drawing.Size(168, 20)
        Me.lblNomDeposito.TabIndex = 143
        Me.lblNomDeposito.Text = "<nombre_deposito>"
        '
        'txtCodDeposito_NE
        '
        Me.txtCodDeposito_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDeposito_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDeposito_NE.Location = New System.Drawing.Point(123, 44)
        Me.txtCodDeposito_NE.Name = "txtCodDeposito_NE"
        Me.txtCodDeposito_NE.Size = New System.Drawing.Size(42, 26)
        Me.txtCodDeposito_NE.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Deposito No.:"
        '
        'btnDetalle
        '
        Me.btnDetalle.ContextMenuStrip = Me.mnuDetalle
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.Image = Global.sigafyc.My.Resources.Resources.icons8_details_32
        Me.btnDetalle.Location = New System.Drawing.Point(1111, 362)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(86, 81)
        Me.btnDetalle.TabIndex = 6
        Me.btnDetalle.Tag = "&detalle"
        Me.btnDetalle.Text = "&detalle"
        Me.btnDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'mnuDetalle
        '
        Me.mnuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalleDeComprasToolStripMenuItem, Me.DetalleDeGastosToolStripMenuItem, Me.ProcesoDeCosteoToolStripMenuItem})
        Me.mnuDetalle.Name = "mnuDetalle"
        Me.mnuDetalle.Size = New System.Drawing.Size(181, 92)
        '
        'DetalleDeComprasToolStripMenuItem
        '
        Me.DetalleDeComprasToolStripMenuItem.Name = "DetalleDeComprasToolStripMenuItem"
        Me.DetalleDeComprasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DetalleDeComprasToolStripMenuItem.Text = "Compras"
        '
        'DetalleDeGastosToolStripMenuItem
        '
        Me.DetalleDeGastosToolStripMenuItem.Name = "DetalleDeGastosToolStripMenuItem"
        Me.DetalleDeGastosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DetalleDeGastosToolStripMenuItem.Text = "Gastos"
        '
        'ProcesoDeCosteoToolStripMenuItem
        '
        Me.ProcesoDeCosteoToolStripMenuItem.Name = "ProcesoDeCosteoToolStripMenuItem"
        Me.ProcesoDeCosteoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProcesoDeCosteoToolStripMenuItem.Text = "Proceso de costeo"
        '
        'frmBe060entmercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 658)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.lblNomDeposito)
        Me.Controls.Add(Me.txtCodDeposito_NE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNomEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmBe060entmercaderia"
        Me.Tag = ""
        Me.Text = "Browse entrada y costeo de mercaderias"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodEmpresa_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomEmpresa, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtCodDeposito_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomDeposito, 0)
        Me.Controls.SetChildIndex(Me.btnDetalle, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomDeposito As Label
    Friend WithEvents txtCodDeposito_NE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDetalle As Button
    Friend WithEvents mnuDetalle As ContextMenuStrip
    Friend WithEvents DetalleDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalleDeGastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesoDeCosteoToolStripMenuItem As ToolStripMenuItem
End Class
