<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFd020mercentrada
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
        Me.cmbTipoBien = New System.Windows.Forms.ComboBox()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodMercaderia_AN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtNombre_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAbreviado_AN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodUnidad_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodClasificacion_NE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipoCosto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodBarra_AN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNombreUnidad = New System.Windows.Forms.Label()
        Me.lblNombreClasificacion = New System.Windows.Forms.Label()
        Me.cmbInventario = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(651, 381)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbInventario)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.lblNombreClasificacion)
        Me.TabPage1.Controls.Add(Me.lblNombreUnidad)
        Me.TabPage1.Controls.Add(Me.txtCodBarra_AN)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cmbTipoCosto)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtCodClasificacion_NE)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCodUnidad_AN)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtAbreviado_AN)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtNombre_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.cmbTipoBien)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtCodMercaderia_AN)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(643, 341)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 436)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(526, 436)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(647, 37)
        '
        'cmbTipoBien
        '
        Me.cmbTipoBien.AccessibleDescription = "tipo"
        Me.cmbTipoBien.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoBien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoBien.FormattingEnabled = True
        Me.cmbTipoBien.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoBien.Location = New System.Drawing.Point(163, 207)
        Me.cmbTipoBien.Name = "cmbTipoBien"
        Me.cmbTipoBien.Size = New System.Drawing.Size(225, 28)
        Me.cmbTipoBien.TabIndex = 6
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(163, 15)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Empresa:"
        '
        'txtCodMercaderia_AN
        '
        Me.txtCodMercaderia_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMercaderia_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMercaderia_AN.Location = New System.Drawing.Point(163, 47)
        Me.txtCodMercaderia_AN.Name = "txtCodMercaderia_AN"
        Me.txtCodMercaderia_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodMercaderia_AN.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Tipo bien:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Código:"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(284, 17)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(168, 20)
        Me.lblNombreEmpresa.TabIndex = 64
        Me.lblNombreEmpresa.Text = "<nombre_empresa>"
        '
        'txtNombre_AN
        '
        Me.txtNombre_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_AN.Location = New System.Drawing.Point(163, 79)
        Me.txtNombre_AN.Name = "txtNombre_AN"
        Me.txtNombre_AN.Size = New System.Drawing.Size(462, 26)
        Me.txtNombre_AN.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Nombre "
        '
        'txtAbreviado_AN
        '
        Me.txtAbreviado_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbreviado_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviado_AN.Location = New System.Drawing.Point(163, 111)
        Me.txtAbreviado_AN.Name = "txtAbreviado_AN"
        Me.txtAbreviado_AN.Size = New System.Drawing.Size(225, 26)
        Me.txtAbreviado_AN.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Abreviación:"
        '
        'txtCodUnidad_AN
        '
        Me.txtCodUnidad_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUnidad_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUnidad_AN.Location = New System.Drawing.Point(163, 143)
        Me.txtCodUnidad_AN.Name = "txtCodUnidad_AN"
        Me.txtCodUnidad_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodUnidad_AN.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Unidad Medida:"
        '
        'txtCodClasificacion_NE
        '
        Me.txtCodClasificacion_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodClasificacion_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodClasificacion_NE.Location = New System.Drawing.Point(163, 175)
        Me.txtCodClasificacion_NE.Name = "txtCodClasificacion_NE"
        Me.txtCodClasificacion_NE.Size = New System.Drawing.Size(87, 26)
        Me.txtCodClasificacion_NE.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Clasificación:"
        '
        'cmbTipoCosto
        '
        Me.cmbTipoCosto.AccessibleDescription = "tipo"
        Me.cmbTipoCosto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCosto.FormattingEnabled = True
        Me.cmbTipoCosto.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoCosto.Location = New System.Drawing.Point(163, 241)
        Me.cmbTipoCosto.Name = "cmbTipoCosto"
        Me.cmbTipoCosto.Size = New System.Drawing.Size(225, 28)
        Me.cmbTipoCosto.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Tipo costeo:"
        '
        'txtCodBarra_AN
        '
        Me.txtCodBarra_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodBarra_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarra_AN.Location = New System.Drawing.Point(163, 309)
        Me.txtCodBarra_AN.Name = "txtCodBarra_AN"
        Me.txtCodBarra_AN.Size = New System.Drawing.Size(380, 26)
        Me.txtCodBarra_AN.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Cod. Barra:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDetalle)
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(643, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDetalle
        '
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.Image = Global.sigafyc.My.Resources.Resources.icons8_details_32
        Me.btnDetalle.Location = New System.Drawing.Point(415, 260)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(225, 78)
        Me.btnDetalle.TabIndex = 45
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
        Me.cmbEstado.Location = New System.Drawing.Point(168, 14)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(225, 28)
        Me.cmbEstado.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Estado:"
        '
        'lblNombreUnidad
        '
        Me.lblNombreUnidad.AutoSize = True
        Me.lblNombreUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUnidad.Location = New System.Drawing.Point(284, 145)
        Me.lblNombreUnidad.Name = "lblNombreUnidad"
        Me.lblNombreUnidad.Size = New System.Drawing.Size(153, 20)
        Me.lblNombreUnidad.TabIndex = 77
        Me.lblNombreUnidad.Text = "<nombre_unidad>"
        '
        'lblNombreClasificacion
        '
        Me.lblNombreClasificacion.AutoSize = True
        Me.lblNombreClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreClasificacion.Location = New System.Drawing.Point(284, 177)
        Me.lblNombreClasificacion.Name = "lblNombreClasificacion"
        Me.lblNombreClasificacion.Size = New System.Drawing.Size(197, 20)
        Me.lblNombreClasificacion.TabIndex = 78
        Me.lblNombreClasificacion.Text = "<nombre_clasificacion>"
        '
        'cmbInventario
        '
        Me.cmbInventario.AccessibleDescription = "tipo"
        Me.cmbInventario.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInventario.FormattingEnabled = True
        Me.cmbInventario.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbInventario.Location = New System.Drawing.Point(163, 275)
        Me.cmbInventario.Name = "cmbInventario"
        Me.cmbInventario.Size = New System.Drawing.Size(47, 28)
        Me.cmbInventario.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Inventario:"
        '
        'frmFd020mercentrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(670, 521)
        Me.Name = "frmFd020mercentrada"
        Me.Tag = ""
        Me.Text = "Formulario bienes de cambio/uso"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbTipoBien As ComboBox
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodMercaderia_AN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtNombre_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodUnidad_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAbreviado_AN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTipoCosto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodClasificacion_NE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtCodBarra_AN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNombreClasificacion As Label
    Friend WithEvents lblNombreUnidad As Label
    Friend WithEvents btnDetalle As Button
    Friend WithEvents cmbInventario As ComboBox
    Friend WithEvents Label11 As Label
End Class
