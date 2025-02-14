// See https://aka.ms/new-console-template for more information
using System;

// basis1();

void basis1()
{
  string first = "Hello";
  string second = "World";
  string result = string.Format("{0} {1}!", first, second);
  Console.WriteLine(result);

  Console.WriteLine("".PadRight(20, '-'));
  Console.WriteLine("{1} {0}!", first, second);
  Console.WriteLine("{0} {0} {0}!", first, second);

  Console.WriteLine("".PadRight(20, '-'));
  Console.WriteLine($"{first} {second}!");
  Console.WriteLine($"{second} {first}!");
  Console.WriteLine($"{first} {first} {first}!");
}

// basis2();

void basis2()
{
  decimal price = 123.45m;
  int discount = 50;
  Console.WriteLine($"Price: {price} (Save {discount})");
  Console.WriteLine($"Price: {price:C} (Save {discount:C})");
  Console.WriteLine($"Price: {price:C3} (Save {discount:C3})");

  decimal measurement = 123456.78912m;
  Console.WriteLine($"Measurement: {measurement:N} units");
  Console.WriteLine($"Measurement: {measurement:N4} units");

  decimal tax = .36785369m;
  Console.WriteLine($"Tax rate: {tax:P2}");

  decimal price2 = 67.5585m;
  decimal salePrice2 = 59.9955m;

  string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice2), price2);

  yourDiscount += $"A discount of {((price2 - salePrice2) / price2):P2}!"; //inserted
  Console.WriteLine(yourDiscount);

}

// basis3();

void basis3()
{
  int invoiceNumber = 1201;
  decimal productShares = 25.4568m;
  decimal subtotal = 2750.00m;
  decimal taxPercentage = .15825m;
  decimal total = 3185.19m;

  Console.WriteLine($"Invoice Number: {invoiceNumber}");
  Console.WriteLine($"    Shares: {productShares:N3}");
  Console.WriteLine($"      Sub Total: {subtotal:C}");
  Console.WriteLine($"        Tax: {taxPercentage:P2}");
  Console.WriteLine($"      Total Billed: {total:C}");
}

// basis4();

void basis4()
{
  string first = "Hello";
  string second = "World";
  string result = string.Format("{0} {1}!", first, second);
  Console.WriteLine(result);
  string input = "Pad this";
  Console.WriteLine(input.PadLeft(12) + ".");
  Console.WriteLine(input.PadRight(12) + ".");
  Console.WriteLine(input.PadLeft(12, '-'));
  Console.WriteLine(input.PadRight(12, '-'));

  string paymentId = "769C";
  string payeeName = "Mr. Stephen Ortega";
  string paymentAmount = "$5,000.00";

  var formattedLine = paymentId.PadRight(6);
  formattedLine += payeeName.PadRight(24);
  formattedLine += paymentAmount.PadLeft(10);

  Console.WriteLine("1234567890123456789012345678901234567890");
  Console.WriteLine(formattedLine);
}

challenge1();


void challenge1()
{
  /*
  Dear Ms. Barros,
  As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

  Currently, you own 2,975,000.00 shares at a return of 12.75%.

  Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

  Here's a quick comparison:

  Magic Yield         12.75%   $55,000,000.00      
  Glorious Future     13.13%   $63,000,000.00
  */
  string customerName = "Ms. Barros";

  string currentProduct = "Magic Yield";
  int currentShares = 2975000;
  decimal currentReturn = 0.1275m;
  decimal currentProfit = 55000000.0m;

  string newProduct = "Glorious Future";
  decimal newReturn = 0.13125m;
  decimal newProfit = 63000000.0m;

  // Your logic here

  string comparisonMessage = $"Dear {customerName},";

  comparisonMessage += "As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.";
  comparisonMessage += "\r\n\r\n";
  comparisonMessage += $"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.";
  comparisonMessage += "\r\n\r\n";
  comparisonMessage += $"Our new product, Glorious Future offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.";
  comparisonMessage += "\r\n\r\n";
  comparisonMessage += "Here's a quick comparison:";
  comparisonMessage += "\r\n\r\n";
  comparisonMessage += $"{currentProduct,-20}         {string.Format("{0:P}", currentReturn),-10}   {string.Format("{0:C}", currentProfit),-20}";
  comparisonMessage += "\r\n";
  comparisonMessage += $"{newProduct,-20}         {string.Format("{0:P}", newReturn),-10}   {string.Format("{0:C}", newProfit),-20}";
  // Your logic here

  Console.WriteLine(comparisonMessage);
}