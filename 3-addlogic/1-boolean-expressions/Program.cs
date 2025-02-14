static void basis_1()
{
    Console.WriteLine("a" == "a");
    Console.WriteLine("a" == "A");
    Console.WriteLine(1 == 2);

    string myValue = "a";
    Console.WriteLine(myValue == "a");
    Console.WriteLine("a" == "a ");
    string value1 = " a";
    string value2 = "A ";
    Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

    ///---- Use the inequality operator
    ///
    Console.WriteLine("a" != "a");
    Console.WriteLine("a" != "A");
    Console.WriteLine(1 != 2);

    myValue = "b";
    Console.WriteLine(myValue != "a");

    // ----- comparison ge gte le lte
    Console.WriteLine(1 > 2);
    Console.WriteLine(1 < 2);
    Console.WriteLine(1 >= 1);
    Console.WriteLine(1 <= 1);

    // methods retuirning boolean
    string pangram = "The quick brown fox jumps over the lazy dog.";
    Console.WriteLine(pangram.Contains("fox"));
    Console.WriteLine(pangram.Contains("cow"));

    // ---- conditional operator?
    // <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
    int saleAmount = 1001;
    int discount = saleAmount > 1000 ? 100 : 50;
    Console.WriteLine($"Discount: {discount}");
    Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
}

static void challenge_1()
{
    Random coin = new Random();
    var val = coin.Next(1, 2);

    Console.WriteLine($"{coin.Next(0, 2)}-{(coin.Next(0, 2) == 1 ? "heads" : "tails")}");
    Console.WriteLine($"{coin.Next(0, 2)}-{(coin.Next(0, 2) == 1 ? "heads" : "tails")}");
    Console.WriteLine($"{coin.Next(0, 2)}-{(coin.Next(0, 2) == 1 ? "heads" : "tails")}");
    Console.WriteLine($"{coin.Next(0, 2)}-{(coin.Next(0, 2) == 1 ? "heads" : "tails")}");

}
static void basis_2()
{
    //string permission = "Admin|Manager";
    string permission = "Admin";
    int level = 21;

    // option 1
    if (permission.Contains("Admin") && level > 55) { Console.WriteLine("Welcome, Super Admin user."); }
    else if (permission.Contains("Admin") && level <= 55) { Console.WriteLine("Welcome, Admin user."); }
    else if (permission.Contains("Manager") && level >= 20) { Console.WriteLine("Contact an Admin for access."); }
    else if (permission.Contains("Manager") && level < 20) { Console.WriteLine("You do not have sufficient privileges."); }
    else if (!permission.Contains("Manager")) { Console.WriteLine("You do not have sufficient privileges-2."); }

    // option 2
    if (permission.Contains("Admin"))
    {
        if (level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else
        {
            Console.WriteLine("Welcome, Admin user.");
        }
    }
    else if (permission.Contains("Manager"))
    {
        if (level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}

void basis_3()
{

    // Code sample 1
    bool flag = true;
    int value = default;

    if (flag)
    {
        value = 10;
        Console.WriteLine($"Inside the code block: {value}");
    }

    Console.WriteLine($"Outside the code block: {value}");

    // Code sample 2
    //int value;

    if (true)
    {
        value = 10;
        Console.WriteLine($"Inside the code block: {value}");
    }

    Console.WriteLine($"Outside the code block: {value}");
}


void challenge_2()
{
    int[] numbers = { 4, 8, 15, 16, 23, 42 };

    bool found = false;
    int total = 0;
    foreach (int number in numbers)
    {
        total += number;

        if (number == 42) found = true;
    }

    if (found) Console.WriteLine("Set contains 42");

    Console.WriteLine($"Total: {total}");

}

challenge_2();
