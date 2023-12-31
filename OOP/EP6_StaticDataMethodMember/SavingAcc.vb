Public Class SavingAcc
    Dim balance As Double
    Shared currInterestRate As Single = 0.04F ' Public khai bao de minh goi SavingAcc.currInterestRate duoc luon
    'static -> shared
    'static dung chung bo nho
    Public Sub New(ByVal balan As Double)

        Me.balance = balan
    End Sub
    Public Function getBalance() As Double

        Return balance
    End Function

    Public Sub setBanlance(ByVal banl As Double)

        balance += banl
    End Sub
    Public Shared Function getInter() As Single

        Return currInterestRate
    End Function
    Public Shared Sub setInter(ByVal lay As Single)

        currInterestRate = lay
    End Sub
End Class
