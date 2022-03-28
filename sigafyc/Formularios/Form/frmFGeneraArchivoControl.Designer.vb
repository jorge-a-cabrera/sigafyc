<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFGeneraArchivoControl
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFGeneraArchivoControl))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DatosControl = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPasswordSupervisor2_AN = New System.Windows.Forms.TextBox()
        Me.txtPasswordSupervisor_AN = New System.Windows.Forms.TextBox()
        Me.txtUsuarioSupervisor_AB = New System.Windows.Forms.TextBox()
        Me.txtUltimoAcceso_FE = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial_AN = New System.Windows.Forms.TextBox()
        Me.txtSerialHDD_AN = New System.Windows.Forms.TextBox()
        Me.txtFechaExpiracion_FE = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DatosSysAdmin = New System.Windows.Forms.GroupBox()
        Me.txtSysAdminPassword_AN = New System.Windows.Forms.TextBox()
        Me.txtSysAdminUsuario_AB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.DatosControl.SuspendLayout()
        Me.DatosSysAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(764, 559)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DatosControl)
        Me.TabPage1.Controls.Add(Me.DatosSysAdmin)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(756, 522)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Requeridos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DatosControl
        '
        Me.DatosControl.Controls.Add(Me.Label9)
        Me.DatosControl.Controls.Add(Me.txtPasswordSupervisor2_AN)
        Me.DatosControl.Controls.Add(Me.txtPasswordSupervisor_AN)
        Me.DatosControl.Controls.Add(Me.txtUsuarioSupervisor_AB)
        Me.DatosControl.Controls.Add(Me.txtUltimoAcceso_FE)
        Me.DatosControl.Controls.Add(Me.txtRazonSocial_AN)
        Me.DatosControl.Controls.Add(Me.txtSerialHDD_AN)
        Me.DatosControl.Controls.Add(Me.txtFechaExpiracion_FE)
        Me.DatosControl.Controls.Add(Me.Label8)
        Me.DatosControl.Controls.Add(Me.Label7)
        Me.DatosControl.Controls.Add(Me.Label6)
        Me.DatosControl.Controls.Add(Me.Label5)
        Me.DatosControl.Controls.Add(Me.Label4)
        Me.DatosControl.Controls.Add(Me.Label3)
        Me.DatosControl.Location = New System.Drawing.Point(25, 161)
        Me.DatosControl.Name = "DatosControl"
        Me.DatosControl.Size = New System.Drawing.Size(702, 334)
        Me.DatosControl.TabIndex = 9
        Me.DatosControl.TabStop = False
        Me.DatosControl.Text = "Datos para archivo de control"
        Me.DatosControl.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Reingrese el Password:"
        Me.Label9.Visible = False
        '
        'txtPasswordSupervisor2_AN
        '
        Me.txtPasswordSupervisor2_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordSupervisor2_AN.Location = New System.Drawing.Point(344, 283)
        Me.txtPasswordSupervisor2_AN.Name = "txtPasswordSupervisor2_AN"
        Me.txtPasswordSupervisor2_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordSupervisor2_AN.Size = New System.Drawing.Size(318, 29)
        Me.txtPasswordSupervisor2_AN.TabIndex = 6
        Me.txtPasswordSupervisor2_AN.Visible = False
        '
        'txtPasswordSupervisor_AN
        '
        Me.txtPasswordSupervisor_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordSupervisor_AN.Location = New System.Drawing.Point(344, 242)
        Me.txtPasswordSupervisor_AN.Name = "txtPasswordSupervisor_AN"
        Me.txtPasswordSupervisor_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordSupervisor_AN.Size = New System.Drawing.Size(318, 29)
        Me.txtPasswordSupervisor_AN.TabIndex = 5
        '
        'txtUsuarioSupervisor_AB
        '
        Me.txtUsuarioSupervisor_AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuarioSupervisor_AB.Location = New System.Drawing.Point(344, 201)
        Me.txtUsuarioSupervisor_AB.Name = "txtUsuarioSupervisor_AB"
        Me.txtUsuarioSupervisor_AB.Size = New System.Drawing.Size(318, 29)
        Me.txtUsuarioSupervisor_AB.TabIndex = 4
        '
        'txtUltimoAcceso_FE
        '
        Me.txtUltimoAcceso_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUltimoAcceso_FE.Location = New System.Drawing.Point(344, 160)
        Me.txtUltimoAcceso_FE.Name = "txtUltimoAcceso_FE"
        Me.txtUltimoAcceso_FE.Size = New System.Drawing.Size(318, 29)
        Me.txtUltimoAcceso_FE.TabIndex = 3
        '
        'txtRazonSocial_AN
        '
        Me.txtRazonSocial_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial_AN.Location = New System.Drawing.Point(344, 119)
        Me.txtRazonSocial_AN.Name = "txtRazonSocial_AN"
        Me.txtRazonSocial_AN.Size = New System.Drawing.Size(318, 29)
        Me.txtRazonSocial_AN.TabIndex = 2
        '
        'txtSerialHDD_AN
        '
        Me.txtSerialHDD_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerialHDD_AN.Location = New System.Drawing.Point(344, 78)
        Me.txtSerialHDD_AN.Name = "txtSerialHDD_AN"
        Me.txtSerialHDD_AN.Size = New System.Drawing.Size(318, 29)
        Me.txtSerialHDD_AN.TabIndex = 1
        '
        'txtFechaExpiracion_FE
        '
        Me.txtFechaExpiracion_FE.CustomFormat = "yyyy-MM-dd"
        Me.txtFechaExpiracion_FE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaExpiracion_FE.Location = New System.Drawing.Point(344, 36)
        Me.txtFechaExpiracion_FE.Name = "txtFechaExpiracion_FE"
        Me.txtFechaExpiracion_FE.Size = New System.Drawing.Size(318, 29)
        Me.txtFechaExpiracion_FE.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(317, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Password Administrador del sistema:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(299, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Usuario Administrador del sistema:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha/hora ultimo acceso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Razon Social"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Serial del Disco duro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha expiracion:"
        '
        'DatosSysAdmin
        '
        Me.DatosSysAdmin.Controls.Add(Me.txtSysAdminPassword_AN)
        Me.DatosSysAdmin.Controls.Add(Me.txtSysAdminUsuario_AB)
        Me.DatosSysAdmin.Controls.Add(Me.Label1)
        Me.DatosSysAdmin.Controls.Add(Me.Label2)
        Me.DatosSysAdmin.Location = New System.Drawing.Point(25, 23)
        Me.DatosSysAdmin.Name = "DatosSysAdmin"
        Me.DatosSysAdmin.Size = New System.Drawing.Size(399, 132)
        Me.DatosSysAdmin.TabIndex = 8
        Me.DatosSysAdmin.TabStop = False
        Me.DatosSysAdmin.Text = "Autenticación del SysAdmin"
        '
        'txtSysAdminPassword_AN
        '
        Me.txtSysAdminPassword_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSysAdminPassword_AN.Location = New System.Drawing.Point(126, 79)
        Me.txtSysAdminPassword_AN.Name = "txtSysAdminPassword_AN"
        Me.txtSysAdminPassword_AN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSysAdminPassword_AN.Size = New System.Drawing.Size(247, 29)
        Me.txtSysAdminPassword_AN.TabIndex = 1
        '
        'txtSysAdminUsuario_AB
        '
        Me.txtSysAdminUsuario_AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSysAdminUsuario_AB.CausesValidation = False
        Me.txtSysAdminUsuario_AB.Location = New System.Drawing.Point(126, 44)
        Me.txtSysAdminUsuario_AB.Name = "txtSysAdminUsuario_AB"
        Me.txtSysAdminUsuario_AB.Size = New System.Drawing.Size(247, 29)
        Me.txtSysAdminUsuario_AB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password:"
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.sigafyc.My.Resources.Resources.icons8_ok_32
        Me.btnAceptar.Location = New System.Drawing.Point(643, 577)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(133, 73)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Tag = "Aceptar"
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.CausesValidation = False
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.sigafyc.My.Resources.Resources.icons8_cancel_32
        Me.btnCancelar.Location = New System.Drawing.Point(12, 577)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(133, 73)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Tag = "Cancelar"
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmFGeneraArchivoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(785, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFGeneraArchivoControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de Archivo de Control del Sisetma"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.DatosControl.ResumeLayout(False)
        Me.DatosControl.PerformLayout()
        Me.DatosSysAdmin.ResumeLayout(False)
        Me.DatosSysAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents btnAceptar As System.Windows.Forms.Button
    Public WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DatosControl As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DatosSysAdmin As System.Windows.Forms.GroupBox
    Friend WithEvents txtSysAdminPassword_AN As System.Windows.Forms.TextBox
    Friend WithEvents txtSysAdminUsuario_AB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFechaExpiracion_FE As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPasswordSupervisor_AN As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioSupervisor_AB As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimoAcceso_FE As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial_AN As System.Windows.Forms.TextBox
    Friend WithEvents txtSerialHDD_AN As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordSupervisor2_AN As System.Windows.Forms.TextBox
End Class
