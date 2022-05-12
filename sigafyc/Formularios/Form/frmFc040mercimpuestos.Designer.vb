<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFc040mercimpuestos
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
        Me.lblNomImpuesto = New System.Windows.Forms.Label()
        Me.txtCodImpuesto_AN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.lblNomMercaderia = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodMercaderia_AN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Size = New System.Drawing.Size(774, 238)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblNomImpuesto)
        Me.TabPage1.Controls.Add(Me.txtCodImpuesto_AN)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cmbOperacion)
        Me.TabPage1.Controls.Add(Me.lblNomMercaderia)
        Me.TabPage1.Controls.Add(Me.lblNomEmpresa)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCodMercaderia_AN)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(766, 202)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 289)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(649, 289)
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Size = New System.Drawing.Size(770, 27)
        '
        'lblNomImpuesto
        '
        Me.lblNomImpuesto.AutoSize = True
        Me.lblNomImpuesto.ForeColor = System.Drawing.Color.Navy
        Me.lblNomImpuesto.Location = New System.Drawing.Point(261, 153)
        Me.lblNomImpuesto.Name = "lblNomImpuesto"
        Me.lblNomImpuesto.Size = New System.Drawing.Size(155, 20)
        Me.lblNomImpuesto.TabIndex = 62
        Me.lblNomImpuesto.Text = "<nombre_impuesto>"
        '
        'txtCodImpuesto_AN
        '
        Me.txtCodImpuesto_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodImpuesto_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodImpuesto_AN.Location = New System.Drawing.Point(142, 151)
        Me.txtCodImpuesto_AN.Name = "txtCodImpuesto_AN"
        Me.txtCodImpuesto_AN.Size = New System.Drawing.Size(113, 26)
        Me.txtCodImpuesto_AN.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Impuesto:"
        '
        'cmbOperacion
        '
        Me.cmbOperacion.AccessibleDescription = "tipo"
        Me.cmbOperacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"Venta", "Compra"})
        Me.cmbOperacion.Location = New System.Drawing.Point(142, 46)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(113, 28)
        Me.cmbOperacion.TabIndex = 1
        '
        'lblNomMercaderia
        '
        Me.lblNomMercaderia.AutoSize = True
        Me.lblNomMercaderia.ForeColor = System.Drawing.Color.Navy
        Me.lblNomMercaderia.Location = New System.Drawing.Point(348, 79)
        Me.lblNomMercaderia.Name = "lblNomMercaderia"
        Me.lblNomMercaderia.Size = New System.Drawing.Size(170, 20)
        Me.lblNomMercaderia.TabIndex = 60
        Me.lblNomMercaderia.Text = "<nombre_documento>"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(261, 16)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(152, 20)
        Me.lblNomEmpresa.TabIndex = 59
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Operación:"
        '
        'txtCodMercaderia_AN
        '
        Me.txtCodMercaderia_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMercaderia_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMercaderia_AN.Location = New System.Drawing.Point(142, 80)
        Me.txtCodMercaderia_AN.Name = "txtCodMercaderia_AN"
        Me.txtCodMercaderia_AN.Size = New System.Drawing.Size(200, 26)
        Me.txtCodMercaderia_AN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Mercadería:"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(142, 14)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(113, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Empresa:"
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(766, 202)
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
        Me.cmbEstado.Location = New System.Drawing.Point(83, 12)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(125, 28)
        Me.cmbEstado.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Estado:"
        '
        'frmFc040mercimpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(790, 371)
        Me.Name = "frmFc040mercimpuestos"
        Me.Tag = ""
        Me.Text = "Formulario Impuesto por Mercaderia"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNomImpuesto As Label
    Friend WithEvents txtCodImpuesto_AN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents lblNomMercaderia As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodMercaderia_AN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label3 As Label
End Class
