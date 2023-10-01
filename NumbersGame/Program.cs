namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök. ");
            Random random = new Random();
            int randomNumber = random.Next(0, 21);

            string input = "";
            int number = 0;

            for (int i = 1; i <= 5; i++)
            {
                input = Console.ReadLine();
                number = int.Parse(input);
                Console.WriteLine($"Försök {i}: {number}");
                if (number == randomNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                else if (i != 5)
                {
                    
                    checkguess(number, randomNumber);

                }
                else
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");

                }
            }


        }



        static void checkguess(int guess, int rando)
        {

            if (guess > rando)
            {
                Console.WriteLine("Tyvärr, du gissade för högt! ");

            }


            else
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
            }


        }




    }
}