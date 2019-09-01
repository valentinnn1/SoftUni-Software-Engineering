function solve(input) {
    let firstNumber = Number(input[0]);
    let secondNumber = Number(input[1]);
    let result = "";

    for (let i = firstNumber; i <= secondNumber; i++) {
        let evenSum = 0;
        let oddSum = 0;
        let numAsString = i.toString();

        for (let j = 0; j <= numAsString.length - 1; j++) {
            let num = Number(numAsString[j]);

            if (j % 2 == 0) {
                oddSum += num;
            } else {
                evenSum += num;
            }
        }

        if (oddSum == evenSum) {
            result += `${i} `
        }
    }
    console.log(result);
}

solve([100000, 100050]);