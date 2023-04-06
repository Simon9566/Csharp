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
Console.ForegroundColor = ConsoleColor.Black;

// Getting the difficulty and constructing main play loops based on them

string difficulty = "tmp";
var difficulties= new Dictionary<string, string>();
difficulties.Add("E", "easy");
difficulties.Add("M", "medium");
difficulties.Add("H", "hard");
difficulties.Add("S", "special");
while (difficulties.ContainsKey(difficulty) == false)
{
    difficulty = Console.ReadLine().ToUpper();
}

Random random =  new Random();

int a = 0;
int b = 0;
bool playing = true;
int guess = 0;
int points = 0;

while(playing)
    {
        a = Random.Next(100, 999);
        b = Random.Next(100, 999);
        if (difficulties[difficulty] == "easy")
        {
                Console.WriteLine($"What is {a} + {b}?");
                guess = Convert.ToInt32( Console.ReadLine() );
                if (guess == a + b)
                {
                    Console.WriteLine("You are correct");
                    points++;
                }
                else
                {
                    Console.WriteLine($"Unfortunately the correct answer was {a + b}");
                }
        }
        else if
     }

