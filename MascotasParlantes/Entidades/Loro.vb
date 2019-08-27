Public Class Loro
    Private _memoria As String
    Public Property Memoria As String
        Get
            Return _memoria
        End Get
        Set(value As String)
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

    Private Function Escuchar(frase As String) As String

        ''inc.
    End Function

End Class

