Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nombre As String
        Nombre = TextBox1.Text
        Dim Apellido As String
        Apellido = TextBox2.Text
        Dim NombreCompleto As String
        NombreCompleto = TextBox1.Text & " " & TextBox2.Text
        Label3.Text = NombreCompleto
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
