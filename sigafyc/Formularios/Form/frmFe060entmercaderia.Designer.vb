<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFe060entmercaderia
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNomDeposito = New System.Windows.Forms.Label()
        Me.txtCodDeposito_NE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecVigencia_FE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFecOperacion_FE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOrgTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNomProveedor = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblTituloSubTotalesNeto = New System.Windows.Forms.Label()
        Me.lblTituloImporte = New System.Windows.Forms.Label()
        Me.txtTotalGeneral_mb = New System.Windows.Forms.TextBox()
        Me.txtGastImpuesto_mb_ND = New System.Windows.Forms.TextBox()
        Me.txtCompImpuesto_mb_ND = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtGastNeto_mb_ND = New System.Windows.Forms.TextBox()
        Me.txtCompNeta_mb_ND = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblGastImpuesto_mb_ND = New System.Windows.Forms.Label()
        Me.lblCompImpuesto_mb_ND = New System.Windows.Forms.Label()
        Me.lblGastNeto_mb_ND = New System.Windows.Forms.Label()
        Me.lblCompNeta_mb_ND = New System.Windows.Forms.Label()
        Me.lblTotalGeneral_mb = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(729, 408)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTotalGeneral_mb)
        Me.TabPage1.Controls.Add(Me.lblGastImpuesto_mb_ND)
        Me.TabPage1.Controls.Add(Me.lblCompImpuesto_mb_ND)
        Me.TabPage1.Controls.Add(Me.lblGastNeto_mb_ND)
        Me.TabPage1.Controls.Add(Me.lblCompNeta_mb_ND)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblTituloSubTotalesNeto)
        Me.TabPage1.Controls.Add(Me.lblTituloImporte)
        Me.TabPage1.Controls.Add(Me.txtTotalGeneral_mb)
        Me.TabPage1.Controls.Add(Me.txtGastImpuesto_mb_ND)
        Me.TabPage1.Controls.Add(Me.txtCompImpuesto_mb_ND)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtGastNeto_mb_ND)
        Me.TabPage1.Controls.Add(Me.txtCompNeta_mb_ND)
        Me.TabPage1.Controls.Add(Me.lblDocumento)
        Me.TabPage1.Controls.Add(Me.lblIdentificacion)
        Me.TabPage1.Controls.Add(Me.lblNomProveedor)
        Me.TabPage1.Controls.Add(Me.txtOrgTransaccion_NE)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtFecVigencia_FE)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtFecOperacion_FE)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.lblNomDeposito)
        Me.TabPage1.Controls.Add(Me.txtCodDeposito_NE)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtNumTransaccion_NE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblNomEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Size = New System.Drawing.Size(721, 372)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 459)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(604, 459)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(725, 25)
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(721, 372)
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
        Me.cmbEstado.Location = New System.Drawing.Point(161, 15)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(150, 28)
        Me.cmbEstado.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Estado:"
        '
        'txtNumTransaccion_NE
        '
        Me.txtNumTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTransaccion_NE.Location = New System.Drawing.Point(161, 47)
        Me.txtNumTransaccion_NE.Name = "txtNumTransaccion_NE"
        Me.txtNumTransaccion_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtNumTransaccion_NE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "Transacción No.:"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(282, 17)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(168, 20)
        Me.lblNomEmpresa.TabIndex = 193
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(161, 15)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Empresa:"
        '
        'lblNomDeposito
        '
        Me.lblNomDeposito.AutoSize = True
        Me.lblNomDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomDeposito.ForeColor = System.Drawing.Color.Navy
        Me.lblNomDeposito.Location = New System.Drawing.Point(282, 81)
        Me.lblNomDeposito.Name = "lblNomDeposito"
        Me.lblNomDeposito.Size = New System.Drawing.Size(168, 20)
        Me.lblNomDeposito.TabIndex = 197
        Me.lblNomDeposito.Text = "<nombre_deposito>"
        '
        'txtCodDeposito_NE
        '
        Me.txtCodDeposito_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDeposito_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDeposito_NE.Location = New System.Drawing.Point(161, 79)
        Me.txtCodDeposito_NE.Name = "txtCodDeposito_NE"
        Me.txtCodDeposito_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodDeposito_NE.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 196
        Me.Label5.Text = "Deposito:"
        '
        'txtFecVigencia_FE
        '
        Me.txtFecVigencia_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecVigencia_FE.Location = New System.Drawing.Point(161, 143)
        Me.txtFecVigencia_FE.Name = "txtFecVigencia_FE"
        Me.txtFecVigencia_FE.Size = New System.Drawing.Size(115, 26)
        Me.txtFecVigencia_FE.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "Fecha vigencia:"
        '
        'txtFecOperacion_FE
        '
        Me.txtFecOperacion_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecOperacion_FE.Location = New System.Drawing.Point(161, 111)
        Me.txtFecOperacion_FE.Name = "txtFecOperacion_FE"
        Me.txtFecOperacion_FE.Size = New System.Drawing.Size(115, 26)
        Me.txtFecOperacion_FE.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 20)
        Me.Label13.TabIndex = 200
        Me.Label13.Text = "Fecha operación:"
        '
        'txtOrgTransaccion_NE
        '
        Me.txtOrgTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrgTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrgTransaccion_NE.Location = New System.Drawing.Point(161, 175)
        Me.txtOrgTransaccion_NE.Name = "txtOrgTransaccion_NE"
        Me.txtOrgTransaccion_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtOrgTransaccion_NE.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "Trans. origen No.:"
        '
        'lblNomProveedor
        '
        Me.lblNomProveedor.AutoSize = True
        Me.lblNomProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblNomProveedor.Location = New System.Drawing.Point(282, 177)
        Me.lblNomProveedor.Name = "lblNomProveedor"
        Me.lblNomProveedor.Size = New System.Drawing.Size(192, 16)
        Me.lblNomProveedor.TabIndex = 204
        Me.lblNomProveedor.Text = "<razon_social_proveedor>"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacion.ForeColor = System.Drawing.Color.Navy
        Me.lblIdentificacion.Location = New System.Drawing.Point(282, 197)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(166, 16)
        Me.lblIdentificacion.TabIndex = 205
        Me.lblIdentificacion.Text = "<doc>: <identificacion>"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Navy
        Me.lblDocumento.Location = New System.Drawing.Point(282, 217)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(125, 16)
        Me.lblDocumento.TabIndex = 206
        Me.lblDocumento.Text = "<tipo>: <numero>"
        '
        'lblTituloSubTotalesNeto
        '
        Me.lblTituloSubTotalesNeto.AutoSize = True
        Me.lblTituloSubTotalesNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloSubTotalesNeto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTituloSubTotalesNeto.Location = New System.Drawing.Point(25, 332)
        Me.lblTituloSubTotalesNeto.Name = "lblTituloSubTotalesNeto"
        Me.lblTituloSubTotalesNeto.Size = New System.Drawing.Size(143, 16)
        Me.lblTituloSubTotalesNeto.TabIndex = 217
        Me.lblTituloSubTotalesNeto.Text = "Sub-Totales de IVA"
        '
        'lblTituloImporte
        '
        Me.lblTituloImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloImporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTituloImporte.Location = New System.Drawing.Point(11, 252)
        Me.lblTituloImporte.Name = "lblTituloImporte"
        Me.lblTituloImporte.Size = New System.Drawing.Size(694, 20)
        Me.lblTituloImporte.TabIndex = 216
        Me.lblTituloImporte.Text = "───────────────────────────────────────────────────────────"
        Me.lblTituloImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalGeneral_mb
        '
        Me.txtTotalGeneral_mb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalGeneral_mb.Enabled = False
        Me.txtTotalGeneral_mb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGeneral_mb.Location = New System.Drawing.Point(524, 295)
        Me.txtTotalGeneral_mb.Name = "txtTotalGeneral_mb"
        Me.txtTotalGeneral_mb.Size = New System.Drawing.Size(169, 26)
        Me.txtTotalGeneral_mb.TabIndex = 215
        Me.txtTotalGeneral_mb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGastImpuesto_mb_ND
        '
        Me.txtGastImpuesto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGastImpuesto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastImpuesto_mb_ND.Location = New System.Drawing.Point(349, 327)
        Me.txtGastImpuesto_mb_ND.Name = "txtGastImpuesto_mb_ND"
        Me.txtGastImpuesto_mb_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtGastImpuesto_mb_ND.TabIndex = 9
        Me.txtGastImpuesto_mb_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCompImpuesto_mb_ND
        '
        Me.txtCompImpuesto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompImpuesto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompImpuesto_mb_ND.Location = New System.Drawing.Point(174, 327)
        Me.txtCompImpuesto_mb_ND.Name = "txtCompImpuesto_mb_ND"
        Me.txtCompImpuesto_mb_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtCompImpuesto_mb_ND.TabIndex = 8
        Me.txtCompImpuesto_mb_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(395, 272)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 16)
        Me.Label16.TabIndex = 212
        Me.Label16.Text = "gastos"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(252, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 16)
        Me.Label17.TabIndex = 211
        Me.Label17.Text = "compras"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGastNeto_mb_ND
        '
        Me.txtGastNeto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGastNeto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastNeto_mb_ND.Location = New System.Drawing.Point(349, 295)
        Me.txtGastNeto_mb_ND.Name = "txtGastNeto_mb_ND"
        Me.txtGastNeto_mb_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtGastNeto_mb_ND.TabIndex = 7
        Me.txtGastNeto_mb_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCompNeta_mb_ND
        '
        Me.txtCompNeta_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompNeta_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompNeta_mb_ND.Location = New System.Drawing.Point(174, 295)
        Me.txtCompNeta_mb_ND.Name = "txtCompNeta_mb_ND"
        Me.txtCompNeta_mb_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtCompNeta_mb_ND.TabIndex = 6
        Me.txtCompNeta_mb_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(25, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 16)
        Me.Label7.TabIndex = 218
        Me.Label7.Text = "Sub-Importe neto"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(570, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 16)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGastImpuesto_mb_ND
        '
        Me.lblGastImpuesto_mb_ND.AutoSize = True
        Me.lblGastImpuesto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGastImpuesto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastImpuesto_mb_ND.Location = New System.Drawing.Point(644, 27)
        Me.lblGastImpuesto_mb_ND.Name = "lblGastImpuesto_mb_ND"
        Me.lblGastImpuesto_mb_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblGastImpuesto_mb_ND.TabIndex = 224
        Me.lblGastImpuesto_mb_ND.Text = "<valor>"
        Me.lblGastImpuesto_mb_ND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompImpuesto_mb_ND
        '
        Me.lblCompImpuesto_mb_ND.AutoSize = True
        Me.lblCompImpuesto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCompImpuesto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompImpuesto_mb_ND.Location = New System.Drawing.Point(569, 26)
        Me.lblCompImpuesto_mb_ND.Name = "lblCompImpuesto_mb_ND"
        Me.lblCompImpuesto_mb_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblCompImpuesto_mb_ND.TabIndex = 222
        Me.lblCompImpuesto_mb_ND.Text = "<valor>"
        Me.lblCompImpuesto_mb_ND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGastNeto_mb_ND
        '
        Me.lblGastNeto_mb_ND.AutoSize = True
        Me.lblGastNeto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGastNeto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastNeto_mb_ND.Location = New System.Drawing.Point(644, 3)
        Me.lblGastNeto_mb_ND.Name = "lblGastNeto_mb_ND"
        Me.lblGastNeto_mb_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblGastNeto_mb_ND.TabIndex = 221
        Me.lblGastNeto_mb_ND.Text = "<valor>"
        Me.lblGastNeto_mb_ND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompNeta_mb_ND
        '
        Me.lblCompNeta_mb_ND.AutoSize = True
        Me.lblCompNeta_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCompNeta_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompNeta_mb_ND.Location = New System.Drawing.Point(569, 3)
        Me.lblCompNeta_mb_ND.Name = "lblCompNeta_mb_ND"
        Me.lblCompNeta_mb_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblCompNeta_mb_ND.TabIndex = 220
        Me.lblCompNeta_mb_ND.Text = "<valor>"
        Me.lblCompNeta_mb_ND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalGeneral_mb
        '
        Me.lblTotalGeneral_mb.AutoSize = True
        Me.lblTotalGeneral_mb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGeneral_mb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGeneral_mb.Location = New System.Drawing.Point(644, 51)
        Me.lblTotalGeneral_mb.Name = "lblTotalGeneral_mb"
        Me.lblTotalGeneral_mb.Size = New System.Drawing.Size(69, 22)
        Me.lblTotalGeneral_mb.TabIndex = 225
        Me.lblTotalGeneral_mb.Text = "<valor>"
        Me.lblTotalGeneral_mb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmFe060entmercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(745, 539)
        Me.Name = "frmFe060entmercaderia"
        Me.Tag = ""
        Me.Text = "Formulario entrada y costeo de mercaderia"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtNumTransaccion_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNomDeposito As Label
    Friend WithEvents txtCodDeposito_NE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFecVigencia_FE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFecOperacion_FE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents lblNomProveedor As Label
    Friend WithEvents txtOrgTransaccion_NE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTituloSubTotalesNeto As Label
    Friend WithEvents lblTituloImporte As Label
    Friend WithEvents txtTotalGeneral_mb As TextBox
    Friend WithEvents txtGastImpuesto_mb_ND As TextBox
    Friend WithEvents txtCompImpuesto_mb_ND As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGastNeto_mb_ND As TextBox
    Friend WithEvents txtCompNeta_mb_ND As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblGastImpuesto_mb_ND As Label
    Friend WithEvents lblCompImpuesto_mb_ND As Label
    Friend WithEvents lblGastNeto_mb_ND As Label
    Friend WithEvents lblCompNeta_mb_ND As Label
    Friend WithEvents lblTotalGeneral_mb As Label
End Class
