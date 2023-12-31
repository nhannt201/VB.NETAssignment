Imports System

Module ToanTangDan
    Sub Main(args As String())
        Dim a As Integer
        Console.Write("a: ")
        a = Integer.Parse(Console.ReadLine())
        a = ++a
        Console.WriteLine(" ++ is " & a)
        a = --a
        Console.WriteLine(" -- is " & a)
        a = a + +++a ' 6 + 6 = 12
        Console.WriteLine("  is " & a)
    End Sub
End Module
