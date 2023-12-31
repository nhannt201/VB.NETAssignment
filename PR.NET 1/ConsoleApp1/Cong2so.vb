Imports System

Module Cong2so
    Sub Main(args As String())
        Dim n1, n2, result As Integer
        Console.Write("Nhap so a:")
        n1 = Convert.ToInt32(Console.ReadLine())
        Console.Write("Nhap so b:")
        n2 = Integer.Parse(Console.ReadLine())
        result = n1 + n2
        Console.WriteLine("Total: a+b= {0}", result)
    End Sub
End Module
