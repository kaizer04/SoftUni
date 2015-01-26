function reverseWordsInString(str) {

    var words = str.split(' ');
    var result = '';

    for (var i = 0; i < words.length; i++) {

        var word = words[i];
        var new_word = '';

        for (j = word.length - 1; j >= 0; j--) {
            new_word += word[j];
        }

        result += new_word + ' ';

    }

    console.log(result);

}

reverseWordsInString('Hello, how are you.');
reverseWordsInString('Life is pretty good, isn’t it?');