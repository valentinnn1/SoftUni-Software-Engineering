function solve(input) {
    let animal = input.shift();
    switch (animal) {
        case "dog": console.log("mammal"); break;
        case "crocodile","tortoise","snake": console.log("reptile"); break;
        default: console.log("unknown"); break;
    }
}

solve(["snake"]);