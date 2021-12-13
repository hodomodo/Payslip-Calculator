Public Class Login_Form


    Public Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "admin" And txt_password.Text = "admin" Then
            Dim calculator As New FormCalculator
            calculator.Show()
            Me.Hide()
        Else
            lbl_loginincorrect.Text = ("Username or Password is Incorrect")

        End If

    End Sub
    Public Sub btn_login_enter(sender As Object, e As EventArgs) Handles btn_login.Enter
        Me.AcceptButton = btn_login

    End Sub

    Private Sub lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

End Class