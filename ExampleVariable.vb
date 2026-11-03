Imports System.Globalization

Module ExampleVariable
    Sub Run()
        Console.Write("Please Input your name:")
        Dim name As String = Console.ReadLine()
        Console.Write("Please Input your age:")
        Dim age As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Please Input your height:")
        Dim height As Double = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
        Console.Write("Please Input your weight:")
        Dim weight As Decimal = Decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
        Console.Write("Please Input your character:")
        Dim character As Char = Char.Parse(Console.ReadLine())
        Console.Write("Please Input if you are active: (y/n)")
        Dim active As Boolean = Console.ReadLine().Trim().ToLower() = "y"
        Dim city = "Batam"
        Const MaxSector As Integer = 10
        Dim currentDate As Date = Date.Now
        Dim currentTime As TimeSpan = TimeSpan.Parse("12:30:00")
        Dim empty As String = Nothing

        Console.WriteLine("====Details Members====")
        Console.WriteLine("Name: " & name)
        Console.WriteLine("Age: " & age)
        Console.WriteLine("Height: " & height)
        Console.WriteLine("Weight: " & weight)
        Console.WriteLine("Character: " & character)
        Console.WriteLine("Active: " & active)
        Console.WriteLine("City: " & city)
        Console.WriteLine("Max Sector: " & MaxSector)
        Console.WriteLine("Current Date: " & currentDate.ToString("dd/MM/yyyy HH:mm"))
        Console.WriteLine("Current Time: " & currentTime.ToString())
        Console.WriteLine("Empty: " & If(empty Is Nothing, "N/A", empty))

    End Sub

End Module
