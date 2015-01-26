(function () {
    'use strict';
    var convertKWtoHP = function (value) {
        var COEFFICIENT = 1.341;
        var hp = COEFFICIENT * value;
        return hp;
    }
    var input = [75, 150, 1000];
    var TO_FIX_NUMBERS = 2;
    for (var i = 0, len = input.length; i < len; i+=1) {
        console.log(convertKWtoHP(input[i]).toFixed(TO_FIX_NUMBERS));
    }
})();