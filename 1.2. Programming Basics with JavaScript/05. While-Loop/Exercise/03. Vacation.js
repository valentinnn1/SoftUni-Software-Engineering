function solve(input) {
    let needed = Number(input.shift());
    let money = Number(input.shift());
    let spendcount = 0;
    let days = 0;

    while (true) {
        let action = input.shift();
        let amount = Number(input.shift());
        days++;
        switch (action) {
            case "spend":
                money -= amount; spendcount++;
                if (money < 0) {
                    money = 0;
                }
                break;
            case "save":
                money += amount; spendcount = 0;
                break;
        }
        if (spendcount == 5) {
            console.log(`You can't save the money.`);
            console.log(`${days}`);
            break;
        }
        else if (money >= needed) {
            console.log(`You saved the money for ${days} days.`);
            break;
        }
    }
}

solve([2000,1000,'spend',1200,'save',2000]);