Public Class ReporteCelula
    Dim red As New ERedes
    Dim celula As New ECelulas

    Private Sub ReporteCelula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        red.CargarCBO(CBRED)
        celula.CargarCBO(CBCelula)
    End Sub

    Private Sub BGuardar_Click_1(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (IsNull_textbox(TBautizados) Or IsNull_textbox(TDia) Or IsNull_textbox(THora) Or IsNull_textbox(TObservaciones) Or
          IsNull_textbox(TDomicilio) Or IsNull_textbox(TDiscipulados) Or IsNull_textbox(TLeccion) Or IsNull_textbox(TLider) Or IsNull_textbox(TAuxiliar) Or Vacio_Combo(CBCelula) Or Vacio_Combo(CBRED) Or IsNull_textbox(TMiembros) Or IsNull_textbox(TMiembrosAus) Or IsNull_textbox(TTotal)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else


            Dim fecha As New Date(DTFecha.Value.Year, DTFecha.Value.Month, DTFecha.Value.Day)


            Dim nuevoReporte As EReporte = New EReporte(CInt(CBRED.SelectedValue), CInt(CBCelula.SelectedValue), TLider.Text, TAuxiliar.Text, TDomicilio.Text, fecha, TDia.Text, THora.Text, TLeccion.Text, TMiembros.Text,
                                                                  TVisitantes.Text, TTotal.Text, TDiscipulados.Text, TBautizados.Text, TAlmasg.Text, TMiembrosAus.Text, TObservaciones.Text)


            If nuevoReporte.GuardarReporte() Then

                MsgBox("Los datos se cargaron correctamente", MsgBoxStyle.OkOnly, "Confirmación")
                Dim rep As New Reporte
                rep.ShowDialog()
                CBRED.ResetText()
                CBCelula.ResetText()

                TLider.Clear()
                TAuxiliar.Clear()
                TDia.Clear()
                THora.Clear()
                TDomicilio.Clear()
                TMiembros.Clear()
                TMiembrosAus.Clear()
                TBautizados.Clear()
                TLeccion.Clear()
                TAlmasg.Clear()
                TObservaciones.Clear()
                TTotal.Clear()
                TVisitantes.Clear()
                TDiscipulados.Clear()
                DTFecha.ResetText()

            Else

                MsgBox("Ocurrio un error al cargar los datos", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Confirmación")
                End If
            End If

    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult
        ask = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If ask = MsgBoxResult.Yes Then


            CBRED.ResetText()
            CBCelula.ResetText()
            TLider.Clear()
            TAuxiliar.Clear()
            TDia.Clear()
            THora.Clear()
            TDomicilio.Clear()
            TMiembros.Clear()
            TMiembrosAus.Clear()
            TBautizados.Clear()
            TLeccion.Clear()
            TAlmasg.Clear()
            TObservaciones.Clear()
            TTotal.Clear()
            TVisitantes.Clear()
            TDiscipulados.Clear()
            DTFecha.ResetText()


        End If
    End Sub
End Class