function solve(input) {
    let degrees = Number(input.shift());
    let typeOfDay = input.shift();
    let outfit = "";
    let shoes = "";

    if (typeOfDay == "Morning") {
        if (10 <= degrees && degrees <= 18) {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        } else if (18 < degrees && degrees <= 24) {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (degrees >= 25) {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
    } else if (typeOfDay == "Afternoon") {
        if (10 <= degrees && degrees <= 18) {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (18 < degrees && degrees <= 24) {
            outfit = "T-Shirt";
            shoes = "Sandals";
        } else if (degrees >= 25) {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        }
    } else if (typeOfDay == "Evening") {
        if (10 <= degrees && degrees <= 18) {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (18 < degrees && degrees <= 24) {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (degrees >= 25) {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }

    console.log(`It's ${degrees} degrees, get your ${outfit} and ${shoes}.`);
}

solve([16, 'Morning']);