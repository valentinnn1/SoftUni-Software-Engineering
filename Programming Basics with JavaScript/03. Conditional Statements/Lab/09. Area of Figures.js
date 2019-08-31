function solve(input) {
    let figure = input.shift();

    if (figure == "square") {
        let side = Number(input.shift());
        console.log((side * side).toFixed(3));
    } else if (figure == "rectangle") {
        let side1 = Number(input.shift());
        let side2 = Number(input.shift());
        console.log((side1 * side2).toFixed(3));
    } else if (figure == "circle") {
        let r = Number(input.shift());
        console.log((Math.PI * r * r).toFixed(3));
    } else if (figure == "triangle") {
        let side = Number(input.shift());
        let h = Number(input.shift());
        console.log((side * h / 2).toFixed(3));
    }
}

solve(["rectangle",7,2.5]);