namespace impl_dotnet
{
    // failed
    public static class LongestCommonPrefix
    {
        public static string Calc(string[] strs)
        {
            string shortest = strs[0];

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < shortest.Length)
                {
                    shortest = strs[i];
                }
            }

            Console.WriteLine(shortest);

            string result = "";
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] == shortest)
                {
                    continue;
                }

                for (int j = 0; j < shortest.Length; j++)
                {
                    // Console.WriteLine(strs[i][j]);
                    Console.WriteLine(shortest[j]);
                    if (shortest[j] == strs[i][j])
                    {
                        result = result + shortest[i];
                    }
                    else {
                        break;
                    }

                }

            }

            Console.WriteLine(result);
            return result;
        }
    }
}
