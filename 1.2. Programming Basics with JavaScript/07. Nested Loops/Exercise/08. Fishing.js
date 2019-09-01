function solve(input) {
    let quota = Number(input.shift());
    let count = 0;
    let profit = 0;
    let lost = 0;
    let fishName = input.shift();

    while (fishName != 'Stop') {
        let fishKg = Number(input.shift());
        count++;
        let sum = 0;

        for (let i = 0; i <= fishName.length - 1; i++) {
            let value = fishName.charCodeAt(i);
            sum += value;
        }
        let price = sum / fishKg;

        if (count % 3 == 0) {
            profit += price;
        } else {
            lost += price;
        }

        if (count == quota) {
            console.log('Lyubo fulfilled the quota!'); break;
        }
        fishName = input.shift();
    }
    if (profit > lost) {
        let income = profit - lost;
        console.log(`Lyubo's profit from ${count} fishes is ${income.toFixed(2)} leva.`);
    } else {
        let lost2 = lost - profit;
        console.log(`Lyubo lost ${lost2.toFixed(2)} leva today.`);
    }
}

solve([3, 'catfish', 70, 'carp', 20, 'tench', 14]);