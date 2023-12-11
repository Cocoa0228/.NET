// See https://aka.ms/new-console-template for more information

#define RANDOM
//#undef RANDOM
#define RANDOM2
//#undef RANDOM2

Random dice = new Random();

#if RANDOM
    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);
#else // RANDOM
    int roll1 = 4; // [1-6]
    int roll2 = 3; // [1-6]
    int roll3 = 2; // [1-6]
#endif // RANDOM

int total = roll1 + roll2 + roll3;
int bonus = 0;

if (roll1 == roll2 && roll1 == roll3)
    bonus += 6;
else
{
    if (roll1 == roll2)
        bonus += 2;
    else if (roll2 == roll3)
        bonus += 2;
    else if (roll3 == roll1)
        bonus += 2;
}

total += bonus;

Console.WriteLine("Dice 1 : " + roll1);
Console.WriteLine("Dice 2 : " + roll2);
Console.WriteLine("Dice 3 : " + roll3);
Console.WriteLine("Dice Bonus : " + bonus);
Console.WriteLine("Dice Total : " + total);

if (total >= 16)
    Console.WriteLine("Result : New car");
else if (total >= 10)
    Console.WriteLine("Result : New notebook");
else if (total == 7)
    Console.WriteLine("Result : trip tickets");
else
    Console.WriteLine("Result : cat");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



Random random = new Random();

#if RANDOM2
    int daysUntilExpiration = random.Next(12);
#else // RANDOM2
    int daysUntilExpiration = 10; // [0-11]
#endif // RANDOM2

int discountPercentage = 0;
string message = "";
bool output = true;

if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
{
    message = "Your subscription will expire soon. Renew now!";
}
else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
{
    discountPercentage = 10;
    message =
        $"Your subscription expires in {daysUntilExpiration} days.\n"
        + $"Renew now and save {discountPercentage}%!";
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    message =
        $"Your subscription expires within a day!\n"
        + $"Renew now and save {discountPercentage}%!";
}
else if (daysUntilExpiration == 0)
{
    message = "Your subscription has expired.";
}
else
{
    output = false;
}

Console.WriteLine("Date : " + daysUntilExpiration);
Console.WriteLine($"Discount : {discountPercentage}%");

if (output)
    Console.WriteLine(message);
else
    Console.WriteLine("(No message.)");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



