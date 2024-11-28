using System;
using System.Collections;
using System.Text.RegularExpressions;
namespace Expenses;
class Program
{
    static void Main(string[] args)
    {
        string enter;
        bool cycle = true;
        string stop = "stop";
        string path = @"D:\C# darslar\34-dars\Expense\Expense.txt";
        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }
        ExpenseClass expenseClass = new ExpenseClass();
        List<ExpenseClass> listOfExpenses = new List<ExpenseClass>();
        do
        {
            System.Console.Write("Expense name: ");
            expenseClass.name = Console.ReadLine();
            System.Console.Write("Amount: ");
            expenseClass.amount = decimal.Parse(Console.ReadLine());
            System.Console.Write("Date: ");
            expenseClass.time = TimeOnly.Parse(Console.ReadLine());
            listOfExpenses.Add(expenseClass);
            do
            {
                
                System.Console.WriteLine("Hit enter to add expense...");
                enter = Console.ReadLine();
                if (Regex.IsMatch(enter, stop, RegexOptions.IgnoreCase))
                {
                    Files.WriteFile(path, listOfExpenses);
                    cycle = false;
                    break;
                }
                else if (!string.IsNullOrWhiteSpace(enter))
                {
                    System.Console.WriteLine("Only enter or stop commands can be accepted");
                }
            } while (!string.IsNullOrWhiteSpace(enter));
        } while (cycle);

    }
}