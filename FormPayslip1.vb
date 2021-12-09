Public Class FormPayslip1
    Public Property basicpayamount As String
    Public Property overtimehours As String
    Public Property overtimerate As String
    Public Property overtimeamount As String
    Public Property grosspay As String
    Public Property taxdeduction As String
    Public Property netpay As String
    Public Property employeename As String



    Private Sub FormPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_basicpayamount.Text = basicpayamount
        lbl_overtimehours.Text = overtimehours
        lbl_overtimerate.Text = overtimerate
        lbl_overtimeamount.Text = overtimeamount
        lbl_grosspayamount.Text = grosspay
        lbl_taxdeductionamount.Text = taxdeduction
        lbl_netpayamount.Text = netpay
        lbl_employeenameout.Text = employeename
    End Sub
End Class