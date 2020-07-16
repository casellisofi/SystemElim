Public Class Administracion

    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Personas"

    Private Sub BAddPers_Click(sender As Object, e As EventArgs) Handles BAddPers.Click
        Dim pers As New AgregarPersona
        pers.ShowDialog()
    End Sub

    Private Sub BModPers_Click(sender As Object, e As EventArgs) Handles BModPers.Click
        Dim pers As New ModificarPersona
        pers.ShowDialog()

    End Sub


    Private Sub BBajaPers_Click(sender As Object, e As EventArgs) Handles BBajaPers.Click
        Dim baja As New BajaPersonas
        baja.ShowDialog()
    End Sub

    Private Sub BLPersona_Click(sender As Object, e As EventArgs) Handles BLPersona.Click
        Dim list As New ListadodePersonas
        list.ShowDialog()
    End Sub


#End Region

#Region "Celulas"

    Private Sub BAddCelula_Click(sender As Object, e As EventArgs) Handles BAddCelula.Click
        Dim cel As New AgregarCelula
        cel.ShowDialog()
    End Sub

    Private Sub BModCelula_Click(sender As Object, e As EventArgs) Handles BModCelula.Click
        Dim celu As New ModificarCelula
        celu.ShowDialog()

    End Sub

    Private Sub BBajaCelula_Click(sender As Object, e As EventArgs) Handles BBajaCelula.Click
        Dim bajaC As New BajaCelula
        bajaC.ShowDialog()

    End Sub

    Private Sub BLCelula_Click(sender As Object, e As EventArgs) Handles BLCelula.Click
        Dim list As New ListadoDeCelulas
        list.ShowDialog()

    End Sub

#End Region

#Region "Areas"

    Private Sub BAddArea_Click(sender As Object, e As EventArgs) Handles BAddArea.Click
        Dim area As New AgregarArea
        area.ShowDialog()
    End Sub


    Private Sub BModArea_Click(sender As Object, e As EventArgs) Handles BModArea.Click
        Dim ar As New Modificar_Area
        ar.ShowDialog()

    End Sub

    Private Sub BBajaArea_Click(sender As Object, e As EventArgs) Handles BBajaArea.Click
        Dim bajaA As New BajaArea
        bajaA.ShowDialog()

    End Sub


    Private Sub BLArea_Click(sender As Object, e As EventArgs) Handles BLArea.Click
        Dim LIST As New ListadoDeAreas
        LIST.ShowDialog()

    End Sub


#End Region


    Private Sub BCant_Click(sender As Object, e As EventArgs) Handles BCant.Click
        Dim cant As New Cantidades
        cant.ShowDialog()
    End Sub

    Private Sub BReportCel_Click(sender As Object, e As EventArgs) Handles BReportCel.Click
        Dim re As New ReporteCelula
        re.ShowDialog()

    End Sub

    Private Sub Blistadorepor_Click(sender As Object, e As EventArgs) Handles Blistadorepor.Click
        Dim re As New ListadoReportes
        re.ShowDialog()

    End Sub

    Private Sub BEstad_Click(sender As Object, e As EventArgs) Handles BEstad.Click

    End Sub
End Class