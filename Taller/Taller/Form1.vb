Public Class Form1
    Dim x As Integer = 0
    Dim y As Double = 0
    Dim n As Integer
    Public vec1() As Double
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
        Panel4.Visible = 0
        PictureBox1.Visible = 1
        PictureBox1.Image = Image.FromFile("imbalotorevancha.png")
        Timer1.Enabled = 0
    End Sub

    Private Sub JugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem.Click
        Panel3.Visible = False
        Panel2.Visible = True
        PictureBox1.Visible = 1
        Panel4.Visible = 0
        Panel2.BackgroundImage = Image.FromFile("baloto.png")
        PictureBox1.Image = Image.FromFile("imbaloto.png")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                        TextBox1.Text = TextBox1.Text & A(i, j) & "  "
                    Catch ex As Exception
                        response = MsgBox("Error al ingresar el valor", 1)
                        If (response = MsgBoxResult.Cancel) Then
                            TextBox2.Text = ""
                            Label11.Text = ""
                            GoTo ini1
                        End If
                        GoTo ini
                    End Try
                Next j
                TextBox1.Text = TextBox1.Text & vbCrLf
            Next i
            mostrarMatriz(matrizTranspuesta(A, n), n, TextBox2)
            If (esTranspuesta(A, matrizTranspuesta(A, n), n) = True) Then
                Label11.Text = "¡¡¡LA MATRIZ ES ANTISIMETRICA!!!"
            Else
                Label11.Text = "¡¡¡LA MATRIZ NO ES ANTISIMETRICA!!!"
            End If
ini1:
        Else
            MsgBox("Error. Ingrese el tamaño de la matriz")
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
                textbox.Text = textbox.Text & A(i, j) & "  "
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackgroundImage = Image.FromFile("hacker.jpeg")
    End Sub

    Private Function ordenarAscendente(vec() As Double, n As Integer) As Double()
        Dim ac As Integer
        For i = 1 To n
            For j = i + 1 To n
                If (vec(i) > vec(j)) Then
                    ac = vec(i)
                    vec(i) = vec(j)
                    vec(j) = ac
                End If
            Next j
        Next i
        Return vec
    End Function

    Private Function ordenarDescendente(vec() As Double, n As Integer) As Double()
        Dim ac As Integer
        For i = 1 To n
            For j = i + 1 To n
                If (vec(i) < vec(j)) Then
                    ac = vec(i)
                    vec(i) = vec(j)
                    vec(j) = ac
                End If
            Next j
        Next i
        Return vec
    End Function

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim response As MsgBoxResult
        n = TextBox6.Text
        ReDim vec1(0 To n)
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        If (n <> 0) Then
            For i = 1 To n
                Try
ini:
                    vec1(i) = InputBox("Por favor ingrese el dato " & i & ":", "Datos")
                    TextBox7.Text = TextBox7.Text & vec1(i) & vbCrLf
                Catch ex As Exception
                    response = MsgBox("Error al ingresar el valor", 1)
                    If (response = MsgBoxResult.Cancel) Then
                        TextBox5.Text = ""
                        TextBox4.Text = ""
                        TextBox7.Text = ""
                        GoTo ini1
                    End If
                    GoTo ini
                End Try
            Next i
ini1:
        Else
            MsgBox("Error. Ingrese el tamaño de la matriz")
        End If
    End Sub

    Public Sub mostrarVector(v() As Double, n As Integer, textbox As TextBox)
        For i = 1 To n
            textbox.Text = textbox.Text & v(i) & vbCrLf
        Next i
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        n = TextBox6.Text
        TextBox4.Text = ""
        mostrarVector(ordenarAscendente(vec1, n), n, TextBox4)
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click
        Panel2.Visible = False
        PictureBox1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        'Panel4.BackColor = Color.FromArgb(RGB(193, 230, 202))
    End Sub

    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        Panel2.Visible = False
        PictureBox1.Visible = False
        Panel4.Visible = 0
        Panel3.Visible = True
        Panel3.BackgroundImage = Image.FromFile("matriz.png")
        Panel3.Location = New Point(3, 3)
        Panel3.Size = New Size(967, 682)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        n = TextBox6.Text
        TextBox5.Text = ""
        mostrarVector(ordenarDescendente(vec1, n), n, TextBox5)
    End Sub
End Class
