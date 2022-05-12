<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFe020listaprecio
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
        Me.lblNombreMercaderia = New System.Windows.Forms.Label()
        Me.lblNombreUnidad = New System.Windows.Forms.Label()
        Me.txtCodUnidad_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodMercaderia_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoPrecio = New System.Windows.Forms.ComboBox()
        Me.txtVigencia_FE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor_ND = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodMoneda_AN = New System.Windows.Forms.TextBox()
        Me.lblCodMoneda = New System.Windows.Forms.Label()
        Me.lblNombreMoneda = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblValor_ND = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(822, 256)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblValor_ND)
        Me.TabPage1.Controls.Add(Me.lblNombreMoneda)
        Me.TabPage1.Controls.Add(Me.lblCodMoneda)
        Me.TabPage1.Controls.Add(Me.txtCodMoneda_AN)
        Me.TabPage1.Controls.Add(Me.txtValor_ND)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtVigencia_FE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmbTipoPrecio)
        Me.TabPage1.Controls.Add(Me.lblNombreMercaderia)
        Me.TabPage1.Controls.Add(Me.lblNombreUnidad)
        Me.TabPage1.Controls.Add(Me.txtCodUnidad_AN)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtCodMercaderia_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Size = New System.Drawing.Size(814, 216)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 307)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(697, 307)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(818, 37)
        '
        'lblNombreMercaderia
        '
        Me.lblNombreMercaderia.AutoSize = True
        Me.lblNombreMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMercaderia.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreMercaderia.Location = New System.Drawing.Point(336, 49)
        Me.lblNombreMercaderia.Name = "lblNombreMercaderia"
        Me.lblNombreMercaderia.Size = New System.Drawing.Size(169, 20)
        Me.lblNombreMercaderia.TabIndex = 129
        Me.lblNombreMercaderia.Text = "<nombre_mercaderia>"
        '
        'lblNombreUnidad
        '
        Me.lblNombreUnidad.AutoSize = True
        Me.lblNombreUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUnidad.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreUnidad.Location = New System.Drawing.Point(336, 81)
        Me.lblNombreUnidad.Name = "lblNombreUnidad"
        Me.lblNombreUnidad.Size = New System.Drawing.Size(138, 20)
        Me.lblNombreUnidad.TabIndex = 128
        Me.lblNombreUnidad.Text = "<nombre_unidad>"
        '
        'txtCodUnidad_AN
        '
        Me.txtCodUnidad_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUnidad_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUnidad_AN.Location = New System.Drawing.Point(157, 79)
        Me.txtCodUnidad_AN.Name = "txtCodUnidad_AN"
        Me.txtCodUnidad_AN.Size = New System.Drawing.Size(120, 26)
        Me.txtCodUnidad_AN.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Unidad Medida:"
        '
        'txtCodMercaderia_AN
        '
        Me.txtCodMercaderia_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMercaderia_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMercaderia_AN.Location = New System.Drawing.Point(157, 47)
        Me.txtCodMercaderia_AN.Name = "txtCodMercaderia_AN"
        Me.txtCodMercaderia_AN.Size = New System.Drawing.Size(173, 26)
        Me.txtCodMercaderia_AN.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Merc./Servicio:"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(336, 17)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(152, 20)
        Me.lblNombreEmpresa.TabIndex = 125
        Me.lblNombreEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(157, 15)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(120, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Empresa:"
        '
        'cmbTipoPrecio
        '
        Me.cmbTipoPrecio.AccessibleDescription = "tipo"
        Me.cmbTipoPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPrecio.FormattingEnabled = True
        Me.cmbTipoPrecio.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoPrecio.Location = New System.Drawing.Point(157, 143)
        Me.cmbTipoPrecio.Name = "cmbTipoPrecio"
        Me.cmbTipoPrecio.Size = New System.Drawing.Size(173, 28)
        Me.cmbTipoPrecio.TabIndex = 4
        '
        'txtVigencia_FE
        '
        Me.txtVigencia_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVigencia_FE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVigencia_FE.Location = New System.Drawing.Point(157, 111)
        Me.txtVigencia_FE.Name = "txtVigencia_FE"
        Me.txtVigencia_FE.Size = New System.Drawing.Size(278, 26)
        Me.txtVigencia_FE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Vigencia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Tipo precio:"
        '
        'txtValor_ND
        '
        Me.txtValor_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor_ND.Location = New System.Drawing.Point(639, 177)
        Me.txtValor_ND.Name = "txtValor_ND"
        Me.txtValor_ND.Size = New System.Drawing.Size(169, 26)
        Me.txtValor_ND.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(577, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Valor:"
        '
        'txtCodMoneda_AN
        '
        Me.txtCodMoneda_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMoneda_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMoneda_AN.Location = New System.Drawing.Point(157, 177)
        Me.txtCodMoneda_AN.Name = "txtCodMoneda_AN"
        Me.txtCodMoneda_AN.Size = New System.Drawing.Size(68, 26)
        Me.txtCodMoneda_AN.TabIndex = 5
        '
        'lblCodMoneda
        '
        Me.lblCodMoneda.AutoSize = True
        Me.lblCodMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMoneda.Location = New System.Drawing.Point(17, 179)
        Me.lblCodMoneda.Name = "lblCodMoneda"
        Me.lblCodMoneda.Size = New System.Drawing.Size(71, 20)
        Me.lblCodMoneda.TabIndex = 137
        Me.lblCodMoneda.Text = "Moneda:"
        '
        'lblNombreMoneda
        '
        Me.lblNombreMoneda.AutoSize = True
        Me.lblNombreMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMoneda.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreMoneda.Location = New System.Drawing.Point(231, 179)
        Me.lblNombreMoneda.Name = "lblNombreMoneda"
        Me.lblNombreMoneda.Size = New System.Drawing.Size(148, 20)
        Me.lblNombreMoneda.TabIndex = 138
        Me.lblNombreMoneda.Text = "<nombre_moneda>"
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(814, 216)
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
        Me.cmbEstado.Location = New System.Drawing.Point(88, 13)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(150, 28)
        Me.cmbEstado.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Estado:"
        '
        'lblValor_ND
        '
        Me.lblValor_ND.AutoSize = True
        Me.lblValor_ND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValor_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor_ND.Location = New System.Drawing.Point(739, 3)
        Me.lblValor_ND.Name = "lblValor_ND"
        Me.lblValor_ND.Size = New System.Drawing.Size(69, 22)
        Me.lblValor_ND.TabIndex = 139
        Me.lblValor_ND.Text = "<valor>"
        '
        'frmFe020listaprecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(842, 391)
        Me.Name = "frmFe020listaprecio"
        Me.Tag = ""
        Me.Text = "Formulario lista de precio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNombreMercaderia As Label
    Friend WithEvents lblNombreUnidad As Label
    Friend WithEvents txtCodUnidad_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodMercaderia_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVigencia_FE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoPrecio As ComboBox
    Friend WithEvents txtValor_ND As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblNombreMoneda As Label
    Friend WithEvents lblCodMoneda As Label
    Friend WithEvents txtCodMoneda_AN As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblValor_ND As Label
End Class
