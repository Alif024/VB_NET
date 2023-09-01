Imports System
Public Module MyProgram
    Sub Main()
        Dim text As String
        Console.Write("Input your text : ")
        text = Console.ReadLine
        Console.WriteLine("Begin")
        Console.WriteLine(text)
        For i As Integer = 1 To 9
            Console.WriteLine(" " & text)
        Next
        Console.WriteLine(" End")
    End Sub
End Module
