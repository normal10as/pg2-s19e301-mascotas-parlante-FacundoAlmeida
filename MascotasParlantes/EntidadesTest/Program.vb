Imports System
Imports Entidades
Module Program
    Sub Main(args As String())
        Dim test As New Loro()
        Dim frase As String
        test.Memoria = "Hola"
        test.FechaNacimiento = #03-03-2000#
        Console.WriteLine("Edad: " & test.Edad)
        Console.WriteLine("Memoria: " & test.Memoria)
        Console.WriteLine("Fecha nacimiento: " & test.FechaNacimiento)
        test.Memoria = Console.ReadLine()
        frase = Console.ReadLine()
    End Sub
End Module
