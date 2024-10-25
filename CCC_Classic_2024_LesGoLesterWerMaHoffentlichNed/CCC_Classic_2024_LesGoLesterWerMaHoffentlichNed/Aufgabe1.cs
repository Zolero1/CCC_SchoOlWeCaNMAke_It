namespace CCC_Classic_2024_LesGoLesterWerMaHoffentlichNed;

public static class Aufgabe1
{
    
    public static List<string> Level1(List<string> input)
    {
        string[] Val;
        List<string> desks = new List<string>();
        for (int i = 1; i<input.Count; i++)
        {
            Val = input[i].Split(" ");
            desks.Add((int.Parse(Val[0])/3*int.Parse(Val[1])).ToString());
        }

        return desks;
    }
}