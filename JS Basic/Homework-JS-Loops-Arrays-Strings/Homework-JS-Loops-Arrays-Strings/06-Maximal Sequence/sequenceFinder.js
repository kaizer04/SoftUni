(function () {
    function findMaxSequence(value) {
        var element = value[0];
        var tempCount = 1;
        var count = 1;
        var tempElement = value[0];
		
        for (var i = 0; i < value.length - 1; i++) {
            if (value[i] === value[i + 1]) {
                tempCount++;
                if (tempCount >= count) {
                    count = tempCount;
                    element = tempElement;
                }
            }
            else {
                tempCount = 1;
                tempElement = value[i + 1];
            }
        }
        var result = [];
        for (var i = 0; i < count; i++) {
            result.push(element);
        }
        console.log(result);
    }
    var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
    findMaxSequence(arr);
    findMaxSequence(['happy']);
    findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);
}());