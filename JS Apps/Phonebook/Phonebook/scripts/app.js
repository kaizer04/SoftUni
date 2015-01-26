'use strict';

(function() {

    $(function() {
        registerEventHandlers();

        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            showUserHomeView()
        } else {
            showHomeView();
        }
    });

    function registerEventHandlers() {
        $("#btnShowLoginView").click(showLoginView);
        $("#btnLoginRegister").click(showRegisterView);
        $("#btnRegisterLogin").click(showLoginView);
        $("#btnShowRegisterView").click(showRegisterView);
        $("#btnLoginLogin").click(loginClicked);
        $("#btnRegister").click(registerClicked);
        $("#phonebook").click(showPhonebookView);
        $("#menuUserHomeView").click(showUserHomeView);
        $("#btnLogout").click(logoutClicked);
        $("#menuAddPhoneButton").click(showAddPhoneView);
        $("#viewAddPhoneButton").click(showAddPhoneView);
        $("#addPhoneButton").click(addPhoneClicked);
        $("#cancleAddPhoneButton").click(showAddPhoneView);
        //$("#deleteButton").click(deletePhoneButtonClicked);
    }

    function showHomeView() {
        $("main > *").hide();
        $("#welcomeHomeView").show();
        var currentUser = userSession.getCurrentUser();
        if (! currentUser) {
            $("#header span").text(" - Welcome");
            $("#menu").hide();
        }
    }

    function showLoginView() {
        $("main > *").hide();
        $("#login-form").show();
        var currentUser = userSession.getCurrentUser();
        if (!currentUser) {
            $("#header span").text(" - Login");
            $("#menu").hide();
        }
        $("#txtLoginUsername").val('');
        $("#txtLoginPassword").val('');
    }

    function loginClicked() {
        var username = $("#txtLoginUsername").val();
        var password = $("#txtLoginPassword").val();
        var fullName = username.fullName;
        ajaxRequester.login(username, password, fullName, authSuccess, loginError);
    }

    function authSuccess(data) {
        showAjaxSucess("Login successful", data);
        userSession.login(data);
        //showBookmarksView();  // TODO
        showUserHomeView();
    }

    function loginError(error) {
        showAjaxError("Login failed", error);
    }

    function logoutClicked() {
        userSession.logout();
        showHomeView();
    }

    function showRegisterView() {
        $("main > *").hide();
        $("#register-form").show();
        var currentUser = userSession.getCurrentUser();
        if (!currentUser) {
            $("#header span").text(" - Registration");
            $("#menu").hide();
        }
        $("#txtRegisterUsername").val('');
        $("#txtRegisterPassword").val('');
        $("#txtRegisterFullName").val('');
    }

    function registerClicked() {
        var username = $("#txtRegisterUsername").val();
        var password = $("#txtRegisterPassword").val();
        var fullName = $("#txtRegisterFullName").val();
        ajaxRequester.register(username, password, fullName,
            function(data) {
                data.username = username;
                authSuccess(data);
            },
            registerError);
    }

    function registerError(error) {
        showAjaxError("Register failed", error);
    }

    function showUserHomeView() {
        $("main > *").hide();
        $("#userHomeView").show();
        var currentUser = userSession.getCurrentUser();
        $("#welcomeUser span").text(currentUser.fullName + " (" + currentUser.username + ")");
        
        $("#header span").text(" - Home");
        $("#menu").show();
    }

    function showPhonebookView() {
        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            $("#header span").text(" - List");
            $("main > *").hide();
            $("#phonesView").show();
            var sessionToken = currentUser.sessionToken;
            ajaxRequester.getPhones(sessionToken, loadPhonesSuccess, loadPhonesError);
        } else {
            showHomeView();
        }
    }

    function loadPhonesSuccess(data) {
        var $phonesTable = $("#phones");
        $phonesTable.html('');
        $phonesTable.append("<tr><th>Name</th><th>Phone</th><th col='2' >Action</th></tr>");
        for (var p in data.results) {
            var phone = data.results[p];
            var $phoneTr = $("<tr>");
            $phoneTr.data("phone", phone);

            var $person = $("<td class='person'>");
            $person.text(phone.person);
            $phoneTr.append($person);

            var $number = $("<td class='number'>");
            $number.text(phone.number);
            $phoneTr.append($number);

            //var $buttons = $("<td><a href='#' class='link'>Edit</a>         <a href='#' class='link'>Delete</a></td>");
            ////$("#deleteButton").click(deletePhoneButtonClicked);
            //$phoneTr.append($buttons);
            var $editButton = $("<td><a href='#' class='link'>Edit</a></td>");
            $phoneTr.append($editButton);
            var $deleteButton = $("<td><a href='#' class='link'>Delete</a></td>");
            $deleteButton.click(deletePhoneButtonClicked);
            $phoneTr.append($deleteButton);

            $phonesTable.append($phoneTr);
            //var $deleteButton = $('<a href="#">Delete</a>');
            //$deleteButton.click(deleteBookmarkButtonClicked);
            //$bookmarkLi.append($deleteButton);

            //$bookmarksUl.append($bookmarkLi);
        }

        //$("#txtTitle").val('');
        //$("#txtUrl").val('');

        $("#phones").show();
        $("#showAddPhoneButton").show();
        
    }

    function loadPhonesError(error) {
        showErrorMessage("Bookmarks load failed.");
    }

    function showAddPhoneView() {
        var currentUser = userSession.getCurrentUser();
        if (currentUser) {
            $("#header span").text(" - Add Phone");
            $("main > *").hide();
            $("#add-phone-form").show();
            //var sessionToken = currentUser.sessionToken;
            //ajaxRequester.getPhones(sessionToken, loadPhonesSuccess, loadPhonesError);
        } else {
            showHomeView();
        }
        $("#personName").val('');
        $("#phoneNumber").val('');
    }

    function addPhoneClicked() {
        var person = $("#personName").val();
        var number = $("#phoneNumber").val();
        var currentUser = userSession.getCurrentUser();
        ajaxRequester.createPhone(person, number, currentUser.objectId,
            showPhonebookView, addPhoneError);
    }

    function addPhoneError(error) {
        showErrorMessage("Phone create failed.");
    }

    function deletePhoneButtonClicked() {
        var phone = $(this).parent().data('phone');
        var currentUser = userSession.getCurrentUser();
        var sessionToken = currentUser.sessionToken;

        noty(
            {
                text: "Delete this phone?",
                type: 'confirm',
                layout: 'topCenter',
                buttons: [
                    {
                        text : "Yes",
                        onClick : function($noty) {
                            deletePhone(sessionToken, phone);
                            $noty.close();
                        }
                    },
                    {
                        text : "Cancel",
                        onClick : function($noty) {
                            $noty.close();
                        }
                    }
                ]}
        );
    }

    function deletePhone(sessionToken, phone) {
        ajaxRequester.deletePhone(
            sessionToken, phone.objectId,
            showPhonebookView, deletePhoneError);
    }

    function deletePhoneError(error) {
        showErrorMessage("Delete phone failed.");
    }

    function showAjaxError(msg, error) {
        var errMsg = error.responseJSON;
        if (errMsg && errMsg.error) {
            showErrorMessage(msg + ": " + errMsg.error);
        } else {
            showErrorMessage(msg + ".");
        }
    }

    function showAjaxSucess(msg, sucess) {
        var sucessMsg = sucess.responseJSON;
        if (sucessMsg && sucessMsg.sucess) {
            showSucessMessage(msg + ": " + sucessMsg.sucess);
        } else {
            showSucessMessage(msg + ".");
        }
    }

    function showInfoMessage(msg) {
        noty({
                text: msg,
                type: 'info',
                layout: 'topCenter',
                timeout: 5000}
        );
    }

    function showErrorMessage(msg) {
        noty({
                text: msg,
                type: 'error',
                layout: 'topCenter',
                timeout: 5000}
        );
    }

    function showSucessMessage(msg) {
        noty({
            text: msg,
            type: 'sucess',
            layout: 'topCenter',
            timeout: 5000
        }
        );
    }

})();
