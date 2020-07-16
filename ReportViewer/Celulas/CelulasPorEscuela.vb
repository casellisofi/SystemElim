Public Class CelulasPorEscuela
    Private Sub CelulasPorEscuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.CelulasPorEscuela' Puede moverla o quitarla según sea necesario.
        Dim objCelu As New ECelulas
        Me.CelulasPorEscuelaTableAdapter.Fill(Me.Datos.CelulasPorEscuela, objCelu.IdActual)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class