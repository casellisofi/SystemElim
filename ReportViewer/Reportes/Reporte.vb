Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.Reporte' Puede moverla o quitarla según sea necesario.
        Dim id As Integer
        Dim objReporte As New EReporte
        If objReporte.Actuall = Nothing Then
            id = objReporte.UltimoReporte
        Else
            id = objReporte.Actuall
        End If

        Me.ReporteTableAdapter.Fill(Me.Datos.Reporte, id)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class