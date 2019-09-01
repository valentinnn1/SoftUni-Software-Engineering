function solve(input) {
    let input1 = input.shift();
    let primeSum = 0;
    let nonPrimeSum = 0;
    let count = 0;

    while (input1 != "stop") {
        let number = Number(input1);
        if (number < 0) {
            console.log("Number is negative.");
        } else {
            for (let i = 1; i <= number; i++) {
                if (number % i == 0) {
                    count++;
                }
            }
            if (number == 1) {
                nonPrimeSum++;
            }
            if (count > 2) {
                nonPrimeSum += number;
            } else {
                primeSum += number;
            }
            count = 0;
        }
        input1 = input.shift();
    }

    console.log(`Sum of all prime numbers is: ${primeSum}`);
    console.log(`Sum of all non prime numbers is: ${nonPrimeSum}`);
}

solve([30, 83, 33, -1, 20, 'stop']);