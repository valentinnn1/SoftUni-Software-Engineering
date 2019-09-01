function solve(input) {
    let name = input.shift();
    let classes = 1;
    let sum = 0;

    while (classes <= 12) {
        let grades = Number(input.shift());
        if (grades >= 4) {
            sum += grades;
            classes++;
        }
    }
    let average = sum / 12;
    console.log(`${name} graduated. Average grade: ${average.toFixed(2)}`);
}

solve(['Pesho', 4, 5.5, 6, 5.43, 4.5, 6, 5.55, 5, 6, 6, 5.43, 5]);