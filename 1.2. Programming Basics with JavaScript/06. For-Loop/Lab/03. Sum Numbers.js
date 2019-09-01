function solve(input) {
    let number = Number(input.shift());
    let sum = 0;

    for (let i = 0; i < number; i++) {
        let singleNumber = Number(input.shift());
        sum += singleNumber;
    }
    console.log(sum);
}

solve([2, 10, 20]);