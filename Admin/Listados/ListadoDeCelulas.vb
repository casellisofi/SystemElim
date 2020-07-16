Public Class ListadoDeCelulas


    Dim objCede As New ECedes
    Dim objCelula As New ECelulas
    Dim objLider As New ELideres
    Dim objEscuela As New EEscuela
    Dim objPersona As New EPersonas
    Dim objBaut As New EBautizados

#Region "Listado de Celulas"

    'Carga DataGridView
    Sub CargarDG(ByVal d As DataGridView)
        objCelula.GetCelulaAll(d)
    End Sub

    Private Sub TBuscador_TextChanged(sender As Object, e As EventArgs) Handles TBuscador.TextChanged
        objCelula.BuscarCelula(TBuscador.Text, DGCelulas)
    End Sub

    Private Sub Celulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDG(DGCelulas)
    End Sub


    Private Sub BExcelP_Click(sender As Object, e As EventArgs) Handles BExcelP.Click
        Dim ce As New CelulaTotal
        ce.ShowDialog()
    End Sub


#End Region

#Region "Celulas por Cede"
    'Carga DataGridView
    Sub CargarDGP(ByVal d As DataGridView)
        objCelula.GetCelulaAll(d)
    End Sub

    Private Sub Cedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCede.CargarCBO(CBCede)
        CargarDGP(DGCelulas1)
        CBCede.Enabled = True
    End Sub

    Private Sub CBCede_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCede.SelectionChangeCommitted
        If Vacio_Combo(CBCede) = False Then
            objCelula.BuscarPorCede(CBCede.SelectedValue, DGCelulas1)
        End If
    End Sub


    Private Sub TBuscadorC_TextChanged(sender As Object, e As EventArgs) Handles TBuscadorC.TextChanged
        objCelula.BuscarCelula(TBuscadorC.Text, DGCelulas1)
    End Sub

    Private Sub LMostrar_Click(sender As Object, e As EventArgs) Handles LMostrar.Click
        CargarDGP(DGCelulas1)
        CBCede.ResetText()
    End Sub

    Private Sub BExcelC_Click(sender As Object, e As EventArgs) Handles BExcelC.Click
        If Vacio_Combo(CBCede) = True Then
            MsgBox("Debe seleccionar una Cede", MsgBoxStyle.Exclamation)
        Else
            Dim cel As ECelulas = New ECelulas(CInt(CBCede.SelectedValue))
            Dim es As New CelulasPorCede
            es.ShowDialog()
        End If
    End Sub

#End Region

#Region "Lideres"

    'Carga DataGridView
    Sub CargarDGL(ByVal d As DataGridView)
        objLider.GetLiderCelulaAll(d)
    End Sub

    Private Sub Lideres_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBCedeL)
        objCelula.CargarCBO(CBCelulaL)
        CargarDGL(DGLideres)
        CBCedeL.Enabled = True

    End Sub


    Private Sub CBCedeL_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCedeL.SelectionChangeCommitted
        If Vacio_Combo(CBCedeL) = False Then
            objLider.BuscarLiderCelulaPorCede(CBCedeL.SelectedValue, DGLideres)
        End If

    End Sub

    Private Sub CBCelulaL_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCelulaL.SelectionChangeCommitted
        If Vacio_Combo(CBCedeL) = True Then
            MsgBox("Primero debe seleccionar una Cede", MsgBoxStyle.Exclamation)
        ElseIf Vacio_Combo(CBCelulaL) = False Then
            objLider.BuscarLiderCelulaPorCedeyCelula(CBCedeL.SelectedValue, CBCelulaL.SelectedValue, DGLideres)
        End If

    End Sub

    Private Sub TBuscadorL_TextChanged(sender As Object, e As EventArgs) Handles TBuscadorL.TextChanged
        objLider.BuscarLiderCelula(TBuscadorL.Text, DGLideres)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        CargarDGL(DGLideres)
        CBCedeL.ResetText()

    End Sub

    Private Sub BExcelL_Click(sender As Object, e As EventArgs) Handles BExcelL.Click
        Dim cel As New CelulasPorLider
        cel.showdialog
    End Sub

