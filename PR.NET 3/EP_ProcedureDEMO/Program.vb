Imports System

Module Program
    Sub Main(args As String())
        welcome()
        Console.WriteLine("Max {0}", FindBig(100, 50))
    End Sub
    Private Function conghaiso(ByVal a As Integer, ByVal b As Integer) As Integer

        Return a + b
    End Function
    Private Function FindBig(ByVal x As Integer, ByVal y As Integer) As Integer 'Formal parameter: tham so hinh thuc

        Dim big As Integer
        big = If(x > y, x, y)
        Return big
    End Function

    Private Function Product2Num(ByVal a As Single, ByVal b As Single) As Single

        Dim pro As Single = a * b
        Return pro
    End Function
    Private Sub P2N_NR(ByVal a As Single, ByVal b As Single) 'Calling Function

        'Call Function
        Dim pro As Single = a * b
        Console.WriteLine("The product of  0 * 1 = 2", a, b, pro)
    End Sub
    Private Sub welcome()

        Console.WriteLine("Welcome to C#")
    End Sub
End Module
