Public Class Form1

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text.Trim().ToLower()
        Dim reversed As String = StrReverse(input)

        If input = reversed Then
            Label1.Text = "The entered string is a Palindrome."
        Else
            Label1.Text = "The entered string is NOT a Palindrome."
        End If
    End Sub
End Class
