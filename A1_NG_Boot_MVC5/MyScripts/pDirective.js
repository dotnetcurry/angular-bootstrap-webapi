/// <reference path="F:\Mahesh_New\Articles\Jan15\A1_NG_Boot_MVC5\A1_NG_Boot_MVC5\Scripts/angular.min.js" />
 
app.directive('personForm',
    function () {

        return {
            restrict: 'E',
            templateUrl: '/MyScripts/pTemplate.html'
        }

    });