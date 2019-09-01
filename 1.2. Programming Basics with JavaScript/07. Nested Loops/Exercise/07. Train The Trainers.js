function solve(input) {
    let numberOfPeople = Number(input.shift());
    let allScore = 0;
    let counter = 0;

    while (true) {
        let nameOfPresentation = input.shift();
        let sumOfGrades = 0;
        if (nameOfPresentation == "Finish") {
            let scoreSum = allScore / counter;
            console.log(`Student's final assessment is ${scoreSum.toFixed(2)}.`);
            break;
        }
        for (let i = 0; i < numberOfPeople; i++) {
            let grade = Number(input.shift());
            sumOfGrades += grade;
            allScore += grade;
            counter++;
        }
        let sumAfter = sumOfGrades / numberOfPeople;
        console.log(`${nameOfPresentation} - ${sumAfter.toFixed(2)}.`);
    }
}

solve([2, 'While-Loop', 6.00, 5.50, 'For-Loop', 5.84, 5.66, 'Finish']);