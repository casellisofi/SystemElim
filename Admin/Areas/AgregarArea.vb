Public Class AgregarArea

    Dim objCede As New ECedes
    Dim objLider As New ELideres

    'Carga ComboBox Lider
    Sub CargarCBOLider(ByVal c As ComboBox)
        objLider.CargarCBO(c)
    End Sub

    'Carga ComboBox Auxiliar
    Sub CargarCBOAuxiliar(ByVal c As ComboBox)
        objLider.CargarCBO(c)
    End Sub

    'Carga ComboBox Cede
    Sub CargarCBOCede(ByVal c As ComboBox)
        objCede.CargarCBO(c)
    End Sub

    Private Sub AgregarArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBOLider(CBLider)
        CargarCBOAuxiliar(CBAuxiliar)
        CargarCBOCede(CBCede)
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (IsNull_textbox(TNombre) Or Vacio_Combo(CBLider) Or Vacio_Combo(CBAuxiliar) Or Vacio_Combo(CBCede)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim nuevaArea As EAreas = New EAreas(TNombre.Text, CInt(CBLider.SelectedValue), CInt(CBAuxiliar.SelectedValue), CInt(CBCede.SelectedValue), TDescr.Text)

            If nuevaArea.GuardarArea() Then
                MsgBox("Los datos se cargaron correctamente", MsgBoxStyle.OkOnly, "Confirmación")

                CBCede.ResetText()
                CBAuxiliar.ResetText()
                CBLider.ResetText()
                TNombre.Clear()


            Else

                MsgBox("Ocurrio un error al cargar los datos", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Confirmación")
            End If
        End If

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

End Class