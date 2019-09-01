function solve(input) {
    let N1 = Number(input.shift());
    let N2 = Number(input.shift());
    let operation = input.shift();

    let result = 0;

    if (operation == "+") {
        result = N1 + N2;
        if (result % 2 != 0) {
            console.log(`${N1} + ${N2} = ${result} - odd`);
        } else if (result % 2 == 0) {
            console.log(`${N1} + ${N2} = ${result} - even`);
        }
    } else if (operation == "-") {
        result = N1 - N2;
        if (result % 2 == 0) {
            console.log(`${N1} - ${N2} = ${result} - even`);
        } else if (result % 2 != 0) {
            console.log(`${N1} - ${N2} = ${result} - odd`);
        }
    } else if (operation == "*") {
        result = N1 * N2;

        if (result % 2 == 0) {
            console.log(`${N1} * ${N2} = ${result} - even`);
        } else if (result % 2 != 0) {
            console.log(`${N1} * ${N2} = ${result} - odd`);
        }
    } else if (operation == "/") {
        result = N1 / N2;
        Math.round(result);
        if (N2 == 0) {
            console.log(`Cannot divide ${N1} by zero`);
        } else {
            console.log(`${N1} / ${N2} = ${result.toFixed(2)} `);
        }
    } else if (operation == "%") {
        result = N1 % N2;
        if (N2 == 0) {
            console.log(`Cannot divide ${N1} by zero`);
        } else {
            console.log(`${N1} % ${N2} = ${result} `);
        }
    }
}

solve([123, 12, '/']);