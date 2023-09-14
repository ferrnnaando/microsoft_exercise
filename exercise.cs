decimal[] sophiaGrades = { 93.0m, 87.0m, 98.0m, 95.0m, 100.0m };
decimal[] nicolasGrades = { 80.0m, 83.0m, 82.0m, 88.0m, 85.0m };
decimal[] zahirahGrades = { 84.0m, 96.0m, 73.0m, 85.0m, 79.0m };
decimal[] jeongGrades = { 90.0m, 92.0m, 98.0m, 100.0m, 97.0m };

decimal sophiaTotal = sophiaGrades[0] + sophiaGrades[1] + sophiaGrades[2] + sophiaGrades[3] + sophiaGrades[4];
decimal nicolasTotal = nicolasGrades[0] + nicolasGrades[1] + nicolasGrades[2] + nicolasGrades[3] + nicolasGrades[4];
decimal zahirahTotal = zahirahGrades[0] + zahirahGrades[1] + zahirahGrades[2] + zahirahGrades[3] + zahirahGrades[4];
decimal jeongTotal =  jeongGrades[0] + jeongGrades[1] + jeongGrades[2] + jeongGrades[3] + jeongGrades[4];

decimal sophiaMedium = (decimal)sophiaTotal / sophiaGrades.Length;
decimal nicolasMedium = (decimal)nicolasTotal / nicolasGrades.Length;
decimal zahirahMedium = (decimal)sophiaTotal / zahirahGrades.Length;
decimal jeongMedium = (decimal)sophiaTotal / sophiaGrades.Length;

Console.WriteLine("Student\t\tGrade\t\tResult\n");

char passedStatus = 'F';
string passedAddition;

if(sophiaMedium >= 5) {
    passedAddition = "(Enough)";
    passedStatus = "A (Enough)";
    Console.WriteLine($"Sophia\t\t{sophiaMedium}\t\t\t{passedStatus}");
    //its bad doing $ if not using it ? (like memory waste)
} else if(sophiaMedium >= )
