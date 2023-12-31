Public Class Rectangle
    Inherits Shape
    Dim dai, rong As Single
    Public Overrides Function CalArea() As Single
        Return dai * rong
    End Function

    Public Overrides Function CalPeri() As Single
        Return dai + rong
    End Function
End Class
