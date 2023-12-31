Public Class Student
    Private stdCode, name, email, mobile As String 'attribute
    ' implicit constrcutor -  default construcotor
    Public Function ToString() As String
        Return stdCode + vbTab + name + vbTab + email + vbTab + mobile
    End Function
    Public Sub setValues(ByVal code As String, ByVal name As String, ByVal email As String, ByVal mobile As String)
        Me.stdCode = code
        Me.name = name
        Me.email = email
        Me.mobile = mobile
    End Sub
End Class
