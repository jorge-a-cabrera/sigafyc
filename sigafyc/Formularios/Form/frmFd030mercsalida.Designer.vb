<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFd030mercsalida
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
        Me.lblNombreClasificacion = New System.Windows.Forms.Label()
        Me.lblNombreUnidad = New System.Windows.Forms.Label()
        Me.txtCodBarra_AN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodClasificacion_NE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodUnidad_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAbreviado_AN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.cmbListaPrecio = New System.Windows.Forms.ComboBox()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodMercaderia_AN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDetalleImpuestos = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Size = New System.Drawing.Size(649, 321)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblNombreClasificacion)
        Me.TabPage1.Controls.Add(Me.lblNombreUnidad)
        Me.TabPage1.Controls.Add(Me.txtCodBarra_AN)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtCodClasificacion_NE)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCodUnidad_AN)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtAbreviado_AN)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtNombre_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.cmbListaPrecio)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtCodMercaderia_AN)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(641, 285)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 372)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(524, 372)
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Size = New System.Drawing.Size(645, 37)
        '
        'lblNombreClasificacion
        '
        Me.lblNombreClasificacion.AutoSize = True
        Me.lblNombreClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreClasificacion.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreClasificacion.Location = New System.Drawing.Point(284, 179)
        Me.lblNombreClasificacion.Name = "lblNombreClasificacion"
        Me.lblNombreClasificacion.Size = New System.Drawing.Size(175, 20)
        Me.lblNombreClasificacion.TabIndex = 99
        Me.lblNombreClasificacion.Text = "<nombre_clasificacion>"
        '
        'lblNombreUnidad
        '
        Me.lblNombreUnidad.AutoSize = True
        Me.lblNombreUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUnidad.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreUnidad.Location = New System.Drawing.Point(284, 147)
        Me.lblNombreUnidad.Name = "lblNombreUnidad"
        Me.lblNombreUnidad.Size = New System.Drawing.Size(138, 20)
        Me.lblNombreUnidad.TabIndex = 98
        Me.lblNombreUnidad.Text = "<nombre_unidad>"
        '
        'txtCodBarra_AN
        '
        Me.txtCodBarra_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodBarra_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarra_AN.Location = New System.Drawing.Point(163, 243)
        Me.txtCodBarra_AN.Name = "txtCodBarra_AN"
        Me.txtCodBarra_AN.Size = New System.Drawing.Size(380, 26)
        Me.txtCodBarra_AN.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Cod. Barra:"
        '
        'txtCodClasificacion_NE
        '
        Me.txtCodClasificacion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodClasificacion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodClasificacion_NE.Location = New System.Drawing.Point(163, 177)
        Me.txtCodClasificacion_NE.Name = "txtCodClasificacion_NE"
        Me.txtCodClasificacion_NE.Size = New System.Drawing.Size(87, 26)
        Me.txtCodClasificacion_NE.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Clasificación:"
        '
        'txtCodUnidad_AN
        '
        Me.txtCodUnidad_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUnidad_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUnidad_AN.Location = New System.Drawing.Point(163, 145)
        Me.txtCodUnidad_AN.Name = "txtCodUnidad_AN"
        Me.txtCodUnidad_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodUnidad_AN.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Unidad Medida:"
        '
        'txtAbreviado_AN
        '
        Me.txtAbreviado_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbreviado_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviado_AN.Location = New System.Drawing.Point(163, 113)
        Me.txtAbreviado_AN.Name = "txtAbreviado_AN"
        Me.txtAbreviado_AN.Size = New System.Drawing.Size(225, 26)
        Me.txtAbreviado_AN.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Abreviación:"
        '
        'txtNombre_AN
        '
        Me.txtNombre_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_AN.Location = New System.Drawing.Point(163, 81)
        Me.txtNombre_AN.Name = "txtNombre_AN"
        Me.txtNombre_AN.Size = New System.Drawing.Size(462, 26)
        Me.txtNombre_AN.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Nombre "
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(284, 19)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(152, 20)
        Me.lblNombreEmpresa.TabIndex = 91
        Me.lblNombreEmpresa.Text = "<nombre_empresa>"
        '
        'cmbListaPrecio
        '
        Me.cmbListaPrecio.AccessibleDescription = "tipo"
        Me.cmbListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbListaPrecio.FormattingEnabled = True
        Me.cmbListaPrecio.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbListaPrecio.Location = New System.Drawing.Point(163, 209)
        Me.cmbListaPrecio.Name = "cmbListaPrecio"
        Me.cmbListaPrecio.Size = New System.Drawing.Size(44, 28)
        Me.cmbListaPrecio.TabIndex = 6
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(163, 17)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Empresa:"
        '
        'txtCodMercaderia_AN
        '
        Me.txtCodMercaderia_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMercaderia_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMercaderia_AN.Location = New System.Drawing.Point(163, 49)
        Me.txtCodMercaderia_AN.Name = "txtCodMercaderia_AN"
        Me.txtCodMercaderia_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodMercaderia_AN.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Lista de Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Código:"
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.btnDetalleImpuestos)
        Me.TabPage2.Controls.Add(Me.btnDetalle)
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(641, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDetalleImpuestos
        '
        Me.btnDetalleImpuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleImpuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleImpuestos.Image = Global.sigafyc.My.Resources.Resources.icons8_details_32
        Me.btnDetalleImpuestos.Location = New System.Drawing.Point(473, 200)
        Me.btnDetalleImpuestos.Name = "btnDetalleImpuestos"
        Me.btnDetalleImpuestos.Size = New System.Drawing.Size(165, 78)
        Me.btnDetalleImpuestos.TabIndex = 2
        Me.btnDetalleImpuestos.Tag = "&unidades"
        Me.btnDetalleImpuestos.Text = "&Impuestos"
        Me.btnDetalleImpuestos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalleImpuestos.UseVisualStyleBackColor = True
        '
        'btnDetalle
        '
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.Image = Global.sigafyc.My.Resources.Resources.icons8_details_32
        Me.btnDetalle.Location = New System.Drawing.Point(302, 200)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(165, 78)
        Me.btnDetalle.TabIndex = 1
        Me.btnDetalle.Tag = "&unidades"
        Me.btnDetalle.Text = "&unidades alternativas"
        Me.btnDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(82, 13)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(145, 28)
        Me.cmbEstado.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Estado:"
        '
        'frmFd030mercsalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(666, 453)
        Me.Name = "frmFd030mercsalida"
        Me.Tag = ""
        Me.Text = "Formulario Mercaderia/servicio para comercializar"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNombreClasificacion As Label
    Friend WithEvents lblNombreUnidad As Label
    Friend WithEvents txtCodBarra_AN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodClasificacion_NE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodUnidad_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAbreviado_AN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents cmbListaPrecio As ComboBox
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodMercaderia_AN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnDetalle As Button
    Friend WithEvents btnDetalleImpuestos As Button
End Class
