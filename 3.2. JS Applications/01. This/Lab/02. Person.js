class Person {
  constructor(first, last) {
    this.firstName = first;
    this.lastName = last;
  }

  get firstName() {
    return this._first;
  }
  set firstName(first) {
    return (this._first = first);
  }
  get lastName() {
    return this._last;
  }
  set lastName(last) {
    return (this._last = last);
  }
  get fullName() {
    return `${this._first} ${this._last}`;
  }
  set fullName(full) {
    let names = full.split(" ");
    if (names.length === 2) {
      this.firstName = names[0];
      this.lastName = names[1];
    }
  }
}
let person = new Person("Peter", "Ivanov");
console.log(person.fullName); //Peter Ivanov
person.firstName = "George";
console.log(person.fullName); //George Ivanov
person.lastName = "Peterson";
console.log(person.fullName); //George Peterson
person.fullName = "Nikola Tesla";
console.log(person.firstName); //Nikola
console.log(person.lastName); //Tesla
