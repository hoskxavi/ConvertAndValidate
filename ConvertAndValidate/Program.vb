'Xavier Hoskins
'RCET 0265
'Fall 2022
'ConvertAndValidate
'https://github.com/hoskxavi/ConvertAndValidate

Imports System

Module Program
    Sub Main()

        'for testing the function add this to your Sub Main()
        Dim usernResponse As String
        Dim aValidNumber As Integer

        Do

            Console.WriteLine($"Enter a number:")

            usernResponse = Console.ReadLine()

            If ConversionValid(usernResponse, aValidNumber) = True Then

                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")

            End If

        Loop

    End Sub

    Function ConversionValid(convertThisString, ByRef toThisInteger) As Boolean

        Dim status As Boolean
        Dim userString

        Try
            userString = CInt(convertThisString)
            toThisInteger = userString
            status = True
        Catch ex As Exception
            status = False
        End Try

        Return status

    End Function
End Module
