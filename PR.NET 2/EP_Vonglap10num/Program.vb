Imports System

Module Program
    Sub Main(args As String())
        For n = 1 To 10
            If (n = 5) Then
                Continue For ' sẽ quay lại bước n++ mà không chạy tiếp phần code dưới nó
            End If
            Console.WriteLine(n) 'In ra n
        Next
    End Sub
End Module
