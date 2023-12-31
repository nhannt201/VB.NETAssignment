Public Class Student
    Inherits Person 'ke thua class person, hoi khac C3 xiu
    Dim subject As String
    Dim mark As Integer

    Public Property Subjectt As String
        Get
            Return subject
        End Get
        Set(value As String)
            subject = value
        End Set

    End Property
    Public Property Markk As Integer
        Get
            Return mark
        End Get
        Set(value As Integer)
            mark = value
        End Set
    End Property

    Public Sub Show()
        MyBase.Show() 'thua ke Show cua lop Person. Tat la viet tiep  Show trong Person
        Console.WriteLine("Subject is " & subject)
        Console.WriteLine("Mark is " & mark)
    End Sub


End Class
