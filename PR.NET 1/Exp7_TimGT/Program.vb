Imports System

Module Program
    Sub Main(args As String())
        Dim numI As Integer
        Dim numF As Single
        Dim ch As Char = "a"
        Dim check As Boolean = True
        Dim numD As Double
        'String Str
        ' Console.Write("Enter a String: ")
        ' Str = Console.ReadLine()
        ' Console.WriteLine("String is " + Str())
        ' Console.WriteLine("String is {0} ", Str)
        ' Console.WriteLine()
        ' Console.WriteLine("Char is " + ch)
        ' Console.WriteLine("Char is {0}", ch)
        ' Console.WriteLine()
        ' Console.WriteLine("Bool is " + check)
        ' Console.WriteLine("Bool is {0}", check)
        ' Console.WriteLine()

        'Nhap readline voi float va doable la so le voi dau ','
        Console.Write("Enter an integer number: ")
        numI = Convert.ToInt32(Console.ReadLine())
        '/*  numI = int.Parase(Console.ReadLine())
        '  numI = Int32.Parse(Console.WriteLine())*/
        Console.Write("Enter a float number: ")
        '  numF = Convert.ToSingle(Console.ReadLine())
        numF = Single.Parse(Console.ReadLine())
        'numF = Single.Parse(Console.ReadLine())
        Console.Write("Enter a double number: ")
        '  numD = Convert.ToDouble(Console.ReadLine())
        '   numD = double.Parse(Console.ReadLine())
        numD = Double.Parse(Console.ReadLine())
        ' write code quickly : cw TAB tab -> Console.WriteLine()
        Console.WriteLine("The integer number is " & numI)
        Console.WriteLine("The integer numbe is {0} ", numI)
        Console.WriteLine()
        Console.WriteLine("The float number is " & numF)
        Console.WriteLine("The float numbe is {0:F2} ", numF)
        Console.WriteLine()
        Console.WriteLine("The double number is " & numD)
        Console.WriteLine("The double numbe is {0:F3} ", numD)
        Console.WriteLine()
    End Sub
End Module
