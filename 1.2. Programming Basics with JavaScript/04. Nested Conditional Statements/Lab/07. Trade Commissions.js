function solve(input) {
    let town = input.shift();
    let sales = Number(input.shift());

    let commission = -1.0;

    if (town == "Sofia") {
        if (0 <= sales && sales <= 500) {
            commission = 0.05;
        } else if (500 < sales && sales <= 1000) {
            commission = 0.07;
        } else if (1000 < sales && sales <= 10000) {
            commission = 0.08;
        } else if (sales > 10000) {
            commission = 0.12;
        }
    } else if (town == "Varna") {
        if (0 <= sales && sales <= 500) {
            commission = 0.045;
        } else if (500 < sales && sales <= 1000) {
            commission = 0.075;
        } else if (1000 < sales && sales <= 10000) {
            commission = 0.1;
        } else if (sales > 10000) {
            commission = 0.13;
        }
    } else if (town == "Plovdiv") {
        if (0 <= sales && sales <= 500) {
            commission = 0.055;
        } else if (500 < sales && sales <= 1000) {
            commission = 0.08;
        } else if (1000 < sales && sales <= 10000) {
            commission = 0.12;
        } else if (sales > 10000) {
            commission = 0.145;
        }
    }

    if (sales > 0 && commission > 0) {
        console.log(`${(commission * sales).toFixed(2)}`);
    } else {
        console.log("error");
    }
}

solve(['Sofia', 1500]);