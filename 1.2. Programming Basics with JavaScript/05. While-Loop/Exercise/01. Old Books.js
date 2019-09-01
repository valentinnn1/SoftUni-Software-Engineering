function solve(input) {
    let book = input.shift();
    let capacity = Number(input.shift());
    let bookCount = 0;
    let foundTheBook = false;

    while (true) {
        let inputBook = input.shift();
        if (inputBook == book) {
            foundTheBook = true;
            break;
        }
        bookCount++;
        if (bookCount == capacity) {
            break;
        }
    }
    if (foundTheBook == true) {
        console.log(`You checked ${bookCount} books and found it.`);
    }
    else {
        console.log(`The book you search is not here!`);
        console.log(`You checked ${bookCount} books.`);
    }
}

solve(['The Spot', 4, 'Hunger Games', 'Harry Potter', 'Torronto', 'Spotify']);