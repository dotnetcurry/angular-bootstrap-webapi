/// <reference path="F:\Mahesh_New\Articles\Jan15\A1_NG_Boot_MVC5\A1_NG_Boot_MVC5\Scripts/angular.min.js" />
/// <reference path="pModule.js" />
app.service("personInfoService", function ($http) {

    this.getInfo = function (id) {
        var req = $http.get('/api/PersonInformationAPI/' + id);
        return req;
    };

    this.getAppInfo = function () {
        var req = $http.get('/api/PersonInformationAPI');
        return req;
    }

    this.postInfo = function (personInfo) {
        var req = $http.post('/api/PersonInformationAPI', personInfo);
        return req;
    };

});
