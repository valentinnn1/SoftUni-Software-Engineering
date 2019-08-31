function solve(input) {
    let excPrice = Number(input.shift());
    let puzzleCount = Number(input.shift());
    let talkingDollsCount = Number(input.shift());
    let teddyBearsCount = Number(input.shift());
    let minionsCount = Number(input.shift());
    let trucksCount = Number(input.shift());
    
    let puzzlePrice = puzzleCount * 2.60;
    let talkingDollsPrice = talkingDollsCount * 3;
    let teddyBearsPrice = teddyBearsCount * 4.10;
    let minionsPrice = minionsCount * 8.20;
    let trucksPrice = trucksCount * 2;
    let totalPrice = puzzlePrice + talkingDollsPrice + teddyBearsPrice + minionsPrice + trucksPrice;
    let toysCount = puzzleCount + talkingDollsCount + teddyBearsCount + minionsCount + trucksCount;
    let discount = 0;

    if (toysCount >= 50) {
        discount = totalPrice * 0.25;
    }

    let totalPriceAfterDiscount = totalPrice - discount;
    let rent = totalPriceAfterDiscount * 0.10;
    let profit = totalPriceAfterDiscount - rent;

    if (profit >= excPrice ) {
        console.log(`Yes! ${(profit - excPrice).toFixed(2)} lv left.`);
    } else {
        console.log(`Not enough money! ${(excPrice - profit).toFixed(2)} lv needed.`);
    }
}

solve([320,8,2,5,5,1]);