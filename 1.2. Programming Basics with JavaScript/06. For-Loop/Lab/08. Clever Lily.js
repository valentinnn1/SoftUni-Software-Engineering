function solve(input) {
    let age = Number(input.shift());
    let washingMachinePrice = Number(input.shift());
    let toyPrice = Number(input.shift());
    let toysCounter = 0;
    let moneyFromGifts = 0;
    let badBrotherCounter = 0;

    for (let i = 1; i <= age; i++) {
        if (i % 2 == 0) {
            badBrotherCounter++;
            moneyFromGifts += 10 * badBrotherCounter;
        }
        else {
            toysCounter++;
        }
    }
    let moneyForToys = toysCounter * toyPrice;
    let totalMoney = (moneyForToys + moneyFromGifts) - badBrotherCounter;

    if (totalMoney >= washingMachinePrice) {
        console.log(`Yes! ${(totalMoney - washingMachinePrice).toFixed(2)}`);
    }
    else {
        console.log(`No! ${(washingMachinePrice - totalMoney).toFixed(2)}`);
    }
}

solve([10, 170.00, 6]);