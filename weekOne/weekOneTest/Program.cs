using System;
using static System.Console;

namespace weekOneTest
{
    internal class Program
    {
        static List<decimal> amounts = new List<decimal>();
        static List<string> categories = new List<string>();
        static List<DateTime> dates = new List<DateTime>();
        static void Main(string[] args)
        {
      

            WriteLine("1. Add Expense");
            WriteLine("2. View Summary");
            WriteLine("3. Search Expenses");
            WriteLine("4. Exit");
            Write("Which Option would you like: ");

            switch (ReadLine())
            {
                case "1":
                    //method call passing 3 arguments
                    AddExpense();
                    break;
                case "2":
                    break;
                case "3":
                    SearchExpneses();
                    break;
                default:
                    WriteLine("Invalid option!");
                    break;
            }//ends switch
            ReadKey();


        }//ends main

        static void AddExpense()
        {
            Write("Enter amount: ");
            if (decimal.TryParse(ReadLine(), out decimal amount))
            {
                Write("Please enter category: ");
                string category = ReadLine();

                Write("Enter date yyyy-mm-dd:");
                if (DateTime.TryParse(ReadLine(), out DateTime date))
                {
                    amounts.Add(amount);
                    categories.Add(category);
                    dates.Add(date);
                    WriteLine("Expense added");
                }//end nested if
                else
                    WriteLine("Invalid date");

            }//end if
            else
                WriteLine("Invalid Amount");
        }

        static void SearchExpenses()
        {
            Write("Enter a category to search: ");
            string searchCat = ReadLine();

            WriteLine("Expenses in the Category Entered");

            foreach (var c in categories)
            {
                if (c.Equals(searchCat, StringComparison.OrdinalIgnoreCase))
                {
                    WriteLine($"Expense cat: {c}"); //string interpolation.
                    //WriteLine("Expense Cat: " + c + "!");// concatination.
                    //WriteLine("Expense Cat: {0}", c);//all do the same thing
                }
            }
        }
    }
}