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
Console.WriteLine("\"" + varTest1 + "\"");

string test1 = "Bob";
int test2 = 3;
decimal test3 = 34.4m;

Console.Write("\nHello, "
    + test1 + "! You have "
    + test2 + " messages in your inbox. The temperature is "
    + test3 + " celsius.");

Console.Write("\n");
Console.WriteLine(@"hello\world
    hello\\world");

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

Console.WriteLine($"Hello, {test1}!");

string str1 = ".NET";
string str2 = "repo";

Console.WriteLine($@"PATH = C:\user\desktop\{str1}\{str2}");

string projectName = "ACME";
string ruMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(
$@"View English output:
C:\Exercise\{projectName}\data.txt
{ruMessage}:
C:\Exercise\{projectName}\ru-RU\data.txt");

int cnt = 10;

Console.WriteLine(@"Total : " + (cnt * 3));

int value = 1;
value++;

Console.WriteLine("1st : " + value);
Console.WriteLine($"2nd : {++value}");
Console.WriteLine("3rd : " + value);
Console.WriteLine("4th : " + (++value));

int fahrenheit = 94;
decimal celsius = ((decimal)fahrenheit - 32.0m) * (5.0m / 9.0m);
int celsiusDigit1 = (int) celsius;
int celsiusDigit2 = (int) (celsius * 10) % 10;

Console.WriteLine($"Celsius : {celsiusDigit1}.{celsiusDigit2}");

int[] student1 = {93, 87, 98, 95, 100};
int[] student2 = {80, 83, 82, 88, 85};
int[] student3 = {84, 96, 73, 85, 79};
int[] student4 = {90, 92, 98, 100, 97};
int[][] students = {student1, student2, student3, student4};
int[] sum = {0, 0, 0, 0};
decimal[] avg = {0.0m, 0.0m, 0.0m, 0.0m};

Console.WriteLine("Student  Grade");

for(int i = 0; i < 4; i++)
{
    for(int i2 = 0; i2 < 5; i2++)
        sum[i] += students[i][i2];
    
    avg[i] = (decimal)sum[i] / 5.0m;
    if(avg[i] >= 90)
        Console.WriteLine($"{i}       {avg[i]} A");
    else
        Console.WriteLine($"{i}       {avg[i]} B");
}

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int gradeA = 4;
int gradeB = 3;

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gpa = (decimal) totalGradePoints / totalCreditHours;
int leadingDigit = (int) gpa;
int firstDigit = (int) (gpa * 10) % 10;
int secondDigit = (int) (gpa * 100 ) % 10;

Console.WriteLine
(
$@"Student: {studentName}

Course              Grade       Credit Hours
{course1Name}           {gradeA}           {course1Credit}
{course2Name}           {gradeB}           {course2Credit}
{course3Name}           {gradeB}           {course3Credit}
{course4Name}    {gradeB}           {course4Credit}
{course5Name}        {gradeA}           {course5Credit}

Final GPA:            {leadingDigit}.{firstDigit}{secondDigit}"
);