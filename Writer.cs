using System;
public class Writer
{
    public static async Task FileWrtr(string str)
    {
        

        using StreamWriter file = new("D:\\SampleOutput.txt", append: true);
        await file.WriteLineAsync(str);
    }

  

    
}

