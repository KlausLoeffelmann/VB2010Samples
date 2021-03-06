Option Strict On
Option Explicit On 

Module mdlMain

    Sub Main()
        Dim klasse1 As New ErsteKlasse(5)
        Console.WriteLine(klasse1.InString())

        Dim klasse2 As New ZweiteKlasse(5)
        Console.WriteLine(klasse2.Value10Added)

        Console.WriteLine()
        Console.WriteLine("Return dr�cken, zum Beenden")
        Console.ReadLine()
    End Sub

End Module

Class ErsteKlasse

    Protected myValue As Integer = 9

    Sub New(ByVal Value As Integer)
        myValue = Value
    End Sub

    Sub New(ByVal Value As Integer, ByVal NurZumTesten As Integer)
        myValue = Value
    End Sub

    'Eigenschaft, um den Wert ver�ndern zu k�nnen
    Property Value() As Integer

        Get
            Return myValue
        End Get

        Set(ByVal Value As Integer)
            myValue = Value
        End Set

    End Property

    'Um die Funktion als String auszudrucken
    Public Function InString() As String

        Return myValue.ToString()

    End Function

End Class

Class ZweiteKlasse
    Inherits ErsteKlasse

    Sub New(ByVal Value As Integer)
        MyBase.New(Value)
    End Sub

    ReadOnly Property Value10Added() As Integer

        Get
            Return myValue + 10
        End Get

    End Property

End Class