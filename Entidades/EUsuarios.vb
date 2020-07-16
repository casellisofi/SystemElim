Imports Microsoft.VisualBasic

'Clase de la entidad Cliente

Public Class EUsuarios
    Private _id_usuario As Integer
    Private _nombre
    Private _contraseña
    Private _rol_id

    'Declara un objeto de tipo Entities
    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"
    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe argumentos

    Public Sub New(ByVal nom As String, ByVal cont As String, ByVal rol As Integer)
        Nombre = nom
        Contraseña = cont
        rol = rol
    End Sub

#End Region

#Region "Set/Get"

    'Get y Set de id_usuario
    Property Id_usuario As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    'Get y Set de nombre
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    'Get y Set de contraseña
    Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    'Get y Set de rol
    Property Rol As Integer
        Get
            Return _rol_id
        End Get
        Set(value As Integer)
            _rol_id = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

    'Agrega un nuevo Usuario
    Function GuardarUsuario() As Boolean

        Try
            Using ctx As New BDSystemElimEntities
                Dim pusuario As Usuario = New Usuario
                With pusuario
                    .nombre = Nombre
                    .contraseña = Contraseña

                End With
                ctx.Usuario.Add(pusuario)
                ctx.SaveChanges()
                _id_usuario = pusuario.id_usuario
                Return True

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Devuelve verdadero si existe un Usuario con el nombre y contraseña recibido
    Function ExisteUsuario(ByVal nomb As String, ByVal cont As String) As Boolean

        Dim buscarUsua = (From p In ctx.Usuario
                          Where p.nombre = nomb And p.contraseña = cont
                          Select p).Count
        If buscarUsua = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Busca el Usuario que tenga el mismo nombre recibido como parametro y devuelve su id de rol
    Function BuscarUsuario(ByVal nomb As String) As Integer

        Dim buscarUsua = (From p In ctx.Usuario
                          Where p.nombre = nomb
                          Select p).First
        Return buscarUsua.rol_id
    End Function

#End Region

End Class