#End Region

#Region "Bautizados"

    'Carga DataGridView
    Sub CargarDGb(ByVal d As DataGridView)
        objBaut.GetBautizadoAll(d)
    End Sub

    Private Sub Bautizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCede.CargarCBO(CBCedeB)
        CargarDGb(DGBaut)
        CBCedeB.Enabled = True
        objCelula.CargarCBO(CBCelulaB)

    End Sub


    Private Sub CBCedeB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCedeB.SelectionChangeCommitted
        If Vacio_Combo(CBCedeB) = False Then
            objBaut.BuscarBautPorCede(CBCedeB.SelectedValue, DGBaut)
        End If
    End Sub

    Private Sub CBCelulaB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCelulaB.SelectionChangeCommitted
        If Vacio_Combo(CBCedeB) = True Then
            MsgBox("Primero debe seleccionar una Cede", MsgBoxStyle.Exclamation)
        ElseIf Vacio_Combo(CBCelulaB) = False Then
            objBaut.BuscarPorCedeyCelula(CBCedeB.SelectedValue, CBCelulaB.SelectedValue, DGBaut)
        End If
    End Sub

    Private Sub TBuscadorB_TextChanged(sender As Object, e As EventArgs) Handles TBuscadorB.TextChanged
        objBaut.Buscar(TBuscadorB.Text, DGBaut)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        CargarDGb(DGBaut)
        CBCedeB.ResetText()
        CBCelulaB.ResetText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Vacio_Combo(CBCelulaB) = True Then
            MsgBox("Debe seleccionar una Celula", MsgBoxStyle.Exclamation)
        Else
            Dim cel As EBautizados = New EBautizados(CInt(CBCelulaB.SelectedValue))
            Dim es As New CelulasPorBautizados
            es.ShowDialog()
        End If
    End Sub

#End Region

#Region "Escuela de Vida"

    'Carga DataGridView
    Sub CargarDGE(ByVal d As DataGridView)
        objEscuela.GetEscuelaAll(d)
    End Sub

    Private Sub Escuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objCelula.CargarCBO(CBCelulaE)
        objEscuela.CargarCBO(CBModulo)
        CargarDGE(DGEscuela)

        CBCelulaE.Enabled = True
        CBModulo.Enabled = True
    End Sub

    Private Sub CBCelulaE_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCelulaE.SelectionChangeCommitted
        If Vacio_Combo(CBCelulaE) = False Then
            objEscuela.BuscarPorCelula(CBCelulaE.SelectedValue, DGEscuela)
        End If
    End Sub

    Private Sub CBModuloSelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBModulo.SelectionChangeCommitted
        If Vacio_Combo(CBCelulaE) = True Then
            MsgBox("Primero debe seleccionar una Celula", MsgBoxStyle.Exclamation)

        ElseIf Vacio_Combo(CBModulo) = False Then
            objEscuela.BuscarPorModuloyCelula(CBModulo.SelectedValue, CBCelulaE.SelectedValue, DGEscuela)
        End If
    End Sub

    Private Sub TEscuela_TextChanged(sender As Object, e As EventArgs) Handles TEscuela.TextChanged
        objEscuela.Buscar(TEscuela.Text, DGEscuela)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        CargarDGE(DGEscuela)
        CBCelulaE.ResetText()
        CBModulo.ResetText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Vacio_Combo(CBCelulaE) = True Then
            MsgBox("Debe seleccionar una Celula", MsgBoxStyle.Exclamation)
        Else
            Dim cel As ECelulas = New ECelulas(CInt(CBCelulaE.SelectedValue))
            Dim es As New CelulasPorEscuela
            es.ShowDialog()
        End If
    End Sub



#End Region

End Class