Public Class EReporte
    Private _id_reporte As Integer
    Private _red_id
    Private _celula_id
    Private _lider
    Private _aux
    Private _domicilio
    Private _fecha
    Private _dia
    Private _hora
    Private _leccion
    Private _miembros_pres
    Private _visitantes
    Private _total_pres
    Private _discipulados
    Private _bautizados
    Private _almasgan
    Private _miembros_aus
    Private _observ

    Public Shared actual
    Public Shared actualFecha
    'Declara un objeto de tipo Entities

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"

    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe un argumento
    Public Sub New(ByVal act As Integer)
        Actuall = act
    End Sub

    'Define un contructor que recibe un argumento
    Public Sub New(ByVal actu As Date)
        ActuallFecha = actu
    End Sub

    'Define un contructor que recibe argumentos

    Public Sub New(ByVal redd As Integer, ByVal celula As Integer, ByVal lider As String, ByVal aux As String, ByVal domicilio As String, ByVal fecha As Date, ByVal dia As String, ByVal hora As String, ByVal lecc As String, ByVal miembrosPres As String, ByVal visitante As String, ByVal total As String, ByVal discip As String, ByVal baut As String, ByVal almasga As String, ByVal miembrosaus As String, ByVal obser As String)
        _red_id = redd
        _celula_id = celula
        _lider = lider
        _aux = aux
        _domicilio = domicilio
        _fecha = fecha
        _dia = dia
        _hora = hora
        _leccion = lecc
        _miembros_pres = miembrosPres
        _visitantes = visitante
        _total_pres = total
        _discipulados = discip
        _bautizados = baut
        _almasgan = almasga
        _miembros_aus = miembrosaus
        _observ = obser
    End Sub

#End Region

