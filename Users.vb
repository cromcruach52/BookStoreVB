Imports System.Data.SqlClient


Public Class Users
    Dim Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BookShopVb;Integrated Security=True")


    Private Sub Populate()
        Con.Open()
        Dim query = "select * from UserTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet

        ds = New DataSet
        adapter.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)

        Con.Close()
    End Sub
    Private Sub Reset()
        unameTxt.Text = ""
        phoneTxt.Text = ""
        addressTxt.Text = ""
        passwordTxt.Text = ""

        Key = 0

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If unameTxt.Text = "" Or phoneTxt.Text = "" Or addressTxt.Text = "" Or passwordTxt.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query As String
            query = "insert into UserTable values('" & unameTxt.Text & "',  '" & phoneTxt.Text & "' ,'" & addressTxt.Text & "', '" & passwordTxt.Text & "')"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Saved Successfully")

            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub


    Dim Key = 0



    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If Key = 0 Then
            MsgBox("Select the user to be deleted")



        Else
            Con.Open()

            Dim query As String
            query = "Delete from UserTable where id= " & Key & ""

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Successfully")

            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        unameTxt.Text = row.Cells(1).Value.ToString
        phoneTxt.Text = row.Cells(2).Value.ToString
        addressTxt.Text = row.Cells(3).Value.ToString
        passwordTxt.Text = row.Cells(4).Value.ToString

        If unameTxt.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Reset()
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If unameTxt.Text = "" Or phoneTxt.Text = "" Or addressTxt.Text = "" Or passwordTxt.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query As String
            query = "Update UserTable set Name = '" & unameTxt.Text & "',  Phone = '" & phoneTxt.Text & "',Address = '" & addressTxt.Text & "',Password = '" & passwordTxt.Text & "' where ID = '" & Key & "'"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Updated Successfully")

            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub closeLbl_Click(sender As Object, e As EventArgs) Handles closeLbl.Click
        Application.Exit()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj = New Books()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub
End Class