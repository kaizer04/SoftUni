(function () {
    function displayProperties(value) {
        var properties = [];
        for (var prop in value) {
            properties.push(prop);
        }

        properties.sort();

        console.log(properties.join('\n'));
    }
    displayProperties(window);
}());