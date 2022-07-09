<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFe051compras
    Inherits frmFormulario

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
        Me.txtNumTransaccion_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNumOrden_NE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxMercaderia = New System.Windows.Forms.GroupBox()
        Me.lblNomMercaderia = New System.Windows.Forms.Label()
        Me.txtCodMercaderia_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodUnidad_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNomUnidad = New System.Windows.Forms.Label()
        Me.txtCantCompra_ND = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecUnitario_in_ND = New System.Windows.Forms.TextBox()
        Me.lblPrecUnitario = New System.Windows.Forms.Label()
        Me.lblCantCompra_real = New System.Windows.Forms.Label()
        Me.lblPrecUnitario_in_ND = New System.Windows.Forms.Label()
        Me.lblCantCompra_ND = New System.Windows.Forms.Label()
        Me.txtImpTotal_in_ND = New System.Windows.Forms.TextBox()
        Me.lblTitImporteTotal = New System.Windows.Forms.Label()
        Me.lblImpTotal_in_ND = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbxMercaderia.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(622, 365)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblImpTotal_in_ND)
        Me.TabPage1.Controls.Add(Me.lblTitImporteTotal)
        Me.TabPage1.Controls.Add(Me.txtImpTotal_in_ND)
        Me.TabPage1.Controls.Add(Me.lblCantCompra_ND)
        Me.TabPage1.Controls.Add(Me.lblPrecUnitario_in_ND)
        Me.TabPage1.Controls.Add(Me.lblCantCompra_real)
        Me.TabPage1.Controls.Add(Me.txtPrecUnitario_in_ND)
        Me.TabPage1.Controls.Add(Me.lblPrecUnitario)
        Me.TabPage1.Controls.Add(Me.txtCantCompra_ND)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lblNomUnidad)
        Me.TabPage1.Controls.Add(Me.txtCodUnidad_AN)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.gbxMercaderia)
        Me.TabPage1.Controls.Add(Me.txtNumOrden_NE)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtNumTransaccion_NE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblNomEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Size = New System.Drawing.Size(614, 329)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 416)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(497, 416)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(618, 25)
        '
        'txtNumTransaccion_NE
        '
        Me.txtNumTransaccion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTransaccion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTransaccion_NE.Location = New System.Drawing.Point(189, 47)
        Me.txtNumTransaccion_NE.Name = "txtNumTransaccion_NE"
        Me.txtNumTransaccion_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtNumTransaccion_NE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Transacción No.:"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(310, 17)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(168, 20)
        Me.lblNomEmpresa.TabIndex = 100
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(189, 15)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Empresa:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(614, 329)
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
        Me.cmbEstado.Location = New System.Drawing.Point(84, 13)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(145, 28)
        Me.cmbEstado.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Estado:"
        '
        'txtNumOrden_NE
        '
        Me.txtNumOrden_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumOrden_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOrden_NE.Location = New System.Drawing.Point(475, 47)
        Me.txtNumOrden_NE.Name = "txtNumOrden_NE"
        Me.txtNumOrden_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtNumOrden_NE.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Orden No.:"
        '
        'gbxMercaderia
        '
        Me.gbxMercaderia.Controls.Add(Me.lblNomMercaderia)
        Me.gbxMercaderia.Controls.Add(Me.txtCodMercaderia_AN)
        Me.gbxMercaderia.Controls.Add(Me.Label8)
        Me.gbxMercaderia.Location = New System.Drawing.Point(20, 79)
        Me.gbxMercaderia.Name = "gbxMercaderia"
        Me.gbxMercaderia.Size = New System.Drawing.Size(573, 94)
        Me.gbxMercaderia.TabIndex = 2
        Me.gbxMercaderia.TabStop = False
        Me.gbxMercaderia.Text = "bien o servicio"
        '
        'lblNomMercaderia
        '
        Me.lblNomMercaderia.AutoSize = True
        Me.lblNomMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomMercaderia.ForeColor = System.Drawing.Color.Navy
        Me.lblNomMercaderia.Location = New System.Drawing.Point(16, 54)
        Me.lblNomMercaderia.Name = "lblNomMercaderia"
        Me.lblNomMercaderia.Size = New System.Drawing.Size(203, 20)
        Me.lblNomMercaderia.TabIndex = 131
        Me.lblNomMercaderia.Text = "<nombre_bien_servicio>"
        '
        'txtCodMercaderia_AN
        '
        Me.txtCodMercaderia_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMercaderia_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMercaderia_AN.Location = New System.Drawing.Point(82, 25)
        Me.txtCodMercaderia_AN.Name = "txtCodMercaderia_AN"
        Me.txtCodMercaderia_AN.Size = New System.Drawing.Size(202, 26)
        Me.txtCodMercaderia_AN.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "codigo:"
        '
        'txtCodUnidad_AN
        '
        Me.txtCodUnidad_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUnidad_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUnidad_AN.Location = New System.Drawing.Point(194, 187)
        Me.txtCodUnidad_AN.Name = "txtCodUnidad_AN"
        Me.txtCodUnidad_AN.Size = New System.Drawing.Size(110, 26)
        Me.txtCodUnidad_AN.TabIndex = 3
        Me.txtCodUnidad_AN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Unidad Medida:"
        '
        'lblNomUnidad
        '
        Me.lblNomUnidad.AutoSize = True
        Me.lblNomUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomUnidad.ForeColor = System.Drawing.Color.Navy
        Me.lblNomUnidad.Location = New System.Drawing.Point(310, 189)
        Me.lblNomUnidad.Name = "lblNomUnidad"
        Me.lblNomUnidad.Size = New System.Drawing.Size(83, 20)
        Me.lblNomUnidad.TabIndex = 134
        Me.lblNomUnidad.Text = "<unidad>"
        '
        'txtCantCompra_ND
        '
        Me.txtCantCompra_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantCompra_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantCompra_ND.Location = New System.Drawing.Point(194, 219)
        Me.txtCantCompra_ND.Name = "txtCantCompra_ND"
        Me.txtCantCompra_ND.Size = New System.Drawing.Size(110, 26)
        Me.txtCantCompra_ND.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Cantidad:"
        '
        'txtPrecUnitario_in_ND
        '
        Me.txtPrecUnitario_in_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecUnitario_in_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecUnitario_in_ND.Location = New System.Drawing.Point(135, 251)
        Me.txtPrecUnitario_in_ND.Name = "txtPrecUnitario_in_ND"
        Me.txtPrecUnitario_in_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtPrecUnitario_in_ND.TabIndex = 5
        '
        'lblPrecUnitario
        '
        Me.lblPrecUnitario.AutoSize = True
        Me.lblPrecUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecUnitario.Location = New System.Drawing.Point(16, 253)
        Me.lblPrecUnitario.Name = "lblPrecUnitario"
        Me.lblPrecUnitario.Size = New System.Drawing.Size(113, 20)
        Me.lblPrecUnitario.TabIndex = 138
        Me.lblPrecUnitario.Text = "Precio unitario:"
        '
        'lblCantCompra_real
        '
        Me.lblCantCompra_real.AutoSize = True
        Me.lblCantCompra_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantCompra_real.ForeColor = System.Drawing.Color.Navy
        Me.lblCantCompra_real.Location = New System.Drawing.Point(311, 221)
        Me.lblCantCompra_real.Name = "lblCantCompra_real"
        Me.lblCantCompra_real.Size = New System.Drawing.Size(138, 20)
        Me.lblCantCompra_real.TabIndex = 139
        Me.lblCantCompra_real.Text = "<cantidad_real>"
        '
        'lblPrecUnitario_in_ND
        '
        Me.lblPrecUnitario_in_ND.AutoSize = True
        Me.lblPrecUnitario_in_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrecUnitario_in_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecUnitario_in_ND.Location = New System.Drawing.Point(6, 289)
        Me.lblPrecUnitario_in_ND.Name = "lblPrecUnitario_in_ND"
        Me.lblPrecUnitario_in_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblPrecUnitario_in_ND.TabIndex = 162
        Me.lblPrecUnitario_in_ND.Text = "<valor>"
        '
        'lblCantCompra_ND
        '
        Me.lblCantCompra_ND.AutoSize = True
        Me.lblCantCompra_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantCompra_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantCompra_ND.Location = New System.Drawing.Point(81, 289)
        Me.lblCantCompra_ND.Name = "lblCantCompra_ND"
        Me.lblCantCompra_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblCantCompra_ND.TabIndex = 163
        Me.lblCantCompra_ND.Text = "<valor>"
        '
        'txtImpTotal_in_ND
        '
        Me.txtImpTotal_in_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpTotal_in_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpTotal_in_ND.Location = New System.Drawing.Point(424, 285)
        Me.txtImpTotal_in_ND.Name = "txtImpTotal_in_ND"
        Me.txtImpTotal_in_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtImpTotal_in_ND.TabIndex = 6
        '
        'lblTitImporteTotal
        '
        Me.lblTitImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitImporteTotal.ForeColor = System.Drawing.Color.Navy
        Me.lblTitImporteTotal.Location = New System.Drawing.Point(51, 287)
        Me.lblTitImporteTotal.Name = "lblTitImporteTotal"
        Me.lblTitImporteTotal.Size = New System.Drawing.Size(367, 20)
        Me.lblTitImporteTotal.TabIndex = 165
        Me.lblTitImporteTotal.Text = "Importe Total:"
        Me.lblTitImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpTotal_in_ND
        '
        Me.lblImpTotal_in_ND.AutoSize = True
        Me.lblImpTotal_in_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImpTotal_in_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpTotal_in_ND.Location = New System.Drawing.Point(156, 287)
        Me.lblImpTotal_in_ND.Name = "lblImpTotal_in_ND"
        Me.lblImpTotal_in_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblImpTotal_in_ND.TabIndex = 166
        Me.lblImpTotal_in_ND.Text = "<valor>"
        '
        'frmFe051compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(639, 499)
        Me.Name = "frmFe051compras"
        Me.Tag = ""
        Me.Text = "Formulario detalle compra bienes o servicios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbxMercaderia.ResumeLayout(False)
        Me.gbxMercaderia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gbxMercaderia As GroupBox
    Friend WithEvents txtNumOrden_NE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumTransaccion_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCantCompra_real As Label
    Friend WithEvents txtPrecUnitario_in_ND As TextBox
    Friend WithEvents lblPrecUnitario As Label
    Friend WithEvents txtCantCompra_ND As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNomUnidad As Label
    Friend WithEvents txtCodUnidad_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNomMercaderia As Label
    Friend WithEvents txtCodMercaderia_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCantCompra_ND As Label
    Friend WithEvents lblPrecUnitario_in_ND As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblImpTotal_in_ND As Label
    Friend WithEvents lblTitImporteTotal As Label
    Friend WithEvents txtImpTotal_in_ND As TextBox
End Class
