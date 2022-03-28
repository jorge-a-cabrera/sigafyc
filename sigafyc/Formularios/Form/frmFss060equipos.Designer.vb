<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFss060equipos
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
        Me.txtMac_AN = New System.Windows.Forms.TextBox()
        Me.txtIp_AN = New System.Windows.Forms.TextBox()
        Me.txtUbicacion_AN = New System.Windows.Forms.TextBox()
        Me.txtCodigo_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Size = New System.Drawing.Size(896, 325)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtExpira_FE)
        Me.TabPage1.Controls.Add(Me.txtValido_FE)
        Me.TabPage1.Controls.Add(Me.txtMac_AN)
        Me.TabPage1.Controls.Add(Me.txtIp_AN)
        Me.TabPage1.Controls.Add(Me.txtUbicacion_AN)
        Me.TabPage1.Controls.Add(Me.txtCodigo_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(888, 285)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 376)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(771, 376)
        '
        'txtExpira_FE
        '
        Me.txtExpira_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpira_FE.Location = New System.Drawing.Point(235, 241)
        Me.txtExpira_FE.Name = "txtExpira_FE"
        Me.txtExpira_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtExpira_FE.TabIndex = 5
        '
        'txtValido_FE
        '
        Me.txtValido_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValido_FE.Location = New System.Drawing.Point(235, 197)
        Me.txtValido_FE.Name = "txtValido_FE"
        Me.txtValido_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtValido_FE.TabIndex = 4
        '
        'txtMac_AN
        '
        Me.txtMac_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMac_AN.Location = New System.Drawing.Point(235, 152)
        Me.txtMac_AN.Name = "txtMac_AN"
        Me.txtMac_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtMac_AN.TabIndex = 3
        '
        'txtIp_AN
        '
        Me.txtIp_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIp_AN.Location = New System.Drawing.Point(235, 108)
        Me.txtIp_AN.Name = "txtIp_AN"
        Me.txtIp_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtIp_AN.TabIndex = 2
        '
        'txtUbicacion_AN
        '
        Me.txtUbicacion_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUbicacion_AN.Location = New System.Drawing.Point(235, 64)
        Me.txtUbicacion_AN.Name = "txtUbicacion_AN"
        Me.txtUbicacion_AN.Size = New System.Drawing.Size(638, 29)
        Me.txtUbicacion_AN.TabIndex = 1
        '
        'txtCodigo_AN
        '
        Me.txtCodigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AN.Location = New System.Drawing.Point(235, 20)
        Me.txtCodigo_AN.Name = "txtCodigo_AN"
        Me.txtCodigo_AN.Size = New System.Drawing.Size(235, 29)
        Me.txtCodigo_AN.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Expira en:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Valido desde:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "MAC address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Direccion IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ubicacion fisica:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Codigo:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(888, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(235, 20)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estado operativo:"
        '
        'frmFss060equipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(918, 462)
        Me.Name = "frmFss060equipos"
        Me.Tag = ""
        Me.Text = "Formulario de Equipo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtExpira_FE As TextBox
    Friend WithEvents txtValido_FE As TextBox
    Friend WithEvents txtMac_AN As TextBox
    Friend WithEvents txtIp_AN As TextBox
    Friend WithEvents txtUbicacion_AN As TextBox
    Friend WithEvents txtCodigo_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
End Class
