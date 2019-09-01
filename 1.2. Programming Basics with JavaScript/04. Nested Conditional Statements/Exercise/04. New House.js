function solve(input) {
    let flower = input.shift();
    let numberOfFlowers = Number(input.shift());
    let budget = Number(input.shift());

    let priceFlower = 0;

    switch (flower)
    {
        case "Roses":
            priceFlower = 5;
            break;
        case "Dahlias":
            priceFlower = 3.80;
            break;
        case "Tulips":
            priceFlower = 2.80;
            break;
        case "Narcissus":
            priceFlower = 3;
            break;
        case "Gladiolus":
            priceFlower = 2.50;
            break;
    }

    let totalPrice = numberOfFlowers * priceFlower;

    if (numberOfFlowers > 80 && flower == "Roses") {
        totalPrice = totalPrice - (totalPrice * 0.10);
    } else if (numberOfFlowers > 90 && flower == "Dahlias") {
        totalPrice = totalPrice - (totalPrice * 0.15);
    } else if (numberOfFlowers > 80 && flower == "Tulips") {
        totalPrice = totalPrice - (totalPrice * 0.15);
    } else if (numberOfFlowers < 120 && flower == "Narcissus") {
        totalPrice = totalPrice + (totalPrice * 0.15);
    } else if (numberOfFlowers < 80 && flower == "Gladiolus") {
        totalPrice = totalPrice + (totalPrice * 0.20);
    }

    if (totalPrice > budget) {
        console.log(`Not enough money, you need ${(totalPrice - budget).toFixed(2)} leva more.`);
    } else {
        console.log(`Hey, you have a great garden with ${numberOfFlowers} ${flower} and ${(budget - totalPrice).toFixed(2)} leva left.`);
    }
}

solve(['Roses',55,250]);