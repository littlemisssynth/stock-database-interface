Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDatabaseDataSet.StockTable' table. You can move, or remove it, as needed.
        Me.StockTableTableAdapter.Fill(Me.StockDatabaseDataSet.StockTable)
        UpdateCaption()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        StockTableBindingSource.MovePrevious()
        UpdateCaption()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        StockTableBindingSource.MoveNext()
        UpdateCaption()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        StockTableBindingSource.MoveFirst()
        UpdateCaption()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        StockTableBindingSource.MoveLast()
        UpdateCaption()
    End Sub
    Private Sub UpdateCaption()
        Dim currentRecord As Integer
        Dim totalRecords As Integer
        totalRecords = Me.StockDatabaseDataSet.Tables("StockTable").Rows.Count
        currentRecord = Me.StockTableBindingSource.Position + 1
        lblRecordNumber.Text = currentRecord & "/" & totalRecords
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.StockTableTableAdapter.Update(Me.StockDatabaseDataSet.StockTable)
        MsgBox("Record Updated.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure that you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Delete Canceled")
            Exit Sub
        End If
        MsgBox("deleting Record")
        Me.StockDatabaseDataSet.Tables("StockTable").Rows(StockTableBindingSource.Position).Delete()
        Me.StockTableTableAdapter.Update(Me.StockDatabaseDataSet.StockTable)
        UpdateCaption()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim row As StockDatabaseDataSet.StockTableRow
        Dim prompt, Reference, Description, Price, Quantity, Discontinued As String
        row = Me.StockDatabaseDataSet.StockTable.NewStockTableRow
        prompt = ("please enter the item Reference.")
        Reference = InputBox(prompt)

        prompt = ("please enter the item Description.")
        Description = InputBox(prompt)

        prompt = ("please enter the item Price.")
        If IsNumeric(InputBox(prompt).text) = True Then
            Price = InputBox(prompt)
        Else
            prompt = ("please enter the item Quantity.")
            Quantity = InputBox(prompt)
        End If

        prompt = ("please enter if the item is Discontinued.")
        Discontinued = InputBox(prompt)

        MsgBox("Adding Record To Database")
        row.Ref = Reference
        row.Description = Description
        row.Price = Price
        row.Quantity = Quantity
        row.Discontinued = Discontinued

        Me.StockDatabaseDataSet.StockTable.Rows.Add(row)
        Me.StockTableTableAdapter.Update(Me.StockDatabaseDataSet.StockTable)
        Me.StockDatabaseDataSet.Clear()
        Me.StockTableTableAdapter.Fill(Me.StockDatabaseDataSet.StockTable)
        UpdateCaption()
    End Sub
End Class
