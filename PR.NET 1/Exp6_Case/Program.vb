Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Nhap ki tu: ")
        Dim nhap As Char = Char.ToLower(Char.Parse(Console.ReadLine()))
        Select Case (nhap)

            Case "f"
                Console.WriteLine("Failed")
            Case "p"
                Console.WriteLine("Passed")
            Case "m"
                Console.WriteLine("Merit")
            Case "d"
                Console.WriteLine("Excellent")
            Case Else
                Console.WriteLine("Null")
        End Select
    End Sub
End Module
