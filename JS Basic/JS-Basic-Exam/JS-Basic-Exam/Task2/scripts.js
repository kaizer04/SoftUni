function solve(input) {
    var result = [];
    var arr = new Array(parseInt(input.length));
    //console.log(input[0].split(''));
    for (var i = 0; i < input.length; i++) {
        var tempArr = input[i].split('');
        //console.log(tempArr);
        
        arr[i] = tempArr;
        
    }
    //console.log(arr);
    for (var i = 0; i < arr.length - 1; i++) {
        for (var j = 0; j < arr[i].length - 1; j++) {
            if ((arr[i][j + 1] === arr[i + 1][j]) && (arr[i][j + 1] === arr[i + 1][j + 1]) && (arr[i][j + 1] === arr[i + 1][j + 2])) {
                arr[i][j + 1] = '*';
                arr[i + 1][j] = '*';
                arr[i + 1][j + 1] = '*';
                arr[i + 1][j + 2] = '*';
            }
        }
    }

    for (var i = 0; i < arr.length; i++) {
        result += arr[i].join('') + '\n';
    }
    //result = arr.join('');

    return result;
}

console.log(solve([
    'abcdexgh',
    'bbbdxxxh',
    'abcxxxxx',
]));
