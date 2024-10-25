// See https://aka.ms/new-console-template for more information

using CCC_Classic_2024_LesGoLesterWerMaHoffentlichNed;
using TrainingForCCC;
using static CCC_Classic_2024_LesGoLesterWerMaHoffentlichNed.Aufgabe1;

string filepath = "C:\\Users\\matth\\Downloads\\level1(1)\\level1_5.in";
string outputFile = "../../../solution.txt";

string[] lines = File.ReadAllLines(filepath);
List<string> ergebnisse = new List<string>();

    ergebnisse = Aufgabe1.Level1(lines.ToList());
    File.WriteAllLines(outputFile,ergebnisse);
