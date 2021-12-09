<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_loginincorrect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(281, 180)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(86, 27)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(140, 90)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(227, 23)
        Me.txt_username.TabIndex = 1
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(44, 92)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(60, 15)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "Username"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(48, 138)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(57, 15)
        Me.lbl_password.TabIndex = 3
        Me.lbl_password.Text = "Password"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(140, 136)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(227, 23)
        Me.txt_password.TabIndex = 4
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(229, 29)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(37, 15)
        Me.lbl_login.TabIndex = 5
        Me.lbl_login.Text = "Login"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(140, 180)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(86, 27)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lbl_loginincorrect
        '
        Me.lbl_loginincorrect.AutoSize = True
        Me.lbl_loginincorrect.Location = New System.Drawing.Point(143, 62)
        Me.lbl_loginincorrect.Name = "lbl_loginincorrect"
        Me.lbl_loginincorrect.Size = New System.Drawing.Size(0, 15)
        Me.lbl_loginincorrect.TabIndex = 7
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 245)
        Me.Controls.Add(Me.lbl_loginincorrect)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.btn_login)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Login_Form"
        Me.Text = "Login_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_login As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lbl_loginincorrect As Label
End Class
