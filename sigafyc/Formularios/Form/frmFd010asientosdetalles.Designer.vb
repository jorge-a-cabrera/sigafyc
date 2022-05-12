<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFd010asientosdetalles : Inherits frmFormulario

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
        Me.components = New System.ComponentModel.Container()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNroAsiento_NE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.txtCodEmpresa_NE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo_NE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuenta6_NE = New System.Windows.Forms.TextBox()
        Me.txtCuenta5_NE = New System.Windows.Forms.TextBox()
        Me.txtCuenta4_NE = New System.Windows.Forms.TextBox()
        Me.txtCuenta3_NE = New System.Windows.Forms.TextBox()
        Me.txtCuenta2_NE = New System.Windows.Forms.TextBox()
        Me.txtCuenta1_NE = New System.Windows.Forms.TextBox()
        Me.ttxCodCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombreCuenta = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.txtImporte_mo_ND = New System.Windows.Forms.TextBox()
        Me.txtConcepto_AN = New System.Windows.Forms.TextBox()
        Me.mnuRecuperaAnterior = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.opcRecuperarAnterior = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCodConcepto_NE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ttxImporte_mb_ND = New System.Windows.Forms.TextBox()
        Me.lblImporte_mb = New System.Windows.Forms.Label()
        Me.lblCotizacion = New System.Windows.Forms.Label()
        Me.lblImporte_mo = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.mnuRecuperaAnterior.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Size = New System.Drawing.Size(896, 487)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblImporte_mo)
        Me.TabPage1.Controls.Add(Me.lblCotizacion)
        Me.TabPage1.Controls.Add(Me.lblImporte_mb)
        Me.TabPage1.Controls.Add(Me.ttxImporte_mb_ND)
        Me.TabPage1.Controls.Add(Me.txtConcepto_AN)
        Me.TabPage1.Controls.Add(Me.txtCodConcepto_NE)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lblImporte)
        Me.TabPage1.Controls.Add(Me.txtImporte_mo_ND)
        Me.TabPage1.Controls.Add(Me.cmbTipo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lblNombreCuenta)
        Me.TabPage1.Controls.Add(Me.txtCuenta6_NE)
        Me.TabPage1.Controls.Add(Me.txtCuenta5_NE)
        Me.TabPage1.Controls.Add(Me.txtCuenta4_NE)
        Me.TabPage1.Controls.Add(Me.txtCuenta3_NE)
        Me.TabPage1.Controls.Add(Me.txtCuenta2_NE)
        Me.TabPage1.Controls.Add(Me.txtCuenta1_NE)
        Me.TabPage1.Controls.Add(Me.ttxCodCuenta)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCodigo_NE)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtNroAsiento_NE)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblNombreEmpresa)
        Me.TabPage1.Controls.Add(Me.txtCodEmpresa_NE)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(888, 451)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 538)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(771, 538)
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(888, 451)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(85, 19)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(159, 28)
        Me.cmbEstado.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Estado:"
        '
        'txtNroAsiento_NE
        '
        Me.txtNroAsiento_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroAsiento_NE.Location = New System.Drawing.Point(179, 47)
        Me.txtNroAsiento_NE.Name = "txtNroAsiento_NE"
        Me.txtNroAsiento_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtNroAsiento_NE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Asiento No.:"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(300, 17)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(179, 20)
        Me.lblNombreEmpresa.TabIndex = 51
        Me.lblNombreEmpresa.Text = "<nombre_de_empresa>"
        '
        'txtCodEmpresa_NE
        '
        Me.txtCodEmpresa_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpresa_NE.Location = New System.Drawing.Point(179, 15)
        Me.txtCodEmpresa_NE.Name = "txtCodEmpresa_NE"
        Me.txtCodEmpresa_NE.Size = New System.Drawing.Size(115, 26)
        Me.txtCodEmpresa_NE.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Empresa:"
        '
        'txtCodigo_NE
        '
        Me.txtCodigo_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_NE.Location = New System.Drawing.Point(179, 79)
        Me.txtCodigo_NE.Name = "txtCodigo_NE"
        Me.txtCodigo_NE.Size = New System.Drawing.Size(64, 26)
        Me.txtCodigo_NE.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Movimiento No.:"
        '
        'txtCuenta6_NE
        '
        Me.txtCuenta6_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta6_NE.Location = New System.Drawing.Point(447, 111)
        Me.txtCuenta6_NE.Name = "txtCuenta6_NE"
        Me.txtCuenta6_NE.Size = New System.Drawing.Size(75, 26)
        Me.txtCuenta6_NE.TabIndex = 8
        Me.txtCuenta6_NE.Text = "000000"
        '
        'txtCuenta5_NE
        '
        Me.txtCuenta5_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta5_NE.Location = New System.Drawing.Point(376, 111)
        Me.txtCuenta5_NE.Name = "txtCuenta5_NE"
        Me.txtCuenta5_NE.Size = New System.Drawing.Size(65, 26)
        Me.txtCuenta5_NE.TabIndex = 7
        Me.txtCuenta5_NE.Text = "00000"
        '
        'txtCuenta4_NE
        '
        Me.txtCuenta4_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta4_NE.Location = New System.Drawing.Point(312, 111)
        Me.txtCuenta4_NE.Name = "txtCuenta4_NE"
        Me.txtCuenta4_NE.Size = New System.Drawing.Size(58, 26)
        Me.txtCuenta4_NE.TabIndex = 6
        Me.txtCuenta4_NE.Text = "0000"
        '
        'txtCuenta3_NE
        '
        Me.txtCuenta3_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta3_NE.Location = New System.Drawing.Point(258, 111)
        Me.txtCuenta3_NE.Name = "txtCuenta3_NE"
        Me.txtCuenta3_NE.Size = New System.Drawing.Size(48, 26)
        Me.txtCuenta3_NE.TabIndex = 5
        Me.txtCuenta3_NE.Text = "000"
        '
        'txtCuenta2_NE
        '
        Me.txtCuenta2_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta2_NE.Location = New System.Drawing.Point(213, 111)
        Me.txtCuenta2_NE.Name = "txtCuenta2_NE"
        Me.txtCuenta2_NE.Size = New System.Drawing.Size(39, 26)
        Me.txtCuenta2_NE.TabIndex = 4
        Me.txtCuenta2_NE.Text = "00"
        '
        'txtCuenta1_NE
        '
        Me.txtCuenta1_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta1_NE.Location = New System.Drawing.Point(179, 111)
        Me.txtCuenta1_NE.Name = "txtCuenta1_NE"
        Me.txtCuenta1_NE.Size = New System.Drawing.Size(28, 26)
        Me.txtCuenta1_NE.TabIndex = 3
        Me.txtCuenta1_NE.Text = "0"
        '
        'ttxCodCuenta
        '
        Me.ttxCodCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ttxCodCuenta.Location = New System.Drawing.Point(568, 111)
        Me.ttxCodCuenta.Name = "ttxCodCuenta"
        Me.ttxCodCuenta.ReadOnly = True
        Me.ttxCodCuenta.Size = New System.Drawing.Size(310, 26)
        Me.ttxCodCuenta.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Cuenta contable:"
        '
        'lblNombreCuenta
        '
        Me.lblNombreCuenta.AutoSize = True
        Me.lblNombreCuenta.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreCuenta.Location = New System.Drawing.Point(175, 140)
        Me.lblNombreCuenta.Name = "lblNombreCuenta"
        Me.lblNombreCuenta.Size = New System.Drawing.Size(209, 20)
        Me.lblNombreCuenta.TabIndex = 64
        Me.lblNombreCuenta.Text = "<nombre_cuenta_contable>"
        '
        'cmbTipo
        '
        Me.cmbTipo.AccessibleDescription = "tipo"
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"1-Debito", "2-Credito"})
        Me.cmbTipo.Location = New System.Drawing.Point(179, 217)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(191, 28)
        Me.cmbTipo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Tipo movimiento:"
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(389, 217)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(224, 24)
        Me.lblImporte.TabIndex = 68
        Me.lblImporte.Text = "Importe:"
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImporte_mo_ND
        '
        Me.txtImporte_mo_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporte_mo_ND.Location = New System.Drawing.Point(619, 215)
        Me.txtImporte_mo_ND.Name = "txtImporte_mo_ND"
        Me.txtImporte_mo_ND.Size = New System.Drawing.Size(263, 26)
        Me.txtImporte_mo_ND.TabIndex = 11
        Me.txtImporte_mo_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConcepto_AN
        '
        Me.txtConcepto_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcepto_AN.ContextMenuStrip = Me.mnuRecuperaAnterior
        Me.txtConcepto_AN.Location = New System.Drawing.Point(179, 282)
        Me.txtConcepto_AN.Multiline = True
        Me.txtConcepto_AN.Name = "txtConcepto_AN"
        Me.txtConcepto_AN.Size = New System.Drawing.Size(703, 158)
        Me.txtConcepto_AN.TabIndex = 13
        '
        'mnuRecuperaAnterior
        '
        Me.mnuRecuperaAnterior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcRecuperarAnterior})
        Me.mnuRecuperaAnterior.Name = "ContextMenuStrip1"
        Me.mnuRecuperaAnterior.Size = New System.Drawing.Size(210, 26)
        '
        'opcRecuperarAnterior
        '
        Me.opcRecuperarAnterior.Name = "opcRecuperarAnterior"
        Me.opcRecuperarAnterior.Size = New System.Drawing.Size(209, 22)
        Me.opcRecuperarAnterior.Text = "Estirar concepto cabecera"
        '
        'txtCodConcepto_NE
        '
        Me.txtCodConcepto_NE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodConcepto_NE.Location = New System.Drawing.Point(179, 250)
        Me.txtCodConcepto_NE.Name = "txtCodConcepto_NE"
        Me.txtCodConcepto_NE.Size = New System.Drawing.Size(65, 26)
        Me.txtCodConcepto_NE.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Concepto:"
        '
        'ttxImporte_mb_ND
        '
        Me.ttxImporte_mb_ND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ttxImporte_mb_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttxImporte_mb_ND.ForeColor = System.Drawing.Color.DarkBlue
        Me.ttxImporte_mb_ND.Location = New System.Drawing.Point(619, 247)
        Me.ttxImporte_mb_ND.Name = "ttxImporte_mb_ND"
        Me.ttxImporte_mb_ND.ReadOnly = True
        Me.ttxImporte_mb_ND.Size = New System.Drawing.Size(263, 29)
        Me.ttxImporte_mb_ND.TabIndex = 71
        Me.ttxImporte_mb_ND.TabStop = False
        Me.ttxImporte_mb_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImporte_mb
        '
        Me.lblImporte_mb.ForeColor = System.Drawing.Color.Navy
        Me.lblImporte_mb.Location = New System.Drawing.Point(389, 252)
        Me.lblImporte_mb.Name = "lblImporte_mb"
        Me.lblImporte_mb.Size = New System.Drawing.Size(224, 24)
        Me.lblImporte_mb.TabIndex = 72
        Me.lblImporte_mb.Text = "Importe:"
        Me.lblImporte_mb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCotizacion
        '
        Me.lblCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotizacion.ForeColor = System.Drawing.Color.Navy
        Me.lblCotizacion.Location = New System.Drawing.Point(300, 46)
        Me.lblCotizacion.Name = "lblCotizacion"
        Me.lblCotizacion.Size = New System.Drawing.Size(578, 24)
        Me.lblCotizacion.TabIndex = 73
        Me.lblCotizacion.Text = "<cotizacion segun documento>"
        Me.lblCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImporte_mo
        '
        Me.lblImporte_mo.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.lblImporte_mo.BackColor = System.Drawing.Color.White
        Me.lblImporte_mo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImporte_mo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte_mo.Location = New System.Drawing.Point(619, 188)
        Me.lblImporte_mo.Name = "lblImporte_mo"
        Me.lblImporte_mo.Size = New System.Drawing.Size(263, 24)
        Me.lblImporte_mo.TabIndex = 10
        Me.lblImporte_mo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmFd010asientosdetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(914, 621)
        Me.Name = "frmFd010asientosdetalles"
        Me.Tag = ""
        Me.Text = "Formulario Movimiento contable"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.lblMensaje, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.mnuRecuperaAnterior.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtNroAsiento_NE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents txtCodEmpresa_NE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo_NE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuenta6_NE As TextBox
    Friend WithEvents txtCuenta5_NE As TextBox
    Friend WithEvents txtCuenta4_NE As TextBox
    Friend WithEvents txtCuenta3_NE As TextBox
    Friend WithEvents txtCuenta2_NE As TextBox
    Friend WithEvents txtCuenta1_NE As TextBox
    Friend WithEvents ttxCodCuenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombreCuenta As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblImporte As Label
    Friend WithEvents txtImporte_mo_ND As TextBox
    Friend WithEvents txtConcepto_AN As TextBox
    Friend WithEvents txtCodConcepto_NE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mnuRecuperaAnterior As ContextMenuStrip
    Friend WithEvents opcRecuperarAnterior As ToolStripMenuItem
    Friend WithEvents lblImporte_mb As Label
    Friend WithEvents ttxImporte_mb_ND As TextBox
    Friend WithEvents lblCotizacion As Label
    Friend WithEvents lblImporte_mo As Label
End Class
