﻿Public Class EPersonas
    'Clase de la entidad Personas
    Private _id_persona As Integer
    Private _nombre
    Private _apellido
    Private _fecha_nac
    Private _lugar_nac
    Private _profesion
    Private _sexo
    Private _direccion
    Private _barrio
    Private _telefono
    Private _cede_id
    Private _celula_id
    Private _lider_id
    Private _escuela_id
    Private _bautizado_id
    Private _estado
    Private _fechaactual
    Private _edad

    Public Shared tempor

    'Declara un objeto de tipo Entities
    Dim ct As BDSystemElimEntities = New BDSystemElimEntities

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal tem As Integer)
        Temporal = tem
    End Sub

    Public Sub New(ByVal id As Integer, ByVal nom As String, ByVal ape As String, ByVal fechaN As Date,
                   ByVal lugarNaci As String, ByVal prof As String, ByVal sex As String,
                   ByVal dir As String, ByVal barr As String, ByVal tel As String,
                   ByVal idcede As Integer, ByVal idcelula As Integer, ByVal idlider As Integer,
                   ByVal idesc As Integer, ByVal idbaut As Integer, ByVal fecha As Date)
        _id_persona = id
        _nombre = nom
        _apellido = ape
        _fecha_nac = fechaN
        _lugar_nac = lugarNaci
        _profesion = prof
        _sexo = sex
        _direccion = dir
        _barrio = barr
        _telefono = tel
        _cede_id = idcede
        _celula_id = idcelula
        _lider_id = idlider
        _escuela_id = idesc
        _bautizado_id = idbaut
        _estado = 1
        _fechaactual = fecha
    End Sub

#End Region

