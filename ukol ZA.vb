Imports System
Imports System.Numerics
Imports System.Security.Cryptography

Module Program
    Sub Main()
        Dim cislo As Object
        Dim vysledek As Integer = 1

        Console.Write("Zadej ��slo")
        cislo = Console.Readline()

        If Not Isnumeric(cislo) Then
            console.writeline(" Vstup mus� b�t ��slo ")
            console.readkey()
            End
        End If
        If cislo > 10 Then
            console.writeline(" ��slo mus� b�t men�� ")
            console.readkey()
            End
        End If
        If cislo < 0 Then
            console.writeline(" minim�ln� zadan� ��slo mus� b�t 1")
            Console.ReadKey()
            End
        End If

        For i As Integer = 1 To cislo
            vysledek *= i
        Next

        console.writeline($"faktori�l zadan�ho ��sla {cislo} je {vysledek}")
    End Sub
End Module
