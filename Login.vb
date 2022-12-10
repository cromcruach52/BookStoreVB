Imports System.Data.SqlClient

Public Class Login
    Dim Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BookShopVb;Integrated Security=True")

    Dim cmd As SqlCommand


    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter Username and Password")
        Else
            Con.Open()

            Dim query = "select * from UserTable where name = '" & UnameTb.Text & "' And password = '" & PasswordTb.Text & "' "
            cmd = New SqlCommand(query, Con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username or Password")

            Else
                Dim Bill = New Bills
                Bill.UserName = UnameTb.Text
                Bills.Show()
                Me.Hide()
            End If


            Con.Close()
        End If
    End Sub

    Private Sub closeLbl_Click(sender As Object, e As EventArgs) Handles closeLbl.Click
        Application.Exit()
    End Sub


    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click
        Dim Obj = New AdminLogin()
        Obj.Show()
        Me.Hide()
    End Sub

End Class