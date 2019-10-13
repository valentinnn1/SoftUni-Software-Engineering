class CheckingAccount {
    constructor(clientId, email, firstName, lastName) {
        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
    }
    get clientId() {
        return this._clientId;
    }
    set clientId(clientId) {
        let lengthValidation = clientId.toString().length === 6;
        if (lengthValidation && Number.isInteger(+clientId)) {
            return this._clientId = clientId;
        }
        throw new TypeError('Client ID must be a 6-digit number');
    }
    get email() {
        return this._email;
    }
    set email(email) {
        let pattern = /[A-Za-z0-9]+@[A-Za-z0-9\.]+/g;
        if (!pattern.test(email)) {
            throw new TypeError('Invalid e-mail');
        }
        return this._email = email;
    }
    get firstName() {
        return this._firstname
    }
    set firstName(firstName) {
        if (firstName.length < 3 || firstName.length > 20) {
            throw new TypeError('First name must be between 3 and 20 characters long');
        } else if (!/[A-Za-z]{3,20}/g.test(firstName)) {
            throw new TypeError('First name must contain only Latin characters');
        }
        return this._firstname = firstName;
    }
    get lastName() {
        return this._firstname
    }
    set lastName(lastName) {
        if (lastName.length < 3 || lastName.length > 20) {
            throw new TypeError('Last name must be between 3 and 20 characters long');
        } else if (!/[A-Za-z]{3,20}/g.test(lastName)) {
            throw new TypeError('Last name must contain only Latin characters');
        }
        return this._lastName = lastName;
    }
}
let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')

console.log(acc.email);