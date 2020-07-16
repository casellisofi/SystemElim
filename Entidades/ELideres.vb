Imports Microsoft.VisualBasic

Public Class ELideres
    Private _id_lider As Integer
    Private _persona_id
    Private _estado
    Private _nombre
    Private _celulalider


    'Declara un objeto de tipo Entities

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities
    Dim objPersona As New EPersonas
    Dim objCelula As New ECelulas

#Region "Constructores"

    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe argumentos

    Public Sub New(ByVal persona As Integer)
        _persona_id = persona
        _estado = 1
    End Sub


#End Region

#Region "Set/Get"

    'Get y Set de id_lider
    Property Id_lider As Integer
        Get
            Return _id_lider
        End Get
        Set(value As Integer)
            _id_lider = value
        End Set
    End Property

    'Get y Ser de Persona
    Property Persona As Integer
        Get
            Return _persona_id

        End Get
        Set(value As Integer)
            _persona_id = value
        End Set
    End Property

    'Get y Ser de Estado
    Property Estado As Integer
        Get
            Return _estado

        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    'Get y Ser de Nombre
    Property Nombre As String
        Get
            Return _nombre

        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    'Get y Ser de Celulalider
    Property CelulaLider As String
        Get
            Return _celulalider

        End Get
        Set(value As String)
            _celulalider = value
        End Set
    End Property

#End Region

