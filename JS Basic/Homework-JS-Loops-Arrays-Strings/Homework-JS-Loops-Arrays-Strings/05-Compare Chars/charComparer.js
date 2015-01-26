(function () {
    function compareChars(value) {
        var isEqual = true;
        for (var i = 0; i < value[0].length; i++) {
            if (!(value[0][i] === value[1][i] && value[0].length === value[1].length)) {
                isEqual = false;
                break;
            }
        }

        return isEqual ? console.log('Equal') : console.log('Not Equal');
    }
    var arr = [
        ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],
        ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']
    ];
    var arr1 = [
        ['3', '5', 'g', 'd'],
        ['5', '3', 'g', 'd']
    ];
    var arr2 = [
        ['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],
        ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']
    ];
    compareChars(arr);
    compareChars(arr1);
    compareChars(arr2);
}());