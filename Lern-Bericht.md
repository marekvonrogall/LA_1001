# Lern-Bericht

Marek von Rogall

## Einleitung

Ein Projekt in welchem aus einer Zahlenspanne die richtige Zahl erraten werden muss.

## Was habe ich gelernt?

Ich habe gelernt, Try-Catch anzuwenden, um ein Programm vor dem Abstürzen zu bewahren.


## Beschreibung

Die Try-Catch Funktion bewahrt ein Programm vor dem Abstürzen, indem man einen Codefetzen welchen man ausprobieren will in "Try" einfügt und den Codefetzen welchen man ausführen möchte, falls "Try" fehlschlägt, in "Catch" einfügt.
Catch bezeichnet das sanfte Auffangen des Programms, wenn dieses in einen Fehler läuft.
Dies kann u.a. bei Eingaben des Nutzers geschehen.

In folgendem Beispiel wird probiert, eine Benutzereingabe in den Integer Dateityp zu formatieren.
Durch fehlerhafte Eingaben des Benutzers kann folgender Fehler entstehen:


![fehler](https://user-images.githubusercontent.com/110893394/189858055-938da7f2-7316-4e67-b058-fa04fb68c1cd.png)


Dies ist ein korrektes Beispiel, um Try-Catch anzuwenden:


```csharp
namespace TryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe = 0;
            try
            {
                eingabe = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Eingabe war korrekt");
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe.");
            }
            Console.WriteLine(eingabe);
        }
    }
}
```

Kann die Konvertierung zum Integer Dateityp in "try" nicht ausgeführt werden, stürzt das Programm nicht ab, sondern führt den Codefetzen in "catch" aus.


## Verifikation

Bild: Zeigt ein Beispiel auf, in welchem ich keine Try-Catch-Funktion angewendet habe, und das Programm abgestürzt ist.

Code: Zeigt auf wie ich die Konvertierung der Benutzereingabe in eine Try-Catch-Funktion eingefügt habe, so dass das Programm nicht abstürzt, sondern sanft aufgefangen wird.


# Reflektion zum Arbeitsprozess

Ich habe schnell und motiviert gelernt, hätte allerdings öfters die Testfälle auszuführen sollen, um Fehler zu vermeiden und schnell zu beheben.


**VBV**: Zuerst ein umfangreichen PAP erstellen, bevor ich anfange einfach darauflos zu Programmieren.
