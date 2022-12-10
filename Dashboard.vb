Imports System.Data.SqlClient
Public Class Dashboard
    Dim Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BookShopVb;Integrated Security=True")
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountBooks()
        CountUsers()
        SumAmount()
    End Sub

    Private Sub CountBooks()
        Dim BookNum As Integer
        Con.Open()
        Dim sql = "select Count(*) from BookTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        BookNum = cmd.ExecuteScalar
        Bookslbl.Text = BookNum
        Con.Close()
    End Sub
    Private Sub CountUsers()
        Dim UsersNum As Integer
        Con.Open()
        Dim sql = "select Count(*) from UserTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        UsersNum = cmd.ExecuteScalar
        Userslbl.Text = UsersNum
        Con.Close()
    End Sub

    Private Sub SumAmount()
        Dim Amount As Integer
        Con.Open()
        Dim sql = "select Sum(Amount) from BillTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Amount = cmd.ExecuteScalar
        Amountlbl.Text = "PHP " + Convert.ToString(Amount)
        Con.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New Users()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj = New Books()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
End Class