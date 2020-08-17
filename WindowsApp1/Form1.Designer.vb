<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.lblRecordNumber = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblDiscontinued = New System.Windows.Forms.Label()
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.StockTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDatabaseDataSet = New WindowsApp1.StockDatabaseDataSet()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtDiscontinued = New System.Windows.Forms.TextBox()
        Me.StockTableTableAdapter = New WindowsApp1.StockDatabaseDataSetTableAdapters.StockTableTableAdapter()
        Me.grpRecordControlls = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.grpSelect.SuspendLayout()
        CType(Me.StockTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecordControlls.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Location = New System.Drawing.Point(75, 13)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(45, 13)
        Me.lblRecord.TabIndex = 0
        Me.lblRecord.Text = "Record:"
        '
        'lblRecordNumber
        '
        Me.lblRecordNumber.AutoSize = True
        Me.lblRecordNumber.Location = New System.Drawing.Point(118, 13)
        Me.lblRecordNumber.Name = "lblRecordNumber"
        Me.lblRecordNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblRecordNumber.TabIndex = 1
        Me.lblRecordNumber.Text = "Label2"
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(56, 40)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(60, 13)
        Me.lblReference.TabIndex = 2
        Me.lblReference.Text = "Reference:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(53, 64)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(81, 94)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(66, 118)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblDiscontinued
        '
        Me.lblDiscontinued.AutoSize = True
        Me.lblDiscontinued.Location = New System.Drawing.Point(43, 141)
        Me.lblDiscontinued.Name = "lblDiscontinued"
        Me.lblDiscontinued.Size = New System.Drawing.Size(72, 13)
        Me.lblDiscontinued.TabIndex = 6
        Me.lblDiscontinued.Text = "Discontinued:"
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.btnLast)
        Me.grpSelect.Controls.Add(Me.btnFirst)
        Me.grpSelect.Controls.Add(Me.btnNext)
        Me.grpSelect.Controls.Add(Me.btnPrevious)
        Me.grpSelect.Location = New System.Drawing.Point(34, 160)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(200, 89)
        Me.grpSelect.TabIndex = 7
        Me.grpSelect.TabStop = False
        Me.grpSelect.Text = "Select Record"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(119, 60)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 3
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(6, 60)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 2
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(119, 20)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(7, 20)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'txtReference
        '
        Me.txtReference.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockTableBindingSource, "Ref", True))
        Me.txtReference.Location = New System.Drawing.Point(121, 37)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(113, 20)
        Me.txtReference.TabIndex = 8
        '
        'StockTableBindingSource
        '
        Me.StockTableBindingSource.DataMember = "StockTable"
        Me.StockTableBindingSource.DataSource = Me.StockDatabaseDataSet
        '
        'StockDatabaseDataSet
        '
        Me.StockDatabaseDataSet.DataSetName = "StockDatabaseDataSet"
        Me.StockDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockTableBindingSource, "Description", True))
        Me.txtDescription.Location = New System.Drawing.Point(121, 64)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(113, 20)
        Me.txtDescription.TabIndex = 9
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockTableBindingSource, "Price", True))
        Me.txtPrice.Location = New System.Drawing.Point(121, 91)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(113, 20)
        Me.txtPrice.TabIndex = 10
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockTableBindingSource, "Quantity", True))
        Me.txtQuantity.Location = New System.Drawing.Point(121, 115)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(113, 20)
        Me.txtQuantity.TabIndex = 11
        '
        'txtDiscontinued
        '
        Me.txtDiscontinued.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockTableBindingSource, "Discontinued", True))
        Me.txtDiscontinued.Location = New System.Drawing.Point(121, 138)
        Me.txtDiscontinued.Name = "txtDiscontinued"
        Me.txtDiscontinued.Size = New System.Drawing.Size(113, 20)
        Me.txtDiscontinued.TabIndex = 12
        '
        'StockTableTableAdapter
        '
        Me.StockTableTableAdapter.ClearBeforeFill = True
        '
        'grpRecordControlls
        '
        Me.grpRecordControlls.Controls.Add(Me.btnNew)
        Me.grpRecordControlls.Controls.Add(Me.btnDelete)
        Me.grpRecordControlls.Controls.Add(Me.btnUpdate)
        Me.grpRecordControlls.Location = New System.Drawing.Point(254, 31)
        Me.grpRecordControlls.Name = "grpRecordControlls"
        Me.grpRecordControlls.Size = New System.Drawing.Size(101, 218)
        Me.grpRecordControlls.TabIndex = 13
        Me.grpRecordControlls.TabStop = False
        Me.grpRecordControlls.Text = "record Controls"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(6, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(6, 48)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(6, 77)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(89, 23)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New Record"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 261)
        Me.Controls.Add(Me.grpRecordControlls)
        Me.Controls.Add(Me.txtDiscontinued)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.grpSelect)
        Me.Controls.Add(Me.lblDiscontinued)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.lblRecordNumber)
        Me.Controls.Add(Me.lblRecord)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Symbius research Stock Database Interface"
        Me.grpSelect.ResumeLayout(False)
        CType(Me.StockTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecordControlls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRecord As Label
    Friend WithEvents lblRecordNumber As Label
    Friend WithEvents lblReference As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblDiscontinued As Label
    Friend WithEvents grpSelect As GroupBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtDiscontinued As TextBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents StockDatabaseDataSet As StockDatabaseDataSet
    Friend WithEvents StockTableBindingSource As BindingSource
    Friend WithEvents StockTableTableAdapter As StockDatabaseDataSetTableAdapters.StockTableTableAdapter
    Friend WithEvents grpRecordControlls As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
End Class
