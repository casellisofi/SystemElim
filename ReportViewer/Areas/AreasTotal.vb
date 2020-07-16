Public Class AreasTotal
    Private Sub AreasTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.Areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.Datos.Areas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class