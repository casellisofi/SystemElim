Public Class EAreas
    Private _id_area As Integer
    Private _nombre
    Private _lider
    Private _auxiliar
    Private _cede_id
    Private _estado
    Private _desc

    Public Shared id
    'Declara un objeto de tipo Entities

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"

    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe un argumento
    Public Sub New(ByVal a As Integer)
        Temporal = a
    End Sub

    'Define un contructor que recibe argumentos

    Public Sub New(ByVal descrip As String, ByVal lider As Integer, ByVal aux As Integer, ByVal ced As Integer, ByVal des As String)
        _nombre = descrip
        _lider = lider
        _auxiliar = aux
        _cede_id = ced
        _estado = 1
        _desc = des

    End Sub

#End Region

#Region "Set/Get"

    'Get y Set de Temporal
    Property Temporal As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    'Get y Set de id_area
    Property Id_area As Integer
        Get
            Return _id_area
        End Get
        Set(value As Integer)
            _id_area = value
        End Set
    End Property

    'Get y Set de Nombre
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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

    'Get y Set de Cede
    Property Cede As Integer
        Get
            Return _cede_id
        End Get
        Set(value As Integer)
            _cede_id = value
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

    'Get y Set de Descripcion
    Property Descripcion As String
        Get
            Return _desc
        End Get
        Set(value As String)
            _desc = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

    'Lista los datos en un ComboBox cargados en Areas
    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaCede = (From c In ctx.Area
                         Where c.id_area >= 1 And c.estado = 1
                         Select c).ToList
        With combo
            .DataSource = listaCede
            .DisplayMember = "nombre"
            .ValueMember = "id_area"
            .SelectedValue = -1
        End With

    End Sub

    'Lista los datos en un DataGridView cargados en Areas
    Public Sub GetAreasAll(ByVal grid As DataGridView)

        Dim listaAreas = (From p In ctx.Area
                          Order By p.id_area Where p.estado = 1
                          Select Nombre = p.nombre, Lider = p.LiderArea.nombre + " " + p.LiderArea.apellido, Auxiliar = p.AuxiliarArea.nombre + " " + p.AuxiliarArea.apellido, Cede = p.Cede.descripcion, Descripcion = p.descripcion).ToList

        grid.DataSource = listaAreas

    End Sub

    'Lista los datos de Lideres en un DataGridView cargados en Areas
    Public Sub GetLiderAreasAll(ByVal grid As DataGridView)

        Dim listaPer = (From p In ctx.Persona Join u In ctx.Area
                      On p.id_persona Equals u.lider Where u.estado = 1
                        Select Cede = u.Cede.descripcion, Servicio = u.nombre, CelulaDelLider = p.CelulaDePersona.nombre, Lider = p.nombre + " " + p.apellido, CelulaDelAuxiliar = u.AuxiliarArea.CelulaDePersona.nombre, Auxiliar = u.AuxiliarArea.nombre + " " + u.AuxiliarArea.apellido, Descripcion = u.descripcion).ToList

        grid.DataSource = listaPer

    End Sub


    'Lista los datos en un DataGridView cargados en Areas para modificar
    Public Sub GetAreaModif(ByVal grid As DataGridView)

        Dim listaAreas = (From p In ctx.Area
                          Order By p.id_area Where p.estado = 1
                          Select ID = p.id_area, Nombre = p.nombre, Lider = p.LiderArea.nombre, Auxiliar = p.AuxiliarArea.nombre, Cede = p.Cede.descripcion, Descripcion = p.descripcion).ToList

        grid.DataSource = listaAreas

    End Sub


    'Lista los datos en un DataGridView cargados en Areas para dar de baja
    Public Sub GetAreaBaja(ByVal grid As DataGridView)

        Dim listaAreas = (From p In ctx.Area
                          Order By p.id_area
                          Select ID = p.id_area, Nombre = p.nombre, Lider = p.LiderArea.nombre + " " + p.LiderArea.apellido, Auxiliar = p.AuxiliarArea.nombre + " " + p.AuxiliarArea.apellido, Cede = p.Cede.descripcion, Descripcion = p.descripcion, Estado = p.estado).ToList

        grid.DataSource = listaAreas

    End Sub

    'Agrega una nueva Area
    Function GuardarArea() As Boolean

        Try
            Using ctx As New BDSystemElimEntities
                Dim parea As Area = New Area
                With parea
                    .nombre = Nombre
                    .lider = Lider
                    .auxiliar = Auxiliar
                    .cede_id = Cede
                    .estado = 1
                    .descripcion = Descripcion

                End With
                ctx.Area.Add(parea)
                ctx.SaveChanges()
                _id_area = parea.id_area
                Return True

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    'Modifica datos de una Area
    Public Function Modificar(ByVal id As Integer, ByVal descrip As String, ByVal lider As Integer, ByVal aux As Integer, ByVal ced As Integer, ByVal des As String) As Boolean

        Dim modif = (From q In ctx.Area
                     Where (q.id_area = id)
                     Select q).First

        modif.nombre = descrip
        modif.lider = lider
        modif.auxiliar = aux
        modif.cede_id = ced
        modif.descripcion = des

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Busca Area a partir de su id y lo devuelve
    Function ObtenerArea(ByVal id As Integer) As Area
        Dim obtn = (From p In ctx.Area
                    Where p.id_area = id
                    Select p).First
        Return obtn
    End Function

    'Lista los datos en un DataGridView cargados en Areas por cede
    Sub BuscarPorCede(ByVal idp As Integer, ByVal grid As DataGridView)

        Dim listaAreas = (From p In ctx.Area
                          Order By p.id_area Where p.estado = 1 And p.cede_id = idp
                          Select Nombre = p.nombre, Lider = p.LiderArea.nombre + " " + p.LiderArea.apellido, Auxiliar = p.AuxiliarArea.nombre + " " + p.AuxiliarArea.apellido, Cede = p.Cede.descripcion, Descripcion = p.descripcion).ToList

        grid.DataSource = listaAreas
    End Sub

    'Lista los datos en un DataGridView cargados en Areas por lider del area por cede
    Sub BuscarLiderAreaPorCede(ByVal idp As Integer, ByVal grid As DataGridView)

        Dim listaPer = (From p In ctx.Persona Join u In ctx.Area
              On p.id_persona Equals u.lider Where p.cede_id = idp And p.estado = 1
                        Select Cede = u.Cede.descripcion, Servicio = u.nombre, CelulaDelLider = p.CelulaDePersona.nombre, Lider = p.nombre + " " + p.apellido, CelulaDelAuxiliar = u.AuxiliarArea.CelulaDePersona.nombre, Auxiliar = u.AuxiliarArea.nombre + " " + u.AuxiliarArea.apellido, Descripcion = u.descripcion).ToList

        grid.DataSource = listaPer
    End Sub

    'Lista los datos en un DataGridView cargados en Areas por Lider de area
    Sub BuscarLiderArea(ByVal a As String, ByVal grid As DataGridView)

        Dim listaLideres = (From p In ctx.Persona Join u In ctx.Area
                            On p.id_persona Equals u.lider Where u.estado = 1 And p.nombre.StartsWith(a) Or p.apellido.StartsWith(a) Or u.nombre.StartsWith(a) Or p.CelulaDePersona.nombre.StartsWith(a)
                            Select Cede = u.Cede.descripcion, Servicio = u.nombre, CelulaDelLider = p.CelulaDePersona.nombre, Lider = p.nombre + " " + p.apellido, CelulaDelAuxiliar = u.AuxiliarArea.CelulaDePersona.nombre, Auxiliar = u.AuxiliarArea.nombre + " " + u.AuxiliarArea.apellido, Descripcion = u.descripcion).ToList

        grid.DataSource = listaLideres


    End Sub

    'Lista los datos en un DataGridView cargados en Area a partir de datos ingresados por teclado
    Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Area
                        Where p.estado = 1 And p.nombre.StartsWith(a) Or p.LiderArea.nombre.StartsWith(a) Or p.AuxiliarArea.nombre.StartsWith(a) Or p.Cede.descripcion.StartsWith(a)
                        Select ID = p.id_area, Nombre = p.nombre, Lider = p.LiderArea.nombre + " " + p.LiderArea.apellido, Auxiliar = p.AuxiliarArea.nombre + " " + p.AuxiliarArea.apellido, Cede = p.Cede.descripcion, Descripcion = p.descripcion).ToList

        grid.DataSource = listaEmp
    End Sub


    'Cambia el estado de una Area
    Public Function Activar_Desactivar(ByVal p_id As Integer, ByVal estad As Integer)

        Dim objborrar = (From q In ctx.Area Where (q.id_area = p_id) Select q).First()

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
