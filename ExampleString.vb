Module ExampleString
    Sub Run()
        Console.Write("Please input your text: ")
        Dim Text As String = Console.ReadLine()
        Do
            Console.WriteLine("Please select an option:")
            Console.WriteLine("1. Display text")
            Console.WriteLine("2. Convert to uppercase")
            Console.WriteLine("3. Convert to lowercase")
            Console.WriteLine("4. Display length of the text")
            Console.WriteLine("5. Replace text")
            Console.WriteLine("0. Back to main menu")
            Console.Write("Please input your options (1, 2, 3, 4, 5) or 0 to exit: ")
            Select Case Console.ReadLine()
                Case "1"
                    Console.WriteLine($"Text: {Text}")
                Case "2"
                    Console.WriteLine($"Uppercase: {Text.ToUpper()}")
                Case "3"
                    Console.WriteLine($"Lowercase: {Text.ToLower()}")
                Case "4"
                    Console.WriteLine($"Length: {Text.Length}")
                Case "5"
                    Console.Write("Enter the text to replace: ")
                    Dim oldText As String = Console.ReadLine()
                    Console.Write("Enter the new text: ")
                    Dim newText As String = Console.ReadLine()
                    Text = Text.Replace(oldText, newText)
                    Console.WriteLine($"Updated text: {Text}")
                Case "0"
                    Exit Do
            End Select
        Loop

    End Sub
End Module
