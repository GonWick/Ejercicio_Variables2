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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'PRUEBA DE DECLARACION DE VARIABLES
        Dim N, A As String
        'La asignación de valor de las variables se puede hacer también en la misma línea.
        N = "Luis" : A = "Ayala"
        'Y las instrucciones o líneas de códigos pueden hacerse también en la misma línea pero separadas por dos puntos “ : ”
        MsgBox(N,, "Nombre") : MsgBox(A,, "Apellido")
    End Sub
End Class
