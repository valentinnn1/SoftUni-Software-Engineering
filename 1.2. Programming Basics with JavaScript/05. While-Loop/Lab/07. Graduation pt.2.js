function solve(input) {
    let name = input.shift();
    let classes = 1;
    let sum = 0;
    let badGrades = 0;
    let isExcluded = false;

    while (classes <= 12) {
        let grades = Number(input.shift());
        if (grades >= 4) {
            sum += grades;
            classes++;
        }
        else {
            badGrades++;
        }
        if (badGrades > 1) {
            isExcluded = true;
            break;
        }
    }

    if (isExcluded == true) {
        console.log(`${name} has been excluded at ${classes} grade`);
    }
    else {
        let average = sum / 12;
        console.log(`${name} graduated. Average grade: ${average.toFixed(2)}`);
    }
}

solve(['Gosho', 5, 5.5, 6, 5.43, 5.5, 6, 5.55, 5, 6, 6, 5.43, 5]);