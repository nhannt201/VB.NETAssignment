Imports System

Module Program
    Sub Main(args As String())
        Dim num1 As Integer
        Console.Write("mot so nguyen: ")
        num1 = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Ban vua nhap: " & num1)
        Console.Write("mot so le: ")
        Dim sole As Single = Single.Parse(Console.ReadLine())
        Console.WriteLine("Ban vua so le: {0:F2}", sole)
    End Sub
End Module
