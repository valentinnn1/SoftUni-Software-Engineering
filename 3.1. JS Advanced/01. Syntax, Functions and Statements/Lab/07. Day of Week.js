function solve(input) {
    let inputType = typeof(input);
    if (inputType == 'number') {
        switch (input) {
            case 1: console.log("Monday"); break;
            case 2: console.log("Tuesday"); break;
            case 3: console.log("Wednesday"); break;
            case 4: console.log("Thursday"); break;
            case 5: console.log("Friday"); break;
            case 6: console.log("Saturday"); break;
            case 7: console.log("Sunday"); break;
        }
    }
    else {
        switch (input) {
            case 'Monday': console.log(1); break;
            case 'Tuesday': console.log(2); break;
            case 'Wednesday': console.log(3); break;
            case 'Thursday': console.log(4); break;
            case 'Friday': console.log(5); break;
            case 'Saturday': console.log(6); break;
            case 'Sunday': console.log(7); break;
            default: console.log("error");
        }
    }
}

solve(1);