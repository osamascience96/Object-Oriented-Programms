Public Class Assessment
    Private AssessmentTitle As String
    Private MaxMarks As Double

    'init all the variables(attributes) of the class'
    Public Sub New(ByVal AssessmentTitle As String, ByVal MaxMarks As Double)
        Me.AssessmentTitle = AssessmentTitle
        Me.MaxMarks = MaxMarks
    End Sub

    Public Sub OutputAssessmentDetails()
        Console.WriteLine("Assessment Title--->" & AssessmentTitle)
        Console.WriteLine("Maximum Marks--->" & MaxMarks)
    End Sub
End Class
