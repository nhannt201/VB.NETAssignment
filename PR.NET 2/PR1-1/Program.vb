Imports System

Module Program
    Sub Main(args As String())
        Dim fact, i, n As Integer
        fact = 1
        i = 1
        Console.Write("Enter n: ")
        n = Integer.Parse(Console.ReadLine())
        If (n < 0) Then
            Console.WriteLine("n khong duoc < 0, vui long nhap lai!")
        Else
            While (i <= n)

                If (n = 0) Then
                    Console.WriteLine("The Factorial of {0} is {1}", n, fact)
                    Exit While
                Else
                    fact *= i
                End If
                i += 1
            End While
            Console.WriteLine("The Factorial of {0} is {1}", n, fact)
        End If
    End Sub
End Module
