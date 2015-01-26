(function () {
    'use strict';
    var roundNumber = function (value) {
        return Math.round(value);
    }

    var floorNumber = function (value) {
        return Math.floor(value);
    }

    var input = [22.7, 12.3, 58.7];
   
    for (var i = 0, len = input.length; i < len; i += 1) {
        console.log(floorNumber(input[i]));
        console.log(roundNumber(input[i]));
    }
})();