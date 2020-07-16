Public Class ModificarCelula

    Dim objCelula As New ECelulas
    Dim objcede As New ECedes
    Dim objred As New ERedes

    Private Sub ModificarCelula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBOLider(CBLider)
        CargarCBOAuxiliar(CBAuxiliar)
        CargarDG(DGCelulas)
        CargarCBOCede(CBCede)
        CargarCBOred(CBred)
    End Sub

#Region "Combo Boxs y DataGridView"

    'Carga ComboBox Lider
    Sub CargarCBOLider(ByVal c As ComboBox)
        objCelula.CargarCBOL(c)
    End Sub

    'Carga ComboBox red
    Sub CargarCBOred(ByVal c As ComboBox)
        objred.CargarCBO(c)
    End Sub

    'Carga ComboBox Auxiliar
    Sub CargarCBOAuxiliar(ByVal c As ComboBox)
        objCelula.CargarCBOL(c)
    End Sub

    'Carga ComboBox Auxiliar
    Sub CargarCBOCede(ByVal c As ComboBox)
        objcede.CargarCBO(c)
    End Sub

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objCelula.GetCelulaModif(d)
    End Sub

#End Region

#Region "Validacion"

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TDirigido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDirigido.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TMesInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TMesInicio.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TAñoInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TAñoInicio.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub DGCelulas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCelulas.CellDoubleClick
        Dim i As Integer = DGCelulas.CurrentRow.Index
        Dim cod As Integer = DGCelulas.Item(0, i).Value

        Try
            Dim cel As Celula = objCelula.ObtenerCelula(cod)
            Using ctx As New BDSystemElimEntities

                Dim lider = (From q In ctx.Persona.AsEnumerable Where (q.id_persona = cel.lider) Select q).ToList
                Dim auxiliar = (From q In ctx.Persona.AsEnumerable Where (q.id_persona = cel.auxiliar) Select q).ToList
                Dim cede = (From q In ctx.Cede.AsEnumerable Where (q.id_cede = cel.cede_id) Select q).ToList
                Dim red = (From q In ctx.Red.AsEnumerable Where (q.id_red = cel.red_id) Select q).ToList


                Tid.Text = cel.id_celula
                TNombre.Text = cel.nombre
                CBLider.Text = lider.Item(0).nombre
                CBCede.Text = cede.Item(0).descripcion
                CBred.Text = red.Item(0).nombre
                CBAuxiliar.Text = auxiliar.Item(0).nombre
                TDirigido.Text = cel.dirigido
                THorario.Text = cel.horario
                TDireccion.Text = cel.direccion
                TMesInicio.Text = cel.mesInicio
                TAñoInicio.Text = cel.añoInicio
                Tsexo.Text = cel.sexo

            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click

        Dim ask As MsgBoxResult
        ask = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = MsgBoxResult.Yes Then

            Tid.Clear()
            TNombre.Clear()
            TDireccion.Clear()
            TDirigido.Clear()
            THorario.Clear()
            TMesInicio.Clear()
            TAñoInicio.Clear()
            CBLider.SelectedValue = -1
            CBAuxiliar.SelectedValue = -1
            CBCede.SelectedValue = -1
            CBred.SelectedValue = -1

        End If
    End Sub

    'Modifica los datos de una Celula


    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (IsNull_textbox(TNombre) Or IsNull_textbox(THorario) Or IsNull_textbox(TDireccion) Or IsNull_textbox(TDirigido) Or IsNull_textbox(TAñoInicio) Or
            IsNull_textbox(TMesInicio)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If MsgBox("¿Desea modificar los datos de la Celula?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Modificar datos de Celula") = MsgBoxResult.Yes Then
                If objCelula.Modificar(Tid.Text, TNombre.Text, CInt(CBLider.SelectedValue), CInt(CBAuxiliar.SelectedValue), CInt(CBCede.SelectedValue), TDireccion.Text, THorario.Text, TDirigido.Text, TMesInicio.Text, TAñoInicio.Text, Tsexo.Text, CInt(CBred.SelectedValue)) Then

                    MessageBox.Show("Los datos de la persona se ha sido modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Tid.Clear()
                    TNombre.Clear()
                    TDireccion.Clear()
                    TDirigido.Clear()
                    THorario.Clear()
                    TMesInicio.Clear()
                    TAñoInicio.Clear()
                    CBLider.SelectedValue = -1
                    CBAuxiliar.SelectedValue = -1
                    CBCede.SelectedValue = -1
                    CBred.SelectedValue = -1
                    CargarDG(DGCelulas)
                Else
                    MessageBox.Show("Error al modificar los datos de la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub


    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objCelula.Buscar(TBuscador.Text, DGCelulas)
    End Sub


#End Region
End Class