(function () {
    function sortArray(value) {
        function compareNumbers(a, b) {
            return a - b;
        }
        value.sort(compareNumbers);

        return value;
    };

    console.log(sortArray([5, 4, 3, 2, 1]));
    console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));
    console.log(sortArray([500, 1, -23, 0, -300, 28, 35, 12]));
}());