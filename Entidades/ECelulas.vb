Public Class ECelulas
    Private _id_celula As Integer
    Private _nombre
    Private _lider
    Private _auxiliar
    Private _direccion
    Private _horario
    Private _dirigido
    Private _mesInicio
    Private _añoInicio
    Private _estado
    Private _cede_id
    Private _sexo
    Private _red_id

    Public Shared id

    'Declara un objeto de tipo Entities

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"

    'Define un contructor que no recibe argumentos
    Public Sub New()

    End Sub

    'Define un contructor que recibe un argumento
    Public Sub New(ByVal idd As Integer)
        IdActual = idd
    End Sub

    'Define un contructor que recibe argumentos
    Public Sub New(ByVal nom As String, ByVal lider As Integer, ByVal aux As Integer, ByVal cede As Integer, ByVal dir As String, ByVal horar As String, ByVal dirig As String, ByVal mesI As String, ByVal añoI As Integer, ByVal sex As String, ByVal reed As Integer)
        _nombre = nom
        _lider = lider
        _auxiliar = aux
        _cede_id = cede
        _direccion = dir
        _horario = horar
        _dirigido = dirig
        _mesInicio = mesI
        _añoInicio = añoI
        _estado = 1
        _sexo = sex
        _red_id = reed
    End Sub


#End Region

