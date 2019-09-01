function solve(input) {
    let wiskeyPrice = Number(input.shift());
    let beerAmount = Number(input.shift());
    let wineAmount = Number(input.shift());
    let rakiaAmount = Number(input.shift());
    let wiskeyAmount = Number(input.shift());

    let rakiaPriceForLiter = wiskeyPrice / 2;
    let winePriceForLiter = rakiaPriceForLiter - (0.4 * rakiaPriceForLiter);
    let beerPriceForLiter = rakiaPriceForLiter - (0.8 * rakiaPriceForLiter);
    let rakiaPrice = rakiaAmount * rakiaPriceForLiter;
    let winePrice = wineAmount * winePriceForLiter;
    let beerPrice = beerAmount * beerPriceForLiter;
    let totalSum = rakiaPrice + winePrice + beerPrice + wiskeyAmount * wiskeyPrice;

    console.log(totalSum.toFixed(2));
}

solve([63.44,3.57,6.35,8.15,2.5]);