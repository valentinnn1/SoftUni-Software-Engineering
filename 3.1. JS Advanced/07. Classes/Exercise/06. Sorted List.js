class List {
    constructor() {
        this.listArr = [];
        this.size = 0;
    }
    sort(listArr) {
        return this.listArr = listArr.sort((a, b) => a - b);
    }
    add(element) {
        this.listArr.push(element);
        this.size++;
        return this.sort(this.listArr);
    }
    remove(index) {
        if (index >= 0 && index < this.size) {
            this.size--;
            return this.listArr.splice(index, 1);
        }
    }
    get(index) {
        if (index >= 0 && index < this.size) {
            return this.listArr[index];
        }
    }
}
let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));

let myList = new result();
console.log(result.size());
// console.log(myList.hasOwnProperty('size'))