// See https://aka.ms/new-console-template for more information

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);