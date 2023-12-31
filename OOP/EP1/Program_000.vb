Imports System

Module Program
    Sub Main(args As String())
        'Dim student As Student = New Student()
        'student.setValues("BSF123", "Le Thi Tho", "thothi999@gmail.com", "0783400998")
        'Console.WriteLine(student.ToString())
        Dim objB1 As Books = New Books()
        Dim objB2 As Books = New Books(100, "Sach DEMO", 123.5)
        objB1.Show()
        objB2.Show()
        Console.WriteLine()
        objB2.price = 200
        objB2.Show()
    End Sub
End Module
