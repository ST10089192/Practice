namespace ST10089192_StringReverseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type a word: ");
            string input = Console.ReadLine();//recieve user input
            string output = null; 

            for(int i = input.Length - 1; i >= 0; i--)//for loop to iterate backwords through the string
            {
                output += input[i];
            }

            Console.WriteLine("Watch the magic..." 
                + "\nYour word in reverse is: " + output);//print output

            Console.ReadLine();
        }
    }
}