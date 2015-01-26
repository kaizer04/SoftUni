(function () {
    'use strict';
    function sumNumbers(value) {
       var sum = 0;
        for (var i = 0, len = value.length; i < len; i += 1) {
            sum += value[i];
            
        }
        
        return sum;
    }

    function divisionBy3(value) {
        var sum = sumNumbers(value);
        
        var isDivisionBy3 = 'the number is not divided by 3 without remainder';
       
        if (value % 3 === 0) {
            isDivisionBy3 = 'the number is divided by 3 without remainder';
        }

        return isDivisionBy3;
    }

    var input = [12, 188, 591, 12, 188, 591, 12, 188, 591, 12, 188, 591];
    //var input = [12, 188, 591];
    console.log(sumNumbers(input));
    console.log(divisionBy3(input));
    //for (var i = 0; i < 3; i += 1) {
    //    console.log(input[i]);
    //    console.log(divisionBy3(input[i]));

    //}
})();