Public Class Course
    Private CourseTitle As String
    Private MaximumStudents As Integer
    Private NumberOfLessons As Integer
    'contains the objects of other classes in the main class, but not inherited
    Private CourseLesson(49) As Lesson
    Private CourseAssessment As Assessment

    Public Sub New(ByVal CourseTitle As String, ByVal MaximumStudents As Integer)
        'init the variables (attributes) of the class 
        Me.CourseTitle = CourseTitle
        Me.MaximumStudents = MaximumStudents
        NumberOfLessons = 0
    End Sub

    Public Function GetCourseTitle() As String
        Return CourseTitle
    End Function

    Public Function GetMaximumStudents() As Integer
        Return MaximumStudents
    End Function

    Public Sub AddLesson(ByVal LessonTitle As String, ByVal DurationMinutes As Integer, ByVal RequiresLab As Boolean)
        'increment number of lessons to 1, to attain the object every new time 
        If (NumberOfLessons <> 50) Then
            CourseLesson(NumberOfLessons) = New Lesson() 'goes to the index n, and init the new Lesson object'
            'at the current index, the current object of Lesson is used to set the properties of that specific object at that index
            ' by calling the methods
            CourseLesson(NumberOfLessons).SetLessonTitle(LessonTitle)
            CourseLesson(NumberOfLessons).SetDurationMinutes(DurationMinutes)
            CourseLesson(NumberOfLessons).SetLabFlag(RequiresLab)
            'display the lesson
            CourseLesson(NumberOfLessons).OutputLessonDetails()
            'increment the numbeoflesson to 1 each time'
            NumberOfLessons = NumberOfLessons + 1
        Else
            Console.WriteLine("List Overflow")
        End If
    End Sub

    Public Sub AddAssessment(ByVal AssessmenTitle As String, ByVal Marks As Double)
        Dim assessmentObj As New Assessment(AssessmenTitle, Marks)
        assessmentObj.OutputAssessmentDetails()
    End Sub

End Class
