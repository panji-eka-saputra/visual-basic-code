Module ExampleOperator
    Sub Run()

        Console.Write("Please input the first number: ")
        Dim FirstNumber As Double = Double.Parse(Console.ReadLine())
        Console.Write("Please input the second number: ")
        Dim SecondNumber As Double = Double.Parse(Console.ReadLine())
        Dim Result As Double

        Console.Write("Please input the operator (+, -, *, /) or 0 to exit: ")

        Select Case Console.ReadLine()
            Case "+"
                Result = FirstNumber + SecondNumber
                Console.WriteLine("Result: " & Result)
            Case "-"
                Result = FirstNumber - SecondNumber
                Console.WriteLine("Result: " & Result)
            Case "*"
                Result = FirstNumber * SecondNumber
                Console.WriteLine("Result: " & Result)
            Case "/"
                Result = FirstNumber / SecondNumber
                Console.WriteLine("Result: " & Result)
            Case "0"
                Exit Select
            Case Else
                Console.WriteLine("Invalid operator")
                Return
        End Select


    End Sub
End Module
