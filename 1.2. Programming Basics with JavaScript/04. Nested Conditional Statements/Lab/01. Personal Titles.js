function solve(input) {
    let age = Number(input.shift());
    let sex = input.shift()

    if (sex == "f") {
        if (age >= 16) {
            console.log("Ms.");
        } else {
            console.log("Miss");
        }
    } else {
        if (age >= 16) {
            console.log("Mr.");
        } else {
            console.log("Master");
        }
    }
}

solve([12, 'f']);