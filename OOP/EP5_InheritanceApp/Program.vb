Imports System

Module Program
    Sub Main(args As String())
        Dim objS As Student = New Student() 'ko co ham dung tuong minh trong Student
        objS.Addresss = "ABCD"
        objS.Namee = "AAAA"
        objS.Subjectt = "SS"
        objS.Markk = 77
        objS.Show()
    End Sub
End Module
