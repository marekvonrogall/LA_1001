using System;


namespace LA1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Spielen = Convert.ToInt32(1);
            while (Spielen == 1)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine("                                            Erraten Sie die Zahl - Spiel                                                ");
                Console.WriteLine("                                                                                                                        ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.WriteLine("Wählen Sie die Zahlenspanne zum raten.");
                Console.WriteLine("");
                Console.Write("Zahl 1: ");
                Console.ForegroundColor = ConsoleColor.Red;
                int X;
                int Zahl1 = 0;
                int Zahl2 = 0;
                bool check = false;
                while (check == false)
                {
                    try
                    {
                        Zahl1 = Convert.ToInt32(Console.ReadLine());
                        check = true;
                    }
                    catch
                    {
                        Console.WriteLine("Dies ist keine gültige Zahl. Bitte geben Sie eine gültige Zahl ein.");
                        check = false;
                    }
                }
                check = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Zahl 2: ");
                Console.ForegroundColor = ConsoleColor.Red;
                while (check == false)
                {
                    try
                    {
                        Zahl2 = Convert.ToInt32(Console.ReadLine());
                        check = true;
                    }
                    catch
                    {
                        Console.WriteLine("Dies ist keine gültige Zahl. Bitte geben Sie eine gültige Zahl ein.");
                        check = false;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (Zahl1 > Zahl2)
                {
                    int Zwischenspeicher = Convert.ToInt32(Zahl1);
                    Zahl1 = Zahl2;
                    Zahl2 = Zwischenspeicher;
                }
                Random rnd = new Random();
                int Zahl = rnd.Next(Zahl1, Zahl2);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine("                                            Erraten Sie die Zahl - Spiel                                                ");
                Console.WriteLine("                                                                                                                        ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.WriteLine("Eine zufällige Zahl zwischen " + Zahl1 + " und " + Zahl2 + " wurde generiert.");
                Console.WriteLine("");
                int Versuche = Convert.ToInt32(0);
                int Eingabe = Convert.ToInt32(0);
                string kleineEingaben = "";
                string grosseEingaben = "";
                string GK = "";
                int oftgross = 0;
                int oftklein = 0;
                while (Zahl != Eingabe)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                                                                                                                        ");
                    Console.WriteLine("                                            Erraten Sie die Zahl - Spiel                                                ");
                    Console.WriteLine("                                                                                                                        ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    if (Versuche != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Die eingegebene Zahl ist ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(GK);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("als die gesuchte Zahl.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Eingaben welche grösser als die gesuchte Zahl waren: " + grosseEingaben);
                        Console.WriteLine("Eingaben welche kleiner als die gesuchte Zahl waren: " + kleineEingaben);
                        Console.WriteLine("");
                    }
                    Console.Write("Denken Sie sich eine Zahl zwischen " + Zahl1 + " und " + Zahl2 + " aus: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    string Cheatv = Console.ReadLine();
                    if (Cheatv.EndsWith("h"))
                    {
                        int Y;
                        string Cheatkontrolle = Cheatv.Remove(Cheatv.Length - 1);
                        while (!Int32.TryParse(Cheatkontrolle, out Y))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(Cheatkontrolle + " ist keine gültige Zahl. Bitte geben Sie eine gültige Zahl ein.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Denken Sie sich eine Zahl zwischen " + Zahl1 + " und " + Zahl2 + " aus: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Cheatkontrolle = Console.ReadLine();
                        }
                        int Cheat = Convert.ToInt32(Cheatkontrolle);
                        {
                            Console.Write("Cheat angewendet.");
                            Versuche++;
                            Console.Clear();
                            break;
                        }
                    }
                    else
                    {
                        int Y;
                        while (!Int32.TryParse(Cheatv, out Y))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(Cheatv + " ist keine gültige Zahl. Bitte geben Sie eine gültige Zahl ein.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Denken Sie sich eine Zahl zwischen " + Zahl1 + " und " + Zahl2 + " aus: ");
                            Console.ForegroundColor = ConsoleColor.Red;

                            Cheatv = Console.ReadLine();
                        }
                    }
                    Eingabe = Convert.ToInt32(Cheatv);
                    Console.ForegroundColor = ConsoleColor.White;
                    Versuche = Versuche + 1;
                    Console.WriteLine("");
                    if (Eingabe > Zahl)
                    {
                        if (oftgross == 0)
                        {
                            oftgross++;
                            grosseEingaben = Convert.ToString(Eingabe);
                            GK = "grösser ";
                        }
                        else
                        {
                            grosseEingaben = grosseEingaben + ", " + Eingabe;
                            GK = "grösser ";
                        }
                    }
                    if (Eingabe < Zahl)
                    {
                        if (oftklein == 0)
                        {
                            oftklein++;
                            kleineEingaben = Convert.ToString(Eingabe);
                            GK = "kleiner ";
                        }
                        else
                        {
                            kleineEingaben = kleineEingaben + ", " + Eingabe;
                            GK = "kleiner ";
                        }
                    }
                }
                bool FirstTry = false;

                if (Versuche == 1)
                {
                    FirstTry = true;
                }
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine("                                            Erraten Sie die Zahl - Spiel                                                ");
                Console.WriteLine("                                                                                                                        ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.WriteLine("Herzlichen Glückwunsch! Sie haben die gesuchte Zahl erraten.");
                Console.WriteLine("Die gesuchte Zahl war: " + Zahl);
                Console.WriteLine("");
                Console.WriteLine("Benötigte Versuche: " + Versuche);
                Console.WriteLine("");
                if (FirstTry == true)
                {
                    Console.WriteLine("Beeindruckend! Sie haben nur einen Versuch gebraucht die Zahl zu erraten!");
                }
                else
                {
                    Console.WriteLine("Ihre (falschen) Versuche die gesuchte Zahl zu erraten waren: " + kleineEingaben + ", " + grosseEingaben);
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Wollen Sie erneut spielen? [y/n] ");                                     
                Console.ForegroundColor = ConsoleColor.Red;                                             
                string Erneut = Console.ReadLine();                                                                                   
                if (Erneut == "y")                                                                      
                {                                                                                       
                    Spielen = Convert.ToInt32(1);                                                       
                }                                                                                       
                if (Erneut == "n")                                                                      
                {                                                                                       
                    Spielen = Convert.ToInt32(0);
                    Environment.ExitCode = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}