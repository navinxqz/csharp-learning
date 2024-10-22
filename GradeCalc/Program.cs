string studentName = "Sophia Johnson";
string[] course= {"English 101", "Algebra 101", "Biology 101", "CScience I", "Psycho 101"};

int[] courseCredit= {3, 3, 4, 4, 3};
int[] courseGrade = {4, 3, 3, 3, 4};

int TotalCreditHour = 0;
int totalGradePoints = 0;

for(int i=0; i<courseCredit.Length; i++){
    TotalCreditHour += courseCredit[i];
}
for(int i=0; i<courseGrade.Length; i++){
    totalGradePoints += courseCredit[i] * courseGrade[i];
}
//Console.WriteLine($"{totalGradePoints} {TotalCreditHour}");
decimal gradePointAvg = (decimal)totalGradePoints/TotalCreditHour;
int leadingDigit = (int) gradePointAvg;

int firstDigit = (int) (gradePointAvg * 10) % 10;
int secondDigit = (int) (gradePointAvg * 100 ) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

for(int i=0; i<course.Length; i++){
    Console.WriteLine($"{course[i]}\t\t{courseGrade[i]}\t\t{courseCredit[i]}");
}
Console.WriteLine($"\nFinal GPA: \t\t{leadingDigit}.{firstDigit}{secondDigit}");