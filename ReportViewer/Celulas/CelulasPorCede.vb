Public Class CelulasPorCede
    Private Sub CelulasPorCede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.CelulasPorCede' Puede moverla o quitarla según sea necesario.
        Dim objcelula As New ECelulas
        Me.CelulasPorCedeTableAdapter.Fill(Me.Datos.CelulasPorCede, objcelula.IdActual)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class