' This is a derived class of CD
Public Class CD
    Inherits LibraryItem

    Private Genere As String
    Private CDName As String

    'creating a new constructor 
    Public Sub New(ByVal ItemId As String, ByVal Artist_Author_name As String)
        MyBase.New(ItemId, Artist_Author_name)
    End Sub

    Public Sub SetGenere(ByVal Genere As String)
        Me.Genere = Genere
    End Sub

    Public Function GetGenere() As String
        Return Genere
    End Function

    Public Sub SetCDName(ByVal CDName As String)
        Me.CDName = CDName
    End Sub

    Public Function GetCDName() As String
        Return CDName
    End Function

    Public Overrides Sub PrintDetails()
        MyBase.PrintDetails() 'Mybase is optional in an overrided function'
        Console.WriteLine("Unique Details-->" & Genere)
    End Sub

End Class
