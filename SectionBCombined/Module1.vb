Module Module1

    Sub Main()
        'B18()
        'B19()
        'B20()
        ' B21()
        B22()

    End Sub
    Sub B22()
        Dim input As String
        Console.Write("Enter a string: ")
        input = Console.ReadLine
        Dim vowels As String() = {"a", "e", "i", "o", "u"}
        Dim vowelCount As Integer
        For Each letter In input
            If vowels.Contains(letter) Then
                vowelCount += 1
            End If
        Next
        Dim inputSplit = input.ToCharArray
        Dim RightMove As Integer = input.Length - 1
        Dim swapCount = vowelCount \ 2
        Dim leftMove = 0
        While swapCount > 0 And leftMove < inputSplit.Length
            While Not vowels.Contains(inputSplit(leftMove))
                leftMove += 1
            End While
            While Not vowels.Contains(inputSplit(RightMove))
                RightMove -= 1
            End While
            Dim temp = inputSplit(leftMove)
            inputSplit(leftMove) = inputSplit(RightMove)
            inputSplit(RightMove) = temp
            swapCount -= 1
            leftMove += 1
            RightMove -= 1
        End While
        For Each letter In inputSplit
            Console.Write(letter)
        Next
        Console.WriteLine()

    End Sub
    Sub B21()
        Dim input As Integer
        Console.Write("Enter a number: ")
        input = Console.ReadLine
        Dim n As Integer = 0
        While input <> 0
            n += 1
            Dim nString As String = n.ToString
            Dim sum As Integer = 0
            For Each number In nString
                sum += Val(number)
            Next
            If n Mod sum = 0 Then

                input -= 1
            End If


        End While
        Console.WriteLine(n)

    End Sub
    Sub B20()
        Dim numDigits As Integer
        Console.Write("Enter number of digits: ")
        numDigits = Console.ReadLine
        Dim nums As New List(Of Integer)
        Dim digCount(9) As Integer
        For i = 1 To numDigits
            Console.Write("Enter a digit: ")
            Dim dig = Console.ReadLine
            nums.Add(dig)
            digCount(dig) += 1

        Next
        Dim max = digCount.Max
        Dim maxCount As Integer
        For i = 0 To 9
            If digCount(i) = max Then
                maxCount += 1
            End If
        Next
        If maxCount = 1 Then
            Console.WriteLine(max)
        Else
            Console.WriteLine("Data was multimodal")
        End If


    End Sub
    Sub B19()
        Dim word1, word2 As String
        Console.Write("Enter word 1: ")
        word1 = Console.ReadLine
        Console.Write("Enter word 2: ")
        word2 = Console.ReadLine
        Dim word1AR = word1.ToArray
        Dim word2AR = word2.ToArray
        For i = 0 To word1AR.Length - 1
            For j = 0 To word2AR.Length - 1
                If word1AR(i) = word2AR(j) Then
                    word1AR(i) = "_"
                    word2AR(j) = "_"
                End If
            Next
        Next
        Dim count = 0
        For i = 0 To word1AR.Length - 1
            If word1AR(i) <> "_" Then
                count += 1
            End If
        Next
        If count = 0 Then
            Console.WriteLine("{0} can be made from {1}", word1, word2)
        Else
            Console.WriteLine("{0} can not be made from {1}", word1, word2)
        End If

    End Sub
    Sub B18()
        Dim repeat As Boolean = True
        While repeat
            Dim input As Integer
            Console.Write("Enter a number: ")
            input = Console.ReadLine
            Dim prime As Boolean = True
            For i = 2 To Math.Sqrt(input)
                If input Mod i = 0 Then
                    prime = False
                End If
            Next
            If input <= 1 Then
                Console.WriteLine("Not greater than 1")
            ElseIf prime Then
                Console.WriteLine("Is prime")
            Else
                Console.WriteLine("Is not prime")
            End If
            Dim again As String
            Console.Write("Would you like to enter another number? (Yes/No): ")
            again = Console.ReadLine
            again = again.ToLower
            If again = "no" Then
                repeat = False
            End If
        End While


    End Sub

End Module