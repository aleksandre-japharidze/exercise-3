def fn(number):
    primes = 0
    sum_div_by_7 = 0
    sum_of_even = 0
    max_odd = 0

    for i in range(1, number + 1):
        if i % 3 == 0 and i % 5 == 0:
            print("FizzBuzz", end=" ")
        elif i % 3 == 0:
            print("Fizz", end=" ")
        elif i % 5 == 0:
            print("Buzz", end=" ")
        elif isPrime(i):
            print(f"[{i}]", end=" ")
            primes += 1
        else:
            print(i, end=" ")


        sum_of_even = sumEven(i)
        max_odd = maxOdd(i)
        sum_div_by_7 = sumDivisibleBy7(i)


    print(f"\n\nNumber of primes: {primes}\nSum of numbers divisible by 7: {sum_div_by_7}\n"
          f"Sum of even numbers: {sum_of_even}\nMax odd number: {max_odd}\n")

def sumDivisibleBy7(num):
    sum = 0
    for i in range(1, num + 1):
        if i % 7 == 0:
            sum += i
    return sum

def maxOdd(num):
    max = 0
    for i in range(1, num + 1):
        if i % 2 != 0:
            if i > max:
                max = i
    return max

def sumEven(num):
    sum = 0
    for i in range(2, num + 1):
        if i % 2 == 0:
            sum += i
    return sum

def isPrime(num):
    if num == 2 or num == 3:
        return True
    elif num % 2 == 0 or num < 2:
        return False
    else:
        for i in range(3, int(num ** 0.5) + 1, 2):
            if num % i == 0:
                return False
    return True


name = input("Enter your name: ")

for i in range(3):
    number = int(input("Enter a number between 10 and 200: "))
    if number < 10 or number > 200:
        if i == 2:
            print("\nToo many invalid attempts. Exiting...")
            break
        else:
            print("Invalid number. Please try again.")
    else:
        fn(number)
        print(f"\nHey, {name}! There's your exercise! BTW, Aleksandre did not use AI to generate the code "
              f"for this exercise. He just read some documentation about how to check prime numbers. He hates "
              f"math with passion, BTW. I mean, not because he's bad at it, but he just hates it.\n")
        break
