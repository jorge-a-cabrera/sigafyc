<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFCambioPassword
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPasswordNuevo2_AN = New System.Windows.Forms.TextBox()
        Me.txtPasswordNuevo_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPasswordActual_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Size = New System.Drawing.Size(515, 185)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.txtPasswordActual_AN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtPasswordNuevo2_AN)
        Me.TabPage1.Controls.Add(Me.txtPasswordNuevo_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(507, 149)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 236)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(390, 236)
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Size = New System.Drawing.Size(511, 37)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(233, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Reingrese la nueva contraseña:"
        '
        'txtPasswordNuevo2_AN
        '
        Me.txtPasswordNuevo2_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordNuevo2_AN.Location = New System.Drawing.Point(258, 103)
        Me.txtPasswordNuevo2_AN.Name = "txtPasswordNuevo2_AN"
        Me.txtPasswordNuevo2_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordNuevo2_AN.Size = New System.Drawing.Size(230, 26)
        Me.txtPasswordNuevo2_AN.TabIndex = 2
        '
        'txtPasswordNuevo_AN
        '
        Me.txtPasswordNuevo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordNuevo_AN.Location = New System.Drawing.Point(258, 62)
        Me.txtPasswordNuevo_AN.Name = "txtPasswordNuevo_AN"
        Me.txtPasswordNuevo_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordNuevo_AN.Size = New System.Drawing.Size(230, 26)
        Me.txtPasswordNuevo_AN.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ingrese nueva contraseña:"
        '
        'txtPasswordActual_AN
        '
        Me.txtPasswordActual_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordActual_AN.Location = New System.Drawing.Point(258, 17)
        Me.txtPasswordActual_AN.Name = "txtPasswordActual_AN"
        Me.txtPasswordActual_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordActual_AN.Size = New System.Drawing.Size(230, 26)
        Me.txtPasswordActual_AN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ingrese contraseña actual:"
        '
        'frmFCambioPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(534, 320)
        Me.Name = "frmFCambioPassword"
        Me.Tag = ""
        Me.Text = "Formulario para Cambiar Contraseña"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtPasswordActual_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPasswordNuevo2_AN As TextBox
    Friend WithEvents txtPasswordNuevo_AN As TextBox
    Friend WithEvents Label8 As Label
End Class
