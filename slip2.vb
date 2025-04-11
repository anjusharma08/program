Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If lbl.Left > 600 Then
            lbl.Left = 10
        End If
        lbl.Left = lbl.Left + 10


    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
    
        If lbl2.Left < 10 Then
            lbl2.Left = 600
        End If
        lbl2.Left = lbl2.Left - 10

    End Sub
End Class
