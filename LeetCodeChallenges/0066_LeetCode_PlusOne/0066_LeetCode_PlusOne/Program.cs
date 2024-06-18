namespace _0066_LeetCode_PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits1 = { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", PlusOne(digits1)));  // Output: 1, 2, 4

            int[] digits2 = { 9, 9, 9 };
            Console.WriteLine(string.Join(", ", PlusOne(digits2)));  // Output: 1, 0, 0, 0
        }

        public static int[] PlusOne(int[] digits)
        {
            int n= digits.Length;

            for(int i = n -1; i>= 0; i--)
            {
                if (digits[i] > 9)
                {
                    digits[i] += 1;
                    return digits;
                }

                digits[i] = 0;
            }
            int[] newDigits = new int[n + 1];
            newDigits[0] = 1;

            return newDigits;
        }

    }
}
