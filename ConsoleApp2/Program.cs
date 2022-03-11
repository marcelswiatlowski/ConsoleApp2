    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 0;
            int max = 10;
            int guess; ;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);
            
                while (guess != number)
                {
                    Console.WriteLine("Zgadnij liczbe między" + min + " - " + max + "");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess:" + guess);

                    if(guess > number)
                    {
                    Console.WriteLine(guess + " jest za wysoka!");                    
                    }
                    else if( guess < number)
                    {
                    Console.WriteLine(guess + " jest za niska!");
                    }
                    guesses++;
                }
                Console.WriteLine("Numer:" + number);
                Console.WriteLine("Wygrałeś!");
                Console.WriteLine("Twoje domysły: " + guesses);
                Console.WriteLine("Chciałbyś zagrać jeszcze raz (T/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();
                
                if(response == "T")
                {
                     playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Dzięki za grę!");

            Console.ReadKey();
        }

    }

