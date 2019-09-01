function solve(input) {
    let n_Number = Number(input.shift());
    let l_Number = Number(input.shift());
    let letter = 97 + l_Number;
    let result = "";
    for (let i1 = 1; i1 < n_Number; i1++) {
        for (let i2 = 1; i2 < n_Number; i2++) {
            for (let i3 = 97; i3 < letter; i3++) {
                for (let i4 = 97; i4 < letter; i4++) {
                    for (let i5 = 2; i5 <= n_Number; i5++) {
                        if (i5 > i1 && i5 > i2) {
                            let i3ToChar = String.fromCharCode(i3);
                            let i4ToChar = String.fromCharCode(i4);
                            result += `${i1}${i2}${i3ToChar}${i4ToChar}${i5} `;
                        }
                    }
                }
            }
        }
    }
    console.log(result);
}

solve([2, 4]);