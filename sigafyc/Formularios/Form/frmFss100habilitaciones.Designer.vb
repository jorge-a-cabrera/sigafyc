<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFss100habilitaciones
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
        Me.txtSS080_codigo_AN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo_AN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSS010_codigo_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtExpira_FE = New System.Windows.Forms.TextBox()
        Me.txtValido_FE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNombreRestriccion = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(665, 344)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblNombreUsuario)
        Me.TabPage1.Controls.Add(Me.lblNombreRestriccion)
        Me.TabPage1.Controls.Add(Me.txtExpira_FE)
        Me.TabPage1.Controls.Add(Me.txtValido_FE)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtSS080_codigo_AN)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cmbTipo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtCodigo_AN)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtSS010_codigo_AN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(657, 304)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 399)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(540, 399)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(661, 37)
        '
        'txtSS080_codigo_AN
        '
        Me.txtSS080_codigo_AN.AccessibleDescription = "codigo"
        Me.txtSS080_codigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSS080_codigo_AN.Location = New System.Drawing.Point(151, 159)
        Me.txtSS080_codigo_AN.Name = "txtSS080_codigo_AN"
        Me.txtSS080_codigo_AN.Size = New System.Drawing.Size(478, 29)
        Me.txtSS080_codigo_AN.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Restricción:"
        '
        'cmbTipo
        '
        Me.cmbTipo.AccessibleDescription = "tipo"
        Me.cmbTipo.AutoCompleteCustomSource.AddRange(New String() {"Usuario", "Perfil"})
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Usuario", "Perfil"})
        Me.cmbTipo.Location = New System.Drawing.Point(151, 53)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(225, 32)
        Me.cmbTipo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 24)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Tipo:"
        '
        'txtCodigo_AN
        '
        Me.txtCodigo_AN.AccessibleDescription = "codigo"
        Me.txtCodigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AN.Location = New System.Drawing.Point(151, 91)
        Me.txtCodigo_AN.Name = "txtCodigo_AN"
        Me.txtCodigo_AN.Size = New System.Drawing.Size(225, 29)
        Me.txtCodigo_AN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Código:"
        '
        'txtSS010_codigo_AN
        '
        Me.txtSS010_codigo_AN.AccessibleDescription = "ss010_codigo"
        Me.txtSS010_codigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSS010_codigo_AN.Location = New System.Drawing.Point(151, 18)
        Me.txtSS010_codigo_AN.Name = "txtSS010_codigo_AN"
        Me.txtSS010_codigo_AN.Size = New System.Drawing.Size(225, 29)
        Me.txtSS010_codigo_AN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Sistema:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(657, 304)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(234, 18)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Estado operativo:"
        '
        'txtExpira_FE
        '
        Me.txtExpira_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpira_FE.Location = New System.Drawing.Point(151, 263)
        Me.txtExpira_FE.Name = "txtExpira_FE"
        Me.txtExpira_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtExpira_FE.TabIndex = 5
        '
        'txtValido_FE
        '
        Me.txtValido_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValido_FE.Location = New System.Drawing.Point(151, 228)
        Me.txtValido_FE.Name = "txtValido_FE"
        Me.txtValido_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtValido_FE.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Expira en:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 24)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Valido desde:"
        '
        'lblNombreRestriccion
        '
        Me.lblNombreRestriccion.Location = New System.Drawing.Point(147, 191)
        Me.lblNombreRestriccion.Name = "lblNombreRestriccion"
        Me.lblNombreRestriccion.Size = New System.Drawing.Size(478, 24)
        Me.lblNombreRestriccion.TabIndex = 36
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.Location = New System.Drawing.Point(147, 123)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(478, 24)
        Me.lblNombreUsuario.TabIndex = 37
        '
        'frmFss100habilitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(685, 482)
        Me.Name = "frmFss100habilitaciones"
        Me.Tag = ""
        Me.Text = "Formulario Habilitacion por Perfil/Usuario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtSS080_codigo_AN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo_AN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSS010_codigo_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtExpira_FE As TextBox
    Friend WithEvents txtValido_FE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNombreRestriccion As Label
    Friend WithEvents lblNombreUsuario As Label
End Class
