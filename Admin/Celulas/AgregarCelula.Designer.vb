<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCelula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCelula))
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TMesInicio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TAñoInicio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBLider = New System.Windows.Forms.ComboBox()
        Me.CBAuxiliar = New System.Windows.Forms.ComboBox()
        Me.THorario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBCede = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GBSexo = New System.Windows.Forms.GroupBox()
        Me.hombre = New System.Windows.Forms.CheckBox()
        Me.mujer = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GBDirigido = New System.Windows.Forms.GroupBox()
        Me.matri = New System.Windows.Forms.RadioButton()
        Me.adoles = New System.Windows.Forms.RadioButton()
        Me.jov = New System.Windows.Forms.RadioButton()
        Me.CBRed = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BAgregarRed = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.GBSexo.SuspendLayout()
        Me.GBDirigido.SuspendLayout()
        Me.SuspendLayout()
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BCancelar.Location = New System.Drawing.Point(449, 564)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(118, 49)
        Me.BCancelar.TabIndex = 1
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(177, 191)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(149, 26)
        Me.TNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(45, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " Nombre "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(44, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "    Lider   "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(44, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "  Auxiliar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(428, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mes de Inicio"
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(586, 259)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(155, 26)
        Me.TDireccion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(427, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "  Dirección "
        '
        'TMesInicio
        '
        Me.TMesInicio.Location = New System.Drawing.Point(585, 327)
        Me.TMesInicio.Name = "TMesInicio"
        Me.TMesInicio.Size = New System.Drawing.Size(155, 26)
        Me.TMesInicio.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(271, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(356, 39)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Agregar una nueva Celula"
        '
        'TAñoInicio
        '
        Me.TAñoInicio.Location = New System.Drawing.Point(585, 395)
        Me.TAñoInicio.Name = "TAñoInicio"
        Me.TAñoInicio.Size = New System.Drawing.Size(155, 26)
        Me.TAñoInicio.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkGray
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(428, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Año de Inicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkGray
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(44, 456)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = " Dirigio a"
        '
        'CBLider
        '
        Me.CBLider.FormattingEnabled = True
        Me.CBLider.Location = New System.Drawing.Point(177, 271)
        Me.CBLider.Name = "CBLider"
        Me.CBLider.Size = New System.Drawing.Size(149, 26)
        Me.CBLider.TabIndex = 17
        '
        'CBAuxiliar
        '
        Me.CBAuxiliar.FormattingEnabled = True
        Me.CBAuxiliar.Location = New System.Drawing.Point(177, 361)
        Me.CBAuxiliar.Name = "CBAuxiliar"
        Me.CBAuxiliar.Size = New System.Drawing.Size(149, 26)
        Me.CBAuxiliar.TabIndex = 18
        '
        'THorario
        '
        Me.THorario.Location = New System.Drawing.Point(585, 195)
        Me.THorario.Name = "THorario"
        Me.THorario.Size = New System.Drawing.Size(155, 26)
        Me.THorario.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DarkGray
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(427, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "   Horario  "
        '
        'CBCede
        '
        Me.CBCede.FormattingEnabled = True
        Me.CBCede.Location = New System.Drawing.Point(177, 124)
        Me.CBCede.Name = "CBCede"
        Me.CBCede.Size = New System.Drawing.Size(149, 26)
        Me.CBCede.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkGray
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(45, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "   Cede    "
        '
        'GBSexo
        '
        Me.GBSexo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GBSexo.Controls.Add(Me.hombre)
        Me.GBSexo.Controls.Add(Me.mujer)
        Me.GBSexo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBSexo.Location = New System.Drawing.Point(586, 119)
        Me.GBSexo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBSexo.Name = "GBSexo"
        Me.GBSexo.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBSexo.Size = New System.Drawing.Size(155, 37)
        Me.GBSexo.TabIndex = 81
        Me.GBSexo.TabStop = False
        '
        'hombre
        '
        Me.hombre.AutoSize = True
        Me.hombre.BackColor = System.Drawing.Color.Transparent
        Me.hombre.Location = New System.Drawing.Point(5, 9)
        Me.hombre.Name = "hombre"
        Me.hombre.Size = New System.Drawing.Size(80, 22)
        Me.hombre.TabIndex = 83
        Me.hombre.Text = "Hombre"
        Me.hombre.UseVisualStyleBackColor = False
        '
        'mujer
        '
        Me.mujer.AutoSize = True
        Me.mujer.Location = New System.Drawing.Point(91, 9)
        Me.mujer.Name = "mujer"
        Me.mujer.Size = New System.Drawing.Size(65, 22)
        Me.mujer.TabIndex = 84
        Me.mujer.Text = "Mujer"
        Me.mujer.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkGray
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(427, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 25)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "  Dirigio a  "
        '
        'GBDirigido
        '
        Me.GBDirigido.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GBDirigido.Controls.Add(Me.matri)
        Me.GBDirigido.Controls.Add(Me.adoles)
        Me.GBDirigido.Controls.Add(Me.jov)
        Me.GBDirigido.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GBDirigido.Location = New System.Drawing.Point(180, 436)
        Me.GBDirigido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBDirigido.Name = "GBDirigido"
        Me.GBDirigido.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBDirigido.Size = New System.Drawing.Size(146, 83)
        Me.GBDirigido.TabIndex = 83
        Me.GBDirigido.TabStop = False
        '
        'matri
        '
        Me.matri.AutoSize = True
        Me.matri.Location = New System.Drawing.Point(14, 56)
        Me.matri.Name = "matri"
        Me.matri.Size = New System.Drawing.Size(110, 22)
        Me.matri.TabIndex = 79
        Me.matri.TabStop = True
        Me.matri.Text = "Matrimonios"
        Me.matri.UseVisualStyleBackColor = True
        '
        'adoles
        '
        Me.adoles.AutoSize = True
        Me.adoles.Location = New System.Drawing.Point(14, 34)
        Me.adoles.Name = "adoles"
        Me.adoles.Size = New System.Drawing.Size(116, 22)
        Me.adoles.TabIndex = 78
        Me.adoles.TabStop = True
        Me.adoles.Text = "Adolescentes"
        Me.adoles.UseVisualStyleBackColor = True
        '
        'jov
        '
        Me.jov.AutoSize = True
        Me.jov.Location = New System.Drawing.Point(23, 13)
        Me.jov.Name = "jov"
        Me.jov.Size = New System.Drawing.Size(82, 22)
        Me.jov.TabIndex = 77
        Me.jov.TabStop = True
        Me.jov.Text = "Jóvenes"
        Me.jov.UseVisualStyleBackColor = True
        '
        'CBRed
        '
        Me.CBRed.FormattingEnabled = True
        Me.CBRed.Location = New System.Drawing.Point(585, 464)
        Me.CBRed.Name = "CBRed"
        Me.CBRed.Size = New System.Drawing.Size(155, 26)
        Me.CBRed.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DarkGray
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(430, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 25)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "   Red   "
        '
        'BAgregarRed
        '
        Me.BAgregarRed.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BAgregarRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BAgregarRed.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BAgregarRed.FlatAppearance.BorderSize = 0
        Me.BAgregarRed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BAgregarRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAgregarRed.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregarRed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BAgregarRed.Location = New System.Drawing.Point(763, 458)
        Me.BAgregarRed.Name = "BAgregarRed"
        Me.BAgregarRed.Size = New System.Drawing.Size(70, 48)
        Me.BAgregarRed.TabIndex = 86
        Me.BAgregarRed.Text = "Agregar Red"
        Me.BAgregarRed.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BGuardar.FlatAppearance.BorderSize = 0
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGuardar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BGuardar.Location = New System.Drawing.Point(265, 564)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(113, 49)
        Me.BGuardar.TabIndex = 0
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'AgregarCelula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 586)
        Me.Controls.Add(Me.BAgregarRed)
        Me.Controls.Add(Me.CBRed)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GBDirigido)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GBSexo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CBCede)
        Me.Controls.Add(Me.THorario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CBAuxiliar)
        Me.Controls.Add(Me.CBLider)
        Me.Controls.Add(Me.TAñoInicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TMesInicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarCelula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GBSexo.ResumeLayout(False)
        Me.GBSexo.PerformLayout()
        Me.GBDirigido.ResumeLayout(False)
        Me.GBDirigido.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BCancelar As Button
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TMesInicio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TAñoInicio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CBLider As ComboBox
    Friend WithEvents CBAuxiliar As ComboBox
    Friend WithEvents THorario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBCede As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GBSexo As GroupBox
    Friend WithEvents hombre As CheckBox
    Friend WithEvents mujer As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GBDirigido As GroupBox
    Friend WithEvents matri As RadioButton
    Friend WithEvents adoles As RadioButton
    Friend WithEvents jov As RadioButton
    Friend WithEvents CBRed As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BAgregarRed As Button
    Friend WithEvents BGuardar As Button
End Class
