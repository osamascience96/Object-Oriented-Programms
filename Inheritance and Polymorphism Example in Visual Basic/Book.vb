' This is a derived class of Book
Public Class Book
    Inherits LibraryItem

    Private IsRequested As Boolean
    Private bookName As String

    'Creating a new constructor 
    Public Sub New(ByVal ItemId As String, ByVal Artist_Author_name As String)
        'when init the constructor of the base class, then requires arguments(Params)
        MyBase.New(ItemId, Artist_Author_name)
    End Sub

    Public Sub SetIsRequested(ByVal boolFlag As Boolean)
        IsRequested = boolFlag
    End Sub

    Public Function GetIsRequested() As Boolean
        Return IsRequested
    End Function

    Public Sub SetBookName(ByVal bookName As String)
        Me.bookName = bookName
    End Sub

    Public Function GetBookName() As String
        Return bookName
    End Function

    Public Overrides Sub PrintDetails()
        MyBase.PrintDetails() 'Mybase is optional in an overrided function'
        Console.WriteLine("Unique Details-->" & IsRequested)
    End Sub

End Class
