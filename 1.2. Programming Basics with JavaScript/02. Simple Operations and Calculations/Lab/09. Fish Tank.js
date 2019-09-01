function solve(input) {
    let length = Number(input.shift());
    let width = Number(input.shift());
    let height = Number(input.shift());
    let percentage = Number(input.shift());
    
    let volume = length * width * height;
    let totalLiters = volume * 0.001;
    let result = totalLiters * (1 - percentage * 0.01);
    console.log(result.toFixed(3));
}

solve([85,75,47,17]);