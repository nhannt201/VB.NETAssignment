Imports System

Module Program
    Sub Main(args As String())
        Dim k, n As Integer
        Console.Write("Nhap n: ")
        n = Integer.Parse(Console.ReadLine())
        '//Console.WriteLine("This is a ");
        '//for (c = 1; c <6; c++)
        '//{
        '//    Console.WriteLine("\tnice");
        '//}
        '//Console.WriteLine("\t\tworld!!");
        Console.WriteLine("In so le: ")
        For k = 1 To n Step 2
            Console.WriteLine(k & vbTab)
        Next
        Console.WriteLine("In xong!")
    End Sub
End Module
