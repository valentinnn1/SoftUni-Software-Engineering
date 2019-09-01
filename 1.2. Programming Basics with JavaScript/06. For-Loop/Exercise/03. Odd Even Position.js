function solve(input) {
    let num = Number(input.shift());
    let oddSum = 0;
    let oddMax = Number.MIN_SAFE_INTEGER;
    let oddMin = Number.MAX_SAFE_INTEGER;
    let evenSum = 0;
    let evenMax = Number.MIN_SAFE_INTEGER;
    let evenMin = Number.MAX_SAFE_INTEGER;


    if (num == 0) {
        console.log(`OddSum=${num.toFixed(2)},`);
        console.log("OddMin=No,");
        console.log("OddMax=No,");
        console.log(`EvenSum=${num.toFixed(2)},`);
        console.log("EvenMin=No,");
        console.log("EvenMax=No");


    }
    else if (num == 1) {
        let curr = Number(input.shift());
        console.log(`OddSum=${curr.toFixed(2)},`);
        console.log(`OddMin=${curr.toFixed(2)},`);
        console.log(`OddMax=${curr.toFixed(2)},`);
        console.log("EvenSum=0.00,");
        console.log("EvenMin=No,");
        console.log("EvenMax=No");
    }
    else {
        for (let i = 1; i <= num; i++) {
            let curr = Number(input.shift());

            if (i % 2 != 0) {
                oddSum += curr;
                if (curr > oddMax) {
                    oddMax = curr;
                }
                if (curr < oddMin) {
                    oddMin = curr;
                }
            }
            else if (i % 2 == 0) {
                evenSum += curr;
                if (curr > evenMax) {
                    evenMax = curr;
                }
                if (curr < evenMin) {
                    evenMin = curr;
                }
            }
        }

        console.log(`OddSum=${oddSum.toFixed(2)},`);
        console.log(`OddMin=${oddMin.toFixed(2)},`);
        console.log(`OddMax=${oddMax.toFixed(2)},`);
        console.log(`EvenSum=${evenSum.toFixed(2)},`);
        console.log(`EvenMin=${evenMin.toFixed(2)},`);
        console.log(`EvenMax=${evenMax.toFixed(2)}`);
    }
}

solve([6, 2, 3, 5, 4, 2, 1]);