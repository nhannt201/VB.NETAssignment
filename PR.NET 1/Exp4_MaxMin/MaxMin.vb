Imports System

Module MaxMin
    Sub Main(args As String())
        Dim a, b, max As Integer
        Console.Write("Enter number a: ")
        a = Integer.Parse(Console.ReadLine())
        Console.Write("Enter number b: ")
        b = Integer.Parse(Console.ReadLine())
        max = If(a > b, a, b)
        Console.WriteLine("Max of a and b is {0}", max)
    End Sub
End Module