#Region "Set/Get"

    'Get y Set de IdAtual
    Property IdActual As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    'Get y Set de id_celula
    Property Id_celula As Integer
        Get
            Return _id_celula
        End Get
        Set(value As Integer)
            _id_celula = value
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

    'Get y Set de direccion
    Property Direccion As String
        Get
            Return _direccion

        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property


    'Get y Set de horario
    Property Horario As String
        Get
            Return _horario
        End Get
        Set(value As String)
            _horario = value
        End Set
    End Property

    'Get y Set de sexo
    Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _horario = value
        End Set
    End Property


    'Get y Set de dirigido
    Property Dirigido As String
        Get
            Return _dirigido
        End Get
        Set(value As String)
            _dirigido = value
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

    'Get y Set de año de estado
    Property Estado As Integer
        Get
            Return _estado

        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    'Get y Set de red
    Property Red As Integer
        Get
            Return _red_id
        End Get
        Set(value As Integer)
            _red_id = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

    'Lista los datos en un ComboBox cargados en Celula
    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaCelula = (From c In ctx.Celula
                           Where c.id_celula >= 0 Where c.estado = 1
                           Select c).ToList
        With combo
            .DataSource = listaCelula
            .DisplayMember = "nombre"
            .ValueMember = "id_celula"
            .SelectedValue = -1
        End With

    End Sub

    'Lista los datos en un ComboBox cargados en Personas para determinar que sea lider
    Public Sub CargarCBOL(ByVal combo As ComboBox)

        Dim listaLideres = (From c In ctx.Persona
                            Where c.id_persona >= 0 Where c.estado = 1
                            Select c).ToList
        With combo
            .DataSource = listaLideres
            .DisplayMember = "nombre"
            .ValueMember = "id_persona"
            .SelectedValue = -1
        End With
    End Sub

    'Lista TODOS los datos en un DataGridView cargados en Celulas
    Public Sub GetCelulaAll(ByVal grid As DataGridView)

        Dim listaCelulas = (From p In ctx.Celula
                            Order By p.id_celula Where p.estado = 1
                            Select Cede = p.CededeCelula.descripcion, Nombre = p.nombre, Lider = p.LiderCelula.nombre + " " + p.LiderCelula.apellido, Auxiliar = p.AuxiliarCelula.nombre + " " + p.AuxiliarCelula.apellido, Dirigido = p.dirigido, Sexo = p.sexo, Horario = p.horario, Dirección = p.direccion, MesInicio = p.mesInicio, añoInicio = p.añoInicio, Red = p.Red.nombre).ToList

        grid.DataSource = listaCelulas

    End Sub

    'Lista los datos en un DataGridView cargados en Celulas para modificar
    Public Sub GetCelulaModif(ByVal grid As DataGridView)

        Dim listaCelulas = (From p In ctx.Celula
                            Order By p.id_celula Where p.estado = 1
                            Select ID = p.id_celula, Cede = p.CededeCelula.descripcion, Nombre = p.nombre, Lider = p.LiderCelula.nombre + " " + p.LiderCelula.apellido, Auxiliar = p.AuxiliarCelula.nombre + " " + p.AuxiliarCelula.apellido, Dirigido = p.dirigido, Sexo = p.sexo, Horario = p.horario, Dirección = p.direccion, MesInicio = p.mesInicio, añoInicio = p.añoInicio, Red = p.Red.nombre).ToList

        grid.DataSource = listaCelulas

    End Sub


    'Lista los datos en un DataGridView cargados en Celulas para dar de baja
    Public Sub GetCelulaBaja(ByVal grid As DataGridView)

        Dim listaCelulas = (From p In ctx.Celula
                            Order By p.id_celula
                            Select ID = p.id_celula, Cede = p.CededeCelula.descripcion, Nombre = p.nombre, Lider = p.LiderCelula.nombre + " " + p.LiderCelula.apellido, Auxiliar = p.AuxiliarCelula.nombre + " " + p.AuxiliarCelula.apellido, Dirección = p.direccion, Red = p.Red.nombre, Estado = p.estado).ToList

        grid.DataSource = listaCelulas

    End Sub

    'Agrega una nueva Celula
    Function GuardarCelula() As Boolean
        Try
            Using ctx As New BDSystemElimEntities
                Dim pcelula As Celula = New Celula
                With pcelula
                    .nombre = Nombre
                    .lider = Lider
                    .auxiliar = Auxiliar
                    .direccion = Direccion
                    .horario = Horario
                    .dirigido = Dirigido
                    .direccion = Direccion
                    .mesInicio = MesInicio
                    .añoInicio = AñoInicio
                    .estado = 1
                    .cede_id = Cede
                    .sexo = Sexo
                    .red_id = Red

                End With
                ctx.Celula.Add(pcelula)
                ctx.SaveChanges()
                _id_celula = pcelula.id_celula
                Return True

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    'Modifica datos de una Celula
    Public Function Modificar(ByVal id As Integer, ByVal nom As String, ByVal lider As Integer, ByVal aux As Integer, ByVal ced As Integer, ByVal dir As String, ByVal horar As String, ByVal dirig As String, ByVal mesI As String, ByVal añoI As Integer, ByVal sex As String, ByVal reed As Integer) As Boolean

        Dim modif = (From q In ctx.Celula
                     Where (q.id_celula = id)
                     Select q).First

        modif.nombre = nom
        modif.lider = lider
        modif.auxiliar = aux
        modif.cede_id = ced
        modif.direccion = dir
        modif.horario = horar
        modif.dirigido = dirig
        modif.mesInicio = mesI
        modif.añoInicio = añoI
        modif.sexo = sex
        modif.red_id = reed

        Try
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    'Busca Celula a partir de su id y lo devuelve
    Function ObtenerCelula(ByVal id As Integer) As Celula
        Dim obtn = (From p In ctx.Celula
                    Where p.id_celula = id
                    Select p).First
        Return obtn
    End Function

    'Busca Celula a partir de su id y devuel el nombre
    Function ObtenerNombreCelula(ByVal id As Integer) As String
        Try
            Dim obtn = (From p In ctx.Celula
                        Where p.lider = id Or p.auxiliar = id
                        Select p.nombre).First
            Return obtn
        Catch ex As Exception
            Return " - "
            MessageBox.Show("Error al encontrar a la Celula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    'Lista los datos en un DataGridView cargados en Celula a partir de datos ingresados por teclado
    Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Celula
                        Where p.nombre.StartsWith(a) Or p.LiderCelula.nombre.StartsWith(a) Or p.AuxiliarCelula.nombre.StartsWith(a) Or p.dirigido.StartsWith(a) Or p.direccion.StartsWith(a) And p.estado = 1
                        Select ID = p.id_celula, Nombre = p.nombre, Lider = p.LiderCelula.nombre + " " + p.LiderCelula.apellido, Auxiliar = p.AuxiliarCelula.nombre + " " + p.AuxiliarCelula.apellido, Dirigido = p.dirigido, Sexo = p.sexo, Horario = p.horario, Dirección = p.direccion, MesInicio = p.mesInicio, añoInicio = p.añoInicio, Red = p.Red.nombre).ToList

        grid.DataSource = listaEmp
    End Sub

    'Lista los datos en un DataGridView cargados en Celula a partir de datos ingresados por teclado
    Sub BuscarCelula(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Celula
                        Where p.nombre.StartsWith(a) Or p.LiderCelula.nombre.StartsWith(a) Or p.AuxiliarCelula.nombre.StartsWith(a) Or p.dirigido.StartsWith(a) Or p.direccion.StartsWith(a) And p.estado = 1
                        Select Nombre = p.nombre, Lider = p.LiderCelula.nombre + " " + p.LiderCelula.apellido, Auxiliar = p.AuxiliarCelula.nombre + " " + p.AuxiliarCelula.apellido, Dirigido = p.dirigido, Sexo = p.sexo, Horario = p.horario, Dirección = p.direccion, MesInicio = p.mesInicio, añoInicio = p.añoInicio, Red = p.Red.nombre).ToList

        grid.DataSource = listaEmp
    End Sub

    'Lista los datos en un DataGridView cargados en Celulas por cede
    Sub BuscarPorCede(ByVal id As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Celula
                         Where p.CededeCelula.id_cede = id And p.estado = 1
                         Select Cede = p.CededeCelula.descripcion, Nombre = p.nombre, Lider = p.LiderCelula.nombre + " " + p.LiderCelula.apellido, Auxiliar = p.AuxiliarCelula.nombre + " " + p.AuxiliarCelula.apellido, Dirigido = p.dirigido, Sexo = p.sexo, Horario = p.horario, Dirección = p.direccion, MesInicio = p.mesInicio, añoInicio = p.añoInicio, Red = p.Red.nombre).ToList

        grid.DataSource = listapers

    End Sub

    'Cambia el estado de una Celula
    Public Function Activar_Desactivar(ByVal p_id As Integer, ByVal estad As Integer)
        Dim objborrar = (From q In ctx.Celula Where (q.id_celula = p_id) Select q).First()

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

