using System;

class Program
{
    static void Main()
    {
        // Be användaren mata in tre tal på en rad
        Console.Write("Ange tre tal (mellan 1 och 100, separerade med mellanslag): ");
        string writtenNumbers = Console.ReadLine()!;

        // Dela upp input-strängen till tre separata strängar
        string[] inputNumbers = writtenNumbers.Split(new[] { ' ', ',' });

        // Kontrollera att exakt tre tal har angetts
        if (inputNumbers.Length != 3)
        {
            Console.WriteLine("Ogiltig inmatning! Ange exakt tre tal.");
            return; // Avsluta programmet om inmatningen är ogiltig
        }

        // Skapa variabler för de tre talen
        int x = 0, y = 0, n = 0;

        // Använd en loop för att göra om string till int och se om det är heltal mellan 1 -100
        for (int i = 0; i < 3; i++)
        {
            if (!int.TryParse(inputNumbers[i], out int num) || num < 1 || num > 100)
            {
                Console.WriteLine("Ogiltigt tal! Ange endast heltal mellan 1 och 100.");
                return; // Avsluta programmet om talen är ogiltiga
            }

            // Spara det konverterade talet i rätt variabel
            if (i == 0) x = num;
            else if (i == 1) y = num;
            else n = num;
        }

        // Hitta det största talet för att bestämma sluttalet
        int maxNumber = Math.Max(x, Math.Max(y, n));

        // Loopa från 1 till det största talet och skriv ut FizzBuzz
        for (int i = 1; i <= maxNumber; i++)
        {
            string output = "";

            // Kolla delbarhet och bygg upp output-strängen
            if (i % x == 0) output += "Fizz";
            if (i % y == 0) output += "Buzz";

            // Om output fortfarande är tom, skriv ut talet självt
            if (output == "")
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}