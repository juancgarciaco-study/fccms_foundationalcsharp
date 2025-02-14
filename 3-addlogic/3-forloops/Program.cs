// See https://aka.ms/new-console-template for more information


void basis1()
{
    Console.WriteLine("-----------------");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("-----------------");
    for (int i = 10; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("-----------------");
    for (int i = 0; i < 10; i += 3)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("-----------------");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        if (i == 7) break;
    }

    Console.WriteLine("-----------------");
    string[] names = ["Alex", "Eddie", "David", "Michael"];
    for (int i = names.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(names[i]);
    }

    Console.WriteLine("-----------------");
    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine(names[i]);
    }

    Console.WriteLine("-----------------");
    for (int i = 0; i < names.Length; i++)
        if (names[i] == "David") names[i] = "Sammy";

    foreach (var name in names) Console.WriteLine(name);
}

challenge1();

static void challenge1()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
            Console.WriteLine($"{i} - FizzBuzz");
        else if (i % 3 == 0)
            Console.WriteLine($"{i} - Fizz");
        else if (i % 5 == 0)
            Console.WriteLine($"{i} - Buzz");
        else
            Console.WriteLine(i);
    }
}