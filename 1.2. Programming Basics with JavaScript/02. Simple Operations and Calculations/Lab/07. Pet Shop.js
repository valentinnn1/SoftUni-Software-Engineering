function solve(input) {
    let dogsCount = Number(input.shift());
    let restCount = Number(input.shift());
    let dogFoodPrice = 2.50 * dogsCount;
    let restFoodPrice = 4 * restCount;
    let sum = dogFoodPrice + restFoodPrice;
    console.log(`${sum.toFixed(2)} lv.`);
}

solve([13,9]);