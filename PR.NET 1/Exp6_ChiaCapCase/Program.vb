Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter your class: ")
        Dim lop As Integer = Integer.Parse(Console.ReadLine())
        Select Case lop
            Case 0
                Console.WriteLine("You are Kindergarten")
            Case 1
            Case 2
            Case 3
            Case 4
            Case 5
                Console.WriteLine("You are Primary")
            Case 6
            Case 7
            Case 8
            Case 9
                Console.WriteLine("You are Secondary")
            Case 10
            Case 11
            Case 12
                Console.WriteLine("You are Hight School")
            Case Else
                If (lop < 1) Then
                    Console.WriteLine("No class available!")

                Else
                    Console.WriteLine("You are student!")
                End If
        End Select

    End Sub
End Module
