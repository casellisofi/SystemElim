Public Class ListadoDeAreas

    Dim objCede As New ECedes
    Dim objCelula As New ECelulas
    Dim objLider As New ELideres
    Dim objEscuela As New EEscuela
    Dim objPersona As New EPersonas
    Dim objArea As New EAreas

#Region "Listado de Areas"

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objArea.GetAreasAll(d)
    End Sub


    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objArea.Buscar(TBuscador.Text, DGAreas)
    End Sub

    Private Sub Areass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDG(DGAreas)
    End Sub

    Private Sub BExcelP_Click(sender As Object, e As EventArgs) Handles BExcelP.Click
        Dim ser As New AreasTotal
        ser.showdialog()
    End Sub

#End Region

#Region "Areas por Cede"
    'Carga DataGridView
    Sub CargarDGP(ByVal d As DataGridView)
        objArea.GetAreasAll(d)
    End Sub

    Private Sub Cedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBCede)
        CargarDGP(DGAreasC)
        CBCede.Enabled = True

    End Sub

    Private Sub CBCede_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCede.SelectionChangeCommitted
        If Vacio_Combo(CBCede) = False Then
            objArea.BuscarPorCede(CBCede.SelectedValue, DGAreasC)
        End If
    End Sub


    Private Sub TBuscar1_TextChanged(sender As Object, e As EventArgs) Handles TBuscar1.TextChanged
        objCelula.Buscar(TBuscar1.Text, DGAreasC)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        CargarDGP(DGAreasC)
        CBCede.ResetText()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Vacio_Combo(CBCede) = True Then
            MsgBox("Debe seleccionar una Cede", MsgBoxStyle.Exclamation)
        Else
            Dim cel As EAreas = New EAreas(CInt(CBCede.SelectedValue))
            Dim es As New AreasPorCede
            es.ShowDialog()
        End If
    End Sub


#End Region

#Region "Lideres"

    'Carga DataGridView
    Sub CargarDGL(ByVal d As DataGridView)
        objArea.GetLiderAreasAll(d)
    End Sub

    Private Sub Lideres_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBLider)
        CargarDGL(DGLideres)
        CBLider.Enabled = True

    End Sub

    Private Sub CBLider_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBLider.SelectionChangeCommitted
        If Vacio_Combo(CBLider) = False Then
            objArea.BuscarLiderAreaPorCede(CBLider.SelectedValue, DGLideres)
        End If
    End Sub


    Private Sub TBuscadorL_TextChanged(sender As Object, e As EventArgs) Handles TbuscadorL.TextChanged
        objArea.BuscarLiderArea(TbuscadorL.Text, DGLideres)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        CargarDGL(DGLideres)
        CBCede.ResetText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Disculpe, en este momento no se puede ejecutar, intente más tarde", MsgBoxStyle.Exclamation)
    End Sub


#End Region

End Class