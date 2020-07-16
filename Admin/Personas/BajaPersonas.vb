Public Class BajaPersonas

    Dim objPersona As New EPersonas

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objPersona.GetPersonaBaja(d)
    End Sub

    Private Sub BajaPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDG(DGPersonas)

    End Sub

    Private Sub BBaja_Click(sender As Object, e As EventArgs) Handles BBaja.Click
        Dim i As Integer = DGPersonas.CurrentRow.Index
        Dim cod As Integer = DGPersonas.Item(0, i).Value

        Try
            Dim pers As Persona = objPersona.ObtenerPersona(cod)
            Using ctx As New BDSystemElimEntities


                If objPersona.Activar_Desactivar(pers.id_persona, pers.estado) Then
                    CargarDG(DGPersonas)
                Else
                    MessageBox.Show("Error al activar/desactivar a la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objPersona.Buscar(TBuscador.Text, DGPersonas)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class