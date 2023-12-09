Imports System

Module Program
    Sub Main()
        Dim str As String
        Dim i, Vow, acount, ecount, icount, ocount, ucount As Integer
        Dim ch As Char

        Console.Write("Enter the string: ")
        Str = UCase(Console.ReadLine())
        For i = 1 To Len(Str)
            Ch = Mid(Str, i, 1)
            If InStr("AEIOU", Ch) > 0 Then Vow = Vow + 1
            If ch = "A" Then acount = acount + 1
            If ch = "E" Then ecount = ecount + 1
            If ch = "I" Then icount = icount + 1
            If ch = "O" Then ocount = ocount + 1
            If ch = "U" Then ucount = ucount + 1
        Next
        Console.WriteLine("Number of Vowels in the string is " & Vow)
        Console.WriteLine("Number of 'A' in the string is " & acount)
        Console.WriteLine("Number of 'E' in the string is " & ecount)
        Console.WriteLine("Number of 'I' in the string is " & icount)
        Console.WriteLine("Number of 'O' in the string is " & ocount)
        Console.WriteLine("Number of 'U' in the string is " & ucount)
        Console.ReadLine()
    End Sub
End Module
