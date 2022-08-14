using System.IO;
using System.Collections.Generic;

public class Reader
{
    static void Main()
    {
        File.WriteAllText(@"SampleOutput.txt", string.Empty);
        var InputTable = new Dictionary<string, string>();
        var OutputTable = new Dictionary<string, string>();
        Console.Write("Введите размер премии: ");
        int premium = int.Parse(Console.ReadLine());
        foreach (string line in File.ReadLines(@"D:\\SampleInput.txt"))
        {
            string[] subs = line.Split('\t');
            InputTable.Add(subs[0], subs[1]);
        }
        /* foreach (var person in InputTable)
         {
             Console.WriteLine($"{person.Key} {person.Value}");
         }*/
        foreach (var person in InputTable)
        {
            double Salary = double.Parse(person.Value);
            Salary = Math.Round(Salary + (Salary * premium / 100), 2);
            OutputTable.Add(person.Key, string.Format("{0}", Salary));
        }
        foreach (var person in OutputTable)
        {
            Writer.FileWrtr($"{person.Key}\t{person.Value}");
        }
        Console.WriteLine("Done!");
        Console.ReadLine();
    }
}
public class Writer
{
    public static async Task FileWrtr(string str)
    {
        using StreamWriter file = new("SampleOutput.txt", append: true);
        await file.WriteLineAsync(str);
    }
}

