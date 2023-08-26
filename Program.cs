namespace ThirdTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "java";
            input = input.ToUpper();
           char[] charArry = input.ToCharArray();
            Array.Reverse(charArry);           
            Console.WriteLine(charArry);
        }
    }
}