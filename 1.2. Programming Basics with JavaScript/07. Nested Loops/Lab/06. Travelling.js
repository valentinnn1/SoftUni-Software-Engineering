function solve(input) {
    let line = "";
    while ((line = input.shift()) != "End") {
        let destination = line;
        let neededMoney = Number(input.shift());

        let money = 0;
        let savings = "";
        while (true) {
            savings = input.shift();
            if (savings == "End") {
                return;
            }
            money += Number(savings);

            if (money >= neededMoney) {
                console.log(`Going to ${destination}!`);
                break;
            }
        }
    }
}

solve(['Greece', 1000, 200, 200, 300, 100, 150, 240, 'Spain', 1200, 300, 500, 193, 423, 'End']);