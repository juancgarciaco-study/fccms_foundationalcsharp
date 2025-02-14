// See https://aka.ms/new-console-template for more information

using static System.Net.Mime.MediaTypeNames;

void basis1()
{
    Console.WriteLine("-----------------");
    Random random = new();
    int current = 0;

    /*
    do
    {
        current = random.Next(1, 11);
        Console.WriteLine(current);
    } while (current != 7);
    */

    /*
    current = random.Next(1, 11);
    while (current >= 3)
    {
        Console.WriteLine(current);
        current = random.Next(1, 11);
    }
    Console.WriteLine($"Last number: {current}");
    */

    do
    {
        current = random.Next(1, 11);

        if (current >= 8) continue;

        Console.WriteLine(current);
    } while (current != 7);
}

void challenge1()
{
    int hero = 10;
    int monster = 10;

    Random dice = new Random();

    do
    {
        int roll = dice.Next(1, 11);
        monster -= roll;
        Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

        if (monster <= 0) continue;

        roll = dice.Next(1, 11);
        hero -= roll;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

    } while (hero > 0 && monster > 0);

    Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
}

void basis2()
{
    string? readResult;
    /*
    Console.WriteLine("Enter a string:");
    do
    {
        readResult = Console.ReadLine();
    } while (readResult == null);
    */

    /*
    bool validEntry = false;
    Console.WriteLine("Enter a string containing at least three characters:");
    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            if (readResult.Length >= 3)
            {
                validEntry = true;
            }
            else
            {
                Console.WriteLine("Your input is invalid, please try again.");
            }
        }
    } while (validEntry == false);
    */

    /*
    Console.WriteLine("Enter an int number:");
    bool validNumber = false;
    do
    {
        readResult = Console.ReadLine();

        validNumber = int.TryParse(readResult, result: out int numericValue);

        if (!validNumber) Console.WriteLine("Your input is invalid, please try again.");
        Console.WriteLine($"numericValue {numericValue}.");
    } while (!validNumber);
    */
}

challenge2();

static void challenge2()
{
    string? readResult;
    string valueEntered = "";

    /*
    Console.WriteLine("-------- 1 ---------");

    Console.WriteLine("Enter an integer value between 5 and 10:");
    bool validNumber = false;
    do
    {
        readResult = Console.ReadLine();
        if (readResult != null) valueEntered = readResult;

        validNumber = int.TryParse(readResult, result: out int numericValue);

        if (!validNumber)
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again.");
            continue;
        }

        if (!(numericValue >= 5 && numericValue <= 10))
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            validNumber = false;
            continue;
        }

        Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
    } while (!validNumber);
    */

    /*
    Console.WriteLine("-------- 2 ---------");
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    bool validRole = false;
    string[] allowedRoles = ["administrator", "manager", "user"];

    do
    {
        readResult = Console.ReadLine();

        validRole = allowedRoles.Contains(readResult?.ToLower());

        if (!validRole)
        {
            Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            continue;
        }


        Console.WriteLine($"Your input value ({readResult}) has been accepted.");
    } while (!validRole);
    */

    Console.WriteLine("-------- 3 ---------");

    string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
    int periodLocation;

    foreach (string str in myStrings)
    {
        bool extraText;
        string myString = str;

        extraText = true;
        do
        {
            periodLocation = myString.IndexOf('.');
            if (periodLocation == -1)
            {
                extraText = false;
                Console.WriteLine(myString);
                continue;
            }

            var text = myString.Substring(0, periodLocation);
            Console.WriteLine(text);
            myString = myString.Remove(0, periodLocation + 1).Trim();

        }
        while (extraText);
    }

}