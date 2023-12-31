Public Class Employee
    Private empName As String
    Private empID As Integer
    Private currPay As Single 'float to single
    Public Sub New() 'ko khai bao gi het tu dong dat la null hoac 0

    End Sub
    '  C#         public int ID { get; set; } to VB is Public Property ID As Integer
    Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Single) 'ben c# de ten giong class, vb.net thi de la New.
        Me.empName = name
        Me.empID = id
        Me.currPay = pay
    End Sub
    Public Property EmpNamee As String

        Get
            Return empName
        End Get
        Set(ByVal value As String)
            empName = value
        End Set
    End Property

    Public Property EmpIDd As Integer
        Get
            Return empID
        End Get
        Set(ByVal value As Integer)
            empID = value
        End Set
    End Property

    Public Property EmpCurrPayy As Single
        Get
            Return currPay
        End Get
        Set(value As Single)
            currPay = value
        End Set
    End Property
    Public Sub Show()
        Console.WriteLine("Emp ID: " & Me.empID)
        Console.WriteLine("Emp Name: " & Me.empName)
        Console.WriteLine("Emp CurrPay: " & Me.EmpCurrPayy)
    End Sub
End Class
