<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFe062entmercaderia
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
        Me.lblTotGeneral_mb = New System.Windows.Forms.Label()
        Me.lblGastImpuesto_mb_ND = New System.Windows.Forms.Label()
        Me.lblGastNeto_mb_ND = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTituloImporte = New System.Windows.Forms.Label()
        Me.txtTotGeneral_mb = New System.Windows.Forms.TextBox()
        Me.txtGastImpuesto_mb_ND = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtGastNeto_mb_ND = New System.Windows.Forms.TextBox()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.lblNomProveedor = New System.Windows.Forms.Label()
        Me.txtOrgTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumOrden_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(727, 263)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtNumOrden_NE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtNumTransaccion_NE)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lblNomEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblTotGeneral_mb)
        Me.TabPage1.Controls.Add(Me.lblGastImpuesto_mb_ND)
        Me.TabPage1.Controls.Add(Me.lblGastNeto_mb_ND)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblTituloImporte)
        Me.TabPage1.Controls.Add(Me.txtTotGeneral_mb)
        Me.TabPage1.Controls.Add(Me.txtGastImpuesto_mb_ND)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtGastNeto_mb_ND)
        Me.TabPage1.Controls.Add(Me.lblDocumento)
        Me.TabPage1.Controls.Add(Me.lblIdentificacion)
        Me.TabPage1.Controls.Add(Me.lblNomProveedor)
        Me.TabPage1.Controls.Add(Me.txtOrgTransaccion_NE)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Size = New System.Drawing.Size(719, 227)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 314)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(602, 314)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(723, 25)
        '
        'lblTotGeneral_mb
        '
        Me.lblTotGeneral_mb.AutoSize = True
        Me.lblTotGeneral_mb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotGeneral_mb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGeneral_mb.Location = New System.Drawing.Point(624, 211)
        Me.lblTotGeneral_mb.Name = "lblTotGeneral_mb"
        Me.lblTotGeneral_mb.Size = New System.Drawing.Size(69, 22)
        Me.lblTotGeneral_mb.TabIndex = 258
        Me.lblTotGeneral_mb.Text = "<valor>"
        Me.lblTotGeneral_mb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotGeneral_mb.Visible = False
        '
        'lblGastImpuesto_mb_ND
        '
        Me.lblGastImpuesto_mb_ND.AutoSize = True
        Me.lblGastImpuesto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGastImpuesto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastImpuesto_mb_ND.Location = New System.Drawing.Point(449, 211)
        Me.lblGastImpuesto_mb_ND.Name = "lblGastImpuesto_mb_ND"
        Me.lblGastImpuesto_mb_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblGastImpuesto_mb_ND.TabIndex = 257
        Me.lblGastImpuesto_mb_ND.Text = "<valor>"
        Me.lblGastImpuesto_mb_ND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGastImpuesto_mb_ND.Visible = False
        '
        'lblGastNeto_mb_ND
        '
        Me.lblGastNeto_mb_ND.AutoSize = True
        Me.lblGastNeto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGastNeto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastNeto_mb_ND.Location = New System.Drawing.Point(274, 211)
        Me.lblGastNeto_mb_ND.Name = "lblGastNeto_mb_ND"
        Me.lblGastNeto_mb_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblGastNeto_mb_ND.TabIndex = 255
        Me.lblGastNeto_mb_ND.Text = "<valor>"
        Me.lblGastNeto_mb_ND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGastNeto_mb_ND.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(570, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 16)
        Me.Label8.TabIndex = 253
        Me.Label8.Text = "total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(25, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 16)
        Me.Label7.TabIndex = 252
        Me.Label7.Text = "Importe de gasto:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTituloImporte
        '
        Me.lblTituloImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloImporte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTituloImporte.Location = New System.Drawing.Point(11, 139)
        Me.lblTituloImporte.Name = "lblTituloImporte"
        Me.lblTituloImporte.Size = New System.Drawing.Size(694, 20)
        Me.lblTituloImporte.TabIndex = 250
        Me.lblTituloImporte.Text = "───────────────────────────────────────────────────────────"
        Me.lblTituloImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotGeneral_mb
        '
        Me.txtTotGeneral_mb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotGeneral_mb.Enabled = False
        Me.txtTotGeneral_mb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGeneral_mb.Location = New System.Drawing.Point(524, 182)
        Me.txtTotGeneral_mb.Name = "txtTotGeneral_mb"
        Me.txtTotGeneral_mb.Size = New System.Drawing.Size(169, 26)
        Me.txtTotGeneral_mb.TabIndex = 249
        Me.txtTotGeneral_mb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGastImpuesto_mb_ND
        '
        Me.txtGastImpuesto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGastImpuesto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastImpuesto_mb_ND.Location = New System.Drawing.Point(349, 182)
        Me.txtGastImpuesto_mb_ND.Name = "txtGastImpuesto_mb_ND"
        Me.txtGastImpuesto_mb_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtGastImpuesto_mb_ND.TabIndex = 235
        Me.txtGastImpuesto_mb_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(395, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 16)
        Me.Label16.TabIndex = 248
        Me.Label16.Text = "impuesto"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(252, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 16)
        Me.Label17.TabIndex = 247
        Me.Label17.Text = "neto"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGastNeto_mb_ND
        '
        Me.txtGastNeto_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGastNeto_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastNeto_mb_ND.Location = New System.Drawing.Point(174, 182)
        Me.txtGastNeto_mb_ND.Name = "txtGastNeto_mb_ND"
        Me.txtGastNeto_mb_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtGastNeto_mb_ND.TabIndex = 233
        Me.txtGastNeto_mb_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Navy
        Me.lblDocumento.Location = New System.Drawing.Point(282, 122)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(125, 16)
        Me.lblDocumento.TabIndex = 246
        Me.lblDocumento.Text = "<tipo>: <numero>"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacion.ForeColor = System.Drawing.Color.Navy
        Me.lblIdentificacion.Location = New System.Drawing.Point(282, 102)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(166, 16)
        Me.lblIdentificacion.TabIndex = 245
        Me.lblIdentificacion.Text = "<doc>: <identificacion>"
        '
        'lblNomProveedor
        '
        Me.lblNomProveedor.AutoSize = True
        Me.lblNomProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblNomProveedor.Location = New System.Drawing.Point(282, 82)
        Me.lblNomProveedor.Name = "lblNomProveedor"
        Me.lblNomProveedor.Size = New System.Drawing.Size(192, 16)
        Me.lblNomProveedor.TabIndex = 244
        Me.lblNomProveedor.Text = "<razon_social_proveedor>"
        '
        'txtOrgTransaccion_NE
        '
        Me.txtOrgTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrgTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrgTransaccion_NE.Location = New System.Drawing.Point(161, 82)
        Me.txtOrgTransaccion_NE.Name = "txtOrgTransaccion_NE"
        Me.txtOrgTransaccion_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtOrgTransaccion_NE.TabIndex = 231
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 243
        Me.Label2.Text = "Trans. origen No.:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(719, 227)
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
        Me.cmbEstado.Location = New System.Drawing.Point(102, 14)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(145, 28)
        Me.cmbEstado.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 20)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Estado:"
        '
        'txtNumOrden_NE
        '
        Me.txtNumOrden_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumOrden_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOrden_NE.Location = New System.Drawing.Point(624, 50)
        Me.txtNumOrden_NE.Name = "txtNumOrden_NE"
        Me.txtNumOrden_NE.Size = New System.Drawing.Size(69, 26)
        Me.txtNumOrden_NE.TabIndex = 261
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(533, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 265
        Me.Label1.Text = "Orden No.:"
        '
        'txtNumTransaccion_NE
        '
        Me.txtNumTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTransaccion_NE.Location = New System.Drawing.Point(161, 50)
        Me.txtNumTransaccion_NE.Name = "txtNumTransaccion_NE"
        Me.txtNumTransaccion_NE.Size = New System.Drawing.Size(84, 26)
        Me.txtNumTransaccion_NE.TabIndex = 260
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 264
        Me.Label3.Text = "Transacción No.:"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(251, 20)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(168, 20)
        Me.lblNomEmpresa.TabIndex = 263
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(161, 18)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(84, 26)
        Me.txtCodEmpresa_NE.TabIndex = 259
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "Empresa:"
        '
        'frmFe062entmercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(744, 399)
        Me.Name = "frmFe062entmercaderia"
        Me.Tag = ""
        Me.Text = "Formulario costeo de mercaderia - gasto adicional"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTotGeneral_mb As Label
    Friend WithEvents lblGastImpuesto_mb_ND As Label
    Friend WithEvents lblGastNeto_mb_ND As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTituloImporte As Label
    Friend WithEvents txtTotGeneral_mb As TextBox
    Friend WithEvents txtGastImpuesto_mb_ND As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGastNeto_mb_ND As TextBox
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents lblNomProveedor As Label
    Friend WithEvents txtOrgTransaccion_NE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtNumOrden_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumTransaccion_NE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label13 As Label
End Class
