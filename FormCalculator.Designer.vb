<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_fn = New System.Windows.Forms.Label()
        Me.lbl_ln = New System.Windows.Forms.Label()
        Me.lbl_basicpay = New System.Windows.Forms.Label()
        Me.txt_fn = New System.Windows.Forms.TextBox()
        Me.txt_ln = New System.Windows.Forms.TextBox()
        Me.lbl_othrs = New System.Windows.Forms.Label()
        Me.txt_basic_pay = New System.Windows.Forms.TextBox()
        Me.txt_ot_hrs = New System.Windows.Forms.TextBox()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.lbl_srlycalc = New System.Windows.Forms.Label()
        Me.lbl_instruct = New System.Windows.Forms.Label()
        Me.btn_payslip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_fn
        '
        Me.lbl_fn.AutoSize = True
        Me.lbl_fn.Location = New System.Drawing.Point(52, 134)
        Me.lbl_fn.Name = "lbl_fn"
        Me.lbl_fn.Size = New System.Drawing.Size(64, 15)
        Me.lbl_fn.TabIndex = 0
        Me.lbl_fn.Text = "First Name"
        '
        'lbl_ln
        '
        Me.lbl_ln.AutoSize = True
        Me.lbl_ln.Location = New System.Drawing.Point(52, 170)
        Me.lbl_ln.Name = "lbl_ln"
        Me.lbl_ln.Size = New System.Drawing.Size(63, 15)
        Me.lbl_ln.TabIndex = 1
        Me.lbl_ln.Text = "Last Name"
        '
        'lbl_basicpay
        '
        Me.lbl_basicpay.AutoSize = True
        Me.lbl_basicpay.Location = New System.Drawing.Point(52, 204)
        Me.lbl_basicpay.Name = "lbl_basicpay"
        Me.lbl_basicpay.Size = New System.Drawing.Size(56, 15)
        Me.lbl_basicpay.TabIndex = 2
        Me.lbl_basicpay.Text = "Basic Pay"
        '
        'txt_fn
        '
        Me.txt_fn.Location = New System.Drawing.Point(177, 131)
        Me.txt_fn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_fn.Name = "txt_fn"
        Me.txt_fn.Size = New System.Drawing.Size(110, 23)
        Me.txt_fn.TabIndex = 3
        '
        'txt_ln
        '
        Me.txt_ln.Location = New System.Drawing.Point(177, 168)
        Me.txt_ln.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ln.Name = "txt_ln"
        Me.txt_ln.Size = New System.Drawing.Size(110, 23)
        Me.txt_ln.TabIndex = 4
        '
        'lbl_othrs
        '
        Me.lbl_othrs.AutoSize = True
        Me.lbl_othrs.Location = New System.Drawing.Point(52, 239)
        Me.lbl_othrs.Name = "lbl_othrs"
        Me.lbl_othrs.Size = New System.Drawing.Size(91, 15)
        Me.lbl_othrs.TabIndex = 6
        Me.lbl_othrs.Text = "Overtime Hours"
        '
        'txt_basic_pay
        '
        Me.txt_basic_pay.Location = New System.Drawing.Point(177, 204)
        Me.txt_basic_pay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_basic_pay.Name = "txt_basic_pay"
        Me.txt_basic_pay.Size = New System.Drawing.Size(110, 23)
        Me.txt_basic_pay.TabIndex = 7
        '
        'txt_ot_hrs
        '
        Me.txt_ot_hrs.Location = New System.Drawing.Point(177, 237)
        Me.txt_ot_hrs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ot_hrs.Name = "txt_ot_hrs"
        Me.txt_ot_hrs.Size = New System.Drawing.Size(110, 23)
        Me.txt_ot_hrs.TabIndex = 8
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(96, 278)
        Me.btn_clr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(82, 22)
        Me.btn_clr.TabIndex = 9
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'lbl_srlycalc
        '
        Me.lbl_srlycalc.AutoSize = True
        Me.lbl_srlycalc.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_srlycalc.Location = New System.Drawing.Point(52, 20)
        Me.lbl_srlycalc.Name = "lbl_srlycalc"
        Me.lbl_srlycalc.Size = New System.Drawing.Size(126, 20)
        Me.lbl_srlycalc.TabIndex = 13
        Me.lbl_srlycalc.Text = "Salary Calculator"
        '
        'lbl_instruct
        '
        Me.lbl_instruct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_instruct.Location = New System.Drawing.Point(52, 69)
        Me.lbl_instruct.Name = "lbl_instruct"
        Me.lbl_instruct.Size = New System.Drawing.Size(318, 38)
        Me.lbl_instruct.TabIndex = 14
        Me.lbl_instruct.Text = "Please enter you First name, Last Name, Basic Pay and Overtime Hours to calculate" &
    " your monthly pay"
        '
        'btn_payslip
        '
        Me.btn_payslip.Location = New System.Drawing.Point(205, 278)
        Me.btn_payslip.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_payslip.Name = "btn_payslip"
        Me.btn_payslip.Size = New System.Drawing.Size(82, 22)
        Me.btn_payslip.TabIndex = 15
        Me.btn_payslip.Text = "Payslip"
        Me.btn_payslip.UseVisualStyleBackColor = True
        '
        'FormCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 338)
        Me.Controls.Add(Me.btn_payslip)
        Me.Controls.Add(Me.lbl_instruct)
        Me.Controls.Add(Me.lbl_srlycalc)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.txt_ot_hrs)
        Me.Controls.Add(Me.txt_basic_pay)
        Me.Controls.Add(Me.lbl_othrs)
        Me.Controls.Add(Me.txt_ln)
        Me.Controls.Add(Me.txt_fn)
        Me.Controls.Add(Me.lbl_basicpay)
        Me.Controls.Add(Me.lbl_ln)
        Me.Controls.Add(Me.lbl_fn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_fn As Label
    Friend WithEvents lbl_ln As Label
    Friend WithEvents lbl_basicpay As Label
    Friend WithEvents txt_fn As TextBox
    Friend WithEvents txt_ln As TextBox
    Friend WithEvents lbl_othrs As Label
    Friend WithEvents txt_basic_pay As TextBox
    Friend WithEvents txt_ot_hrs As TextBox
    Friend WithEvents btn_clr As Button
    Friend WithEvents btn_calculate As Button
    Friend WithEvents txt_ans As TextBox
    Friend WithEvents lbl_srlycalc As Label
    Friend WithEvents lbl_instruct As Label
    Friend WithEvents btn_payslip As Button
End Class
