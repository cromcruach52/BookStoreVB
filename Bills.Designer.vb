<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bills
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bills))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AddToBillBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PriceTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QuantityTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClientTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BNameTb = New System.Windows.Forms.TextBox()
        Me.Totallbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.closeLbl = New System.Windows.Forms.Label()
        Me.billDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unamelbl = New System.Windows.Forms.Label()
        Me.bookDGV = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog3 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.billDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'AddToBillBtn
        '
        Me.AddToBillBtn.BackColor = System.Drawing.Color.RoyalBlue
        resources.ApplyResources(Me.AddToBillBtn, "AddToBillBtn")
        Me.AddToBillBtn.ForeColor = System.Drawing.Color.Transparent
        Me.AddToBillBtn.Name = "AddToBillBtn"
        Me.AddToBillBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.RoyalBlue
        resources.ApplyResources(Me.ResetBtn, "ResetBtn")
        Me.ResetBtn.ForeColor = System.Drawing.Color.Transparent
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Name = "Label6"
        '
        'PriceTb
        '
        resources.ApplyResources(Me.PriceTb, "PriceTb")
        Me.PriceTb.Name = "PriceTb"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'QuantityTb
        '
        resources.ApplyResources(Me.QuantityTb, "QuantityTb")
        Me.QuantityTb.Name = "QuantityTb"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'ClientTb
        '
        resources.ApplyResources(Me.ClientTb, "ClientTb")
        Me.ClientTb.Name = "ClientTb"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'BNameTb
        '
        resources.ApplyResources(Me.BNameTb, "BNameTb")
        Me.BNameTb.Name = "BNameTb"
        '
        'Totallbl
        '
        resources.ApplyResources(Me.Totallbl, "Totallbl")
        Me.Totallbl.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Totallbl.Name = "Totallbl"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Name = "Label9"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Name = "Label13"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Controls.Add(Me.Label13)
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Name = "Panel6"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label9)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Name = "Label1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.closeLbl)
        Me.Panel2.Controls.Add(Me.billDGV)
        Me.Panel2.Controls.Add(Me.Unamelbl)
        Me.Panel2.Controls.Add(Me.bookDGV)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.AddToBillBtn)
        Me.Panel2.Controls.Add(Me.ResetBtn)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PriceTb)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.QuantityTb)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ClientTb)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BNameTb)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Totallbl)
        Me.Panel2.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'closeLbl
        '
        resources.ApplyResources(Me.closeLbl, "closeLbl")
        Me.closeLbl.ForeColor = System.Drawing.Color.RoyalBlue
        Me.closeLbl.Name = "closeLbl"
        '
        'billDGV
        '
        Me.billDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.billDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.billDGV, "billDGV")
        Me.billDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.billDGV.EnableHeadersVisualStyles = False
        Me.billDGV.Name = "billDGV"
        Me.billDGV.RowHeadersVisible = False
        Me.billDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.billDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.billDGV.RowTemplate.Height = 24
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        resources.ApplyResources(Me.Column4, "Column4")
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        resources.ApplyResources(Me.Column5, "Column5")
        Me.Column5.Name = "Column5"
        '
        'Unamelbl
        '
        resources.ApplyResources(Me.Unamelbl, "Unamelbl")
        Me.Unamelbl.BackColor = System.Drawing.Color.Transparent
        Me.Unamelbl.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Unamelbl.Name = "Unamelbl"
        '
        'bookDGV
        '
        Me.bookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bookDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.bookDGV, "bookDGV")
        Me.bookDGV.EnableHeadersVisualStyles = False
        Me.bookDGV.Name = "bookDGV"
        Me.bookDGV.RowHeadersVisible = False
        Me.bookDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.bookDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.bookDGV.RowTemplate.Height = 24
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Name = "Label8"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Name = "Label10"
        '
        'PrintPreviewDialog1
        '
        resources.ApplyResources(Me.PrintPreviewDialog1, "PrintPreviewDialog1")
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        '
        'PrintPreviewDialog2
        '
        resources.ApplyResources(Me.PrintPreviewDialog2, "PrintPreviewDialog2")
        Me.PrintPreviewDialog2.Document = Me.PrintDocument3
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        '
        'PrintDocument3
        '
        '
        'PrintPreviewDialog3
        '
        resources.ApplyResources(Me.PrintPreviewDialog3, "PrintPreviewDialog3")
        Me.PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        '
        'Bills
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bills"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.billDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents AddToBillBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ClientTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents Totallbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents billDGV As DataGridView
    Friend WithEvents bookDGV As DataGridView
    Friend WithEvents closeLbl As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents Unamelbl As Label
    Friend WithEvents PrintPreviewDialog3 As PrintPreviewDialog
End Class
