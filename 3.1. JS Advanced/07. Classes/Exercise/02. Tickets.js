function solve(input, sortCriteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }
    let outputArr = [];

    for (const ticket of input) {
        let [destination, price, status] = ticket.split('|');
        price = +price;
        outputArr.push(new Ticket(destination, price, status));
    }
    let sortedArr = outputArr.sort((a, b) => {
        if (a[sortCriteria] > b[sortCriteria]) {
            return 1
        } else if (a[sortCriteria] < b[sortCriteria]) {
            return -1
        }
        return 0;
    })
    return sortedArr;
}
console.log(solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'));