<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBc040docimpuestos
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
        Me.lblNomEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodDocumento_NE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNomDocumento = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(14, 76)
        Me.txtBuscar.Size = New System.Drawing.Size(847, 22)
        '
        'btnSalir
        '
        Me.btnSalir.TabIndex = 7
        '
        'btnAuditoria
        '
        Me.btnAuditoria.TabIndex = 6
        '
        'btnConsultar
        '
        Me.btnConsultar.TabIndex = 5
        '
        'btnBorrar
        '
        Me.btnBorrar.TabIndex = 4
        '
        'btnModificar
        '
        Me.btnModificar.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.TabIndex = 2
        '
        'lblNomEmpresa
        '
        Me.lblNomEmpresa.AutoSize = True
        Me.lblNomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEmpresa.Location = New System.Drawing.Point(202, 14)
        Me.lblNomEmpresa.Name = "lblNomEmpresa"
        Me.lblNomEmpresa.Size = New System.Drawing.Size(182, 20)
        Me.lblNomEmpresa.TabIndex = 39
        Me.lblNomEmpresa.Text = "<nombre del usuario>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(122, 12)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(74, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Empresa:"
        '
        'txtCodDocumento_NE
        '
        Me.txtCodDocumento_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDocumento_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDocumento_NE.Location = New System.Drawing.Point(122, 44)
        Me.txtCodDocumento_NE.Name = "txtCodDocumento_NE"
        Me.txtCodDocumento_NE.Size = New System.Drawing.Size(53, 26)
        Me.txtCodDocumento_NE.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Documento:"
        '
        'lblNomDocumento
        '
        Me.lblNomDocumento.AutoSize = True
        Me.lblNomDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomDocumento.Location = New System.Drawing.Point(202, 46)
        Me.lblNomDocumento.Name = "lblNomDocumento"
        Me.lblNomDocumento.Size = New System.Drawing.Size(183, 20)
        Me.lblNomDocumento.TabIndex = 42
        Me.lblNomDocumento.Text = "<nombre documento>"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(847, 546)
        Me.DataGridView1.TabIndex = 43
        '
        'frmBc040docimpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 656)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblNomDocumento)
        Me.Controls.Add(Me.txtCodDocumento_NE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNomEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBc040docimpuestos"
        Me.Tag = ""
        Me.Text = "Browse Impuestos por documento"
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnAuditoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.txtBuscar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCodEmpresa_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomEmpresa, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtCodDocumento_NE, 0)
        Me.Controls.SetChildIndex(Me.lblNomDocumento, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNomEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodDocumento_NE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNomDocumento As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
