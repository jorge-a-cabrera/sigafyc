<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFc040docimpuestos : Inherits frmFormulario

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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodDocumento_NE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.lblNomDocumento = New System.Windows.Forms.Label()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.lblNomImpuesto = New System.Windows.Forms.Label()
        Me.txtCodImpuesto_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAplicacion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(778, 237)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbAplicacion)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblNomImpuesto)
        Me.TabPage1.Controls.Add(Me.txtCodImpuesto_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cmbOperacion)
        Me.TabPage1.Controls.Add(Me.lblNomDocumento)
        Me.TabPage1.Controls.Add(Me.lblNomEmpresa)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCodDocumento_NE)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Size = New System.Drawing.Size(770, 197)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 288)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(653, 288)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(774, 37)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Operación:"
        '
        'txtCodDocumento_NE
        '
        Me.txtCodDocumento_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDocumento_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDocumento_NE.Location = New System.Drawing.Point(147, 49)
        Me.txtCodDocumento_NE.Name = "txtCodDocumento_NE"
        Me.txtCodDocumento_NE.Size = New System.Drawing.Size(64, 26)
        Me.txtCodDocumento_NE.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Documento:"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(147, 14)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(113, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Empresa:"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Location = New System.Drawing.Point(266, 16)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(182, 24)
        Me.lblNomEmpresa.TabIndex = 44
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'lblNomDocumento
        '
        Me.lblNomDocumento.AutoSize = True
        Me.lblNomDocumento.Location = New System.Drawing.Point(266, 51)
        Me.lblNomDocumento.Name = "lblNomDocumento"
        Me.lblNomDocumento.Size = New System.Drawing.Size(204, 24)
        Me.lblNomDocumento.TabIndex = 45
        Me.lblNomDocumento.Text = "<nombre_documento>"
        '
        'cmbOperacion
        '
        Me.cmbOperacion.AccessibleDescription = "tipo"
        Me.cmbOperacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"Venta", "Compra"})
        Me.cmbOperacion.Location = New System.Drawing.Point(147, 117)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(113, 28)
        Me.cmbOperacion.TabIndex = 2
        '
        'lblNomImpuesto
        '
        Me.lblNomImpuesto.AutoSize = True
        Me.lblNomImpuesto.Location = New System.Drawing.Point(266, 153)
        Me.lblNomImpuesto.Name = "lblNomImpuesto"
        Me.lblNomImpuesto.Size = New System.Drawing.Size(185, 24)
        Me.lblNomImpuesto.TabIndex = 49
        Me.lblNomImpuesto.Text = "<nombre_impuesto>"
        '
        'txtCodImpuesto_AN
        '
        Me.txtCodImpuesto_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodImpuesto_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodImpuesto_AN.Location = New System.Drawing.Point(147, 151)
        Me.txtCodImpuesto_AN.Name = "txtCodImpuesto_AN"
        Me.txtCodImpuesto_AN.Size = New System.Drawing.Size(113, 26)
        Me.txtCodImpuesto_AN.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 24)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Impuesto:"
        '
        'cmbAplicacion
        '
        Me.cmbAplicacion.AccessibleDescription = "tipo"
        Me.cmbAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbAplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAplicacion.FormattingEnabled = True
        Me.cmbAplicacion.Items.AddRange(New Object() {"Linea", "Totales"})
        Me.cmbAplicacion.Location = New System.Drawing.Point(619, 149)
        Me.cmbAplicacion.Name = "cmbAplicacion"
        Me.cmbAplicacion.Size = New System.Drawing.Size(137, 28)
        Me.cmbAplicacion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(510, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Aplicación:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(770, 197)
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
        Me.cmbEstado.Location = New System.Drawing.Point(147, 13)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 28)
        Me.cmbEstado.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Estado:"
        '
        'frmFc040docimpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(795, 367)
        Me.Name = "frmFc040docimpuestos"
        Me.Tag = ""
        Me.Text = "Formulario Impuesto por Documento"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNomDocumento As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodDocumento_NE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents lblNomImpuesto As Label
    Friend WithEvents txtCodImpuesto_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbAplicacion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label3 As Label
End Class
