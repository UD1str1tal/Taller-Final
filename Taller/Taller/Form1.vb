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

    Private Sub RevanchaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RevanchaToolStripMenuItem1.Click
        Label8.Visible = True
        Panel3.Visible = False
        Panel2.Visible = True
        PictureBox1.Visible = 1
        PictureBox1.Image = Image.FromFile("imbalotorevancha.png")
        Timer1.Enabled = 0
    End Sub

    Private Sub JugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem.Click
        Panel3.Visible = False
        Panel2.Visible = True
        PictureBox1.Visible = 1
        Panel2.BackgroundImage = Image.FromFile("baloto.png")
        PictureBox1.Image = Image.FromFile("imbaloto.png")
    End Sub

    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        Panel2.Visible = False
        PictureBox1.Visible = False
        Panel3.Visible = True
        Panel3.BackgroundImage = Image.FromFile("matriz.png")
        Panel3.Location = New Point(3, 3)
        Panel3.Size = New Size(967, 682)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Integer
        n = TextBox3.Text
        Dim A(n, n) As Double
        Dim response As MsgBoxResult
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label11.Text = ""
        If (n <> 0) Then
            For i = 1 To n
                For j = 1 To n
                    Try
ini:
                        A(i, j) = InputBox("Por favor ingrese los datos de la matriz A(" & i & ", " & j & ")", "Datos")
                        TextBox1.Text = TextBox1.Text & A(i, j) & "     "
                    Catch ex As Exception
                        response = MsgBox("Error al ingresar el valor", 1)
                        If (response = MsgBoxResult.Cancel) Then
                            GoTo ini1
                        End If
                        GoTo ini
                    End Try
                Next j
                TextBox1.Text = TextBox1.Text & vbCrLf
            Next i
ini1:
        Else
            MsgBox("Error. Ingrese el tamaño de la matriz")
        End If
        mostrarMatriz(matrizTranspuesta(A, n), n, TextBox2)
        If (esTranspuesta(A, matrizTranspuesta(A, n), n) = True) Then
            Label11.Text = "¡¡¡LA MATRIZ ES ANTISIMETRICA!!!"
        Else
            Label11.Text = "¡¡¡LA MATRIZ NO ES ANTISIMETRICA!!!"
        End If
    End Sub

    Private Function matrizTranspuesta(A(,) As Double, n As Integer) As Double(,)
        Dim b(n, n) As Double
        For i = 1 To n
            For j = 1 To n
                b(i, j) = A(j, i)
            Next j
        Next i
        Return b
    End Function

    Private Sub mostrarMatriz(A(,) As Double, n As Integer, textbox As TextBox)
        For i = 1 To n
            For j = 1 To n
                textbox.Text = textbox.Text & A(i, j) & "     "
            Next j
            textbox.Text = textbox.Text & vbCrLf
        Next i
    End Sub

    Private Function esTranspuesta(A(,) As Double, b(,) As Double, n As Integer) As Boolean
        Dim anti As Boolean
        For i = 1 To n
            For j = 1 To n
                If (b(i, j) = (-1) * A(i, j)) Then
                    anti = True
                Else
                    anti = False
                End If
            Next j
        Next i
        Return anti
    End Function

End Class
