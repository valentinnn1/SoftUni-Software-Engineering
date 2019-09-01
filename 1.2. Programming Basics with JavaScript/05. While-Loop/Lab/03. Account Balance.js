function solve(input) {
    let n = Number(input.shift());
    let i = 0;
    let balance = 0.0;

    while (i < n) {
        let amount = Number(input.shift());
        if (amount < 0) {
            console.log("Invalid operation!"); 
            console.log(`Total: ${balance.toFixed(2)}`); return;
        }
        console.log(`Increase: ${amount.toFixed(2)}`);
        balance += amount;
        i++;
    }
    console.log(`Total: ${balance.toFixed(2)}`);
}

solve([3, 5.51, 69.42, 100]);