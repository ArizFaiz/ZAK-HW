Imports System

Module Program
    Sub Main()
        Dim str As String
        Console.Write("Enter the string: ")
        str = Console.ReadLine()
        If (InStr(str, "not")) < (InStr(str, "bad")) Then
            Console.WriteLine(Mid(str, 1, InStr(str, "not") - 1) & "good")
        Else Console.WriteLine(str)
        End If
        Console.ReadLine()
    End Sub
End Module
