<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFb060perautgest : Inherits frmFormulario

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
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNroDocumento_SR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoPerfil = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Grupo2 = New System.Windows.Forms.GroupBox()
        Me.txtAbreviado_AN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre_AN = New System.Windows.Forms.TextBox()
        Me.Grupo3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail_AN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono_AN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCiudad_AN = New System.Windows.Forms.TextBox()
        Me.txtDireccion_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbxGrupo21 = New System.Windows.Forms.GroupBox()
        Me.lblNombreMoneda = New System.Windows.Forms.Label()
        Me.txtCodMoneda_AN = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblLimiteHabilitacion = New System.Windows.Forms.Label()
        Me.lblLimiteCredito = New System.Windows.Forms.Label()
        Me.lblNombreSucursal = New System.Windows.Forms.Label()
        Me.txtCodSucursal_NE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLimiteHabilitacion_ND = New System.Windows.Forms.TextBox()
        Me.txtLimiteCredito_ND = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiasVencimiento_NE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbxGrupo0 = New System.Windows.Forms.GroupBox()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxGrupo1.SuspendLayout()
        Me.Grupo2.SuspendLayout()
        Me.Grupo3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbxGrupo21.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gbxGrupo0.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Size = New System.Drawing.Size(896, 534)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage3, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.gbxGrupo0)
        Me.TabPage1.Controls.Add(Me.Grupo3)
        Me.TabPage1.Controls.Add(Me.Grupo2)
        Me.TabPage1.Controls.Add(Me.gbxGrupo1)
        Me.TabPage1.Size = New System.Drawing.Size(888, 494)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 585)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(771, 585)
        '
        'gbxGrupo1
        '
        Me.gbxGrupo1.Controls.Add(Me.cmbTipoDocumento)
        Me.gbxGrupo1.Controls.Add(Me.Label3)
        Me.gbxGrupo1.Controls.Add(Me.txtNroDocumento_SR)
        Me.gbxGrupo1.Controls.Add(Me.Label1)
        Me.gbxGrupo1.Controls.Add(Me.cmbTipoPerfil)
        Me.gbxGrupo1.Controls.Add(Me.Label2)
        Me.gbxGrupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo1.Location = New System.Drawing.Point(13, 77)
        Me.gbxGrupo1.Name = "gbxGrupo1"
        Me.gbxGrupo1.Size = New System.Drawing.Size(862, 86)
        Me.gbxGrupo1.TabIndex = 1
        Me.gbxGrupo1.TabStop = False
        Me.gbxGrupo1.Text = "Identificación del perfil"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.AccessibleDescription = "tipo"
        Me.cmbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(309, 36)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(275, 28)
        Me.cmbTipoDocumento.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "tipo de documento:"
        '
        'txtNroDocumento_SR
        '
        Me.txtNroDocumento_SR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocumento_SR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento_SR.Location = New System.Drawing.Point(608, 39)
        Me.txtNroDocumento_SR.Name = "txtNroDocumento_SR"
        Me.txtNroDocumento_SR.Size = New System.Drawing.Size(234, 26)
        Me.txtNroDocumento_SR.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(605, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "número:"
        '
        'cmbTipoPerfil
        '
        Me.cmbTipoPerfil.AccessibleDescription = "tipo"
        Me.cmbTipoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPerfil.FormattingEnabled = True
        Me.cmbTipoPerfil.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoPerfil.Location = New System.Drawing.Point(10, 36)
        Me.cmbTipoPerfil.Name = "cmbTipoPerfil"
        Me.cmbTipoPerfil.Size = New System.Drawing.Size(284, 28)
        Me.cmbTipoPerfil.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "tipo de perfil:"
        '
        'Grupo2
        '
        Me.Grupo2.Controls.Add(Me.txtAbreviado_AN)
        Me.Grupo2.Controls.Add(Me.Label4)
        Me.Grupo2.Controls.Add(Me.txtNombre_AN)
        Me.Grupo2.Enabled = False
        Me.Grupo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupo2.Location = New System.Drawing.Point(13, 169)
        Me.Grupo2.Name = "Grupo2"
        Me.Grupo2.Size = New System.Drawing.Size(862, 110)
        Me.Grupo2.TabIndex = 2
        Me.Grupo2.TabStop = False
        Me.Grupo2.Text = "Nombre y apellido / razón social"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Apodo, denominación comercial o sigla"
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
        'Grupo3
        '
        Me.Grupo3.Controls.Add(Me.Label7)
        Me.Grupo3.Controls.Add(Me.txtEmail_AN)
        Me.Grupo3.Controls.Add(Me.Label6)
        Me.Grupo3.Controls.Add(Me.txtTelefono_AN)
        Me.Grupo3.Controls.Add(Me.Label5)
        Me.Grupo3.Controls.Add(Me.txtCiudad_AN)
        Me.Grupo3.Controls.Add(Me.txtDireccion_AN)
        Me.Grupo3.Controls.Add(Me.Label8)
        Me.Grupo3.Enabled = False
        Me.Grupo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupo3.Location = New System.Drawing.Point(13, 285)
        Me.Grupo3.Name = "Grupo3"
        Me.Grupo3.Size = New System.Drawing.Size(862, 194)
        Me.Grupo3.TabIndex = 3
        Me.Grupo3.TabStop = False
        Me.Grupo3.Text = "Datos de ubicación y contacto"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "dirección:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleDescription = ""
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.gbxGrupo21)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(888, 494)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Restricciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbxGrupo21
        '
        Me.gbxGrupo21.Controls.Add(Me.lblNombreMoneda)
        Me.gbxGrupo21.Controls.Add(Me.txtCodMoneda_AN)
        Me.gbxGrupo21.Controls.Add(Me.Label14)
        Me.gbxGrupo21.Controls.Add(Me.lblLimiteHabilitacion)
        Me.gbxGrupo21.Controls.Add(Me.lblLimiteCredito)
        Me.gbxGrupo21.Controls.Add(Me.lblNombreSucursal)
        Me.gbxGrupo21.Controls.Add(Me.txtCodSucursal_NE)
        Me.gbxGrupo21.Controls.Add(Me.Label13)
        Me.gbxGrupo21.Controls.Add(Me.txtLimiteHabilitacion_ND)
        Me.gbxGrupo21.Controls.Add(Me.txtLimiteCredito_ND)
        Me.gbxGrupo21.Controls.Add(Me.Label10)
        Me.gbxGrupo21.Controls.Add(Me.txtDiasVencimiento_NE)
        Me.gbxGrupo21.Controls.Add(Me.Label11)
        Me.gbxGrupo21.Controls.Add(Me.Label12)
        Me.gbxGrupo21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo21.Location = New System.Drawing.Point(13, 16)
        Me.gbxGrupo21.Name = "gbxGrupo21"
        Me.gbxGrupo21.Size = New System.Drawing.Size(862, 152)
        Me.gbxGrupo21.TabIndex = 0
        Me.gbxGrupo21.TabStop = False
        Me.gbxGrupo21.Text = "parametros operativos"
        '
        'lblNombreMoneda
        '
        Me.lblNombreMoneda.AutoSize = True
        Me.lblNombreMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMoneda.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreMoneda.Location = New System.Drawing.Point(162, 65)
        Me.lblNombreMoneda.Name = "lblNombreMoneda"
        Me.lblNombreMoneda.Size = New System.Drawing.Size(93, 20)
        Me.lblNombreMoneda.TabIndex = 130
        Me.lblNombreMoneda.Text = "<moneda>"
        '
        'txtCodMoneda_AN
        '
        Me.txtCodMoneda_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMoneda_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMoneda_AN.Location = New System.Drawing.Point(166, 36)
        Me.txtCodMoneda_AN.Name = "txtCodMoneda_AN"
        Me.txtCodMoneda_AN.Size = New System.Drawing.Size(68, 26)
        Me.txtCodMoneda_AN.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(163, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "moneda:"
        '
        'lblLimiteHabilitacion
        '
        Me.lblLimiteHabilitacion.BackColor = System.Drawing.Color.White
        Me.lblLimiteHabilitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLimiteHabilitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimiteHabilitacion.Location = New System.Drawing.Point(614, 65)
        Me.lblLimiteHabilitacion.Name = "lblLimiteHabilitacion"
        Me.lblLimiteHabilitacion.Size = New System.Drawing.Size(216, 24)
        Me.lblLimiteHabilitacion.TabIndex = 4
        Me.lblLimiteHabilitacion.Text = "<limite habilitacion>"
        Me.lblLimiteHabilitacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLimiteCredito
        '
        Me.lblLimiteCredito.BackColor = System.Drawing.Color.White
        Me.lblLimiteCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLimiteCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimiteCredito.Location = New System.Drawing.Point(317, 65)
        Me.lblLimiteCredito.Name = "lblLimiteCredito"
        Me.lblLimiteCredito.Size = New System.Drawing.Size(214, 24)
        Me.lblLimiteCredito.TabIndex = 2
        Me.lblLimiteCredito.Text = "<limite credito>"
        Me.lblLimiteCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombreSucursal
        '
        Me.lblNombreSucursal.AutoSize = True
        Me.lblNombreSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreSucursal.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreSucursal.Location = New System.Drawing.Point(95, 108)
        Me.lblNombreSucursal.Name = "lblNombreSucursal"
        Me.lblNombreSucursal.Size = New System.Drawing.Size(166, 20)
        Me.lblNombreSucursal.TabIndex = 127
        Me.lblNombreSucursal.Text = "<nombre_sucursal>"
        '
        'txtCodSucursal_NE
        '
        Me.txtCodSucursal_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSucursal_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSucursal_NE.Location = New System.Drawing.Point(15, 106)
        Me.txtCodSucursal_NE.Name = "txtCodSucursal_NE"
        Me.txtCodSucursal_NE.Size = New System.Drawing.Size(74, 26)
        Me.txtCodSucursal_NE.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 15)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "sucursal:"
        '
        'txtLimiteHabilitacion_ND
        '
        Me.txtLimiteHabilitacion_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLimiteHabilitacion_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimiteHabilitacion_ND.Location = New System.Drawing.Point(614, 36)
        Me.txtLimiteHabilitacion_ND.Name = "txtLimiteHabilitacion_ND"
        Me.txtLimiteHabilitacion_ND.Size = New System.Drawing.Size(216, 26)
        Me.txtLimiteHabilitacion_ND.TabIndex = 5
        Me.txtLimiteHabilitacion_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLimiteCredito_ND
        '
        Me.txtLimiteCredito_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLimiteCredito_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimiteCredito_ND.Location = New System.Drawing.Point(317, 36)
        Me.txtLimiteCredito_ND.Name = "txtLimiteCredito_ND"
        Me.txtLimiteCredito_ND.Size = New System.Drawing.Size(214, 26)
        Me.txtLimiteCredito_ND.TabIndex = 3
        Me.txtLimiteCredito_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(410, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 15)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "limite de crédito"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiasVencimiento_NE
        '
        Me.txtDiasVencimiento_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiasVencimiento_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasVencimiento_NE.Location = New System.Drawing.Point(15, 36)
        Me.txtDiasVencimiento_NE.Name = "txtDiasVencimiento_NE"
        Me.txtDiasVencimiento_NE.Size = New System.Drawing.Size(68, 26)
        Me.txtDiasVencimiento_NE.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(659, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 15)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "limite liberación bloqueo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 15)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "días vencimiento:"
        '
        'TabPage3
        '
        Me.TabPage3.AccessibleName = "Activo"
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.cmbEstado)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(888, 494)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Complementario"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(92, 12)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 24)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Estado:"
        '
        'gbxGrupo0
        '
        Me.gbxGrupo0.Controls.Add(Me.lblNombreEmpresa)
        Me.gbxGrupo0.Controls.Add(Me.txtCodEmpresa_NE)
        Me.gbxGrupo0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo0.Location = New System.Drawing.Point(13, 6)
        Me.gbxGrupo0.Name = "gbxGrupo0"
        Me.gbxGrupo0.Size = New System.Drawing.Size(862, 65)
        Me.gbxGrupo0.TabIndex = 0
        Me.gbxGrupo0.TabStop = False
        Me.gbxGrupo0.Text = "empresa"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(133, 22)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(198, 20)
        Me.lblNombreEmpresa.TabIndex = 123
        Me.lblNombreEmpresa.Text = "<nombre_de_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(10, 20)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(117, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'frmFb060perautgest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(917, 671)
        Me.Name = "frmFb060perautgest"
        Me.Tag = ""
        Me.Text = "Formulario Perfil autorizado de gestión"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbxGrupo1.ResumeLayout(False)
        Me.gbxGrupo1.PerformLayout()
        Me.Grupo2.ResumeLayout(False)
        Me.Grupo2.PerformLayout()
        Me.Grupo3.ResumeLayout(False)
        Me.Grupo3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gbxGrupo21.ResumeLayout(False)
        Me.gbxGrupo21.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.gbxGrupo0.ResumeLayout(False)
        Me.gbxGrupo0.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxGrupo1 As GroupBox
    Friend WithEvents cmbTipoDocumento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNroDocumento_SR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoPerfil As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Grupo2 As GroupBox
    Friend WithEvents txtAbreviado_AN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre_AN As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Grupo3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail_AN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono_AN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCiudad_AN As TextBox
    Friend WithEvents txtDireccion_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents gbxGrupo21 As GroupBox
    Friend WithEvents txtLimiteHabilitacion_ND As TextBox
    Friend WithEvents txtLimiteCredito_ND As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDiasVencimiento_NE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNombreSucursal As Label
    Friend WithEvents txtCodSucursal_NE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents gbxGrupo0 As GroupBox
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents lblLimiteHabilitacion As Label
    Friend WithEvents lblLimiteCredito As Label
    Friend WithEvents lblNombreMoneda As Label
    Friend WithEvents txtCodMoneda_AN As TextBox
    Friend WithEvents Label14 As Label
End Class
