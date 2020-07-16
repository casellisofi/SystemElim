Public Class CelulasPorLider
    Private Sub CelulasPorLider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.CelulasPorLider' Puede moverla o quitarla según sea necesario.
        Me.CelulasPorLiderTableAdapter.Fill(Me.Datos.CelulasPorLider)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class