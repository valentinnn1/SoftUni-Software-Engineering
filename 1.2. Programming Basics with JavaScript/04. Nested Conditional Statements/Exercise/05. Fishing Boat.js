function solve(input) {
    let budget = Number(input.shift());
    let season = input.shift();
    let fisherman = Number(input.shift());

    let rentBoat = 0;
    let even = 1;

    if (fisherman % 2 == 0) {
        even *= 0.95;
    }

    switch (season) {
        case "Spring":
            rentBoat = 3000 * even;
            break;
        case "Summer":
            rentBoat = 4200 * even;
            break;
        case "Autumn":
            rentBoat = 4200;
            break;
        case "Winter":
            rentBoat = 2600 * even;
            break;
    }

    if (fisherman >= 12) {
        rentBoat *= 0.75;
    } else if (fisherman >= 7) {
        rentBoat *= 0.85;
    } else {
        rentBoat *= 0.90;
    }

    let diff = Math.abs(budget - rentBoat);

    if (budget >= rentBoat) {
        console.log(`Yes! You have ${diff.toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money! You need ${diff.toFixed(2)} leva.`);
    }
}

solve([3000, 'Summer', 11]);