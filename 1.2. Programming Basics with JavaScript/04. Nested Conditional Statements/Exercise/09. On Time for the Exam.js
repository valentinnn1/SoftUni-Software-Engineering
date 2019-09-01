function solve(input) {
    let examHours = Number(input.shift());
    let examMins = Number(input.shift());
    let arrHours = Number(input.shift());
    let arrMins = Number(input.shift());

    let examTotalMins = examHours * 60 + examMins;
    let arrTotalMins = arrHours * 60 + arrMins;
    let time = examTotalMins - arrTotalMins;

    if (time < 0) {
        console.log('Late');
        if (time > -60) {
            console.log(`${Math.abs(time)} minutes after the start`);
        } else {
            let h = Math.abs(parseInt(time / 60));
            let m = Math.abs(time % 60);
            if (m < 10) {
                console.log(`${h}:0${m} hours after the start`);
            } else {
                console.log(`${h}:${m} hours after the start`);
            }
        }
    } else if (time == 0 || time <= 30) {
        console.log('On time');
        if (time > 0) {
            console.log(`${time} minutes before the start`);
        }
    } else {
        console.log('Early');
        if (time < 60) {
            console.log(`${time} minutes before the start`);
        } else {
            let h = parseInt(time / 60);
            let m = time % 60;
            if (m < 10) {
                console.log(`${h}:0${m} hours before the start`);
            } else {
                console.log(`${h}:${m} hours before the start`);
            }
        }
    }
}

solve([9, 30, 9, 50]);