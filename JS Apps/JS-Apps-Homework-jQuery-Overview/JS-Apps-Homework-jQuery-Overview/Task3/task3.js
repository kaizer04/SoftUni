$(function () {
    var cars = [{ "manufacturer": "BMW", "model": "E92 320i", "year": 2011, "price": 50000, "class": "Family" },
    { "manufacturer": "Porsche", "model": "Panamera", "year": 2012, "price": 100000, "class": "Sport" },
    { "manufacturer": "Peugeot", "model": "305", "year": 1978, "price": 1000, "class": "Family" }],

    $wrapper = $('#wrapper'),
    table = $('<table />').addClass('table');
    $wrapper.append(table);

    var headRow = $('<tr></tr>').css('background', 'green');
    table.append(headRow);

    for (var carProp in cars[0]) {
        var currHead = $('<th></th>');
        currHead.text(carProp);
        headRow.append(currHead);
    }

    cars.forEach(function (element) {
        var car = element;
        var $row = $('<tr />');
        $row.append($('<td />').html(car.manufacturer));
        $row.append($('<td />').html(car.model));
        $row.append($('<td />').html(car.year));
        $row.append($('<td />').html(car.price));
        $row.append($('<td />').html(car.class));
        table.append($row);
    })
})