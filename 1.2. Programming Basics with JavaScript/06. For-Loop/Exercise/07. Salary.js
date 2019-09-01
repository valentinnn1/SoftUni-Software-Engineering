function solve(input) {
    let tabs = Number(input.shift());
    let salary = Number(input.shift());

    for (let i = 0; i < tabs; i++) {
        let site = input.shift();

        if (site == "Facebook") {
            salary -= 150;
        }
        else if (site == "Instagram") {
            salary -= 100;
        }
        else if (site == "Reddit") {
            salary -= 50;
        }

        if (salary <= 0) {
            console.log("You have lost your salary.");
            return;
        }
    }
    console.log(salary);
}

solve([3, 500, 'Github.com', 'Stackoverflow.com', 'softuni.bg']);