Module ExampleCondition
    Sub Run()
        Console.Write("Please input your result: ")
        Dim result As Double = Double.Parse(Console.ReadLine())
        If result >= 85 AndAlso result <= 100 Then
            Console.WriteLine("Your grade is A")
        ElseIf result >= 70 AndAlso result < 85 Then
            Console.WriteLine("Your grade is B")
        ElseIf result >= 50 AndAlso result < 70 Then
            Console.WriteLine("Your grade is C")
        ElseIf result >= 30 AndAlso result < 50 Then
            Console.WriteLine("Your grade is D")
        ElseIf result >= 0 AndAlso result < 30 Then
            Console.WriteLine("Failed")
        Else
            Console.WriteLine("Invalid result")
        End If
    End Sub

End Module
