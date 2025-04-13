Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User01\Desktop\Personal\Courses\VBWindowsFormApp\VBWinFormsApp\VBWinFormsApp\bin\Debug\net8.0-windows\db\DatabaseVB.accdb"


    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Students (sID, sName, Semester, Cell) Values ('" + txtId.Text + "','" + txtName.Text + "','" + txtSemester.Text + "','" + txtCellphone.Text + "')"
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Record stored successfully!")



    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        dA = New OleDbDataAdapter("select * from Students", conn)
        dT.Clear()
        dA.Fill(dT)
        DataGridView1.DataSource = dT
        conn.Close()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim q As String
        q = "Select * from Students Where 1=1 "

        If String.IsNullOrWhiteSpace(txtName.Text) = False Then
            q = q + " AND sName LIKE '%" + txtName.Text + "%'"
        End If
        If String.IsNullOrWhiteSpace(txtSemester.Text) = False Then
            q = q + " AND Semester LIKE '%" + txtSemester.Text + "%'"
        End If
        If String.IsNullOrWhiteSpace(txtCellphone.Text) = False Then
            q = q + " AND Cell LIKE '%" + txtCellphone.Text + "%'"
        End If

        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        dA = New OleDbDataAdapter(q, conn)
        dT.Clear()
        dA.Fill(dT)
        DataGridView1.DataSource = dT
        conn.Close()
    End Sub
End Class