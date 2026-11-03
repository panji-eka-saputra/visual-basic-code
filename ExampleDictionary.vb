Module ExampleDictionary
    Sub Run()
        ' Key = code product (String), Value = total stock (Integer)
        ' OrdinalIgnoreCase: "p001" and "P001" is the same key
        Dim stock As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase) From {
            {"P001", 10},
            {"P002", 25},
            {"P003", 0}
        }

        Do
            Console.WriteLine("=== Stock (Dictionary) ===")
            Console.WriteLine("1. Display all")
            Console.WriteLine("2. Add new product")
            Console.WriteLine("3. Update stock")
            Console.WriteLine("4. Find product")
            Console.WriteLine("5. Remove product")
            Console.WriteLine("6. Summary")
            Console.WriteLine("0. Back to main menu")
            Console.Write("Select: ")

            Select Case Console.ReadLine()
                Case "1"
                    ' Loop on key-value (= for k, v in d.items())
                    For Each pair In stock
                        Console.WriteLine($"  {pair.Key} : {pair.Value}")
                    Next

                Case "2"
                    Console.Write("Product code: ")
                    Dim code = Console.ReadLine().Trim()
                    If stock.ContainsKey(code) Then                ' = code in d
                        Console.WriteLine($"{code} already exists. Use 'Update stock'.")
                    Else
                        Console.Write("Quantity: ")
                        Dim qty = Integer.Parse(Console.ReadLine())
                        stock.Add(code, qty)                       ' Add: error if key exists
                        Console.WriteLine($"{code} added.")
                    End If

                Case "3"
                    Console.Write("Product code: ")
                    Dim code = Console.ReadLine().Trim()
                    If stock.ContainsKey(code) Then
                        Console.Write($"Current stock {stock(code)}. New quantity: ")
                        stock(code) = Integer.Parse(Console.ReadLine())   ' (key) = ... overwrite value
                        Console.WriteLine("Updated.")
                    Else
                        Console.WriteLine($"{code} not found.")
                    End If

                Case "4"
                    Console.Write("Product code: ")
                    Dim code = Console.ReadLine().Trim()
                    Dim qty As Integer
                    ' TryGetValue: search + get simultaneously, without error (= d.get(code))
                    If stock.TryGetValue(code, qty) Then
                        Console.WriteLine($"{code} : {qty}" & If(qty = 0, "  (OUT OF STOCK)", ""))
                    Else
                        Console.WriteLine($"{code} not found.")
                    End If

                Case "5"
                    Console.Write("Product code to remove: ")
                    Dim code = Console.ReadLine().Trim()
                    If stock.Remove(code) Then                     ' True if successfully removed, False if not found
                        Console.WriteLine($"{code} removed.")
                    Else
                        Console.WriteLine($"{code} not found.")
                    End If

                Case "6"
                    Console.WriteLine($"  Total products : {stock.Count}")
                    Console.WriteLine($"  Total stock    : {stock.Values.Sum()}")
                    Console.WriteLine($"  All codes      : {String.Join(", ", stock.Keys)}")
                    Dim empty = stock.Where(Function(p) p.Value = 0).Select(Function(p) p.Key)
                    Console.WriteLine($"  Out of stock   : {If(empty.Any(), String.Join(", ", empty), "-")}")
                    ' Order from highest stock
                    For Each pair In stock.OrderByDescending(Function(p) p.Value)
                        Console.WriteLine($"    {pair.Key,-6} {pair.Value,5}")
                    Next

                Case "0"
                    Exit Do

                Case Else
                    Console.WriteLine("Invalid selection.")
            End Select
        Loop
    End Sub
End Module
