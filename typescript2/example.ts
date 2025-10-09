import * as readlineSync from 'readline-sync';

function fn(number: number) {
    var primes = 0;
    var sum_of_even = 0;
    var max_odd = 0;
    var sum_div_by_7 = 0;

    for (let i = 1; i <= number; i++) {
        if (i % 3 == 0 && i % 5 == 0) {
            process.stdout.write("FizzBuzz" + " ");
        } else if (i % 3 == 0) {
            process.stdout.write("Fizz" + " ");
        } else if (i % 5 == 0) {
            process.stdout.write("Buzz" + " ");
        } else if (isPrime(i)) {
            process.stdout.write("[" + i.toString() + "]" + " ");
            primes += 1;
        } else {
            process.stdout.write(i.toString() + " ");
        }

        sum_of_even = sumEven(i);
        max_odd = maxOdd(i);
        sum_div_by_7 = sumDivisibleBy7(i);
    }

    console.log("\n\nNumber of primes: " + primes + "\nSum of numbers divisible by 7: " + sum_div_by_7 +
        "\nSum of even numbers: " + sum_of_even + "\nMax odd number: " + max_odd + "\n");

}

function sumDivisibleBy7(num: number) {
    var sum = 0;
    for (let i=1; i<=num; i++) {
        if (i % 7 == 0) {
            sum += i;
        }
    }
    return sum;
}

function maxOdd(num: number) {
    var max = 0;
    for (let i=1; i<=num; i++) {
        if (i % 2 != 0) {
            if (i > max) {
                max = i;
            }
        }
    }
    return max;
}

function sumEven(num: number) {
    var sum = 0;
    for (let i=2; i<=num; i++) {
        if (i % 2 == 0) {
            sum += i;
        }
    }
    return sum;
}

function isPrime(num: number) {
    if (num == 2 || num == 3) {
        return true;
    } else if (num % 2 == 0 || num < 2) {
        return false; 
    } else {
        for (let i=3; i<=num**0.5 + 1; i+=2) {
            if (num % i == 0) {
                return false;
            }
        }
    }
    return true;
}


const name = readlineSync.question("Enter your name: ")
for (let i = 0; i <= 2; i++) {
    const numberString = readlineSync.question("Enter an integer between 10 and 200: ");
    const number = parseInt(numberString);
    if (number < 10 || number > 200) {
        if (i == 2) {
            console.log("\nToo many invalid attempts. Exiting...");
            break;
        } else {
            console.log("Invalid number. Please try again.");
        }
    } else {
        fn(number);
        console.log("\nHey, " + name + "! There's your exercise! BTW, Aleksandre did not use AI to generate the code " +
        "for this exercise. He just read some documentation about how to check prime numbers. And " +
        "to be even more honest with you, he also just googled 'how to print with for loop on one line in typescript' " +
        "and stuff like that.");
        break;
    }
}