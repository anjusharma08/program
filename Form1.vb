Imports System.Data.OleDb

Public Class Form1
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TY Slips Solutions\Slip 30 Q 2\Supplier.accdb;"
    Dim conn As New OleDbConnection(connString)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO Supplier (ID, Name, Phone, Address) VALUES (?, ?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text)
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text)
            cmd.Parameters.AddWithValue("@p3", TextBox3.Text)
            cmd.Parameters.AddWithValue("@p4", TextBox4.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Supplier details saved successfully!")
            ' Clear text fields after successful insert
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

        Catch ex As OleDbException When ex.Message.Contains("duplicate")
            MessageBox.Show("Error: SupID must be unique. Please enter a different ID.", "Duplicate Entry")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
            LoadData() ' Refresh DataGridView
        End Try
    End Sub

    Private Sub LoadData()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM Supplier"
            Dim adapter As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class