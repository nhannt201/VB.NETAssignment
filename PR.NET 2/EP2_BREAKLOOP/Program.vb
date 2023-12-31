Imports System

Module Program
    Sub Main(args As String())
        Dim i As Integer = 1
        While (i <= 10)
            Console.Write(i & " ")
            i += 1
            If (i >= 6) Then

                Exit While

            End If
        End While
        Console.WriteLine()
    End Sub
End Module
