function getTypeOfVariable() {
    var result = '';

    if (arguments.length <= 0) {
        result = 'No arguments';
    }

    for (var i in arguments) {
        result += 'Argument of position ' + i + ' is of type ' + typeof arguments[i] + "\n";
    }

    console.log(result);
}

getTypeOfVariable(4, 'gdfg', 5.66);
getTypeOfVariable(4, true, 5.66);
getTypeOfVariable();
console.log();

function person(name) {
    this.name = name;
    var personName = name;
    console.log('personName in function scope: ' + personName);
}

// name in global scope
person('Yanku');
console.log('personName in global scope: ' + name);

function PersonObj(name) {
    var personName = 'This is private name: ' + name;
    this.name = name;

    this.getPersonName = function getName() {
        return personName;
    }
}

var gosho = new PersonObj('Object name: Gosho');
// personName is private for PersonObj
console.log(gosho.name);
console.log(gosho.getPersonName());
console.log(name);
console.log();

var stamat = new PersonObj('Object name: Stamat');
var pesho = new PersonObj('Petarcho');
PersonObj.call(stamat, 'Stamat already is Gosho');
console.log(stamat.getPersonName());
console.log(pesho.getPersonName());