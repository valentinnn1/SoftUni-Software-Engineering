function solve(input) {
    let n = Number(input.shift());
    let numbersTo200 = 0;
    let numbersFrom200To399 = 0;
    let numbersFrom400To599 = 0;
    let numbersFrom600To799 = 0;
    let numbers800 = 0;

    for (let i = 0; i < n; i++) {
        let number = Number(input.shift());

        if (number < 200) {
            numbersTo200++;
        }
        else if (number <= 399) {
            numbersFrom200To399++;
        }
        else if (number <= 599) {
            numbersFrom400To599++;
        }
        else if (number < 800) {
            numbersFrom600To799++;
        }
        else {
            numbers800++;
        }
    }
    console.log(`${(numbersTo200 * 100.0 / n).toFixed(2)}%`);
    console.log(`${(numbersFrom200To399 * 100.0 / n).toFixed(2)}%`);
    console.log(`${(numbersFrom400To599 * 100.0 / n).toFixed(2)}%`);
    console.log(`${(numbersFrom600To799 * 100.0 / n).toFixed(2)}%`);
    console.log(`${(numbers800 * 100.0 / n).toFixed(2)}%`);
}

solve([4, 53, 7, 56, 999]);