Module ExampleDate
    Sub Run()
        Console.WriteLine("=== Date Operations ===")
        Console.WriteLine("1. Check current date and time")
        Console.WriteLine("2. Add days to current date")
        Console.WriteLine("3. Subtract days from current date")
        Console.WriteLine("4. Calculate difference between two dates")
        Console.WriteLine("0. Back to main menu")
        Do
            Console.Write("Please select an option (1, 2, 3, 4) or 0 to exit: ")
            Select Case Console.ReadLine()
                Case "1"
                    Dim currentDate As DateTime = DateTime.Now
                    Console.WriteLine($"Current date and time: {currentDate}")
                Case "2"
                    Console.Write("Enter number of days to add: ")
                    Dim daysToAdd As Integer = Integer.Parse(Console.ReadLine())
                    Dim newDate As DateTime = DateTime.Now.AddDays(daysToAdd)
                    Console.WriteLine($"New date after adding {daysToAdd} days: {newDate}")
                Case "3"
                    Console.Write("Enter number of days to subtract: ")
                    Dim daysToSubtract As Integer = Integer.Parse(Console.ReadLine())
                    Dim newDate As DateTime = DateTime.Now.AddDays(-daysToSubtract)
                    Console.WriteLine($"New date after subtracting {daysToSubtract} days: {newDate}")
                Case "4"
                    Console.Write("Enter the first date (yyyy-MM-dd): ")
                    Dim firstDate As DateTime = DateTime.Parse(Console.ReadLine())
                    Console.Write("Enter the second date (yyyy-MM-dd): ")
                    Dim secondDate As DateTime = DateTime.Parse(Console.ReadLine())
                    Dim difference As TimeSpan = secondDate - firstDate
                    Console.WriteLine($"Difference between the two dates: {difference.Days} days")
                Case "0"
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid option. Please try again.")
            End Select
        Loop

    End Sub
End Module
