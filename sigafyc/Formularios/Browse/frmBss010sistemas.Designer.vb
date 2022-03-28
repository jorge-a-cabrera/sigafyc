<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBss010sistemas
    Inherits frmBrowse

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
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Size = New System.Drawing.Size(851, 19)
        '
        'btnAuditoria
        '
        '
        'frmBss010sistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 664)
        Me.Name = "frmBss010sistemas"
        Me.Tag = ""
        Me.Text = "Browse de Sistemas"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
