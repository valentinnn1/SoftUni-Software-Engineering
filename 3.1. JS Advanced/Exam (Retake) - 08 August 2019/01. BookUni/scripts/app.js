function solve() {
    const inputArr = document.getElementsByTagName('input');
    const btn = document.getElementsByTagName('button')[0];
    const profit = document.querySelector('body > h1:nth-child(3)');
    let sum = 0;

    btn.addEventListener('click', add);

    function add(ev) {
        ev.preventDefault();

        const book = inputArr[0].value;
        const year = +inputArr[1].value;
        let price = +inputArr[2].value;

        if (book !== '' && typeof book === 'string' && year >= 0 && price >= 0) {
            price = price.toFixed(2);

            if (year >= 2000) {
                createBook(book, year, price, 'new');
            } else {
                createBook(book, year, price, 'old');
            }
        }
    }

    function createBook(book, year, price, type) {

        let div = document.createElement('div');
        div.setAttribute('class', 'book');

        let p = document.createElement('p');
        p.textContent = `${book} [${year}]`;
        div.appendChild(p);

        let button = document.createElement('button');
        button.textContent = `Buy it only for ${price} BGN`;
        button.addEventListener('click', remove);
        div.appendChild(button);

        if (type === 'new') {
            let moveBtn = document.createElement('button');
            moveBtn.textContent = 'Move to old section';
            moveBtn.addEventListener('click', move);
            div.appendChild(moveBtn);

            document.querySelector('#outputs > section:nth-child(2) > div').appendChild(div);
        } else {
            price = makeDiscount(price, 15);
            button.textContent = `Buy it only for ${price} BGN`;
            document.querySelector('#outputs > section:nth-child(1) > div').appendChild(div);
        }
    }

    function remove(ev) {
        let text = ev.target.parentNode.children[1].textContent;
        let price = Number(text.replace('Buy it only for ', '').replace(' BGN', ''));
        sum += price
        profit.textContent = `Total Store Profit: ${sum.toFixed(2)} BGN`;
        ev.target.parentNode.remove();
    }

    function move(ev) {

        let text = ev.target.parentNode.children[1].textContent;
        let price = Number(text.replace('Buy it only for ', '').replace(' BGN', ''));
        price = makeDiscount(price, 15);
        ev.target.parentNode.children[1].textContent = `Buy it only for ${price.toFixed(2)} BGN`;

        document.querySelector('#outputs > section:nth-child(1) > div').appendChild(ev.target.parentNode);

        ev.target.parentNode.children[2].remove();
    }

    function makeDiscount(price, num) {
        return price * (1 - num / 100);
    }
}