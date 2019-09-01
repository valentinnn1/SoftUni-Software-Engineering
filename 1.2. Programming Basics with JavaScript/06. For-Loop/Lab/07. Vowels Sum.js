function solve(input) {
    let inputString = input.shift();
    let sum = 0;
    for (let i = 0; i < inputString.length; i++)
    {
        switch (inputString[i])
        {
            case 'a': sum += 1; break;
            case 'e': sum += 2; break;
            case 'i': sum += 3; break;
            case 'o': sum += 4; break;
            case 'u': sum += 5; break;
        }
    }
    console.log(sum);
}

solve(['bamboo']);