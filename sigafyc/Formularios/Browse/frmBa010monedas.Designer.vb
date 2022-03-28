<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBa010monedas
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 14)
        Me.txtBuscar.Size = New System.Drawing.Size(474, 22)
        Me.txtBuscar.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(490, 446)
        Me.btnSalir.TabIndex = 6
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Location = New System.Drawing.Point(490, 359)
        Me.btnAuditoria.TabIndex = 5
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(490, 272)
        Me.btnConsultar.TabIndex = 4
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(490, 185)
        Me.btnBorrar.TabIndex = 3
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(490, 98)
        Me.btnModificar.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(490, 11)
        Me.btnAgregar.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 42)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(474, 485)
        Me.DataGridView1.TabIndex = 0
        '
        'frmBa010monedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 542)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmBa010monedas"
        Me.Tag = ""
        Me.Text = "Browse de Monedas"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
End Class
