// the ourAnimals array will store the following: 
using System.Diagnostics.Metrics;

string animalSpecies = "";
string animalID = "";
string resTrim = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            resTrim = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            resTrim = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            resTrim = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            resTrim = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            resTrim = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + resTrim;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                // var curPet = ourAnimals[i].Length;
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine(String.Empty.PadRight(10, '-'));
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount++;
                }
            }
            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            Console.WriteLine("petCount-0: {0}", petCount);
            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;

                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();

                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }

                    }
                } while (validEntry == false);

                // get the pet's age. can be ? at initial entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        resTrim = readResult;
                        if (resTrim != "?")
                        {
                            validEntry = int.TryParse(resTrim, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }

                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount++;
                Console.WriteLine("petCount-1: {0}", petCount);
                animalID = animalSpecies.Substring(0, 1) + (petCount).ToString();

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + resTrim;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");

                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            Console.WriteLine("petCount-2: {0}", petCount);

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;
        case "3":
            // Ensure animal ages and physical descriptions are complete 

            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    bool validEntry = false;
                    Console.WriteLine(ourAnimals[i, 2]);

                    // validate ages
                    if (ourAnimals[i, 2] == "Age: ?")
                    {
                        do
                        {
                            Console.WriteLine("Enter an age for ID #: {0}", ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                resTrim = readResult.Trim();
                                validEntry = int.TryParse(resTrim, out int petAge);

                                if (validEntry)
                                {
                                    ourAnimals[i, 2] = $"Age: {resTrim}";
                                }

                            }
                        } while (validEntry == false);
                    }

                    // validate physical descriptions
                    if (ourAnimals[i, 4].Trim() == "Physical description:")
                    {
                        do
                        {
                            Console.WriteLine("Enter a physical description for ID #: {0} (size, color, gender, weight, housebroken)", ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                resTrim = readResult.Trim();
                                validEntry = resTrim != "";

                                if (validEntry)
                                {
                                    ourAnimals[i, 4] = $"Physical description: {resTrim}";
                                }

                            }
                        } while (validEntry == false);
                    }

                    // validate Personality descriptions
                    if (ourAnimals[i, 5].Trim() == "Personality:")
                    {
                        do
                        {
                            Console.WriteLine("Enter a Personality description for ID #: {0} (likes or dislikes, tricks, energy level)", ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                resTrim = readResult.Trim();
                                validEntry = resTrim != "";

                                if (validEntry)
                                {
                                    ourAnimals[i, 5] = $"Personality description: {resTrim}";
                                }

                            }
                        } while (validEntry == fals);
                    }

                    // validate nickname
                    if (ourAnimals[i, 3].Trim() == "Nickname:")
                    {
                        do
                        {
                            Console.WriteLine("Enter a nickname for ID #: {0}", ourAnimals[i, 0]);
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                resTrim = readResult.Trim();
                                validEntry = resTrim != "";

                                if (validEntry)
                                {
                                    ourAnimals[i, 3] = $"nickname: {resTrim}";
                                }

                            }
                        } while (validEntry == false);
                    }

                }
            }

            Console.WriteLine("Press the Enter key to exit from [OPTION 3].");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Ensure
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:

            break;

    }

    //// pause code execution
    //readResult = Console.ReadLine();
}
while (menuSelection != "exit");
