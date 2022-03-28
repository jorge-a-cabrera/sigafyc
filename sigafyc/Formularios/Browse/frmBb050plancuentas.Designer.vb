<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBb050plancuentas : Inherits frmBrowseSinGrid

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuExportar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItem_Exportar1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Exportar2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Importar1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuExportar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(10, 44)
        Me.txtBuscar.Size = New System.Drawing.Size(851, 19)
        Me.txtBuscar.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.TabIndex = 8
        '
        'btnAuditoria
        '
        Me.btnAuditoria.TabIndex = 7
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 69)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(851, 581)
        Me.DataGridView1.TabIndex = 1
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(177, 14)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(182, 20)
        Me.lblNombreEmpresa.TabIndex = 36
        Me.lblNombreEmpresa.Text = "<nombre del usuario>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(97, 12)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(74, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Empresa:"
        '
        'mnuExportar
        '
        Me.mnuExportar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_Exportar1, Me.MenuItem_Exportar2, Me.MenuItem_Importar1})
        Me.mnuExportar.Name = "nnuExportar"
        Me.mnuExportar.Size = New System.Drawing.Size(218, 70)
        '
        'MenuItem_Exportar1
        '
        Me.MenuItem_Exportar1.Name = "MenuItem_Exportar1"
        Me.MenuItem_Exportar1.Size = New System.Drawing.Size(217, 22)
        Me.MenuItem_Exportar1.Text = "Exportar a Excel"
        '
        'MenuItem_Exportar2
        '
        Me.MenuItem_Exportar2.Name = "MenuItem_Exportar2"
        Me.MenuItem_Exportar2.Size = New System.Drawing.Size(217, 22)
        Me.MenuItem_Exportar2.Text = "Exportar a Texto delimitado"
        '
        'MenuItem_Importar1
        '
        Me.MenuItem_Importar1.Name = "MenuItem_Importar1"
        Me.MenuItem_Importar1.Size = New System.Drawing.Size(217, 22)
        Me.MenuItem_Importar1.Text = "Importar Texto delimitado"
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.sigafyc.My.Resources.Resources.icons8_color_print_32
        Me.btnImprimir.Location = New System.Drawing.Point(867, 362)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 81)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Tag = "Imprimir"
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmBb050plancuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 659)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblNombreEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmBb050plancuentas"
        Me.Tag = ""
        Me.Text = "Browse de Cuenta contables"
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
        Me.Controls.SetChildIndex(Me.lblNombreEmpresa, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuExportar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mnuExportar As ContextMenuStrip
    Friend WithEvents MenuItem_Exportar1 As ToolStripMenuItem
    Friend WithEvents MenuItem_Exportar2 As ToolStripMenuItem
    Friend WithEvents MenuItem_Importar1 As ToolStripMenuItem
    Friend WithEvents btnImprimir As Button
End Class
