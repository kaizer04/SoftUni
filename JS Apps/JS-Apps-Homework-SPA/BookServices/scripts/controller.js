var app = app || {};

app.controller = (function () {
    function BaseController(data) {
        this._data = data;
    }

    //BaseController.prototype.loadHome = function (selector) {
    //    $(selector).load('./templates/home.html');
    //}

    //BaseController.prototype.loadLogin = function (selector) {
    //    $(selector).load('./templates/login.html');
    //}

    //BaseController.prototype.loadRegister = function (selector) {
    //    $(selector).load('./templates/register.html');
    //}

    BaseController.prototype.loadBookmarks = function (selector) {
        this._data.bookmarks.getAll()
        .then(function (data) {
            $.get('./templates/bookmarks.html', function (template) {
                var output = Mustache.render(template, data);
                $(selector).html(output);
            })
        })
    }

    BaseController.prototype.attachEventHandlers = function () {
        var selector = '#wrapper';
        //attachLoginHandler.call(this, selector);
        //attachRegisterHandler.call(this, selector);
        attachCreateBookmarkHandler.call(this, selector);
        attachDeleteBookmarkHandler.call(this, selector);
        attachEditBookmarkHandler.call(this, selector);
    }

    var attachLoginHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#login', function () {
            var username = $('#username').val();
            var password = $('#password').val();
            _this._data.users.login(username, password)
            .then(function (data) {
                window.history.replaceState('Bookmarks', 'Bookmarks', '#/bookmarks');
            },
            function (error) {
                // body...
            });
        });
    }

    var attachRegisterHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#register', function () {
            var username = $('#username').val();
            var password = $('#password').val();
            _this._data.users.register(username, password)
                .then(function (data) {
                    alert(data.username);
                },
                function (error) {
                    // body...
                });
        });
    }

    var attachCreateBookmarkHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '#create-bookmark', function (ev) {
            var title = $('#title').val();
            var author = $('#author').val();
            var isbn = $('#isbn').val();
            var bookmark = {
                title: title,
                author: author,
                isbn: isbn
            }
            _this._data.bookmarks.add(bookmark)
                .then(function (data) {
                    console.log('I am in bookmarks add success!');
                    _this._data.bookmarks.getById(data.objectId)
                    .then(function (bookmark) {
                        var li = $('<li>').append('<b>' + bookmark.title + '</b> by ' + bookmark.author + '; ISBN: ' + bookmark.isbn);
                        $('#bookmarks ul').append(li);
                        $('#title').val('');
                        $('#author').val('');
                        $('#isbn').val('');
                    }, function (error) {
                        console.log(error);
                    });
                }, function (error) {
                    console.log(error);
                });
        });
    }

    var attachEditBookmarkHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '.edit-bookmark-btn', function (event) {
            var objectId = $(this).parent().data('id');
            var title = $('#edit-title').val();
            var author = $('#edit-author').val();
            var isbn = $('#edit-isbn').val();
            if (!title || !author) {
                return alert('The title and author fields must have value!')
            }
            var data = {
                title: title,
                author: author,
                isbn: isbn
            }
            _this._data.lib.editBook(objectId, data)
            .then(function (data) {
                $('#edit-row').empty();
                _this.loadLibrary(selector);
            }, function (error) {
                return alert('Can not load Library!');
            })
        })
    }

    var attachDeleteBookmarkHandler = function (selector) {
        var _this = this;
        $(selector).on('click', '.delete-bookmark-btn', function (ev) {
            var deleteConfirmed = confirm('Do you want to delete this book');
            if (deleteConfirmed) {
                var objectId = $(this).parent().data('id');
                _this._data.bookmarks.delete(objectId)
                .then(function (data) {
                    $(ev.target).parent().remove();
                },
                function (error) {
                    console.log(error);
                })
            };
        })
    }

    return {
        get: function (data) {
            return new BaseController(data);
        }
    }
}())