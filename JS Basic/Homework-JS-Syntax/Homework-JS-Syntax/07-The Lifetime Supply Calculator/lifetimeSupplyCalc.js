(function () {
    function calcSupply(age, max_age, amount) {
        var food = ['chocolate', 'fruits', 'nuts', 'meat', 'blood'];

        var kg = ((max_age - age) * 365) * amount;

        var rnd = Math.floor(Math.random() * food.length);

        console.log(kg + 'kg of ' + food[rnd] + ' would be enough until I am ' + max_age + ' years old.');
    }

    calcSupply(38, 118, 0.5);
    calcSupply(20, 87, 2);
    calcSupply(16, 102, 1.1);
}());