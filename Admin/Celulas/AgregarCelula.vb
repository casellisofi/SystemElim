Public Class AgregarCelula

    Dim objCede As New ECedes
    Dim objCelula As New ECelulas
    Dim objred As New ERedes

    'Carga ComboBox Lider
    Sub CargarCBOLider(ByVal c As ComboBox)
        objCelula.CargarCBOL(c)
    End Sub

    'Carga ComboBox Auxiliar
    Sub CargarCBOAuxiliar(ByVal c As ComboBox)
        objCelula.CargarCBOL(c)
    End Sub

    'Carga ComboBox Cede
    Sub CargarCBOCede(ByVal c As ComboBox)
        objCede.CargarCBO(c)
    End Sub

    'Carga ComboBox Red
    Sub CargarCBORed(ByVal c As ComboBox)
        objred.CargarCBO(c)
    End Sub
    Private Sub AgregarCelula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBOLider(CBLider)
        CargarCBOAuxiliar(CBAuxiliar)
        CargarCBOCede(CBCede)
        CargarCBORed(CBRed)
    End Sub
#Region "Validacion"



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TDirigido_KeyPress(sender As Object, e As KeyPressEventArgs)
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


    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (IsNull_textbox(TNombre) Or IsNull_textbox(THorario) Or IsNull_textbox(TDireccion) Or IsNull_textbox(TAñoInicio) Or
          IsNull_textbox(TMesInicio) Or Vacio_Combo(CBLider) Or Vacio_Combo(CBCede)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim diri As RadioButton = Validar_Radio(GBDirigido)

            Dim nuevaCelula As ECelulas = New ECelulas(TNombre.Text, CInt(CBLider.SelectedValue), CInt(CBAuxiliar.SelectedValue), CInt(CBCede.SelectedValue), TDireccion.Text, THorario.Text, diri.Text,
                                                       TMesInicio.Text, TAñoInicio.Text, CheckBox(GBSexo), CInt(CBRed.SelectedValue))

            If nuevaCelula.GuardarCelula() Then

                MsgBox("Los datos se cargaron correctamente", MsgBoxStyle.OkOnly, "Confirmación")

                CBLider.ResetText()
                CBAuxiliar.ResetText()
                CBCede.ResetText()
                CBRed.ResetText()
                TNombre.Clear()
                'jov.ResetText()
                'adoles.ResetText()
                'matri.ResetText()
                'hombre.ResetText()
                'mujer.ResetText()
                THorario.Clear()
                TDireccion.Clear()
                TMesInicio.Clear()
                TAñoInicio.Clear()



            Else
                MsgBox("Ocurrio un error al cargar los datos", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Confirmación")
            End If
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult
        ask = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = MsgBoxResult.Yes Then

            CBLider.ResetText()
            CBAuxiliar.ResetText()
            CBCede.ResetText()
            CBRed.ResetText()
            TNombre.Clear()
            THorario.Clear()
            TDireccion.Clear()
            TMesInicio.Clear()
            TAñoInicio.Clear()
            'jov.ResetText()
            'adoles.ResetText()
            'matri.ResetText()
            'hombre.ResetText()
            'mujer.ResetText()


        End If
    End Sub

    Private Sub BAgregarRed_Click(sender As Object, e As EventArgs) Handles BAgregarRed.Click
        Dim red As New AgregarRed
        red.ShowDialog()

    End Sub
End Class
