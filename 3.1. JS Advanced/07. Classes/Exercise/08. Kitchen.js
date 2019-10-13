class Kitchen {
    constructor(budget) {
        this.budget = Number(budget) || 0;
        this.productsInStock = {};
        this.menu = {};
        this.actionsHistory = [];
    }
    get budget() {
        return this._budget;
    }
    set budget(budget) {
        return this._budget = Number(budget);
    }
    loadProducts(products) {
        let messageLog = []
        products.forEach(el => {
            let [product, quantity, price] = el.split(' ');
            price = Number(price);
            quantity = Number(quantity);
            if (price <= this.budget) {
                if (!this.productsInStock.hasOwnProperty(product)) {
                    this.productsInStock[product] = 0;
                }
                this.productsInStock[product] += quantity;
                this.budget -= price;
                messageLog.push(`Successfully loaded ${quantity} ${product}`);
            } else {
                messageLog.push(`There was not enough money to load ${quantity} ${product}`);
            }
        });
        this.actionsHistory = [...this.actionsHistory, ...messageLog];
        return this.actionsHistory.join('\n');
    }
    addToMenu(meal, neededProductsInput, price) {
        if (!this.menu[meal]) {
            this.menu[meal] = {
                neededProducts: {},
                price: Number(price),
            }
            neededProductsInput.forEach(el => {
                let [product, quantity] = el.split(' ');
                this.menu[meal].neededProducts[product] = Number(quantity);
            });
            let menuArr = Object.entries(this.menu);
            return `Great idea! Now with the ${meal} we have ${menuArr.length} meals in the menu, other ideas?`;
        } else {
            return `The ${meal} is already in our menu, try something different.`;
        }
    }
    showTheMenu() {
        let menuArr = [];
        for (const key in this.menu) {
            let currentMeal = key;
            let currentPrice = this.menu[key].price;
            menuArr.push(`${currentMeal} - $ ${currentPrice}`);
        }
        if (menuArr.length > 0) {
            return menuArr.join('\n') + '\n';
        } else {
            return `Our menu is not ready yet, please come later...`;
        }
    }
    makeTheOrder(meal) {
        if (!this.menu.hasOwnProperty(meal)) {
            return `There is not ${meal} yet in our menu, do you want to order something else?`
        } else {
            let productsWeNeed = this.menu[meal].neededProducts;

            for (const key in productsWeNeed) {
                if (productsWeNeed[key] > this.productsInStock[key]) {

                    return `For the time being, we cannot complete your order (${meal}), we are very sorry...`
                }
            }

            for (const key in productsWeNeed) {
                this.productsInStock[key] -= productsWeNeed[key];
            }
            let dollars = this.menu[meal].price;
            return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${dollars}.`
        }
    }
}
let kitchen = new Kitchen(1000);
console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));
console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));
console.log(kitchen.showTheMenu());
console.log(kitchen.makeTheOrder('Pizz'));