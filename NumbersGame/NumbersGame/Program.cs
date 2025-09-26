partial class Program
{
    static void Main(string[] args)
    {
        bool spelaIgen = true;

        while (spelaIgen)
        {
            PlayGame();

            Console.WriteLine();
            Console.Write("Vill du spela igen? (ja/nej): ");
            string svar = Console.ReadLine().ToLower();

            if (svar != "ja")
            {
                spelaIgen = false;
            }
            Console.Clear();
        }

        Console.WriteLine("Tack för att du spelade!");
    }

        static void PlayGame()
        {
            Random random = new Random();

            int number = random.Next(1, 20);

            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 till 20. Kan du gissa vilket? Du får fem försök.");



            for (int i = 1; i < 6; i++) // loopar 5 gånger
            {
                int guess;

                while (true)
                {
                    Console.Write("Gissning " + i + ": ");

                    string input = Console.ReadLine();

                    if (int.TryParse(input, out guess)) // försöker convertera till en int
                    {

                        if (guess > 0 && guess < 21)
                        {
                            break; // giltig gissning → gå vidare
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt svar! Skriv ett tal mellan 1 och 20.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt svar! Skriv ett tal mellan 1 och 20.");
                    }
                }





                if (CheckGuess(guess, number))
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    return;
                }

                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }

                else
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }




            }
            Console.WriteLine();
            Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!\n");
            Console.WriteLine("Talet var " + number + "!\n"); //skriver vad talet var

        

            static bool CheckGuess(int guess, int correctNumber) //kollar om gissningen är rätt
            {
                return guess == correctNumber;
            }
        }
        

}



    
