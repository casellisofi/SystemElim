Public Class ListadoPorRed
    Private Sub ListadoPorRed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.ListadoPorRed' Puede moverla o quitarla según sea necesario.

        Dim objred As New ERedes
        Me.ListadoPorRedTableAdapter.Fill(Me.Datos.ListadoPorRed, objred.IdActual)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class