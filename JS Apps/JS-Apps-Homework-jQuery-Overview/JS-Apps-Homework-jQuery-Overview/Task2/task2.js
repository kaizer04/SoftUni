function onChangeBackgroundColor() {
    var colorValue = $('#colorPicker').val();
    var inputClass = '.' + $('#class').val();
    $(inputClass).css('background-color', colorValue);
}