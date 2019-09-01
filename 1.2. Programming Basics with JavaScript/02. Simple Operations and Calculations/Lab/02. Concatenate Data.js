function concatanate(input) {
    let firstName = input.shift();
    let lastName = input.shift();
    let age = Number(input.shift());
    let city = input.shift();
    console.log(`You are ${firstName} ${lastName}, a ${age}-years old person from ${city}.`);
}

concatanate(['Maria', 'Ivanova', 20, 'Sofia']);