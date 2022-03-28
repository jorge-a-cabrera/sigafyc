<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBss100habilitaciones
    Inherits frmBrowseSinGrid

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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigo_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(12, 101)
        Me.txtBuscar.Size = New System.Drawing.Size(851, 19)
        Me.txtBuscar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.TabIndex = 9
        '
        'btnAuditoria
        '
        Me.btnAuditoria.TabIndex = 8
        '
        'btnConsultar
        '
        Me.btnConsultar.TabIndex = 7
        '
        'btnBorrar
        '
        Me.btnBorrar.TabIndex = 6
        '
        'btnModificar
        '
        Me.btnModificar.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(851, 524)
        Me.DataGridView1.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(9, 75)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(114, 20)
        Me.lblNombre.TabIndex = 30
        Me.lblNombre.Text = "asdfsadfasdf"
        '
        'txtCodigo_AN
        '
        Me.txtCodigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo_AN.Location = New System.Drawing.Point(149, 47)
        Me.txtCodigo_AN.Name = "txtCodigo_AN"
        Me.txtCodigo_AN.Size = New System.Drawing.Size(240, 26)
        Me.txtCodigo_AN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Código usuario:"
        '
        'cmbTipo
        '
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Usuario", "Perfil"})
        Me.cmbTipo.Location = New System.Drawing.Point(12, 13)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(246, 28)
        Me.cmbTipo.TabIndex = 0
        Me.cmbTipo.Tag = "Seleccione el Tipo"
        Me.cmbTipo.Text = "Seleccione el Tipo"
        '
        'frmBss100habilitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 659)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCodigo_AN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmBss100habilitaciones"
        Me.Tag = ""
        Me.Text = "Browse Habilitaciones por Perfil/Usuario"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo_AN, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.cmbTipo, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigo_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipo As ComboBox
End Class
