Public Class BajaCelula
    Private Sub BajaCelula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDG(DGCelulas)
    End Sub

    Dim objCelula As New ECelulas

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objCelula.GetCelulaBaja(d)
    End Sub


    Private Sub BBaja_Click(sender As Object, e As EventArgs) Handles BBaja.Click
        Dim i As Integer = DGCelulas.CurrentRow.Index
        Dim cod As Integer = DGCelulas.Item(0, i).Value

        Try
            Dim cel As Celula = objCelula.ObtenerCelula(cod)
            Using ctx As New BDSystemElimEntities


                If objCelula.Activar_Desactivar(cel.id_celula, cel.estado) Then
                    CargarDG(DGCelulas)
                Else
                    MessageBox.Show("Error al activar/desactivar a la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objCelula.Buscar(TBuscador.Text, DGCelulas)
    End Sub
End Class