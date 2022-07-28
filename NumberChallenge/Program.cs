// See https://aka.ms/new-console-template for more information

int theNumber = new Random().Next(20);
Console.WriteLine("Lets Play 'Guess the Number'!");
Console.WriteLine("I'm thinking of a number between 0 and 20.");
Console.WriteLine("Enter your guess, or -1 to give up");
Console.WriteLine("What's your guess?");
bool test = true;
string userInput = Console.ReadLine();
int userGuess;
bool number = Int32.TryParse(userInput, out userGuess);
int counter = 0;

while (test == true)
{
    //Confirm that the user is entering a number!
    if (number)
    {

    }
    else
    {
        Console.WriteLine("Please enter a number");
        userInput = Console.ReadLine();
        number = Int32.TryParse(userInput, out userGuess);
        counter++;
        continue;
    }
   //When the user enters -1 this means that they've had enough and they want out
    if (userGuess == -1)
    {
        Console.WriteLine("Good Bye!");
        break;

    }
    else if (userGuess > theNumber)
    {
        Console.WriteLine("The correct number is lower.");
        Console.WriteLine("What's Your Guess?.");
        userInput = Console.ReadLine();
        number = Int32.TryParse(userInput, out userGuess);
        counter++; 
        continue;
    }
    else if (userGuess < theNumber)
    {
        Console.WriteLine("The number is higher. Please try again.");
        Console.WriteLine("What's Your Guess?");
        userInput = Console.ReadLine();
        number = Int32.TryParse(userInput, out userGuess);
        counter++;
        continue;

    }
    else
    {
        Console.WriteLine("Great job of selecting the number!");
    counter++;
    Console.WriteLine($"You got it right in {counter} tries.");
        break;
    }
        
    
}










