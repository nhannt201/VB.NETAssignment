Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer = 10
        Change(x)
        Console.WriteLine("x = {0}", x)
    End Sub
    Private Sub Change(ByVal x As Integer)
        x = 11
        Console.WriteLine("x = {0}", x)
    End Sub
End Module
