function solve(input) {
    let currIndex = 0;
    let name = input[currIndex];
    let winnerName = "";
    let winnerScore = 0;
    while (name != "STOP") {
        let tempScore = 0;
        for (let i = 0; i < name.length; i++) {
            tempScore += name.charCodeAt(i);
        }
        if (winnerScore < tempScore) {
            winnerScore = tempScore;
            winnerName = name;
        }
        currIndex++;
        name = input[currIndex];
    }
    console.log(`Winner is ${winnerName} - ${winnerScore}!`);
}

solve(['Petar', 'Georgi', 'Stanimir', 'STOP']);