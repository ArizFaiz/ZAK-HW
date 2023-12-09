Imports System

Module Program
    Sub Main()
        Dim str1, str2, f2charstr1, f2charstr2 As String
        Console.Write("Enter the string: ")
        str1 = (Console.ReadLine())
        Console.Write("Enter the string: ")
        str2 = (Console.ReadLine())
        f2charstr1 = Left(str1, 2)
        f2charstr2 = Left(Str2, 2)
        Console.WriteLine(f2charstr2 & Mid(str1, 3, Len(str1)) & " " & f2charstr1 & Mid(str2, 3, Len(str2)))
        Console.ReadLine()
    End Sub
End Module
