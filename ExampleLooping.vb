Module ExampleLooping
    Sub Run()
        Console.WriteLine("=== For Loop ===")
        Console.Write("Please input a start number: ")
        Dim StartNumber As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Please input an end number: ")
        Dim EndNumber As Integer = Integer.Parse(Console.ReadLine())

        For loopindex As Integer = StartNumber To EndNumber
            Console.WriteLine("Loop index: " & loopindex)
        Next

        Console.WriteLine("=== Do Loop ===")
        Console.Write("Please input a number: ")
        Dim NumberDoLoop As Integer = Integer.Parse(Console.ReadLine())
        Dim i As Integer = 1
        Do
            Console.WriteLine("Do loop index: " & i)
            i += 1
        Loop While i <= NumberDoLoop

        Console.WriteLine("=== Do While ===")
        Console.Write("Please input a number: ")
        Dim NumberDoWhile As Integer = Integer.Parse(Console.ReadLine())
        Dim NumberDoWhileIndex As Integer = 1
        Do While NumberDoWhileIndex <= NumberDoWhile
            Console.WriteLine("Do while loop index: " & NumberDoWhileIndex)
            NumberDoWhileIndex += 1
        Loop

        Console.WriteLine("=== Do Until ===")
        Console.Write("Please input your saldo: ")
        Dim Saldo As Integer = Integer.Parse(Console.ReadLine())
        Dim MinimumSaldo As Integer = 50000

        Do Until Saldo < MinimumSaldo
            Saldo -= 50000
            Console.WriteLine("Your saldo is: " & Saldo)
        Loop

        Console.WriteLine("=== Do Loop Until ===")
        Console.Write("Please input a number: ")
        Dim NumberOfAttempt As Integer = Integer.Parse(Console.ReadLine())
        Dim j As Integer = 1
        Do
            j += 1
        Loop Until j > NumberOfAttempt
        Console.WriteLine("Total Attempts: " & j)

        Console.WriteLine("=== For Each Loop ===")
        Dim fruits = {"Apple", "Banana", "Cherry", "Watermelon"}
        For Each fruit In fruits
            Console.WriteLine("Fruit: " & fruit)
        Next


    End Sub
End Module
