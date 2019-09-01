function solve(input) {
    let days = Number(input.shift());
    let roomType = input.shift();
    let evaluation = input.shift();
    let nights = days - 1;
    let price = 0;
    let discount = 0;

    if (roomType == "room for one person") {
        price = 18 * nights;
    } else if (roomType == "apartment") {
        price = 25 * nights;
        if (days < 10) {
            discount = price * 0.30;
            price -= discount;
        } else if (days >= 10 && days <= 15) {
            discount = price * 0.35;
            price -= discount;
        } else if (days > 15){
            discount = price * 0.50;
            price -= discount;
        }
    } else if (roomType == "president apartment") {
        price = 35 * nights;
        if (days < 10) {
            discount = price * 0.10;
            price -= discount;
        } else if (days >= 10 && days <= 15) {
            discount = price * 0.15;
            price -= discount;
        } else if (days > 15){
            discount = price * 0.20;
            price -= discount;
        }
    }

    if (evaluation == "positive") {
        let newDiscount = price * 0.25;
        price += newDiscount;
        console.log(price.toFixed(2));
    } else if (evaluation == "negative") {
        let newDiscount = price * 0.10;
        price -= newDiscount;
        console.log(price.toFixed(2));
    }
}

solve([14, 'apartment', 'positive']);