function solve(input) {
    let projection = input.shift()
    let rows = Number(input.shift());
    let columns = Number(input.shift());
    let ticketPrice = 0;
    let chairs = rows * columns;

    if (projection == "Premiere") {
        ticketPrice = 12.00;
    } else if (projection == "Normal") {
        ticketPrice = 7.50;
    } else if (projection == "Discount") {
        ticketPrice = 5.00;
    }

    let totalPrice = ticketPrice * chairs;
    console.log(`${totalPrice.toFixed(2)} leva`);
}

solve(['Premiere',10,12]);