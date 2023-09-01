Imports System
Public Module MyProgram
    Sub Main()
        Dim grade As Integer
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("Input your score : ")
        grade = Console.ReadLine()
        Select Case grade
            Case >= 80 : Console.Write("You grade A")
            Case >= 70 : Console.Write("You grade B")
            Case >= 60 : Console.Write("You grade C")
            Case >= 50 : Console.Write("You grade D")
            Case Else : Console.Write("You grade F")
        End Select
        Console.WriteLine("")
        Console.WriteLine("Thanks for using")
    End Sub
End Module