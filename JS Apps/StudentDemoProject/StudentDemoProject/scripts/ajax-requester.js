var ajaxRequester = (function () {
    var makeRequest = function makeRequest(method, url, data, success, error) {
        return $.ajax({
            type: method,
            url: url,
            contentType: 'application/json',
            data: JSON.stringify(data),
            success: success,
            error: error
        })
    }

    function makeGetRequest(url, success, error) {
        makeRequest('GET', url, null, success, error)
    }

    function makePostRequest(url, data, success, error) {
        makeRequest('POST', url, data, success, error)
    }

    function makePutRequest(url, data, success, error) {
        makeRequest('PUT', url, data, success, error)
    }

    function makeDeleteRequest(url, success, error) {
        makeRequest('DELETE', url, {}, success, error)
    }

    return {
        get: makeGetRequest,
        post: makePostRequest,
        put: makePutRequest,
        delete: makeDeleteRequest
    }
}());


// http://localhost:3000/students -> GET -> all students
// http://localhost:3000/students -> POST -> ({name: "Pesho", grade: 4}) -> new student
// http://localhost:3000/students/3 -> DELETE -> delete student with id 3