Public Class FormPayslip1
    Public Property basicpayamount As Decimal
    Public Property overtimehours As Decimal
    Public Property overtimerate As Decimal
    Public Property overtimeamount As Decimal
    Public Property grosspay As Decimal
    Public Property taxdeduction As Decimal
    Public Property netpay As Decimal
    Public Property employeename As String



    Private Sub FormPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_basicpayamount.Text = basicpayamount.ToString("###,###")
        lbl_overtimehours.Text = overtimehours.ToString("###,###")
        lbl_overtimerate.Text = overtimerate.ToString("###,###")
        lbl_overtimeamount.Text = overtimeamount.ToString("###,###")
        lbl_grosspayamount.Text = grosspay.ToString("###,###")
        lbl_taxdeductionamount.Text = taxdeduction.ToString("###,###")
        lbl_netpayamount.Text = netpay.ToString("###,###")
        lbl_employeenameout.Text = employeename
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class