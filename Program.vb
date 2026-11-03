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
                Case "0"
                    Exit Do
                Case Else
                    Console.WriteLine("Your selection is invalid.")
            End Select
        Loop
    End Sub
End Module
