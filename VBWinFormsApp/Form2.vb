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
End Class