﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoPorRed
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Datos = New SystemElim.Datos()
        Me.ListadoPorRedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoPorRedTableAdapter = New SystemElim.DatosTableAdapters.ListadoPorRedTableAdapter()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoPorRedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ListadoPorRedBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SystemElim.ListadoPorRed.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(695, 657)
        Me.ReportViewer1.TabIndex = 0
        '
        'Datos
        '
        Me.Datos.DataSetName = "Datos"
        Me.Datos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoPorRedBindingSource
        '
        Me.ListadoPorRedBindingSource.DataMember = "ListadoPorRed"
        Me.ListadoPorRedBindingSource.DataSource = Me.Datos
        '
        'ListadoPorRedTableAdapter
        '
        Me.ListadoPorRedTableAdapter.ClearBeforeFill = True
        '
        'ListadoPorRed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 657)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ListadoPorRed"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoPorRedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListadoPorRedBindingSource As BindingSource
    Friend WithEvents Datos As Datos
    Friend WithEvents ListadoPorRedTableAdapter As DatosTableAdapters.ListadoPorRedTableAdapter
End Class
