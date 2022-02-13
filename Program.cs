// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;

Calculator cal = new Calculator();
Console.WriteLine($"The Sum of 7 and 4 is {cal.Substract(7, 4)}");
Console.WriteLine($"The Mul of 7 and 4 is { cal.Multiply(7, 4)}");
Console.WriteLine($"The Sub of 7 and 4 is {cal.Sum(7, 4)}");