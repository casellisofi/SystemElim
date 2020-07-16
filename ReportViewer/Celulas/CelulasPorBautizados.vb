Public Class CelulasPorBautizados
    Private Sub CelulasPorBautizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.CelulasPorBaut' Puede moverla o quitarla según sea necesario.
        Dim objBaut As New EBautizados
        Me.CelulasPorBautTableAdapter.Fill(Me.Datos.CelulasPorBaut, objBaut.Temporal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class