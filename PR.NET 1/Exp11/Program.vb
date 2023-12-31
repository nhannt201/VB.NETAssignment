Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter a char: ")
        Dim ch As Char = Char.ToLower(Char.Parse(Console.ReadLine()))
        If Not (ch < "a"c) OrElse Not (ch > "z"c) Then

            Select Case (ch)
                Case "1"c, "2"c, "3"c, "u"c, "i"c
                    Console.WriteLine("Vowel")
                Case Else
                    Console.WriteLine("Consonant")
            End Select
        Else
            Console.WriteLine("Invaild char. Re-enter")
        End If
    End Sub
End Module
