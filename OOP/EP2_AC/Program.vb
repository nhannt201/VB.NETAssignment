Imports System

Module Program
    Sub Main(args As String())
        Dim obj As Students = New Students()
        obj.setInfor("Nhan", 24, "HCM city", "5")
        Console.WriteLine("Show information: " + obj.getInfor())
    End Sub
End Module
