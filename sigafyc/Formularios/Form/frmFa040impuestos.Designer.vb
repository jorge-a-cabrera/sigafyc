<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFa040impuestos : Inherits frmFormulario

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
        Me.gbxGrupo1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre_AN = New System.Windows.Forms.TextBox()
        Me.txtCodigo_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxGrupo3 = New System.Windows.Forms.GroupBox()
        Me.txtPorcBaseImpo_ND = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombreMoneda = New System.Windows.Forms.Label()
        Me.txtCodMoneda_AN = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtValor_ND = New System.Windows.Forms.TextBox()
        Me.cmbTipoValor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxGrupo1.SuspendLayout()
        Me.gbxGrupo3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Size = New System.Drawing.Size(896, 255)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbxGrupo3)
        Me.TabPage1.Controls.Add(Me.gbxGrupo1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(888, 219)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 306)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(771, 306)
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'gbxGrupo1
        '
        Me.gbxGrupo1.Controls.Add(Me.Label3)
        Me.gbxGrupo1.Controls.Add(Me.txtNombre_AN)
        Me.gbxGrupo1.Controls.Add(Me.txtCodigo_AN)
        Me.gbxGrupo1.Controls.Add(Me.Label1)
        Me.gbxGrupo1.Controls.Add(Me.cmbOperacion)
        Me.gbxGrupo1.Controls.Add(Me.Label2)
        Me.gbxGrupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo1.Location = New System.Drawing.Point(16, 18)
        Me.gbxGrupo1.Name = "gbxGrupo1"
        Me.gbxGrupo1.Size = New System.Drawing.Size(862, 82)
        Me.gbxGrupo1.TabIndex = 0
        Me.gbxGrupo1.TabStop = False
        Me.gbxGrupo1.Text = "Identificación del impuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "nombre:"
        '
        'txtNombre_AN
        '
        Me.txtNombre_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_AN.Location = New System.Drawing.Point(354, 36)
        Me.txtNombre_AN.Name = "txtNombre_AN"
        Me.txtNombre_AN.Size = New System.Drawing.Size(490, 26)
        Me.txtNombre_AN.TabIndex = 2
        '
        'txtCodigo_AN
        '
        Me.txtCodigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo_AN.Location = New System.Drawing.Point(156, 36)
        Me.txtCodigo_AN.Name = "txtCodigo_AN"
        Me.txtCodigo_AN.Size = New System.Drawing.Size(181, 26)
        Me.txtCodigo_AN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "codigo:"
        '
        'cmbOperacion
        '
        Me.cmbOperacion.AccessibleDescription = "tipo"
        Me.cmbOperacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbOperacion.Location = New System.Drawing.Point(10, 36)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(133, 28)
        Me.cmbOperacion.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "operación:"
        '
        'gbxGrupo3
        '
        Me.gbxGrupo3.Controls.Add(Me.txtPorcBaseImpo_ND)
        Me.gbxGrupo3.Controls.Add(Me.Label4)
        Me.gbxGrupo3.Controls.Add(Me.lblNombreMoneda)
        Me.gbxGrupo3.Controls.Add(Me.txtCodMoneda_AN)
        Me.gbxGrupo3.Controls.Add(Me.Label14)
        Me.gbxGrupo3.Controls.Add(Me.txtValor_ND)
        Me.gbxGrupo3.Controls.Add(Me.cmbTipoValor)
        Me.gbxGrupo3.Controls.Add(Me.Label6)
        Me.gbxGrupo3.Controls.Add(Me.Label5)
        Me.gbxGrupo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo3.Location = New System.Drawing.Point(130, 106)
        Me.gbxGrupo3.Name = "gbxGrupo3"
        Me.gbxGrupo3.Size = New System.Drawing.Size(628, 92)
        Me.gbxGrupo3.TabIndex = 1
        Me.gbxGrupo3.TabStop = False
        Me.gbxGrupo3.Text = "Datos implementación"
        '
        'txtPorcBaseImpo_ND
        '
        Me.txtPorcBaseImpo_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPorcBaseImpo_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcBaseImpo_ND.Location = New System.Drawing.Point(31, 45)
        Me.txtPorcBaseImpo_ND.Name = "txtPorcBaseImpo_ND"
        Me.txtPorcBaseImpo_ND.Size = New System.Drawing.Size(133, 26)
        Me.txtPorcBaseImpo_ND.TabIndex = 0
        Me.txtPorcBaseImpo_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "% s/Base Imponible"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombreMoneda
        '
        Me.lblNombreMoneda.AutoSize = True
        Me.lblNombreMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMoneda.Location = New System.Drawing.Point(374, 76)
        Me.lblNombreMoneda.Name = "lblNombreMoneda"
        Me.lblNombreMoneda.Size = New System.Drawing.Size(80, 16)
        Me.lblNombreMoneda.TabIndex = 133
        Me.lblNombreMoneda.Text = "<moneda>"
        '
        'txtCodMoneda_AN
        '
        Me.txtCodMoneda_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMoneda_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMoneda_AN.Location = New System.Drawing.Point(378, 47)
        Me.txtCodMoneda_AN.Name = "txtCodMoneda_AN"
        Me.txtCodMoneda_AN.Size = New System.Drawing.Size(68, 26)
        Me.txtCodMoneda_AN.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(375, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "moneda:"
        '
        'txtValor_ND
        '
        Me.txtValor_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor_ND.Location = New System.Drawing.Point(470, 47)
        Me.txtValor_ND.Name = "txtValor_ND"
        Me.txtValor_ND.Size = New System.Drawing.Size(133, 26)
        Me.txtValor_ND.TabIndex = 3
        Me.txtValor_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbTipoValor
        '
        Me.cmbTipoValor.AccessibleDescription = "tipo"
        Me.cmbTipoValor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipoValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoValor.FormattingEnabled = True
        Me.cmbTipoValor.Items.AddRange(New Object() {"Fijo", "Modificable"})
        Me.cmbTipoValor.Location = New System.Drawing.Point(186, 45)
        Me.cmbTipoValor.Name = "cmbTipoValor"
        Me.cmbTipoValor.Size = New System.Drawing.Size(168, 28)
        Me.cmbTipoValor.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(566, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "valor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "tipo valor:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(888, 219)
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
        Me.cmbEstado.Location = New System.Drawing.Point(91, 13)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 28)
        Me.cmbEstado.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Estado:"
        '
        'frmFa040impuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(916, 391)
        Me.Name = "frmFa040impuestos"
        Me.Tag = ""
        Me.Text = "Formulario de Impuesto"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbxGrupo1.ResumeLayout(False)
        Me.gbxGrupo1.PerformLayout()
        Me.gbxGrupo3.ResumeLayout(False)
        Me.gbxGrupo3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxGrupo1 As GroupBox
    Friend WithEvents txtCodigo_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbxGrupo3 As GroupBox
    Friend WithEvents txtValor_ND As TextBox
    Friend WithEvents cmbTipoValor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre_AN As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNombreMoneda As Label
    Friend WithEvents txtCodMoneda_AN As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPorcBaseImpo_ND As TextBox
    Friend WithEvents Label4 As Label
End Class
