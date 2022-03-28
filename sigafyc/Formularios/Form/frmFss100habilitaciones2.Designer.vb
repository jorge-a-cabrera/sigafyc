<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFss100habilitaciones2
    Inherits frmFormulario

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
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo_AN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSS010_codigo_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtExpira_FE = New System.Windows.Forms.TextBox()
        Me.txtValido_FE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Size = New System.Drawing.Size(862, 521)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.txtBuscar)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.btnAdicionar)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.txtExpira_FE)
        Me.TabPage1.Controls.Add(Me.txtValido_FE)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblNombreUsuario)
        Me.TabPage1.Controls.Add(Me.cmbTipo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtCodigo_AN)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtSS010_codigo_AN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Size = New System.Drawing.Size(854, 481)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(12, 572)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(737, 572)
        '
        'lblMensaje
        '
        Me.lblMensaje.Size = New System.Drawing.Size(858, 37)
        Me.lblMensaje.TabIndex = 2
        '
        'cmbTipo
        '
        Me.cmbTipo.AccessibleDescription = "tipo"
        Me.cmbTipo.AutoCompleteCustomSource.AddRange(New String() {"Usuario", "Perfil"})
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Usuario", "Perfil"})
        Me.cmbTipo.Location = New System.Drawing.Point(141, 58)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(225, 32)
        Me.cmbTipo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 24)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tipo:"
        '
        'txtCodigo_AN
        '
        Me.txtCodigo_AN.AccessibleDescription = "codigo"
        Me.txtCodigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo_AN.Location = New System.Drawing.Point(141, 96)
        Me.txtCodigo_AN.Name = "txtCodigo_AN"
        Me.txtCodigo_AN.Size = New System.Drawing.Size(225, 29)
        Me.txtCodigo_AN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Código:"
        '
        'txtSS010_codigo_AN
        '
        Me.txtSS010_codigo_AN.AccessibleDescription = "ss010_codigo"
        Me.txtSS010_codigo_AN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSS010_codigo_AN.Location = New System.Drawing.Point(141, 23)
        Me.txtSS010_codigo_AN.Name = "txtSS010_codigo_AN"
        Me.txtSS010_codigo_AN.Size = New System.Drawing.Size(225, 29)
        Me.txtSS010_codigo_AN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Sistema:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.Location = New System.Drawing.Point(378, 101)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(467, 24)
        Me.lblNombreUsuario.TabIndex = 38
        '
        'txtExpira_FE
        '
        Me.txtExpira_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExpira_FE.Location = New System.Drawing.Point(610, 59)
        Me.txtExpira_FE.Name = "txtExpira_FE"
        Me.txtExpira_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtExpira_FE.TabIndex = 4
        '
        'txtValido_FE
        '
        Me.txtValido_FE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValido_FE.Location = New System.Drawing.Point(610, 23)
        Me.txtValido_FE.Name = "txtValido_FE"
        Me.txtValido_FE.Size = New System.Drawing.Size(235, 29)
        Me.txtValido_FE.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(475, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Expira en:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(475, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Valido desde:"
        '
        'TabPage2
        '
        Me.TabPage2.AccessibleName = "Activo"
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(854, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Complementario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Bloqueado"})
        Me.cmbEstado.Location = New System.Drawing.Point(238, 19)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(196, 32)
        Me.cmbEstado.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Estado operativo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(360, 292)
        Me.DataGridView1.TabIndex = 5
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Image = Global.sigafyc.My.Resources.Resources.icons8_next_page_32
        Me.btnAdicionar.Location = New System.Drawing.Point(387, 260)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 61)
        Me.btnAdicionar.TabIndex = 43
        Me.btnAdicionar.Tag = "agregar"
        Me.btnAdicionar.Text = "agregar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.sigafyc.My.Resources.Resources.icons8_back_to_32
        Me.btnEliminar.Location = New System.Drawing.Point(387, 338)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 61)
        Me.btnEliminar.TabIndex = 44
        Me.btnEliminar.Tag = "qutiar"
        Me.btnEliminar.Text = "qutiar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "restricciones disponibles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(481, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 24)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "restricciones a agregar"
        '
        'txtBuscar
        '
        Me.txtBuscar.AccessibleDescription = "codigo"
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(6, 131)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(360, 29)
        Me.txtBuscar.TabIndex = 47
        Me.txtBuscar.Tag = "ingrese su busqueda"
        Me.txtBuscar.Text = "ingrese su busqueda"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(485, 187)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(360, 292)
        Me.ListBox1.TabIndex = 6
        '
        'frmFss100habilitaciones2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(883, 656)
        Me.Name = "frmFss100habilitaciones2"
        Me.Tag = ""
        Me.Text = "Formulario Hablitacones para Perfiles/Usuarios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo_AN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSS010_codigo_AN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents txtExpira_FE As TextBox
    Friend WithEvents txtValido_FE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
