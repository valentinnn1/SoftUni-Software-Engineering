function solve(input) {
    let sqMeters = Number(input.shift());
    let price = sqMeters * 7.61;
    let discount = price * 0.18;
    let totalSum = price - discount;
    console.log(`The final price is: ${totalSum.toFixed(2)} lv.`);
    console.log(`The discount is: ${discount.toFixed(2)} lv.`);
}

solve([135]);