function getRadioButtonValue() {
    var valueToReturn = $("input[type='radio'][name='insert']:checked").val();
    return valueToReturn;
}

(function () {
    $('div').on('click', function (ev) {
        if (getRadioButtonValue() === 'before') {
            $(ev.target).before($('<div><a href="#" style="text-decoration:none;color:green">New Div Before</a></div>'));
        }
        else {
            $(ev.target).after($('<div><a href="#" style="text-decoration:none;color:red">New Div After</a></div>'));
        }
        ev.stopImmediatePropagation();
    });
}());
