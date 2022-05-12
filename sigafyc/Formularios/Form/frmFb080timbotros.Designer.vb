<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFb080timbotros
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumTimbrado_NE = New System.Windows.Forms.TextBox()
        Me.gbxGrupo1 = New System.Windows.Forms.GroupBox()
        Me.txtExpira_FE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValido_FE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbxGrupo2 = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNroDocumento_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxGrupo1.SuspendLayout()
        Me.gbxGrupo2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 37)
        Me.TabControl1.Size = New System.Drawing.Size(536, 304)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.gbxGrupo2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtNumTimbrado_NE)
        Me.TabPage1.Controls.Add(Me.gbxGrupo1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(528, 268)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(17, 343)
        Me.btnCancelar.Size = New System.Drawing.Size(120, 74)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(425, 343)
        Me.btnAceptar.Size = New System.Drawing.Size(120, 74)
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(9, 9)
        Me.lblMensaje.Size = New System.Drawing.Size(501, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Timbrado No.:"
        '
        'txtNumTimbrado_NE
        '
        Me.txtNumTimbrado_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTimbrado_NE.Location = New System.Drawing.Point(131, 15)
        Me.txtNumTimbrado_NE.Name = "txtNumTimbrado_NE"
        Me.txtNumTimbrado_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtNumTimbrado_NE.TabIndex = 0
        '
        'gbxGrupo1
        '
        Me.gbxGrupo1.Controls.Add(Me.txtExpira_FE)
        Me.gbxGrupo1.Controls.Add(Me.Label8)
        Me.gbxGrupo1.Controls.Add(Me.txtValido_FE)
        Me.gbxGrupo1.Controls.Add(Me.Label7)
        Me.gbxGrupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo1.Location = New System.Drawing.Point(22, 176)
        Me.gbxGrupo1.Name = "gbxGrupo1"
        Me.gbxGrupo1.Size = New System.Drawing.Size(480, 76)
        Me.gbxGrupo1.TabIndex = 2
        Me.gbxGrupo1.TabStop = False
        Me.gbxGrupo1.Text = "periodo de vigencia"
        '
        'txtExpira_FE
        '
        Me.txtExpira_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpira_FE.Location = New System.Drawing.Point(315, 35)
        Me.txtExpira_FE.Name = "txtExpira_FE"
        Me.txtExpira_FE.Size = New System.Drawing.Size(146, 26)
        Me.txtExpira_FE.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Hasta:"
        '
        'txtValido_FE
        '
        Me.txtValido_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValido_FE.Location = New System.Drawing.Point(82, 35)
        Me.txtValido_FE.Name = "txtValido_FE"
        Me.txtValido_FE.Size = New System.Drawing.Size(146, 26)
        Me.txtValido_FE.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Desde:"
        '
        'gbxGrupo2
        '
        Me.gbxGrupo2.Controls.Add(Me.lblNombre)
        Me.gbxGrupo2.Controls.Add(Me.txtNroDocumento_AN)
        Me.gbxGrupo2.Controls.Add(Me.Label1)
        Me.gbxGrupo2.Controls.Add(Me.cmbTipoDocumento)
        Me.gbxGrupo2.Controls.Add(Me.Label3)
        Me.gbxGrupo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo2.Location = New System.Drawing.Point(22, 50)
        Me.gbxGrupo2.Name = "gbxGrupo2"
        Me.gbxGrupo2.Size = New System.Drawing.Size(479, 120)
        Me.gbxGrupo2.TabIndex = 1
        Me.gbxGrupo2.TabStop = False
        Me.gbxGrupo2.Text = "Documento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Navy
        Me.lblNombre.Location = New System.Drawing.Point(77, 82)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(179, 20)
        Me.lblNombre.TabIndex = 84
        Me.lblNombre.Text = "<nombre_razon_social>"
        '
        'txtNroDocumento_AN
        '
        Me.txtNroDocumento_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocumento_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento_AN.Location = New System.Drawing.Point(227, 52)
        Me.txtNroDocumento_AN.Name = "txtNroDocumento_AN"
        Me.txtNroDocumento_AN.Size = New System.Drawing.Size(181, 26)
        Me.txtNroDocumento_AN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "número:"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.AccessibleDescription = "tipo"
        Me.cmbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(81, 51)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(133, 28)
        Me.cmbTipoDocumento.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "tipo:"
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(528, 268)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(90, 15)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(138, 28)
        Me.cmbEstado.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Estado:"
        '
        'frmFb080timbotros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(561, 427)
        Me.Name = "frmFb080timbotros"
        Me.Tag = ""
        Me.Text = "Formulario Timbrados de terceros"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbxGrupo1.ResumeLayout(False)
        Me.gbxGrupo1.PerformLayout()
        Me.gbxGrupo2.ResumeLayout(False)
        Me.gbxGrupo2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumTimbrado_NE As TextBox
    Friend WithEvents gbxGrupo1 As GroupBox
    Friend WithEvents txtExpira_FE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtValido_FE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gbxGrupo2 As GroupBox
    Friend WithEvents txtNroDocumento_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoDocumento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNombre As Label
End Class
