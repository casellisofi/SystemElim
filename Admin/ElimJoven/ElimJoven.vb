Public Class ElimJoven

    'Dim objPersona As New EPersonas
    'Dim objLider As New ELideres

    ''Carga DataGridView
    'Sub CargarDG(ByVal d As DataGridView)
    '    objLider.GetLiderBaja(d)

    'End Sub
    'Private Sub ElimJoven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    CargarDG(DGLideres)
    'End Sub


    'Private Sub DGLideres_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    Dim i As Integer = DGLideres.CurrentRow.Index
    '    Dim cod As Integer = DGLideres.Item(0, i).Value

    '    Try
    '        Dim pers As Persona = objPersona.ObtenerPersona(cod)
    '        Using ctx As New BDSystemElimEntities

    '            Dim lblAux As Label
    '            Dim yPos As Integer

    '            yPos = 70

    '            Dim idli As Lideres = objLider.ObtenerLiderSeleccionado(pers.id_persona)
    '            Dim idlid As Integer = idli.id_lider


    '            For Each id In objPersona.listaPersona()

    '                If id.lider_id = idlid Then

    '                    lblAux = New Label()
    '                    lblAux.Text = id.nombre + " " + id.apellido
    '                    lblAux.Location = New Point(25, yPos)
    '                    Me.Controls.Add(lblAux)
    '                    yPos = yPos + 25

    '                End If

    '            Next id
    '        End Using
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    'End Sub
End Class