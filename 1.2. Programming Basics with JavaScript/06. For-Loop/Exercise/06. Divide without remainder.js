function solve(input) {
    let n = Number(input.shift());
    let divideBy2 = 0;
    let divideBy3 = 0;
    let divideBy4 = 0;

    for (let i = 0; i < n; i++) {
        let number = Number(input.shift());

        if (number % 2 == 0) {
            divideBy2++;
        }
        if (number % 3 == 0) {
            divideBy3++;
        }
        if (number % 4 == 0) {
            divideBy4++;
        }
    }

    console.log(`${(divideBy2 * 100.0 / n).toFixed(2)}%`);
    console.log(`${(divideBy3 * 100.0 / n).toFixed(2)}%`);
    console.log(`${(divideBy4 * 100.0 / n).toFixed(2)}%`);
}

solve([10, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65]);