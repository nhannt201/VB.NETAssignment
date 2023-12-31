Public Class Books
    Public ID As Integer
    Public title As String
    Public price As Double

    Public Sub New() 'exlicit constructor - No parameter
        Me.ID = 0
        Me.title = ""
        Me.price = 0
    End Sub
    Public Sub New(ByVal id As Integer, ByVal title As String, ByVal price As Double)

        Me.ID = id ' tham so hinh thuc
        Me.title = title
        Me.price = price
    End Sub
    Public Sub Show()
        Console.WriteLine("Book ID: " & Me.ID)
        Console.WriteLine("Book Title: " & Me.title)
        Console.WriteLine("Book Price: " & Me.price)
    End Sub
End Class
