Imports System

Module Program
    Sub Main()
        Dim str1 As String
        Dim i As Integer
        Dim hasall As Boolean

        Console.Write("Enter the string: ")
        str1 = UCase(Console.ReadLine())
        hasall = True
        For i = 65 To 90
            If InStr(str1, Chr(i)) = 0 Then
                Console.WriteLine("The string does not have all the alphabets")
                hasall = False
                Exit For
            End If
        Next
        If hasall = True Then Console.WriteLine("The string has all tha alphabets")
        Console.ReadLine()
    End Sub
End Module
