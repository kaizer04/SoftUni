(function () {
    'use strict';
    function isPrime(value) {
        var maxDivide = Math.sqrt(value);
        var isPrime = true;
        for (var i = 2; i <= maxDivide; i++) {
            if (value % i === 0) {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }

    var input = [7, 254, 587];

    for (var i = 0, len = input.length; i < len; i += 1) {
        console.log(isPrime(input[i]));
        
    }
})();