Public Class Person
    Dim name As String
    Dim address As String
    Public Property Namee As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property Addresss As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property
    Public Sub Show()
        Console.WriteLine("Name is: " & name)
        Console.WriteLine("Address is: " & address)
    End Sub
End Class
