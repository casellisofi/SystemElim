Public Class CelulasTotal
    Private Sub PersonasTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.Personas' Puede moverla o quitarla según sea necesario.
        Dim fechaAc As Date = Date.Now
        Dim fecha As New Date(fechaAc.Year, fechaAc.Month, fechaAc.Day)

        Me.PersonasTableAdapter.listado(Me.Datos.Personas, fecha)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class