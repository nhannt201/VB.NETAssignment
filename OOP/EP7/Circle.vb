Public Class Circle
    Inherits Shape
    Private radious As Single
    Public Const PI As Single = 3.14F

    Public Overrides Function CalArea() As Single
        Return radious * radious * PI
    End Function

    Public Overrides Function CalPeri() As Single
        Return (radious * 2) * PI
    End Function
End Class
