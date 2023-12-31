Imports System

Module Program
    Sub Main(args As String())
        Dim objS1 As SavingAcc = New SavingAcc(50)
        Dim objS2 As SavingAcc = New SavingAcc(100)
        Dim objS3 As SavingAcc = New SavingAcc(1000.25)
        Dim Interest1 As Double = objS1.getBalance() * SavingAcc.getInter()
        Dim Interest2 As Double = objS2.getBalance() * SavingAcc.getInter()
        Dim Interest3 As Double = objS3.getBalance() * SavingAcc.getInter()
        Console.WriteLine("Inrest1 of O1 is {0:F2} ", Interest1)
        Console.WriteLine("Inrest2 of O2 is {0:F2}", Interest2)
        Console.WriteLine("Inrest3 of O3 is {0:F2}", Interest3)
        Console.WriteLine()
        objS1.setBanlance(600)
        SavingAcc.setInter(0.05F)
        Interest1 = objS1.getBalance() * SavingAcc.getInter()
        Interest2 = objS2.getBalance() * SavingAcc.getInter()
        Interest3 = objS3.getBalance() * SavingAcc.getInter()
        Console.WriteLine("Inrest1 of O1 is {0:F2} ", Interest1)
        Console.WriteLine("Inrest2 of O2 is {0:F2}", Interest2)
        Console.WriteLine("Inrest3 of O3 is {0:F2}", Interest3)
    End Sub
End Module
