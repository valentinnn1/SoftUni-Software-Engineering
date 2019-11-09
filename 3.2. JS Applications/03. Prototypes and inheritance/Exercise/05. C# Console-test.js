const expect = require('chai').expect;
const Console = require('./05. C# Console');

describe('testing the Console class', function () {
    it('test the class standart', function () {
        let expected = Console.writeLine('a');
        expect(expected).to.be.equal('a');
    });
    it('test the class standart with placeholder', function () {
        let expected = Console.writeLine('a {0}', 1);
        expect(expected).to.be.equal('a 1');
    });
    it('test the class standart with object', function () {
        let expected = Console.writeLine({ a: 1 });
        expect(expected).to.be.equal(JSON.stringify({ a: 1 }));
    });
    it('test the class standart with non-string first param ', function () {
        let expected = () => {
            Console.writeLine(1, 1);
        }
        expect(expected).to.throw(TypeError);
    });
    it('test the class standart with more parameters, than placeholders', function () {
        let expected = () => {
            Console.writeLine('a {0}', '1', '2');
        }
        expect(expected).to.throw(RangeError);
    });
    it('test the class standart with placeholder, which is greater than the params', function () {
        let expected = () => {
            Console.writeLine('a {5}', '1', '2');
        }
        expect(expected).to.throw(RangeError);
    });
    it('test the class standart with placeholder', function () {
        let expected = Console.writeLine('a {0}{1}', 1, 2);
        expect(expected).to.be.equal('a 12');
    });
    it('test the class standart with placeholder', function () {
        let expected = Console.writeLine('a {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}', 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11);
        expect(expected).to.be.equal('a 1234567891011');
    });
});