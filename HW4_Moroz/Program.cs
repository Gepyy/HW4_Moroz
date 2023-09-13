using HW4_Moroz;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public static int GetCheckedAge(string s, string text)
    {
        Console.WriteLine(text);
        s = Console.ReadLine();
        if (int.TryParse(s, out int result))
        {
            return result;
        }
        else
        {
            return 0;
        }
    }
    public static string GetCheckedName(string s, string text)
    {
        Console.WriteLine(text);
        s  = Console.ReadLine();
        if(!String.IsNullOrEmpty(s) && Regex.IsMatch(s, @"^[a-zA-Z'-]+$"))
        {
            return s;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect data :(");
            Console.ForegroundColor = ConsoleColor.Gray;
            return "Error type";
        }
    }
    public static Gender GetCheckedGender(string s, string text)
    {
        Console.WriteLine(text);
        s = Console.ReadLine().ToUpper();
        switch(s)
        {
            case "M":
                return Gender.male;
            case "F":
                return Gender.female;
            default:
                Console.WriteLine("Inccorect Gender!");
                return Gender.none;
        }
    }
    public static void Main(string[] args)
    {
        string checker = string.Empty;
        User user1 = new User(GetCheckedAge(checker, "Input Age:"));
        user1.Gender = Gender.mechanic;
        user1.Gender = GetCheckedGender(checker, "Input Gender(M/F):");
        user1.FirstName = GetCheckedName(checker, "Input FirstName:");
        user1.LastName  = GetCheckedName(checker, "Input LastName:");
        Console.WriteLine(user1.ToString()); 
        Console.ReadKey();


    }
}   
