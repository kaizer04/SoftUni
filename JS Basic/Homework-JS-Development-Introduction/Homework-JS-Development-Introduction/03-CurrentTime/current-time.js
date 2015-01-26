window.onload = function () {
    var currentTime = new Date();
    var hours = currentTime.getHours();
    var minutes = currentTime.getMinutes();
    if (minutes < 10) {
        minutes = '0' + minutes;
    }
    console.log(hours + ':' + minutes);
}();

//If tou do not have node, you can start numbers1to10.html