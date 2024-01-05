// See https://aka.ms/new-console-template for more information



/* Init */
#define RANDOM_SCORE
//#undef RANDOM_SCORE
#define CHALLENGE2_ENABLE
//#undef CHALLENGE2_ENABLE
#define CHALLENGE2_ANSWER
#undef CHALLENGE2_ANSWER

#if !CHALLENGE2_ENABLE
const int STUDENT_COUNT = 4;

Random random = new Random();



/* Student list */
string[] students =
{
    "student1",
    "student2",
    "student3",
    "student4"
};

Console.WriteLine("* Student list");
foreach (string student in students)
{
    Console.WriteLine($"Name : {student}");
}



/* Student each 5 score */
#if RANDOM_SCORE
    const int SCORE_COUNT = 5;

    decimal[] studentScores1 = new decimal[SCORE_COUNT];
    decimal[] studentScores2 = new decimal[SCORE_COUNT];
    decimal[] studentScores3 = new decimal[SCORE_COUNT];
    decimal[] studentScores4 = new decimal[SCORE_COUNT];
    decimal[][] studentScores = 
    {
        studentScores1,
        studentScores2,
        studentScores3,
        studentScores4
    };

    foreach (decimal[] studentScore in studentScores)
    {
        for (int idx = 0; idx < studentScore.Length; idx++)
        {
            studentScore[idx] = random.Next(0, 101);
        }
    }
#else // RANDOM_SCORE
    decimal[] studentScores1 = { 90, 86, 87, 98, 100 };
    decimal[] studentScores2 = { 92, 89, 81, 96, 90 };
    decimal[] studentScores3 = { 90, 85, 87, 98, 68 };
    decimal[] studentScores4 = { 90, 95, 87, 88, 96 };
    decimal[][] studentScores = 
    {
        studentScores1,
        studentScores2,
        studentScores3,
        studentScores4
    };
#endif // RANDOM_SCORE

Console.WriteLine();
Console.WriteLine("* Student each score");
foreach (decimal[] studentScore in studentScores)
{
    Console.Write("Score : ");
    foreach (decimal score in studentScore)
    {
        Console.Write($"{score} ");
    }
    Console.WriteLine();
}



/* Sum score */
double[] sumScores = new double[STUDENT_COUNT];

Console.WriteLine();
Console.WriteLine("* Student sum score");
for (int idx = 0; idx < students.Length; idx++)
{
    foreach (double score in studentScores[idx])
    {
        sumScores[idx] += score;
    }
}

foreach (double sumScore in sumScores)
{
    Console.WriteLine($"Sum : {sumScore}");
}



/* Average score */
double[] avgScores = new double[STUDENT_COUNT];
for (int idx = 0; idx < avgScores.Length; idx++)
{
    avgScores[idx] = sumScores[idx] / 5.0;
}

Console.WriteLine();
Console.WriteLine("* Student avg score");
string printAvgScore;
foreach (double avgScore in avgScores)
{
    printAvgScore = String.Format("{0:0.0}", avgScore);
    Console.WriteLine($"Avg : {printAvgScore}");
}



/* Additional score */
decimal[] additionalScores = new decimal[STUDENT_COUNT];
for (int idx = 0; idx < additionalScores.Length; idx++)
{
    additionalScores[idx] = random.Next(0, 2);
}

Console.WriteLine();
Console.WriteLine("* Student additional score");
foreach (decimal additionalScore in additionalScores)
{
    Console.WriteLine($"Additional : {additionalScore}");
}



/* Apply addtional score */
for (int idx = 0; idx < students.Length; idx++)
{
    if (additionalScores[idx] == 1)
    {
        sumScores[idx] *= 1.1;
    }
}

Console.WriteLine();
Console.WriteLine("* Apply additional score");
string printApplyScore;
foreach (decimal sumScore in sumScores)
{
    printApplyScore = String.Format("{0:0.0}", sumScore);
    Console.WriteLine($"Apply score : {printApplyScore}");
}



/* Final score */
for (int idx = 0; idx < avgScores.Length; idx++)
{
    avgScores[idx] = sumScores[idx] / 5.0;
}

