(function () {
    function findMostFreqNum(value) {
        function compareNumbers(a, b) {
            return a - b;
        }
        
        var count = 1;
        var mostFreqNumber = value[0];
        var maxCount = 1;

        value.sort(compareNumbers);

        for (var i = 1; i < value.length; i++) {
             if (value[i] === value[i - 1]) {
                count++;
             }
             else {
                count = 1;
            }

            if (count > maxCount) {
                maxCount = count;
                mostFreqNumber = value[i];
            }

        }

        return mostFreqNumber + ' (' + maxCount + ' times)';
    };

    console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
    console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
    console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));
}());   