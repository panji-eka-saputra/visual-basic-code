Module ExampleInputOutput
    Sub Run()
        Console.Write("Please Input your name:")
        Dim name As String = Console.ReadLine()
        If String.IsNullOrWhiteSpace(name) Then
            Console.WriteLine("Name cannot be empty")
        Else
            Console.WriteLine("Hello, " & name)
        End If
    End Sub
End Module
