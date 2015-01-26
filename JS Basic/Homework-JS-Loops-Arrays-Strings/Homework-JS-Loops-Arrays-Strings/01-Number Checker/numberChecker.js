(function () {
    function printNumbers(n) {
        console.log(n);
        var result = [];
        if (n <= 0) {
            result = 'no';
        }

        for (var i = 1; i <= n; i++) {
            if (!(i % 4 === 0 || i % 5 === 0)) {
                result.push(i);
            }
        }
        
        return result;
    };
    
    console.log(printNumbers(20));
    console.log(printNumbers(-5));
    console.log(printNumbers(13));
}());