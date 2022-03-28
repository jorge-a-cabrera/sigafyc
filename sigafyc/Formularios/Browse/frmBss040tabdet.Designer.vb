<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBss040tabdet
    Inherits frmBrowseSinGrid

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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNombreTabla = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(10, 48)
        Me.txtBuscar.Size = New System.Drawing.Size(851, 19)
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(867, 449)
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Location = New System.Drawing.Point(867, 362)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 76)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(851, 454)
        Me.DataGridView1.TabIndex = 16
        '
        'lblNombreTabla
        '
        Me.lblNombreTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTabla.Location = New System.Drawing.Point(12, 9)
        Me.lblNombreTabla.Name = "lblNombreTabla"
        Me.lblNombreTabla.Size = New System.Drawing.Size(851, 29)
        Me.lblNombreTabla.TabIndex = 24
        Me.lblNombreTabla.Text = "Label1"
        Me.lblNombreTabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBss040tabdet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 539)
        Me.Controls.Add(Me.lblNombreTabla)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmBss040tabdet"
        Me.Tag = ""
        Me.Text = "Browse Detalle de Tabla"
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.lblNombreTabla, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombreTabla As Label
End Class
