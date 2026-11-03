Module ExampleLooping
    Sub Run()
        Console.Write("Please input a start number: ")
        Dim StartNumber As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Please input an end number: ")
        Dim EndNumber As Integer = Integer.Parse(Console.ReadLine())

        For loopindex As Integer = StartNumber To EndNumber
            Console.WriteLine("Loop index: " & loopindex)
        Next

    End Sub
End Module
