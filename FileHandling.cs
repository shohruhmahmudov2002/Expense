using System.IO;

public class Files
{
    public static void WriteFile(string path, List<ExpenseClass> list)
    {
        using (StreamWriter streamWriter = new StreamWriter(path))
        {
            streamWriter.WriteLine(" ----------------------------------------------- ");
            streamWriter.WriteLine($"| {"Expence",-10}    | {"Amount",-10}    | {"Date",-10}    |");
            streamWriter.WriteLine(" ----------------------------------------------- ");

            foreach (var expence in list)
            {
                streamWriter.WriteLine($"| {expence.name,-10}    | {expence.amount,-10}    | {expence.time,-10}    |");
                streamWriter.WriteLine(" ----------------------------------------------- ");
            }
            
        }
    }
    //public static void ReadFile(string path, List<ExpenseClass> list)
    //{
    //    using (StreamReader sr = new StreamReader(path))
    //    {
    //        var text = sr.ReadToEnd();

    //    }
    //}

}
