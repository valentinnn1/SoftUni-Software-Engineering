function solve(input) {
    let firstNumber = Number(input[0]);
    let secondNumber = Number(input[1]);
    let result = "";

    for (let i = firstNumber; i <= secondNumber; i++) {
        let leftSum = 0;
        let rightSum = 0;
        let midSum = 0;

        let numAsString = i.toString();

        for (let j = 0; j <= numAsString.length - 1; j++) {
            let num = Number(numAsString[j]);

            switch (j) {
                case 0: leftSum += num; break;
                case 1: leftSum += num; break;
                case 2: midSum += num; break;
                case 3: rightSum += num; break;
                case 4: rightSum += num; break;
            }
        }
        if (leftSum < rightSum) {
            leftSum += midSum;
        } else if (rightSum < leftSum) {
            rightSum += midSum;
        }

        if (leftSum == rightSum) {
            result += `${i} `;
        }
    }
    console.log(result);
}

solve([10000, 10100]);