#Region "Set/Get"

    'Get y Set de ActualFecha
    Property ActuallFecha As Date
        Get
            Return actualFecha
        End Get
        Set(value As Date)
            actualFecha = value
        End Set
    End Property

    'Get y Set de ACTUAL
    Property Actuall As Integer
        Get
            Return actual
        End Get
        Set(value As Integer)
            actual = value
        End Set
    End Property

    'Get y Set de id_reporte
    Property Id_reporte As Integer
        Get
            Return _id_reporte
        End Get
        Set(value As Integer)
            _id_reporte = value
        End Set
    End Property

    'Get y Set de Red
    Property Red As Integer
        Get
            Return _red_id
        End Get
        Set(value As Integer)
            _red_id = value
        End Set
    End Property

    'Get y Set de Celula
    Property Celula As Integer
        Get
            Return _celula_id
        End Get
        Set(value As Integer)
            _celula_id = value
        End Set
    End Property

    'Get y Set de lider
    Property Lider As String
        Get
            Return _lider
        End Get
        Set(value As String)
            _lider = value
        End Set
    End Property

    'Get y Set de auxiliar
    Property Auxiliar As String
        Get
            Return _aux
        End Get
        Set(value As String)
            _aux = value
        End Set
    End Property

    'Get y Set de Domicilio
    Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            _domicilio = value
        End Set
    End Property

    'Get y Set de Fecha
    Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    'Get y Set de Dia
    Property Dia As String
        Get
            Return _dia
        End Get
        Set(value As String)
            _dia = value
        End Set
    End Property

    'Get y Set de Hora
    Property Hora As String
        Get
            Return _hora
        End Get
        Set(value As String)
            _hora = value
        End Set
    End Property


    'Get y Set de MiembrosPres
    Property MiembrosPres As String
        Get
            Return _miembros_pres
        End Get
        Set(value As String)
            _miembros_pres = value
        End Set
    End Property

    'Get y Set de Visitantes
    Property Visitantes As String
        Get
            Return _visitantes
        End Get
        Set(value As String)
            _visitantes = value
        End Set
    End Property

    'Get y Set de Leccion
    Property Leccion As String
        Get
            Return _leccion
        End Get
        Set(value As String)
            _leccion = value
        End Set
    End Property

    'Get y Set de total
    Property Total As String
        Get
            Return _total_pres
        End Get
        Set(value As String)
            _total_pres = value
        End Set
    End Property

    'Get y Set de dicispulados
    Property Discipulados As String
        Get
            Return _discipulados
        End Get
        Set(value As String)
            _discipulados = value
        End Set
    End Property

    'Get y Set de bautizados
    Property Bautizados As String
        Get
            Return _bautizados
        End Get
        Set(value As String)
            _bautizados = value
        End Set
    End Property

    'Get y Set de almas ganadas
    Property AlmasGanadas As String
        Get
            Return _almasgan
        End Get
        Set(value As String)
            _almasgan = value
        End Set
    End Property


    'Get y Set de miembrosaus
    Property MiembrosAus As String
        Get
            Return _miembros_aus
        End Get
        Set(value As String)
            _miembros_aus = value
        End Set
    End Property


    'Get y Set de observaciones
    Property Observaciones As String
        Get
            Return _observ
        End Get
        Set(value As String)
            _observ = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

    'Lista los datos en un ComboBox cargados en Reporte
    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaReporte = (From c In ctx.Reporte
                            Where c.id_reporte
                            Select c).ToList
        With combo
            .DataSource = listaReporte
            .DisplayMember = "id_reporte"
            .ValueMember = "id_reporte"
            .SelectedValue = -1
        End With

    End Sub

    'Lista TODOS los datos en un DataGridView cargados en Reporte
    Public Sub GetReporteAll(ByVal grid As DataGridView)

        Dim listaCelulas = (From p In ctx.Reporte
                            Order By p.id_reporte
                            Select ID = p.id_reporte, Red = p.Red.nombre, Celula = p.Celula.nombre, Lider = p.lider, Auxiliar = p.aux, Domicilio = p.domicilio, Fecha = p.fecha, Dia = p.dia, Hora = p.hora, MiembrosPresentes = p.miembros_pres, Visitantes = p.visitantes, TotalPresentes = p.total_pres, Discipulados = p.discipulados, Bautizados = p.bautizados, AlmasGanadas = p.almasganadas, MiembrosAusentes = p.miembros_ausent, Observaciones = p.observacion).ToList

        grid.DataSource = listaCelulas

    End Sub

    'Lista los datos en un DataGridView cargados en Reporte para modificar
    Public Sub GetReporteModif(ByVal grid As DataGridView)

        Dim listaCelulas = (From p In ctx.Reporte
                            Order By p.id_reporte
                            Select ID = p.id_reporte, Red = p.Red.nombre, Celula = p.Celula.nombre, Lider = p.lider, Auxiliar = p.aux, Domicilio = p.domicilio, Fecha = p.fecha, Dia = p.dia, Hora = p.hora, MiembrosPresentes = p.miembros_pres, Visitantes = p.visitantes, TotalPresentes = p.total_pres, Discipulados = p.discipulados, Bautizados = p.bautizados, AlmasGanadas = p.almasganadas, MiembrosAusentes = p.miembros_ausent, Observaciones = p.observacion).ToList

        grid.DataSource = listaCelulas

    End Sub

    'Agrega un nuevo Reporte
    Function GuardarReporte() As Boolean

        Try
            Using ctx As New BDSystemElimEntities
                Dim preporte As Reporte = New Reporte
                With preporte
                    .red_id = Red
                    .celula_id = Celula
                    .lider = Lider
                    .aux = Auxiliar
                    .domicilio = Domicilio
                    .fecha = Fecha
                    .dia = Dia
                    .hora = Hora
                    .leccion = Leccion
                    .miembros_pres = MiembrosPres
                    .visitantes = Visitantes
                    .total_pres = Total
                    .discipulados = Discipulados
                    .bautizados = Bautizados
                    .almasganadas = AlmasGanadas
                    .miembros_ausent = MiembrosAus
                    .observacion = Observaciones

                End With
                ctx.Reporte.Add(preporte)
                ctx.SaveChanges()
                _id_reporte = preporte.id_reporte
                Return True

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    'Modifica datos de un Reporte
    Public Function Modificar(ByVal id As Integer, ByVal redd As Integer, ByVal celula As Integer, ByVal lider As String, ByVal aux As String, ByVal domicilio As String, ByVal fecha As Date, ByVal dia As String, ByVal hora As String, ByVal leccion As String, ByVal miembrosPres As String, ByVal visitante As String, ByVal total As String, ByVal discip As String, ByVal baut As String, ByVal almasga As String, ByVal miembrosaus As String, ByVal obser As String)

        Dim modif = (From q In ctx.Reporte
                     Where (q.id_reporte = id)
                     Select q).First

        modif.red_id = redd
        modif.celula_id = celula
        modif.lider = lider
        modif.aux = aux
        modif.domicilio = domicilio
        modif.fecha = fecha
        modif.dia = dia
        modif.hora = hora
        modif.miembros_pres = miembrosPres
        modif.visitantes = visitante
        modif.total_pres = total
        modif.discipulados = discip
        modif.bautizados = baut
        modif.almasganadas = almasga
        modif.miembros_ausent = miembrosaus
        modif.observacion = obser

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Devuelve el id del ultimo Reporte
    Public Function UltimoReporte()
        Try
            Using DBF As New BDSystemElimEntities
                Dim qultimo = (From q In DBF.Reporte Select q).ToList
                Dim contador As Integer = qultimo.Count

                If contador = 0 Then
                    Return 0
                Else
                    Return qultimo.Item(contador - 1).id_reporte
                End If
            End Using
        Catch Ex As Exception
            Return MessageBox.Show("ERROR ultimo reporte")
        End Try
    End Function

    'Busca Reporte a partir de su id y lo devuelve
    Function ObtenerReporte(ByVal id As Integer) As Reporte
        Dim obtn = (From p In ctx.Reporte
                    Where p.id_reporte = id
                    Select p).First
        Return obtn
    End Function

    'Lista los datos en un DataGridView cargados en Reporte a partir de datos ingresados por teclado
    Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Reporte
                        Where p.Red.nombre.StartsWith(a) Or p.Celula.nombre.StartsWith(a) Or p.aux.StartsWith(a) Or p.lider.StartsWith(a) Or p.domicilio.StartsWith(a)
                        Select Red = p.Red.nombre, Celula = p.Celula.nombre, Lider = p.lider, Auxiliar = p.aux, Domicilio = p.domicilio, Fecha = p.fecha, Dia = p.dia, Hora = p.hora, MiembrosPresentes = p.miembros_pres, Visitantes = p.visitantes, TotalPresentes = p.total_pres, Discipulados = p.discipulados, Bautizados = p.bautizados, AlmasGanadas = p.almasganadas, MiembrosAusentes = p.miembros_ausent, Observaciones = p.observacion).ToList

        grid.DataSource = listaEmp
    End Sub

    'Lista los datos en un DataGridView cargados en Reporte por red
    Sub BuscarPorRed(ByVal id As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Reporte
                         Where p.red_id = id
                         Select Red = p.Red.nombre, Celula = p.Celula.nombre, Lider = p.lider, Auxiliar = p.aux, Domicilio = p.domicilio, Fecha = p.fecha, Dia = p.dia, Hora = p.hora, MiembrosPresentes = p.miembros_pres, Visitantes = p.visitantes, TotalPresentes = p.total_pres, Discipulados = p.discipulados, Bautizados = p.bautizados, AlmasGanadas = p.almasganadas, MiembrosAusentes = p.miembros_ausent, Observaciones = p.observacion).ToList

        grid.DataSource = listapers

    End Sub

    'Lista los datos en un DataGridView cargados en Reporte por celula
    Sub BuscarPorCelula(ByVal id As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Reporte
                         Where p.celula_id = id
                         Select Red = p.Red.nombre, Celula = p.Celula.nombre, Lider = p.lider, Auxiliar = p.aux, Domicilio = p.domicilio, Fecha = p.fecha, Dia = p.dia, Hora = p.hora, MiembrosPresentes = p.miembros_pres, Visitantes = p.visitantes, TotalPresentes = p.total_pres, Discipulados = p.discipulados, Bautizados = p.bautizados, AlmasGanadas = p.almasganadas, MiembrosAusentes = p.miembros_ausent, Observaciones = p.observacion).ToList

        grid.DataSource = listapers

    End Sub

    'Lista los datos en un DataGridView cargados en Reporte a partir de un rango de fechas
    Sub BuscarPorFechas(ByVal ini As Date, ByVal fin As Date, ByVal grid As DataGridView)
        Dim listaF = (From p In ctx.Reporte
                      Where p.fecha >= ini And p.fecha <= fin
                      Select Red = p.Red.nombre, Celula = p.Celula.nombre, Lider = p.lider, Auxiliar = p.aux, Domicilio = p.domicilio, Fecha = p.fecha, Dia = p.dia, Hora = p.hora, MiembrosPresentes = p.miembros_pres, Visitantes = p.visitantes, TotalPresentes = p.total_pres, Discipulados = p.discipulados, Bautizados = p.bautizados, AlmasGanadas = p.almasganadas, MiembrosAusentes = p.miembros_ausent, Observaciones = p.observacion).ToList

        grid.DataSource = listaF

    End Sub

#End Region

End Class
