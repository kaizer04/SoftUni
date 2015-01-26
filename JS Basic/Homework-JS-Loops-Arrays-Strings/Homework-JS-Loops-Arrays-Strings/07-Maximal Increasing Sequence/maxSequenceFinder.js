(function () {
    function findMaxSequence(value) {
        var countElement = 1;
        var longest = 0;
        var longestSequence = [value[0]];
        var tempSequence = [value[0]];
        
        for (var i = 1; i < value.length; i++) {
		
            if (value[i - 1] >= value[i]) {
                if (countElement > longest) {
                    longest = countElement;
                    longestSequence = tempSequence;
		        }
                countElement = 0;
                tempSequence = [];
            }
            
            tempSequence.push(value[i]);
            countElement++;
        }
        
        console.log(tempSequence.length > longestSequence.length ? tempSequence : longestSequence.length < 2 ? 'no' : longestSequence);
    }
    var arr = [3, 2, 3, 4, 2, 2, 4];
    findMaxSequence(arr);
    findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
    findMaxSequence([3, 2, 1]);
}());