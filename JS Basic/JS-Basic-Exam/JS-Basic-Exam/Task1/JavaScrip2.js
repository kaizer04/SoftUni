function solve(input) {

    var assarr = {};
    var count;
    for (var i = 0; i < input.length; i++) {
        var tempRow = input[i].split(/[|]+/);
        //console.log(tempRow);
        var band = tempRow[0].trim();
        var town = tempRow[1].trim();
        var venue = tempRow[3].trim();
        //console.log('1'+ venue + '1');
        if (!(town in assarr)) {
            assarr[town] = {};
            assarr[town][venue] = [band];
        }
        else if ((town in assarr) && !(venue in assarr[town])) {
            assarr[town][venue].push(band);
        }
        else {
            band.concat(assarr[town][venue]);
            assarr[town][venue] = band;
        }
    }
    console.log(assarr);
    var keysUsers = [];
    for (var key in assarr) {
        if (assarr.hasOwnProperty(key)) {
            keysUsers.push(key);
        }
    }
    keysUsers.sort();
    var output = '';
    for (var i = 0; i < keysUsers.length; i++) {
        var sumMinutes = 0;
        var keysUsersIp = [];
        for (var key in assarr[keysUsers[i]]) {
            if (assarr[keysUsers[i]].hasOwnProperty(key)) {
                keysUsersIp.push(key);
                sumMinutes += assarr[keysUsers[i]][key];
            }
        }
        output += keysUsers[i] + ': ' + sumMinutes + ' [' + keysUsersIp.sort().join(', ') + ']\n';
    }
    //console.log(output);
}

//when you submit the code into the Judge system, do not copy the code below!
solve([
    'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'
]);