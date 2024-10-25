using System.Linq.Expressions;
using System.Xml;

namespace TrainingForCCC;

public static class IterateFiles {
    public static string Final = "Result";
    public static string directoryPath = "C:\\Users\\matth\\Downloads\\level1(1)\\";
    
    public static void IterateThroughFiles(string fileName, Func<List<string>,List<string>> methodToUse) {
        for (var i = 1; i <= 5; i++)
        {
            fileName = fileName.Replace("_" + (i - 1).ToString(), "_" + i.ToString());
            
            string filePath = directoryPath + fileName;
            
            var lines = File.ReadAllLines(filePath).ToList();

            var Final = methodToUse(lines);
            
            File.WriteAllLines(directoryPath + "//Output" + i + ".out", Final);
        }
    }
    
    public static void IterateThroughExample(string fileName, Func<List<string>,List<string>> methodToUse) {
        string filePath = directoryPath + fileName;

        Console.WriteLine(filePath);
        
        var lines = File.ReadAllLines(filePath).ToList();

        var Final = methodToUse(lines);
        
        File.WriteAllLines(directoryPath + "//Output//" + "Example.out", Final);
    }
    
    public static void IterateThroughFiles(string fileName, Func<string,List<string>> methodToUse) {
        for (var i = 1; i <= 5; i++)
        {
            fileName = fileName.Replace("_" + (i - 1).ToString(), "_" + i.ToString());
            
            string filePath = directoryPath + fileName;

            var Final = methodToUse(filePath);
            
            File.WriteAllLines(directoryPath+ "//Output//" + "//Output" + i + ".out", Final);
        }
    }
    
    public static void IterateThroughExample(string fileName, Func<string,List<string>> methodToUse) {
        string filePath = directoryPath + fileName;

        var Final = methodToUse(filePath);
        
        File.WriteAllLines(directoryPath + "//Output//" + "Example.out", Final);
    }
}

