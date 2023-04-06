// Start of the program, get the player name, current date and clear the console to allow for the main loop

Console.WriteLine("Please enter your name");
string player_name = Console.ReadLine();
var date = DateTime.Now;
Console.Clear();

// Main menu

Console.WriteLine($"Hello {player_name}, {date} is a good time to practice your mathematical skills. Are you ready?");
Console.WriteLine();
Console.WriteLine("Select your desired difficulty level");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("E - Easy, addition only");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("M - Medium, addition and subtraction");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("H - Hard, addition subtraction and multiplication");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("S- Superb,  addition has been replaced with division, all results are to be given with 2 decimal spaces, even if those are zeroes :)");
Console.ResetColor();

// Getting the difficulty and constructing main play loops based on them

string difficulty = "tmp";
var difficulties = new Dictionary<string, string>();
difficulties.Add("E", "easy");
difficulties.Add("M", "medium");
difficulties.Add("H", "hard");
difficulties.Add("S", "special");
while (difficulties.ContainsKey(difficulty) == false)
{
    difficulty = Console.ReadLine().ToUpper();
}

int a = 0;
int b = 0;
bool playing = true;
int guess = 0;
int points = 0;

Random random = new Random();

public void Ask_continue()
{
    Console.WriteLine("If you want to stop enter \"N\"");
    string choice = Console.ReadLine().ToUpper();
    if (choice == "N")
        playing = false;
}

public void Ask_addition()
{
    Console.WriteLine($"What is {a} + {b}?");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess == a + b)
    {
        Console.WriteLine("You are correct");
        points++;
    }
    else
    {
        Console.WriteLine($"Unfortunately the correct answer was {a + b}");
    }
    Ask_continue();
}

public void Ask_subtraction()
{
    while (a < b)
    {
        a = random.Next(100, 999);
        b = random.Next(100, 999);
    }

    {
        Console.WriteLine($"What is {a} - {b}?");
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess == a - b)
        {
            Console.WriteLine("You are correct");
            points++;
        }
        else
        {
            Console.WriteLine($"Unfortunately the correct answer was {a - b}");
        }
        Ask_continue();
    }
}
while (playing)
{
    a = random.Next(100, 999);
    b = random.Next(100, 999);
    if (difficulties[difficulty] == "easy")
    {
        Ask_addition();
    }
    else if (difficulties[difficulty] == "medium")
    {
        int operation = random.Next(1, 3)
        if (operation == 1)
        {
            Ask_addition();
        }
        else
        {
            Ask_subtraction();
        }
    }
    else if (difficulties[difficulty] == "hard")
    {

    }
    else
    {

    }
}
