<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoDeAreas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoDeAreas))
        Me.Areas = New System.Windows.Forms.TabControl()
        Me.Areass = New System.Windows.Forms.TabPage()
        Me.BExcelP = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBuscador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGAreas = New System.Windows.Forms.DataGridView()
        Me.Cedes = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBCede = New System.Windows.Forms.ComboBox()
        Me.TBuscar1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGAreasC = New System.Windows.Forms.DataGridView()
        Me.Lideres = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBLider = New System.Windows.Forms.ComboBox()
        Me.TbuscadorL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGLideres = New System.Windows.Forms.DataGridView()
        Me.Areas.SuspendLayout()
        Me.Areass.SuspendLayout()
        CType(Me.DGAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cedes.SuspendLayout()
        CType(Me.DGAreasC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lideres.SuspendLayout()
        CType(Me.DGLideres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Areas
        '
        Me.Areas.Controls.Add(Me.Areass)
        Me.Areas.Controls.Add(Me.Cedes)
        Me.Areas.Controls.Add(Me.Lideres)
        Me.Areas.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Areas.ItemSize = New System.Drawing.Size(150, 24)
        Me.Areas.Location = New System.Drawing.Point(-1, -3)
        Me.Areas.Name = "Areas"
        Me.Areas.SelectedIndex = 0
        Me.Areas.Size = New System.Drawing.Size(869, 546)
        Me.Areas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.Areas.TabIndex = 1
        '
        'Areass
        '
        Me.Areass.BackColor = System.Drawing.Color.Gray
        Me.Areass.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.Areass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Areass.Controls.Add(Me.BExcelP)
        Me.Areass.Controls.Add(Me.Label20)
        Me.Areass.Controls.Add(Me.TBuscador)
        Me.Areass.Controls.Add(Me.Label1)
        Me.Areass.Controls.Add(Me.DGAreas)
        Me.Areass.Location = New System.Drawing.Point(4, 28)
        Me.Areass.Name = "Areass"
        Me.Areass.Padding = New System.Windows.Forms.Padding(3)
        Me.Areass.Size = New System.Drawing.Size(861, 514)
        Me.Areass.TabIndex = 0
        Me.Areass.Text = "Listado de Areas"
        '
        'BExcelP
        '
        Me.BExcelP.Cursor = System.Windows.Forms.Cursors.Default
        Me.BExcelP.Location = New System.Drawing.Point(24, 411)
        Me.BExcelP.Name = "BExcelP"
        Me.BExcelP.Size = New System.Drawing.Size(84, 27)
        Me.BExcelP.TabIndex = 156
        Me.BExcelP.Text = "Imprimir"
        Me.BExcelP.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Candara", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(765, 411)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 23)
        Me.Label20.TabIndex = 155
        Me.Label20.Text = "Buscar"
        '
        'TBuscador
        '
        Me.TBuscador.Cursor = System.Windows.Forms.Cursors.Default
        Me.TBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscador.Location = New System.Drawing.Point(492, 411)
        Me.TBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.TBuscador.Name = "TBuscador"
        Me.TBuscador.Size = New System.Drawing.Size(259, 26)
        Me.TBuscador.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(329, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 29)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "LISTADO DE SERVICIOS"
        '
        'DGAreas
        '
        Me.DGAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAreas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGAreas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGAreas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAreas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAreas.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAreas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGAreas.Location = New System.Drawing.Point(147, 74)
        Me.DGAreas.MultiSelect = False
        Me.DGAreas.Name = "DGAreas"
        Me.DGAreas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAreas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGAreas.Size = New System.Drawing.Size(614, 306)
        Me.DGAreas.TabIndex = 152
        '
        'Cedes
        '
        Me.Cedes.BackColor = System.Drawing.Color.Gray
        Me.Cedes.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.Cedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cedes.Controls.Add(Me.Button1)
        Me.Cedes.Controls.Add(Me.Label14)
        Me.Cedes.Controls.Add(Me.Label6)
        Me.Cedes.Controls.Add(Me.CBCede)
        Me.Cedes.Controls.Add(Me.TBuscar1)
        Me.Cedes.Controls.Add(Me.Label2)
        Me.Cedes.Controls.Add(Me.DGAreasC)
        Me.Cedes.Location = New System.Drawing.Point(4, 28)
        Me.Cedes.Name = "Cedes"
        Me.Cedes.Padding = New System.Windows.Forms.Padding(3)
        Me.Cedes.Size = New System.Drawing.Size(861, 514)
        Me.Cedes.TabIndex = 1
        Me.Cedes.Text = "Areas por Cedes"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Location = New System.Drawing.Point(23, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 27)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(712, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 23)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "Mostrar todos"
        Me.Label14.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(783, 415)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Buscar"
        '
        'CBCede
        '
        Me.CBCede.FormattingEnabled = True
        Me.CBCede.Location = New System.Drawing.Point(204, 25)
        Me.CBCede.Name = "CBCede"
        Me.CBCede.Size = New System.Drawing.Size(121, 26)
        Me.CBCede.TabIndex = 148
        '
        'TBuscar1
        '
        Me.TBuscar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscar1.Location = New System.Drawing.Point(532, 411)
        Me.TBuscar1.Margin = New System.Windows.Forms.Padding(2)
        Me.TBuscar1.Name = "TBuscar1"
        Me.TBuscar1.Size = New System.Drawing.Size(247, 26)
        Me.TBuscar1.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(19, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 20)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Seleccione una Cede"
        '
        'DGAreasC
        '
        Me.DGAreasC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAreasC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGAreasC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGAreasC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAreasC.Location = New System.Drawing.Point(143, 73)
        Me.DGAreasC.Name = "DGAreasC"
        Me.DGAreasC.Size = New System.Drawing.Size(608, 313)
        Me.DGAreasC.TabIndex = 145
        '
        'Lideres
        '
        Me.Lideres.BackColor = System.Drawing.Color.Gray
        Me.Lideres.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.Lideres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lideres.Controls.Add(Me.Button2)
        Me.Lideres.Controls.Add(Me.Label3)
        Me.Lideres.Controls.Add(Me.Label4)
        Me.Lideres.Controls.Add(Me.CBLider)
        Me.Lideres.Controls.Add(Me.TbuscadorL)
        Me.Lideres.Controls.Add(Me.Label5)
        Me.Lideres.Controls.Add(Me.DGLideres)
        Me.Lideres.Location = New System.Drawing.Point(4, 28)
        Me.Lideres.Name = "Lideres"
        Me.Lideres.Padding = New System.Windows.Forms.Padding(3)
        Me.Lideres.Size = New System.Drawing.Size(861, 514)
        Me.Lideres.TabIndex = 2
        Me.Lideres.Text = "Lideres de Areas"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Location = New System.Drawing.Point(28, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 27)
        Me.Button2.TabIndex = 164
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(710, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Mostrar todos"
        Me.Label3.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(781, 414)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Buscar"
        '
        'CBLider
        '
        Me.CBLider.FormattingEnabled = True
        Me.CBLider.Location = New System.Drawing.Point(209, 25)
        Me.CBLider.Name = "CBLider"
        Me.CBLider.Size = New System.Drawing.Size(121, 26)
        Me.CBLider.TabIndex = 161
        '
        'TbuscadorL
        '
        Me.TbuscadorL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbuscadorL.Location = New System.Drawing.Point(537, 410)
        Me.TbuscadorL.Margin = New System.Windows.Forms.Padding(2)
        Me.TbuscadorL.Name = "TbuscadorL"
        Me.TbuscadorL.Size = New System.Drawing.Size(240, 26)
        Me.TbuscadorL.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(24, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 20)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Seleccione una Cede"
        '
        'DGLideres
        '
        Me.DGLideres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGLideres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGLideres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGLideres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLideres.Location = New System.Drawing.Point(66, 76)
        Me.DGLideres.Name = "DGLideres"
        Me.DGLideres.Size = New System.Drawing.Size(725, 310)
        Me.DGLideres.TabIndex = 149
        '
        'ListadoDeAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(867, 490)
        Me.Controls.Add(Me.Areas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListadoDeAreas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Areas.ResumeLayout(False)
        Me.Areass.ResumeLayout(False)
        Me.Areass.PerformLayout()
        CType(Me.DGAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cedes.ResumeLayout(False)
        Me.Cedes.PerformLayout()
        CType(Me.DGAreasC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lideres.ResumeLayout(False)
        Me.Lideres.PerformLayout()
        CType(Me.DGLideres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lideres As TabPage
    Friend WithEvents DGLideres As DataGridView
    Friend WithEvents Cedes As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBCede As ComboBox
    Friend WithEvents TBuscar1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGAreasC As DataGridView
    Friend WithEvents Areass As TabPage
    Friend WithEvents Areas As TabControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBLider As ComboBox
    Friend WithEvents TbuscadorL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BExcelP As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents TBuscador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGAreas As DataGridView
End Class
