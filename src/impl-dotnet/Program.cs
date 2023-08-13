namespace impl_dotnet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
       int pn = 121;
       bool isPalindrome = Palindrome.IsPalindrome(pn);
       Console.WriteLine($"Is Palidrome {pn} = {isPalindrome}");
       RomanToInt.Calc();
    }
}
