Public Class AgregarRed
    Dim red As New ERedes

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim nuevared As ERedes = New ERedes(TNombre.Text)

        If nuevared.GuardarRed() Then

            MsgBox("Los datos se cargaron correctamente", MsgBoxStyle.OkOnly, "Confirmación")
        End If

        TNombre.Clear()

    End Sub
End Class