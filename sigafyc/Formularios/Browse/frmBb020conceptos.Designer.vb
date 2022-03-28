<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBb020conceptos : Inherits frmBrowseSinGrid

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
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mnuContextual = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextualItem_ExportarExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextualItem_ExportarTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextualItem_ImportarTexto = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuContextual.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 42)
        Me.txtBuscar.TabIndex = 8
        '
        'btnSalir
        '
        Me.btnSalir.TabIndex = 7
        '
        'btnAuditoria
        '
        Me.btnAuditoria.TabIndex = 6
        '
        'btnConsultar
        '
        Me.btnConsultar.TabIndex = 5
        '
        'btnBorrar
        '
        Me.btnBorrar.TabIndex = 4
        '
        'btnModificar
        '
        Me.btnModificar.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.TabIndex = 2
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(177, 9)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(182, 20)
        Me.lblNombreEmpresa.TabIndex = 33
        Me.lblNombreEmpresa.Text = "<nombre del usuario>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(97, 7)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(74, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Empresa:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(851, 575)
        Me.DataGridView1.TabIndex = 1
        '
        'mnuContextual
        '
        Me.mnuContextual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextualItem_ExportarExcel, Me.ContextualItem_ExportarTexto, Me.ContextualItem_ImportarTexto})
        Me.mnuContextual.Name = "mnuContextual"
        Me.mnuContextual.Size = New System.Drawing.Size(244, 70)
        '
        'ContextualItem_ExportarExcel
        '
        Me.ContextualItem_ExportarExcel.Name = "ContextualItem_ExportarExcel"
        Me.ContextualItem_ExportarExcel.Size = New System.Drawing.Size(243, 22)
        Me.ContextualItem_ExportarExcel.Text = "Exportar a Excel"
        '
        'ContextualItem_ExportarTexto
        '
        Me.ContextualItem_ExportarTexto.Name = "ContextualItem_ExportarTexto"
        Me.ContextualItem_ExportarTexto.Size = New System.Drawing.Size(243, 22)
        Me.ContextualItem_ExportarTexto.Text = "Exportar a Texto delimitado"
        '
        'ContextualItem_ImportarTexto
        '
        Me.ContextualItem_ImportarTexto.Name = "ContextualItem_ImportarTexto"
        Me.ContextualItem_ImportarTexto.Size = New System.Drawing.Size(243, 22)
        Me.ContextualItem_ImportarTexto.Text = "Importar desde texto delimitado"
        '
        'frmBb020conceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 660)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblNombreEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmBb020conceptos"
        Me.Tag = ""
        Me.Text = "Browse de Conceptos"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodEmpresa_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNombreEmpresa, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuContextual.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mnuContextual As ContextMenuStrip
    Friend WithEvents ContextualItem_ExportarExcel As ToolStripMenuItem
    Friend WithEvents ContextualItem_ExportarTexto As ToolStripMenuItem
    Friend WithEvents ContextualItem_ImportarTexto As ToolStripMenuItem
End Class
