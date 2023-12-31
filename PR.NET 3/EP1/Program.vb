Imports System

Module Program
    Sub Main(args As String())
        Dim n1, n2, num, sum As Integer
        While (True)
            Console.WriteLine("1.Find Max " & vbNewLine & "2.Print 1 to n" & vbNewLine & "3.Sum 1 to n" & vbNewLine & "4.Print Astric" & vbNewLine & "5.Exit")
            Console.Write("====> Enter a option: ")
            Dim cn As Integer = Integer.Parse(Console.ReadLine())
            Select Case (cn)

                Case 1
                    Console.Write("Enter a n1: ")
                    n1 = Integer.Parse(Console.ReadLine())
                    Console.Write("Enter a n2: ")
                    n2 = Integer.Parse(Console.ReadLine())
                    FindMax(n1, n2)

                Case 2
                    Console.Write("Enter num: ")
                    num = Integer.Parse(Console.ReadLine())
                    PrintNum(num)

                Case 3
                    Console.Write("Enter num: ")
                    num = Integer.Parse(Console.ReadLine())
                    sum = Sumnum(num)
                    Console.WriteLine("Sum of 1 to {0} is {1}", num, sum)

                Case 4
                    Console.Write("Enter num: ")
                    num = Integer.Parse(Console.ReadLine())
                    PrintTriangle(num)

                Case 5
                    Console.WriteLine("Bye bye")
                    Environment.Exit(0)

                Case Else
                    Console.WriteLine("Invaild num. Plse re-enter")
            End Select
        End While
        Console.WriteLine("-----------------------------------------\nNew Option\n-----------------------------------------")
    End Sub
    'FindMax
    Private Sub FindMax(ByVal x As Integer, ByVal y As Integer)

        Dim max As Integer = If(x > y, x, y)
        Console.WriteLine("Max of {0} and {1} is {2}", x, y, max)
    End Sub

    '/PrintNum
    Private Sub PrintNum(ByVal n As Integer)

        Dim i As Integer
        For i = 1 To n

            Console.Write(i & vbTab)
        Next
        Console.WriteLine()
    End Sub
    'SumNum
    Private Function Sumnum(ByVal n As Integer) As Integer
        Dim i As Integer
        Dim sum As Integer = 0
        For i = 1 To n
            sum += i
        Next
        Return sum
    End Function
    'In tam giac hoa thi
    Private Sub PrintTriangle(ByVal n As Integer)

        For i = 1 To n - 1

            For j = 1 To i 'print astric

                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        End Sub
End Module
