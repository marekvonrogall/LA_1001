# Lern-Bericht

Marek von Rogall

## Einleitung

Ein Projekt in welchem aus einer Zahlenspanne die richtige Zahl erraten werden muss.

## Was habe ich gelernt?

Ich habe gelernt, Try-Catch anzuwenden, um ein Programm vor dem Abstürzen zu bewahren.


## Beschreibung

Die Try-Catch Schleife bewahrt ein Programm vor dem Abstürzen, indem man einen Codefetzen welchen man ausprobieren will in "Try" einfügt und den Codefetzen welchen man ausführen möchte, falls "Try" fehlschlägt, in "Catch" einfügt.
Catch bezeichnet das sanfte Auffangen des Programms, wenn dieses in einen Fehler läuft.
Dies kann u.a. bei Eingaben des Nutzers geschehen.

In folgendem Beispiel wird probiert, eine Benutzereingabe in den Integer Dateityp zu formatieren.
Da diese Eingabe allerings ein Double ist, stürzt das Programm ab.





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



* Eine textliche Beschreibung
* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
