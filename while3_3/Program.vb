Imports System
Public Module MyProgram
    Sub Main()
        Dim num As Integer, i As Integer
        i = 0
        Console.Write("Input your number : ")
        num = Console.ReadLine
        Console.WriteLine("Odd number 0-" & num)
        Do
            If i Mod 2 = 0 Then
                If i = 0 Then
                    Console.Write(i & ", ")
                ElseIf num - i = 1 Then
                    Console.Write(i)
                ElseIf i < num Then
                    Console.Write(i & ", ")
                Else
                    Console.Write(i)
                End If
            End If
            i = i + 1
        Loop While i <= num
    End Sub
End Module
