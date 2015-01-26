(function () {
    function register(e) {
        var name = $('#name').val();
        localStorage.setItem('name', name);
    }

    if (!localStorage['visitsCount']) {
        localStorage.setItem('visitsCount', 0);
    }

    if (!sessionStorage['visitsCount']) {
        sessionStorage.setItem('visitsCount', 0);
    }

    localStorage['visitsCount']++;
    sessionStorage['visitsCount']++;
    $('<div>').text('Total visits: ' + localStorage['visitsCount'])
                .appendTo('body');
    $('<div>').text('Session visits: ' + sessionStorage['visitsCount'])
                .appendTo('body');

    if (localStorage['name']) {
        $('form').hide();
        $('#greet').text('Hello ' + localStorage['name'] + '!');
    }
    else {
        $('#registerButton').on('click', register);
    }
})();