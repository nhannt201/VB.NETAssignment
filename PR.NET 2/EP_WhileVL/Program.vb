Imports System

Module Program
    Sub Main(args As String())
        Dim sum, count, grade, avg As Integer
        sum = 0
        count = 0
        Console.Write("Nhap diem: ")
        grade = Convert.ToInt32(Console.ReadLine())
        While grade <> -1
            sum += grade
            Console.Write("Nhap diem: ")
            grade = Integer.Parse(Console.ReadLine())
            count += 1
        End While
        If (count <> 0) Then
            avg = sum / count
            Console.WriteLine("The avg of " & count & " is " & avg)
        End If
    End Sub
End Module
