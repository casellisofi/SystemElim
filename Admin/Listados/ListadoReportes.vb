Public Class ListadoReportes
    Dim objRepo As New EReporte
    Dim objRed As New ERedes
    Dim objCelula As New ECelulas

    'Carga DataGridView
    Sub CargarDGA(ByVal d As DataGridView)
        objRepo.GetReporteAll(d)
    End Sub

    'Carga ComboBox de Red
    Sub CargarCBO(ByVal d As ComboBox)
        objRed.CargarCBO(d)
    End Sub

    'Carga ComboBox de Celula
    Sub CargarCBOC(ByVal d As ComboBox)
        objCelula.CargarCBO(d)
    End Sub


#Region "Listado"

    Private Sub Allrepor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDGA(DGAllRepor)
    End Sub

    Private Sub BExcelP_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        Dim rep As New ListadoTotalReporte
        rep.ShowDialog()

    End Sub

    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objRepo.Buscar(TBuscador.Text, DGAllRepor)
    End Sub

    Private Sub DGAllRepor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAllRepor.CellDoubleClick
        Dim i As Integer = DGAllRepor.CurrentRow.Index
        Dim cod As Integer = DGAllRepor.Item(0, i).Value

        Dim re As New Reporte
        Dim rep As EReporte = New EReporte(cod)
        re.ShowDialog()

    End Sub

#End Region

#Region "por Red"

    Private Sub red_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDGA(DGRed)
        CargarCBO(CBRed)

    End Sub
    Private Sub TBuscar1_TextChanged(sender As Object, e As EventArgs) Handles TBuscar1.TextChanged
        objRepo.Buscar(TBuscar1.Text, DGRed)
    End Sub

    Private Sub CBRed_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles CBRed.SelectionChangeCommitted
        If Vacio_Combo(CBRed) = False Then
            objRepo.BuscarPorRed(CBRed.SelectedValue, DGRed)
        End If
    End Sub

    Private Sub DGred_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRed.CellDoubleClick
        Dim i As Integer = DGRed.CurrentRow.Index
        Dim cod As Integer = DGRed.Item(0, i).Value

        Dim re As New Reporte
        Dim rep As EReporte = New EReporte(cod)
        re.ShowDialog()

    End Sub

    Private Sub BImpRed_Click(sender As Object, e As EventArgs) Handles BImpRed.Click
        If Vacio_Combo(CBRed) = True Then
            MsgBox("Debe seleccionar una Red", MsgBoxStyle.Exclamation)

        Else
            Dim red As ERedes = New ERedes(CInt(CBRed.SelectedValue))
            Dim re As New ListadoPorRed
            re.ShowDialog()
        End If
    End Sub
#End Region

#Region "por Celula"

    Private Sub TBuscadorL_TextChanged(sender As Object, e As EventArgs) Handles TbuscadorL.TextChanged
        objRepo.Buscar(TbuscadorL.Text, DGcelula)
    End Sub

    Private Sub CBcelula_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCelula.SelectionChangeCommitted
        If Vacio_Combo(CBCelula) = False Then
            objRepo.BuscarPorCelula(CBCelula.SelectedValue, DGcelula)
        End If
    End Sub

    Private Sub Celula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarCBOC(CBCelula)
        CargarDGA(DGcelula)

    End Sub

    Private Sub DGcelula_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGcelula.CellDoubleClick
        Dim i As Integer = DGcelula.CurrentRow.Index
        Dim cod As Integer = DGcelula.Item(0, i).Value

        Dim re As New Reporte
        Dim rep As EReporte = New EReporte(cod)
        re.ShowDialog()

    End Sub

    Private Sub BImpCel_Click(sender As Object, e As EventArgs) Handles BImpCel.Click
        If Vacio_Combo(CBCelula) = True Then
            MsgBox("Debe seleccionar una Celula", MsgBoxStyle.Exclamation)
        Else
            Dim red As ECelulas = New ECelulas(CInt(CBCelula.SelectedValue))
            Dim re As New ListadoPorCelula
            re.ShowDialog()
        End If
    End Sub




#End Region

#Region "por Fechas"
    Private Sub Fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDGA(DTFecha)
    End Sub

    Private Sub Dtfecha_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTFecha.CellDoubleClick
        Dim i As Integer = DTFecha.CurrentRow.Index
        Dim cod As Integer = DTFecha.Item(0, i).Value

        Dim re As New Reporte
        Dim rep As EReporte = New EReporte(cod)
        re.ShowDialog()

    End Sub


    Private Sub DTHasta_ValueChanged(sender As Object, e As EventArgs) Handles DTHasta.ValueChanged
        Dim inicio As New Date(DTDesde.Value.Year, DTDesde.Value.Month, DTDesde.Value.Day)
        Dim fin As New Date(DTHasta.Value.Year, DTHasta.Value.Month, DTHasta.Value.Day)

        If inicio < fin Then
            objRepo.BuscarPorFechas(inicio, fin, DTFecha)
        Else
            MsgBox("Ingrese un rango de fechas valido")
        End If
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        objRepo.Buscar(TextBox1.Text, DTFecha)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim inicio As New Date(DTDesde.Value.Year, DTDesde.Value.Month, DTDesde.Value.Day)
        Dim fin As New Date(DTHasta.Value.Year, DTHasta.Value.Month, DTHasta.Value.Day)

        If inicio < fin Then
            Dim fecha As New Date(DTDesde.Value.Year, DTDesde.Value.Month, DTDesde.Value.Day)

            Dim red As EReporte = New EReporte(fecha)
            Dim re As New ListadoPorFecha
            re.ShowDialog()
        Else
            MsgBox("Ingrese un rango de fechas valido")

        End If
    End Sub

    Private Sub Fechas_Click(sender As Object, e As EventArgs) Handles Fechas.Click

    End Sub




#End Region

End Class