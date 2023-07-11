//gather info from user and store it

Console.WriteLine("Welcome to the number analyzer");
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
//
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please choose a number from 1 to 100 including 1 and 100");
    int userInput = int.Parse(Console.ReadLine());

    //determine response

    if (userInput % 2 == 1 && userInput < 60)
    {
        Console.WriteLine(userInput + " Odd and less than 60");
    }
    else if (userInput >= 2 && userInput <= 24)
    {
        Console.WriteLine(userInput + " Even and less than 25");
    }
    else if (userInput >= 26 && userInput <= 60)
    {
        Console.WriteLine(userInput + " Even and between 26 and 60 inclusive");
    }
    else if (userInput < 60)
    {
        Console.WriteLine(userInput + " Even and greater than 60");
    }
    else
    {
        Console.WriteLine(userInput + " Odd and greater than 60");
    }

    //ask to continue
    while (true)
    {
        Console.WriteLine(userName + " Would you like to continue? y/n");
        string choice = Console.ReadLine();

        if (choice == "n")
        {
            runProgram = false;
            break;
        }
        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        if (choice != "n" && choice != "y")
        {
            Console.WriteLine("invalid response");

        }
    }
}

    
