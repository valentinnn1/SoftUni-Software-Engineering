function solve(input) {
    let n = Number(input.shift());
    let counter = 0;
    let bigNum = Number.MIN_SAFE_INTEGER;

    while (n > counter) {
        let currNum = Number(input.shift());
        if (currNum > bigNum) {
            bigNum = currNum;
        }
        counter++;
    }
    console.log(bigNum);
}

solve([4, 45, -20, 7, 99]);