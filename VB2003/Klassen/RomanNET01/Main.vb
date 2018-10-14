Option Strict On
Option Explicit On 

Public Class Main

    Shared Sub Main()

        Dim locRomanNumeral As New RomanNumerals

        'Text ausgeben; Anwender zur Eingabe auffordern
        Console.Write("Geben Sie eine Zahl zwischen 1 und 3.999 ein: ")

        'Zahl als Text einlesen, mit der statischen Methode Parse in Integer
        'umwandeln und das Ergebnis der Klasseninstanz zuweisen
        locRomanNumeral.FromInt(Integer.Parse(Console.ReadLine()))

        'Das r�mische Literale ausgeben, das in der Klasseninstanz gespeichert ist
        Console.WriteLine("Entspricht dem r�mischen Numerale " & locRomanNumeral.ToRomanNumeral)

        'Dies nur noch, damit nicht alles sofort wieder verschwindet
        Console.WriteLine()
        Console.WriteLine("Return dr�cken zum Beenden...")
        Console.ReadLine()

    End Sub

End Class