Console.WriteLine();
Console.WriteLine("* Final score");
foreach (double avgScore in avgScores)
{
    printAvgScore = String.Format("{0:0.0}", avgScore);
    Console.WriteLine($"Avg : {printAvgScore}");
}



/* Check grade */
string[] grades = new string[STUDENT_COUNT];
for (int idx = 0; idx < students.Length; idx++)
{
    if (avgScores[idx] >= 97) grades[idx] = "A+";
    else if (avgScores[idx] >= 93) grades[idx] = "A";
    else if (avgScores[idx] >= 90) grades[idx] = "A-";
    else if (avgScores[idx] >= 87) grades[idx] = "B+";
    else if (avgScores[idx] >= 83) grades[idx] = "B";
    else if (avgScores[idx] >= 80) grades[idx] = "B-";
    else if (avgScores[idx] >= 77) grades[idx] = "C+";
    else if (avgScores[idx] >= 73) grades[idx] = "C";
    else if (avgScores[idx] >= 70) grades[idx] = "C-";
    else if (avgScores[idx] >= 67) grades[idx] = "D+";
    else if (avgScores[idx] >= 63) grades[idx] = "D";
    else if (avgScores[idx] >= 60) grades[idx] = "D-";
    else grades[idx] = "F";
}

Console.WriteLine();
Console.WriteLine("* Final score");
foreach (string grade in grades)
{
    Console.WriteLine($"Grade : {grade}");
}



/* Result */
Console.WriteLine();
Console.WriteLine($"Student      Grade");
for (int idx = 0; idx < students.Length; idx++)
{
    printAvgScore = String.Format("{0:0.0}", avgScores[idx]);
    Console.WriteLine($"{students[idx]}:    {printAvgScore} {grades[idx]}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();



/* Answer */
// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] _studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        _studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        _studentScores = andrewScores;

    else if (currentStudent == "Emma")
        _studentScores = emmaScores;

    else if (currentStudent == "Logan")
        _studentScores = loganScores;

    else if (currentStudent == "Becky")
        _studentScores = beckyScores;

    else if (currentStudent == "Chris")
        _studentScores = chrisScores;

    else if (currentStudent == "Eric")
        _studentScores = ericScores;

    else if (currentStudent == "Gregor")
        _studentScores = gregorScores;

    else
        continue;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in _studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();



#else // CHALLENGE2_ENABLE



/* Challenge2 - code */
#if !CHALLENGE2_ANSWER
/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\t"
    + "Exam Score\t\t"
    + "Overall Grade\t\t"
    + "Exter Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentExamScore = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    int sumExtraCredit = 0;

    decimal currentExtraCredit = 0;    

    decimal currentExtraCreditPts = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments < examAssignments)
            sumAssignmentScores += score;
        else if (gradedAssignments == examAssignments)
        {
            sumAssignmentScores += score;
            currentExamScore = (decimal)(sumAssignmentScores) / examAssignments;
        }
        else
            sumExtraCredit += score;
    }

    currentStudentGrade = (decimal)(currentExamScore) + ((decimal)(sumExtraCredit) / 10) / examAssignments;
    currentExtraCredit = (decimal)(sumExtraCredit) / (decimal)(gradedAssignments - examAssignments);
    currentExtraCreditPts = currentStudentGrade - currentExamScore;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-

    /*
    Console.WriteLine("Student\t\t"
    + "Exam Score\t\t"
    + "Overall Grade\t\t"
    + "Exter Credit\n");
    */    
    Console.WriteLine($"{currentStudent}\t\t"
        + $"{currentExamScore}\t\t"
        + $"\t{currentStudentGrade}\t{currentStudentLetterGrade}\t"
        + $"\t{currentExtraCredit}\t({currentExtraCreditPts} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();



#else // CHALLENGE2_ANSWER



/* Challenge2 - answer */
/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)

*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- calculate exam and extra credit sums (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;

    /* 
    the inner foreach loop: 
    - sums the exam and extra credit scores
    - counts the extra credit assignments
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumExamScores = sumExamScores + score;
        }

        else
        {
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }

    currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
    currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

    currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";


    // Student         Exam Score      Overall Grade   Extra Credit
    // Sophia          92.2            95.88   A       92 (3.68 pts)

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

#endif // CHALLENGE2_ANSWER
#endif // CHALLENGE2_ENABLE