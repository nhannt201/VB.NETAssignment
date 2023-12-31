Imports System

Module Program
    Sub Main(args As String())
        Dim i As Integer = 0
        While (i <= 10)
            i += 1
            If (i = 5) Then
                Continue While 'khong thuc hien buoc nay va lap lai.
            End If
            Console.WriteLine(i & vbTab)
        End While
        Console.WriteLine()
    End Sub
End Module
