Public Class Lesson
    Private LessonTitle As String
    Private DurationMinutes As Integer
    Private RequiresLab As Boolean

    Public Sub SetLessonTitle(ByVal LessonTitle As String)
        Me.LessonTitle = LessonTitle
    End Sub

    Public Sub SetDurationMinutes(ByVal DurationMinutes As Integer)
        Me.DurationMinutes = DurationMinutes
    End Sub

    Public Sub SetLabFlag(ByVal RequiresLab As Boolean)
        Me.RequiresLab = RequiresLab
    End Sub

    Public Sub OutputLessonDetails()
        Console.WriteLine("Title Of Lesson--->" & LessonTitle)
        Console.WriteLine("DurationMinutes of Lesson--->" & DurationMinutes.ToString() & " minutes")
        Console.WriteLine("Does Lab Requires--->" & RequiresLab.ToString())
    End Sub
End Class
