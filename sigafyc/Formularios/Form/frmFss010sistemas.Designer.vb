<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFss010sistemas
    Inherits frmFormulario

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
        Me.txtNombre_AN = New System.Windows.Forms.TextBox()
        Me.txtCodigo_AB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(660, 171)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtNombre_AN)
        Me.TabPage1.Controls.Add(Me.txtCodigo_AB)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(652, 131)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 226)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(539, 226)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(656, 37)
        '
        'txtNombre_AN
        '
        Me.txtNombre_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre_AN.Location = New System.Drawing.Point(124, 76)
        Me.txtNombre_AN.Name = "txtNombre_AN"
        Me.txtNombre_AN.Size = New System.Drawing.Size(506, 29)
        Me.txtNombre_AN.TabIndex = 1
        '
        'txtCodigo_AB
        '
        Me.txtCodigo_AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AB.Location = New System.Drawing.Point(124, 32)
        Me.txtCodigo_AB.Name = "txtCodigo_AB"
        Me.txtCodigo_AB.Size = New System.Drawing.Size(235, 29)
        Me.txtCodigo_AB.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Codigo:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(652, 131)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(174, 21)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estado operativo:"
        '
        'frmFss010sistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(681, 309)
        Me.Name = "frmFss010sistemas"
        Me.Tag = ""
        Me.Text = "Formulario de sistemas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtNombre_AN As TextBox
    Friend WithEvents txtCodigo_AB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
End Class
