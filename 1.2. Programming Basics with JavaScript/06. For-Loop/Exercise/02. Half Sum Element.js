function solve(input) {
    let counter = Number(input.shift());
    let sum = 0;
    let max = 0;
    for (let i = 0; i < counter; i++) {
        let num = Number(input.shift());
        if (num > max) {
            max = num;
        }
        sum += num;
    }

    sum -= max;
    if (sum == max) {
        console.log(`Yes`);
        console.log(`Sum = ${max}`);
    }
    else {
        console.log(`No`);
        console.log(`Diff = ${Math.abs(sum - max)}`);
    }
}

solve([4, 6, 1, 2, 3]);