<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarArea))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.CBCede = New System.Windows.Forms.ComboBox()
        Me.CBLider = New System.Windows.Forms.ComboBox()
        Me.CBAuxiliar = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TDescr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(363, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Cede   "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(363, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Auxiliar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(62, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Lider      "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(57, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(168, 177)
        Me.TNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(132, 20)
        Me.TNombre.TabIndex = 15
        '
        'CBCede
        '
        Me.CBCede.FormattingEnabled = True
        Me.CBCede.Location = New System.Drawing.Point(470, 177)
        Me.CBCede.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBCede.Name = "CBCede"
        Me.CBCede.Size = New System.Drawing.Size(139, 21)
        Me.CBCede.TabIndex = 26
        '
        'CBLider
        '
        Me.CBLider.FormattingEnabled = True
        Me.CBLider.Location = New System.Drawing.Point(168, 245)
        Me.CBLider.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBLider.Name = "CBLider"
        Me.CBLider.Size = New System.Drawing.Size(132, 21)
        Me.CBLider.TabIndex = 27
        '
        'CBAuxiliar
        '
        Me.CBAuxiliar.FormattingEnabled = True
        Me.CBAuxiliar.Location = New System.Drawing.Point(470, 248)
        Me.CBAuxiliar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBAuxiliar.Name = "CBAuxiliar"
        Me.CBAuxiliar.Size = New System.Drawing.Size(139, 21)
        Me.CBAuxiliar.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(180, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(366, 39)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Agregar un nuevo Servicio"
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BCancelar.Location = New System.Drawing.Point(358, 372)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(118, 49)
        Me.BCancelar.TabIndex = 31
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
        Me.BGuardar.Location = New System.Drawing.Point(187, 372)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(113, 49)
        Me.BGuardar.TabIndex = 30
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(106, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Descripción"
        '
        'TDescr
        '
        Me.TDescr.Location = New System.Drawing.Point(223, 314)
        Me.TDescr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TDescr.Name = "TDescr"
        Me.TDescr.Size = New System.Drawing.Size(323, 20)
        Me.TDescr.TabIndex = 32
        '
        'AgregarArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.SystemElim.My.Resources.Resources.fondo_negro_abstracto_sombra_doblez_tecnologia_1408_563
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(708, 476)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TDescr)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBAuxiliar)
        Me.Controls.Add(Me.CBLider)
        Me.Controls.Add(Me.CBCede)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TNombre)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AgregarArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents CBCede As ComboBox
    Friend WithEvents CBLider As ComboBox
    Friend WithEvents CBAuxiliar As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TDescr As TextBox
End Class
