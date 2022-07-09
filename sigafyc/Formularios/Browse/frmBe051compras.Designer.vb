<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBe051compras
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomDocumento = New System.Windows.Forms.Label()
        Me.txtNumTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblNumComprobante = New System.Windows.Forms.Label()
        Me.lblFecOperacion = New System.Windows.Forms.Label()
        Me.lblFecRendicion = New System.Windows.Forms.Label()
        Me.lblCodMoneda = New System.Windows.Forms.Label()
        Me.lblCotizacion = New System.Windows.Forms.Label()
        Me.lblCondOperacion = New System.Windows.Forms.Label()
        Me.lblNumTimbrado = New System.Windows.Forms.Label()
        Me.lblTitSubTotales = New System.Windows.Forms.Label()
        Me.lblTotExenta = New System.Windows.Forms.Label()
        Me.lblTotGrav05 = New System.Windows.Forms.Label()
        Me.lblTotGrav10 = New System.Windows.Forms.Label()
        Me.lblTotGenera = New System.Windows.Forms.Label()
        Me.lblTitTotGenera = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIvaGrav10 = New System.Windows.Forms.Label()
        Me.lblIvaGrav05 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 169)
        Me.txtBuscar.Size = New System.Drawing.Size(1041, 22)
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1057, 565)
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Location = New System.Drawing.Point(1057, 478)
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(1057, 271)
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(1057, 184)
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(1057, 97)
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(1057, 10)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 197)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1041, 354)
        Me.DataGridView1.TabIndex = 25
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(222, 14)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(169, 20)
        Me.lblNombreEmpresa.TabIndex = 140
        Me.lblNombreEmpresa.Text = "<nombre de empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(142, 12)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(74, 26)
        Me.txtCodEmpresa_NE.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Empresa:"
        '
        'lblNomDocumento
        '
        Me.lblNomDocumento.AutoSize = True
        Me.lblNomDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNomDocumento.Location = New System.Drawing.Point(11, 118)
        Me.lblNomDocumento.Name = "lblNomDocumento"
        Me.lblNomDocumento.Size = New System.Drawing.Size(165, 20)
        Me.lblNomDocumento.TabIndex = 147
        Me.lblNomDocumento.Text = "<nombre documento>"
        '
        'txtNumTransaccion_NE
        '
        Me.txtNumTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTransaccion_NE.Location = New System.Drawing.Point(142, 44)
        Me.txtNumTransaccion_NE.Name = "txtNumTransaccion_NE"
        Me.txtNumTransaccion_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtNumTransaccion_NE.TabIndex = 141
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Transacción No.:"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRazonSocial.Location = New System.Drawing.Point(12, 75)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(554, 43)
        Me.lblRazonSocial.TabIndex = 149
        Me.lblRazonSocial.Text = "<nombre o razon social>"
        '
        'lblNumComprobante
        '
        Me.lblNumComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumComprobante.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNumComprobante.Location = New System.Drawing.Point(791, 40)
        Me.lblNumComprobante.Name = "lblNumComprobante"
        Me.lblNumComprobante.Size = New System.Drawing.Size(260, 20)
        Me.lblNumComprobante.TabIndex = 148
        Me.lblNumComprobante.Text = "XXX-XXX-XXXXXXX"
        Me.lblNumComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecOperacion
        '
        Me.lblFecOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecOperacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFecOperacion.Location = New System.Drawing.Point(791, 66)
        Me.lblFecOperacion.Name = "lblFecOperacion"
        Me.lblFecOperacion.Size = New System.Drawing.Size(260, 20)
        Me.lblFecOperacion.TabIndex = 150
        Me.lblFecOperacion.Text = "<aaaa-mm-dd>"
        Me.lblFecOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecRendicion
        '
        Me.lblFecRendicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecRendicion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFecRendicion.Location = New System.Drawing.Point(791, 92)
        Me.lblFecRendicion.Name = "lblFecRendicion"
        Me.lblFecRendicion.Size = New System.Drawing.Size(260, 20)
        Me.lblFecRendicion.TabIndex = 151
        Me.lblFecRendicion.Text = "<aaaa-mm-dd>"
        Me.lblFecRendicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodMoneda
        '
        Me.lblCodMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMoneda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCodMoneda.Location = New System.Drawing.Point(791, 118)
        Me.lblCodMoneda.Name = "lblCodMoneda"
        Me.lblCodMoneda.Size = New System.Drawing.Size(260, 20)
        Me.lblCodMoneda.TabIndex = 152
        Me.lblCodMoneda.Text = "<moneda_operacion>"
        Me.lblCodMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCotizacion
        '
        Me.lblCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotizacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCotizacion.Location = New System.Drawing.Point(791, 144)
        Me.lblCotizacion.Name = "lblCotizacion"
        Me.lblCotizacion.Size = New System.Drawing.Size(260, 20)
        Me.lblCotizacion.TabIndex = 153
        Me.lblCotizacion.Text = "<xxx.xxx>"
        Me.lblCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCondOperacion
        '
        Me.lblCondOperacion.AutoSize = True
        Me.lblCondOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondOperacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCondOperacion.Location = New System.Drawing.Point(12, 144)
        Me.lblCondOperacion.Name = "lblCondOperacion"
        Me.lblCondOperacion.Size = New System.Drawing.Size(141, 20)
        Me.lblCondOperacion.TabIndex = 154
        Me.lblCondOperacion.Text = "<cond_operacion>"
        '
        'lblNumTimbrado
        '
        Me.lblNumTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTimbrado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNumTimbrado.Location = New System.Drawing.Point(791, 10)
        Me.lblNumTimbrado.Name = "lblNumTimbrado"
        Me.lblNumTimbrado.Size = New System.Drawing.Size(260, 20)
        Me.lblNumTimbrado.TabIndex = 155
        Me.lblNumTimbrado.Text = "<numero timbrado>"
        Me.lblNumTimbrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitSubTotales
        '
        Me.lblTitSubTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitSubTotales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitSubTotales.Location = New System.Drawing.Point(331, 573)
        Me.lblTitSubTotales.Name = "lblTitSubTotales"
        Me.lblTitSubTotales.Size = New System.Drawing.Size(141, 20)
        Me.lblTitSubTotales.TabIndex = 156
        Me.lblTitSubTotales.Text = "Sub-Totales:"
        Me.lblTitSubTotales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotExenta
        '
        Me.lblTotExenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotExenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotExenta.Location = New System.Drawing.Point(481, 573)
        Me.lblTotExenta.Name = "lblTotExenta"
        Me.lblTotExenta.Size = New System.Drawing.Size(183, 20)
        Me.lblTotExenta.TabIndex = 157
        Me.lblTotExenta.Text = "Exenta"
        Me.lblTotExenta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotGrav05
        '
        Me.lblTotGrav05.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGrav05.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotGrav05.Location = New System.Drawing.Point(671, 573)
        Me.lblTotGrav05.Name = "lblTotGrav05"
        Me.lblTotGrav05.Size = New System.Drawing.Size(187, 20)
        Me.lblTotGrav05.TabIndex = 158
        Me.lblTotGrav05.Text = "Gravada5%"
        Me.lblTotGrav05.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotGrav10
        '
        Me.lblTotGrav10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGrav10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotGrav10.Location = New System.Drawing.Point(864, 573)
        Me.lblTotGrav10.Name = "lblTotGrav10"
        Me.lblTotGrav10.Size = New System.Drawing.Size(187, 20)
        Me.lblTotGrav10.TabIndex = 159
        Me.lblTotGrav10.Text = "Gravada10%"
        Me.lblTotGrav10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotGenera
        '
        Me.lblTotGenera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGenera.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotGenera.Location = New System.Drawing.Point(864, 626)
        Me.lblTotGenera.Name = "lblTotGenera"
        Me.lblTotGenera.Size = New System.Drawing.Size(187, 20)
        Me.lblTotGenera.TabIndex = 160
        Me.lblTotGenera.Text = "Gravada10%"
        Me.lblTotGenera.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitTotGenera
        '
        Me.lblTitTotGenera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitTotGenera.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitTotGenera.Location = New System.Drawing.Point(671, 626)
        Me.lblTitTotGenera.Name = "lblTitTotGenera"
        Me.lblTitTotGenera.Size = New System.Drawing.Size(187, 20)
        Me.lblTitTotGenera.TabIndex = 161
        Me.lblTitTotGenera.Text = "Total General:"
        Me.lblTitTotGenera.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(864, 555)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 14)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Gravada10%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(671, 555)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 14)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Gravada5%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(481, 555)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 14)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Exenta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIvaGrav10
        '
        Me.lblIvaGrav10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIvaGrav10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIvaGrav10.Location = New System.Drawing.Point(864, 600)
        Me.lblIvaGrav10.Name = "lblIvaGrav10"
        Me.lblIvaGrav10.Size = New System.Drawing.Size(187, 20)
        Me.lblIvaGrav10.TabIndex = 166
        Me.lblIvaGrav10.Text = "Gravada10%"
        Me.lblIvaGrav10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIvaGrav05
        '
        Me.lblIvaGrav05.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIvaGrav05.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIvaGrav05.Location = New System.Drawing.Point(671, 600)
        Me.lblIvaGrav05.Name = "lblIvaGrav05"
        Me.lblIvaGrav05.Size = New System.Drawing.Size(187, 20)
        Me.lblIvaGrav05.TabIndex = 165
        Me.lblIvaGrav05.Text = "Gravada5%"
        Me.lblIvaGrav05.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(481, 600)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 20)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Liquidacion de IVA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmBe051compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 657)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblIvaGrav10)
        Me.Controls.Add(Me.lblIvaGrav05)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTitTotGenera)
        Me.Controls.Add(Me.lblTotGenera)
        Me.Controls.Add(Me.lblTotGrav10)
        Me.Controls.Add(Me.lblTotGrav05)
        Me.Controls.Add(Me.lblTotExenta)
        Me.Controls.Add(Me.lblTitSubTotales)
        Me.Controls.Add(Me.lblNumTimbrado)
        Me.Controls.Add(Me.lblCondOperacion)
        Me.Controls.Add(Me.lblCotizacion)
        Me.Controls.Add(Me.lblCodMoneda)
        Me.Controls.Add(Me.lblFecRendicion)
        Me.Controls.Add(Me.lblFecOperacion)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.lblNumComprobante)
        Me.Controls.Add(Me.lblNomDocumento)
        Me.Controls.Add(Me.txtNumTransaccion_NE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNombreEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmBe051compras"
        Me.Tag = ""
        Me.Text = "Browse Detalle compras bienes  o servicios"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodEmpresa_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNombreEmpresa, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtNumTransaccion_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomDocumento, 0)
        Me.Controls.SetChildIndex(Me.lblNumComprobante, 0)
        Me.Controls.SetChildIndex(Me.lblRazonSocial, 0)
        Me.Controls.SetChildIndex(Me.lblFecOperacion, 0)
        Me.Controls.SetChildIndex(Me.lblFecRendicion, 0)
        Me.Controls.SetChildIndex(Me.lblCodMoneda, 0)
        Me.Controls.SetChildIndex(Me.lblCotizacion, 0)
        Me.Controls.SetChildIndex(Me.lblCondOperacion, 0)
        Me.Controls.SetChildIndex(Me.lblNumTimbrado, 0)
        Me.Controls.SetChildIndex(Me.lblTitSubTotales, 0)
        Me.Controls.SetChildIndex(Me.lblTotExenta, 0)
        Me.Controls.SetChildIndex(Me.lblTotGrav05, 0)
        Me.Controls.SetChildIndex(Me.lblTotGrav10, 0)
        Me.Controls.SetChildIndex(Me.lblTotGenera, 0)
        Me.Controls.SetChildIndex(Me.lblTitTotGenera, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblIvaGrav05, 0)
        Me.Controls.SetChildIndex(Me.lblIvaGrav10, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomDocumento As Label
    Friend WithEvents txtNumTransaccion_NE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblNumComprobante As Label
    Friend WithEvents lblFecOperacion As Label
    Friend WithEvents lblFecRendicion As Label
    Friend WithEvents lblCodMoneda As Label
    Friend WithEvents lblCotizacion As Label
    Friend WithEvents lblCondOperacion As Label
    Friend WithEvents lblNumTimbrado As Label
    Friend WithEvents lblTitSubTotales As Label
    Friend WithEvents lblTotExenta As Label
    Friend WithEvents lblTotGrav05 As Label
    Friend WithEvents lblTotGrav10 As Label
    Friend WithEvents lblTotGenera As Label
    Friend WithEvents lblTitTotGenera As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblIvaGrav10 As Label
    Friend WithEvents lblIvaGrav05 As Label
    Friend WithEvents Label8 As Label
End Class
