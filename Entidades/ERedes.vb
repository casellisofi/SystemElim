Public Class ERedes

    Private _id_red As Integer
    Private _nombre
    Private _estado

    Public Shared id

    'Declara un objeto de tipo Entities

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"

    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe un argumento
    Public Sub New(ByVal id As Integer)
        IdActual = id
    End Sub

    'Define un contructor que recibe argumentos

    Public Sub New(ByVal descrip As String)
        _nombre = descrip
        _estado = 1

    End Sub

#End Region

#Region "Set/Get"

    'Get y Set de id_red
    Property Id_red As Integer
        Get
            Return _id_red
        End Get
        Set(value As Integer)
            _id_red = value
        End Set
    End Property

    'Get y Set de IDactual
    Property IdActual As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
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

    'Get y Set de año de Estado
    Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

    'Lista los datos en un ComboBox cargados en Redes
    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaCede = (From c In ctx.Red
                         Where c.id_red >= 0 And c.estado = 1
                         Select c).ToList
        With combo
            .DataSource = listaCede
            .DisplayMember = "nombre"
            .ValueMember = "id_red"
            .SelectedValue = -1
        End With
    End Sub

    'Lista los datos en un DataGridView cargados en Redes
    Public Sub GetRedesAll(ByVal grid As DataGridView)

        Dim listaRed = (From p In ctx.Red
                        Order By p.id_red Where p.estado = 1
                        Select ID = p.id_red, Nombre = p.nombre, Estado = p.estado).ToList

        grid.DataSource = listaRed

    End Sub

    'Agrega una nueva Red
    Function GuardarRed() As Boolean

        Try
            Using ctx As New BDSystemElimEntities
                Dim pred As Red = New Red
                With pred
                    .nombre = Nombre
                    .estado = 1

                End With
                ctx.Red.Add(pred)
                ctx.SaveChanges()
                _id_red = pred.id_red
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Busca Red partir de su id y lo devuelve
    Function ObtenerRed(ByVal id As Integer) As Red
        Dim obtn = (From p In ctx.Red
                    Where p.id_red = id And p.estado = 1
                    Select p).First
        Return obtn
    End Function


    ''Lista los datos en un DataGridView cargados en Area a partir de datos ingresados por teclado
    'Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
    '    Dim listaEmp = (From p In ctx.Area
    '                    Where p.estado = 1 And p.nombre.StartsWith(a) Or p.LiderArea.nombre.StartsWith(a) Or p.AuxiliarArea.nombre.StartsWith(a) Or p.Cede.descripcion.StartsWith(a) And p.estado = 1
    '                    Select ID = p.id_area, Nombre = p.nombre, Lider = p.LiderArea.nombre, Auxiliar = p.AuxiliarArea.nombre, Cede = p.Cede.descripcion).ToList

    '    grid.DataSource = listaEmp
    'End Sub


    'Cambia el estado de una Red
    Public Function Activar_Desactivar(ByVal p_id As Integer, ByVal estad As Integer)
        Dim objborrar = (From q In ctx.Red Where (q.id_red = p_id) Select q).First()

        Try
            If estad = 1 Then
                objborrar.estado = 0
            Else
                objborrar.estado = 1
            End If
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

End Class
