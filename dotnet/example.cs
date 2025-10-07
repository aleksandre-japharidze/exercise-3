public class Example
{
    public static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        string inputString = Console.ReadLine();
        
        int number = int.Parse(inputString);
        
        for (int i=1; i<=number; i++) {
            if ((i % 3) == 0 && (i % 5) == 0) {
                Console.WriteLine("FizzBuzz");
            } else if ((i % 3) == 0) {
                Console.WriteLine("Fizz");
            } else if ((i % 5) == 0) {
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine(i);
            }
        }
    }
}