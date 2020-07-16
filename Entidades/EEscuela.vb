Public Class EEscuela
    Private id_escuela As Integer
    Private descripcion

    Dim ctx As BDSystemElimEntities = New BDSystemElimEntities

#Region "Procedimientos"

    'Lista los datos en un ComboBox cargados en Escuela
    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim listaEsc = (From c In ctx.EscuelaDeVida
                        Where c.id_escuela >= 0
                        Select c).ToList
        With combo
            .DataSource = listaEsc
            .DisplayMember = "descripcion"
            .ValueMember = "id_escuela"
            .SelectedValue = -1
        End With
    End Sub

    'Lista los datos en un DataGridView cargados en Escuela
    Public Sub GetEscuelaAll(ByVal grid As DataGridView)

        Dim listaPersonas = (From p In ctx.Persona
                             Order By p.id_persona Where p.estado = 1
                             Select Cede = p.CededePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre, Apellido = p.apellido,
                                           Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, EscuelaDeVida = p.EscuelaDeVida.descripcion).ToList

        grid.DataSource = listaPersonas

    End Sub

    'Lista los datos en un DataGridView cargados en Escuela a partir de datos ingresados por teclado
    Sub Buscar(ByVal a As String, ByVal grid As DataGridView)
        Dim listaEmp = (From p In ctx.Persona
                        Where p.nombre.StartsWith(a) Or p.apellido.StartsWith(a) Or p.CededePersona.descripcion.StartsWith(a) Or p.CeluladePersona.nombre.StartsWith(a) Or p.EscuelaDeVida.descripcion.StartsWith(a) And p.estado = 1
                        Select Cede = p.CededePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre, Apellido = p.apellido,
                                           Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, EscuelaDeVida = p.EscuelaDeVida.descripcion).ToList


        grid.DataSource = listaEmp
    End Sub

    ''Lista los datos en un DataGridView cargados en Escuela por Celula
    Sub BuscarPorCelula(ByVal id As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Persona
                         Where p.celula_id = id And p.estado = 1
                         Select Cede = p.CededePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre, Apellido = p.apellido,
                                           Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, EscuelaDeVida = p.EscuelaDeVida.descripcion).ToList

        grid.DataSource = listapers
    End Sub

    'Lista los datos en un DataGridView cargados en Escuela por Cede
    Sub BuscarporCede(ByVal id As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Persona
                         Where id = p.cede_id And p.estado = 1
                         Select Cede = p.CededePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre, Apellido = p.apellido,
                                           Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, EscuelaDeVida = p.EscuelaDeVida.descripcion).ToList

        grid.DataSource = listapers
    End Sub

    ''Lista los datos en un DataGridView cargados en Escuela por modulo
    Sub BuscarPorModulo(ByVal idE As Integer, ByVal idC As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Persona
                         Where p.escuela_id = idE And p.cede_id = idC And p.estado = 1
                         Select Cede = p.CededePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre, Apellido = p.apellido,
                                           Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, EscuelaDeVida = p.EscuelaDeVida.descripcion).ToList

        grid.DataSource = listapers
    End Sub

    'Lista los datos en un DataGridView cargados en Escuela por modulo y celula
    Sub BuscarPorModuloyCelula(ByVal idE As Integer, ByVal idC As Integer, ByVal grid As DataGridView)
        Dim listapers = (From p In ctx.Persona
                         Where p.escuela_id = idE And p.celula_id = idC And p.estado = 1
                         Select Cede = p.CededePersona.descripcion, Celula = p.CeluladePersona.nombre, Nombre = p.nombre, Apellido = p.apellido,
                                           Lider = p.LiderDePersona.PersonaQueEsLider.nombre + " " + p.LiderDePersona.PersonaQueEsLider.apellido, EscuelaDeVida = p.EscuelaDeVida.descripcion).ToList

        grid.DataSource = listapers
    End Sub

#End Region

End Class
