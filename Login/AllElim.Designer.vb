<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllElim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllElim))
        Me.BEntrar = New System.Windows.Forms.Button()
        Me.TContraseña = New System.Windows.Forms.TextBox()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BEntrar
        '
        Me.BEntrar.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BEntrar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEntrar.Location = New System.Drawing.Point(531, 295)
        Me.BEntrar.Name = "BEntrar"
        Me.BEntrar.Size = New System.Drawing.Size(122, 42)
        Me.BEntrar.TabIndex = 4
        Me.BEntrar.Text = "Entrar"
        Me.BEntrar.UseVisualStyleBackColor = True
        '
        'TContraseña
        '
        Me.TContraseña.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TContraseña.HideSelection = False
        Me.TContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TContraseña.Location = New System.Drawing.Point(504, 170)
        Me.TContraseña.Multiline = True
        Me.TContraseña.Name = "TContraseña"
        Me.TContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TContraseña.Size = New System.Drawing.Size(149, 19)
        Me.TContraseña.TabIndex = 3
        Me.TContraseña.WordWrap = False
        '
        'TUsuario
        '
        Me.TUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TUsuario.Location = New System.Drawing.Point(504, 107)
        Me.TUsuario.Multiline = True
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(149, 19)
        Me.TUsuario.TabIndex = 2
        '
        'LContraseña
        '
        Me.LContraseña.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LContraseña.AutoSize = True
        Me.LContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LContraseña.Location = New System.Drawing.Point(375, 169)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(95, 18)
        Me.LContraseña.TabIndex = 12
        Me.LContraseña.Text = "Contraseña"
        '
        'LUsuario
        '
        Me.LUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LUsuario.AutoSize = True
        Me.LUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LUsuario.Location = New System.Drawing.Point(375, 106)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(67, 18)
        Me.LUsuario.TabIndex = 11
        Me.LUsuario.Text = "Usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SystemElim.My.Resources.Resources.descarga1
        Me.PictureBox1.Location = New System.Drawing.Point(649, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'AllElim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.SystemElim.My.Resources.Resources._2019_06_23__2_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BEntrar)
        Me.Controls.Add(Me.TContraseña)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AllElim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllElim"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BEntrar As Button
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents LContraseña As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TContraseña As TextBox
End Class
