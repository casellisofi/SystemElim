<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modificar_Area
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Area))
        Me.DGAreas = New System.Windows.Forms.DataGridView()
        Me.CBAuxiliar = New System.Windows.Forms.ComboBox()
        Me.CBLider = New System.Windows.Forms.ComboBox()
        Me.CBCede = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Tid = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBuscador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TDescr = New System.Windows.Forms.TextBox()
        CType(Me.DGAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGAreas
        '
        Me.DGAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAreas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAreas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAreas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGAreas.Location = New System.Drawing.Point(12, 57)
        Me.DGAreas.Name = "DGAreas"
        Me.DGAreas.Size = New System.Drawing.Size(559, 224)
        Me.DGAreas.TabIndex = 4
        '
        'CBAuxiliar
        '
        Me.CBAuxiliar.FormattingEnabled = True
        Me.CBAuxiliar.Location = New System.Drawing.Point(385, 422)
        Me.CBAuxiliar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBAuxiliar.Name = "CBAuxiliar"
        Me.CBAuxiliar.Size = New System.Drawing.Size(146, 21)
        Me.CBAuxiliar.TabIndex = 38
        '
        'CBLider
        '
        Me.CBLider.FormattingEnabled = True
        Me.CBLider.Location = New System.Drawing.Point(114, 426)
        Me.CBLider.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBLider.Name = "CBLider"
        Me.CBLider.Size = New System.Drawing.Size(139, 21)
        Me.CBLider.TabIndex = 37
        '
        'CBCede
        '
        Me.CBCede.FormattingEnabled = True
        Me.CBCede.Location = New System.Drawing.Point(384, 372)
        Me.CBCede.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBCede.Name = "CBCede"
        Me.CBCede.Size = New System.Drawing.Size(146, 21)
        Me.CBCede.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(310, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Cede   "
        Me.Label4.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(302, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Auxiliar"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(30, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Lider      "
        Me.Label2.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(30, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nombre"
        Me.Label5.UseWaitCursor = True
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(114, 373)
        Me.TNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(139, 20)
        Me.TNombre.TabIndex = 31
        '
        'Tid
        '
        Me.Tid.Location = New System.Drawing.Point(114, 306)
        Me.Tid.Name = "Tid"
        Me.Tid.Size = New System.Drawing.Size(31, 20)
        Me.Tid.TabIndex = 140
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Location = New System.Drawing.Point(13, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "IDENTIFICACION:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(500, 299)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 20)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "Buscar"
        '
        'TBuscador
        '
        Me.TBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscador.Location = New System.Drawing.Point(280, 296)
        Me.TBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.TBuscador.Name = "TBuscador"
        Me.TBuscador.Size = New System.Drawing.Size(216, 26)
        Me.TBuscador.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Seleccione un Servicio"
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BCancelar.Location = New System.Drawing.Point(320, 523)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(118, 49)
        Me.BCancelar.TabIndex = 145
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BGuardar.FlatAppearance.BorderSize = 0
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGuardar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BGuardar.Location = New System.Drawing.Point(149, 523)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(113, 49)
        Me.BGuardar.TabIndex = 144
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(94, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Descripción"
        '
        'TDescr
        '
        Me.TDescr.Location = New System.Drawing.Point(211, 471)
        Me.TDescr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TDescr.Name = "TDescr"
        Me.TDescr.Size = New System.Drawing.Size(264, 20)
        Me.TDescr.TabIndex = 146
        '
        'Modificar_Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 584)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TDescr)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TBuscador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tid)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.CBAuxiliar)
        Me.Controls.Add(Me.CBLider)
        Me.Controls.Add(Me.CBCede)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.DGAreas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGAreas As DataGridView
    Friend WithEvents CBAuxiliar As ComboBox
    Friend WithEvents CBLider As ComboBox
    Friend WithEvents CBCede As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Tid As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TBuscador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TDescr As TextBox
End Class
