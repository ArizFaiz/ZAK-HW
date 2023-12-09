Imports System
Imports Microsoft

Module Program
    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""

        Console.Write("Enter a string: ")
        Str1 = Console.ReadLine()

        Console.Write("Enter a character to find: ")
        Char1 = Console.ReadLine()

        Console.Write("Enter a character to replace: ")
        Char2 = Console.ReadLine()

        For i = 1 To Len(Str1)
            Char3 = Mid(Str1, i, 1)
            If Char3 = Char1 Then
                Str2 = Str2 & Char2
            Else
                Str2 = Str2 & Char3
            End If
        Next
        Console.WriteLine("The new string is: " & Str2)
        Console.ReadLine()
    End Sub
End Module
