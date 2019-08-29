function solve(input) {
    let name = input.shift();
    let projectCount = Number(input.shift());
    let neededHours = 3 * projectCount;
    console.log(`The architect ${name} will need ${neededHours} hours to complete ${projectCount} project/s.`);
}

solve(['George', 4]);