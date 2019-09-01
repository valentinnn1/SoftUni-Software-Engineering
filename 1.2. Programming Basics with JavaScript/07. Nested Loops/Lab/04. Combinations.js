function solve(input) {
    let n = Number(input.shift());
    let counter = 0;

    for (let x1 = 0; x1 <= 25; x1++) {
        for (let x2 = 0; x2 <= 25; x2++) {
            for (let x3 = 0; x3 <= 25; x3++) {
                for (let x4 = 0; x4 <= 25; x4++) {
                    for (let x5 = 0; x5 <= 25; x5++) {
                        if (x1 + x2 + x3 + x4 + x5 == n) {
                            counter++;
                        } else {
                            continue;
                        }
                    }
                }
            }
        }
    }
    console.log(counter);
}

solve([25]);