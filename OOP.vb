Module OOP
    Public Enum CustomerType
        Individual
        Corporate
    End Enum
    Public Enum GenderType
        Male
        Female
    End Enum
    Public Class Customer
        Public Property Name As String
        Public Property Birthdate As Date
        Public Property Phone As String
        Public Property Type As CustomerType
        Public Property Gender As GenderType

        Public Function GetAge() As Integer
            Dim Today As Date = Date.Today
            Dim Age As Integer = Today.Year - Birthdate.Year
            If Birthdate.Date > Today.AddYears(-Age) Then Age -= 1
            Return Age
        End Function

        Public Sub PrintInfo()
            Console.WriteLine("Name : " & Name)
            Console.WriteLine("Birthdate : " & Birthdate.ToString("dd-MM-yyyy"))
            Console.WriteLine("Age : " & GetAge() & " years")
            Console.WriteLine("Gender : " & Gender.ToString())
            Console.WriteLine("Phone : " & Phone)
            Console.WriteLine("Customer Type : " & Type.ToString())
        End Sub
    End Class

    Sub Run()
        ' Create data or object customer
        Dim c As New Customer With {
            .Name = "Panji Eka Saputra",
            .Birthdate = New Date(1998, 5, 20),
            .Phone = "081234567890",
            .Type = CustomerType.Individual,
            .Gender = GenderType.Male
        }

        Console.WriteLine("=== Customer Data ===")
        c.PrintInfo()
        'Console.WriteLine()
        'Console.WriteLine("Please enter to exit...")
        'Console.ReadLine()
    End Sub
End Module
