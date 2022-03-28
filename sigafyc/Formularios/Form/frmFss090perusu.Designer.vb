<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFss090perusu
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
        Me.txtSS070_codigo_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSS050_codigo_AB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblNombrePerfil = New System.Windows.Forms.Label()
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
        Me.TabControl1.Size = New System.Drawing.Size(681, 242)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblNombrePerfil)
        Me.TabPage1.Controls.Add(Me.lblNombreUsuario)
        Me.TabPage1.Controls.Add(Me.txtSS050_codigo_AB)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtSS070_codigo_AN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(673, 202)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 297)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(556, 297)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(677, 37)
        '
        'txtSS070_codigo_AN
        '
        Me.txtSS070_codigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSS070_codigo_AN.Location = New System.Drawing.Point(172, 110)
        Me.txtSS070_codigo_AN.Name = "txtSS070_codigo_AN"
        Me.txtSS070_codigo_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtSS070_codigo_AN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Codigo perfil:"
        '
        'txtSS050_codigo_AB
        '
        Me.txtSS050_codigo_AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSS050_codigo_AB.Location = New System.Drawing.Point(172, 17)
        Me.txtSS050_codigo_AB.Name = "txtSS050_codigo_AB"
        Me.txtSS050_codigo_AB.Size = New System.Drawing.Size(235, 29)
        Me.txtSS050_codigo_AB.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Codigo usuario:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(168, 49)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(165, 24)
        Me.lblNombreUsuario.TabIndex = 18
        Me.lblNombreUsuario.Text = "<nombre usuario>"
        '
        'lblNombrePerfil
        '
        Me.lblNombrePerfil.AutoSize = True
        Me.lblNombrePerfil.Location = New System.Drawing.Point(168, 142)
        Me.lblNombrePerfil.Name = "lblNombrePerfil"
        Me.lblNombrePerfil.Size = New System.Drawing.Size(143, 24)
        Me.lblNombrePerfil.TabIndex = 19
        Me.lblNombrePerfil.Text = "<nombre perfil>"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(673, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(234, 21)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estado operativo:"
        '
        'frmFss090perusu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(700, 383)
        Me.Name = "frmFss090perusu"
        Me.Tag = ""
        Me.Text = "Formulario Perfiles por Usuario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSS070_codigo_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSS050_codigo_AB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombrePerfil As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
End Class
