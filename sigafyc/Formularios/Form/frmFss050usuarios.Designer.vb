<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFss050usuarios : Inherits frmFormulario

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigo_AB = New System.Windows.Forms.TextBox()
        Me.txtNombre_AB = New System.Windows.Forms.TextBox()
        Me.txtLogin_AN = New System.Windows.Forms.TextBox()
        Me.txtPassword_AN = New System.Windows.Forms.TextBox()
        Me.txtPassword2_AN = New System.Windows.Forms.TextBox()
        Me.txtSS060_Codigo_AN = New System.Windows.Forms.TextBox()
        Me.txtValido_FE = New System.Windows.Forms.TextBox()
        Me.txtExpira_FE = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Size = New System.Drawing.Size(646, 417)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.txtExpira_FE)
        Me.TabPage1.Controls.Add(Me.txtValido_FE)
        Me.TabPage1.Controls.Add(Me.txtSS060_Codigo_AN)
        Me.TabPage1.Controls.Add(Me.txtPassword2_AN)
        Me.TabPage1.Controls.Add(Me.txtPassword_AN)
        Me.TabPage1.Controls.Add(Me.txtLogin_AN)
        Me.TabPage1.Controls.Add(Me.txtNombre_AB)
        Me.TabPage1.Controls.Add(Me.txtCodigo_AB)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(638, 377)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 472)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(521, 472)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(642, 37)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre y apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Login de acceso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Confirme el password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Equipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Valido desde:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Expira en:"
        '
        'txtCodigo_AB
        '
        Me.txtCodigo_AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AB.Location = New System.Drawing.Point(237, 19)
        Me.txtCodigo_AB.Name = "txtCodigo_AB"
        Me.txtCodigo_AB.Size = New System.Drawing.Size(235, 29)
        Me.txtCodigo_AB.TabIndex = 0
        '
        'txtNombre_AB
        '
        Me.txtNombre_AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre_AB.Location = New System.Drawing.Point(237, 63)
        Me.txtNombre_AB.Name = "txtNombre_AB"
        Me.txtNombre_AB.Size = New System.Drawing.Size(378, 29)
        Me.txtNombre_AB.TabIndex = 1
        '
        'txtLogin_AN
        '
        Me.txtLogin_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin_AN.Location = New System.Drawing.Point(237, 107)
        Me.txtLogin_AN.Name = "txtLogin_AN"
        Me.txtLogin_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtLogin_AN.TabIndex = 2
        '
        'txtPassword_AN
        '
        Me.txtPassword_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword_AN.Location = New System.Drawing.Point(237, 151)
        Me.txtPassword_AN.Name = "txtPassword_AN"
        Me.txtPassword_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtPassword_AN.TabIndex = 3
        '
        'txtPassword2_AN
        '
        Me.txtPassword2_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword2_AN.Location = New System.Drawing.Point(237, 195)
        Me.txtPassword2_AN.Name = "txtPassword2_AN"
        Me.txtPassword2_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtPassword2_AN.TabIndex = 4
        '
        'txtSS060_Codigo_AN
        '
        Me.txtSS060_Codigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSS060_Codigo_AN.Location = New System.Drawing.Point(237, 239)
        Me.txtSS060_Codigo_AN.Name = "txtSS060_Codigo_AN"
        Me.txtSS060_Codigo_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtSS060_Codigo_AN.TabIndex = 5
        '
        'txtValido_FE
        '
        Me.txtValido_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValido_FE.Location = New System.Drawing.Point(237, 283)
        Me.txtValido_FE.Name = "txtValido_FE"
        Me.txtValido_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtValido_FE.TabIndex = 6
        '
        'txtExpira_FE
        '
        Me.txtExpira_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpira_FE.Location = New System.Drawing.Point(237, 327)
        Me.txtExpira_FE.Name = "txtExpira_FE"
        Me.txtExpira_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtExpira_FE.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(638, 377)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(240, 18)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 24)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Estado operativo:"
        '
        'frmFss050usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(668, 555)
        Me.Name = "frmFss050usuarios"
        Me.Tag = ""
        Me.Text = "Formulario de Usuarios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExpira_FE As TextBox
    Friend WithEvents txtValido_FE As TextBox
    Friend WithEvents txtSS060_Codigo_AN As TextBox
    Friend WithEvents txtPassword2_AN As TextBox
    Friend WithEvents txtPassword_AN As TextBox
    Friend WithEvents txtLogin_AN As TextBox
    Friend WithEvents txtNombre_AB As TextBox
    Friend WithEvents txtCodigo_AB As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
End Class
