using System.Text.RegularExpressions;

namespace PasswordChecker;

class PasswordChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine() ?? string.Empty;
        int strengthScore = 0;
        //checks for lowercase letters in the password
        if (Regex.IsMatch(password, "[0-9]"))
        {
            strengthScore += 1;
        }
        if (Regex.IsMatch(password, "[a-z]"))
        {
            strengthScore += 3;
        }

        if (Regex.IsMatch(password, "[A-Z]"))
        {
            strengthScore += 3;
        }

        if (Regex.IsMatch(password, "\\W"))
        {
            strengthScore += 5;
        }

        if (password.Length >= 8 && password.Length <= 12)
        {
            strengthScore *= 2;
        }
        if (password.Length >= 13 && password.Length <= 16)
        {
            strengthScore *= 3;
        }
        if (password.Length >= 17 && password.Length <= 24)
        {
            strengthScore *= 4;
        }

        if (strengthScore <= 12)
        {
            Console.WriteLine("Your password is extremely weak, please create another one. Strength score: " + strengthScore);
        }
        else if (strengthScore <= 24)
        {
            Console.WriteLine("Your password is average. Strength score: " + strengthScore);
        }
        else if (strengthScore <= 48)
        {
            Console.WriteLine("Your password is extremely strong. Strength score: " + strengthScore);
        }
    }
}