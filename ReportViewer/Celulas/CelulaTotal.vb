Public Class CelulaTotal
    Private Sub CelulaTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.Celulas' Puede moverla o quitarla según sea necesario.
        Me.CelulasTableAdapter.Fill(Me.Datos.Celulas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class