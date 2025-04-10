Imports System.Data.OleDb

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dT As New DataTable
    Dim dA As New OleDbDataAdapter(cmd)


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
        Label1 = New Label()
        lblName = New Label()
        lblSemester = New Label()
        lblCellphone = New Label()
        txtId = New TextBox()
        txtName = New TextBox()
        txtSemester = New TextBox()
        txtCellphone = New TextBox()
        BtnSave = New Button()
        DataGridView1 = New DataGridView()
        btnShow = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(22, 20)
        Label1.TabIndex = 0
        Label1.Text = "Id"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(49, 133)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblSemester
        ' 
        lblSemester.AutoSize = True
        lblSemester.Location = New Point(49, 176)
        lblSemester.Name = "lblSemester"
        lblSemester.Size = New Size(70, 20)
        lblSemester.TabIndex = 2
        lblSemester.Text = "Semester"
        ' 
        ' lblCellphone
        ' 
        lblCellphone.AutoSize = True
        lblCellphone.Location = New Point(49, 218)
        lblCellphone.Name = "lblCellphone"
        lblCellphone.Size = New Size(76, 20)
        lblCellphone.TabIndex = 3
        lblCellphone.Text = "Cellphone"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(142, 88)
        txtId.Name = "txtId"
        txtId.Size = New Size(125, 27)
        txtId.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(142, 134)
        txtName.Name = "txtName"
        txtName.Size = New Size(203, 27)
        txtName.TabIndex = 5
        ' 
        ' txtSemester
        ' 
        txtSemester.Location = New Point(142, 177)
        txtSemester.Name = "txtSemester"
        txtSemester.Size = New Size(203, 27)
        txtSemester.TabIndex = 6
        ' 
        ' txtCellphone
        ' 
        txtCellphone.Location = New Point(142, 219)
        txtCellphone.Name = "txtCellphone"
        txtCellphone.Size = New Size(203, 27)
        txtCellphone.TabIndex = 7
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(251, 282)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(94, 29)
        BtnSave.TabIndex = 8
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(464, 88)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(645, 363)
        DataGridView1.TabIndex = 9
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(464, 44)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(94, 29)
        btnShow.TabIndex = 10
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 678)
        Controls.Add(btnShow)
        Controls.Add(DataGridView1)
        Controls.Add(BtnSave)
        Controls.Add(txtCellphone)
        Controls.Add(txtSemester)
        Controls.Add(txtName)
        Controls.Add(txtId)
        Controls.Add(lblCellphone)
        Controls.Add(lblSemester)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblCellphone As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSemester As TextBox
    Friend WithEvents txtCellphone As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnShow As Button
End Class
