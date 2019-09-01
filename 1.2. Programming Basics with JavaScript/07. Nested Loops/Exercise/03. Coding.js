function solve(input) {
    let stringNum = input[0];

    for (let i = stringNum.length - 1; i >= 0; i--) {
        let currDigitToNum = Number(stringNum[i]);
        if (currDigitToNum == 0) {
            console.log("ZERO"); continue;
        }
        let printLine = "";
        for (let n = 1; n <= currDigitToNum; n++) {
            printLine += String.fromCharCode(currDigitToNum + 33);
        }
        console.log(printLine);
    }
}

solve(['2049']);