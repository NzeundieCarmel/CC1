﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace Web_Api

    Partial Public Class BoulangerieEntities
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=BoulangerieEntities")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property Bien() As DbSet(Of Bien)
        Public Overridable Property Propritaire() As DbSet(Of Propritaire)
    
    End Class

End Namespace
