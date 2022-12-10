Imports System.Data.SqlClient

Public Class Bills
    Dim Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BookShopVb;Integrated Security=True")
    Public Shared UserName As String = Nothing
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

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Unamelbl.Text = UserName
        Populate()
    End Sub

    Dim Key = 0, i = 0, GrdTotal = 0, Stock = 0

    Private Sub Update()
        Dim NewQty = Stock - Convert.ToInt32(QuantityTb.Text)
        Con.Open()

        Dim query As String
        query = "Update BookTable set Quantity = " & NewQty & " where Bld = " & Key & ""

        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Book Updated Successfully")

        Con.Close()
        Populate()
    End Sub


    Private Sub AddToBillBtn_Click(sender As Object, e As EventArgs) Handles AddToBillBtn.Click
        If QuantityTb.Text = "" Then
            MsgBox("Enter The Quantity")
        ElseIf BNameTb.Text = "" Then
            MsgBox("Select The Book")
        ElseIf Convert.ToInt32(QuantityTb.Text) > Stock Then
            MsgBox("Not Enough Stock")

        Else
            Dim rnum As Integer = billDGV.Rows.Add()
            i = i + 1

            Dim Total = Convert.ToInt32(Val(QuantityTb.Text)) * Convert.ToInt32(Val(PriceTb.Text))

            billDGV.Rows.Item(rnum).Cells("Column1").Value = i
            billDGV.Rows.Item(rnum).Cells("Column2").Value = BNameTb.Text
            billDGV.Rows.Item(rnum).Cells("Column3").Value = PriceTb.Text
            billDGV.Rows.Item(rnum).Cells("Column4").Value = QuantityTb.Text

            billDGV.Rows.Item(rnum).Cells("Column5").Value = Total
            GrdTotal = GrdTotal + Total
            Dim Tot As String
            Tot = "PHP " + Convert.ToString(GrdTotal)
            Totallbl.Text = Tot
            Update()
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        e.Graphics.DrawString("Bookshop", New Font("Century Gothic", 25), Brushes.MidnightBlue, 350, 40)
        e.Graphics.DrawString("========Your Bill=========", New Font("Century Gothic", 16), Brushes.MidnightBlue, 350, 40)
        Dim bm As New Bitmap(Me.billDGV.Width, billDGV.Height)
        billDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.billDGV.Width, Me.billDGV.Height))
        e.Graphics.DrawImage(bm, 60, 120)
        e.Graphics.DrawString("Total Amount Php " + GrdTotal.ToString, New Font("Century Gothic", 15), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("========Thanks For Buying In Our Shop===========" + GrdTotal.ToString, New Font("Century Gothic", 15), Brushes.Crimson, 150, 580)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddBill()
        PrintPreviewDialog2.Show()

    End Sub

    Private Sub AddBill()
        Try
            Con.Open()

            Dim query As String

            query = "insert into BillTable values( '" & Unamelbl.Text & "' ,  '" & ClientTb.Text & "' ," & GrdTotal & ")"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill Saved Successfully")

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub bookDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookDGV.CellContentClick
        Dim row As DataGridViewRow = bookDGV.Rows(e.RowIndex)
        BNameTb.Text = row.Cells(1).Value.ToString
        PriceTb.Text = row.Cells(5).Value.ToString
        Stock = Convert.ToInt32(row.Cells(4).Value.ToString)


        If BNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub closeLbl_Click(sender As Object, e As EventArgs) Handles closeLbl.Click
        Application.Exit()
    End Sub

    Private Sub Reset()
        Key = 0
        QuantityTb.Text = ""
        PriceTb.Text = ""
        ClientTb.Text = ""
        BNameTb.Text = ""
    End Sub

End Class