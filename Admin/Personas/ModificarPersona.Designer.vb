<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarPersona))
        Me.DGPersonas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TProfesion = New System.Windows.Forms.TextBox()
        Me.DFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.CBModulo = New System.Windows.Forms.ComboBox()
        Me.TAño = New System.Windows.Forms.TextBox()
        Me.TLugar = New System.Windows.Forms.TextBox()
        Me.CBLider = New System.Windows.Forms.ComboBox()
        Me.CBCelula = New System.Windows.Forms.ComboBox()
        Me.CBCede = New System.Windows.Forms.ComboBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TLugarNac = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardarModifif = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TIglesia = New System.Windows.Forms.TextBox()
        Me.GBSexo = New System.Windows.Forms.GroupBox()
        Me.RMujer = New System.Windows.Forms.RadioButton()
        Me.RHombre = New System.Windows.Forms.RadioButton()
        Me.Barrio = New System.Windows.Forms.Label()
        Me.TBarrio = New System.Windows.Forms.TextBox()
        Me.GBBautizado = New System.Windows.Forms.GroupBox()
        Me.RNoB = New System.Windows.Forms.RadioButton()
        Me.RSiB = New System.Windows.Forms.RadioButton()
        Me.GBEscuela = New System.Windows.Forms.GroupBox()
        Me.RNoV = New System.Windows.Forms.RadioButton()
        Me.RSiV = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBuscador = New System.Windows.Forms.TextBox()
        Me.Tid = New System.Windows.Forms.TextBox()
        CType(Me.DGPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBSexo.SuspendLayout()
        Me.GBBautizado.SuspendLayout()
        Me.GBEscuela.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGPersonas
        '
        Me.DGPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGPersonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGPersonas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPersonas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGPersonas.Location = New System.Drawing.Point(12, 47)
        Me.DGPersonas.Name = "DGPersonas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGPersonas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGPersonas.RowHeadersVisible = False
        Me.DGPersonas.Size = New System.Drawing.Size(1082, 250)
        Me.DGPersonas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione una Persona"
        '
        'TProfesion
        '
        Me.TProfesion.Location = New System.Drawing.Point(178, 557)
        Me.TProfesion.Name = "TProfesion"
        Me.TProfesion.Size = New System.Drawing.Size(147, 20)
        Me.TProfesion.TabIndex = 104
        '
        'DFechaNac
        '
        Me.DFechaNac.Location = New System.Drawing.Point(541, 382)
        Me.DFechaNac.Name = "DFechaNac"
        Me.DFechaNac.Size = New System.Drawing.Size(147, 20)
        Me.DFechaNac.TabIndex = 102
        '
        'CBModulo
        '
        Me.CBModulo.FormattingEnabled = True
        Me.CBModulo.Location = New System.Drawing.Point(899, 612)
        Me.CBModulo.Name = "CBModulo"
        Me.CBModulo.Size = New System.Drawing.Size(145, 21)
        Me.CBModulo.TabIndex = 101
        '
        'TAño
        '
        Me.TAño.Location = New System.Drawing.Point(901, 467)
        Me.TAño.Name = "TAño"
        Me.TAño.Size = New System.Drawing.Size(146, 20)
        Me.TAño.TabIndex = 97
        '
        'TLugar
        '
        Me.TLugar.Location = New System.Drawing.Point(901, 430)
        Me.TLugar.Name = "TLugar"
        Me.TLugar.Size = New System.Drawing.Size(146, 20)
        Me.TLugar.TabIndex = 96
        '
        'CBLider
        '
        Me.CBLider.FormattingEnabled = True
        Me.CBLider.Location = New System.Drawing.Point(543, 603)
        Me.CBLider.Name = "CBLider"
        Me.CBLider.Size = New System.Drawing.Size(145, 21)
        Me.CBLider.TabIndex = 93
        '
        'CBCelula
        '
        Me.CBCelula.FormattingEnabled = True
        Me.CBCelula.Location = New System.Drawing.Point(541, 550)
        Me.CBCelula.Name = "CBCelula"
        Me.CBCelula.Size = New System.Drawing.Size(145, 21)
        Me.CBCelula.TabIndex = 91
        '
        'CBCede
        '
        Me.CBCede.FormattingEnabled = True
        Me.CBCede.Location = New System.Drawing.Point(541, 504)
        Me.CBCede.Name = "CBCede"
        Me.CBCede.Size = New System.Drawing.Size(145, 21)
        Me.CBCede.TabIndex = 89
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(179, 515)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(147, 20)
        Me.TTelefono.TabIndex = 87
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(178, 438)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(147, 20)
        Me.TDireccion.TabIndex = 84
        '
        'TLugarNac
        '
        Me.TLugarNac.Location = New System.Drawing.Point(541, 460)
        Me.TLugarNac.Name = "TLugarNac"
        Me.TLugarNac.Size = New System.Drawing.Size(147, 20)
        Me.TLugarNac.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(369, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 25)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Fecha de Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(369, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 25)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Lugar de Nacimiento"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(178, 391)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(147, 20)
        Me.TApellido.TabIndex = 80
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(178, 350)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(148, 20)
        Me.TNombre.TabIndex = 78
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BCancelar.Location = New System.Drawing.Point(592, 651)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(104, 36)
        Me.BCancelar.TabIndex = 76
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardarModifif
        '
        Me.BGuardarModifif.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BGuardarModifif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BGuardarModifif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGuardarModifif.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardarModifif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BGuardarModifif.Location = New System.Drawing.Point(423, 651)
        Me.BGuardarModifif.Name = "BGuardarModifif"
        Me.BGuardarModifif.Size = New System.Drawing.Size(108, 36)
        Me.BGuardarModifif.TabIndex = 75
        Me.BGuardarModifif.Text = "Guardar"
        Me.BGuardarModifif.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(52, 599)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 25)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Sexo           "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(52, 550)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Profesión"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(52, 508)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 25)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Teléfono  "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(52, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 25)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(52, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Apellido   "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(54, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Nombre   "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(721, 575)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(243, 25)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Modulo en que se encuentra"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(727, 493)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(188, 25)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Hizo Escuela de vida?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(780, 453)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 25)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Año     "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(780, 419)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 25)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Lugar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(727, 343)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 25)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Está Bautizado?"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(369, 599)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 25)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Lider       "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(369, 497)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 25)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Cede       "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(369, 550)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 25)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Celula    "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(780, 384)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 25)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Iglesia"
        '
        'TIglesia
        '
        Me.TIglesia.Location = New System.Drawing.Point(901, 391)
        Me.TIglesia.Name = "TIglesia"
        Me.TIglesia.Size = New System.Drawing.Size(146, 20)
        Me.TIglesia.TabIndex = 117
        '
        'GBSexo
        '
        Me.GBSexo.Controls.Add(Me.RMujer)
        Me.GBSexo.Controls.Add(Me.RHombre)
        Me.GBSexo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBSexo.Location = New System.Drawing.Point(180, 599)
        Me.GBSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.GBSexo.Name = "GBSexo"
        Me.GBSexo.Padding = New System.Windows.Forms.Padding(2)
        Me.GBSexo.Size = New System.Drawing.Size(146, 37)
        Me.GBSexo.TabIndex = 119
        Me.GBSexo.TabStop = False
        '
        'RMujer
        '
        Me.RMujer.AutoSize = True
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
        Me.RHombre.Location = New System.Drawing.Point(5, 11)
        Me.RHombre.Name = "RHombre"
        Me.RHombre.Size = New System.Drawing.Size(62, 17)
        Me.RHombre.TabIndex = 77
        Me.RHombre.TabStop = True
        Me.RHombre.Text = "Hombre"
        Me.RHombre.UseVisualStyleBackColor = True
        '
        'Barrio
        '
        Me.Barrio.AutoSize = True
        Me.Barrio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Barrio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barrio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Barrio.Location = New System.Drawing.Point(52, 469)
        Me.Barrio.Name = "Barrio"
        Me.Barrio.Size = New System.Drawing.Size(64, 25)
        Me.Barrio.TabIndex = 120
        Me.Barrio.Text = "Barrio"
        '
        'TBarrio
        '
        Me.TBarrio.Location = New System.Drawing.Point(178, 476)
        Me.TBarrio.Name = "TBarrio"
        Me.TBarrio.Size = New System.Drawing.Size(147, 20)
        Me.TBarrio.TabIndex = 121
        '
        'GBBautizado
        '
        Me.GBBautizado.Controls.Add(Me.RNoB)
        Me.GBBautizado.Controls.Add(Me.RSiB)
        Me.GBBautizado.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBBautizado.Location = New System.Drawing.Point(899, 336)
        Me.GBBautizado.Margin = New System.Windows.Forms.Padding(2)
        Me.GBBautizado.Name = "GBBautizado"
        Me.GBBautizado.Padding = New System.Windows.Forms.Padding(2)
        Me.GBBautizado.Size = New System.Drawing.Size(146, 37)
        Me.GBBautizado.TabIndex = 122
        Me.GBBautizado.TabStop = False
        '
        'RNoB
        '
        Me.RNoB.AutoSize = True
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
        Me.GBEscuela.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBEscuela.Location = New System.Drawing.Point(909, 526)
        Me.GBEscuela.Margin = New System.Windows.Forms.Padding(2)
        Me.GBEscuela.Name = "GBEscuela"
        Me.GBEscuela.Padding = New System.Windows.Forms.Padding(2)
        Me.GBEscuela.Size = New System.Drawing.Size(146, 38)
        Me.GBEscuela.TabIndex = 123
        Me.GBEscuela.TabStop = False
        '
        'RNoV
        '
        Me.RNoV.AutoSize = True
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
        Me.RSiV.Location = New System.Drawing.Point(20, 14)
        Me.RSiV.Name = "RSiV"
        Me.RSiV.Size = New System.Drawing.Size(34, 17)
        Me.RSiV.TabIndex = 78
        Me.RSiV.TabStop = True
        Me.RSiV.Text = "Si"
        Me.RSiV.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Location = New System.Drawing.Point(964, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "IDENTIFICACION:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(1035, 14)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 20)
        Me.Label20.TabIndex = 134
        Me.Label20.Text = "Buscar"
        '
        'TBuscador
        '
        Me.TBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscador.Location = New System.Drawing.Point(793, 11)
        Me.TBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.TBuscador.Name = "TBuscador"
        Me.TBuscador.Size = New System.Drawing.Size(234, 26)
        Me.TBuscador.TabIndex = 133
        '
        'Tid
        '
        Me.Tid.Location = New System.Drawing.Point(1065, 306)
        Me.Tid.Name = "Tid"
        Me.Tid.Size = New System.Drawing.Size(29, 20)
        Me.Tid.TabIndex = 125
        '
        'ModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1107, 699)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TBuscador)
        Me.Controls.Add(Me.Tid)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GBEscuela)
        Me.Controls.Add(Me.GBBautizado)
        Me.Controls.Add(Me.Barrio)
        Me.Controls.Add(Me.TBarrio)
        Me.Controls.Add(Me.GBSexo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TIglesia)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TProfesion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DFechaNac)
        Me.Controls.Add(Me.CBModulo)
        Me.Controls.Add(Me.TAño)
        Me.Controls.Add(Me.TLugar)
        Me.Controls.Add(Me.CBLider)
        Me.Controls.Add(Me.CBCelula)
        Me.Controls.Add(Me.CBCede)
        Me.Controls.Add(Me.TTelefono)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.TLugarNac)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardarModifif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGPersonas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBSexo.ResumeLayout(False)
        Me.GBSexo.PerformLayout()
        Me.GBBautizado.ResumeLayout(False)
        Me.GBBautizado.PerformLayout()
        Me.GBEscuela.ResumeLayout(False)
        Me.GBEscuela.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGPersonas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TProfesion As TextBox
    Friend WithEvents DFechaNac As DateTimePicker
    Friend WithEvents CBModulo As ComboBox
    Friend WithEvents TAño As TextBox
    Friend WithEvents TLugar As TextBox
    Friend WithEvents CBLider As ComboBox
    Friend WithEvents CBCelula As ComboBox
    Friend WithEvents CBCede As ComboBox
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TLugarNac As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardarModifif As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TIglesia As TextBox
    Friend WithEvents GBSexo As GroupBox
    Friend WithEvents RMujer As RadioButton
    Friend WithEvents RHombre As RadioButton
    Friend WithEvents Barrio As Label
    Friend WithEvents TBarrio As TextBox
    Friend WithEvents GBBautizado As GroupBox
    Friend WithEvents RNoB As RadioButton
    Friend WithEvents RSiB As RadioButton
    Friend WithEvents GBEscuela As GroupBox
    Friend WithEvents RNoV As RadioButton
    Friend WithEvents RSiV As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TBuscador As TextBox
    Friend WithEvents Tid As TextBox
End Class
