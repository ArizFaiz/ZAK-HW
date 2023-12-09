Imports System

Module Program
    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2 As Char
        Dim i As Integer

        Str1 = ""
        Char1 = ""
        Char2 = ""

        Console.Write("Enter a string: ")
        Str1 = Console.ReadLine()
        Char1 = Left(Str1, 1)
        Str2 = Char1

        For i = 2 To Len(Str1)
            Char2 = Mid(Str1, i, 1)
            If Char2 = Char1 Then
                Str2 = Str2 & "*"
            Else
                Str2 = Str2 & Char2
            End If
        Next
        Console.WriteLine("The new string is: " & Str2)
        Console.ReadLine()
    End Sub
End Module
