Public Class Students
    Dim name As String
    Dim age As Integer
    Dim adr As String
    Dim gba As String
    Public Sub setInfor(ByVal name As String, ByVal age As Integer, ByVal adr As String, ByVal gba As String)

        Me.name = name
        Me.age = age
        Me.adr = adr
        Me.gba = gba
    End Sub
    Public Function getInfor() As String
        Return name & vbTab & age & vbTab & adr & vbTab & gba
    End Function
End Class
