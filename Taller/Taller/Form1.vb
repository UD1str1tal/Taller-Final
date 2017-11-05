Public Class Form1
    Dim x As Integer = 0
    Dim y As Double = 0

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer2.Enabled = 1
        x = 0
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (x = 2) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
        Else
            x += 1
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Timer2.Enabled = True) Then
            Randomize()
            Label1.Text = CInt((42 * Rnd()) + 1)
            Label2.Text = CInt((42 * Rnd()) + 1)
            Label3.Text = CInt((42 * Rnd()) + 1)
            Label4.Text = CInt((42 * Rnd()) + 1)
            Label5.Text = CInt((42 * Rnd()) + 1)
            Label6.Text = CInt((15 * Rnd()) + 1)
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub RevanchaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RevanchaToolStripMenuItem1.Click
        Label7.Visible = True
        Label8.Visible = True
        Panel3.Visible = True
        Panel2.Visible = True

    End Sub

    Private Sub RevanchaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevanchaToolStripMenuItem.Click
        Panel3.Visible = True
        Panel2.Visible = True
        PictureBox1.ImageLocation = 
    End Sub
End Class
