Imports System

Module Program
    Sub Main(args As String())
        Dim cp, i, cf, res As Integer
        cp = 0
        i = 0
        cf = 0
        For i = 1 To 9

            Console.Write("Enter a res: (1 P - 2 F) =>")
            res = Integer.Parse(Console.ReadLine())
            Select Case (res)

                Case 1
                    cp += 1
                Case 2
                    cf += 1
                Case Else
                    Console.WriteLine("Khong dung!")
            End Select
        Next
        Console.WriteLine("Passed: {0} Failed: {1}", cp, cf)
    End Sub
End Module
