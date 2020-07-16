Public Class BajaArea

    Dim objArea As New EAreas

    Private Sub BajaArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDG(DGAreas)
    End Sub
    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objArea.GetAreaBaja(d)
    End Sub


    Private Sub BBaja_Click(sender As Object, e As EventArgs) Handles BBaja.Click
        Dim i As Integer = DGAreas.CurrentRow.Index
        Dim cod As Integer = DGAreas.Item(0, i).Value

        Try
            Dim area As Area = objArea.ObtenerArea(cod)
            Using ctx As New BDSystemElimEntities


                If objArea.Activar_Desactivar(area.id_area, area.estado) Then
                    CargarDG(DGAreas)
                Else
                    MessageBox.Show("Error al activar/desactivar a la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objArea.Buscar(TBuscador.Text, DGAreas)
    End Sub
End Class