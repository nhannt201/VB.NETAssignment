Imports System

Module Program
    Sub Main(args As String())
        Dim objB As Product = New Product()
        objB.id = 345
        objB.name = "TV OLED"
        objB.setPrice(111)
        Console.WriteLine("The information of product: " + objB.ToString())
        Console.WriteLine("Pd ID: " & objB.id)
        Console.WriteLine("Pd name: " & objB.name)
        Console.WriteLine("Pd Price: " & objB.getProduct())
    End Sub
End Module
