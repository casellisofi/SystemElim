Public Class ListadoTotalReporte
    Private Sub ListadoTotalReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.ListadoTotalReporte' Puede moverla o quitarla según sea necesario.
        Me.ListadoTotalReporteTableAdapter.Fill(Me.Datos.ListadoTotalReporte)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class