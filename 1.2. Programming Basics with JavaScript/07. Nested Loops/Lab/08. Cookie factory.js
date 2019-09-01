function solve(input) {
    let counts = Number(input.shift());
    let command = "";
    let hasFlour = false;
    let hasEggs = false;
    let hasSugar = false;
    let i = 1;

    while (counts > 0) {
        command = input.shift();

        switch (command) {
            case "flour":
                hasFlour = true;
                break;
            case "eggs":
                hasEggs = true;
                break;
            case "sugar":
                hasSugar = true;
                break;
        }

        if (command == "Bake!") {
            if (hasFlour && hasEggs && hasSugar) {
                console.log(`Baking batch number ${i}...`);
                counts--;
                i++;
                hasFlour = hasEggs = hasSugar = false;
            } else {
                console.log("The batter should contain flour, eggs and sugar!");
            }
        }
    }
}

solve([2, 'flour', 'eggs', 'sugar', 'chocolate', 'Bake!', 'flour', 'eggs', 'sugar', 'caramel', 'peanuts', 'Bake!']);