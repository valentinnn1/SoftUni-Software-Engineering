function solve(num) {
    let result = "";
    for (let i = 0; i < num; i++) {
        for (let i = 0; i < num; i++) {
            result += '* ';
        }
        console.log(result);
        result = "";
    }
}

solve(3);