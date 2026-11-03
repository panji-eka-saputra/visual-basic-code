Module ExampleList
    Sub Run()
        Dim numbers As New List(Of Integer) From {1, 2, 3, 4, 5}
        Do

            Console.WriteLine("Please select operation for list")
            Console.WriteLine("1. Display all elements")
            Console.WriteLine("2. Add new element")
            Console.WriteLine("3. Insert new element")
            Console.WriteLine("4. Remove by index")
            Console.WriteLine("5. Remove by value")
            Console.WriteLine("0. Exit")
            Console.Write("Please input the operator (1, 2, 3, 4, 5) or 0 to exit: ")
            Select Case Console.ReadLine()
                Case "1"
                    Console.WriteLine("Elements in the list: ")
                    For Each number As Integer In numbers
                        Console.WriteLine(number)
                    Next
                Case "2"
                    Console.Write("Add new element to the list: ")
                    Dim NewElement As Integer = Integer.Parse(Console.ReadLine())
                    numbers.Add(NewElement)
                Case "3"
                    Console.WriteLine("Please input the index to insert at: ")
                    Dim InsertIndex As Integer = Integer.Parse(Console.ReadLine())
                    Console.WriteLine("Please input the value to insert: ")
                    Dim InsertValue As Integer = Integer.Parse(Console.ReadLine())
                    If InsertIndex >= 0 AndAlso InsertIndex <= numbers.Count Then
                        numbers.Insert(InsertIndex, InsertValue)
                    Else
                        Console.WriteLine("Index is out of range.")
                    End If
                Case "4"
                    Console.WriteLine("Please input the index to remove: ")
                    Dim RemoveIndex As Integer = Integer.Parse(Console.ReadLine())
                    If RemoveIndex >= 0 AndAlso RemoveIndex < numbers.Count Then
                        numbers.RemoveAt(RemoveIndex)
                        Console.WriteLine("Element at index " & RemoveIndex & " removed.")
                    Else
                        Console.WriteLine("Index is out of range.")
                    End If
                Case "5"
                    Console.WriteLine("Please input the value to remove: ")
                    Dim RemoveValue As Integer = Integer.Parse(Console.ReadLine())
                    If numbers.Contains(RemoveValue) Then
                        numbers.Remove(RemoveValue)
                        Console.WriteLine("Element with value " & RemoveValue & " removed.")
                    Else
                        Console.WriteLine("Value not found in the list.")
                    End If
                Case "0"
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid operation selected.")
            End Select
        Loop
    End Sub
End Module
