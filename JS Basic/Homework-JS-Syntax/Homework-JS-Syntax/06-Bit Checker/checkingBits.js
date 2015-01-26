(function () {
    'use strict';
    function bitChecker(value) {
        var mask = 1 << 3;
        
        var isOne = false;
        if ((value & mask) !== 0) {
            isOne = true;
        }

        return isOne;
    }

    var input = [333, 425, 2567564754];
    
    for (var i = 0; i < 3; i += 1) {
        console.log(input[i]);
        console.log(bitChecker(input[i]));

    }
})();