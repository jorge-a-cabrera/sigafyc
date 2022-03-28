<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFss070perfiles
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
        Me.txtExpira_FE = New System.Windows.Forms.TextBox()
        Me.txtValido_FE = New System.Windows.Forms.TextBox()
        Me.txtNombre_AN = New System.Windows.Forms.TextBox()
        Me.txtCodigo_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Size = New System.Drawing.Size(653, 247)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtExpira_FE)
        Me.TabPage1.Controls.Add(Me.txtValido_FE)
        Me.TabPage1.Controls.Add(Me.txtNombre_AN)
        Me.TabPage1.Controls.Add(Me.txtCodigo_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(645, 207)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 302)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(528, 302)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(649, 37)
        '
        'txtExpira_FE
        '
        Me.txtExpira_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpira_FE.Location = New System.Drawing.Point(239, 154)
        Me.txtExpira_FE.Name = "txtExpira_FE"
        Me.txtExpira_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtExpira_FE.TabIndex = 3
        '
        'txtValido_FE
        '
        Me.txtValido_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValido_FE.Location = New System.Drawing.Point(239, 110)
        Me.txtValido_FE.Name = "txtValido_FE"
        Me.txtValido_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtValido_FE.TabIndex = 2
        '
        'txtNombre_AN
        '
        Me.txtNombre_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre_AN.Location = New System.Drawing.Point(239, 66)
        Me.txtNombre_AN.Name = "txtNombre_AN"
        Me.txtNombre_AN.Size = New System.Drawing.Size(378, 29)
        Me.txtNombre_AN.TabIndex = 1
        '
        'txtCodigo_AN
        '
        Me.txtCodigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AN.Location = New System.Drawing.Point(239, 22)
        Me.txtCodigo_AN.Name = "txtCodigo_AN"
        Me.txtCodigo_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtCodigo_AN.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Expira en:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Valido desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre perfil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(645, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(238, 24)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estado operativo:"
        '
        'frmFss070perfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(678, 386)
        Me.Name = "frmFss070perfiles"
        Me.Tag = ""
        Me.Text = "Formulario de Perfil"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtExpira_FE As TextBox
    Friend WithEvents txtValido_FE As TextBox
    Friend WithEvents txtNombre_AN As TextBox
    Friend WithEvents txtCodigo_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
End Class
