Public Class AreasPorCede
    Private Sub AreasPorCede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.AreasPorCede' Puede moverla o quitarla según sea necesario.
        Dim objArea As New EAreas
        Me.AreasPorCedeTableAdapter.Fill(Me.Datos.AreasPorCede, objArea.Temporal)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class