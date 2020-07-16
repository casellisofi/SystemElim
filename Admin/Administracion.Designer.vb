<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administracion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BAddPers = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BModPers = New System.Windows.Forms.Button()
        Me.BBajaPers = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BBajaCelula = New System.Windows.Forms.Button()
        Me.BModCelula = New System.Windows.Forms.Button()
        Me.BAddCelula = New System.Windows.Forms.Button()
        Me.BBajaArea = New System.Windows.Forms.Button()
        Me.BModArea = New System.Windows.Forms.Button()
        Me.BAddArea = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BLArea = New System.Windows.Forms.Button()
        Me.BLCelula = New System.Windows.Forms.Button()
        Me.BLPersona = New System.Windows.Forms.Button()
        Me.BCant = New System.Windows.Forms.Button()
        Me.BReportCel = New System.Windows.Forms.Button()
        Me.Blistadorepor = New System.Windows.Forms.Button()
        Me.BEstad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(221, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido a AdminElim!"
        '
        'BAddPers
        '
        Me.BAddPers.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BAddPers.FlatAppearance.BorderSize = 0
        Me.BAddPers.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BAddPers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BAddPers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAddPers.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAddPers.Location = New System.Drawing.Point(103, 232)
        Me.BAddPers.Name = "BAddPers"
        Me.BAddPers.Size = New System.Drawing.Size(106, 26)
        Me.BAddPers.TabIndex = 2
        Me.BAddPers.Text = "Agregar"
        Me.BAddPers.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(28, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gestión de Personas"
        '
        'BModPers
        '
        Me.BModPers.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BModPers.FlatAppearance.BorderSize = 0
        Me.BModPers.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BModPers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BModPers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModPers.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModPers.Location = New System.Drawing.Point(103, 286)
        Me.BModPers.Name = "BModPers"
        Me.BModPers.Size = New System.Drawing.Size(106, 26)
        Me.BModPers.TabIndex = 5
        Me.BModPers.Text = "Modificar"
        Me.BModPers.UseVisualStyleBackColor = True
        '
        'BBajaPers
        '
        Me.BBajaPers.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BBajaPers.FlatAppearance.BorderSize = 0
        Me.BBajaPers.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BBajaPers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BBajaPers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBajaPers.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBajaPers.Location = New System.Drawing.Point(103, 334)
        Me.BBajaPers.Name = "BBajaPers"
        Me.BBajaPers.Size = New System.Drawing.Size(106, 26)
        Me.BBajaPers.TabIndex = 6
        Me.BBajaPers.Text = "Dar de Baja Personas"
        Me.BBajaPers.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(293, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gestión de Celulas"
        '
        'BBajaCelula
        '
        Me.BBajaCelula.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BBajaCelula.FlatAppearance.BorderSize = 0
        Me.BBajaCelula.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BBajaCelula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BBajaCelula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBajaCelula.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBajaCelula.Location = New System.Drawing.Point(352, 334)
        Me.BBajaCelula.Name = "BBajaCelula"
        Me.BBajaCelula.Size = New System.Drawing.Size(110, 26)
        Me.BBajaCelula.TabIndex = 10
        Me.BBajaCelula.Text = "Dar de Baja"
        Me.BBajaCelula.UseVisualStyleBackColor = True
        '
        'BModCelula
        '
        Me.BModCelula.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BModCelula.FlatAppearance.BorderSize = 0
        Me.BModCelula.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BModCelula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BModCelula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModCelula.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModCelula.Location = New System.Drawing.Point(352, 286)
        Me.BModCelula.Name = "BModCelula"
        Me.BModCelula.Size = New System.Drawing.Size(110, 26)
        Me.BModCelula.TabIndex = 9
        Me.BModCelula.Text = "Modificar"
        Me.BModCelula.UseVisualStyleBackColor = True
        '
        'BAddCelula
        '
        Me.BAddCelula.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BAddCelula.FlatAppearance.BorderSize = 0
        Me.BAddCelula.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BAddCelula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BAddCelula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAddCelula.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAddCelula.Location = New System.Drawing.Point(352, 232)
        Me.BAddCelula.Name = "BAddCelula"
        Me.BAddCelula.Size = New System.Drawing.Size(110, 26)
        Me.BAddCelula.TabIndex = 8
        Me.BAddCelula.Text = "Agregar"
        Me.BAddCelula.UseVisualStyleBackColor = True
        '
        'BBajaArea
        '
        Me.BBajaArea.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BBajaArea.FlatAppearance.BorderSize = 0
        Me.BBajaArea.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BBajaArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BBajaArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBajaArea.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBajaArea.Location = New System.Drawing.Point(588, 334)
        Me.BBajaArea.Name = "BBajaArea"
        Me.BBajaArea.Size = New System.Drawing.Size(110, 26)
        Me.BBajaArea.TabIndex = 14
        Me.BBajaArea.Text = "Dar de Baja "
        Me.BBajaArea.UseVisualStyleBackColor = True
        '
        'BModArea
        '
        Me.BModArea.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BModArea.FlatAppearance.BorderSize = 0
        Me.BModArea.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BModArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BModArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModArea.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModArea.Location = New System.Drawing.Point(588, 286)
        Me.BModArea.Name = "BModArea"
        Me.BModArea.Size = New System.Drawing.Size(110, 26)
        Me.BModArea.TabIndex = 13
        Me.BModArea.Text = "Modificar"
        Me.BModArea.UseVisualStyleBackColor = True
        '
        'BAddArea
        '
        Me.BAddArea.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BAddArea.FlatAppearance.BorderSize = 0
        Me.BAddArea.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BAddArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BAddArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAddArea.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAddArea.Location = New System.Drawing.Point(588, 232)
        Me.BAddArea.Name = "BAddArea"
        Me.BAddArea.Size = New System.Drawing.Size(110, 26)
        Me.BAddArea.TabIndex = 12
        Me.BAddArea.Text = "Agregar"
        Me.BAddArea.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(540, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 33)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Gestión de Áreas"
        '
        'BLArea
        '
        Me.BLArea.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BLArea.FlatAppearance.BorderSize = 0
        Me.BLArea.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BLArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BLArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLArea.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLArea.Location = New System.Drawing.Point(588, 389)
        Me.BLArea.Name = "BLArea"
        Me.BLArea.Size = New System.Drawing.Size(110, 26)
        Me.BLArea.TabIndex = 15
        Me.BLArea.Text = "Listado"
        Me.BLArea.UseVisualStyleBackColor = True
        '
        'BLCelula
        '
        Me.BLCelula.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BLCelula.FlatAppearance.BorderSize = 0
        Me.BLCelula.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BLCelula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BLCelula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLCelula.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLCelula.Location = New System.Drawing.Point(352, 389)
        Me.BLCelula.Name = "BLCelula"
        Me.BLCelula.Size = New System.Drawing.Size(110, 26)
        Me.BLCelula.TabIndex = 16
        Me.BLCelula.Text = "Listado"
        Me.BLCelula.UseVisualStyleBackColor = True
        '
        'BLPersona
        '
        Me.BLPersona.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BLPersona.FlatAppearance.BorderSize = 0
        Me.BLPersona.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BLPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BLPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLPersona.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLPersona.Location = New System.Drawing.Point(103, 389)
        Me.BLPersona.Name = "BLPersona"
        Me.BLPersona.Size = New System.Drawing.Size(106, 26)
        Me.BLPersona.TabIndex = 17
        Me.BLPersona.Text = "Listado"
        Me.BLPersona.UseVisualStyleBackColor = True
        '
        'BCant
        '
        Me.BCant.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BCant.FlatAppearance.BorderSize = 0
        Me.BCant.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BCant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BCant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCant.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCant.Location = New System.Drawing.Point(473, 494)
        Me.BCant.Name = "BCant"
        Me.BCant.Size = New System.Drawing.Size(141, 28)
        Me.BCant.TabIndex = 18
        Me.BCant.Text = "Cantidades"
        Me.BCant.UseVisualStyleBackColor = True
        '
        'BReportCel
        '
        Me.BReportCel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BReportCel.FlatAppearance.BorderSize = 0
        Me.BReportCel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BReportCel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BReportCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BReportCel.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BReportCel.Location = New System.Drawing.Point(34, 494)
        Me.BReportCel.Name = "BReportCel"
        Me.BReportCel.Size = New System.Drawing.Size(141, 29)
        Me.BReportCel.TabIndex = 19
        Me.BReportCel.Text = "Reporte Celular"
        Me.BReportCel.UseVisualStyleBackColor = True
        '
        'Blistadorepor
        '
        Me.Blistadorepor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Blistadorepor.FlatAppearance.BorderSize = 0
        Me.Blistadorepor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Blistadorepor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Blistadorepor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Blistadorepor.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blistadorepor.Location = New System.Drawing.Point(253, 495)
        Me.Blistadorepor.Name = "Blistadorepor"
        Me.Blistadorepor.Size = New System.Drawing.Size(141, 28)
        Me.Blistadorepor.TabIndex = 20
        Me.Blistadorepor.Text = "Listado Reportes"
        Me.Blistadorepor.UseVisualStyleBackColor = True
        '
        'BEstad
        '
        Me.BEstad.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BEstad.FlatAppearance.BorderSize = 0
        Me.BEstad.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.BEstad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BEstad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEstad.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEstad.Location = New System.Drawing.Point(684, 494)
        Me.BEstad.Name = "BEstad"
        Me.BEstad.Size = New System.Drawing.Size(141, 28)
        Me.BEstad.TabIndex = 21
        Me.BEstad.Text = "Estadisticas"
        Me.BEstad.UseVisualStyleBackColor = True
        '
        'Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.SystemElim.My.Resources.Resources._14408_line_font_black_fabric_texture_textile_black_and_white_1680x10501
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(837, 558)
        Me.Controls.Add(Me.BEstad)
        Me.Controls.Add(Me.Blistadorepor)
        Me.Controls.Add(Me.BReportCel)
        Me.Controls.Add(Me.BCant)
        Me.Controls.Add(Me.BLPersona)
        Me.Controls.Add(Me.BLCelula)
        Me.Controls.Add(Me.BLArea)
        Me.Controls.Add(Me.BBajaArea)
        Me.Controls.Add(Me.BModArea)
        Me.Controls.Add(Me.BAddArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BBajaCelula)
        Me.Controls.Add(Me.BModCelula)
        Me.Controls.Add(Me.BAddCelula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BBajaPers)
        Me.Controls.Add(Me.BModPers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BAddPers)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Administracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BAddPers As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BModPers As Button
    Friend WithEvents BBajaPers As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BBajaCelula As Button
    Friend WithEvents BModCelula As Button
    Friend WithEvents BAddCelula As Button
    Friend WithEvents BBajaArea As Button
    Friend WithEvents BModArea As Button
    Friend WithEvents BAddArea As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BLArea As Button
    Friend WithEvents BLCelula As Button
    Friend WithEvents BLPersona As Button
    Friend WithEvents BCant As Button
    Friend WithEvents BReportCel As Button
    Friend WithEvents Blistadorepor As Button
    Friend WithEvents BEstad As Button
End Class
