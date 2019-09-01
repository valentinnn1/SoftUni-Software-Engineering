function solve(input) {
    let widthCake = Number(input.shift());
    let lengthCake = Number(input.shift());
    let wholeCake = widthCake * lengthCake;
    while (wholeCake >= 0) {
        let taken = input.shift();
        if (taken == "STOP") {
            console.log(`${wholeCake} pieces are left.`);
            return;
        }
        wholeCake = wholeCake - Number(taken);
    }
    console.log(`No more cake left! You need ${Math.abs(wholeCake)} pieces more.`);
}

solve([10, 10, 20, 20, 20, 20, 21]);