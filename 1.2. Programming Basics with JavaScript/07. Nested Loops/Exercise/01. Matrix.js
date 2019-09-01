function solve(input) {
    let a = Number(input.shift());
    let b = Number(input.shift());
    let c = Number(input.shift());
    let d = Number(input.shift());

    for (let firstRowFirstNum = a; firstRowFirstNum <= b; firstRowFirstNum++) {
        for (let firstRowSecondNum = a; firstRowSecondNum <= b; firstRowSecondNum++) {
            for (let secondRowFirstNum = c; secondRowFirstNum <= d; secondRowFirstNum++) {
                for (let secondRowSecondNum = c; secondRowSecondNum <= d; secondRowSecondNum++) {
                    if (((firstRowFirstNum + secondRowSecondNum) == (firstRowSecondNum + secondRowFirstNum) && (firstRowFirstNum != firstRowSecondNum) && (secondRowFirstNum != secondRowSecondNum))) {
                        console.log(`${firstRowFirstNum}${firstRowSecondNum}`);
                        console.log(`${secondRowFirstNum}${secondRowSecondNum}`);
                        console.log();
                    }
                }
            }
        }
    }
}

solve([1, 2, 3, 4]);