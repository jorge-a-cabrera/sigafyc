<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatusUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusEquipo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusIp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusLoginAcceso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDescripcionMenu = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1226, 29)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusUsuario, Me.lblStatusEquipo, Me.lblStatusIp, Me.lblStatusLoginAcceso, Me.lblStatusFechaHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 600)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(1226, 29)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatusUsuario
        '
        Me.lblStatusUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatusUsuario.Name = "lblStatusUsuario"
        Me.lblStatusUsuario.Size = New System.Drawing.Size(157, 24)
        Me.lblStatusUsuario.Text = "ToolStripStatusLabel1"
        '
        'lblStatusEquipo
        '
        Me.lblStatusEquipo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatusEquipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblStatusEquipo.Name = "lblStatusEquipo"
        Me.lblStatusEquipo.Size = New System.Drawing.Size(157, 24)
        Me.lblStatusEquipo.Text = "ToolStripStatusLabel2"
        '
        'lblStatusIp
        '
        Me.lblStatusIp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatusIp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblStatusIp.Name = "lblStatusIp"
        Me.lblStatusIp.Size = New System.Drawing.Size(157, 24)
        Me.lblStatusIp.Text = "ToolStripStatusLabel3"
        '
        'lblStatusLoginAcceso
        '
        Me.lblStatusLoginAcceso.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatusLoginAcceso.Name = "lblStatusLoginAcceso"
        Me.lblStatusLoginAcceso.Size = New System.Drawing.Size(157, 24)
        Me.lblStatusLoginAcceso.Text = "ToolStripStatusLabel1"
        '
        'lblStatusFechaHora
        '
        Me.lblStatusFechaHora.Name = "lblStatusFechaHora"
        Me.lblStatusFechaHora.Size = New System.Drawing.Size(583, 24)
        Me.lblStatusFechaHora.Spring = True
        Me.lblStatusFechaHora.Text = "ToolStripStatusLabel1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.sigafyc.My.Resources.Resources._7f95204b_37ad_499f_a4b0_83ec7340270c
        Me.PictureBox1.Location = New System.Drawing.Point(494, 224)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblDescripcionMenu
        '
        Me.lblDescripcionMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcionMenu.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionMenu.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDescripcionMenu.Location = New System.Drawing.Point(-4, 566)
        Me.lblDescripcionMenu.Name = "lblDescripcionMenu"
        Me.lblDescripcionMenu.Size = New System.Drawing.Size(1482, 34)
        Me.lblDescripcionMenu.TabIndex = 5
        Me.lblDescripcionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sigafyc.My.Resources.Resources.background_2462431_640
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1226, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDescripcionMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatusUsuario As ToolStripStatusLabel
    Friend WithEvents lblStatusEquipo As ToolStripStatusLabel
    Friend WithEvents lblStatusIp As ToolStripStatusLabel
    Friend WithEvents lblStatusLoginAcceso As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblStatusFechaHora As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDescripcionMenu As Label
End Class
