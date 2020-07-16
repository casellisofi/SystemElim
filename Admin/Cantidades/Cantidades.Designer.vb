<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cantidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cantidades))
        Me.BPersonas = New System.Windows.Forms.Button()
        Me.BCelulas = New System.Windows.Forms.Button()
        Me.BBaut = New System.Windows.Forms.Button()
        Me.BEscuela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BPersonas
        '
        Me.BPersonas.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BPersonas.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPersonas.ForeColor = System.Drawing.SystemColors.Control
        Me.BPersonas.Location = New System.Drawing.Point(60, 78)
        Me.BPersonas.Name = "BPersonas"
        Me.BPersonas.Size = New System.Drawing.Size(304, 121)
        Me.BPersonas.TabIndex = 26
        Me.BPersonas.Text = "PERSONAS"
        Me.BPersonas.UseVisualStyleBackColor = False
        '
        'BCelulas
        '
        Me.BCelulas.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BCelulas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCelulas.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCelulas.ForeColor = System.Drawing.SystemColors.Control
        Me.BCelulas.Location = New System.Drawing.Point(509, 78)
        Me.BCelulas.Name = "BCelulas"
        Me.BCelulas.Size = New System.Drawing.Size(304, 121)
        Me.BCelulas.TabIndex = 27
        Me.BCelulas.Text = "CELULAS"
        Me.BCelulas.UseVisualStyleBackColor = False
        '
        'BBaut
        '
        Me.BBaut.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BBaut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBaut.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBaut.ForeColor = System.Drawing.SystemColors.Control
        Me.BBaut.Location = New System.Drawing.Point(60, 268)
        Me.BBaut.Name = "BBaut"
        Me.BBaut.Size = New System.Drawing.Size(304, 121)
        Me.BBaut.TabIndex = 28
        Me.BBaut.Text = "BAUTIZADOS"
        Me.BBaut.UseVisualStyleBackColor = False
        '
        'BEscuela
        '
        Me.BEscuela.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BEscuela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BEscuela.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEscuela.ForeColor = System.Drawing.SystemColors.Control
        Me.BEscuela.Location = New System.Drawing.Point(509, 268)
        Me.BEscuela.Name = "BEscuela"
        Me.BEscuela.Size = New System.Drawing.Size(304, 121)
        Me.BEscuela.TabIndex = 29
        Me.BEscuela.Text = "ESCUELA DE VIDA"
        Me.BEscuela.UseVisualStyleBackColor = False
        '
        'Cantidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(869, 478)
        Me.Controls.Add(Me.BEscuela)
        Me.Controls.Add(Me.BBaut)
        Me.Controls.Add(Me.BCelulas)
        Me.Controls.Add(Me.BPersonas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cantidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BPersonas As Button
    Friend WithEvents BCelulas As Button
    Friend WithEvents BBaut As Button
    Friend WithEvents BEscuela As Button
End Class