#Region "Cantidades"

    'Devuelve la cantidad tota de Celulas registradas
    Function CantTotal() As Integer
        Dim buscar = (From p In ctx.Celula
                      Select p.id_celula).Count
        Return buscar
    End Function

    'Devuelve la cantidad tota de Celulas registradas por Cede
    Function CantPorCede(ByVal a As String) As Integer
        If a = "Sol de Mayo" Then

            Dim buscar = (From p In ctx.Celula
                          Where p.cede_id = 1
                          Select p.id_celula).Count
            Return buscar
        ElseIf a = "Molina Punta" Then
            Dim buscar = (From p In ctx.Celula
                          Where p.cede_id = 2
                          Select p.id_celula).Count
            Return buscar
        End If
        Return 0
    End Function

    'Devuelve la cantidad tota de Celulas registradas por Sexo
    Function CantPorSexo(ByVal sex As String) As Integer
        If sex = "Mujer" Then

            Dim buscar = (From p In ctx.Celula
                          Where p.sexo = "Mujer"
                          Select p.id_celula).Count
            Return buscar
        ElseIf sex = "Hombre" Then

            Dim buscar = (From p In ctx.Celula
                          Where p.sexo = "Hombre"
                          Select p.id_celula).Count
            Return buscar
        ElseIf sex = "Hombre y Mujer" Then

            Dim buscar = (From p In ctx.Celula
                          Where p.sexo = "Hombre y Mujer"
                          Select p.id_celula).Count
            Return buscar
        End If
        Return 0
    End Function

    'Devuelve la cantidad tota de Celulas registradas por Dirigido
    Function CantPorDirigido(ByVal dir As String) As Integer
        If dir = "Jovenes" Then

            Dim buscar = (From p In ctx.Celula
                          Where p.dirigido = "Jovenes"
                          Select p.id_celula).Count
            Return buscar
        ElseIf dir = "Adolescentes" Then

            Dim buscar = (From p In ctx.Celula
                          Where p.dirigido = "Adolescentes"
                          Select p.id_celula).Count
            Return buscar
        ElseIf dir = "Matrimonios" Then

            Dim buscar = (From p In ctx.Celula
                          Where p.dirigido = "Matrimonios"
                          Select p.id_celula).Count
            Return buscar
        End If
        Return 0
    End Function

#End Region

End Class



