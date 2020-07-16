Public Class ListadoPorCelula
    Private Sub ListadoPorCelula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.ListadoPorCelula' Puede moverla o quitarla según sea necesario.
        Dim objcelula As New ECelulas

        Me.ListadoPorCelulaTableAdapter.Fill(Me.Datos.ListadoPorCelula, objcelula.IdActual)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class