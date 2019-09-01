function solve(input) {
    let recordInSec = Number(input.shift());
    let distanceInM = Number(input.shift());
    let timeInSeconds = Number(input.shift());

    let ivanchoTime = distanceInM * timeInSeconds;
    let slowTime = Math.floor((distanceInM / 15)) * 12.5;
    let totalTime = ivanchoTime + slowTime;

    if (totalTime < recordInSec) {
        console.log(`Yes, he succeeded! The new world record is ${totalTime.toFixed(2)} seconds.`);
    } else {
        let neededTime = totalTime - recordInSec;
        console.log(`No, he failed! He was ${neededTime.toFixed(2)} seconds slower.`);
    }
}

solve([10464,1500,20]);