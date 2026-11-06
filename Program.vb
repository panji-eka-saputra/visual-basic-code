Imports System
Imports System.Globalization
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main()
        Do
            Console.WriteLine()
            Console.WriteLine("=== Practice VB.NET ===")
            Console.WriteLine("1. Loop")
            Console.WriteLine("2. Input & Output")
            Console.WriteLine("3. Variable")
            Console.WriteLine("4. Operator")
            Console.WriteLine("5. Condition")
            Console.WriteLine("6. Array")
            Console.WriteLine("7. List")
            Console.WriteLine("8. Dictionary")
            Console.WriteLine("9. String")
            Console.WriteLine("10. Date")
            Console.WriteLine("11. Sub Function")
            Console.WriteLine("12. OOP")
            Console.WriteLine("0. Exit")
            Console.Write("Select: ")

            Select Case Console.ReadLine()
                Case "1"
                    ExampleLooping.Run()
                Case "2"
                    ExampleInputOutput.Run()
                Case "3"
                    ExampleVariable.Run()
                Case "4"
                    ExampleOperator.Run()
                Case "5"
                    ExampleCondition.Run()
                Case "6"
                    ExampleArray.Run()
                Case "7"
                    ExampleList.Run()
                Case "8"
                    ExampleDictionary.Run()
                Case "9"
                    ExampleString.Run()
                Case "10"
                    ExampleDate.Run()
                Case "11"
                    ExampleSubFunction.Run()
                Case "12"
                    OOP.Run()
                Case "0"
                    Exit Do
                Case Else
                    Console.WriteLine("Your selection is invalid.")
            End Select
        Loop
    End Sub
End Module
