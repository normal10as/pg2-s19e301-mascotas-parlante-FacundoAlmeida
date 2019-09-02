
Imports System.DateTime
Public Class Loro


    'constructor
    Public Sub New()
        Memoria = New Queue(Of String) 'Dar valor siempre a la propiedad y no a la variable "_memoria".
        FechaNacimiento = Date.Now()
        Nombre = " "
        Memoria.Enqueue("Hola")
    End Sub


    Private _memoria As Queue(Of String)

    Public Property Memoria As Queue(Of String)
        Get
            Return _memoria
        End Get
        Set(value As Queue(Of String))
            _memoria = value
        End Set
    End Property
    '--------------------------------------
    Private _edad As Short
    Public ReadOnly Property Edad As Short
        Get
            Return _edad
        End Get
    End Property
    '-----------------------------------------
    Private _fechanacimiento As Date
    Public Property FechaNacimiento As Date

        Get
            Return _fechanacimiento
        End Get
        Set(value As Date)
            _fechanacimiento = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Function CalcularEdad(FechaNacimiento As Date) As UShort
        Dim DiferenciaEdad As UShort
        Dim FechaActual As Date = Date.Now()
        DiferenciaEdad = (FechaActual.Year) - (FechaNacimiento.Year)
        Return DiferenciaEdad
    End Function


    Public Sub Escuchar(frase As String)
        Memoria.Enqueue(frase)
    End Sub


    Public Function Hablar() As String
        Dim frase As String
        frase = Memoria.Dequeue()
        Return frase

    End Function

    Public Function ToString() As String
        Return Nombre
    End Function




End Class

