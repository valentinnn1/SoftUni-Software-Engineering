function solve(input) {
    let n = Number(input.shift());
    let oddSum = 0;
    let evenSum = 0;

    for (let i = 1; i <= n; i++)
    {
        let number = Number(input.shift());

        if (i % 2 == 0) {
            evenSum += number;
        }
        else {
            oddSum += number;
        }
    }

    if (evenSum == oddSum) {
        console.log(`Yes`);
        console.log(`Sum = ${evenSum}`);
    }
    else {
        console.log(`No`);
        console.log(`Diff = ${Math.abs(oddSum-evenSum)}`);
    }
}

solve([]);