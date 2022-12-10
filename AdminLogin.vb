

Public Class AdminLogin
    Private Sub closeLbl_Click(sender As Object, e As EventArgs) Handles closeLbl.Click
        Application.Exit()
    End Sub

    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If PasswordTb.Text = "Password" Then
            Dim Obj = New Dashboard()
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Password")
        End If
    End Sub
End Class