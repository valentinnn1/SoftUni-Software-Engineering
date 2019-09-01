function solve(input) {
    let n = Number(input.shift());
    let prevSum = 0;
    let currSum = 0;
    let maxDiff = 0;
    let currDiff = 0;

    for (let i = 0; i < n; i++) {
        let firstNum = Number(input.shift());
        let secondNum = Number(input.shift());

        if (i == 0) {
            currSum = firstNum + secondNum;
            continue;
        }
        prevSum = currSum;
        currSum = firstNum + secondNum;
        currDiff = Math.abs(currSum - prevSum);

        if (currDiff > maxDiff) {
            maxDiff = currDiff;
        }
    }

    if (maxDiff == 0) {
        console.log(`Yes, value=${currSum}`);
    }
    else {
        console.log(`No, maxdiff=${maxDiff}`);
    }
}

solve([3, 1, 2, 0, 3, 4, -1]);