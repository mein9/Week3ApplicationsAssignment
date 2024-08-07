
namespace Week3ApplicationsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "biopsy";
            string string2 = "computer";

            // Call IsAbecedarian method, which will handle printing the result
            IsAbecedarian(string1);
            IsAbecedarian(string2);
        }

        public static void IsAbecedarian(string s)
        {
            // Compares each string letter to the next to make sure word is abecedarian
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].CompareTo(s[i + 1]) > 0) //if false enters loop
                {
                    Console.WriteLine($"{s} is not abecedarian");
                    return;  // stops loop on first error, saves time
                }
            }
            Console.WriteLine($"{s} is abecedarian"); //runs only after entire entire string is itterated over
        }
    }
}