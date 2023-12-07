// See https://aka.ms/new-console-template for more information
Console.WriteLine('a'); // char
Console.WriteLine(123); // int
Console.WriteLine(5.2f); // float
Console.WriteLine(62.33); // double
Console.WriteLine(53.231m); // dec
Console.WriteLine(true); // bool

string userName = "Bill";
char userInitial = 'b';
int score = 500;
decimal rate = (score / 100.0m) + 0.00m;
bool status = true;

Console.Write("\n");
Console.WriteLine(userName);
Console.WriteLine(userInitial);
Console.WriteLine(score);
Console.WriteLine(rate);
Console.WriteLine(status);

var varTest1 = "hello";

Console.Write("\n");
Console.WriteLine(varTest1);

string test1 = "Bob";
int test2 = 3;
decimal test3 = 34.4m;

Console.Write("\nHello, "
    + test1 + "! You have "
    + test2 + " messages in your inbox. The temperature is "
    + test3 + " celsius.");