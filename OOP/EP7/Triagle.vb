Public Class Triagle
    Inherits Shape 'se ke thua 

    Private a, b, c As Integer

    Public Overrides Function CalArea() As Single
        Return 0
    End Function

    Public Overrides Function CalPeri() As Single
        Return a + b + c
    End Function
End Class
