
int totalCoffeeCost = 0;
Start:
Console.Clear();
Console.WriteLine("Welcome to the Coffee Shop! Below you find our selections\n");
Console.WriteLine("Sizes of Coffee:\n1 - Small\n2 - Medium\n3 - Large\n\nPlease select desired coffee size");
int userChoice = int.Parse(Console.ReadLine()!);


switch(userChoice)
{
    case 1:
        totalCoffeeCost += 1;
        break;
    case 2:
        totalCoffeeCost += 2;
        break;
    case 3:
        totalCoffeeCost += 3;
        break;
    default:
        Console.WriteLine($"Your choice {userChoice} is invalid\n\nPress any key to continue...");
        Console.ReadKey();
        goto Start;
}

Decide:
Console.Clear ();
Console.WriteLine("Would you like to buy another coffee?\n - Yes\n - No");
string userContinue = Console.ReadLine()!.ToLower();

switch(userContinue)
{
    case "yes" or "y":
        goto Start;
    case "no" or "n":
        break;
    default:
        Console.WriteLine("Invalid input. Please input either 'yes' or 'no'\n\nPress any key to continue...");
        Console.ReadKey();
        goto Decide;
        
}

Console.WriteLine("\nThank you for shopping with us");
Console.WriteLine($"Your total cost is: ${totalCoffeeCost}");
Console.WriteLine("\nPlease come again!");

Console.ReadKey();
