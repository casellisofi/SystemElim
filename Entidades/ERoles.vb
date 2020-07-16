Imports Microsoft.VisualBasic

Public Class ERoles

    'Clase de la entidad Roles
    Private _id_rol As Integer
    Private _descripcion

    'Declara un objeto de tipo Entities

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

    'Get y Set de id_rol

    Property Id_rol As Integer
        Get
            Return _id_rol
        End Get
        Set(value As Integer)
            _id_rol = value
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

    'Lista los datos en un ComboBox cargados en Rol

    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaRol = (From c In ctx.Rol
                        Where c.id_rol >= 1
                        Select c).ToList
        With combo
            .DataSource = listaRol
            .DisplayMember = "descripcion"
            .ValueMember = "id_rol"
            .SelectedValue = -1
        End With

    End Sub

    'Busca el Rol que tenga el mismo id recibido como parametro y devuelve su id
    Function BuscarRoles(ByVal id As Integer) As Integer

        Dim buscarRol = (From p In ctx.Rol
                         Where p.id_rol = id
                         Select p).First
        Return buscarRol.id_rol
    End Function

End Class
