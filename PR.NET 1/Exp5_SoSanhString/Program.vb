Imports System

Module Program
    Sub Main(args As String())
        Dim s1, s2 As String
        Console.Write("Nhap s1: ")
        s1 = Console.ReadLine()
        Console.Write("Nhap s2: ")
        s2 = Console.ReadLine()
        If (s1.Equals(s2)) Then
            Console.WriteLine("{0} == {1}", s1, s2)

        Else
            Console.WriteLine("{0} !== {1}", s1, s2)
        End If
    End Sub
End Module
