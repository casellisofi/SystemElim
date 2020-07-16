Public Class PersonasPorEscuela
    Private Sub PersonasPorEscuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.PersonasPorEscuela' Puede moverla o quitarla según sea necesario.
        Me.PersonasPorEscuelaTableAdapter.Fill(Me.Datos.PersonasPorEscuela)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class