Public Class AgregarLider

    Dim objPersona As New EPersonas
    Dim objLider As New ELideres

    'Carga ComboBox Lider
    Sub CargarCBOL(ByVal c As ComboBox)
        objPersona.CargarCBO(c)
    End Sub

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objLider.GetLiderBaja(d)

    End Sub


    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click

        Dim nuevoLider As ELideres = New ELideres(CInt(CBLider.SelectedValue))

        If objLider.ExisteLider(CBLider.SelectedValue) = False Then

            If nuevoLider.GuardarLider() Then

                CBLider.ResetText()
                MsgBox("Los datos se cargaron correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton2, "Confirmación")
                CargarDG(DGLideres)
            Else

                MsgBox("Ocurrio un error al cargar los datos", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Confirmación")
            End If

        Else
            MsgBox("Lider ya ha sido agregado", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Confirmación")
        End If
    End Sub

    Private Sub AgregarLider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBOL(CBLider)
        CargarCBOL(CBpers)
        CargarDG(DGLideres)
    End Sub

    Private Sub BDarDeBaja_Click(sender As Object, e As EventArgs) Handles BDarDeBaja.Click
        Dim i As Integer = DGLideres.CurrentRow.Index
        Dim cod As Integer = DGLideres.Item(0, i).Value

        Try
            Dim pers As Lideres = objLider.ObtenerLider(cod)
            Using ctx As New BDSystemElimEntities


                If objLider.Activar_Desactivar(pers.id_lider, pers.estado) Then
                    CargarDG(DGLideres)
                    MessageBox.Show("Exito!", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Error al activar/desactivar a la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objPersona.Buscar(TBuscador.Text, DGLideres)
    End Sub

    Private Sub DGLideres_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLideres.CellDoubleClick
        Dim i As Integer = DGLideres.CurrentRow.Index
        Dim cod As Integer = DGLideres.Item(0, i).Value



        Try
            Dim cel As Lideres = objLider.ObtenerLider(cod)
            Using ctx As New BDSystemElimEntities

                Dim lider = (From q In ctx.Persona.AsEnumerable Where (q.id_persona = cel.persona_id) Select q).ToList



                CBpers.Text = lider.Item(0).nombre + " " + lider.Item(0).apellido
                Tcelula.Text = cel.celulalider

            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BGuard_Click(sender As Object, e As EventArgs) Handles BGuard.Click
        If objLider.Modificar(CInt(CBpers.SelectedValue), Tcelula.Text) = True Then
            MessageBox.Show("Los datos de la persona se ha sido modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Tcelula.Clear()

            CBpers.SelectedValue = -1

            CargarDG(DGlideres)
        Else
            MessageBox.Show("Error al modificar los datos de la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class