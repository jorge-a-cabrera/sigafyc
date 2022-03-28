<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBss090perusu
    Inherits frmBrowseSinGrid

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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSS050_codigo_AB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(10, 47)
        Me.txtBuscar.Size = New System.Drawing.Size(851, 19)
        Me.txtBuscar.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.TabIndex = 8
        '
        'btnAuditoria
        '
        Me.btnAuditoria.TabIndex = 7
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(867, 308)
        Me.btnConsultar.TabIndex = 6
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(867, 221)
        Me.btnBorrar.TabIndex = 5
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(867, 134)
        Me.btnModificar.TabIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(867, 47)
        Me.btnAgregar.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(10, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(851, 578)
        Me.DataGridView1.TabIndex = 2
        '
        'txtSS050_codigo_AB
        '
        Me.txtSS050_codigo_AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSS050_codigo_AB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSS050_codigo_AB.Location = New System.Drawing.Point(146, 15)
        Me.txtSS050_codigo_AB.Name = "txtSS050_codigo_AB"
        Me.txtSS050_codigo_AB.Size = New System.Drawing.Size(235, 26)
        Me.txtSS050_codigo_AB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Codigo usuario:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(387, 15)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(182, 20)
        Me.lblNombreUsuario.TabIndex = 27
        Me.lblNombreUsuario.Text = "<nombre del usuario>"
        '
        'frmBss090perusu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 659)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.txtSS050_codigo_AB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmBss090perusu"
        Me.Tag = ""
        Me.Text = "Browse Perfiles por Usuario"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtSS050_codigo_AB, 0)
        Me.Controls.SetChildIndex(Me.lblNombreUsuario, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSS050_codigo_AB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreUsuario As Label
End Class
