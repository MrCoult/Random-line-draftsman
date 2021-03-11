Public Class Form1
    Dim g As Graphics
    Dim rct As Rectangle
    Dim varSTART As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not varSTART Then
            g = TextBox1.CreateGraphics
            rct = New Rectangle(TextBox1.Location.X, TextBox1.Location.Y, TextBox1.Width, TextBox1.Height)
            Timer1.Start()
            varSTART = True
            Button1.Text = "STOP"
        Else
            Timer1.Stop()
            varSTART = False
            Button1.Text = "START"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim pn As New Pen(Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255, Rnd() * 255), 2)
        With g
            .DrawLine(pn, Rnd() * rct.Width, Rnd() * rct.Height, Rnd() * rct.Width, Rnd() * rct.Height)
            .Save()
        End With
    End Sub
End Class
