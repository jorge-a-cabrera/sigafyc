<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBe020listaprecio
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
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreMercaderia = New System.Windows.Forms.Label()
        Me.txtCodMercaderia_AN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombreUnidad = New System.Windows.Forms.Label()
        Me.txtCodUnidad_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 108)
        '
        'btnAuditoria
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 136)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(851, 514)
        Me.DataGridView1.TabIndex = 27
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(309, 14)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(182, 20)
        Me.lblNombreEmpresa.TabIndex = 42
        Me.lblNombreEmpresa.Text = "<nombre del usuario>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(188, 12)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(74, 26)
        Me.txtCodEmpresa_NE.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Empresa:"
        '
        'lblNombreMercaderia
        '
        Me.lblNombreMercaderia.AutoSize = True
        Me.lblNombreMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMercaderia.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreMercaderia.Location = New System.Drawing.Point(309, 46)
        Me.lblNombreMercaderia.Name = "lblNombreMercaderia"
        Me.lblNombreMercaderia.Size = New System.Drawing.Size(188, 20)
        Me.lblNombreMercaderia.TabIndex = 100
        Me.lblNombreMercaderia.Text = "<nombre_mercaderia>"
        '
        'txtCodMercaderia_AN
        '
        Me.txtCodMercaderia_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMercaderia_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMercaderia_AN.Location = New System.Drawing.Point(188, 44)
        Me.txtCodMercaderia_AN.Name = "txtCodMercaderia_AN"
        Me.txtCodMercaderia_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodMercaderia_AN.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 20)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Mercadería/Servicio:"
        '
        'lblNombreUnidad
        '
        Me.lblNombreUnidad.AutoSize = True
        Me.lblNombreUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUnidad.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreUnidad.Location = New System.Drawing.Point(309, 78)
        Me.lblNombreUnidad.Name = "lblNombreUnidad"
        Me.lblNombreUnidad.Size = New System.Drawing.Size(153, 20)
        Me.lblNombreUnidad.TabIndex = 122
        Me.lblNombreUnidad.Text = "<nombre_unidad>"
        '
        'txtCodUnidad_AN
        '
        Me.txtCodUnidad_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUnidad_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUnidad_AN.Location = New System.Drawing.Point(188, 76)
        Me.txtCodUnidad_AN.Name = "txtCodUnidad_AN"
        Me.txtCodUnidad_AN.Size = New System.Drawing.Size(115, 26)
        Me.txtCodUnidad_AN.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Unidad Medida:"
        '
        'frmBe020listaprecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 658)
        Me.Controls.Add(Me.lblNombreUnidad)
        Me.Controls.Add(Me.txtCodUnidad_AN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNombreMercaderia)
        Me.Controls.Add(Me.txtCodMercaderia_AN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNombreEmpresa)
        Me.Controls.Add(Me.txtCodEmpresa_NE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmBe020listaprecio"
        Me.Tag = ""
        Me.Text = "Browse Lista de Precios"
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
        Me.Controls.SetChildIndex(Me.lblNombreEmpresa, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtCodMercaderia_AN, 0)
        Me.Controls.SetChildIndex(Me.lblNombreMercaderia, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCodUnidad_AN, 0)
        Me.Controls.SetChildIndex(Me.lblNombreUnidad, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreMercaderia As Label
    Friend WithEvents txtCodMercaderia_AN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombreUnidad As Label
    Friend WithEvents txtCodUnidad_AN As TextBox
    Friend WithEvents Label3 As Label
End Class
