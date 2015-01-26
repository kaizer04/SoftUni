function solve(input) {
    var words = input[0].split(/[^a-zA-Z]+/);
    var firstWord = '';
    var secondWord = '';
    for (var i = 0; i < words.length; i++) {
        for (var k = 0; k < words.length; k++){
            for (var j = 0; j < words[i].length; j++) {
                if (words[i][j] === words[k][j]) {
                    firstWord += words[i][j];
                }
            }
            
        }
    }
    
    console.log(firstWord);
}

solve(['java..?|basics/*-+=javabasics']);