

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //_2_exercise_array_basics_1();
            //_2_exercise_array_basics_2();
            //_3_exercise_foreach();
            _4_challenge();
        }

        private static void _4_challenge()
        {
            string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
            foreach (string s in orderIDs) { 
                if (s.StartsWith('B'))
                    Console.WriteLine(s);
            }
        }

        private static void _3_exercise_foreach()
        {
            string[] names = { "Rowena", "Robin", "Bao" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }

        static void _2_exercise_array_basics_1()
        {
            Console.WriteLine("_2_exercise_array_basics_1!");
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            //fraudulentOrderIDs[3] = "D000";
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
        }
        static void _2_exercise_array_basics_2()
        {
            Console.WriteLine("_2_exercise_array_basics_2!");

            string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        }
    }
}
