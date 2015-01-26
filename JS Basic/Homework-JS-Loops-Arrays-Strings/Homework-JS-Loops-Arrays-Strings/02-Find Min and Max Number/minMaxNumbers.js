(function () {
    function findMinAndMax(value) {
        function compareNumbers(a, b) {
            return a - b;
        }
        value.sort(compareNumbers);
        
        return 'Min -> ' + value[0] + '\nMax -> ' + value[value.length - 1];
    };

    console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
    console.log(findMinAndMax([2, 2, 2, 2, 2]));
    console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));
}());