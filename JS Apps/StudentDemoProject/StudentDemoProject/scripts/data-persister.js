var app = app || {};

app.dataPersister = (function () {
    function Persister(rootUrl) {
        this.rootUrl = rootUrl;
        this.students = new Students(rootUrl);
        this.schools = new Schools(rootUrl);
    }

    var Students = (function () {
        function Students(rootUrl) {
            this.serviceUrl = rootUrl + 'students/'
        }

        Students.prototype.getAll = function (sucess, error) {
            return ajaxRequester.get(this.serviceUrl, sucess, error);
        }

        Students.prototype.add = function (student, sucess, error) {
            return ajaxRequester.post(this.serviceUrl, student, sucess, error);
        }

        Students.prototype.delete = function (id, sucess, error) {
            return ajaxRequester.delete(this.serviceUrl + id, sucess, error);
        }

        return Students;
    }());

    var Schools = (function () {
        function Schools(rootUrl) {
            this.serviceUrls = rootUrl + 'schools/'
        }

        return Schools;
    }());
    //Persister.prototype.getAll = function () {
    //    return ajaxRequeser.get();
    //}

    return {
        get: function (rootUrl) {
            return new Persister(rootUrl);
        }
    }
}());

// persister.students.getAll()
// persister.students.add()
// persister.students.delete()