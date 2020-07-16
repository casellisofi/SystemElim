Public Class AllElim
    Private Sub AllElim_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Declaracion de objetos

    Dim objUsuario As EUsuarios = New EUsuarios
    Dim objPersona As EPersonas = New EPersonas
    Dim objRol As ERoles = New ERoles

    'Procedimiento para inicio de sesion

    Private Sub BEntrar_Click_1(sender As Object, e As EventArgs) Handles BEntrar.Click, MyBase.Enter

        If IsNull_textbox(TUsuario) Or IsNull_textbox(TContraseña) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If objUsuario.ExisteUsuario(TUsuario.Text, TContraseña.Text) Then
                Dim idR As Integer = objUsuario.BuscarUsuario(TUsuario.Text)
                Dim rol As Integer = objRol.BuscarRoles(idR)

                If rol = 1 Then
                    Dim adm As New Administracion
                    adm.ShowDialog()


                ElseIf rol = 3 Then
                    Dim joven As New ElimJoven
                    joven.ShowDialog()
                End If

                TUsuario.Clear()
                TContraseña.Clear()
            Else
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class