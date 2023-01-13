<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmautores
    Inherits System.Windows.Forms.Form

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
        Me.lblname1 = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblname2 = New System.Windows.Forms.Label()
        Me.lblemail2 = New System.Windows.Forms.Label()
        Me.lblname3 = New System.Windows.Forms.Label()
        Me.lblemail3 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.txtautor1 = New System.Windows.Forms.TextBox()
        Me.txtautor2 = New System.Windows.Forms.TextBox()
        Me.txtemail2 = New System.Windows.Forms.TextBox()
        Me.txtautor3 = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.email3 = New System.Windows.Forms.TextBox()
        Me.txtemail1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblname1
        '
        Me.lblname1.AutoSize = True
        Me.lblname1.Location = New System.Drawing.Point(12, 24)
        Me.lblname1.Name = "lblname1"
        Me.lblname1.Size = New System.Drawing.Size(87, 13)
        Me.lblname1.TabIndex = 0
        Me.lblname1.Text = "nombre de autor "
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(12, 59)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(92, 13)
        Me.lblemail.TabIndex = 1
        Me.lblemail.Text = "correo electronico"
        '
        'lblname2
        '
        Me.lblname2.AutoSize = True
        Me.lblname2.Location = New System.Drawing.Point(12, 97)
        Me.lblname2.Name = "lblname2"
        Me.lblname2.Size = New System.Drawing.Size(133, 13)
        Me.lblname2.TabIndex = 2
        Me.lblname2.Text = "nombre del segundo autor "
        '
        'lblemail2
        '
        Me.lblemail2.AutoSize = True
        Me.lblemail2.Location = New System.Drawing.Point(12, 131)
        Me.lblemail2.Name = "lblemail2"
        Me.lblemail2.Size = New System.Drawing.Size(89, 13)
        Me.lblemail2.TabIndex = 3
        Me.lblemail2.Text = "correo elctronico "
        '
        'lblname3
        '
        Me.lblname3.AutoSize = True
        Me.lblname3.Location = New System.Drawing.Point(12, 164)
        Me.lblname3.Name = "lblname3"
        Me.lblname3.Size = New System.Drawing.Size(119, 13)
        Me.lblname3.TabIndex = 4
        Me.lblname3.Text = "nombre del tercer autor "
        '
        'lblemail3
        '
        Me.lblemail3.AutoSize = True
        Me.lblemail3.Location = New System.Drawing.Point(12, 206)
        Me.lblemail3.Name = "lblemail3"
        Me.lblemail3.Size = New System.Drawing.Size(92, 13)
        Me.lblemail3.TabIndex = 5
        Me.lblemail3.Text = "correo electronico"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(12, 252)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(96, 13)
        Me.lblfecha.TabIndex = 6
        Me.lblfecha.Text = "fecha de creacion "
        '
        'txtautor1
        '
        Me.txtautor1.Enabled = False
        Me.txtautor1.Location = New System.Drawing.Point(148, 21)
        Me.txtautor1.Name = "txtautor1"
        Me.txtautor1.Size = New System.Drawing.Size(161, 20)
        Me.txtautor1.TabIndex = 7
        Me.txtautor1.Text = "Andrey Sanchez Zuniga"
        '
        'txtautor2
        '
        Me.txtautor2.Enabled = False
        Me.txtautor2.Location = New System.Drawing.Point(148, 90)
        Me.txtautor2.Name = "txtautor2"
        Me.txtautor2.Size = New System.Drawing.Size(161, 20)
        Me.txtautor2.TabIndex = 8
        Me.txtautor2.Text = "Stephanie Mora Jiménez"
        '
        'txtemail2
        '
        Me.txtemail2.Enabled = False
        Me.txtemail2.Location = New System.Drawing.Point(148, 124)
        Me.txtemail2.Name = "txtemail2"
        Me.txtemail2.Size = New System.Drawing.Size(161, 20)
        Me.txtemail2.TabIndex = 9
        Me.txtemail2.Text = "stephanie_2103@hotmail.com"
        '
        'txtautor3
        '
        Me.txtautor3.Enabled = False
        Me.txtautor3.Location = New System.Drawing.Point(148, 161)
        Me.txtautor3.Name = "txtautor3"
        Me.txtautor3.Size = New System.Drawing.Size(161, 20)
        Me.txtautor3.TabIndex = 10
        Me.txtautor3.Text = "Alejandra Cordero Matamoros "
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(148, 245)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(72, 20)
        Me.txtfecha.TabIndex = 12
        Me.txtfecha.Text = "26/05/2019"
        '
        'email3
        '
        Me.email3.Enabled = False
        Me.email3.Location = New System.Drawing.Point(148, 206)
        Me.email3.Name = "email3"
        Me.email3.Size = New System.Drawing.Size(161, 20)
        Me.email3.TabIndex = 13
        Me.email3.Text = "alejandracm88@gmail.com"
        '
        'txtemail1
        '
        Me.txtemail1.Enabled = False
        Me.txtemail1.Location = New System.Drawing.Point(148, 56)
        Me.txtemail1.Name = "txtemail1"
        Me.txtemail1.Size = New System.Drawing.Size(161, 20)
        Me.txtemail1.TabIndex = 14
        Me.txtemail1.Text = "andrey.sanchez30@hotmail.com"
        '
        'frmautores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(350, 285)
        Me.Controls.Add(Me.txtemail1)
        Me.Controls.Add(Me.email3)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtautor3)
        Me.Controls.Add(Me.txtemail2)
        Me.Controls.Add(Me.txtautor2)
        Me.Controls.Add(Me.txtautor1)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblemail3)
        Me.Controls.Add(Me.lblname3)
        Me.Controls.Add(Me.lblemail2)
        Me.Controls.Add(Me.lblname2)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblname1)
        Me.Name = "frmautores"
        Me.Text = "frmautores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname1 As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblname2 As Label
    Friend WithEvents lblemail2 As Label
    Friend WithEvents lblname3 As Label
    Friend WithEvents lblemail3 As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents txtautor1 As TextBox
    Friend WithEvents txtautor2 As TextBox
    Friend WithEvents txtemail2 As TextBox
    Friend WithEvents txtautor3 As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents email3 As TextBox
    Friend WithEvents txtemail1 As TextBox
End Class
