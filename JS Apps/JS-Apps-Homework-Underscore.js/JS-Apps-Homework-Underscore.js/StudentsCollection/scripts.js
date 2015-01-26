(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../../scripts/underscore.js');
    }

    //var Student = Object.create({
    //    init: function (fname, lname, age) {
    //        this.fname = fname;
    //        this.lname = lname;
    //        this.age = age;
    //        return this;
    //    },
    //    toString: function () {
    //        return this.fname + ' ' + this.lname;
    //    }
    //});

    var students = [
        { "gender": "Male", "firstName": "Joe", "lastName": "Riley", "age": 22, "country": "Russia" },
        {"gender":"Female","firstName":"Lois","lastName":"Morgan","age":41,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Roy","lastName":"Wood","age":33,"country":"Russia"},
        {"gender":"Female","firstName":"Diana","lastName":"Freeman","age":40,"country":"Argentina"},
        {"gender":"Female","firstName":"Bonnie","lastName":"Hunter","age":23,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Joe","lastName":"Young","age":16,"country":"Bulgaria"},
        {"gender":"Female","firstName":"Kathryn","lastName":"Murray","age":22,"country":"Indonesia"},
        {"gender":"Male","firstName":"Dennis","lastName":"Woods","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Billy","lastName":"Patterson","age":24,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Willie","lastName":"Gray","age":42,"country":"China"},
        {"gender":"Male","firstName":"Justin","lastName":"Lawson","age":38,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Ryan","lastName":"Foster","age":24,"country":"Indonesia"},
        {"gender":"Male","firstName":"Eugene","lastName":"Morris","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Eugene","lastName":"Rivera","age":45,"country":"Philippines"},
        { "gender": "Female", "firstName": "Kathleen", "lastName": "Hunter", "age": 28, "country": "Bulgaria" }
    ];

    console.log('---Task 1---');

    function filterSpecificAgeRange(students) {
        var filtered = _.chain(students)
                        .filter(function (student) {
                            return student.age >= 18 && student.age <= 24
                        }).value();

        return filtered;
    }

    console.log(filterSpecificAgeRange(students));



    console.log('---Task 2---');
   
    function filterAndSortFirstNameBeforeLastName(students) {
        var filtered = _.filter(students, function (student) {
            if (student.firstName < student.lastName) {
                return true;
            }
            else {
                return false;
            }
        });

        //var sorted = _.chain(filtered)
        //                .sortBy(function (student) {
        //                    return student.fname + ' ' + student.lname
        //                })
        //                .reverse().value();

        //return sorted;
        return filtered;
    }

    console.log(filterAndSortFirstNameBeforeLastName(students));

    console.log('---Task 3---');

    function filterCountryOnlyNames(students) {
        var filtered = _.where(students, { country: 'Bulgaria' })
                        .map(function(student) {
                            return student.firstName + ' ' + student.lastName;
                        });

        //return sorted;
        return filtered;
    }

    console.log(filterCountryOnlyNames(students));

    console.log('---Task 4---');
    console.log(_.last(students, 5));

    console.log('---Task 5---');

    function firstThreeNotBulgariaAndMale(students) {
        var filtered = _.chain(students)
                        .filter(function (student) {
                            return student.country !== 'Bulgaria' && student.gender === 'Male';
                        })
                        .first(3).value();

        return filtered;
    }

    console.log(firstThreeNotBulgariaAndMale(students));
}());