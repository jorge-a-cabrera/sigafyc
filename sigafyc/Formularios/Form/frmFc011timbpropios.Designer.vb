<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFc011timbpropios
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumTimbrado_NE = New System.Windows.Forms.TextBox()
        Me.gbxGrupo1 = New System.Windows.Forms.GroupBox()
        Me.txtHastaNumero_NE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesdeNumero_NE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNombreSucursal = New System.Windows.Forms.Label()
        Me.txtCodSucursal_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrefijo_AN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxGrupo1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(646, 255)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.txtPrefijo_AN)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtNumTimbrado_NE)
        Me.TabPage1.Controls.Add(Me.gbxGrupo1)
        Me.TabPage1.Controls.Add(Me.lblNombreSucursal)
        Me.TabPage1.Controls.Add(Me.txtCodSucursal_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Size = New System.Drawing.Size(638, 215)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(10, 320)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(515, 320)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(642, 37)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Timbrado No.:"
        '
        'txtNumTimbrado_NE
        '
        Me.txtNumTimbrado_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTimbrado_NE.Location = New System.Drawing.Point(150, 18)
        Me.txtNumTimbrado_NE.Name = "txtNumTimbrado_NE"
        Me.txtNumTimbrado_NE.Size = New System.Drawing.Size(115, 29)
        Me.txtNumTimbrado_NE.TabIndex = 0
        '
        'gbxGrupo1
        '
        Me.gbxGrupo1.Controls.Add(Me.txtHastaNumero_NE)
        Me.gbxGrupo1.Controls.Add(Me.Label8)
        Me.gbxGrupo1.Controls.Add(Me.txtDesdeNumero_NE)
        Me.gbxGrupo1.Controls.Add(Me.Label7)
        Me.gbxGrupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupo1.Location = New System.Drawing.Point(12, 128)
        Me.gbxGrupo1.Name = "gbxGrupo1"
        Me.gbxGrupo1.Size = New System.Drawing.Size(617, 77)
        Me.gbxGrupo1.TabIndex = 80
        Me.gbxGrupo1.TabStop = False
        Me.gbxGrupo1.Text = "rango numeración"
        '
        'txtHastaNumero_NE
        '
        Me.txtHastaNumero_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHastaNumero_NE.Location = New System.Drawing.Point(392, 28)
        Me.txtHastaNumero_NE.Name = "txtHastaNumero_NE"
        Me.txtHastaNumero_NE.Size = New System.Drawing.Size(146, 26)
        Me.txtHastaNumero_NE.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Hasta:"
        '
        'txtDesdeNumero_NE
        '
        Me.txtDesdeNumero_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesdeNumero_NE.Location = New System.Drawing.Point(155, 28)
        Me.txtDesdeNumero_NE.Name = "txtDesdeNumero_NE"
        Me.txtDesdeNumero_NE.Size = New System.Drawing.Size(146, 26)
        Me.txtDesdeNumero_NE.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Desde:"
        '
        'lblNombreSucursal
        '
        Me.lblNombreSucursal.AutoSize = True
        Me.lblNombreSucursal.Location = New System.Drawing.Point(271, 54)
        Me.lblNombreSucursal.Name = "lblNombreSucursal"
        Me.lblNombreSucursal.Size = New System.Drawing.Size(178, 24)
        Me.lblNombreSucursal.TabIndex = 82
        Me.lblNombreSucursal.Text = "<nombre_sucursal>"
        '
        'txtCodSucursal_NE
        '
        Me.txtCodSucursal_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSucursal_NE.Location = New System.Drawing.Point(150, 52)
        Me.txtCodSucursal_NE.Name = "txtCodSucursal_NE"
        Me.txtCodSucursal_NE.Size = New System.Drawing.Size(115, 29)
        Me.txtCodSucursal_NE.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Sucursal"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(638, 215)
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
        Me.cmbEstado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Estado:"
        '
        'txtPrefijo_AN
        '
        Me.txtPrefijo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrefijo_AN.Location = New System.Drawing.Point(150, 87)
        Me.txtPrefijo_AN.Name = "txtPrefijo_AN"
        Me.txtPrefijo_AN.Size = New System.Drawing.Size(115, 29)
        Me.txtPrefijo_AN.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Prefijo"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(271, 18)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(182, 24)
        Me.lblNombreEmpresa.TabIndex = 86
        Me.lblNombreEmpresa.Text = "<nombre_empresa>"
        '
        'frmFc011timbpropios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(662, 405)
        Me.Name = "frmFc011timbpropios"
        Me.Tag = ""
        Me.Text = "Formulario Formulario Timbrados propios (por sucursal y punto expedición)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbxGrupo1.ResumeLayout(False)
        Me.gbxGrupo1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumTimbrado_NE As TextBox
    Friend WithEvents gbxGrupo1 As GroupBox
    Friend WithEvents txtHastaNumero_NE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesdeNumero_NE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNombreSucursal As Label
    Friend WithEvents txtCodSucursal_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrefijo_AN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombreEmpresa As Label
End Class
