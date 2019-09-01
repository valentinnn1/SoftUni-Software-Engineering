function solve(input) {
    let n = Number(input.shift());
    let leftSum = 0;
    let rightSum = 0;

    for (let i = 0; i < n; i++) {
        let leftNum = Number(input.shift());
        leftSum += leftNum;
    }

    for (let i = 0; i < n; i++) {
        let rightNum = Number(input.shift());
        rightSum += rightNum;
    }
    if (leftSum == rightSum) {
        console.log(`Yes, sum = ${leftSum}`);
    }
    else {
        console.log(`No, diff = ${Math.abs(leftSum - rightSum)}`);
    }
}

solve([2, 10, 90, 60, 40]);