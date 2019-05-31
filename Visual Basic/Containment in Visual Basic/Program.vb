Imports System

Module Program
    Sub Main(args As String())
        Dim courseObj As New Course("Electronics", 10)
        Console.WriteLine("Course Title--->" & courseObj.GetCourseTitle())
        Console.WriteLine("Maximum Numbers of Students--->" & courseObj.GetMaximumStudents())
        courseObj.AddLesson("Boolean Logic", 45, True)
        courseObj.AddLesson("Classic Mechanics", 90, True)
        courseObj.AddAssessment("Assignment 1", 20.0)

    End Sub
End Module
