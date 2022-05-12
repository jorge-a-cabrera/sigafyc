<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBc040mercimpuestos
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
        Me.lblNomMercaderia = New System.Windows.Forms.Label()
        Me.txtCodMercaderia_AN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 105)
        Me.txtBuscar.TabIndex = 10
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
        Me.btnConsultar.TabIndex = 6
        '
        'btnBorrar
        '
        Me.btnBorrar.TabIndex = 5
        '
        'btnModificar
        '
        Me.btnModificar.TabIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(851, 517)
        Me.DataGridView1.TabIndex = 9
        '
        'lblNomMercaderia
        '
        Me.lblNomMercaderia.AutoSize = True
        Me.lblNomMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomMercaderia.ForeColor = System.Drawing.Color.Navy
        Me.lblNomMercaderia.Location = New System.Drawing.Point(258, 75)
        Me.lblNomMercaderia.Name = "lblNomMercaderia"
        Me.lblNomMercaderia.Size = New System.Drawing.Size(188, 20)
        Me.lblNomMercaderia.TabIndex = 50
        Me.lblNomMercaderia.Text = "<nombre_mercaderia>"
        '
        'txtCodMercaderia_AN
        '
        Me.txtCodMercaderia_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMercaderia_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMercaderia_AN.Location = New System.Drawing.Point(121, 73)
        Me.txtCodMercaderia_AN.Name = "txtCodMercaderia_AN"
        Me.txtCodMercaderia_AN.Size = New System.Drawing.Size(131, 26)
        Me.txtCodMercaderia_AN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Mercadería:"
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNomEmpresa.Location = New System.Drawing.Point(258, 9)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(168, 20)
        Me.lblNomEmpresa.TabIndex = 48
        Me.lblNomEmpresa.Text = "<nombre_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(121, 7)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(90, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Empresa:"
        '
        'cmbOperacion
        '
        Me.cmbOperacion.AccessibleDescription = "tipo"
        Me.cmbOperacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"Compra", "Venta"})
        Me.cmbOperacion.Location = New System.Drawing.Point(121, 39)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(131, 28)
        Me.cmbOperacion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Operación:"
        '
        'frmBc040mercimpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 657)
        Me.Controls.Add(Me.cmbOperacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNomMercaderia)
        Me.Controls.Add(Me.txtCodMercaderia_AN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNomEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmBc040mercimpuestos"
        Me.Tag = ""
        Me.Text = "Browse Impuestos por Mercaderia"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodEmpresa_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomEmpresa, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtCodMercaderia_AN, 0)
        Me.Controls.SetChildIndex(Me.lblNomMercaderia, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.cmbOperacion, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNomMercaderia As Label
    Friend WithEvents txtCodMercaderia_AN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents Label3 As Label
End Class
