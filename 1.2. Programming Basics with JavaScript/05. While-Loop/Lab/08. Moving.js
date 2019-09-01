function solve(input) {
    let w = Number(input.shift());
    let l = Number(input.shift());
    let h = Number(input.shift());
    let totalCubicMeters = 0;
    let cubicMeters = w * l * h;

    while (true) {
        let command = input.shift();
        if (command == "Done") {
            break;
        }
        let boxesCubicMeters = Number(command);
        totalCubicMeters += boxesCubicMeters;

        let diff = cubicMeters - totalCubicMeters;

        if (diff < 0) {
            console.log(`No more free space! You need ${Math.abs(diff)} Cubic meters more.`); return;
        }
    }
    console.log(`${cubicMeters - totalCubicMeters} Cubic meters left.`);
}

solve([10, 10, 2, 20, 20, 20, 20, 122]);