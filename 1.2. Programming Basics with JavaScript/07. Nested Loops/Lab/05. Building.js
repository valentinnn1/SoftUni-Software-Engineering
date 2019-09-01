function solve(input) {
    let floor = Number(input.shift());
    let rooms = Number(input.shift());
    for (let i = floor; i >= 1; i--) {
        let result = "";
        for (let j = 0; j < rooms; j++) {
            if (floor == i) {
                result += `L${i}${j} `;
            }
            else if (i % 2 == 0) {
                result += `O${i}${j} `;
            }
            else {
                result += `A${i}${j} `;
            }
        }
        console.log(result);
    }
}

solve([6, 4]);