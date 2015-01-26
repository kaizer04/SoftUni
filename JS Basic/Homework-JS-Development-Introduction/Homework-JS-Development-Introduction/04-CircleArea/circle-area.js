window.onload = function () {
    var circleArea = function (radius) {
        var circleArea = Math.PI * radius * radius;

        return circleArea;
    }

    var radius = [7, 1.5, 20];
    //console.log(circleArea(radius[0]));
   
    for (var i = 0; i < 3; i+=1) {
        var div = document.createElement('div');
        var text = 'r = ' + radius[i] + '; area = ' + circleArea(radius[i]);
        var textNode = document.createTextNode(text);
        div.appendChild(textNode);
        document.body.appendChild(div);
    }
    
}();
