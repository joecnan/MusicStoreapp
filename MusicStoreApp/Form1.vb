Public Class Form1
    Private valor As Double = 0.00

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub pbximagen1_Click(sender As Object, e As EventArgs) Handles pbximagen1.Click
        pbxcentral.Image = pbximagen1.Image
        lbltitulo.Text = "Hasta que te conocí"
        lblautor.Text = "Juan Gabriel"
        lblalbum.Text = "Pensamientos"
        lblaño.Text = "1986"
        lblprecio.Text = "S/. 4.50"
        AxWindowsMediaPlayer1.URL = "C:\Users\José\Desktop\Proyectos Visual 2015\MusicStoreApp\Otros\Juan Gabriel - Hasta Que Te Conocí.mp3"
    End Sub

    Private Sub btncomprar1_Click(sender As Object, e As EventArgs) Handles btncomprar1.Click
        If btncomprar1.Text = "COMPRAR" Then
            valor += 4.5
            btncomprar1.Text = "QUITAR"
        ElseIf btncomprar1.Text = "QUITAR" Then
            valor -= 4.5
            btncomprar1.Text = "COMPRAR"

        End If
        lbltotal.Text = valor.ToString("S/. #.##")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltotal.Text = "S/. 0.00"
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbximagen2.Click
        pbxcentral.Image = pbximagen2.Image
        lbltitulo.Text = "El Noa Noa"
        lblautor.Text = "Juan Gabriel"
        lblalbum.Text = "Recuerdos"
        lblaño.Text = "1980"
        lblprecio.Text = "S/. 5.50"
        AxWindowsMediaPlayer1.URL = "C:\Users\José\Desktop\Proyectos Visual 2015\MusicStoreApp\Otros\Juan Gabriel - El Noa-Noa.mp3"
    End Sub

    Private Sub btncomprar2_Click(sender As Object, e As EventArgs) Handles btncomprar2.Click
        If btncomprar2.Text = "COMPRAR" Then
            valor += 5.5
            btncomprar2.Text = "QUITAR"
        ElseIf btncomprar2.Text = "QUITAR" Then
            valor -= 5.5
            btncomprar2.Text = "COMPRAR"

        End If
        lbltotal.Text = valor.ToString("S/. #.##")
    End Sub

    Private Sub pbximagen3_Click(sender As Object, e As EventArgs) Handles pbximagen3.Click
        pbxcentral.Image = pbximagen3.Image
        lbltitulo.Text = "Querida"
        lblautor.Text = "Juan Gabriel"
        lblalbum.Text = "Recuerdos II"
        lblaño.Text = "1984"
        lblprecio.Text = "S/. 6.50"
        AxWindowsMediaPlayer1.URL = "C:\Users\José\Desktop\Proyectos Visual 2015\MusicStoreApp\Otros\Juan Gabriel - Querida ft. Juanes.mp3"
    End Sub

    Private Sub btncomprar3_Click(sender As Object, e As EventArgs) Handles btncomprar3.Click
        If btncomprar3.Text = "COMPRAR" Then
            valor += 6.5
            btncomprar3.Text = "QUITAR"
        ElseIf btncomprar3.Text = "QUITAR" Then
            valor -= 6.5
            btncomprar3.Text = "COMPRAR"

        End If
        lbltotal.Text = valor.ToString("S/. #.##")
    End Sub

    Private Sub pbximagen4_Click(sender As Object, e As EventArgs) Handles pbximagen4.Click
        pbxcentral.Image = pbximagen4.Image
        lbltitulo.Text = "Asi Fue"
        lblautor.Text = "Juan Gabriel"
        lblalbum.Text = "Juntos otra vez"
        lblaño.Text = "1996"
        lblprecio.Text = "S/. 4.50"
        AxWindowsMediaPlayer1.URL = "C:\Users\José\Desktop\Proyectos Visual 2015\MusicStoreApp\Otros\Juan Gabriel - Así Fue.mp3"
    End Sub

    Private Sub btncomprar4_Click(sender As Object, e As EventArgs) Handles btncomprar4.Click
        If btncomprar4.Text = "COMPRAR" Then
            valor += 4.5
            btncomprar4.Text = "QUITAR"
        ElseIf btncomprar4.Text = "QUITAR" Then
            valor -= 4.5
            btncomprar4.Text = "COMPRAR"

        End If
        lbltotal.Text = valor.ToString("S/. #.##")
    End Sub

    Private Sub pbximagen5_Click(sender As Object, e As EventArgs) Handles pbximagen5.Click
        pbxcentral.Image = pbximagen5.Image
        lbltitulo.Text = "Amor Eterno"
        lblautor.Text = "Juan Gabriel"
        lblalbum.Text = "Recuerdos"
        lblaño.Text = "1984"
        lblprecio.Text = "S/. 7.50"
        AxWindowsMediaPlayer1.URL = "C:\Users\José\Desktop\Proyectos Visual 2015\MusicStoreApp\Otros\Juan Gabriel - Amor Eterno.mp3"
    End Sub

    Private Sub btncomprar5_Click(sender As Object, e As EventArgs) Handles btncomprar5.Click
        If btncomprar5.Text = "COMPRAR" Then
            valor += 7.5
            btncomprar5.Text = "QUITAR"
        ElseIf btncomprar5.Text = "QUITAR" Then
            valor -= 7.5
            btncomprar5.Text = "COMPRAR"

        End If
        lbltotal.Text = valor.ToString("S/. #.##")
    End Sub

    Private Sub pbximagen6_Click(sender As Object, e As EventArgs) Handles pbximagen6.Click
        pbxcentral.Image = pbximagen6.Image
        lbltitulo.Text = "Abrázame muy fuerte"
        lblautor.Text = "Juan Gabriel"
        lblalbum.Text = "Recuerdos"
        lblaño.Text = "1984"
        lblprecio.Text = "S/. 7.50"
        AxWindowsMediaPlayer1.URL = "C:\Users\José\Desktop\Proyectos Visual 2015\MusicStoreApp\Otros\Juan Gabriel - Abrázame Muy Fuerte.mp3"
    End Sub

    Private Sub btncomprar6_Click(sender As Object, e As EventArgs) Handles btncomprar6.Click
        If btncomprar6.Text = "COMPRAR" Then
            valor += 7.5
            btncomprar6.Text = "QUITAR"
        ElseIf btncomprar6.Text = "QUITAR" Then
            valor -= 7.5
            btncomprar6.Text = "COMPRAR"

        End If
        lbltotal.Text = valor.ToString("S/. #.##")
    End Sub
End Class
