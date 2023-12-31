Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Nhap n: ")
        Dim n As Integer = Integer.Parse(Console.ReadLine())
        Dim i As Integer = 1
        Console.WriteLine("The Odd list:")
        Console.WriteLine()
        Do
            Console.Write(i & vbTab)
            i += 2 'so le
        Loop While (i <= n)
    End Sub
End Module
