Imports System

Module Program
    Sub Main()
        Dim s As String
        Console.Write("Enter the string: ")
        s = Console.ReadLine()
        If Len(s) > 1 Then
            Console.WriteLine(Left(s, 2) & Right(s, 2))
        Else Console.WriteLine(s)
        End If
        Console.ReadLine()
    End Sub
End Module
