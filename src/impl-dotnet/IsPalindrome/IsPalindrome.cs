namespace dotnet_land {
    public class PalindromeNumber {
        public PalindromeNumber() { }

        public bool IsPalindrome(int x) {

            string str = x.ToString();

            int[] intArr = str.Select(x => Convert.ToInt32(x) - 48).ToArray();

            int[] reversedArr = Enumerable.Reverse(intArr).ToArray();

            return intArr.SequenceEqual(reversedArr);
        }

        public bool IsPalindrome2(int x) {
            int test = 0;

            if (x % 10 == 0 && x != 0) return false;

            while (x > test) {
                test = test * 10 + x % 10;
                x = x / 10;
            }
            return x == test | x == test / 10;
        }

        public bool IsPalindrome3(int x) {
            int r = 0;
            int c = x;

            while (c > 0) {
                Console.WriteLine("----------------------");
                Console.WriteLine($"c = {c}");
                Console.WriteLine($"r = {r}");


                Console.WriteLine($"{r} * 10 = " + r * 10);
                Console.WriteLine($"{c} % 10 = " + c % 10);
                Console.WriteLine($"{r} * 10 + {c} % 10 = " + r * 10 + c % 10);
                r = r * 10 + c % 10;

                Console.WriteLine($"{c} / 10 = " + c / 10);
                c = c / 10;

                Console.WriteLine($"c = {c}");
                Console.WriteLine($"r = {r}");
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"r = {r}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"x = {x}");
            return r == x;
        }

    }
}
