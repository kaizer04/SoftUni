(function () {
    function createArray(value) {
        for (var i = 0; i < value.length; i++) {
            console.log(i * 5);
        }
    }
    var arr = new Array(20);
    createArray(arr);
}());