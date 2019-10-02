function solve(num) {
    return function(addend) {
        return num + addend;
    }
}

let add5 = solution(5);
console.log(add5(2));
console.log(add5(3));
