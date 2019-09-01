function solve(input) {
    let string1 = input.shift();
    let string2 = input.shift();
    string1 = string1.toLowerCase();
    string2 = string2.toLowerCase();
    if (string1 == string2) {
        console.log("yes");
    } else {
        console.log("no");
    }
}

solve(["SoftUni", "softuni"]);