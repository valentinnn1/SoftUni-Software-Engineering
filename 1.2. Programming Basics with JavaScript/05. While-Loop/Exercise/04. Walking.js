function solve(input) {
    let purpose = 10000;
    let stepsSum = 0;
    let output = '';

    while (true) {
        let command = input.shift();

        if (command == "Going home") {
            let finalSteps = Number(input.shift());
            stepsSum += finalSteps;
            break;
        } else {
            let currentSteps = Number(command);
            stepsSum += currentSteps;

            if (stepsSum >= purpose) {
                break;
            }
        }
    }
    if (stepsSum >= purpose) {
        console.log("Goal reached! Good job!");
    } else {
        console.log(`${purpose - stepsSum} more steps to reach goal.`);
    }
}

solve([1000, 1500, 2000, 6500]);