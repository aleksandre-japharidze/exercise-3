"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
rl.question("Input an integer: ", function (input) {
    var num = parseInt(input, 10);
    for (var i = 1; i <= num; i++) {
        if (i % 3 == 0 && i % 5 == 0) {
            console.log("FizzBuzz");
        }
        else if (i % 3 == 0) {
            console.log("Fizz");
        }
        else if (i % 5 == 0) {
            console.log("Buzz");
        }
        else {
            console.log(i);
        }
    }
    rl.close();
});
