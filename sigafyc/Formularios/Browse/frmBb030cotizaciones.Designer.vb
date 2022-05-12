<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBb030cotizaciones : Inherits frmBrowseSinGrid

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
        Me.lblNombreMoneda1 = New System.Windows.Forms.Label()
        Me.txtCodMoneda1_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreMoneda2 = New System.Windows.Forms.Label()
        Me.txtCodMoneda2_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(10, 79)
        Me.txtBuscar.Size = New System.Drawing.Size(433, 19)
        Me.txtBuscar.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(449, 446)
        Me.btnSalir.TabIndex = 8
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Location = New System.Drawing.Point(449, 359)
        Me.btnAuditoria.TabIndex = 7
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(449, 272)
        Me.btnConsultar.TabIndex = 6
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(449, 185)
        Me.btnBorrar.TabIndex = 5
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(449, 98)
        Me.btnModificar.TabIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(449, 11)
        Me.btnAgregar.TabIndex = 3
        '
        'lblNombreMoneda1
        '
        Me.lblNombreMoneda1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMoneda1.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreMoneda1.Location = New System.Drawing.Point(132, 14)
        Me.lblNombreMoneda1.Name = "lblNombreMoneda1"
        Me.lblNombreMoneda1.Size = New System.Drawing.Size(205, 24)
        Me.lblNombreMoneda1.TabIndex = 36
        Me.lblNombreMoneda1.Text = "<nombre del usuario>"
        '
        'txtCodMoneda1_AN
        '
        Me.txtCodMoneda1_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMoneda1_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMoneda1_AN.Location = New System.Drawing.Point(52, 12)
        Me.txtCodMoneda1_AN.Name = "txtCodMoneda1_AN"
        Me.txtCodMoneda1_AN.Size = New System.Drawing.Size(74, 26)
        Me.txtCodMoneda1_AN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "De:"
        '
        'lblNombreMoneda2
        '
        Me.lblNombreMoneda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMoneda2.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreMoneda2.Location = New System.Drawing.Point(132, 45)
        Me.lblNombreMoneda2.Name = "lblNombreMoneda2"
        Me.lblNombreMoneda2.Size = New System.Drawing.Size(205, 24)
        Me.lblNombreMoneda2.TabIndex = 39
        Me.lblNombreMoneda2.Text = "<nombre del usuario>"
        '
        'txtCodMoneda2_AN
        '
        Me.txtCodMoneda2_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMoneda2_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMoneda2_AN.Location = New System.Drawing.Point(52, 43)
        Me.txtCodMoneda2_AN.Name = "txtCodMoneda2_AN"
        Me.txtCodMoneda2_AN.Size = New System.Drawing.Size(74, 26)
        Me.txtCodMoneda2_AN.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "A:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(433, 423)
        Me.DataGridView1.TabIndex = 2
        '
        'frmBb030cotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 540)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblNombreMoneda2)
        Me.Controls.Add(Me.txtCodMoneda2_AN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNombreMoneda1)
        Me.Controls.Add(Me.txtCodMoneda1_AN)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmBb030cotizaciones"
        Me.Tag = ""
        Me.Text = "Browse de Cotizaciones"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodMoneda1_AN, 0)
        Me.Controls.SetChildIndex(Me.lblNombreMoneda1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCodMoneda2_AN, 0)
        Me.Controls.SetChildIndex(Me.lblNombreMoneda2, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreMoneda1 As Label
    Friend WithEvents txtCodMoneda1_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreMoneda2 As Label
    Friend WithEvents txtCodMoneda2_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
