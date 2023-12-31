Public Class Product
    Public id As Integer
    Public name As String
    Private price As Double
    Public Function ToString() As String 'string thi Function

        Return id & vbTab & name & vbTab & price
    End Function
    Public Function getProduct() As Double

        Return price
    End Function
    Public Sub setPrice(ByVal gia As Double) 'Void thi Sub

        Me.price = gia
    End Sub
End Class
