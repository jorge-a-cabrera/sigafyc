﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFEnviarMail : Inherits frmFormulario

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
        Me.gbxGrupo1 = New System.Windows.Forms.GroupBox()
        Me.txtFromFullName_AN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMailFrom_AN = New System.Windows.Forms.TextBox()
        Me.gbxGrupo2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNameCCO_AN = New System.Windows.Forms.TextBox()
        Me.txtNameCC_AN = New System.Windows.Forms.TextBox()
        Me.txtNameTo_AN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMailCCO_AN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMailCC_AN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMailTo_AN = New System.Windows.Forms.TextBox()
        Me.txtAsunto_AN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMensaje_AN = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAdjuntos = New System.Windows.Forms.Button()
        Me.lstAdjuntos = New System.Windows.Forms.ListBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxGrupo1.SuspendLayout()
        Me.gbxGrupo2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 12)
        Me.TabControl1.Size = New System.Drawing.Size(896, 599)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.txtMensaje_AN)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtAsunto_AN)
        Me.TabPage1.Controls.Add(Me.gbxGrupo2)
        Me.TabPage1.Controls.Add(Me.gbxGrupo1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Size = New System.Drawing.Size(888, 563)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(12, 617)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(767, 617)
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Size = New System.Drawing.Size(888, 37)
        '
        'gbxGrupo1
        '
        Me.gbxGrupo1.Controls.Add(Me.txtFromFullName_AN)
        Me.gbxGrupo1.Controls.Add(Me.Label4)
        Me.gbxGrupo1.Controls.Add(Me.Label3)
        Me.gbxGrupo1.Controls.Add(Me.txtMailFrom_AN)
        Me.gbxGrupo1.Location = New System.Drawing.Point(22, 21)
        Me.gbxGrupo1.Name = "gbxGrupo1"
        Me.gbxGrupo1.Size = New System.Drawing.Size(840, 113)
        Me.gbxGrupo1.TabIndex = 0
        Me.gbxGrupo1.TabStop = False
        Me.gbxGrupo1.Text = "de (remitente):"
        '
        'txtFromFullName_AN
        '
        Me.txtFromFullName_AN.Location = New System.Drawing.Point(205, 62)
        Me.txtFromFullName_AN.Name = "txtFromFullName_AN"
        Me.txtFromFullName_AN.Size = New System.Drawing.Size(612, 26)
        Me.txtFromFullName_AN.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre completo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cuenta correo:"
        '
        'txtMailFrom_AN
        '
        Me.txtMailFrom_AN.Location = New System.Drawing.Point(205, 30)
        Me.txtMailFrom_AN.Name = "txtMailFrom_AN"
        Me.txtMailFrom_AN.Size = New System.Drawing.Size(612, 26)
        Me.txtMailFrom_AN.TabIndex = 0
        '
        'gbxGrupo2
        '
        Me.gbxGrupo2.Controls.Add(Me.Label9)
        Me.gbxGrupo2.Controls.Add(Me.Label8)
        Me.gbxGrupo2.Controls.Add(Me.txtNameCCO_AN)
        Me.gbxGrupo2.Controls.Add(Me.txtNameCC_AN)
        Me.gbxGrupo2.Controls.Add(Me.txtNameTo_AN)
        Me.gbxGrupo2.Controls.Add(Me.Label7)
        Me.gbxGrupo2.Controls.Add(Me.txtMailCCO_AN)
        Me.gbxGrupo2.Controls.Add(Me.Label6)
        Me.gbxGrupo2.Controls.Add(Me.txtMailCC_AN)
        Me.gbxGrupo2.Controls.Add(Me.Label5)
        Me.gbxGrupo2.Controls.Add(Me.txtMailTo_AN)
        Me.gbxGrupo2.Location = New System.Drawing.Point(22, 140)
        Me.gbxGrupo2.Name = "gbxGrupo2"
        Me.gbxGrupo2.Size = New System.Drawing.Size(840, 166)
        Me.gbxGrupo2.TabIndex = 1
        Me.gbxGrupo2.TabStop = False
        Me.gbxGrupo2.Text = "para (destinatario):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(380, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "nombre del destinatario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "email:"
        '
        'txtNameCCO_AN
        '
        Me.txtNameCCO_AN.Location = New System.Drawing.Point(384, 122)
        Me.txtNameCCO_AN.Name = "txtNameCCO_AN"
        Me.txtNameCCO_AN.Size = New System.Drawing.Size(436, 26)
        Me.txtNameCCO_AN.TabIndex = 5
        '
        'txtNameCC_AN
        '
        Me.txtNameCC_AN.Location = New System.Drawing.Point(384, 90)
        Me.txtNameCC_AN.Name = "txtNameCC_AN"
        Me.txtNameCC_AN.Size = New System.Drawing.Size(436, 26)
        Me.txtNameCC_AN.TabIndex = 3
        '
        'txtNameTo_AN
        '
        Me.txtNameTo_AN.Location = New System.Drawing.Point(384, 58)
        Me.txtNameTo_AN.Name = "txtNameTo_AN"
        Me.txtNameTo_AN.Size = New System.Drawing.Size(436, 26)
        Me.txtNameTo_AN.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "cco.:"
        '
        'txtMailCCO_AN
        '
        Me.txtMailCCO_AN.Location = New System.Drawing.Point(71, 122)
        Me.txtMailCCO_AN.Name = "txtMailCCO_AN"
        Me.txtMailCCO_AN.Size = New System.Drawing.Size(307, 26)
        Me.txtMailCCO_AN.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "cc.:"
        '
        'txtMailCC_AN
        '
        Me.txtMailCC_AN.Location = New System.Drawing.Point(71, 90)
        Me.txtMailCC_AN.Name = "txtMailCC_AN"
        Me.txtMailCC_AN.Size = New System.Drawing.Size(307, 26)
        Me.txtMailCC_AN.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "a:"
        '
        'txtMailTo_AN
        '
        Me.txtMailTo_AN.Location = New System.Drawing.Point(71, 58)
        Me.txtMailTo_AN.Name = "txtMailTo_AN"
        Me.txtMailTo_AN.Size = New System.Drawing.Size(307, 26)
        Me.txtMailTo_AN.TabIndex = 0
        '
        'txtAsunto_AN
        '
        Me.txtAsunto_AN.Location = New System.Drawing.Point(22, 337)
        Me.txtAsunto_AN.Name = "txtAsunto_AN"
        Me.txtAsunto_AN.Size = New System.Drawing.Size(840, 26)
        Me.txtAsunto_AN.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Asunto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mensaje:"
        '
        'txtMensaje_AN
        '
        Me.txtMensaje_AN.Location = New System.Drawing.Point(22, 400)
        Me.txtMensaje_AN.Multiline = True
        Me.txtMensaje_AN.Name = "txtMensaje_AN"
        Me.txtMensaje_AN.Size = New System.Drawing.Size(840, 139)
        Me.txtMensaje_AN.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnQuitar)
        Me.TabPage2.Controls.Add(Me.btnAdjuntos)
        Me.TabPage2.Controls.Add(Me.lstAdjuntos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(888, 563)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Adjunto(s)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAdjuntos
        '
        Me.btnAdjuntos.Location = New System.Drawing.Point(17, 15)
        Me.btnAdjuntos.Name = "btnAdjuntos"
        Me.btnAdjuntos.Size = New System.Drawing.Size(265, 36)
        Me.btnAdjuntos.TabIndex = 0
        Me.btnAdjuntos.Text = "agregar adjunto"
        Me.btnAdjuntos.UseVisualStyleBackColor = True
        '
        'lstAdjuntos
        '
        Me.lstAdjuntos.FormattingEnabled = True
        Me.lstAdjuntos.ItemHeight = 20
        Me.lstAdjuntos.Location = New System.Drawing.Point(17, 57)
        Me.lstAdjuntos.Name = "lstAdjuntos"
        Me.lstAdjuntos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAdjuntos.Size = New System.Drawing.Size(854, 484)
        Me.lstAdjuntos.TabIndex = 2
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(606, 15)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(265, 36)
        Me.btnQuitar.TabIndex = 1
        Me.btnQuitar.Text = "quitar adjunto"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'frmFEnviarMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Nothing
        Me.ClientSize = New System.Drawing.Size(914, 703)
        Me.Name = "frmFEnviarMail"
        Me.Tag = ""
        Me.Text = "Parametros para Envio de Mail"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbxGrupo1.ResumeLayout(False)
        Me.gbxGrupo1.PerformLayout()
        Me.gbxGrupo2.ResumeLayout(False)
        Me.gbxGrupo2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAsunto_AN As TextBox
    Friend WithEvents gbxGrupo2 As GroupBox
    Friend WithEvents gbxGrupo1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMensaje_AN As TextBox
    Friend WithEvents txtFromFullName_AN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMailFrom_AN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMailCCO_AN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMailCC_AN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMailTo_AN As TextBox
    Friend WithEvents txtNameTo_AN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNameCCO_AN As TextBox
    Friend WithEvents txtNameCC_AN As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnAdjuntos As Button
    Friend WithEvents lstAdjuntos As ListBox
    Friend WithEvents btnQuitar As Button
End Class
