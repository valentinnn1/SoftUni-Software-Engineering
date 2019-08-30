function solve(input) {
    let days = Number(input.shift());
    let confectioners = Number(input.shift());
    let cakesCount = Number(input.shift());
    let gofretiCount = Number(input.shift());
    let pancakesCount = Number(input.shift());

    let cakesPrice = cakesCount * 45;
    let gofretiPrice = gofretiCount * 5.80;
    let pancakesPrice = pancakesCount * 3.20;
    let totalPriceFor1Day = (cakesPrice + gofretiPrice + pancakesPrice) * confectioners;
    let moneyFromPeople = totalPriceFor1Day * days;
    let finalResult = moneyFromPeople - (moneyFromPeople / 8);
    console.log(finalResult.toFixed(2));
}

solve([131,5,9,33,46]);