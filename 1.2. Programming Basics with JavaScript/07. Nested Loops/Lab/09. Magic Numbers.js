function solve(input) {
    let magicNumber = Number(input.shift());
    let sum = 0;
    let result = "";

    for (let i = 1; i <= 9; i++) {
        for (let j = 1; j <= 9; j++) {
            for (let k = 1; k <= 9; k++) {
                for (let l = 1; l <= 9; l++) {
                    for (let m = 1; m <= 9; m++) {
                        for (let n = 1; n <= 9; n++) {
                            sum = i * j * k * l * m * n;
                            if (sum == magicNumber) {
                                result += `${i}${j}${k}${l}${m}${n} `;
                            }
                        }
                    }
                }
            }
        }
    }
    console.log(result);
}

solve([8]);