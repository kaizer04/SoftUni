function lastDigitAsText(number) {

    var number = number.toString();
    var digit = Number(number[number.length - 1]);

    var result = '';

    switch (digit) {
        case 0:
            result = 'Zero';
            break;
        case 1:
            result = 'One';
            break;
        case 2:
            result = 'Two';
            break;
        case 3:
            result = 'Three';
            break;
        case 4:
            result = 'Four';
            break;
        case 5:
            result = 'Five';
            break;
        case 6:
            result = 'Six';
            break;
        case 7:
            result = 'Seven';
            break;
        case 8:
            result = 'Eight';
            break;
        case 9:
            result = 'Nine';
            break;
    }

    console.log(result);

}

lastDigitAsText(6);
lastDigitAsText(-55);
lastDigitAsText(133);
lastDigitAsText(14567);