namespace impl_dotnet
{
    public static class RomanToInt
    {
        public static KeyVal[] KeyVals = {
            new KeyVal {Key = 'I', Value = 1},
            new KeyVal {Key = 'V', Value = 5},
            new KeyVal {Key = 'X', Value = 10},
            new KeyVal {Key = 'L', Value = 50},
            new KeyVal {Key = 'C', Value = 100},
            new KeyVal {Key = 'D', Value = 500},
            new KeyVal {Key = 'M', Value = 1000}
        };

        public static void Calc()
        {
            Console.WriteLine("Calc me daddy");


            // string a = "LVIII";
            string s = "MCMXCIV";
            char[] inputs = s.ToArray();

            int result = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                char currentInput = inputs[i];
                char nextInput = '\0';

                if (i + 1 < inputs.Length)
                {
                    nextInput = inputs[i + 1];
                }

                int currentVal = 0;
                int nextVal = 0;

                foreach (KeyVal item in KeyVals)
                {
                    if (item.Key == currentInput)
                    {
                        currentVal = item.Value;
                    }

                    if (item.Key == nextInput)
                    {
                        nextVal = item.Value;
                    }
                }

                if (currentVal < nextVal)
                {
                    result = result + (nextVal - currentVal);
                    i++;
                }
                else
                {
                    result = result + currentVal;
                }

            }

            // for (int i = 0; i < KeyVals.Length; i++)
            // {
            //     KeyVal item = KeyVals[i];
            //     if(item.Key == a) {
            //         result += result + item.Value;
            //     }
            // }

            Console.WriteLine($"Input: {s} : Output: {result}");
        }
    }

    public struct KeyVal
    {
        public char Key { get; set; }
        public int Value { get; set; }
    }

}
