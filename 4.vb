Imports System
Imports System.Numerics

Module Program
    Sub Main()
        Dim str1 As String
        Dim count, count1, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, big As Integer
        Dim char1 As Char
        str1 = ""
        char1 = ""
        a = 0
        b = 0
        c = 0
        d = 0
        e = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        k = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        x = 0
        y = 0
        z = 0
        Console.Write("Enter the string: ")
        str1 = UCase(Console.ReadLine())
        For count = 1 To Len(str1)
            If Mid(str1, i, 1) = "A" Then a = a + 1
            If Mid(str1, i, 1) = "B" Then b = b + 1
            If Mid(str1, i, 1) = "C" Then c = c + 1
            If Mid(str1, i, 1) = "D" Then d = d + 1
            If Mid(str1, i, 1) = "E" Then e = e + 1
            If Mid(str1, i, 1) = "F" Then f = f + 1
            If Mid(str1, i, 1) = "G" Then g = g + 1
            If Mid(str1, i, 1) = "H" Then h = h + 1
            If Mid(str1, i, 1) = "i" Then i = i + 1
            If Mid(str1, i, 1) = "J" Then j = j + 1
            If Mid(str1, i, 1) = "K" Then k = k + 1
            If Mid(str1, i, 1) = "L" Then l = l + 1
            If Mid(str1, i, 1) = "M" Then m = m + 1
            If Mid(str1, i, 1) = "N" Then n = n + 1
            If Mid(str1, i, 1) = "O" Then o = o + 1
            If Mid(str1, i, 1) = "P" Then p = p + 1
            If Mid(str1, i, 1) = "Q" Then q = q + 1
            If Mid(str1, i, 1) = "R" Then r = r + 1
            If Mid(str1, i, 1) = "S" Then s = s + 1
            If Mid(str1, i, 1) = "T" Then t = t + 1
            If Mid(str1, i, 1) = "U" Then u = u + 1
            If Mid(str1, i, 1) = "V" Then v = v + 1
            If Mid(str1, i, 1) = "W" Then w = w + 1
            If Mid(str1, i, 1) = "X" Then x = x + 1
            If Mid(str1, i, 1) = "Y" Then y = y + 1
            If Mid(str1, i, 1) = "Z" Then z = z + 1
            If a > big Then
                big = a
                char1 = "a"
            End If
            If b > big Then
                big = b
                char1 = "b"
            End If
            If c > big Then
                big = c
                char1 = "c"
            End If
            If d > big Then
                big = d
                char1 = "d"
            End If
            If e > big Then
                big = e
                char1 = "e"
            End If
            If f > big Then
                big = f
                char1 = "f"
            End If
            If g > big Then
                big = g
                char1 = "g"
            End If
            If h > big Then
                big = h
                char1 = "h"
            End If
            If i > big Then
                big = i
                char1 = "i"
            End If
            If j > big Then
                big = j
                char1 = "j"
            End If
            If k > big Then
                big = k
                char1 = "k"
            End If
            If l > big Then
                big = l
                char1 = "l"
            End If
            If m > big Then
                big = m
                char1 = "m"
            End If
            If n > big Then
                big = n
                char1 = "n"
            End If
            If o > big Then
                big = o
                char1 = "o"
            End If
            If p > big Then
                big = p
                char1 = "p"
            End If
            If q > big Then
                big = q
                char1 = "q"
            End If
            If r > big Then
                big = r
                char1 = "r"
            End If
            If s > big Then
                big = s
                char1 = "s"
            End If
            If t > big Then
                big = t
                char1 = "t"
            End If
            If u > big Then
                big = u
                char1 = "u"
            End If
            If v > big Then
                big = v
                char1 = "v"
            End If
            If w > big Then
                big = w
                char1 = "w"
            End If
            If x > big Then
                big = x
                char1 = "x"
            End If
            If y > big Then
                big = y
                char1 = "y"
            End If
            If z > big Then
                big = z
                char1 = "z"
            End If
        Next
        Console.WriteLine("The character which appears the most is :" & char1 & "which appears " & big & " times")
        Console.ReadLine()


    End Sub
End Module
