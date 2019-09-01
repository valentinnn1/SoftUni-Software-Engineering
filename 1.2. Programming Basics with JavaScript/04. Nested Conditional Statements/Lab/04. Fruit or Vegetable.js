function solve(input) {
    let word = input.shift();

    if (word == "banana" || word == "apple" || word == "kiwi" || word == "cherry" || word == "lemon" || word == "grapes") {
        console.log("fruit");
    } else if (word == "tomato" || word == "cucumber" || word == "pepper" || word == "carrot") {
        console.log("vegetable");
    } else {
        console.log("unknown");
    }
}

solve(['apple']);