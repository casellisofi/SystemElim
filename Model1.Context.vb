﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class BDSystemElimEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=BDSystemElimEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Cede() As DbSet(Of Cede)
    Public Overridable Property EscuelaDeVida() As DbSet(Of EscuelaDeVida)
    Public Overridable Property Rol() As DbSet(Of Rol)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property Usuario() As DbSet(Of Usuario)
    Public Overridable Property Bautizados() As DbSet(Of Bautizados)
    Public Overridable Property Celula() As DbSet(Of Celula)
    Public Overridable Property Red() As DbSet(Of Red)
    Public Overridable Property Reporte() As DbSet(Of Reporte)
    Public Overridable Property Lideres() As DbSet(Of Lideres)
    Public Overridable Property Persona() As DbSet(Of Persona)
    Public Overridable Property Area() As DbSet(Of Area)

End Class
