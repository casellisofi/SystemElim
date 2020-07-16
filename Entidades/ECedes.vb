Imports Microsoft.VisualBasic

Public Class ECedes
    Private _id_cede As Integer
    Private _descripcion
    Private _lider
    Private _auxiliar
    Private _mesInicio
    Private _añoInicio
    Private _estado

    'Declara un objeto de tipo Entities

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"

    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe argumentos
    Public Sub New(ByVal descrip As String, ByVal lider As Integer, ByVal aux As Integer, ByVal mesI As String, ByVal añoI As Integer)
        _descripcion = descrip
        _lider = lider
        _auxiliar = aux
        _mesInicio = mesI
        _añoInicio = añoI
        _estado = 1
    End Sub

#End Region

#Region "Set/Get"

    'Get y Set de id_cede
    Property Id_cede As Integer
        Get
            Return _id_cede
        End Get
        Set(value As Integer)
            _id_cede = value
        End Set
    End Property

    'Get y Set de descripcion
    Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    'Get y Set de lider
    Property Lider As Integer
        Get
            Return _lider
        End Get
        Set(value As Integer)
            _lider = value
        End Set
    End Property

    'Get y Set de auxiliar
    Property Auxiliar As Integer
        Get
            Return _auxiliar
        End Get
        Set(value As Integer)
            _auxiliar = value
        End Set
    End Property

    'Get y Set de mes de Inicio
    Property MesInicio As String
        Get
            Return _mesInicio

        End Get
        Set(value As String)
            _mesInicio = value
        End Set
    End Property


    'Get y Set de año de Inicio
    Property AñoInicio As Integer
        Get
            Return _añoInicio

        End Get
        Set(value As Integer)
            _añoInicio = value
        End Set
    End Property

#End Region

    'Lista los datos en un ComboBox cargados en Cede

    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaCede = (From c In ctx.Cede
                         Where c.id_cede >= 1 And c.estado = 1
                         Select c).ToList
        With combo
            .DataSource = listaCede
            .DisplayMember = "descripcion"
            .ValueMember = "id_cede"
            .SelectedValue = -1
        End With

    End Sub
End Class

