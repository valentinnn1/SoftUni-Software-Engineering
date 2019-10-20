const BookStore = require("../index.js");

const expect = require("chai").expect;

describe("testing the class BookStore", function() {
  let bs;
  beforeEach(function() {
    bs = new BookStore("Boogy");
  });
  describe("testing the name property in the constructor", function() {
    it("testing constructor of the class BookStore with string", function() {
      let expected = bs.name;
      expect(expected).to.equal("Boogy");
    });
    it("testing constructor of the class BookStore with obj", function() {
      bs = new BookStore({ a: "a" });
      let expected = bs.name;
      expect(expected).to.deep.equal({ a: "a" });
    });
    it("testing the property workers, need to be empty arr", function() {
      let expected = bs.workers.length;
      expect(expected).to.equal(0);
      expect(Array.isArray(bs.workers)).to.be.true;
    });
    it("testing the property books, need to be empty arr", function() {
      let expected = bs.books.length;
      expect(expected).to.equal(0);
      expect(Array.isArray(bs.books)).to.be.true;
    });
  });
  describe("testing the methods", function() {
    it("check if the methods are attached to the proto", function() {
      expect(typeof BookStore.prototype.stockBooks === "function").to.be.true;
      expect(typeof BookStore.prototype.hire === "function").to.be.true;
      expect(typeof BookStore.prototype.fire === "function").to.be.true;
      expect(typeof BookStore.prototype.sellBook === "function").to.be.true;
      expect(typeof BookStore.prototype.printWorkers === "function").to.be.true;
    });
    it("testing the stockBook method with correct params", function() {
      let expected = bs.stockBooks(["a-b"]);
      expect(expected).to.deep.equal([{ author: "b", title: "a" }]);
    });
    it("testing the stockBook method with more elements", function() {
      let expected = bs.stockBooks(["a-b", "c-d"]);
      expect(expected).to.deep.equal([
        { author: "b", title: "a" },
        { author: "d", title: "c" }
      ]);
    });
    it("testing if the books are stored in the books property with the stockBook method", function() {
      bs.stockBooks(["a-b", "c-d"]);
      let expected = bs.books.length;
      expect(expected).to.equal(2);
    });
    //to test the split in stockBook

    it("testing the hire method with two correct params", function() {
      let expected = bs.hire("Pesho", "gradinar");
      expect(expected).to.equal("Pesho started work at Boogy as gradinar");
    });
    it("testing the hire method with already hired worker should throw", function() {
      bs.hire("Pesho", "gradinar");
      let expected = () => {
        bs.hire("Pesho", "chistach");
      };
      expect(expected).to.throw(Error, "This person is our employee");
    });
    it("testing if the hire method adds worker in workersArr", function() {
      bs.hire("Pesho", "gradinar");
      let expected = bs.workers.length;
      expect(expected).to.equal(1);
    });
    it("testing if the hire method adds worker in workersArr with correct properties", function() {
      bs.hire("Pesho", "gradinar");
      expect(bs.workers[0]).to.has.property("name");
      expect(bs.workers[0]).to.has.property("position");
      expect(bs.workers[0]).to.has.property("booksSold");
    });
    it("testing the fire method with non existing worker should throw", function() {
      let expected = () => {
        bs.fire("Pesho");
      };
      expect(expected).to.throw(Error, `Pesho doesn't work here`);
    });
    it("testing if the hire method removes worker in workersArr", function() {
      bs.hire("Pesho", "gradinar");
      bs.hire("Gosho", "chistach");
      bs.fire("Pesho");
      let expected = bs.workers;
      expect(bs.workers.length).to.equal(1);
      expect(expected).to.deep.equal([
        { name: "Gosho", position: "chistach", booksSold: 0 }
      ]);
    });
    it("testing the fire method with existing worker should fire him", function() {
      bs.hire("Pesho", "gradinar");
      let expected = bs.fire("Pesho");
      expect(expected).to.equal(`Pesho is fired`);
    });
    it("testing the sellBook method with correct params", function() {
      bs.hire("Pesho", "gradinar");
      bs.stockBooks(["kniga-b", "c-d"]);
      bs.sellBook("kniga", "Pesho");
      expect(bs.books.length).to.equal(1);
      expect(bs.workers[0].booksSold).to.equal(1);
    });
    it("testing the sellBook method with non existing worker should throw", function() {
      bs.stockBooks(["kniga-b", "c-d"]);
      let expected = () => {
        bs.sellBook("kniga", "Pesho");
      };
      expect(expected).to.throw(Error, "Pesho is not working here");
    });
    it("testing the sellBook method with non existing book should throw", function() {
      bs.hire("Pesho", "gradinar");
      bs.stockBooks(["a-b", "c-d"]);
      let expected = () => {
        bs.sellBook("kniga", "Pesho");
      };
      expect(expected).to.throw(Error, "This book is out of stock");
    });
    it("testing the printWorkers method", function() {
      bs.hire("Pesho", "gradinar");
      let expected = bs.printWorkers();
      expect(expected).to.equal("Name:Pesho Position:gradinar BooksSold:0");
    });
  });
});
