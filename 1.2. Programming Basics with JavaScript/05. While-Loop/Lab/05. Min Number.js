function solve(input) {
    let n = Number(input.shift());
    let counter = 0;
    let smallNum = Number.MAX_SAFE_INTEGER;

    while (n > counter) {
        let currNum = Number(input.shift());
        if (currNum < smallNum) {
            smallNum = currNum;
        }
        counter++;
    }
    console.log(smallNum);
}

solve([4, 45, -20, 7, 99]);