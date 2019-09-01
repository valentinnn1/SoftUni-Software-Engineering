function solve(input) {
    let month = input.shift();
    let numberOfNights = Number(input.shift());

    let priceApart = 0.0;
    let priceStudio = 0.0;

    switch (month) {
        case "May":
        case "October":

            if (numberOfNights > 14) {
                priceApart = numberOfNights * 65.0 * 0.9;
                priceStudio = numberOfNights * 50.0 * 0.7;
            } else if (numberOfNights > 7) {
                priceStudio = numberOfNights * 50.0 * 0.95;
                priceApart = numberOfNights * 65.0;
            } else {
                priceApart = numberOfNights * 65.0;
                priceStudio = numberOfNights * 50.0;
            }
            break;

        case "June":
        case "September":
            if (numberOfNights > 14) {
                priceApart = numberOfNights * 68.70 * 0.9;
                priceStudio = numberOfNights * 75.20 * 0.8;
            } else {
                priceApart = numberOfNights * 68.70;
                priceStudio = numberOfNights * 75.20;
            }
            break;

        case "July":
        case "August":
            priceStudio = numberOfNights * 76.0;

            if (numberOfNights > 14) {
                priceApart = numberOfNights * 77 * 0.9;
            } else {
                priceApart = numberOfNights * 77.0;
            }
            break;
    }

    console.log(`Apartment: ${priceApart.toFixed(2)} lv.`);
    console.log(`Studio: ${priceStudio.toFixed(2)} lv.`);
}

solve(['May', 15]);