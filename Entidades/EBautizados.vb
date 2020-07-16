Imports Microsoft.VisualBasic

Public Class EBautizados
    Private _id_bautizado As Integer
    Private _iglesia
    Private _lugar
    Private _año
    Private _estado

    Public Shared temp
    'Declara un objeto de tipo Entities
    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"

    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe un argumento
    Public Sub New(ByVal te As Integer)
        Temporal = te
    End Sub

    'Define un contructor que recibe argumentos
    Public Sub New(ByVal est As String, ByVal igle As String, ByVal lugarr As String, ByVal añoo As Integer)
        _estado = est
        _iglesia = igle
        _lugar = lugarr
        _año = añoo
    End Sub

#End Region

#Region "Set/Get"
    'Get y Set de Temporal
    Property Temporal As Integer
        Get
            Return temp
        End Get
        Set(value As Integer)
            temp = value
        End Set
    End Property

    'Get y Set de id_bautizado
    Property Id_bautizado As Integer
        Get
            Return _id_bautizado
        End Get
        Set(value As Integer)
            _id_bautizado = value
        End Set
    End Property

    'Get y Set de estado
    Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    'Get y Set de Iglesia
    Property Iglesia As String
        Get
            Return _iglesia
        End Get
        Set(value As String)
            _iglesia = value
        End Set
    End Property

    'Get y Set de lugar
    Property Lugar As String
        Get
            Return _lugar
        End Get
        Set(value As String)
            _lugar = value
        End Set
    End Property

    'Get y Set de Año
    Property Año As Integer
        Get
            Return _año
        End Get
        Set(value As Integer)
            _año = value
        End Set
    End Property
#End Region

#Region "Procedimientos"
    'Agrega un nuevo Bautizado
    Function GuardarBautizado() As Boolean

        Try
            Using ctx As New BDSystemElimEntities
                Dim pbautiz As Bautizados = New Bautizados
                With pbautiz

                    .estado = estado
                    .iglesia = Iglesia
                    .lugar = Lugar
                    .año = Año

                End With
                ctx.Bautizados.Add(pbautiz)
                ctx.SaveChanges()
                _id_bautizado = pbautiz.id_bautizado
                Return True

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Lista TODOS los datos en un DataGridView cargados en Bautizados
    Public Sub GetBautizadoAll(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona
                             Order By p.id_persona Where p.estado = 1 And p.Bautizados.estado = "Si"
                             Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Edad = (Today.Year - Year(p.fecha_nac)), Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido,
                                         IglesiaDondeSeBautizo = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en  Bautizados por cede
    Public Sub BuscarBautPorCede(ByVal id As Integer, ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona
                             Order By p.id_persona Where p.estado = 1 And p.Bautizados.estado = "Si" And p.cede_id = id
                             Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Edad = (Today.Year - Year(p.fecha_nac)), Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido,
                                         IglesiaDondeSeBautizo = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Bautizados por Celula
    Public Sub BuscarBautPorCelula(ByVal id As Integer, ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona
                             Order By p.id_persona Where p.estado = 1 And p.Bautizados.estado = "Si" And p.celula_id = id
                             Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Edad = (Today.Year - Year(p.fecha_nac)), Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido,
                                         IglesiaDondeSeBautizo = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Bautizados por cede y celula
    Sub BuscarPorCedeyCelula(ByVal idE As Integer, ByVal idC As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Persona
                         Where p.cede_id = idE And p.celula_id = idC And p.estado = 1
                         Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Edad = (Today.Year - Year(p.fecha_nac)), Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido,
                                         IglesiaDondeSeBautizo = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listapers
    End Sub

    'Lista los datos en un DataGridView cargados en Bautizados a partir de datos ingresados por teclado
    Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Persona
                        Where p.nombre.StartsWith(a) Or p.apellido.StartsWith(a) Or p.CedeDePersona.descripcion.StartsWith(a) Or p.CelulaDePersona.nombre.StartsWith(a) And p.estado = 1 And p.Bautizados.estado = "Si"
                        Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Edad = (Today.Year - Year(p.fecha_nac)), Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido,
                                         IglesiaDondeSeBautizo = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listaEmp
    End Sub
#End Region

End Class
