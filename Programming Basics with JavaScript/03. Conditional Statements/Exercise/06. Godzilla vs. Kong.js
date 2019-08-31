function solve(input) {
    let budget = Number(input.shift());
    let statistCount = Number(input.shift());
    let clothesFor1Statist = Number(input.shift());
    let decorPrice = budget * 0.10;
    let clothesPrice = statistCount * clothesFor1Statist;

    if (statistCount > 150) {
        let discount = clothesPrice * 0.1;
        clothesPrice -= discount;
    }
    let priceForFilm = decorPrice + clothesPrice;

    if (budget - priceForFilm >= 0) {
        console.log(`Action!`);
        console.log(`Wingard starts filming with ${(budget - priceForFilm).toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money!`);
        console.log(`Wingard needs ${(priceForFilm - budget).toFixed(2)} leva more.`);
    }
}

solve([15437.62,186,57.99]);