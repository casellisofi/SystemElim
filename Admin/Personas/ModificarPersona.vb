Public Class ModificarPersona

    Dim objCede As New ECedes
    Dim objCelula As New ECelulas
    Dim objLider As New ELideres
    Dim objEscuela As New EEscuela
    Dim objPersona As New EPersonas

    Private Sub ModificarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDG(DGPersonas)
        CargarCBO(CBCede)
        CargarCBOC(CBCelula)
        CargarCBOL(CBLider)
        CargarCBOE(CBModulo)
    End Sub

#Region "Combo Boxs y DataGridView"

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

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objPersona.GetPersonaModif(d)
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

    Private Sub TProfesion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TProfesion.KeyPress
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TSexo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Validar_letras(e) Then
            MessageBox.Show("Solo se admiten letras", "Validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

#Region "Procedimientos"

    'Obtiene los datos de la Persona seleccionada

    Private Sub DGPersonas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPersonas.CellDoubleClick
        Dim i As Integer = DGPersonas.CurrentRow.Index
        Dim cod As Integer = DGPersonas.Item(0, i).Value

        Try
            Dim pers As Persona = objPersona.ObtenerPersona(cod)
            Using ctx As New BDSystemElimEntities

                Dim cede = (From q In ctx.Cede.AsEnumerable Where (q.id_cede = pers.cede_id) Select q).ToList
                Dim celula = (From q In ctx.Celula.AsEnumerable Where (q.id_celula = pers.celula_id) Select q).ToList
                Dim lider = (From q In ctx.Lideres.AsEnumerable Where (q.id_lider = pers.lider_id) Select q).ToList
                Dim bautiza = (From q In ctx.Bautizados.AsEnumerable Where (q.id_bautizado = pers.bautizado_id) Select q).ToList
                Dim escuela = (From q In ctx.EscuelaDeVida.AsEnumerable Where (q.id_escuela = pers.escuela_id) Select q).ToList


                Dim fechaN As New Date(DFechaNac.Value.Year, DFechaNac.Value.Month, DFechaNac.Value.Day)

                Tid.Text = pers.id_persona
                TNombre.Text = pers.nombre
                TApellido.Text = pers.apellido
                TDireccion.Text = pers.direccion
                TBarrio.Text = pers.barrio
                TProfesion.Text = pers.profesion
                TTelefono.Text = pers.telefono
                Validar_RadioN(GBSexo, pers.sexo)
                DFechaNac.Value = New Date(pers.fecha_nac.Value.Year, pers.fecha_nac.Value.Month, pers.fecha_nac.Value.Day)
                TLugarNac.Text = pers.lugar_nac
                CBCede.Text = cede.Item(0).descripcion
                CBCelula.Text = celula.Item(0).nombre
                CBLider.Text = lider.Item(0).PersonaQueEsLider.nombre
                Validar_RadioN(GBBautizado, pers.Bautizados.estado)
                TIglesia.Text = pers.Bautizados.iglesia
                TLugar.Text = pers.Bautizados.lugar
                TAño.Text = pers.Bautizados.año
                CBModulo.Text = escuela.Item(0).descripcion

            End Using
        Catch ex As Exception
        End Try
    End Sub

    'Modifica los datos de una Persona

    Private Sub BGuardarModifif_Click(sender As Object, e As EventArgs) Handles BGuardarModifif.Click
        'If (IsNull_textbox(TNombre) Or IsNull_textbox(TApellido) Or IsNull_textbox(TBarrio) Or IsNull_textbox(TTelefono) Or IsNull_textbox(TProfesion) Or
        '   IsNull_textbox(TLugarNac) Or Vacio_Combo(CBModulo) Or Vacio_Combo(CBCede) Or Vacio_Combo(CBCelula) Or Vacio_Combo(CBLider) Or IsNull_textbox(TIglesia) Or
        '   IsNull_textbox(TLugar) Or IsNull_textbox(TAño)) Then
        If (IsNull_textbox(TNombre)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim fechaNac As New Date(DFechaNac.Value.Year, DFechaNac.Value.Month, DFechaNac.Value.Day)

            Dim rbB As RadioButton = Validar_Radio(GBBautizado)
            Dim sexo As RadioButton = Validar_Radio(GBSexo)
            Dim rbE As RadioButton = Validar_Radio(GBEscuela)

            Dim idlideer As Integer = objLider.ObtenerLiderSeleccionado(CInt(CBLider.SelectedValue)).id_lider



            If MsgBox("¿Desea modificar los datos de la Persona?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Modificar datos de Persona") = MsgBoxResult.Yes Then
                If objPersona.Modificar(Tid.Text, TNombre.Text, TApellido.Text, fechaNac, TLugarNac.Text, TProfesion.Text, sexo.Text, TDireccion.Text,
                                                          TBarrio.Text, TTelefono.Text, CInt(CBCede.SelectedValue), CInt(CBCelula.SelectedValue),
                                                          idlideer, CInt(CBModulo.SelectedValue), TIglesia.Text, TLugar.Text, TAño.Text) Then
                    MessageBox.Show("Los datos de la persona se ha sido modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Tid.Clear()
                    TApellido.Clear()
                    TNombre.Clear()
                    TDireccion.Clear()
                    TBarrio.Clear()
                    TProfesion.Clear()
                    TTelefono.Clear()
                    DFechaNac.ResetText()
                    TLugarNac.Clear()
                    CBCede.SelectedValue = -1
                    CBCelula.SelectedValue = -1
                    CBLider.SelectedValue = -1
                    TIglesia.Clear()
                    TLugar.Clear()
                    TAño.Clear()
                    Desactivar_Radio(GBSexo)
                    Desactivar_Radio(GBBautizado)
                    Desactivar_Radio(GBEscuela)
                    CargarDG(DGPersonas)
                Else
                    MessageBox.Show("Error al modificar los datos de la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            TProfesion.Clear()
            TTelefono.Clear()
            DFechaNac.ResetText()
            TLugarNac.Clear()
            CBCede.SelectedValue = -1
            CBCelula.SelectedValue = -1
            TIglesia.Clear()
            TLugar.Clear()
            TAño.Clear()
            CBModulo.SelectedValue = -1
            RMujer.ResetText()
            RHombre.ResetText()
            RSiB.ResetText()
            RNoB.ResetText()
            RSiV.ResetText()
            RNoV.ResetText()
        End If
    End Sub

    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objPersona.Buscar(TBuscador.Text, DGPersonas)

    End Sub



#End Region

End Class