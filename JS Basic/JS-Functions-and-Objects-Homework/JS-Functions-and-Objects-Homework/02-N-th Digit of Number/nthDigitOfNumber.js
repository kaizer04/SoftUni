function findNthDigit(arr) {

    var n = Number(arr[0]);
    var number = arr[1].toString();
    number = number.replace(/\D/, '');
    var result = '';

    if (n > number.length) {
        result = 'The number doesn’t have 6 digits';
    } else {
        result = number[number.length - n];
    }

    console.log(result);

}

findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);