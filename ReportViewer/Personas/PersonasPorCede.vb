Public Class PersonasPorCede
    Private Sub PersonasPorCede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos.PersonasPorCede' Puede moverla o quitarla según sea necesario.

        Dim objpersona As New EPersonas
        Me.PersonasPorCedeTableAdapter.Fill(Me.Datos.PersonasPorCede, objpersona.Temporal)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class