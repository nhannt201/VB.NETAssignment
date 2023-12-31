Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter a number n:")
        Dim n As Integer = Integer.Parse(Console.ReadLine())
        For i = 1 To n Step 2

            Console.WriteLine(i)
        Next
        Console.WriteLine("Finished running, press any key to exit.")
    End Sub
End Module
