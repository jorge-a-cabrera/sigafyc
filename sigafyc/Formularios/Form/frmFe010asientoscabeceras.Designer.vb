<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFe010asientoscabeceras : Inherits frmFormulario

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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreSucursal = New System.Windows.Forms.Label()
        Me.txtCodSucursal_NE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha_FE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodDocumento_NE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNombreDocumento = New System.Windows.Forms.Label()
        Me.txtNroDocumento_AN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodMoneda_AN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNombreMoneda = New System.Windows.Forms.Label()
        Me.txtCodConcepto_NE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConcepto_AN = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Size = New System.Drawing.Size(900, 452)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.txtConcepto_AN)
        Me.TabPage1.Controls.Add(Me.txtCodConcepto_NE)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lblNombreMoneda)
        Me.TabPage1.Controls.Add(Me.txtCodMoneda_AN)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtNroDocumento_AN)
        Me.TabPage1.Controls.Add(Me.lblNombreDocumento)
        Me.TabPage1.Controls.Add(Me.txtCodDocumento_NE)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtFecha_FE)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.lblNombreSucursal)
        Me.TabPage1.Controls.Add(Me.txtCodSucursal_NE)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtCodigo_NE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(892, 416)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 503)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(775, 503)
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Size = New System.Drawing.Size(896, 37)
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(892, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(87, 15)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(144, 28)
        Me.cmbEstado.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Estado:"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(297, 19)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(179, 20)
        Me.lblNombreEmpresa.TabIndex = 46
        Me.lblNombreEmpresa.Text = "<nombre_de_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(176, 17)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEmpresa_NE.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Empresa:"
        '
        'txtCodigo_NE
        '
        Me.txtCodigo_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_NE.Location = New System.Drawing.Point(176, 49)
        Me.txtCodigo_NE.Name = "txtCodigo_NE"
        Me.txtCodigo_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodigo_NE.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Asiento No.:"
        '
        'lblNombreSucursal
        '
        Me.lblNombreSucursal.AutoSize = True
        Me.lblNombreSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreSucursal.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreSucursal.Location = New System.Drawing.Point(246, 81)
        Me.lblNombreSucursal.Name = "lblNombreSucursal"
        Me.lblNombreSucursal.Size = New System.Drawing.Size(149, 20)
        Me.lblNombreSucursal.TabIndex = 51
        Me.lblNombreSucursal.Text = "<nombre_sucursal>"
        '
        'txtCodSucursal_NE
        '
        Me.txtCodSucursal_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSucursal_NE.Location = New System.Drawing.Point(176, 81)
        Me.txtCodSucursal_NE.Name = "txtCodSucursal_NE"
        Me.txtCodSucursal_NE.Size = New System.Drawing.Size(64, 26)
        Me.txtCodSucursal_NE.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Sucursal:"
        '
        'txtFecha_FE
        '
        Me.txtFecha_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha_FE.Location = New System.Drawing.Point(176, 113)
        Me.txtFecha_FE.Name = "txtFecha_FE"
        Me.txtFecha_FE.Size = New System.Drawing.Size(115, 26)
        Me.txtFecha_FE.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Fecha operación:"
        '
        'txtCodDocumento_NE
        '
        Me.txtCodDocumento_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDocumento_NE.Location = New System.Drawing.Point(176, 145)
        Me.txtCodDocumento_NE.Name = "txtCodDocumento_NE"
        Me.txtCodDocumento_NE.Size = New System.Drawing.Size(64, 26)
        Me.txtCodDocumento_NE.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Documento:"
        '
        'lblNombreDocumento
        '
        Me.lblNombreDocumento.AutoSize = True
        Me.lblNombreDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDocumento.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreDocumento.Location = New System.Drawing.Point(246, 147)
        Me.lblNombreDocumento.Name = "lblNombreDocumento"
        Me.lblNombreDocumento.Size = New System.Drawing.Size(170, 20)
        Me.lblNombreDocumento.TabIndex = 56
        Me.lblNombreDocumento.Text = "<nombre_documento>"
        '
        'txtNroDocumento_AN
        '
        Me.txtNroDocumento_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocumento_AN.Location = New System.Drawing.Point(176, 177)
        Me.txtNroDocumento_AN.Name = "txtNroDocumento_AN"
        Me.txtNroDocumento_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtNroDocumento_AN.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Nro. documento:"
        '
        'txtCodMoneda_AN
        '
        Me.txtCodMoneda_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMoneda_AN.Location = New System.Drawing.Point(176, 209)
        Me.txtCodMoneda_AN.Name = "txtCodMoneda_AN"
        Me.txtCodMoneda_AN.Size = New System.Drawing.Size(64, 26)
        Me.txtCodMoneda_AN.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Moneda:"
        '
        'lblNombreMoneda
        '
        Me.lblNombreMoneda.AutoSize = True
        Me.lblNombreMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMoneda.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreMoneda.Location = New System.Drawing.Point(246, 211)
        Me.lblNombreMoneda.Name = "lblNombreMoneda"
        Me.lblNombreMoneda.Size = New System.Drawing.Size(148, 20)
        Me.lblNombreMoneda.TabIndex = 61
        Me.lblNombreMoneda.Text = "<nombre_moneda>"
        '
        'txtCodConcepto_NE
        '
        Me.txtCodConcepto_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodConcepto_NE.Location = New System.Drawing.Point(176, 241)
        Me.txtCodConcepto_NE.Name = "txtCodConcepto_NE"
        Me.txtCodConcepto_NE.Size = New System.Drawing.Size(65, 26)
        Me.txtCodConcepto_NE.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Concepto:"
        '
        'txtConcepto_AN
        '
        Me.txtConcepto_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcepto_AN.Location = New System.Drawing.Point(176, 273)
        Me.txtConcepto_AN.Multiline = True
        Me.txtConcepto_AN.Name = "txtConcepto_AN"
        Me.txtConcepto_AN.Size = New System.Drawing.Size(707, 133)
        Me.txtConcepto_AN.TabIndex = 64
        '
        'frmFe010asientoscabeceras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(917, 583)
        Me.Name = "frmFe010asientoscabeceras"
        Me.Tag = ""
        Me.Text = "Formulario de Asiento contable"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreSucursal As Label
    Friend WithEvents txtCodSucursal_NE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha_FE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNroDocumento_AN As TextBox
    Friend WithEvents lblNombreDocumento As Label
    Friend WithEvents txtCodDocumento_NE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodMoneda_AN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNombreMoneda As Label
    Friend WithEvents txtCodConcepto_NE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConcepto_AN As TextBox
End Class
