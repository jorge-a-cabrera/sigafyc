<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBe062entmercaderia
    Inherits frmBrowseSinGrid

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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrgTransaccion = New System.Windows.Forms.Label()
        Me.lblFecVigencia = New System.Windows.Forms.Label()
        Me.lblFecOperacion = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.lblNomProveedor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblNomDeposito = New System.Windows.Forms.Label()
        Me.txtNumTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotGeneral = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblGastImpuesto = New System.Windows.Forms.Label()
        Me.lblGastNeto = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 188)
        '
        'btnAuditoria
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(448, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 16)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "Datos del proveedor/documento:"
        '
        'lblOrgTransaccion
        '
        Me.lblOrgTransaccion.AutoSize = True
        Me.lblOrgTransaccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrgTransaccion.ForeColor = System.Drawing.Color.Navy
        Me.lblOrgTransaccion.Location = New System.Drawing.Point(155, 159)
        Me.lblOrgTransaccion.Name = "lblOrgTransaccion"
        Me.lblOrgTransaccion.Size = New System.Drawing.Size(172, 18)
        Me.lblOrgTransaccion.TabIndex = 242
        Me.lblOrgTransaccion.Text = "<transaccion_origen>"
        '
        'lblFecVigencia
        '
        Me.lblFecVigencia.AutoSize = True
        Me.lblFecVigencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecVigencia.ForeColor = System.Drawing.Color.Navy
        Me.lblFecVigencia.Location = New System.Drawing.Point(155, 131)
        Me.lblFecVigencia.Name = "lblFecVigencia"
        Me.lblFecVigencia.Size = New System.Drawing.Size(139, 18)
        Me.lblFecVigencia.TabIndex = 241
        Me.lblFecVigencia.Text = "<fecha_vigencia>"
        '
        'lblFecOperacion
        '
        Me.lblFecOperacion.AutoSize = True
        Me.lblFecOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecOperacion.ForeColor = System.Drawing.Color.Navy
        Me.lblFecOperacion.Location = New System.Drawing.Point(155, 101)
        Me.lblFecOperacion.Name = "lblFecOperacion"
        Me.lblFecOperacion.Size = New System.Drawing.Size(153, 18)
        Me.lblFecOperacion.TabIndex = 240
        Me.lblFecOperacion.Text = "<fecha_operacion>"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Navy
        Me.lblDocumento.Location = New System.Drawing.Point(448, 133)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(125, 16)
        Me.lblDocumento.TabIndex = 239
        Me.lblDocumento.Text = "<tipo>: <numero>"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacion.ForeColor = System.Drawing.Color.Navy
        Me.lblIdentificacion.Location = New System.Drawing.Point(448, 113)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(166, 16)
        Me.lblIdentificacion.TabIndex = 238
        Me.lblIdentificacion.Text = "<doc>: <identificacion>"
        '
        'lblNomProveedor
        '
        Me.lblNomProveedor.AutoSize = True
        Me.lblNomProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblNomProveedor.Location = New System.Drawing.Point(448, 93)
        Me.lblNomProveedor.Name = "lblNomProveedor"
        Me.lblNomProveedor.Size = New System.Drawing.Size(192, 16)
        Me.lblNomProveedor.TabIndex = 237
        Me.lblNomProveedor.Text = "<razon_social_proveedor>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 236
        Me.Label2.Text = "Origen Trans. No.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 235
        Me.Label10.Text = "Vigencia:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 234
        Me.Label13.Text = "Operación:"
        '
        'lblNomDeposito
        '
        Me.lblNomDeposito.AutoSize = True
        Me.lblNomDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomDeposito.ForeColor = System.Drawing.Color.Navy
        Me.lblNomDeposito.Location = New System.Drawing.Point(7, 71)
        Me.lblNomDeposito.Name = "lblNomDeposito"
        Me.lblNomDeposito.Size = New System.Drawing.Size(159, 18)
        Me.lblNomDeposito.TabIndex = 233
        Me.lblNomDeposito.Text = "<nombre_deposito>"
        '
        'txtNumTransaccion_NE
        '
        Me.txtNumTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTransaccion_NE.Location = New System.Drawing.Point(158, 39)
        Me.txtNumTransaccion_NE.Name = "txtNumTransaccion_NE"
        Me.txtNumTransaccion_NE.Size = New System.Drawing.Size(86, 24)
        Me.txtNumTransaccion_NE.TabIndex = 229
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Transacción No.:"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(250, 11)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(159, 18)
        Me.lblNomEmpresa.TabIndex = 231
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(158, 9)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(86, 24)
        Me.txtCodEmpresa_NE.TabIndex = 228
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Empresa:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 216)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(851, 391)
        Me.DataGridView1.TabIndex = 244
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(674, 610)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 14)
        Me.Label5.TabIndex = 255
        Me.Label5.Text = "General"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(481, 610)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 14)
        Me.Label7.TabIndex = 254
        Me.Label7.Text = "Impuesto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(292, 610)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 14)
        Me.Label9.TabIndex = 253
        Me.Label9.Text = "Neto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotGeneral
        '
        Me.lblTotGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGeneral.ForeColor = System.Drawing.Color.Navy
        Me.lblTotGeneral.Location = New System.Drawing.Point(674, 630)
        Me.lblTotGeneral.Name = "lblTotGeneral"
        Me.lblTotGeneral.Size = New System.Drawing.Size(187, 20)
        Me.lblTotGeneral.TabIndex = 248
        Me.lblTotGeneral.Text = "Gravada10%"
        Me.lblTotGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(99, 631)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 20)
        Me.Label8.TabIndex = 247
        Me.Label8.Text = "Totales importe:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGastImpuesto
        '
        Me.lblGastImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastImpuesto.ForeColor = System.Drawing.Color.Navy
        Me.lblGastImpuesto.Location = New System.Drawing.Point(481, 631)
        Me.lblGastImpuesto.Name = "lblGastImpuesto"
        Me.lblGastImpuesto.Size = New System.Drawing.Size(187, 20)
        Me.lblGastImpuesto.TabIndex = 246
        Me.lblGastImpuesto.Text = "Gravada10%"
        Me.lblGastImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGastNeto
        '
        Me.lblGastNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGastNeto.ForeColor = System.Drawing.Color.Navy
        Me.lblGastNeto.Location = New System.Drawing.Point(288, 631)
        Me.lblGastNeto.Name = "lblGastNeto"
        Me.lblGastNeto.Size = New System.Drawing.Size(187, 20)
        Me.lblGastNeto.TabIndex = 245
        Me.lblGastNeto.Text = "Gravada5%"
        Me.lblGastNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmBe062entmercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 657)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotGeneral)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblGastImpuesto)
        Me.Controls.Add(Me.lblGastNeto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOrgTransaccion)
        Me.Controls.Add(Me.lblFecVigencia)
        Me.Controls.Add(Me.lblFecOperacion)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.lblNomProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblNomDeposito)
        Me.Controls.Add(Me.txtNumTransaccion_NE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNomEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmBe062entmercaderia"
        Me.Tag = ""
        Me.Text = "Browse costeo de mercaderia - gastos adicionales"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtCodEmpresa_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomEmpresa, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNumTransaccion_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomDeposito, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblNomProveedor, 0)
        Me.Controls.SetChildIndex(Me.lblIdentificacion, 0)
        Me.Controls.SetChildIndex(Me.lblDocumento, 0)
        Me.Controls.SetChildIndex(Me.lblFecOperacion, 0)
        Me.Controls.SetChildIndex(Me.lblFecVigencia, 0)
        Me.Controls.SetChildIndex(Me.lblOrgTransaccion, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.lblGastNeto, 0)
        Me.Controls.SetChildIndex(Me.lblGastImpuesto, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.lblTotGeneral, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents lblOrgTransaccion As Label
    Friend WithEvents lblFecVigencia As Label
    Friend WithEvents lblFecOperacion As Label
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents lblNomProveedor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblNomDeposito As Label
    Friend WithEvents txtNumTransaccion_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotGeneral As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblGastImpuesto As Label
    Friend WithEvents lblGastNeto As Label
End Class
