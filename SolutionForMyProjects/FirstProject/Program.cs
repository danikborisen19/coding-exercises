namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine(IsPalindrome("alla"));
           
      

        }
        public static bool IsPalindrome(string inputString)
        {
            inputString = inputString.ToLower();
            inputString = new string(inputString.Where(char.IsLetterOrDigit).ToArray());
            int left = 0;
            int right = inputString.Length - 1;

            while (left < right)
            {
                if (inputString[left] != inputString[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    
    }
}



