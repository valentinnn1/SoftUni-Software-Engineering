class Stringer {
    constructor(innerString , innerLength) {
        this.innerString  = innerString ;
        this.innerLength = innerLength;
    }
    decrease(length) {
        if (this.innerLength >= length) {
            return this.innerLength -= length
        }
        return this.innerLength = 0;
    }
    increase(length) {
        return this.innerLength += length;
    }
    toString() {
        let output = ''
        if (this.innerString.length <= this.innerLength) {
            output = this.innerString;
        } else {
            output = `${this.innerString.slice(0, this.innerLength)}...`;
        }
        return output;
    }
}
let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString()); // Test