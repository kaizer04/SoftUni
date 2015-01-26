﻿function biggerThanNeighbors(index, arr) {

    var result = '';

    if (index > arr.length - 1) {
        result = 'invalid index';
    } else if (index === 0 || index === arr.length - 1) {
        result = 'only one neighbor';
    } else {

        var bigger = false;

        if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
            bigger = true;
        }

        if (bigger === true) {
            result = 'bigger';
        } else {
            result = 'not bigger';
        }

    }

    console.log(result);

}

biggerThanNeighbors(2, [1, 2, 3, 3, 5]);
biggerThanNeighbors(2, [1, 2, 5, 3, 4]);
biggerThanNeighbors(5, [1, 2, 5, 3, 4]);
biggerThanNeighbors(0, [1, 2, 5, 3, 4]);