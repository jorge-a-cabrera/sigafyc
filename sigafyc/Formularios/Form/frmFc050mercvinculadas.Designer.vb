<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFc050mercvinculadas
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
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodSalida_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreSalida = New System.Windows.Forms.Label()
        Me.gbxVinculada = New System.Windows.Forms.GroupBox()
        Me.lblCantidadReal = New System.Windows.Forms.Label()
        Me.lblNombreEntrada = New System.Windows.Forms.Label()
        Me.lblNombreUnidad = New System.Windows.Forms.Label()
        Me.txtCodUnidad_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidad_ND = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodEntrada_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxVinculada.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(872, 276)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbxVinculada)
        Me.TabPage1.Controls.Add(Me.lblNombreSalida)
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtCodSalida_AN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(864, 236)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 327)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(747, 327)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(872, 37)
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(283, 21)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(168, 20)
        Me.lblNombreEmpresa.TabIndex = 106
        Me.lblNombreEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(162, 19)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Empresa:"
        '
        'txtCodSalida_AN
        '
        Me.txtCodSalida_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSalida_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSalida_AN.Location = New System.Drawing.Point(162, 51)
        Me.txtCodSalida_AN.Name = "txtCodSalida_AN"
        Me.txtCodSalida_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodSalida_AN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Merc./Servicio:"
        '
        'lblNombreSalida
        '
        Me.lblNombreSalida.AutoSize = True
        Me.lblNombreSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreSalida.Location = New System.Drawing.Point(283, 53)
        Me.lblNombreSalida.Name = "lblNombreSalida"
        Me.lblNombreSalida.Size = New System.Drawing.Size(146, 20)
        Me.lblNombreSalida.TabIndex = 111
        Me.lblNombreSalida.Text = "<nombre_salida>"
        '
        'gbxVinculada
        '
        Me.gbxVinculada.Controls.Add(Me.lblCantidadReal)
        Me.gbxVinculada.Controls.Add(Me.lblNombreEntrada)
        Me.gbxVinculada.Controls.Add(Me.lblNombreUnidad)
        Me.gbxVinculada.Controls.Add(Me.txtCodUnidad_AN)
        Me.gbxVinculada.Controls.Add(Me.Label3)
        Me.gbxVinculada.Controls.Add(Me.txtCantidad_ND)
        Me.gbxVinculada.Controls.Add(Me.Label7)
        Me.gbxVinculada.Controls.Add(Me.txtCodEntrada_AN)
        Me.gbxVinculada.Controls.Add(Me.Label8)
        Me.gbxVinculada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxVinculada.Location = New System.Drawing.Point(162, 83)
        Me.gbxVinculada.Name = "gbxVinculada"
        Me.gbxVinculada.Size = New System.Drawing.Size(688, 143)
        Me.gbxVinculada.TabIndex = 2
        Me.gbxVinculada.TabStop = False
        Me.gbxVinculada.Text = "mercaderia/servicio vinculado"
        '
        'lblCantidadReal
        '
        Me.lblCantidadReal.AutoSize = True
        Me.lblCantidadReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadReal.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidadReal.Location = New System.Drawing.Point(288, 102)
        Me.lblCantidadReal.Name = "lblCantidadReal"
        Me.lblCantidadReal.Size = New System.Drawing.Size(153, 20)
        Me.lblCantidadReal.TabIndex = 121
        Me.lblCantidadReal.Text = "<nombre_unidad>"
        '
        'lblNombreEntrada
        '
        Me.lblNombreEntrada.AutoSize = True
        Me.lblNombreEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEntrada.Location = New System.Drawing.Point(288, 38)
        Me.lblNombreEntrada.Name = "lblNombreEntrada"
        Me.lblNombreEntrada.Size = New System.Drawing.Size(161, 20)
        Me.lblNombreEntrada.TabIndex = 120
        Me.lblNombreEntrada.Text = "<nombre_entrada>"
        '
        'lblNombreUnidad
        '
        Me.lblNombreUnidad.AutoSize = True
        Me.lblNombreUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUnidad.Location = New System.Drawing.Point(288, 70)
        Me.lblNombreUnidad.Name = "lblNombreUnidad"
        Me.lblNombreUnidad.Size = New System.Drawing.Size(153, 20)
        Me.lblNombreUnidad.TabIndex = 119
        Me.lblNombreUnidad.Text = "<nombre_unidad>"
        '
        'txtCodUnidad_AN
        '
        Me.txtCodUnidad_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUnidad_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUnidad_AN.Location = New System.Drawing.Point(167, 68)
        Me.txtCodUnidad_AN.Name = "txtCodUnidad_AN"
        Me.txtCodUnidad_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodUnidad_AN.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Unidad Medida:"
        '
        'txtCantidad_ND
        '
        Me.txtCantidad_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad_ND.Location = New System.Drawing.Point(167, 100)
        Me.txtCantidad_ND.Name = "txtCantidad_ND"
        Me.txtCantidad_ND.Size = New System.Drawing.Size(115, 26)
        Me.txtCantidad_ND.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Cantidad:"
        '
        'txtCodEntrada_AN
        '
        Me.txtCodEntrada_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEntrada_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEntrada_AN.Location = New System.Drawing.Point(167, 36)
        Me.txtCodEntrada_AN.Name = "txtCodEntrada_AN"
        Me.txtCodEntrada_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEntrada_AN.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Merc./Servicio:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(864, 263)
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
        Me.cmbEstado.Location = New System.Drawing.Point(165, 12)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(225, 28)
        Me.cmbEstado.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Estado:"
        '
        'frmFc050mercvinculadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(889, 407)
        Me.Name = "frmFc050mercvinculadas"
        Me.Tag = ""
        Me.Text = "Formulario Mercaderia para comercializar con sus vinculos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbxVinculada.ResumeLayout(False)
        Me.gbxVinculada.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxVinculada As GroupBox
    Friend WithEvents lblNombreEntrada As Label
    Friend WithEvents lblNombreUnidad As Label
    Friend WithEvents txtCodUnidad_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantidad_ND As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodEntrada_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNombreSalida As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodSalida_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCantidadReal As Label
End Class
