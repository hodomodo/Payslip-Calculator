Public Class FormCalculator

    Friend Function lbl_basicpayamount() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub lbl_pay_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_srlycalc.Click

    End Sub

    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        txt_fn.Clear()
        txt_ln.Clear()
        txt_ot_hrs.Clear()
        txt_basic_pay.Clear()


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_payslip_Click(sender As Object, e As EventArgs)
        Dim frmps As New FormPayslip1
        Me.Hide()
        frmps.Show()

        Me.Close()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub btn_payslip_Click_1(sender As Object, e As EventArgs) Handles btn_payslip.Click
        Dim frmps As New FormPayslip1

        Const band_1 As Decimal = 20.0
        Const band_2 As Decimal = 30.0
        Const band_3 As Decimal = 35.0
        Const tax_deduction As Decimal = 0.8

        Dim first_name As String = Val(txt_fn.Text)
        Dim last_name As String = Val(txt_ln.Text)
        Dim basic_pay As Decimal = Val(txt_basic_pay.Text)
        Dim ot_hours As Decimal = Val(txt_ot_hrs.Text)

        Dim tax_deduction_calc = basic_pay * tax_deduction

        Dim band_1_calc As Decimal = basic_pay + (ot_hours * band_1)
        Dim band_2_calc As Decimal = tax_deduction_calc + (ot_hours * band_2)
        Dim band_3_calc As Decimal = tax_deduction_calc + (ot_hours * band_3)


        If (basic_pay >= 1) AndAlso (1000 > basic_pay) Then
            frmps.overtimerate = "£20"
            frmps.netpay = band_1_calc
            frmps.grosspay = basic_pay + (ot_hours * band_1)

        ElseIf (basic_pay >= 1001) AndAlso (3000 >= basic_pay) Then
            frmps.overtimerate = "£30"
            frmps.netpay = band_2_calc
            frmps.grosspay = basic_pay + (ot_hours * band_2)

        ElseIf (basic_pay >= 3001) Then
            frmps.overtimerate = "£35"
            frmps.netpay = band_2_calc
            frmps.grosspay = basic_pay + (ot_hours * band_3)

        Else txt_ans.Text = "error"
        End If

        frmps.basicpayamount = txt_basic_pay.Text
        frmps.overtimehours = txt_ot_hrs.Text
        frmps.taxdeduction = basic_pay * 0.2
        frmps.employeename = txt_fn.Text + " " + txt_ln.Text

        Me.Hide()
        frmps.Show()
        Me.Close()
    End Sub

    Private Sub txt_basic_pay_TextChanged(sender As Object, e As EventArgs) Handles txt_basic_pay.TextChanged

    End Sub
End Class
