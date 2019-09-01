function solve(input) {
    let n = Number(input.shift());
    let smallest = Number.MAX_SAFE_INTEGER;
    let biggest = Number.MIN_SAFE_INTEGER;

    for (let i = 0; i < n; i++) {
        let num = Number(input.shift());
        if (num < smallest) {
            smallest = num;
        }
        if (num > biggest) {
            biggest = num;
        }
    }
    console.log(`Max number: ${biggest}`);
    console.log(`Min number: ${smallest}`);
}

solve([5, 10, 20, 304, 0, 50]);