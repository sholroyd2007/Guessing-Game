string name = GetName();
int guesses = 1;
int number = GetNumber();

CheckNumber();

void CheckNumber()
{
    Console.WriteLine($"Enter Your Guess {name.ToUpper()}. Please choose a number between 1 and 20.");
    var guess = Console.ReadLine();
    ConfirmCheck(guess);
}

void ConfirmCheck(string guess)
{
    if (string.IsNullOrWhiteSpace(guess))
    {
        Console.WriteLine("You Did Not Enter A Value!");
        Console.WriteLine("Press Enter To Try Again");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Enter Your Next Guess {name.ToUpper()}");
        var newGuess = Console.ReadLine();
        ConfirmCheck(newGuess);
    }
    int guessInt;
    bool canConvert = int.TryParse(guess, out guessInt);
    if (canConvert)
    {
        if (int.Parse(guess) == number)
        {
            Console.WriteLine("You Are Correct. Well Guessed!");
            Console.WriteLine("\n");
            Console.WriteLine($"You took {guesses} guesses to get this correct!");
            Environment.Exit(0);
        }
        else
        {
            guesses++;
            Console.WriteLine("You Are Incorrect!");
            Console.WriteLine("Press Enter To Try Again");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Enter Your Next Guess {name.ToUpper()}");
            var newGuess = Console.ReadLine();
            ConfirmCheck(newGuess);
        }
    }
    else
    {
        Console.WriteLine("Incorrect Input!");
        Console.WriteLine("Press Enter To Try Again");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Enter Your Next Guess {name.ToUpper()}");
        var newGuess = Console.ReadLine();
        ConfirmCheck(newGuess);
    }
    
    
}

int GetNumber()
{
    var random = new Random();
    var randomNumber = random.Next(1,20);
    return randomNumber;
}

string GetName()
{
    Console.WriteLine("Please Enter Your Name");
    var name = Console.ReadLine();
    return name;
}