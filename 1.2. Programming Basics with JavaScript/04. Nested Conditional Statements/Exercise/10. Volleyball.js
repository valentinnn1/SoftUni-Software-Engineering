function solve(input) {
    let typeOfYear = input.shift();
    let holidays = Number(input.shift());
    let homeWeekends = Number(input.shift());

    let weekendsInSofia = (48 - homeWeekends) * 3.0 / 4;
    let gamesInSofiaInHolidays = holidays * 2.0 / 3;
    let fullWeekendPlusHolidays = weekendsInSofia + homeWeekends + gamesInSofiaInHolidays;

    if (typeOfYear == "normal") {
        let result = Math.floor(fullWeekendPlusHolidays);
        console.log(result);
    } else if (typeOfYear == "leap") {
        let leapResult = fullWeekendPlusHolidays * 0.15;
        leapResult = leapResult + fullWeekendPlusHolidays;
        let result = Math.floor(leapResult);
        console.log(result);
    }
}

solve(['normal', 3, 2]);