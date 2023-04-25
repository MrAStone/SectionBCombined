Module Module1

    Sub Main()
        'B18()
        'B19()
        'B20()
        ' B21()
        B22()
        'AlternateB22()
        'StackB22()
    End Sub
    Sub B22()
        Dim input As String
        Console.Write("Enter a string: ")
        input = Console.ReadLine
        Dim vowels As String() = {"a", "e", "i", "o", "u"} ' array containing vowels
        Dim vowelCount As Integer
        For Each letter In input ' count the number of vowels in the input
            If vowels.Contains(letter) Then
                vowelCount += 1
            End If
        Next
        Dim swapCount = vowelCount \ 2 ' find out how many swaps are needed
        Dim inputSplit = input.ToCharArray ' split input into array of chars as you can't edit parts of strings
        Dim RightMove As Integer = input.Length - 1 'Last index used to find rightmost vowel
        Dim leftMove = 0 ' first index to find leftmost vowel
        While swapCount > 0  ' loop while there are still swaps to do
            While Not vowels.Contains(inputSplit(leftMove)) 'find leftmost vowel
                leftMove += 1
            End While
            While Not vowels.Contains(inputSplit(RightMove)) 'find rightmost vowel
                RightMove -= 1
            End While
            Dim temp = inputSplit(leftMove) ' swap left and right vowels
            inputSplit(leftMove) = inputSplit(RightMove)
            inputSplit(RightMove) = temp
            swapCount -= 1 ' one less swap still to do
            leftMove += 1 ' move left pointer up
            RightMove -= 1 ' move right pointer down
        End While
        For Each letter In inputSplit
            Console.Write(letter)
        Next
        Console.WriteLine()

    End Sub
    Sub AlternateB22()
        Console.Write("Please enter the word: ") 
        Dim Word() As Char = Console.ReadLine().ToCharArray() 
        Dim Vowels As String() = {"a", "e", "i", "o", "u"} 
        Dim VowelsInWord As List(Of Char) = Word.ToList().Where(AddressOf Vowels.Contains).ToList() 
        Dim NumVowels As Integer = VowelsInWord.Count 
        Dim CurrentVowelNum = 0 
        For Letter As Integer = 0 To Word.Length - 1 Step 1 
            If Vowels.Contains(Word(Letter)) Then 
                Word(Letter) = VowelsInWord(VowelsInWord.Count - 1 - CurrentVowelNum) 
                CurrentVowelNum = CurrentVowelNum + 1 
            End If 
        Next
        Console.WriteLine(Word) 
    End Sub

    Sub StackB22()
        Console.Write("Please enter the word: ")
        Dim Word() As Char = Console.ReadLine().ToCharArray()
        Dim Vowels As Char() = {"a", "e", "i", "o", "u"}
        Dim VowelStack As New Stack(Of Char)
        For x As Integer = 0 To Word.Length - 1 Step 1
            If Vowels.Contains(Word(x)) Then
                VowelStack.Push(Word(x))
            End If
        Next
        For x As Integer = 0 To Word.Length - 1 Step 1
            If Vowels.Contains(Word(x)) Then
                Word(x) = VowelStack.Pop()
            End If
        Next
        Console.WriteLine(Word)
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
