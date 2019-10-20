// 85/100

class Library {
  constructor(libraryName) {
    this.libraryName = libraryName;
    this.subscribers = [];

    this.normalCount = this.libraryName.length;
    this.specialCount = this.libraryName.length * 2;
    this.vipCount = Number.MAX_SAFE_INTEGER;
    this.subscriptionTypes = {
      normal: this.normalCount,
      special: this.specialCount,
      vip: this.vipCount
    };
  }

  subscribe(name, type) {
    if (!this.subscriptionTypes[type]) {
      throw new Error(`The type ${type} is invalid`);
    }
    if (!this.subscribers.find(x => x.name === name)) {
      this.subscribers.push({ name, type, books: [] });
      return this.subscribers[this.subscribers.length - 1];
    } else {
      let found = this.subscribers.find(x => x.name === name);
      found.type = type;
      return found;
    }
  }

  unsubscribe(name) {
    if (!this.subscribers.find(x => x.name === name)) {
      throw new Error(`There is no such subscriber as ${name}`);
    }
    const foundIndex = this.subscribers.findIndex(x => x.name === name);
    this.subscribers.splice(foundIndex, 1);
    return this.subscribers;
  }
  //tuk mai ima test, mezhdu dvata metoda; proverka
  receiveBook(subscriberName, bookTitle, bookAuthor) {
    if (!this.subscribers.find(x => x.name === subscriberName)) {
      throw new Error(`There is no such subscriber as ${name}`);
    }
    let subscriber = this.subscribers.find(x => x.name === subscriberName);

    const limit = this.subscriptionTypes[subscriber.type];
    if (subscriber.books.length >= limit) {
      throw new Error(`You have reached your subscription limit ${limit}!`);
    }
    subscriber.books.push({ title: bookTitle, author: bookAuthor });

    return subscriber;
  }

  showInfo() {
    if (this.subscribers.length === 0) {
      return `${this.libraryName} has no information about any subscribers`;
    }
    let outputStr = "";
    this.subscribers.forEach(el => {
      outputStr += `Subscriber: ${el.name}, Type: ${el.type}\n`;
      outputStr += `Received books: `;

      el.books.forEach(e => {
        outputStr += `${e.title} by ${e.author}, `;
      });
    });
    return (outputStr = outputStr.slice(0, outputStr.length - 2));
  }
}
let lib = new Library("Lib");

console.log(lib.subscribe("Peter", "normal"));
console.log(lib.subscribe("John", "special"));

console.log(
  lib.receiveBook("John", "A Song of Ice and Fire", "George R. R. Martin")
);
console.log(lib.receiveBook("Peter", "Lord of the rings", "J. R. R. Tolkien"));
console.log(lib.receiveBook("John", "Harry Potter", "J. K. Rowling"));

console.log(lib.showInfo());
