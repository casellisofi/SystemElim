Public Class PersonasPorLider
    Private Sub PersonasPorLider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.PersonasPorLider' Puede moverla o quitarla según sea necesario.
        Me.PersonasPorLiderTableAdapter.Fill(Me.Datos.PersonasPorLider)


        Me.ReportViewer1.RefreshReport
    End Sub

End Class