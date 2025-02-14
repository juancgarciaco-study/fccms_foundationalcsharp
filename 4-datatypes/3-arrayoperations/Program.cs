// See https://aka.ms/new-console-template for more information

using System;

void basis1()
{
  string[] pallets = ["B14", "A11", "B12", "A13"];
  Console.WriteLine(pallets);

  Console.WriteLine("Sorted...");
  Array.Sort(pallets);
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  Console.WriteLine("");
  Console.WriteLine("Reversed...");
  Array.Reverse(pallets);
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }
}

void basis2()
{
  string[] pallets = ["B14", "A11", "B12", "A13"];
  Console.WriteLine("");

  Array.Clear(pallets, 0, 2);
  Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }
}

static void basis3()
{
  string[] pallets = ["B14", "A11", "B12", "A13"];
  Console.WriteLine("");

  Array.Clear(pallets, 0, 2);
  Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  // start again
  Console.WriteLine("");
  pallets = ["B14", "A11", "B12", "A13"];
  Console.WriteLine("".PadRight(20, '-'));
  Console.WriteLine("".PadRight(20, '-'));

  Console.WriteLine($"Before: {pallets[0]}");
  Array.Clear(pallets, 0, 2);
  Console.WriteLine($"After: {pallets[0]}");

  Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  // start again
  Console.WriteLine("");
  pallets = ["B14", "A11", "B12", "A13"];
  Console.WriteLine("".PadRight(20, '-'));
  Console.WriteLine("".PadRight(20, '-'));

  Console.WriteLine("");

  Console.WriteLine($"Before: {pallets[0]?.ToLower()}");
  Array.Clear(pallets, 0, 2);
  Console.WriteLine($"After: {pallets[0]?.ToLower()}");

  Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  // resize the array
  Console.WriteLine("");
  Array.Resize(ref pallets, 6);
  Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

  pallets[4] = "C01";
  pallets[5] = "C02";

  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }
}

void basis4()
{
  string[] pallets = ["B14", "A11", "B12", "A13"];
  Console.WriteLine("");

  Array.Clear(pallets, 0, 2);
  Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  Console.WriteLine("");
  Array.Resize(ref pallets, 6);
  Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

  pallets[4] = "C01";
  pallets[5] = "C02";

  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }

  Console.WriteLine("Resizing to 3");
  Array.Resize(ref pallets, 3);
  Console.WriteLine($"... count: {pallets.Length}");

  foreach (var pallet in pallets)
  {
    Console.WriteLine($"-- {pallet}");
  }
}

void basis5()
{
  string value = "abc123";
  char[] valueArray = value.ToCharArray();
  Console.WriteLine($"valueArray: {valueArray.Length}");
  Console.WriteLine($"valueArray: {new string(valueArray)}");

  Array.Reverse(valueArray);
  string result = new string(valueArray);
  Console.WriteLine(result);

  var result2 = String.Join(",", valueArray);
  Console.WriteLine(result2);

  string[] items = result2.Split(',');
  foreach (string item in items)
  {
    Console.WriteLine(item);
  }

}


void challenge1()
{
  string pangram = "The quick brown fox jumps over the lazy dog";

  // split by space
  string[] wordsArr = pangram.Split(' ');
  string[] wordsReversedArr = new string[wordsArr.Length];
  Console.WriteLine(pangram);

  for (int i = 0; i < wordsArr.Length; i++)
  {
    var word = wordsArr[i];

    // reverse each word.
    char[] WordReverseArr = word.ToCharArray();
    Array.Reverse(WordReverseArr);

    // get a string from word array
    var revWord = new string(WordReverseArr);
    //Console.WriteLine($"word: {word} -> {revWord}");
    wordsReversedArr[i] = revWord;
  }

  /*
  int wordIx = 0;
  foreach (string word in wordsArr)
  {
    // reverse each word.
    char[] WordReverseArr = word.ToCharArray();
    Array.Reverse(WordReverseArr);

    // get a string from word array
    var revWord = new string(WordReverseArr);
    Console.WriteLine($"word: {word} -> {revWord}");
    wordsReversedArr[wordIx++] = revWord;
  }
  */

  string result = string.Join(" ", wordsReversedArr);
  Console.WriteLine(result);

}

// challenge1();
challenge2();

void challenge2()
{
  string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
  string[] orders = orderStream.Split(',');
  // sort Array
  Array.Sort(orders);

  foreach (string order in orders)
  {
    if (order.Length == 4)
    {
      Console.WriteLine(order);
    }
    else
    {
      Console.WriteLine($"{order}\t - Error");
    }
  }

}