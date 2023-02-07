// Make a List with the following grades: 6.5, 9.5, 5, 4, 4.5, 10, 7.1. Loop through them, 
// and for grades lower than 5.5, ask the user if they want to retake this course (y/n). If they answer anything other than y or n (disregarding uppercase or lowercase), 
// keep repeating the question.

// Any course the user wishes to retake is increased by 1. Print the final list of grades.

// For example:

// Grade: 6.5
// Grade: 9.5
// Grade: 4
// Retake this course? y/n
// y
// Grade: 5
// Retake this course? y/n
// n
// Grade: 4.5
// Retake this course? y/n
// y
// Grade: 10
// Grade: 7.1
// Final grades:
// 6.5
// 9.5
// 5
// 5
// 5.5
// 10
// 7.1
#nullable disable

List<double> grades = new List<double>(){6.5, 9.5, 5, 4, 4.5, 10, 7.1};

for (int i = 0; i < grades.Count; i++)
{   
    System.Console.WriteLine(grades[i]);
    if (grades[i] < 5.5)
    {   
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            grades[i]++;
            System.Console.WriteLine(grades[i]);
        }
    }
}
/dfdsfdss
