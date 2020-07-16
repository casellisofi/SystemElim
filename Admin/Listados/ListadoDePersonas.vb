Imports Microsoft.Office.Interop

Public Class ListadoDePersonas
    Dim objCede As New ECedes
    Dim objCelula As New ECelulas
    Dim objLider As New ELideres
    Dim objEscuela As New EEscuela
    Dim objPersona As New EPersonas
    Dim objBaut As New EBautizados

#Region "Listado de Personas"

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objPersona.GetPersonaAll(d)
    End Sub


    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objPersona.Buscar(TBuscador.Text, DGPersonas)
    End Sub

    Private Sub Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDG(DGPersonas)
    End Sub


    Private Sub BExcelP_Click(sender As Object, e As EventArgs) Handles BExcelP.Click
        Dim rep As New CelulasTotal
        rep.ShowDialog()

        'Try
        '    Dim fichero As New SaveFileDialog()
        '    fichero.Filter = "Excel (*.xls)|*.xls"
        '    If fichero.ShowDialog() = DialogResult.OK Then
        '        Dim aplicacion As Microsoft.Office.Interop.Excel.Application
        '        Dim libros_trabajo As Microsoft.Office.Interop.Excel.Workbook
        '        Dim hoja_trabajo As Microsoft.Office.Interop.Excel.Worksheet
        '        aplicacion = New Microsoft.Office.Interop.Excel.Application()
        '        libros_trabajo = aplicacion.Workbooks.Add()
        '        hoja_trabajo = DirectCast(libros_trabajo.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
        '        'Recorremos el DataGridView rellenando la hoja de trabajo

        '        Dim columnsCount As Integer = DGPersonas.Columns.Count
        '        For i As Integer = 0 To DGPersonas.Rows.Count - 1
        '            For j As Integer = 0 To DGPersonas.Columns.Count - 1

        '                If i = 0 Then 'pintamos cabecera
        '                    hoja_trabajo.Cells(i + 1, j + 1) = DGPersonas.Columns(j).HeaderText
        '                    hoja_trabajo.Cells(i + 2, j + 1) = DGPersonas.Rows(i).Cells(j).Value.ToString()
        '                Else 'pintamos datos
        '                    hoja_trabajo.Cells(i + 2, j + 1) = DGPersonas.Rows(i).Cells(j).Value.ToString()
        '                End If
        '            Next
        '        Next
        '        libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal)
        '        libros_trabajo.Close(True)
        '        MessageBox.Show("Éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None)
        '        aplicacion.Quit()

        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

#End Region

#Region "Personas por Cede"
    'Carga DataGridView
    Sub CargarDGP(ByVal d As DataGridView)
        objPersona.GetPersonaAll(d)
    End Sub

    Private Sub Cedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBCede)
        CargarDGP(DGPersonas1)
        CBCede.Enabled = True

    End Sub

    Private Sub CBCede_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCede.SelectionChangeCommitted
        If Vacio_Combo(CBCede) = False Then
            objPersona.BuscarPorCede(CBCede.SelectedValue, DGPersonas1)
        End If
    End Sub


    Private Sub TBuscar1_TextChanged(sender As Object, e As EventArgs) Handles TBuscar1.TextChanged
        objPersona.Buscar(TBuscar1.Text, DGPersonas1)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        CargarDGP(DGPersonas1)
        CBCede.ResetText()

    End Sub


    Private Sub BExcelC_Click(sender As Object, e As EventArgs) Handles BExcelC.Click

        If Vacio_Combo(CBCede) = True Then
            MsgBox("Debe seleccionar una Cede", MsgBoxStyle.Exclamation)
        Else
            Dim re As New PersonasPorCede
            Dim objPersona As EPersonas = New EPersonas(CInt(CBCede.SelectedValue))
            re.ShowDialog()
        End If
    End Sub


#End Region

#Region "Lideres"

    'Carga DataGridView
    Sub CargarDGL(ByVal d As DataGridView)
        objLider.GetLiderAll(d)
    End Sub

    Private Sub Lideres_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBLider)
        CargarDGL(DGLideres)
        CBLider.Enabled = True

    End Sub

    Private Sub CBLider_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBLider.SelectionChangeCommitted
        If Vacio_Combo(CBLider) = False Then
            objLider.BuscarLiderPorCede(CBLider.SelectedValue, DGLideres)
        End If
    End Sub


    Private Sub TBuscadorL_TextChanged(sender As Object, e As EventArgs) Handles TBuscadorL.TextChanged
        objLider.BuscarLideres(TBuscadorL.Text, DGLideres)
    End Sub


    Private Sub Label13_Click_1(sender As Object, e As EventArgs) Handles Label13.Click
        CargarDGL(DGLideres)
        CBLider.ResetText()

    End Sub


    Private Sub bexcelL_click(sender As Object, e As EventArgs) Handles BExcelL.Click

        Dim es As New PersonasPorLider
            es.ShowDialog()


    End Sub


#End Region

#Region "Bautizados"

    'Carga DataGridView
    Sub CargarDGb(ByVal d As DataGridView)
        objBaut.GetBautizadoAll(d)
    End Sub

    Private Sub Bautizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBBaut)
        CargarDGb(DGBautizado)
        CBBaut.Enabled = True

    End Sub

    Private Sub CBBaut_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBBaut.SelectionChangeCommitted
        If Vacio_Combo(CBBaut) = False Then
            objBaut.BuscarBautPorCede(CBBaut.SelectedValue, DGBautizado)
        End If
    End Sub


    Private Sub TBuscadorB_TextChanged(sender As Object, e As EventArgs) Handles TBuscadorB.TextChanged
        objBaut.Buscar(TBuscadorB.Text, DGBautizado)
    End Sub


    Private Sub Label12_Click_1(sender As Object, e As EventArgs) Handles Label12.Click
        CargarDGb(DGBautizado)
        CBBaut.ResetText()

    End Sub


    Private Sub BexcelB_click(sender As Object, e As EventArgs) Handles BExcelB.Click
        Dim ba As New PersonasPorBautiz
        ba.ShowDialog()

    End Sub


#End Region

#Region "Escuela de Vida"

    'Carga DataGridView
    Sub CargarDGE(ByVal d As DataGridView)
        objEscuela.GetEscuelaAll(d)
    End Sub

    Private Sub Escuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBCedeE)
        objEscuela.CargarCBO(CBModulo)
        CargarDGE(DGEscuela)

        CBCedeE.Enabled = True
        CBModulo.Enabled = True
    End Sub

    Private Sub CBEscuela_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCedeE.SelectionChangeCommitted
        If Vacio_Combo(CBCedeE) = False Then
            objEscuela.BuscarporCede(CBCedeE.SelectedValue, DGEscuela)
        End If
    End Sub

    Private Sub CBModuloSelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBModulo.SelectionChangeCommitted
        If Vacio_Combo(CBModulo) = False Then
            objEscuela.BuscarPorModulo(CBModulo.SelectedValue, CBCedeE.SelectedValue, DGEscuela)
        End If
    End Sub


    Private Sub TEscuela_TextChanged(sender As Object, e As EventArgs) Handles TEscuela.TextChanged
        objEscuela.Buscar(TEscuela.Text, DGEscuela)
        End
    End Sub

    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        CargarDGE(DGEscuela)
        CBCedeE.ResetText()
        CBModulo.ResetText()
    End Sub



    Private Sub bexcelE_click(sender As Object, e As EventArgs) Handles BExcelE.Click
        Dim es As New personasporescuela
        es.ShowDialog

    End Sub

#End Region

End Class