Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c, max As Integer
        Console.Write("Nhap so a: ")
        a = Integer.Parse(Console.ReadLine())
        Console.Write("Nhap so b: ")
        b = Integer.Parse(Console.ReadLine())
        Console.Write("Nhap so c: ")
        c = Integer.Parse(Console.ReadLine())
        max = If(a > b, a, b)
        max = If(max > c, max, c)
        '//if ((a==b) && (b==c))
        '//{
        '//    max = a
        '//} else { 
        '//max = (a > b ? a : b)
        '//max = (max > c ? max : c)
        '//}
        Console.WriteLine("Max {0}", max)
    End Sub
End Module
