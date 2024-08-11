namespace Detect_Pangram
{
    internal class Program
    {
        public static bool IsPangram(string str)
        {
            HashSet<char> alphabet = new HashSet<char>
            {
                'a', 'b', 'c', 'd', 'e',
                'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z'
            };

            foreach (char c in str.ToLower()) 
            {
                alphabet.Remove(c);
            }      

            return alphabet.Count == 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));
        }
    }
}