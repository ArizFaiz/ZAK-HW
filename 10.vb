Imports System

Module Program
    Sub Main()
        Dim str1 As String
        Console.Write("Enter the string: ")
        str1 = (Console.ReadLine())
        If Len(str1) > 2 And Right(str1, 3) <> "ing" Then Console.WriteLine(str1 & "ing")
        If Len(str1) > 2 And Right(str1, 3) = "ing" Then Console.WriteLine(str1 & "ly")
        If Len(str1) < 3 Then Console.WriteLine(str1)
        Console.ReadLine()
    End Sub
End Module
