' This is a base class
Public Class LibraryItem
    'class attributes
    Private ItemId As String
    Private Artist_Author_name As String
    Private ItemTakenDate As Date
    Private loanFlag As Boolean

    ' making a constructor 
    Public Sub New(ByRef ItemId As String, ByRef Artist_Author_name As String)
        ' init the attributes 
        Me.ItemId = ItemId
        Me.Artist_Author_name = Artist_Author_name
    End Sub

    Public Function GetItemId() As String
        Return ItemId
    End Function

    Public Function Get_Artist_Author_Name() As String
        Return Artist_Author_name
    End Function

    ' methods(behavious) of the class 
    Public Sub SetLoan(ByVal loanFlag)
        Me.loanFlag = loanFlag
    End Sub

    Public Function GetLoan() As Boolean
        Return loanFlag
    End Function

    Public Sub SetItemTakenDate(ByVal ItemTakenDate As Date)
        Me.ItemTakenDate = ItemTakenDate
    End Sub

    Public Function GetItemTakenDate() As Date
        Return ItemTakenDate
    End Function

    'This Procedutre can have a seperate definition to each derived classes using the word overridable'
    'The keyword Overridable must be in the parent class
    Public Overridable Sub PrintDetails()
        Console.Write("Details-->" & ItemId & " " & Artist_Author_name)
        Console.WriteLine()
    End Sub

End Class
