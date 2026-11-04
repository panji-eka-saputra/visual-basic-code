Module ExampleSubFunction
    Sub Run()
        Do
            Console.WriteLine("=== Sub Function Operations ===")
            Console.WriteLine("1. Greet (Sub + Optional parameter)")
            Console.WriteLine("2. Rectangle area (Function + Return value)")
            Console.WriteLine("3. Swap two numbers (Sub + ByRef parameters)")
            Console.WriteLine("4. ByVal vs Byref")
            Console.WriteLine("5. Check evnen or odd (Function + Return value)")
            Console.WriteLine("0. Back to main menu")

            Console.Write("Please input your options (1, 2, 3, 4, 5) or 0 to exit: ")
            Select Case Console.ReadLine()
                Case "1"
                    Console.Write("Please input your name: ")
                    Dim name As String = Console.ReadLine()
                    Console.Write("Greeting type (1. Formal, 2. Casual): ")
                    Dim greetingType As Integer = Integer.Parse(Console.ReadLine())
                    Select Case greetingType
                        Case 1
                            Greet(name, "Good Day")
                        Case 2
                            Greet(name, "Hey there")
                        Case Else
                            Greet(name, "Hello")
                    End Select
                Case "2"
                    Console.Write("Please input the length of the rectangle: ")
                    Dim length As Double = Double.Parse(Console.ReadLine())
                    Console.Write("Please input the width of the rectangle: ")
                    Dim width As Double = Double.Parse(Console.ReadLine())
                    Dim area As Double = RectangleArea(length, width)
                    Console.WriteLine($"The area of the rectangle is: {area}")
                Case "3"
                    Console.Write("Please input the first number: ")
                    Dim num1 As Integer = Integer.Parse(Console.ReadLine())
                    Console.Write("Please input the second number: ")
                    Dim num2 As Integer = Integer.Parse(Console.ReadLine())
                    SwapNumbers(num1, num2)
                    Console.WriteLine($"After swapping: {num1}, {num2}")
                Case "4"
                    Console.Write("Please input a number (ByVal): ")
                    Dim byValNum As Integer = Integer.Parse(Console.ReadLine())
                    Console.Write("Please input a number (ByRef): ")
                    Dim byRefNum As Integer = Integer.Parse(Console.ReadLine())
                    Console.WriteLine($"Before change: ByVal = {byValNum}, ByRef = {byRefNum}")
                    ChangeValues(byValNum, byRefNum)
                    Console.WriteLine($"After change: ByVal = {byValNum}, ByRef = {byRefNum}")
                Case "5"
                    Console.Write("Please input a number to check even or odd: ")
                    Dim number As Integer = Integer.Parse(Console.ReadLine())
                    If IsEven(number) Then
                        Console.WriteLine($"{number} is even.")
                    Else
                        Console.WriteLine($"{number} is odd.")
                    End If
                Case "0"
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid option. Please try again.")
            End Select
        Loop
    End Sub

    Private Sub Greet(name As String, greeting As String)
        Console.WriteLine($"{greeting}, {name}!")
    End Sub
    Private Function RectangleArea(length As Double, width As Double) As Double
        Return length * width
    End Function

    Private Sub SwapNumbers(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    Private Sub ChangeValues(ByVal byValNum As Integer, ByRef byRefNum As Integer)
        byValNum += 10
        byRefNum += 10
    End Sub

    Function IsEven(number As Integer) As Boolean
        Return number Mod 2 = 0
    End Function
End Module
