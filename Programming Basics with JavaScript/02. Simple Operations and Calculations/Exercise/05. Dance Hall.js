function solve(input) {
    let length = Number(input.shift());
    let width = Number(input.shift());
    let side = Number(input.shift());

    let hallSize = (length * 100) * (width * 100);
    let wardrobeSize = (side * 100) * (side * 100);
    let benchSize = hallSize / 10;
    let freeSpace = hallSize - wardrobeSize - benchSize;
    let dancers = Math.floor(freeSpace / (40 + 7000));

    console.log(dancers);
}

solve([50,25,2]);