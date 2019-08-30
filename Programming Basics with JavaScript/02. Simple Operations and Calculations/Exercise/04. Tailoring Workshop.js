function solve(input) {
    let count = Number(input.shift());
    let length = Number(input.shift());
    let width = Number(input.shift());

    let area1 = count * (length + 2 * 0.30) * (width + 2 * 0.30);
    let area2 = count * (length / 2) * (length / 2);

    let priceUSD = area1 * 7 + area2 * 9;
    let priceBGN = priceUSD * 1.85;

    console.log(`${priceUSD.toFixed(2)} USD`);
    console.log(`${priceBGN.toFixed(2)} BGN`);
}

solve([10,1.20,0.65]);