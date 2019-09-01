function solve(input) {
    let num = Number(input.shift());

    if ((num != 0) && ((num <= 99) || (num >= 201))) {
        console.log("invalid");
    }
}

solve([220]);