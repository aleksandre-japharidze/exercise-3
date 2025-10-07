void Fn(int number)
{
    int primes = 0;
    int sumDivBy_7 = 0;
    int sumOfEven = 0;
    int maxOdd = 0;

    for (int i = 1; i <= number; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.Write("FizzBuzz" + " ");
        } 
        else if (i % 3 == 0)
        {
            Console.Write("Fizz" + " ");
        } 
        else if (i % 5 == 0)
        {
            Console.Write("Buzz" + " ");
        }
        else if (isPrime(i))
        {
            Console.Write($"[{i}]" + " ");
            primes += 1;
        }
        else
        {
            Console.Write(i + " ");
        }
        
        sumOfEven = SumEven(i);
        sumDivBy_7 = SumDivisiblesBy7(i);
        maxOdd = MaxOdd(i);
    }
    
    Console.WriteLine($"\n\nNumber of primes: {primes}\nSum of even numbers: {sumOfEven}\n" +
                      $"Sum of numbers divisible by 7: {sumDivBy_7}\nMax odd number: {maxOdd}");
}

int SumDivisiblesBy7(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        if (i % 7 == 0)
        {
            sum += i;
        }
    }
    return sum;
}

int MaxOdd(int num)
{
    int max = 0;
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 != 0)
        {
            if (i > max)
            {
                max = i;
            }
        }
    }
    return max;
}

int SumEven(int num)
{
    int sum = 0;
    for (int i = 2; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    return sum;
}

bool isPrime(int num)
{
    if (num == 2 || num == 3)
    {
        return true;
    } 
    else if (num % 2 == 0 || num < 2)
    {
        return false;
    }
    else
    {
        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
    }
    return true;
}


Console.Write("Enter your name: ");

string name = Console.ReadLine();

for (int i = 0; i <= 2; i++)
{
    Console.Write("Enter a number between 10 and 200: ");
    
    int number = int.Parse(Console.ReadLine());
    if (number < 10 || number > 200)
    {
        if (i == 2)
        {
            Console.WriteLine("\nToo many invalid attempts. Exiting...");
            break;
        }
        else
        {
            Console.WriteLine("Invalid number. Please try again.");
        }
    }
    else
    {
        Fn(number);
        Console.WriteLine($"\n\nHey, {name}! There's your exercise! BTW, Aleksandre did not use AI to generate the code " +
                          $"for this exercise. He just read some documentation about how to check prime numbers.");
        break;
    }
}