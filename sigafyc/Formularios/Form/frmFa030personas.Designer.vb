<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFa030personas : Inherits frmFormulario

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
        Me.gbxGrupo1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo_SR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxGrupo2 = New System.Windows.Forms.GroupBox()
        Me.txtAbreviado_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre_AN = New System.Windows.Forms.TextBox()
        Me.gbxGrupo3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail_AN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono_AN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCiudad_AN = New System.Windows.Forms.TextBox()
        Me.txtDireccion_AN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxGrupo1.SuspendLayout()
        Me.gbxGrupo2.SuspendLayout()
        Me.gbxGrupo3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(896, 460)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbxGrupo3)
        Me.TabPage1.Controls.Add(Me.gbxGrupo2)
        Me.TabPage1.Controls.Add(Me.gbxGrupo1)
        Me.TabPage1.Size = New System.Drawing.Size(888, 420)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 511)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(771, 511)
        '
        'gbxGrupo1
        '
        Me.gbxGrupo1.Controls.Add(Me.txtCodigo_SR)
        Me.gbxGrupo1.Controls.Add(Me.Label1)
        Me.gbxGrupo1.Controls.Add(Me.cmbTipoDocumento)
        Me.gbxGrupo1.Controls.Add(Me.Label2)
        Me.gbxGrupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo1.Location = New System.Drawing.Point(16, 6)
        Me.gbxGrupo1.Name = "gbxGrupo1"
        Me.gbxGrupo1.Size = New System.Drawing.Size(354, 82)
        Me.gbxGrupo1.TabIndex = 0
        Me.gbxGrupo1.TabStop = False
        Me.gbxGrupo1.Text = "Documento:"
        '
        'txtCodigo_SR
        '
        Me.txtCodigo_SR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_SR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo_SR.Location = New System.Drawing.Point(156, 37)
        Me.txtCodigo_SR.Name = "txtCodigo_SR"
        Me.txtCodigo_SR.Size = New System.Drawing.Size(181, 26)
        Me.txtCodigo_SR.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "número:"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.AccessibleDescription = "tipo"
        Me.cmbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(10, 36)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(133, 28)
        Me.cmbTipoDocumento.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "tipo:"
        '
        'gbxGrupo2
        '
        Me.gbxGrupo2.Controls.Add(Me.txtAbreviado_AN)
        Me.gbxGrupo2.Controls.Add(Me.Label3)
        Me.gbxGrupo2.Controls.Add(Me.txtNombre_AN)
        Me.gbxGrupo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo2.Location = New System.Drawing.Point(16, 94)
        Me.gbxGrupo2.Name = "gbxGrupo2"
        Me.gbxGrupo2.Size = New System.Drawing.Size(862, 110)
        Me.gbxGrupo2.TabIndex = 1
        Me.gbxGrupo2.TabStop = False
        Me.gbxGrupo2.Text = "Nombre y apellido / razón social"
        '
        'txtAbreviado_AN
        '
        Me.txtAbreviado_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbreviado_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviado_AN.Location = New System.Drawing.Point(10, 72)
        Me.txtAbreviado_AN.Name = "txtAbreviado_AN"
        Me.txtAbreviado_AN.Size = New System.Drawing.Size(846, 26)
        Me.txtAbreviado_AN.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Apodo, denominación comercial o sigla"
        '
        'txtNombre_AN
        '
        Me.txtNombre_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_AN.Location = New System.Drawing.Point(10, 20)
        Me.txtNombre_AN.Name = "txtNombre_AN"
        Me.txtNombre_AN.Size = New System.Drawing.Size(846, 26)
        Me.txtNombre_AN.TabIndex = 0
        '
        'gbxGrupo3
        '
        Me.gbxGrupo3.Controls.Add(Me.Label7)
        Me.gbxGrupo3.Controls.Add(Me.txtEmail_AN)
        Me.gbxGrupo3.Controls.Add(Me.Label6)
        Me.gbxGrupo3.Controls.Add(Me.txtTelefono_AN)
        Me.gbxGrupo3.Controls.Add(Me.Label5)
        Me.gbxGrupo3.Controls.Add(Me.txtCiudad_AN)
        Me.gbxGrupo3.Controls.Add(Me.txtDireccion_AN)
        Me.gbxGrupo3.Controls.Add(Me.Label4)
        Me.gbxGrupo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo3.Location = New System.Drawing.Point(16, 210)
        Me.gbxGrupo3.Name = "gbxGrupo3"
        Me.gbxGrupo3.Size = New System.Drawing.Size(862, 194)
        Me.gbxGrupo3.TabIndex = 2
        Me.gbxGrupo3.TabStop = False
        Me.gbxGrupo3.Text = "Datos de ubicación y contacto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 15)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "correo electrónico:"
        '
        'txtEmail_AN
        '
        Me.txtEmail_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail_AN.Location = New System.Drawing.Point(10, 147)
        Me.txtEmail_AN.Name = "txtEmail_AN"
        Me.txtEmail_AN.Size = New System.Drawing.Size(846, 26)
        Me.txtEmail_AN.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "teléfono:"
        '
        'txtTelefono_AN
        '
        Me.txtTelefono_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono_AN.Location = New System.Drawing.Point(427, 93)
        Me.txtTelefono_AN.Name = "txtTelefono_AN"
        Me.txtTelefono_AN.Size = New System.Drawing.Size(429, 26)
        Me.txtTelefono_AN.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "ciudad:"
        '
        'txtCiudad_AN
        '
        Me.txtCiudad_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCiudad_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad_AN.Location = New System.Drawing.Point(10, 93)
        Me.txtCiudad_AN.Name = "txtCiudad_AN"
        Me.txtCiudad_AN.Size = New System.Drawing.Size(411, 26)
        Me.txtCiudad_AN.TabIndex = 1
        '
        'txtDireccion_AN
        '
        Me.txtDireccion_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion_AN.Location = New System.Drawing.Point(10, 39)
        Me.txtDireccion_AN.Name = "txtDireccion_AN"
        Me.txtDireccion_AN.Size = New System.Drawing.Size(846, 26)
        Me.txtDireccion_AN.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "dirección:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(888, 420)
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
        Me.cmbEstado.Location = New System.Drawing.Point(91, 13)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 28)
        Me.cmbEstado.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Estado:"
        '
        'frmFa030personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(916, 594)
        Me.Name = "frmFa030personas"
        Me.Tag = ""
        Me.Text = "Formulario de Personas Fisicas o Juridicas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbxGrupo1.ResumeLayout(False)
        Me.gbxGrupo1.PerformLayout()
        Me.gbxGrupo2.ResumeLayout(False)
        Me.gbxGrupo2.PerformLayout()
        Me.gbxGrupo3.ResumeLayout(False)
        Me.gbxGrupo3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxGrupo1 As GroupBox
    Friend WithEvents txtCodigo_SR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoDocumento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbxGrupo3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail_AN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono_AN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCiudad_AN As TextBox
    Friend WithEvents txtDireccion_AN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gbxGrupo2 As GroupBox
    Friend WithEvents txtAbreviado_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre_AN As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
End Class
