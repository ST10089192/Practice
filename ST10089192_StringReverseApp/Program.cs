namespace ST10089192_StringReverseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type a word: ");
            string input = Console.ReadLine();
            string output = null; 

            for(int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine("Watch the magic...");

            Console.WriteLine("\nHere it is in reverse: " + output);
            Console.ReadLine();
        }
    }
}