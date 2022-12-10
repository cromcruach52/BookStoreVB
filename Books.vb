Imports System.Data.SqlClient

Public Class Books
    Dim Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BookShopVb;Integrated Security=True")

    Private Sub Populate()
        Con.Open()
        Dim query = "select * from BookTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet

        ds = New DataSet
        adapter.Fill(ds)

        bookDGV.DataSource = ds.Tables(0)

        Con.Close()
    End Sub

    Private Sub Filter()
        Con.Open()
        Dim query = "select * from BookTable where Category = '" & FilterCb.SelectedItem.ToString() & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet

        ds = New DataSet
        adapter.Fill(ds)

        bookDGV.DataSource = ds.Tables(0)

        Con.Close()
    End Sub


    Private Sub Reset()
        booknameTxt.Text = ""
        authorTxt.Text = ""
        quantityTxt.Text = ""
        priceTxt.Text = ""
        categoriesCB.SelectedIndex = -1
        Key = 0
    End Sub

    Private Sub bookDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles bookDGV.CellMouseClick
        Dim row As DataGridViewRow = bookDGV.Rows(e.RowIndex)
        booknameTxt.Text = row.Cells(1).Value.ToString
        authorTxt.Text = row.Cells(2).Value.ToString
        categoriesCB.SelectedItem = row.Cells(3).Value.ToString
        quantityTxt.Text = row.Cells(4).Value.ToString
        priceTxt.Text = row.Cells(5).Value.ToString

        If booknameTxt.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub



    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If booknameTxt.Text = "" Or authorTxt.Text = "" Or quantityTxt.Text = "" Or priceTxt.Text = "" Or categoriesCB.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query As String
            query = "insert into BookTable values('" & booknameTxt.Text & "',  '" & authorTxt.Text & "' ,'" & categoriesCB.SelectedItem.ToString & "','" & quantityTxt.Text & "', '" & priceTxt.Text & "')"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved Successfully")

            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Dim Key = 0


    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Reset()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If Key = 0 Then
            MsgBox("Select the Book to be deleted")



        Else
            Con.Open()

            Dim query As String
            query = "Delete from BookTable where Bld= " & Key & ""

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Removed Successfully")

            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub closeLbl_Click(sender As Object, e As EventArgs) Handles closeLbl.Click
        Application.Exit()
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If booknameTxt.Text = "" Or authorTxt.Text = "" Or quantityTxt.Text = "" Or priceTxt.Text = "" Or categoriesCB.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query As String
            query = "Update BookTable set Title = '" & booknameTxt.Text & "',  Author = '" & authorTxt.Text & "',Category = '" & categoriesCB.SelectedItem.ToString & "', Quantity = '" & quantityTxt.Text & "', Price = '" & priceTxt.Text & "' where Bld = '" & Key & "'"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Updated Successfully")

            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FilterCb.SelectionChangeCommitted
        Filter()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        Populate()
    End Sub


    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New Users()
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