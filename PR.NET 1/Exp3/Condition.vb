Imports System

Module Condition
    Sub Main(args As String())
        Dim grade As Integer
        Dim name As String
        Console.Write("Ten cua ban: ")
        name = Console.ReadLine()
        Console.Write("Nhap diem cua ban: ")
        grade = Integer.Parse(Console.ReadLine())
        Console.WriteLine()
        If (grade >= 60) Then
            Console.WriteLine("{0} - {1}", name, grade)
            Console.WriteLine("You are passed")
        Else
            Console.WriteLine("{0} is failed!", name)
        End If
    End Sub
End Module
