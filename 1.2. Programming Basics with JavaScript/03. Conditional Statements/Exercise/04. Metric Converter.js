function solve(input) {
    let num = Number(input.shift());
    let fromUnit = input.shift();
    let toUnit = input.shift();

    if (fromUnit == "m" && toUnit == "cm") {
        console.log((num * 100).toFixed(3));
    } else if (fromUnit == "m" && toUnit == "mm") {
        console.log((num * 1000).toFixed(3));
    } else if (fromUnit == "cm" && toUnit == "m") {
        console.log((num / 100).toFixed(3));
    } else if (fromUnit == "cm" && toUnit == "mm") {
        console.log((num * 10).toFixed(3));
    } else if (fromUnit == "mm" && toUnit == "m") {
        console.log((num / 1000).toFixed(3));
    } else if (fromUnit == "mm" && toUnit == "cm") {
        console.log((num / 10).toFixed(3));
    }
}

solve([12, "mm", "m"]);