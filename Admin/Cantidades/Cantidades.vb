Public Class Cantidades
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub BPersonas_Click(sender As Object, e As EventArgs) Handles BPersonas.Click
        Dim a As New CantPersona
        a.ShowDialog()

    End Sub

    Private Sub BCelulas_Click(sender As Object, e As EventArgs) Handles BCelulas.Click
        Dim a As New CantCelulas
        a.ShowDialog()
    End Sub

    Private Sub BBaut_Click(sender As Object, e As EventArgs) Handles BBaut.Click
        Dim a As New CantBautizados
        a.ShowDialog()
    End Sub

    Private Sub BEscuela_Click(sender As Object, e As EventArgs) Handles BEscuela.Click
        Dim a As New CantEscuela
        a.ShowDialog()
    End Sub
End Class