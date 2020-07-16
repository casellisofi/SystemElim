
' Espacio de nombres con clases para el manejo de expresiones regulares en .NET  
Imports System.Text.RegularExpressions

Module Validaciones

    Public Function Validar_digitos(ByVal e As TextBox, ByVal n As Integer) As Boolean
            Dim a As String = CStr(e.Text)
        If a.Length <= n Then
            Return True
        Else
            Return False
        End If
        Return MsgBox("Error")

    End Function

        Public Function Validar_numeros(ByVal e As KeyPressEventArgs) As Boolean
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
                Return False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                Return False
            Else
                e.Handled = True
                Return True
            End If
        End Function

        Public Function Validar_letras(ByVal e As KeyPressEventArgs) As Boolean
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
                Return False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
                Return False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
                Return False
            Else
                e.Handled = True
                Return True
            End If
        End Function

        ' Valida si un textbox contiene un email
        '

        Public Function IsEmail(ByVal p_textbox As TextBox) As Boolean
            Dim t As String = CStr(p_textbox.Text)
            If t = String.Empty Then
                Return False ' Campo vacio
            Else
                ' Compruebo si el formato de la dirección es correcto
                Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
                Dim m As Match = re.Match(t)
                If m.Captures.Count <> 0 Then
                    Return True 'Si es un email valido

                Else
                    Return False 'No es un email valido

                End If
            End If
        End Function

        ' Valida un textbox, retorna True si un textbox es nulo
        '
        Public Function IsNull_textbox(ByVal p_textbox As TextBox) As Boolean
            If p_textbox.Text = "" Then
                Return True ' Textbox nulo
            End If
            Return False ' Textbox no nulo
        End Function

    ' Valida un combobox, retorna True si un combobox esta vacio
    '

    Public Function Vacio_Combo(combo As ComboBox) As Boolean
        If combo.SelectedIndex = -1 Then
            Return True ' Combobox vacio
        End If
        Return False ' Combobox no vacio

    End Function

    Public Function Vacio_atributo(ByVal id As Integer) As Boolean
        If id < 0 Then
            Return True' Combobox vacio
        End If
        Return False ' Combobox no vacio

    End Function

    'Valida un datetimepicker, retorna True si se selecciono un año que es mayor a 2000

    Public Function Validar_fechaCum(DateT As DateTimePicker) As Boolean
            Dim vMes As Integer = DateT.Value.Year


            If vMes > 2000 Then
                Return True ' Es mayor
            Else
                Return False ' No es mayor
            End If
        End Function

    Public Function Validar_Radio(ByVal gr As GroupBox)
        For Each b As RadioButton In gr.Controls.OfType(Of RadioButton)()
            If b.Checked = True Then
                Return b
            End If
        Next
        Return MsgBox("error")
    End Function

    Public Function CheckBox(ByVal gr As GroupBox) As String
        Dim oc As String = ""
        Dim i As Integer = 0
        For Each be As CheckBox In gr.Controls.OfType(Of CheckBox)()

            If be.Checked = True Then
                If i = 0 Then
                    oc = be.Text
                ElseIf i = 1 Then

                    oc = oc + " y " + be.Text
                End If
                i = i + 1
                End If

        Next

        Return oc


    End Function

    Public Function Desactivar_Radio(ByVal gr As GroupBox)
        For Each b As RadioButton In gr.Controls.OfType(Of RadioButton)()
            If b.Checked = True Then
                b.Checked = False
            End If
        Next
        Return MsgBox("error")
    End Function

    Public Sub Validar_RadioN(ByVal gr As GroupBox, ByVal nom As String)
            For Each b As RadioButton In gr.Controls.OfType(Of RadioButton)()
                If b.Text = nom Then
                    b.Checked = True
                End If
            Next

        End Sub


    End Module

