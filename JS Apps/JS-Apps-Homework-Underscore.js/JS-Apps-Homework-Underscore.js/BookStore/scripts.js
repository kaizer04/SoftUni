(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../../scripts/underscore.js');
    }

    //var Book = Object.create({
    //    init: function (name, author) {
    //        this.name = name,
    //        this.author = author;
    //        return this;
    //    },
    //    toString: function () {
    //        return this.name + ' ' + this.author;
    //    }
    //});

    var books = [
        { "book": "The Grapes of Wrath", "author": "John Steinbeck", "price": "34,24", "language": "French" },
        { "book": "The Great Gatsby", "author": "F. Scott Fitzgerald", "price": "39,26", "language": "English" },
        { "book": "Nineteen Eighty-Four", "author": "George Orwell", "price": "15,39", "language": "English" },
        { "book": "Ulysses", "author": "James Joyce", "price": "23,26", "language": "German" },
        { "book": "Lolita", "author": "Vladimir Nabokov", "price": "14,19", "language": "German" },
        { "book": "Catch-22", "author": "Joseph Heller", "price": "47,89", "language": "German" },
        { "book": "The Catcher in the Rye", "author": "J. D. Salinger", "price": "25,16", "language": "English" },
        { "book": "Beloved", "author": "Toni Morrison", "price": "48,61", "language": "French" },
        { "book": "Of Mice and Men", "author": "John Steinbeck", "price": "29,81", "language": "Bulgarian" },
        { "book": "Animal Farm", "author": "George Orwell", "price": "38,42", "language": "English" },
        { "book": "Finnegans Wake", "author": "James Joyce", "price": "29,59", "language": "English" },
        { "book": "The Grapes of Wrath", "author": "John Steinbeck", "price": "42,94", "language": "English" }
    ];

    console.log('---Task 1---');

    function groupByLanguageAndSortByAuthor(books) {
        var grouped = _.groupBy(_.sortBy(books, function (book) {
                                    return book.author + '_' + book.price;
                                }), 'language');
        return grouped;
    }
    //var groupByLanguage = _.groupBy(books, 'language');
    //var groupByLanguageAndSortByAuthor = _.chain(books)
    //                                        .groupBy(books, 'language')
    //                                        .sortBy('author')
    //                                        .sortBy('price').value();
    //groupByLanguage = _.sortBy(mostFamousBooks, function (book) { return book.length });
    //console.log('mostPopularAuthor: ' + _.last(mostFamousBooks)[0].author);
    console.log(groupByLanguageAndSortByAuthor(books));

    console.log('---Task 2---');

    //function groupedByAuthorAndAveragePrice(books) {
    //    var groupedByAuthor = _.groupBy(books, 'author');
    //    console.log(groupedByAuthor);
    //    var averagePriceForAuthor = function (groupedByAuthor) {
            
    //        return _.each(groupedByAuthor, function () {
    //            var averagePrice = groupedByAuthor.author['price'] / groupedByAuthor.author.count();

    //            return groupedByAuthor.author + ' - average price: ' + averagePrice;
    //        })
    //    }

    //    groupedByAuthor.each(function (index, value) {
    //        console.log(value);
    //    })

    //    return averagePriceForAuthor;
    //}
    //console.log(groupedByAuthorAndAveragePrice(books));

    var secondPoint = _.chain(books)
                        .groupBy('author')
                        .map(function (value, author) {
                            var hisBook = value;
                            var sum = 0;
                            _.each(hisBook, function (value, hisBook) {
                                sum += parseFloat(value.price.replace(/,/g, '.'));
                            });
                            return [author, (sum / hisBook.length).toFixed(2)]
                        }).value();
    console.log(secondPoint);
}());