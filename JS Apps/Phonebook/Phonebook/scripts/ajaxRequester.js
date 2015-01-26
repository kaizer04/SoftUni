'use strict';

var ajaxRequester = (function() {
    var baseUrl = "https://api.parse.com/1/";

    var headers =
    {
        "X-Parse-Application-Id": "3k3K0UgOAN70a88MSPvwEWx8nzE5u6vi9vAAniYi",
        "X-Parse-REST-API-Key": "ckotInImXr9PfWdf5udPuNhe6yHRRh9PJA1SXzlC"
    };

    function login(username, password, fullName, success, error) {
        jQuery.ajax({
            method: "GET",
            headers: headers,
            url: baseUrl + "login",
            data: { username: username, password: password, fullName: fullName },
            success: success,
            error: error
        });
    }

    function register(username, password, fullName, success, error) {
        jQuery.ajax({
            method: "POST",
            headers: headers,
            url: baseUrl + "users",
            data: JSON.stringify({username: username, password: password, fullName: fullName}),
            success: success,
            error: error
        });
    }

    function getHeadersWithSessionToken(sessionToken) {
        var headersWithToken = JSON.parse(JSON.stringify(headers));
        headersWithToken['X-Parse-Session-Token'] = sessionToken;
        return headersWithToken;
    }

    function getPhones(sessionToken, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "GET",
            headers: headersWithToken,
            url: baseUrl + "classes/Phone",
            success: success,
            error: error
        });
    }

    function createPhone(person, number, userId, success, error) {
        var phone = { person: person, number: number, ACL: {} };
        phone.ACL[userId] = { "write": true, "read": true };
        jQuery.ajax({
            method: "POST",
            headers: headers,
            url: baseUrl + "classes/Phone",
            data: JSON.stringify(phone),
            success: success,
            error: error
        });
    }

    function deletePhone(sessionToken, phoneId, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "DELETE",
            headers: headersWithToken,
            url: baseUrl + "classes/Phone/" + phoneId,
            success: success,
            error: error
        });
    }

    return {
        login: login,
        register: register,
        getPhones: getPhones,
        createPhone: createPhone,
        deletePhone: deletePhone
    };
})();