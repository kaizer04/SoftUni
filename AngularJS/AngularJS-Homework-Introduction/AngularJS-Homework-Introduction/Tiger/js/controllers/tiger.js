'use strict';

app.controller('Tiger', function ($scope) {
    $scope.name = "Pesho";
    $scope.image = "http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg";
    $scope.born = 'Asia';
    $scope.birthDate = 2006;
    $scope.live = "Sofia Zoo";
    $scope.myStyle = {
        'width': '550px',
        'background-color': 'lightgray',
        'color': 'blue',
        'span': 'bold'
    }
    $scope.wrap = 'wrapClass';
});