function solve (input) {
    var start = parseInt(input[0]);
    var end = parseInt(input[1]);
    function isFibonacciNumber(number) {
        
        //function fibonacciArray() {
        //    var arr = [1, 1];
        //    for (var i = 0; i < 35; i += 1) {
        //        if (arr[i] + arr[i + 1] <= 1000000) {
        //            arr.push(arr[i] + arr[i + 1]);
        //        }
        //    }

        //    return arr;
        //}
        var fibonacciArray = [1, 1];
        for (var i = 0; i < 31; i += 1) {
            if (fibonacciArray[i] + fibonacciArray[i + 1] <= 2000000) {
                fibonacciArray.push(fibonacciArray[i] + fibonacciArray[i + 1]);
            }
        }

        var isFibonacci = false;
        //var fibonacciArray = fibonacciArray();
        for (var i = 0, len = fibonacciArray.length; i < len; i += 1) {
            if (number === fibonacciArray[i]) {
                isFibonacci = true;
                break
            }
        }

        return isFibonacci ? 'yes' : 'no';
    }

    function squareNumber(number) {
        var square = number * number;
        return square;
    }

    var result = '<table>\n<tr><th>Num</th><th>Square</th><th>Fib</th></tr>';
    
    for (var i = start; i <= end; i+=1) {
        result += '\n<tr><td>' + i + '</td><td>' + squareNumber(i) + '</td><td>' + isFibonacciNumber(i, end) + '</td></tr>';
    }

    result += '\n</table>';
    return result;
    
}

console.log(solve([55, 56]));
