Public Class Modificar_Area

    Dim objArea As New EAreas
    Dim objLider As New ELideres

    Private Sub Modificar_Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBOLider(CBLider)
        CargarCBOAuxiliar(CBAuxiliar)
        CargarDG(DGAreas)
    End Sub


#Region "Combo Boxs y DataGridView"

    'Carga ComboBox Lider
    Sub CargarCBOLider(ByVal c As ComboBox)
        objLider.CargarCBO(c)
    End Sub

    'Carga ComboBox Auxiliar
    Sub CargarCBOAuxiliar(ByVal c As ComboBox)
        objLider.CargarCBO(c)
    End Sub

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objArea.GetAreaModif(d)
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub DGAreas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAreas.CellDoubleClick
        Dim i As Integer = DGAreas.CurrentRow.Index
        Dim cod As Integer = DGAreas.Item(0, i).Value

        Try
            Dim area As Area = objArea.ObtenerArea(cod)
            Using ctx As New BDSystemElimEntities

                Dim lider = (From q In ctx.Persona.AsEnumerable Where (q.id_persona = area.lider) Select q).ToList
                Dim auxiliar = (From q In ctx.Persona.AsEnumerable Where (q.id_persona = area.auxiliar) Select q).ToList
                Dim cede = (From q In ctx.Cede.AsEnumerable Where (q.id_cede = area.cede_id) Select q).ToList

                Tid.Text = area.id_area
                TNombre.Text = area.nombre
                CBLider.Text = lider.Item(0).nombre
                CBAuxiliar.Text = auxiliar.Item(0).nombre
                CBCede.Text = cede.Item(0).descripcion


            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult
        ask = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = MsgBoxResult.Yes Then

            CBCede.ResetText()
            CBAuxiliar.ResetText()
            CBLider.ResetText()
            TNombre.Clear()
            TDescr.Clear()

        End If
    End Sub

    'Modifica los datos de una Area


    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (IsNull_textbox(TNombre) Or Vacio_Combo(CBLider) Or Vacio_Combo(CBAuxiliar) Or Vacio_Combo(CBCede)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            If MsgBox("¿Desea modificar los datos de la Area?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Modificar Instrumento") = MsgBoxResult.Yes Then
                If objArea.Modificar(Tid.Text, TNombre.Text, CInt(CBLider.SelectedValue), CInt(CBAuxiliar.SelectedValue), CInt(CBCede.SelectedValue), TDescr.Text) Then
                    MessageBox.Show("Los datos de la area se ha sido modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Tid.Clear()
                    TNombre.Clear()
                    TDescr.Clear()
                    CBLider.SelectedValue = -1
                    CBAuxiliar.SelectedValue = -1
                    CBCede.SelectedValue = -1
                    CargarDG(DGAreas)
                Else
                    MessageBox.Show("Error al modificar los datos de la area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub


    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objArea.Buscar(TBuscador.Text, DGAreas)
    End Sub

#End Region

End Class