#Region "Set/Get"

    'Get y Set de Temporal
    Property Temporal As Integer
        Get
            Return tempor
        End Get
        Set(value As Integer)
            tempor = value
        End Set
    End Property

    'Get y Set de id persona
    Property Id_persona As Integer
        Get
            Return _id_persona
        End Get
        Set(value As Integer)
            _id_persona = value
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

    'Get y Set de apellido
    Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    'Get y Set de fecha_nac
    Property Fecha_nac As Date
        Get
            Return _fecha_nac
        End Get
        Set(value As Date)
            _fecha_nac = value
        End Set
    End Property

    'Get y Set de Lugar de nacimiento
    Property LugarNac As String
        Get
            Return _lugar_nac
        End Get
        Set(value As String)
            _lugar_nac = value
        End Set
    End Property

    'Get y Set de Profesion
    Property Profesion As String
        Get
            Return _profesion

        End Get
        Set(value As String)
            _profesion = value
        End Set
    End Property

    'Get y Set de sexo
    Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    'Get y Set de Direccion
    Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    'Get y Set de edad
    Property Edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    'Get y Set de Barrio
    Property Barrio As String
        Get
            Return _barrio
        End Get
        Set(value As String)
            _barrio = value
        End Set
    End Property

    'Get y Set de telefono
    Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
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
    Property Lider As Integer
        Get
            Return _lider_id
        End Get
        Set(value As Integer)
            _lider_id = value
        End Set
    End Property

    'Get y Set de escuela
    Property Escuela As Integer
        Get
            Return _escuela_id
        End Get
        Set(value As Integer)
            _escuela_id = value
        End Set
    End Property

    'Get y Set de bautizado
    Property Bautizadoo As Integer
        Get
            Return _bautizado_id
        End Get
        Set(value As Integer)
            _bautizado_id = value
        End Set
    End Property

    'Get y Set de estado
    Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    'Get y Set de fechaactual
    Property FechaActual As Date
        Get
            Return _fechaactual
        End Get
        Set(value As Date)
            _fechaactual = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

    'Lista TODOS los datos en un DataGridView cargados en Persona
    Public Sub GetPersonaAll(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ct.Persona
                             Order By p.id_persona Where p.estado = 1
                             Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, Dirección = p.direccion, Barrio = p.barrio,
                                           Telefono = p.telefono, Ocupacion = p.profesion, Edad = p.edad, EscuelaDeVida = p.EscuelaDeVida.descripcion,
                                            Bautizado = p.Bautizados.estado, Iglesia = p.Bautizados.iglesia).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Persona
    Public Sub GetPersonaAll1(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ct.Persona
                             Order By p.id_persona Where p.estado = 1
                             Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre, Apellido = p.apellido, Lider = p.LiderDePersona.PersonaQueEsLider.nombre, Sexo = p.sexo, Dirección = p.direccion, Barrio = p.barrio,
                                            Profesion = p.profesion, Telefono = p.telefono, Ocupacion = p.profesion, Edad = p.edad, LugardeNacimiento = p.lugar_nac, EscuelaDeVida = p.EscuelaDeVida.descripcion,
                                            Bautizado = p.Bautizados.estado, Iglesia = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Persona para modificar
    Public Sub GetPersonaModif(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ct.Persona
                             Order By p.id_persona Where p.estado = 1
                             Select ID = p.id_persona, Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, Sexo = p.sexo, Dirección = p.direccion, Barrio = p.barrio,
                                            Profesion = p.profesion, Telefono = p.telefono, Ocupacion = p.profesion, Edad = p.edad, LugardeNacimiento = p.lugar_nac, EscuelaDeVida = p.EscuelaDeVida.descripcion,
                                            Bautizado = p.Bautizados.estado, Iglesia = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Persona para dar de baja
    Public Sub GetPersonaBaja(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ct.Persona
                             Order By p.id_persona
                             Select ID = p.id_persona, Cede = p.CededePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre + " " + p.apellido, Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, Estado = p.estado).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un ComboBox cargados en Persona
    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaPersona = (From c In ct.Persona
                            Where c.id_persona >= 0 And c.estado = 1
                            Select c).ToList
        With combo
            .DataSource = listaPersona
            .DisplayMember = "nombre"
            .ValueMember = "id_persona"
            .SelectedValue = -1
        End With

    End Sub

    'Agrega una nueva Persona
    Function GuardarPersona() As Boolean

        Try
            Using ctx As New BDSystemElimEntities
                Dim parametro As Persona = New Persona
                With parametro
                    .id_persona = Id_persona
                    .nombre = Nombre
                    .apellido = Apellido
                    .fecha_nac = Fecha_nac
                    .lugar_nac = LugarNac
                    .profesion = Profesion
                    .sexo = Sexo
                    .direccion = Direccion
                    .barrio = Barrio
                    .telefono = Telefono
                    .cede_id = Cede
                    .celula_id = Celula
                    .lider_id = Lider
                    .escuela_id = Escuela
                    .bautizado_id = Bautizadoo
                    .estado = 1
                    .fechaactual = FechaActual
                    .edad = Today.Year - Fecha_nac.Year

                End With
                ctx.Persona.Add(parametro)
                ctx.SaveChanges()

                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Retorna el id de la ultima Persona registrada
    Function IdUltimo() As Integer
        Dim buscarId = (From p In ct.Persona
                        Select p.id_persona).Max()
        Return buscarId
    End Function

    'Busca Persona a partir de su id y lo devuelve
    Function ObtenerPersona(ByVal id As Integer) As Persona
        Dim obtn = (From p In ct.Persona
                    Where p.id_persona = id
                    Select p).First
        Return obtn
    End Function

    'Lista los datos cargados en Persona
    Function listaPersona()
        Dim obtn = (From p In ct.Persona
                    Order By p.id_persona
                    Select p).ToList
        Return obtn
    End Function

    'Busca Persona por Cede a partir de su id y lo devuelve
    Function BuscarPersonaporCede(ByVal id As Integer) As Integer
        Dim buscar = (From p In ct.Cede
                      Where p.id_cede = id
                      Select p).First
        Dim buscarRol = (From p In ct.Persona
                         Where p.cede_id = buscar.id_cede
                         Select p).First
        Return buscarRol.id_persona
    End Function

    'Lista los datos en un DataGridView cargados en Persona a partir de datos ingresados por teclado
    Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ct.Persona
                        Where p.barrio.StartsWith(a) Or p.nombre.StartsWith(a) Or p.profesion.StartsWith(a) Or p.apellido.StartsWith(a) Or p.direccion.StartsWith(a) Or p.CedeDePersona.descripcion.StartsWith(a) Or p.CelulaDePersona.nombre.StartsWith(a) And p.estado = 1
                        Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, Dirección = p.direccion, Barrio = p.barrio,
                                           Telefono = p.telefono, Ocupacion = p.profesion, Edad = p.edad, EscuelaDeVida = p.EscuelaDeVida.descripcion,
                                            Bautizado = p.Bautizados.estado, Iglesia = p.Bautizados.iglesia).ToList


        grid.DataSource = listaEmp
    End Sub

    'Lista los datos en un DataGridView cargados en Persona a partir de datos ingresados por teclado
    Sub BuscarModif(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ct.Persona
                        Where p.barrio.StartsWith(a) Or p.nombre.StartsWith(a) Or p.profesion.StartsWith(a) Or p.apellido.StartsWith(a) Or p.direccion.StartsWith(a) Or p.CedeDePersona.descripcion.StartsWith(a) Or p.CelulaDePersona.nombre.StartsWith(a) And p.estado = 1
                        Select ID = p.id_persona, Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, Sexo = p.sexo, Dirección = p.direccion, Barrio = p.barrio,
                                            Profesion = p.profesion, Telefono = p.telefono, Ocupacion = p.profesion, Edad = p.edad, LugardeNacimiento = p.lugar_nac, EscuelaDeVida = p.EscuelaDeVida.descripcion,
                                            Bautizado = p.Bautizados.estado, Iglesia = p.Bautizados.iglesia, Lugar = p.Bautizados.lugar, Año = p.Bautizados.año).ToList

        grid.DataSource = listaEmp
    End Sub

    'Lista los datos en un DataGridView cargados en Persona por cede
    Sub BuscarPorCede(ByVal id As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ct.Persona
                         Where p.CedeDePersona.id_cede = id And p.estado = 1
                         Select Cede = p.CedeDePersona.descripcion, Celula = p.CelulaDePersona.nombre, Nombre = p.nombre + " " + p.apellido, Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, Dirección = p.direccion, Barrio = p.barrio,
                                           Telefono = p.telefono, Ocupacion = p.profesion, Edad = p.edad, EscuelaDeVida = p.EscuelaDeVida.descripcion,
                                            Bautizado = p.Bautizados.estado, Iglesia = p.Bautizados.iglesia).ToList

        grid.DataSource = listapers
    End Sub

    'Modifica datos de una Persona
    Public Function Modificar(ByVal id As Integer, ByVal nom As String, ByVal ape As String,
                               ByVal fechaN As Date, ByVal lugarNaci As String, ByVal prof As String,
                               ByVal sex As String, ByVal dir As String, ByVal barr As String, ByVal tel As String,
                                ByVal idcede As Integer, ByVal idcelula As Integer, ByVal idlider As Integer,
                                ByVal idesc As Integer, ByVal igle As String, ByVal lug As String, ByVal año As Integer) As Boolean

        Dim modif = (From q In ct.Persona
                     Where (q.id_persona = id)
                     Select q).First

        modif.nombre = nom
        modif.apellido = ape
        modif.fecha_nac = fechaN
        modif.lugar_nac = lugarNaci
        modif.profesion = prof
        modif.sexo = sex
        modif.direccion = dir
        modif.barrio = barr
        modif.telefono = tel
        modif.cede_id = idcede
        modif.celula_id = idcelula
        modif.lider_id = idlider
        modif.escuela_id = idesc
        modif.Bautizados.iglesia = igle
        modif.Bautizados.lugar = lug
        modif.Bautizados.año = año
        modif.edad = Today.Year - fechaN.Year

        Try
            ct.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    'Cambia el estado de una Persona
    Public Function Activar_Desactivar(ByVal p_id As Integer, ByVal estad As Integer)

        Dim objborrar = (From q In ct.Persona Where (q.id_persona = p_id) Select q).First()

        Try
            If estad = 1 Then
                objborrar.estado = 0
            Else
                objborrar.estado = 1
            End If
            ct.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "Cantidades"

    'Devuelve la cantidad total de Personas registradas
    Function CantTotal() As Integer
        Dim buscar = (From p In ct.Persona
                      Select p.id_persona).Count
        Return buscar
    End Function

    'Devuelve la cantidad tota de Personas por Cede registradas
    Function CantPorCede(ByVal a As String) As Integer
        If a = "Sol de Mayo" Then

            Dim buscar = (From p In ct.Persona
                          Where p.cede_id = 1
                          Select p.id_persona).Count
            Return buscar
        ElseIf a = "Molina Punta" Then
            Dim buscar = (From p In ct.Persona
                          Where p.cede_id = 2
                          Select p.id_persona).Count
            Return buscar

        End If
        Return 0
    End Function

    'Devuelve la cantidad tota de Personas por lugar registradas
    Function CantPorLugar(ByVal a As String) As Integer
        If a = "Ctes" Then

            Dim buscar = (From p In ct.Persona
                          Where p.lugar_nac = "Corrientes"
                          Select p.id_persona).Count
            Return buscar
        Else
            Dim buscar = (From p In ct.Persona
                          Where p.lugar_nac <> "Corrientes"
                          Select p.id_persona).Count
            Return buscar

        End If
        Return 0
    End Function

    'Devuelve la cantidad tota de Personas por ocupacion registradas
    Function CantPorOcupacion(ByVal a As String) As Integer
        If a = "Estudian" Then

            Dim buscar = (From p In ct.Persona
                          Where p.profesion = "Estudia"
                          Select p.id_persona).Count
            Return buscar
        ElseIf a = "Trabajan" Then
            Dim buscar = (From p In ct.Persona
                          Where p.profesion = "Trabaja"
                          Select p.id_persona).Count
            Return buscar
        ElseIf a = "Trabajan y Estudian" Then
            Dim buscar = (From p In ct.Persona
                          Where p.profesion = "Trabaja y Estudia"
                          Select p.id_persona).Count
            Return buscar

        ElseIf a = "Otro" Then
            Dim buscar = (From p In ct.Persona
                          Where p.profesion = "Otro"
                          Select p.id_persona).Count
            Return buscar

        End If

        Return 0
    End Function

    'Devuelve la cantidad tota de Personas por Sexo registradas
    Function CantPorSexo(ByVal cede As String, ByVal sex As String) As Integer
        If cede = "Sol de Mayo" And sex = "Mujer" Then

            Dim buscar = (From p In ct.Persona
                          Where p.cede_id = 1 And p.sexo = "mujer"
                          Select p.id_persona).Count
            Return buscar
        ElseIf cede = "Sol de Mayo" And sex = "Hombre" Then

            Dim buscar = (From p In ct.Persona
                          Where p.cede_id = 1 And p.sexo = "hombre"
                          Select p.id_persona).Count
            Return buscar
        ElseIf cede = "Molina Punta" And sex = "Mujer" Then

            Dim buscar = (From p In ct.Persona
                          Where p.cede_id = 2 And p.sexo = "Mujer"
                          Select p.id_persona).Count
            Return buscar
        ElseIf cede = "Molina Punta" And sex = "Hombre" Then

            Dim buscar = (From p In ct.Persona
                          Where p.cede_id = 2 And p.sexo = "Hombre"
                          Select p.id_persona).Count
            Return buscar

        End If
        Return 0
    End Function

#End Region

End Class