#Region "Procedimientos"
    'Agrega una nueva Persona
    Function GuardarLider() As Boolean

        Dim pers As Persona = objPersona.ObtenerPersona(_persona_id)
        Dim nomb As String = pers.nombre + " " + pers.apellido
        Dim celula As String = objCelula.ObtenerNombreCelula(_persona_id)

        Try
            Using ctx As New BDSystemElimEntities
                Dim parametro As Lideres = New Lideres
                With parametro
                    .persona_id = Persona
                    .estado = 1
                    .nombre = nomb
                    .celulalider = celula

                End With
                ctx.Lideres.Add(parametro)
                ctx.SaveChanges()
                _id_lider = parametro.id_lider
                Return True

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


    'Lista los datos en un ComboBox cargados en Lideres
    Public Sub CargarCBO(ByVal combo As ComboBox)

        Dim listaLideres = (From u In ctx.Persona Join q In ctx.Lideres
                            On u.id_persona Equals q.persona_id
                            Order By u.id_persona
                            Select nomyApe = u.nombre + " " + u.apellido, id_persona = u.id_persona).ToList

        With combo
            .DataSource = listaLideres
            .DisplayMember = "nomyApe"
            .ValueMember = "id_persona"
            .SelectedValue = -1
        End With
    End Sub

    'Busca Lider a partir de su id y lo devuelve
    Function ObtenerLiderSeleccionado(ByVal id As Integer) As Lideres
        Dim obtn = (From p In ctx.Lideres
                    Where p.persona_id = id
                    Select p).First
        Return obtn
    End Function

    'Retorna true si existe el lider recibido como parametro
    Function ExisteLider(ByVal id As Integer) As Boolean
        Dim obtn = (From p In ctx.Lideres
                    Where p.persona_id = id
                    Select p).Count
        If obtn = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Lista TODOS los datos en un DataGridView cargados en Lideres de Celulas
    Public Sub GetLiderCelulaAll(ByVal grid As DataGridView)

        Dim listaPer = (From p In ctx.Persona Join u In ctx.Celula
                      On p.id_persona Equals u.lider
                        Select Cede = u.CededeCelula.descripcion, Celula = u.nombre, Nombre = p.nombre + " " + p.apellido, Auxiliar = u.AuxiliarCelula.nombre + " " + u.AuxiliarCelula.apellido,
                                            Dirigido = u.dirigido, Sexo = u.sexo, Red = u.Red.nombre).ToList

        grid.DataSource = listaPer

    End Sub

    'Lista TODOS los datos en un DataGridView cargados en Lideres
    Public Sub GetLiderAll(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona Join u In ctx.Lideres
                             On p.id_persona Equals u.persona_id
                             Select Cede = p.CedeDePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre + " " + p.apellido,
                                            Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, CelulaQueEsLider = u.celulalider).ToList
        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Lideres para dar de baja
    Public Sub GetLiderBaja(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona Join u In ctx.Lideres
                             On p.id_persona Equals u.persona_id
                             Select ID = u.id_lider, Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido,
                                            Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, CelulaQueEsLider = u.celulalider, Estado = u.estado).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Lideres por Cede
    Sub BuscarLiderPorCede(ByVal idp As Integer, ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona Join u In ctx.Lideres
                             On p.id_persona Equals u.persona_id Where p.cede_id = idp
                             Select Cede = p.CedeDePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre + " " + p.apellido,
                                            Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, CelulaQueEsLider = u.celulalider).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Lideres de Celula por cede
    Sub BuscarLiderCelulaPorCede(ByVal idp As Integer, ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona Join u In ctx.Celula
                             On p.id_persona Equals u.lider Where p.cede_id = idp
                             Select Cede = u.CededeCelula.descripcion, Celula = u.nombre, Nombre = p.nombre + " " + p.apellido, Auxiliar = u.AuxiliarCelula.nombre + " " + u.AuxiliarCelula.apellido,
                                            Dirigido = u.dirigido, Sexo = u.sexo, Red = u.Red.nombre).ToList

        grid.DataSource = listaPersonas

    End Sub
    'Lista los datos en un DataGridView cargados en Lideres de Celula por Cdde y celula
    Sub BuscarLiderCelulaPorCedeyCelula(ByVal idp As Integer, ByVal idC As Integer, ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona Join u In ctx.Celula
                             On p.id_persona Equals u.lider Where p.cede_id = idp And u.id_celula = idC
                             Select Cede = p.CededePersona.descripcion, Celula = u.nombre, Nombre = p.nombre + " " + p.apellido, Auxiliar = u.AuxiliarCelula.nombre + " " + u.AuxiliarCelula.apellido,
                                            Dirigido = u.dirigido).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Lideres a partir de datos ingresados por teclado
    Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Persona Join u In ctx.Lideres On p.id_persona Equals u.persona_id
                        Where p.nombre.StartsWith(a) Or p.apellido.StartsWith(a) Or p.CedeDePersona.descripcion.StartsWith(a) Or p.CeluladePersona.nombre.StartsWith(a) Or p.LiderDePersona.PersonaQueEsLider.nombre.StartsWith(a)
                        Select Cede = p.CedeDePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre + " " + p.apellido,
                                            Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, CelulaQueEsLider = u.celulalider, Estado = u.estado).ToList


        grid.DataSource = listaEmp
    End Sub

    'Lista los datos en un DataGridView cargados en Lideres por Celula a partir de datos ingresados por teclado
    Sub BuscarLiderCelula(ByVal a As String, ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona Join u In ctx.Celula
                             On p.id_persona Equals u.lider And p.id_persona Equals u.auxiliar
                             Where u.nombre.StartsWith(a) Or p.nombre.StartsWith(a) Or p.apellido.StartsWith(a) Or p.CedeDePersona.descripcion.StartsWith(a) Or p.CeluladePersona.nombre.StartsWith(a) Or p.LiderDePersona.PersonaQueEsLider.nombre.StartsWith(a)
                             Select Cede = p.CedeDePersona.descripcion, Celula = u.nombre, Nombre = p.nombre + " " + p.apellido,
                                            Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, Dirigido = u.dirigido).ToList

        grid.DataSource = listaPersonas
    End Sub


    'Lista los datos en un DataGridView cargados en Lideres a partir de datos ingresados por teclado
    Sub BuscarLideres(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Persona Join u In ctx.Lideres On p.id_persona Equals u.persona_id
                        Where p.nombre.StartsWith(a) Or p.apellido.StartsWith(a) Or p.CedeDePersona.descripcion.StartsWith(a) Or p.CelulaDePersona.nombre.StartsWith(a) Or p.LiderDePersona.PersonaQueEsLider.nombre.StartsWith(a)
                        Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido,
                                            Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, CelulaQueEsLider = u.celulalider).ToList


        grid.DataSource = listaEmp
    End Sub

    'Busca Lider a partir de su dni y lo devuelve
    Function ObtenerLider(ByVal id As Integer) As Lideres
        Dim obtn = (From p In ctx.Lideres
                    Where p.id_lider = id
                    Select p).First
        Return obtn
    End Function

    'Modifica datos de un Lider
    Public Function Modificar(ByVal id As Integer, ByVal nom As String)
        Dim modif = (From q In ctx.Lideres
                     Where (q.persona_id = id)
                     Select q).First


        modif.persona_id = id
        modif.celulalider = nom


        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    'Cambia el estado de un Lider
    Public Function Activar_Desactivar(ByVal p_id As Integer, ByVal estad As Integer)

        Dim objborrar = (From q In ctx.Lideres Where (q.id_lider = p_id) Select q).First()

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


