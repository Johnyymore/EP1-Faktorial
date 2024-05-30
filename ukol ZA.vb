Imports System
Imports System.Numerics
Imports System.Security.Cryptography

Module Program
    Sub Main()
        Dim cislo As Object
        Dim vysledek As Integer = 1

        Console.Write("Zadej èíslo")
        cislo = Console.Readline()

        If Not Isnumeric(cislo) Then
            console.writeline(" Vstup musí být èíslo ")
            console.readkey()
            End
        End If
        If cislo > 10 Then
            console.writeline(" èíslo musí být menší ")
            console.readkey()
            End
        End If
        If cislo < 0 Then
            console.writeline(" minimální zadané èíslo musí být 1")
            Console.ReadKey()
            End
        End If

        For i As Integer = 1 To cislo
            vysledek *= i
        Next

        console.writeline($"faktoriál zadaného èísla {cislo} je {vysledek}")
    End Sub
End Module
