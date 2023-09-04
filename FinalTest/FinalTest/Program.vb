Imports System

Module Program
    Sub Main(args As String())
        Dim score As Double
        Dim grade As String
        Console.Write("Enter the score: ")
        score = Double.Parse(Console.ReadLine())
        If score >= 80 Then
            grade = "A"
        ElseIf score >= 70 Then
            grade = "B"
        ElseIf score >= 60 Then
            grade = "C"
        ElseIf score >= 50 Then
            grade = "D"
        Else
            grade = "F"
        End If
        Console.WriteLine("The grade is: " & grade)
    End Sub
End Module
