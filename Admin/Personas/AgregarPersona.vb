Public Class AgregarPersona

    Dim objCede As New ECedes
    Dim objCelula As New ECelulas
    Dim objLider As New ELideres
    Dim objEscuela As New EEscuela
    Dim objPersona As New EPersonas

#Region "Combo Boxs"

    'Carga ComboBox Cede
    Sub CargarCBO(ByVal c As ComboBox)
        objCede.CargarCBO(c)
    End Sub

    'Carga ComboBox Celula
    Sub CargarCBOC(ByVal c As ComboBox)
        objCelula.CargarCBO(c)
    End Sub

    'Carga ComboBox Lider
    Sub CargarCBOL(ByVal c As ComboBox)
        objLider.CargarCBO(c)
    End Sub

    'Carga ComboBox Escuela
    Sub CargarCBOE(ByVal c As ComboBox)
        objEscuela.CargarCBO(c)
    End Sub
#End Region

#Region "Validación"

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub TLugarNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TLugarNac.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub TLugar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TLugar.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TAño.KeyPress
        If Validar_numeros(e) Then
            MessageBox.Show("Solo se admiten numeros", "Validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

    Private Sub AgregarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCBO(CBCede)
        CargarCBOC(CBCelula)
        CargarCBOL(CBLider)
        CargarCBOE(CBModulo)
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (IsNull_textbox(TNombre) Or IsNull_textbox(TApellido) Or IsNull_textbox(TBarrio) Or IsNull_textbox(TTelefono) Or (RMujer.Checked = False And RHombre.Checked = False) Or
            IsNull_textbox(TLugarNac) Or Vacio_Combo(CBModulo) Or Vacio_Combo(CBCede) Or Vacio_Combo(CBCelula) Or Vacio_Combo(CBLider) Or
IsNull_textbox(TLugar) Or IsNull_textbox(TAño) Or (RSiB.Checked = False And RNoB.Checked = False) Or (RSiV.Checked = False And RNoV.Checked = False)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else


            Dim fechaNac As New Date(DFechaNac.Value.Year, DFechaNac.Value.Month, DFechaNac.Value.Day)

            Dim rbB As RadioButton = Validar_Radio(GBBautizado)
            Dim sexo As RadioButton = Validar_Radio(GBSexo)
            Dim rbE As RadioButton = Validar_Radio(GBEscuela)


            Dim nuevoBautizado As EBautizados = New EBautizados(rbB.Text, TIglesia.Text, TLugar.Text, TAño.Text)

            If nuevoBautizado.GuardarBautizado() Then

                Dim idB As Integer = nuevoBautizado.Id_bautizado

                Dim id As Integer = objPersona.idUltimo + 1
                Dim fechaAc As Date = Date.Now

                Dim idlideer As Integer = objLider.ObtenerLiderSeleccionado(CInt(CBLider.SelectedValue)).id_lider

                Dim nuevaPersona As EPersonas = New EPersonas(id, TNombre.Text, TApellido.Text, fechaNac, TLugarNac.Text, CheckBox(gbprofesion), sexo.Text, TDireccion.Text,
                                                                  TBarrio.Text, TTelefono.Text, CInt(CBCede.SelectedValue), CInt(CBCelula.SelectedValue),
                                                                  idlideer, CInt(CBModulo.SelectedValue), idB, fechaAc)


                If nuevaPersona.GuardarPersona() Then

                    MsgBox("Los datos se cargaron correctamente", MsgBoxStyle.OkOnly, "Confirmación")

                    GBProfesion.ResetText()

                    CBCede.ResetText()
                    CBCelula.ResetText()
                    CBLider.ResetText()
                    CBModulo.ResetText()
                    TApellido.Clear()
                    TNombre.Clear()
                    RMujer.ResetText()
                    RHombre.ResetText()
                    TBarrio.Clear()
                    TTelefono.Clear()
                    TLugarNac.Clear()
                    TLugar.Clear()
                    TDireccion.Clear()
                    GBEscuela.ResetText()
                    GBSexo.ResetText()
                    GBBautizado.ResetText()


                    TAño.Clear()
                    DFechaNac.ResetText()

                Else

                    MsgBox("Ocurrio un error al cargar los datos", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Confirmación")
                End If
            End If

        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult
        ask = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = MsgBoxResult.Yes Then

            TApellido.Clear()
            TNombre.Clear()
            TDireccion.Clear()
            TBarrio.Clear()
            GBEscuela.ResetText()
            GBSexo.ResetText()
            GBBautizado.ResetText()
            GBProfesion.ResetText()
            TTelefono.Clear()
            DFechaNac.ResetText()
            TLugarNac.Clear()
            CBCede.SelectedValue = -1
            CBCelula.SelectedValue = -1
            TIglesia.Clear()
            TLugar.Clear()
            TAño.Clear()
            CBModulo.SelectedValue = -1

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lider As New AgregarLider
        lider.showdialog()
    End Sub
End Class