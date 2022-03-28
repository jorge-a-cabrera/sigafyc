<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFCierreEjercicio : Inherits frmFormulario

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFCierreEjercicio))
        Me.lblNombreSucursal = New System.Windows.Forms.Label()
        Me.txtCodSucursal_NE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombreDocumento = New System.Windows.Forms.Label()
        Me.txtCodDocumento_NE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecha_FE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkSaldos = New System.Windows.Forms.CheckBox()
        Me.chkCabecera = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(12, 191)
        Me.TabControl1.Size = New System.Drawing.Size(726, 351)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.chkSaldos)
        Me.TabPage1.Controls.Add(Me.chkCabecera)
        Me.TabPage1.Controls.Add(Me.txtFecha_FE)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.lblNombreDocumento)
        Me.TabPage1.Controls.Add(Me.txtCodDocumento_NE)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lblNombreSucursal)
        Me.TabPage1.Controls.Add(Me.txtCodSucursal_NE)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Size = New System.Drawing.Size(718, 311)
        Me.TabPage1.Text = "Parametros para el Cierre"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 548)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(601, 548)
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.IndianRed
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Size = New System.Drawing.Size(722, 179)
        Me.lblMensaje.Text = resources.GetString("lblMensaje.Text")
        '
        'lblNombreSucursal
        '
        Me.lblNombreSucursal.AutoSize = True
        Me.lblNombreSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreSucursal.Location = New System.Drawing.Point(290, 67)
        Me.lblNombreSucursal.Name = "lblNombreSucursal"
        Me.lblNombreSucursal.Size = New System.Drawing.Size(195, 24)
        Me.lblNombreSucursal.TabIndex = 109
        Me.lblNombreSucursal.Text = "<nombre_sucursal>"
        '
        'txtCodSucursal_NE
        '
        Me.txtCodSucursal_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSucursal_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSucursal_NE.Location = New System.Drawing.Point(169, 65)
        Me.txtCodSucursal_NE.Name = "txtCodSucursal_NE"
        Me.txtCodSucursal_NE.Size = New System.Drawing.Size(74, 29)
        Me.txtCodSucursal_NE.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Sucursal:"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(290, 20)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(233, 24)
        Me.lblNombreEmpresa.TabIndex = 107
        Me.lblNombreEmpresa.Text = "<nombre_de_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(169, 18)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 29)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Empresa:"
        '
        'lblNombreDocumento
        '
        Me.lblNombreDocumento.AutoSize = True
        Me.lblNombreDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDocumento.Location = New System.Drawing.Point(290, 116)
        Me.lblNombreDocumento.Name = "lblNombreDocumento"
        Me.lblNombreDocumento.Size = New System.Drawing.Size(222, 24)
        Me.lblNombreDocumento.TabIndex = 112
        Me.lblNombreDocumento.Text = "<nombre_documento>"
        '
        'txtCodDocumento_NE
        '
        Me.txtCodDocumento_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDocumento_NE.Location = New System.Drawing.Point(169, 114)
        Me.txtCodDocumento_NE.Name = "txtCodDocumento_NE"
        Me.txtCodDocumento_NE.Size = New System.Drawing.Size(64, 29)
        Me.txtCodDocumento_NE.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Documento:"
        '
        'txtFecha_FE
        '
        Me.txtFecha_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha_FE.Location = New System.Drawing.Point(169, 167)
        Me.txtFecha_FE.Name = "txtFecha_FE"
        Me.txtFecha_FE.Size = New System.Drawing.Size(115, 29)
        Me.txtFecha_FE.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 24)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Fecha de cierre:"
        '
        'chkSaldos
        '
        Me.chkSaldos.AutoSize = True
        Me.chkSaldos.Location = New System.Drawing.Point(199, 257)
        Me.chkSaldos.Name = "chkSaldos"
        Me.chkSaldos.Size = New System.Drawing.Size(318, 28)
        Me.chkSaldos.TabIndex = 116
        Me.chkSaldos.Text = "Reconstrucción saldos de cuentas"
        Me.chkSaldos.UseVisualStyleBackColor = True
        '
        'chkCabecera
        '
        Me.chkCabecera.AutoSize = True
        Me.chkCabecera.Location = New System.Drawing.Point(200, 223)
        Me.chkCabecera.Name = "chkCabecera"
        Me.chkCabecera.Size = New System.Drawing.Size(319, 28)
        Me.chkCabecera.TabIndex = 115
        Me.chkCabecera.Text = "Reconstrucción cabecera asientos"
        Me.chkCabecera.UseVisualStyleBackColor = True
        '
        'frmFCierreEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(749, 633)
        Me.Name = "frmFCierreEjercicio"
        Me.Tag = ""
        Me.Text = "Parametros Generación Asiento de Cierre de Ejercicio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNombreSucursal As Label
    Friend WithEvents txtCodSucursal_NE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNombreDocumento As Label
    Friend WithEvents txtCodDocumento_NE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFecha_FE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chkSaldos As CheckBox
    Friend WithEvents chkCabecera As CheckBox
End Class
