function solve(input) {
    let budget = Number(input.shift());
    let season = input.shift();

    let destination = "";

    if (budget <= 100) {
        if (season == "summer") {
            let moneySpend = budget * 0.30;
            console.log("Somewhere in Bulgaria");
            console.log(`Camp - ${moneySpend.toFixed(2)}`);
        }
        else if (season == "winter")
        {
            let moneySpend = budget * 0.70;
            console.log("Somewhere in Bulgaria");
            console.log(`Hotel - ${moneySpend.toFixed(2)}`);
        }
    } else if (budget <= 1000) {
        if (season == "summer") {
            let moneySpend = budget * 0.40;
            console.log("Somewhere in Balkans");
            console.log(`Camp - ${moneySpend.toFixed(2)}`);
        } else if (season == "winter") {
            let moneySpend = budget * 0.80;
            console.log("Somewhere in Balkans");
            console.log(`Hotel - ${moneySpend.toFixed(2)}`);
        }
    } else if (budget > 1000 && season == "summer" || season == "winter") {
        let moneySpend = budget * 0.90;
        console.log("Somewhere in Europe");
        console.log(`Hotel - ${moneySpend.toFixed(2)}`);
    }
}

solve([312,'summer']);