﻿(function () {
    if (typeof require !== 'undefined') {
        _ = require('node_modules/underscore/underscore.js');
    }

    var students = [
        { "gender": "Male", "firstName": "Joe", "lastName": "Riley", "age": 22, "country": "Russia" },
        { "gender": "Female", "firstName": "Lois", "lastName": "Morgan", "age": 41, "country": "Bulgaria" },
        { "gender": "Male", "firstName": "Roy", "lastName": "Wood", "age": 33, "country": "Russia" },
        { "gender": "Female", "firstName": "Diana", "lastName": "Freeman", "age": 40, "country": "Argentina" },
        { "gender": "Female", "firstName": "Bonnie", "lastName": "Hunter", "age": 23, "country": "Bulgaria" },
        { "gender": "Male", "firstName": "Joe", "lastName": "Young", "age": 16, "country": "Bulgaria" },
        { "gender": "Female", "firstName": "Kathryn", "lastName": "Murray", "age": 22, "country": "Indonesia" },
        { "gender": "Male", "firstName": "Dennis", "lastName": "Woods", "age": 37, "country": "Bulgaria" },
        { "gender": "Male", "firstName": "Billy", "lastName": "Patterson", "age": 24, "country": "Bulgaria" },
        { "gender": "Male", "firstName": "Willie", "lastName": "Gray", "age": 42, "country": "China" },
        { "gender": "Male", "firstName": "Justin", "lastName": "Lawson", "age": 38, "country": "Bulgaria" },
        { "gender": "Male", "firstName": "Ryan", "lastName": "Foster", "age": 24, "country": "Indonesia" },
        { "gender": "Male", "firstName": "Eugene", "lastName": "Morris", "age": 37, "country": "Bulgaria" },
        { "gender": "Male", "firstName": "Eugene", "lastName": "Rivera", "age": 45, "country": "Philippines" },
        { "gender": "Female", "firstName": "Kathleen", "lastName": "Hunter", "age": 28, "country": "Bulgaria" }
    ];

    var studentsWithAgeBetween18And24 = _.filter(students, function (student) {
        return student.age >= 18 && student.age <= 24;
    });

    _.each(studentsWithAgeBetween18And24, function (student) {
        console.log(student);
    });

    var alphabeticallyStudents = _.filter(students, function (student) {
        return student.firstName < student.lastName;
    });

    _.each(alphabeticallyStudents, function (student) {
        console.log(student);
    });

    var studentsFromBulgaria = _.map(
        _.where(students, { country: "Bulgaria" }),
        function (student) {
            return { firstName: student.firstName, lastName: student.lastName };
        }
    );

    _.each(studentsFromBulgaria, function (student) {
        console.log(student);
    });

    var lastFiveStudents = _.last(students, 5);

    _.each(lastFiveStudents, function (student) {
        console.log(student);
    });

    var specialStudents = _.filter(students, function (student) {
        return student.country != 'Bulgaria' && student.gender == 'Male';
    });

    specialStudents = _.first(specialStudents, 3);

    _.each(specialStudents, function (student) {
        console.log(student);
    });

}());