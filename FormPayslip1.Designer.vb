<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPayslip1
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
        Me.lbl_employeename = New System.Windows.Forms.Label()
        Me.lbl_netpay = New System.Windows.Forms.Label()
        Me.lbl_taxdeduction = New System.Windows.Forms.Label()
        Me.lbl_grosspay = New System.Windows.Forms.Label()
        Me.lbl_overtime = New System.Windows.Forms.Label()
        Me.lbl_basicpay = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_employeenameout = New System.Windows.Forms.Label()
        Me.lbl_rate = New System.Windows.Forms.Label()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.lbl_overtimehours = New System.Windows.Forms.Label()
        Me.lbl_overtimerate = New System.Windows.Forms.Label()
        Me.lbl_overtimeamount = New System.Windows.Forms.Label()
        Me.lbl_basicpayamount = New System.Windows.Forms.Label()
        Me.lbl_grosspayamount = New System.Windows.Forms.Label()
        Me.lbl_taxdeductionamount = New System.Windows.Forms.Label()
        Me.lbl_netpayamount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_employeename
        '
        Me.lbl_employeename.AutoSize = True
        Me.lbl_employeename.Location = New System.Drawing.Point(378, 46)
        Me.lbl_employeename.Name = "lbl_employeename"
        Me.lbl_employeename.Size = New System.Drawing.Size(97, 15)
        Me.lbl_employeename.TabIndex = 0
        Me.lbl_employeename.Text = "Employee Name:"
        '
        'lbl_netpay
        '
        Me.lbl_netpay.AutoSize = True
        Me.lbl_netpay.Location = New System.Drawing.Point(196, 253)
        Me.lbl_netpay.Name = "lbl_netpay"
        Me.lbl_netpay.Size = New System.Drawing.Size(48, 15)
        Me.lbl_netpay.TabIndex = 1
        Me.lbl_netpay.Text = "Net Pay"
        '
        'lbl_taxdeduction
        '
        Me.lbl_taxdeduction.AutoSize = True
        Me.lbl_taxdeduction.Location = New System.Drawing.Point(196, 218)
        Me.lbl_taxdeduction.Name = "lbl_taxdeduction"
        Me.lbl_taxdeduction.Size = New System.Drawing.Size(84, 15)
        Me.lbl_taxdeduction.TabIndex = 2
        Me.lbl_taxdeduction.Text = "Tax deduction:"
        '
        'lbl_grosspay
        '
        Me.lbl_grosspay.AutoSize = True
        Me.lbl_grosspay.Location = New System.Drawing.Point(196, 186)
        Me.lbl_grosspay.Name = "lbl_grosspay"
        Me.lbl_grosspay.Size = New System.Drawing.Size(64, 15)
        Me.lbl_grosspay.TabIndex = 3
        Me.lbl_grosspay.Text = "Gross Pay: "
        '
        'lbl_overtime
        '
        Me.lbl_overtime.AutoSize = True
        Me.lbl_overtime.Location = New System.Drawing.Point(196, 148)
        Me.lbl_overtime.Name = "lbl_overtime"
        Me.lbl_overtime.Size = New System.Drawing.Size(59, 15)
        Me.lbl_overtime.TabIndex = 4
        Me.lbl_overtime.Text = "Overtime:"
        '
        'lbl_basicpay
        '
        Me.lbl_basicpay.AutoSize = True
        Me.lbl_basicpay.Location = New System.Drawing.Point(196, 113)
        Me.lbl_basicpay.Name = "lbl_basicpay"
        Me.lbl_basicpay.Size = New System.Drawing.Size(59, 15)
        Me.lbl_basicpay.TabIndex = 5
        Me.lbl_basicpay.Text = "Basic Pay:"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(297, 86)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(39, 15)
        Me.lbl_time.TabIndex = 6
        Me.lbl_time.Text = "Hours"
        '
        'lbl_employeenameout
        '
        Me.lbl_employeenameout.AutoSize = True
        Me.lbl_employeenameout.Location = New System.Drawing.Point(440, 46)
        Me.lbl_employeenameout.Name = "lbl_employeenameout"
        Me.lbl_employeenameout.Size = New System.Drawing.Size(0, 15)
        Me.lbl_employeenameout.TabIndex = 7
        '
        'lbl_rate
        '
        Me.lbl_rate.AutoSize = True
        Me.lbl_rate.Location = New System.Drawing.Point(419, 86)
        Me.lbl_rate.Name = "lbl_rate"
        Me.lbl_rate.Size = New System.Drawing.Size(47, 15)
        Me.lbl_rate.TabIndex = 8
        Me.lbl_rate.Text = "Rate (£)"
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Location = New System.Drawing.Point(543, 86)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(68, 15)
        Me.lbl_amount.TabIndex = 9
        Me.lbl_amount.Text = "Amount (£)"
        '
        'lbl_overtimehours
        '
        Me.lbl_overtimehours.AutoSize = True
        Me.lbl_overtimehours.Location = New System.Drawing.Point(297, 148)
        Me.lbl_overtimehours.Name = "lbl_overtimehours"
        Me.lbl_overtimehours.Size = New System.Drawing.Size(0, 15)
        Me.lbl_overtimehours.TabIndex = 10
        '
        'lbl_overtimerate
        '
        Me.lbl_overtimerate.AutoSize = True
        Me.lbl_overtimerate.Location = New System.Drawing.Point(419, 148)
        Me.lbl_overtimerate.Name = "lbl_overtimerate"
        Me.lbl_overtimerate.Size = New System.Drawing.Size(0, 15)
        Me.lbl_overtimerate.TabIndex = 11
        '
        'lbl_overtimeamount
        '
        Me.lbl_overtimeamount.AutoSize = True
        Me.lbl_overtimeamount.Location = New System.Drawing.Point(543, 148)
        Me.lbl_overtimeamount.Name = "lbl_overtimeamount"
        Me.lbl_overtimeamount.Size = New System.Drawing.Size(0, 15)
        Me.lbl_overtimeamount.TabIndex = 12
        '
        'lbl_basicpayamount
        '
        Me.lbl_basicpayamount.AutoSize = True
        Me.lbl_basicpayamount.Location = New System.Drawing.Point(543, 113)
        Me.lbl_basicpayamount.Name = "lbl_basicpayamount"
        Me.lbl_basicpayamount.Size = New System.Drawing.Size(0, 15)
        Me.lbl_basicpayamount.TabIndex = 13
        '
        'lbl_grosspayamount
        '
        Me.lbl_grosspayamount.AutoSize = True
        Me.lbl_grosspayamount.Location = New System.Drawing.Point(543, 186)
        Me.lbl_grosspayamount.Name = "lbl_grosspayamount"
        Me.lbl_grosspayamount.Size = New System.Drawing.Size(0, 15)
        Me.lbl_grosspayamount.TabIndex = 14
        '
        'lbl_taxdeductionamount
        '
        Me.lbl_taxdeductionamount.AutoSize = True
        Me.lbl_taxdeductionamount.Location = New System.Drawing.Point(543, 218)
        Me.lbl_taxdeductionamount.Name = "lbl_taxdeductionamount"
        Me.lbl_taxdeductionamount.Size = New System.Drawing.Size(0, 15)
        Me.lbl_taxdeductionamount.TabIndex = 15
        '
        'lbl_netpayamount
        '
        Me.lbl_netpayamount.AutoSize = True
        Me.lbl_netpayamount.Location = New System.Drawing.Point(543, 253)
        Me.lbl_netpayamount.Name = "lbl_netpayamount"
        Me.lbl_netpayamount.Size = New System.Drawing.Size(0, 15)
        Me.lbl_netpayamount.TabIndex = 16
        '
        'FormPayslip1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_netpayamount)
        Me.Controls.Add(Me.lbl_taxdeductionamount)
        Me.Controls.Add(Me.lbl_grosspayamount)
        Me.Controls.Add(Me.lbl_basicpayamount)
        Me.Controls.Add(Me.lbl_overtimeamount)
        Me.Controls.Add(Me.lbl_overtimerate)
        Me.Controls.Add(Me.lbl_overtimehours)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.lbl_rate)
        Me.Controls.Add(Me.lbl_employeenameout)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_basicpay)
        Me.Controls.Add(Me.lbl_overtime)
        Me.Controls.Add(Me.lbl_grosspay)
        Me.Controls.Add(Me.lbl_taxdeduction)
        Me.Controls.Add(Me.lbl_netpay)
        Me.Controls.Add(Me.lbl_employeename)
        Me.Name = "FormPayslip1"
        Me.Text = "FormPayslip1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_employeename As Label
    Friend WithEvents lbl_netpay As Label
    Friend WithEvents lbl_taxdeduction As Label
    Friend WithEvents lbl_grosspay As Label
    Friend WithEvents lbl_overtime As Label
    Friend WithEvents lbl_basicpay As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_employeenameout As Label
    Friend WithEvents lbl_rate As Label
    Friend WithEvents lbl_amount As Label
    Friend WithEvents lbl_overtimehours As Label
    Friend WithEvents lbl_overtimerate As Label
    Friend WithEvents lbl_overtimeamount As Label
    Friend WithEvents lbl_basicpayamount As Label
    Friend WithEvents lbl_grosspayamount As Label
    Friend WithEvents lbl_taxdeductionamount As Label
    Friend WithEvents lbl_netpayamount As Label
End Class
