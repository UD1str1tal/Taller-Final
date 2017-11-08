Public Class Form1
    Dim x As Integer = 0
    Dim y As Double = 0
    Public n, dado, dado1 As Integer
    Public vec1() As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackgroundImage = Image.FromFile("hacker.jpeg")
        Button5.Enabled = False
    End Sub

    'DADOS ------------------------------------------------------------------------------------------------------------
    Private Sub DadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadosToolStripMenuItem.Click
        Panel3.Visible = False
        Panel2.Visible = 0
        Panel4.Visible = 0
        PictureBox1.Visible = 0
        Panel6.Visible = 1
        Panel6.Location = New Point(182, 190)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer3.Enabled = True
        Timer4.Enabled = 1
        y = 0
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If (Timer4.Enabled = True) Then
            Randomize()
            dado = CInt((5 * Rnd()) + 1)
            dado1 = CInt((5 * Rnd()) + 1)
            mostrarDado(dado, PictureBox2)
            mostrarDado(dado1, PictureBox3)
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If (y = 1) Then
            Timer3.Enabled = False
            Timer4.Enabled = False
        Else
            y += 1
        End If
    End Sub

    Public Sub mostrarDado(numDado As Integer, picture As PictureBox)
        Select Case numDado
            Case 1
                picture.Image = Image.FromFile("d1.png")
            Case 2
                picture.Image = Image.FromFile("d2.png")
            Case 3
                picture.Image = Image.FromFile("d3.png")
            Case 4
                picture.Image = Image.FromFile("d4.png")
            Case 5
                picture.Image = Image.FromFile("d5.png")
            Case 6
                picture.Image = Image.FromFile("d6.png")
        End Select
    End Sub

    'BALOTO ------------------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Image.FromFile("imbaloto.png")
        Button5.Enabled = True
        Label8.Visible = False
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1.Enabled = True
        Button5.Enabled = False
        Label8.Visible = True
        PictureBox1.Image = Image.FromFile("imbalotorevancha.png")
        Timer1.Enabled = 1
        Timer2.Enabled = 1
        x = 0
    End Sub

    Private Sub JugarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem1.Click
        Panel3.Visible = False
        Panel2.Visible = True
        PictureBox1.Visible = 1
        Panel4.Visible = 0
        Panel6.Visible = 0
        Panel2.BackgroundImage = Image.FromFile("baloto.png")
        PictureBox1.Image = Image.FromFile("imbaloto.png")
    End Sub

    'MATRICES ------------------------------------------------------------------------------------------------------------
    Private Sub AntisimetricaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntisimetricaToolStripMenuItem.Click
        Panel2.Visible = False
        PictureBox1.Visible = False
        Panel4.Visible = 0
        Panel6.Visible = 0
        Panel3.Visible = True
        Panel3.BackgroundImage = Image.FromFile("matriz.png")
        Panel3.Location = New Point(3, 3)
        Panel3.Size = New Size(967, 682)
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
                        'If (i = j) Then
                        'ini2:
                        'A(i, j) = InputBox("Por favor ingrese los datos de la matriz A(" & i & ", " & j & ") solo '0' ", "Datos")
                        'If (A(i, j) <> 0) Then
                        'MsgBox("Error. Ingrese el valor '0' en la diagonal")
                        'GoTo ini
                        'Else
                        'TextBox1.Text = TextBox1.Text & A(i, j) & "  "
                        'End If
                        '
                        'Else
                        A(i, j) = InputBox("Por favor ingrese los datos de la matriz A(" & i & ", " & j & ")", "Datos")
                        TextBox1.Text = TextBox1.Text & A(i, j) & "  "
                        'End If

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
            If (esAntisimetrica(A, matrizTranspuesta(A, n), n) = True) Then
                Label11.Text = "¡¡¡LA MATRIZ ES ANTISIMETRICA!!!"
            Else
                Label11.Text = "¡¡¡LA MATRIZ NO ES ANTISIMETRICA!!!"
            End If
ini1:
        Else
            MsgBox("Error. Ingrese el tamaño de la matriz")
        End If

    End Sub

    Private Function esAntisimetrica(A(,) As Double, b(,) As Double, n As Integer) As Boolean
        Dim anti As Boolean = False
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

    'ORDENAR -----------------------------------------------------------------------------------
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim response As MsgBoxResult
        n = TextBox6.Text
        ReDim vec1(0 To n)
        TextBox4.Text = ""
        TextBox7.Text = ""
        GroupBox1.Enabled = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        If (n <> 0) Then

            For i = 1 To n
                Try
ini:
                    vec1(i) = InputBox("Por favor ingrese el dato " & i & ":", "Datos")
                    TextBox7.Text = TextBox7.Text & vec1(i) & vbCrLf
                Catch ex As Exception
                    response = MsgBox("Error al ingresar el valor", 1)
                    If (response = MsgBoxResult.Cancel) Then
                        TextBox4.Text = ""
                        TextBox7.Text = ""
                        GoTo ini1
                    End If
                    GoTo ini
                End Try
            Next i
            GroupBox1.Enabled = True
ini1:
        Else
            MsgBox("Error. Ingrese el tamaño del vector")
        End If
    End Sub

    Public Sub mostrarVector(v() As Double, n As Integer, textbox As TextBox)
        For i = 1 To n
            textbox.Text = textbox.Text & v(i) & vbCrLf
        Next i
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (TextBox7.Text <> "") Then
            Try
                n = TextBox6.Text
                Label13.Text = "ASCENDENTE"
                TextBox4.Text = ""
                mostrarVector(ordenarAscendente(vec1, n), n, TextBox4)
            Catch ex As Exception
                MsgBox("Error. Ingrese el tamaño del vector")
            End Try
        Else
            MsgBox("Por favor ingrese el vector")
        End If
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click
        Panel2.Visible = False
        PictureBox1.Visible = False
        Panel3.Visible = False
        Panel6.Visible = 0
        Panel4.Visible = True
        'Panel4.BackColor = Color.FromArgb(RGB(193, 230, 202))
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (TextBox7.Text <> "") Then
            Try
                n = TextBox6.Text
                Label13.Text = "DESCENDENTE"
                TextBox4.Text = ""
                mostrarVector(ordenarDescendente(vec1, n), n, TextBox4)
            Catch ex As Exception
                MsgBox("Error. Ingrese el tamaño del vector")
            End Try
        Else
            MsgBox("Por favor ingrese el vector")
        End If

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

    'SALIR ------------------------------------------------------------------------------------------------------------
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub



    '------------------------------------------------------------------------------------------------------------















End Class
