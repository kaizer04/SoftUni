function findYoungestPerson(persons) {

    var youngest = persons[0]['age'];
    var id = 0;

    for (var i = 1; i < persons.length; i++) {

        if (persons[i]['age'] < youngest) {
            youngest = persons[i]['age'];
            id = i;
        }
    }

    console.log('The youngest person is ' + persons[id]['firstname'] + ' ' + persons[id]['lastname']);

}

var persons = [
  { firstname: 'George', lastname: 'Kolev', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Baba', lastname: 'Ginka', age: 40 }];
findYoungestPerson(persons);