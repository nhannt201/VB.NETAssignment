Imports System

Module ToanTongHop
    Sub Main(args As String())
        Console.WriteLine("Nhap 2 so nguyen: ")
        Console.Write("Nhap so thu nhat: ")
        Dim a As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Nhap so thu hai: ")
        Dim b As Integer = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Cac phep toan: +, -, *, / ")
        Console.Write("Nhap phep toan: ")
        Dim pt As String = (Console.ReadLine())
        Select Case (pt)
            Case "+"
                Console.WriteLine("Dap an cong: " & (a + b)) 'trong vb phep toan moi dung +-*/ con lai dung &
            Case "-"
                Console.WriteLine("Dap an tru: " & (a - b))
            Case "*"
                Console.WriteLine("Dap an nhan: " & (a * b))
            Case "/"
                Console.WriteLine("Dap an chia: " & (a / b))
            Case Else
                Console.WriteLine("Phep toan khong hop le. Vui long nhap lai!")
        End Select
    End Sub
End Module
