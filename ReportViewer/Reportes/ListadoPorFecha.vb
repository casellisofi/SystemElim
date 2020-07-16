Public Class ListadoPorFecha
    Private Sub ListadoPorFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.ListadoPorFecha' Puede moverla o quitarla según sea necesario.
        Dim objRep As New EReporte

        Me.ListadoPorFechaTableAdapter.Fill(Me.Datos.ListadoPorFecha, objRep.ActuallFecha)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class