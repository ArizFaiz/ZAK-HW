Imports System

Module Program
    Sub Main()
        Dim str As String
        Dim i As Integer
        Dim Chr As Char
        Dim alpha As Integer
        Dim digit As Integer
        Dim space As Integer
        alpha = 0
        digit = 0
        space = 0

        Console.Write("Enter the string: ")
        str = UCase(Console.ReadLine())

        For i = 1 To Len(str)
            Chr = Mid(str, i, 1)
            If Chr >= "A" And Chr <= "Z" Then
                alpha = alpha + 1
            ElseIf Chr >= "0" And Chr <= "9" Then
                digit = digit + 1
            ElseIf Chr = " " Then
                space = space + 1
            End If
        Next
        Console.WriteLine("Number of alphabets in the string is " & alpha)
        Console.WriteLine("Number of digits in the string is " & digit)
        Console.WriteLine("Number of spaces in the string is " & space)
        Console.ReadLine()
    End Sub
End Module
