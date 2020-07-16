Public Class PersonasPorBautiz
    Private Sub PersonasPorBautiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.PersonasPorBautiz' Puede moverla o quitarla según sea necesario.
        Me.PersonasPorBautizTableAdapter.Fill(Me.Datos.PersonasPorBautiz)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class