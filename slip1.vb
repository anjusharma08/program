Public Class Form1
    Dim counter As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        counter = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        counter = counter + 1
        TextBox1.Text = counter

    End Sub
End Class


