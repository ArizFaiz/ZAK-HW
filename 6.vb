Imports System

Module Program
    Sub Main()
        Dim count As Integer
        Console.Write("Enter the number of donuts: ")
        count = (Console.ReadLine())
        If count >= 1 And count < 10 Then Console.WriteLine("Number of donuts is : " & count)
        If count > 9 Then Console.WriteLine("Number of donuts is : " & "many")
        Console.ReadLine()
    End Sub
End Module
