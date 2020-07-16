<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarPersona))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TLugarNac = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBarrio = New System.Windows.Forms.TextBox()
        Me.CBCede = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBCelula = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBLider = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TAño = New System.Windows.Forms.TextBox()
        Me.TLugar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CBModulo = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GBBautizado = New System.Windows.Forms.GroupBox()
        Me.RNoB = New System.Windows.Forms.RadioButton()
        Me.RSiB = New System.Windows.Forms.RadioButton()
        Me.GBEscuela = New System.Windows.Forms.GroupBox()
        Me.RNoV = New System.Windows.Forms.RadioButton()
        Me.RSiV = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.GBSexo = New System.Windows.Forms.GroupBox()
        Me.RMujer = New System.Windows.Forms.RadioButton()
        Me.RHombre = New System.Windows.Forms.RadioButton()
        Me.TIglesia = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.trabaja = New System.Windows.Forms.CheckBox()
        Me.estudia = New System.Windows.Forms.CheckBox()
        Me.otro = New System.Windows.Forms.CheckBox()
        Me.GBProfesion = New System.Windows.Forms.GroupBox()
        Me.GBBautizado.SuspendLayout()
        Me.GBEscuela.SuspendLayout()
        Me.GBSexo.SuspendLayout()
        Me.GBProfesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(249, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 33)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Agregar una nueva Persona"
        '
        'TLugarNac
        '
        Me.TLugarNac.Location = New System.Drawing.Point(175, 478)
        Me.TLugarNac.Name = "TLugarNac"
        Me.TLugarNac.Size = New System.Drawing.Size(147, 20)
        Me.TLugarNac.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(52, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha de Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(52, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Lugar de Nacimiento"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(175, 125)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(147, 20)
        Me.TApellido.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(52, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Apellido   "
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(175, 88)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(147, 20)
        Me.TNombre.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(52, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre   "
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BCancelar.Location = New System.Drawing.Point(436, 520)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(104, 36)
        Me.BCancelar.TabIndex = 14
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BGuardar.FlatAppearance.BorderSize = 0
        Me.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGuardar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BGuardar.Location = New System.Drawing.Point(285, 520)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(108, 36)
        Me.BGuardar.TabIndex = 13
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "   Celula  "
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(175, 238)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(147, 20)
        Me.TTelefono.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(52, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Teléfono  "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(52, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Barrio      "
        '
        'TBarrio
        '
        Me.TBarrio.Location = New System.Drawing.Point(175, 202)
        Me.TBarrio.Name = "TBarrio"
        Me.TBarrio.Size = New System.Drawing.Size(147, 20)
        Me.TBarrio.TabIndex = 26
        '
        'CBCede
        '
        Me.CBCede.FormattingEnabled = True
        Me.CBCede.Location = New System.Drawing.Point(577, 88)
        Me.CBCede.Name = "CBCede"
        Me.CBCede.Size = New System.Drawing.Size(145, 21)
        Me.CBCede.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(432, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 23)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "    Cede   "
        '
        'CBCelula
        '
        Me.CBCelula.FormattingEnabled = True
        Me.CBCelula.Location = New System.Drawing.Point(577, 126)
        Me.CBCelula.Name = "CBCelula"
        Me.CBCelula.Size = New System.Drawing.Size(145, 21)
        Me.CBCelula.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(431, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 23)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "    Lider   "
        '
        'CBLider
        '
        Me.CBLider.FormattingEnabled = True
        Me.CBLider.Location = New System.Drawing.Point(576, 167)
        Me.CBLider.Name = "CBLider"
        Me.CBLider.Size = New System.Drawing.Size(145, 21)
        Me.CBLider.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(431, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 23)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Está Bautizado?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(483, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 23)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "   Año    "
        '
        'TAño
        '
        Me.TAño.Location = New System.Drawing.Point(597, 326)
        Me.TAño.Name = "TAño"
        Me.TAño.Size = New System.Drawing.Size(126, 20)
        Me.TAño.TabIndex = 41
        '
        'TLugar
        '
        Me.TLugar.Location = New System.Drawing.Point(597, 289)
        Me.TLugar.Name = "TLugar"
        Me.TLugar.Size = New System.Drawing.Size(126, 20)
        Me.TLugar.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(483, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 23)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "  Lugar "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(432, 369)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(165, 23)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Hizo Escuela de vida?"
        '
        'CBModulo
        '
        Me.CBModulo.FormattingEnabled = True
        Me.CBModulo.Location = New System.Drawing.Point(577, 477)
        Me.CBModulo.Name = "CBModulo"
        Me.CBModulo.Size = New System.Drawing.Size(145, 21)
        Me.CBModulo.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(432, 442)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(217, 23)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Modulo en que se encuentra"
        '
        'DFechaNac
        '
        Me.DFechaNac.Location = New System.Drawing.Point(175, 408)
        Me.DFechaNac.Name = "DFechaNac"
        Me.DFechaNac.Size = New System.Drawing.Size(147, 20)
        Me.DFechaNac.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(52, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Ocupación:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(52, 324)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 23)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "     Sexo    "
        '
        'GBBautizado
        '
        Me.GBBautizado.Controls.Add(Me.RNoB)
        Me.GBBautizado.Controls.Add(Me.RSiB)
        Me.GBBautizado.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GBBautizado.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBBautizado.Location = New System.Drawing.Point(577, 207)
        Me.GBBautizado.Margin = New System.Windows.Forms.Padding(2)
        Me.GBBautizado.Name = "GBBautizado"
        Me.GBBautizado.Padding = New System.Windows.Forms.Padding(2)
        Me.GBBautizado.Size = New System.Drawing.Size(146, 37)
        Me.GBBautizado.TabIndex = 73
        Me.GBBautizado.TabStop = False
        '
        'RNoB
        '
        Me.RNoB.AutoSize = True
        Me.RNoB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RNoB.Location = New System.Drawing.Point(85, 11)
        Me.RNoB.Name = "RNoB"
        Me.RNoB.Size = New System.Drawing.Size(39, 17)
        Me.RNoB.TabIndex = 78
        Me.RNoB.TabStop = True
        Me.RNoB.Text = "No"
        Me.RNoB.UseVisualStyleBackColor = True
        '
        'RSiB
        '
        Me.RSiB.AutoSize = True
        Me.RSiB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RSiB.Location = New System.Drawing.Point(21, 11)
        Me.RSiB.Name = "RSiB"
        Me.RSiB.Size = New System.Drawing.Size(34, 17)
        Me.RSiB.TabIndex = 77
        Me.RSiB.TabStop = True
        Me.RSiB.Text = "Si"
        Me.RSiB.UseVisualStyleBackColor = True
        '
        'GBEscuela
        '
        Me.GBEscuela.Controls.Add(Me.RNoV)
        Me.GBEscuela.Controls.Add(Me.RSiV)
        Me.GBEscuela.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GBEscuela.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBEscuela.Location = New System.Drawing.Point(577, 394)
        Me.GBEscuela.Margin = New System.Windows.Forms.Padding(2)
        Me.GBEscuela.Name = "GBEscuela"
        Me.GBEscuela.Padding = New System.Windows.Forms.Padding(2)
        Me.GBEscuela.Size = New System.Drawing.Size(146, 38)
        Me.GBEscuela.TabIndex = 74
        Me.GBEscuela.TabStop = False
        '
        'RNoV
        '
        Me.RNoV.AutoSize = True
        Me.RNoV.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RNoV.Location = New System.Drawing.Point(84, 14)
        Me.RNoV.Name = "RNoV"
        Me.RNoV.Size = New System.Drawing.Size(39, 17)
        Me.RNoV.TabIndex = 79
        Me.RNoV.TabStop = True
        Me.RNoV.Text = "No"
        Me.RNoV.UseVisualStyleBackColor = True
        '
        'RSiV
        '
        Me.RSiV.AutoSize = True
        Me.RSiV.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RSiV.Location = New System.Drawing.Point(20, 14)
        Me.RSiV.Name = "RSiV"
        Me.RSiV.Size = New System.Drawing.Size(34, 17)
        Me.RSiV.TabIndex = 78
        Me.RSiV.TabStop = True
        Me.RSiV.Text = "Si"
        Me.RSiV.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(52, 163)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 23)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "Dirección "
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(175, 163)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(147, 20)
        Me.TDireccion.TabIndex = 75
        '
        'GBSexo
        '
        Me.GBSexo.Controls.Add(Me.RMujer)
        Me.GBSexo.Controls.Add(Me.RHombre)
        Me.GBSexo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GBSexo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBSexo.Location = New System.Drawing.Point(174, 319)
        Me.GBSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.GBSexo.Name = "GBSexo"
        Me.GBSexo.Padding = New System.Windows.Forms.Padding(2)
        Me.GBSexo.Size = New System.Drawing.Size(146, 37)
        Me.GBSexo.TabIndex = 79
        Me.GBSexo.TabStop = False
        '
        'RMujer
        '
        Me.RMujer.AutoSize = True
        Me.RMujer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RMujer.Location = New System.Drawing.Point(85, 11)
        Me.RMujer.Name = "RMujer"
        Me.RMujer.Size = New System.Drawing.Size(51, 17)
        Me.RMujer.TabIndex = 78
        Me.RMujer.TabStop = True
        Me.RMujer.Text = "Mujer"
        Me.RMujer.UseVisualStyleBackColor = True
        '
        'RHombre
        '
        Me.RHombre.AutoSize = True
        Me.RHombre.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RHombre.Location = New System.Drawing.Point(5, 11)
        Me.RHombre.Name = "RHombre"
        Me.RHombre.Size = New System.Drawing.Size(62, 17)
        Me.RHombre.TabIndex = 77
        Me.RHombre.TabStop = True
        Me.RHombre.Text = "Hombre"
        Me.RHombre.UseVisualStyleBackColor = True
        '
        'TIglesia
        '
        Me.TIglesia.Location = New System.Drawing.Point(597, 257)
        Me.TIglesia.Name = "TIglesia"
        Me.TIglesia.Size = New System.Drawing.Size(126, 20)
        Me.TIglesia.TabIndex = 81
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(483, 254)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 23)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "  Iglesia"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(728, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 44)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Agregar Lider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'trabaja
        '
        Me.trabaja.AutoSize = True
        Me.trabaja.BackColor = System.Drawing.Color.Transparent
        Me.trabaja.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.trabaja.Location = New System.Drawing.Point(5, 12)
        Me.trabaja.Name = "trabaja"
        Me.trabaja.Size = New System.Drawing.Size(62, 17)
        Me.trabaja.TabIndex = 83
        Me.trabaja.Text = "Trabaja"
        Me.trabaja.UseVisualStyleBackColor = False
        '
        'estudia
        '
        Me.estudia.AutoSize = True
        Me.estudia.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.estudia.Location = New System.Drawing.Point(73, 12)
        Me.estudia.Name = "estudia"
        Me.estudia.Size = New System.Drawing.Size(61, 17)
        Me.estudia.TabIndex = 84
        Me.estudia.Text = "Estudia"
        Me.estudia.UseVisualStyleBackColor = True
        '
        'otro
        '
        Me.otro.AutoSize = True
        Me.otro.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.otro.Location = New System.Drawing.Point(131, 12)
        Me.otro.Name = "otro"
        Me.otro.Size = New System.Drawing.Size(46, 17)
        Me.otro.TabIndex = 85
        Me.otro.Text = "Otro"
        Me.otro.UseVisualStyleBackColor = True
        '
        'GBProfesion
        '
        Me.GBProfesion.Controls.Add(Me.trabaja)
        Me.GBProfesion.Controls.Add(Me.otro)
        Me.GBProfesion.Controls.Add(Me.estudia)
        Me.GBProfesion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GBProfesion.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBProfesion.Location = New System.Drawing.Point(161, 272)
        Me.GBProfesion.Margin = New System.Windows.Forms.Padding(2)
        Me.GBProfesion.Name = "GBProfesion"
        Me.GBProfesion.Padding = New System.Windows.Forms.Padding(2)
        Me.GBProfesion.Size = New System.Drawing.Size(176, 37)
        Me.GBProfesion.TabIndex = 80
        Me.GBProfesion.TabStop = False
        '
        'AgregarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 579)
        Me.Controls.Add(Me.GBProfesion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TIglesia)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GBSexo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.GBEscuela)
        Me.Controls.Add(Me.GBBautizado)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DFechaNac)
        Me.Controls.Add(Me.CBModulo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TAño)
        Me.Controls.Add(Me.TLugar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CBLider)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CBCelula)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CBCede)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBarrio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TLugarNac)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GBBautizado.ResumeLayout(False)
        Me.GBBautizado.PerformLayout()
        Me.GBEscuela.ResumeLayout(False)
        Me.GBEscuela.PerformLayout()
        Me.GBSexo.ResumeLayout(False)
        Me.GBSexo.PerformLayout()
        Me.GBProfesion.ResumeLayout(False)
        Me.GBProfesion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TLugarNac As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TBarrio As TextBox
    Friend WithEvents CBCede As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CBCelula As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CBLider As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TAño As TextBox
    Friend WithEvents TLugar As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CBModulo As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DFechaNac As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GBBautizado As GroupBox
    Friend WithEvents GBEscuela As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents RNoB As RadioButton
    Friend WithEvents RSiB As RadioButton
    Friend WithEvents RNoV As RadioButton
    Friend WithEvents RSiV As RadioButton
    Friend WithEvents GBSexo As GroupBox
    Friend WithEvents RMujer As RadioButton
    Friend WithEvents RHombre As RadioButton
    Friend WithEvents TIglesia As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents trabaja As CheckBox
    Friend WithEvents estudia As CheckBox
    Friend WithEvents otro As CheckBox
    Friend WithEvents GBProfesion As GroupBox
End Class
