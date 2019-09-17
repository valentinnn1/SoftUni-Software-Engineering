function solve(arg1, arg2, arg3) {
    let sumLength;
    let avgLength;
    let arg1Length = arg1.length;
    let arg2Length = arg2.length;
    let arg3Length = arg3.length;

    sumLength = arg1Length + arg2Length + arg3Length;
    avgLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(avgLength);
}

solve('chocolate', 'ice cream', 'cake');