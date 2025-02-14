﻿// See https://aka.ms/new-console-template for more information



void basis1()
{
    Console.WriteLine("Signed integral types:");

    Console.WriteLine($"sbyte \t\t : {sbyte.MinValue} to {sbyte.MaxValue}");
    Console.WriteLine($"short \t\t : {short.MinValue} to {short.MaxValue}");
    Console.WriteLine($"int \t\t : {int.MinValue} to {int.MaxValue}");
    Console.WriteLine($"long \t\t : {long.MinValue} to {long.MaxValue}");

    Console.WriteLine("");
    Console.WriteLine("Unsigned integral types:");

    Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
    Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
    Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
    Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

    Console.WriteLine("");
    Console.WriteLine("Floating point types:");
    Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
    Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
    Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
}
Console.WriteLine("Hello, World!");

void basis2()
{
    int[] data = new int[3];

    int val_A = 2;
    int val_B = val_A;
    val_B = 5;

    
    Console.WriteLine("--Value Types--");
    Console.WriteLine($"val_A: {val_A}");
    Console.WriteLine($"val_B: {val_B}");

    Console.WriteLine("".PadRight(10,'-'));

    int[] ref_A = [2];
    int[] ref_B = ref_A;
    ref_B[0] = 5;

    Console.WriteLine("--Reference Types--");
    Console.WriteLine($"ref_A[0]: {ref_A[0]}");
    Console.WriteLine($"ref_B[0]: {ref_B[0]}");
}

basis2();
