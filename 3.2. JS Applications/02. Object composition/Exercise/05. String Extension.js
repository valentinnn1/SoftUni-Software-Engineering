(function () {
    String.prototype.ensureStart = function (str) {

        if (this.valueOf().startsWith(str)) {
            return this.valueOf();
        }

        return str + this.valueOf();
    };

    String.prototype.ensureEnd = function (str) {

        if (this.valueOf().endsWith(str)) {
            return this.valueOf();
        }

        return this.valueOf() + str;
    };

    String.prototype.isEmpty = function () {
        let isEmpty = this.valueOf().length === 0;
        return isEmpty;
    };

    String.prototype.truncate = function (num) {

        if (num < 4) {
            return '.'.repeat(num);
        }

        if (num >= this.valueOf().length) {
            return this.valueOf();
        }

        let lastIndex = this.valueOf().lastIndexOf(' ');

        if (lastIndex === -1) {
            return this.valueOf().slice(0, num - 3) + '...';

        }

        let splited = this.valueOf().split(/ /);
        let text = '';

        for (let index = 0; index < splited.length; index++) {

            let element = splited[index];

            if (text.length + element.length + 3 > num) {
                break;
            }

            text += element + ' ';
        }

        return text.trim() + '...';
    };

    String.format = function (text, ...params) {

        for (let index = 0; index < params.length; index++) {
            let element = params[index];
            let pattern = `{${index}}`;
            text = text.replace(pattern, element);
        }

        return text;
    };
})();