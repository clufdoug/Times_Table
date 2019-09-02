Module Module1

    Sub Main()

        Console.WriteLine("Times table help")
        Do

            Console.Write("Choose the base Number ")
            Dim base As Double
            base = Console.ReadLine()
            Console.Write(base.ToString("000") & " | ")

            Dim num1 = base * 1
            Console.Write(num1.ToString("000") & " | ")

            Dim num2 = base * 2
            Console.Write(num2.ToString("000") & " | ")

            Dim num3 = base * 3
            Console.Write(num3.ToString("000") & " | ")

            Dim num4 = base * 4
            Console.Write(num4.ToString("000") & " | ")

            Dim num5 = base * 5
            Console.Write(num5.ToString("000") & " | ")

            Dim num6 = base * 6
            Console.Write(num6.ToString("000") & " | ")

            Dim num7 = base * 7
            Console.Write(num7.ToString("000") & " | ")

            Dim num8 = base * 8
            Console.Write(num8.ToString("000") & " | ")

            Dim num9 = base * 9
            Console.Write(num9.ToString("000") & " | ")

            Dim num10 = base * 10
            Console.Write(num10.ToString("000") & " | ")

            Dim num11 = base * 11
            Console.Write(num11.ToString("000") & " | ")

            Dim num12 = base * 12
            Console.Write(num12.ToString("000") & " | ")
            Console.WriteLine("")

        Loop

    End Sub

End Module
