﻿// See https://aka.ms/new-console-template for more information
static void Step1()
{

    // initialize variables - graded assignments 
    int currentAssignments = 5;

    int sophia1 = 90;
    int sophia2 = 86;
    int sophia3 = 87;
    int sophia4 = 98;
    int sophia5 = 100;

    int andrew1 = 92;
    int andrew2 = 89;
    int andrew3 = 81;
    int andrew4 = 96;
    int andrew5 = 90;

    int emma1 = 90;
    int emma2 = 85;
    int emma3 = 87;
    int emma4 = 98;
    int emma5 = 68;

    int logan1 = 90;
    int logan2 = 95;
    int logan3 = 87;
    int logan4 = 88;
    int logan5 = 96;

    int sophiaSum = 0;
    int andrewSum = 0;
    int emmaSum = 0;
    int loganSum = 0;

    decimal sophiaScore;
    decimal andrewScore;
    decimal emmaScore;
    decimal loganScore;

    sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
    andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
    emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
    loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

    sophiaScore = (decimal)sophiaSum / currentAssignments;
    andrewScore = (decimal)andrewSum / currentAssignments;
    emmaScore = (decimal)emmaSum / currentAssignments;
    loganScore = (decimal)loganSum / currentAssignments;

    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
    Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
    Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

    Console.WriteLine("Press the Enter key to continue");
    Console.ReadLine();

}

static void Step2()
{
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


    //---
    int[] studentScores = new int[10];

    string currentStudentLetterGrade;

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
        else if (currentStudent == "Becky")
            studentScores = beckyScores;
        else if (currentStudent == "Chris")
            studentScores = chrisScores;
        else if (currentStudent == "Eric")
            studentScores = ericScores;
        else if (currentStudent == "Gregor")
            studentScores = gregorScores;
        else
            continue;

        // initialize/reset the sum of scored assignments
        int sumAssignmentScores = 0;

        // initialize/reset the calculated average of exam + extra credit scores
        decimal currentStudentGrade = 0;

        int gradedAssignments = 0;
        foreach (int score in studentScores)
        {
            gradedAssignments++;

            if (gradedAssignments <= examAssignments)
            {
                // add the exam score to the sum
                sumAssignmentScores += score;
            }
            else
            {
                sumAssignmentScores += score / 10;
            }
        }

        currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

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

        Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

    }

    Console.WriteLine("Press the Enter key to continue");
    Console.ReadLine();

}

static void Step3()
{
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
    // Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

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

        int gradedAssignments = 0;
        int gradedExtraCreditAssignments = 0;

        int sumExamScores = 0;
        int sumExtraCreditScores = 0;

        decimal currentStudentGrade = 0;
        decimal currentStudentExamScore = 0;
        decimal currentStudentExtraCreditScore = 0;

        /* 
        the inner foreach loop sums assignment scores
        extra credit assignments are worth 10% of an exam score
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

        // Student         Grade
        // Sophia:         92.2    A-

        //Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
    }

}

Console.WriteLine("Hello, World! to Guided project...");
//Step1();
//Step2();
Step3();
Console.WriteLine(5 / 10);