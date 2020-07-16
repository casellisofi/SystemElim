<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoReportes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Repor = New System.Windows.Forms.TabControl()
        Me.Allrepor = New System.Windows.Forms.TabPage()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBuscador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGAllRepor = New System.Windows.Forms.DataGridView()
        Me.Red = New System.Windows.Forms.TabPage()
        Me.BImpRed = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBRed = New System.Windows.Forms.ComboBox()
        Me.TBuscar1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGRed = New System.Windows.Forms.DataGridView()
        Me.Celula = New System.Windows.Forms.TabPage()
        Me.BImpCel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCelula = New System.Windows.Forms.ComboBox()
        Me.TbuscadorL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGcelula = New System.Windows.Forms.DataGridView()
        Me.Fechas = New System.Windows.Forms.TabPage()
        Me.DTHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTFecha = New System.Windows.Forms.DataGridView()
        Me.Repor.SuspendLayout()
        Me.Allrepor.SuspendLayout()
        CType(Me.DGAllRepor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Red.SuspendLayout()
        CType(Me.DGRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Celula.SuspendLayout()
        CType(Me.DGcelula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fechas.SuspendLayout()
        CType(Me.DTFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Repor
        '
        Me.Repor.Controls.Add(Me.Allrepor)
        Me.Repor.Controls.Add(Me.Red)
        Me.Repor.Controls.Add(Me.Celula)
        Me.Repor.Controls.Add(Me.Fechas)
        Me.Repor.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repor.ItemSize = New System.Drawing.Size(215, 30)
        Me.Repor.Location = New System.Drawing.Point(-4, 2)
        Me.Repor.Name = "Repor"
        Me.Repor.SelectedIndex = 0
        Me.Repor.Size = New System.Drawing.Size(865, 524)
        Me.Repor.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.Repor.TabIndex = 2
        '
        'Allrepor
        '
        Me.Allrepor.BackColor = System.Drawing.Color.Gray
        Me.Allrepor.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.Allrepor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Allrepor.Controls.Add(Me.BImprimir)
        Me.Allrepor.Controls.Add(Me.Label20)
        Me.Allrepor.Controls.Add(Me.TBuscador)
        Me.Allrepor.Controls.Add(Me.Label1)
        Me.Allrepor.Controls.Add(Me.DGAllRepor)
        Me.Allrepor.Location = New System.Drawing.Point(4, 34)
        Me.Allrepor.Name = "Allrepor"
        Me.Allrepor.Padding = New System.Windows.Forms.Padding(3)
        Me.Allrepor.Size = New System.Drawing.Size(857, 486)
        Me.Allrepor.TabIndex = 0
        Me.Allrepor.Text = "Listado de Reportes"
        '
        'BImprimir
        '
        Me.BImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.BImprimir.Location = New System.Drawing.Point(25, 435)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(84, 27)
        Me.BImprimir.TabIndex = 156
        Me.BImprimir.Text = "Imprimir"
        Me.BImprimir.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Candara", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(778, 436)
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
        Me.TBuscador.Location = New System.Drawing.Point(440, 436)
        Me.TBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.TBuscador.Name = "TBuscador"
        Me.TBuscador.Size = New System.Drawing.Size(324, 26)
        Me.TBuscador.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(254, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 29)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "LISTADO DE REPORTES DE CÉLULAS"
        '
        'DGAllRepor
        '
        Me.DGAllRepor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAllRepor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGAllRepor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGAllRepor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAllRepor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGAllRepor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAllRepor.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAllRepor.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGAllRepor.Location = New System.Drawing.Point(54, 65)
        Me.DGAllRepor.MultiSelect = False
        Me.DGAllRepor.Name = "DGAllRepor"
        Me.DGAllRepor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAllRepor.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGAllRepor.RowHeadersVisible = False
        Me.DGAllRepor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGAllRepor.Size = New System.Drawing.Size(768, 340)
        Me.DGAllRepor.TabIndex = 152
        '
        'Red
        '
        Me.Red.BackColor = System.Drawing.Color.Gray
        Me.Red.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Red.Controls.Add(Me.BImpRed)
        Me.Red.Controls.Add(Me.Label14)
        Me.Red.Controls.Add(Me.Label6)
        Me.Red.Controls.Add(Me.CBRed)
        Me.Red.Controls.Add(Me.TBuscar1)
        Me.Red.Controls.Add(Me.Label2)
        Me.Red.Controls.Add(Me.DGRed)
        Me.Red.Location = New System.Drawing.Point(4, 34)
        Me.Red.Name = "Red"
        Me.Red.Padding = New System.Windows.Forms.Padding(3)
        Me.Red.Size = New System.Drawing.Size(857, 486)
        Me.Red.TabIndex = 1
        Me.Red.Text = "Reportes por Red"
        '
        'BImpRed
        '
        Me.BImpRed.Cursor = System.Windows.Forms.Cursors.Default
        Me.BImpRed.Location = New System.Drawing.Point(28, 443)
        Me.BImpRed.Name = "BImpRed"
        Me.BImpRed.Size = New System.Drawing.Size(84, 27)
        Me.BImpRed.TabIndex = 159
        Me.BImpRed.Text = "Imprimir"
        Me.BImpRed.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(712, 17)
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
        Me.Label6.Location = New System.Drawing.Point(783, 452)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Buscar"
        '
        'CBRed
        '
        Me.CBRed.FormattingEnabled = True
        Me.CBRed.Location = New System.Drawing.Point(188, 13)
        Me.CBRed.Name = "CBRed"
        Me.CBRed.Size = New System.Drawing.Size(121, 26)
        Me.CBRed.TabIndex = 148
        '
        'TBuscar1
        '
        Me.TBuscar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscar1.Location = New System.Drawing.Point(572, 448)
        Me.TBuscar1.Margin = New System.Windows.Forms.Padding(2)
        Me.TBuscar1.Name = "TBuscar1"
        Me.TBuscar1.Size = New System.Drawing.Size(207, 26)
        Me.TBuscar1.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Seleccione una Red"
        '
        'DGRed
        '
        Me.DGRed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGRed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRed.Location = New System.Drawing.Point(66, 61)
        Me.DGRed.Name = "DGRed"
        Me.DGRed.Size = New System.Drawing.Size(744, 345)
        Me.DGRed.TabIndex = 145
        '
        'Celula
        '
        Me.Celula.BackColor = System.Drawing.Color.Gray
        Me.Celula.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.Celula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Celula.Controls.Add(Me.BImpCel)
        Me.Celula.Controls.Add(Me.Label3)
        Me.Celula.Controls.Add(Me.Label4)
        Me.Celula.Controls.Add(Me.CBCelula)
        Me.Celula.Controls.Add(Me.TbuscadorL)
        Me.Celula.Controls.Add(Me.Label5)
        Me.Celula.Controls.Add(Me.DGcelula)
        Me.Celula.Location = New System.Drawing.Point(4, 34)
        Me.Celula.Name = "Celula"
        Me.Celula.Padding = New System.Windows.Forms.Padding(3)
        Me.Celula.Size = New System.Drawing.Size(857, 486)
        Me.Celula.TabIndex = 2
        Me.Celula.Text = "Reportes por Celula"
        '
        'BImpCel
        '
        Me.BImpCel.Cursor = System.Windows.Forms.Cursors.Default
        Me.BImpCel.Location = New System.Drawing.Point(31, 434)
        Me.BImpCel.Name = "BImpCel"
        Me.BImpCel.Size = New System.Drawing.Size(84, 27)
        Me.BImpCel.TabIndex = 164
        Me.BImpCel.Text = "Imprimir"
        Me.BImpCel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(709, 15)
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
        Me.Label4.Location = New System.Drawing.Point(780, 439)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Buscar"
        '
        'CBCelula
        '
        Me.CBCelula.FormattingEnabled = True
        Me.CBCelula.Location = New System.Drawing.Point(188, 15)
        Me.CBCelula.Name = "CBCelula"
        Me.CBCelula.Size = New System.Drawing.Size(121, 26)
        Me.CBCelula.TabIndex = 161
        '
        'TbuscadorL
        '
        Me.TbuscadorL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbuscadorL.Location = New System.Drawing.Point(569, 435)
        Me.TbuscadorL.Margin = New System.Windows.Forms.Padding(2)
        Me.TbuscadorL.Name = "TbuscadorL"
        Me.TbuscadorL.Size = New System.Drawing.Size(207, 26)
        Me.TbuscadorL.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 20)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Seleccione una Celula"
        '
        'DGcelula
        '
        Me.DGcelula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGcelula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGcelula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGcelula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGcelula.Location = New System.Drawing.Point(58, 63)
        Me.DGcelula.Name = "DGcelula"
        Me.DGcelula.Size = New System.Drawing.Size(752, 343)
        Me.DGcelula.TabIndex = 149
        '
        'Fechas
        '
        Me.Fechas.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.Fechas.Controls.Add(Me.DTHasta)
        Me.Fechas.Controls.Add(Me.DTDesde)
        Me.Fechas.Controls.Add(Me.Label10)
        Me.Fechas.Controls.Add(Me.Button3)
        Me.Fechas.Controls.Add(Me.Label8)
        Me.Fechas.Controls.Add(Me.TextBox1)
        Me.Fechas.Controls.Add(Me.Label9)
        Me.Fechas.Controls.Add(Me.DTFecha)
        Me.Fechas.Location = New System.Drawing.Point(4, 34)
        Me.Fechas.Name = "Fechas"
        Me.Fechas.Padding = New System.Windows.Forms.Padding(3)
        Me.Fechas.Size = New System.Drawing.Size(857, 486)
        Me.Fechas.TabIndex = 3
        Me.Fechas.Text = "Reportes por Fechas"
        Me.Fechas.UseVisualStyleBackColor = True
        '
        'DTHasta
        '
        Me.DTHasta.Location = New System.Drawing.Point(512, 27)
        Me.DTHasta.Name = "DTHasta"
        Me.DTHasta.Size = New System.Drawing.Size(243, 26)
        Me.DTHasta.TabIndex = 174
        '
        'DTDesde
        '
        Me.DTDesde.Location = New System.Drawing.Point(197, 27)
        Me.DTDesde.Name = "DTDesde"
        Me.DTDesde.Size = New System.Drawing.Size(246, 26)
        Me.DTDesde.TabIndex = 173
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(449, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 20)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "Hasta"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Location = New System.Drawing.Point(40, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 27)
        Me.Button3.TabIndex = 171
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(789, 444)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 18)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(578, 440)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 26)
        Me.TextBox1.TabIndex = 167
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(130, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Desde"
        '
        'DTFecha
        '
        Me.DTFecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DTFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DTFecha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DTFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTFecha.Location = New System.Drawing.Point(67, 68)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(752, 343)
        Me.DTFecha.TabIndex = 165
        '
        'ListadoReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 524)
        Me.Controls.Add(Me.Repor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ListadoReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Repor.ResumeLayout(False)
        Me.Allrepor.ResumeLayout(False)
        Me.Allrepor.PerformLayout()
        CType(Me.DGAllRepor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Red.ResumeLayout(False)
        Me.Red.PerformLayout()
        CType(Me.DGRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Celula.ResumeLayout(False)
        Me.Celula.PerformLayout()
        CType(Me.DGcelula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fechas.ResumeLayout(False)
        Me.Fechas.PerformLayout()
        CType(Me.DTFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Repor As TabControl
    Friend WithEvents Allrepor As TabPage
    Friend WithEvents BImprimir As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents TBuscador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGAllRepor As DataGridView
    Friend WithEvents Red As TabPage
    Friend WithEvents BImpRed As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBRed As ComboBox
    Friend WithEvents TBuscar1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGRed As DataGridView
    Friend WithEvents Celula As TabPage
    Friend WithEvents BImpCel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBCelula As ComboBox
    Friend WithEvents TbuscadorL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DGcelula As DataGridView
    Friend WithEvents Fechas As TabPage
    Friend WithEvents DTHasta As DateTimePicker
    Friend WithEvents DTDesde As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DTFecha As DataGridView
End Class
