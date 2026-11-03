Module ExampleArray
    Sub Run()
        Dim numbers() As Integer = {1, 2, 3, 4, 5}
        Console.WriteLine("Length of the array: " & numbers.Length)
        Console.Write("Elements in the array: ")
        Dim Element As Integer = Integer.Parse(Console.ReadLine())
        If Element >= 0 AndAlso Element < numbers.Length Then
            Console.WriteLine($"Element at index {Element}: {numbers(Element)}")
        Else
            Console.WriteLine("Index is out of range.")
        End If

        Console.WriteLine("Add new element to the array: ")
        Dim NewElement As Integer = Integer.Parse(Console.ReadLine())
        ReDim Preserve numbers(numbers.Length)
        numbers(numbers.Length - 1) = NewElement
        For Each number As Integer In numbers
            Console.WriteLine(number)
        Next
    End Sub
End Module
