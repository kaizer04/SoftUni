window.onload = function () {
    function ConvertHexadecimalChar(number) {
        var ch;
        switch (number) {
            case 10:
                ch = "A";
                break;
            case 11:
                ch = "B";
                break;
            case 12:
                ch = "C";
                break;
            case 13:
                ch = "D";
                break;
            case 14:
                ch = "E";
                break;
            case 15:
                ch = "F";
                break;
        }
        return ch;
    }

    var decToHex = function (number) {
        var result = '';
        var array = [];
        console.log(number);
        while (number > 0) {
            array.push(number % 16);
            number = number / 16 | 0;
        }
        console.log(array);
        array.reverse();
        console.log(array);
        for (var i = 0; i < array.length; i+=1) {
            if (array[i] > 9) {
                result += ConvertHexadecimalChar(array[i]);
            }
            else {
                result += array[i];
            }

        }

        return result;
    }
    var number = prompt('Enter a number', 0);
    alert(decToHex(number));
}();