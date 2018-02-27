angular.module('appBase').factory('civilFactory', ['$http', '$q', 
    function ($http, $q) {

        var urlBase = '/api/civil';
        var civilFactory = {};

        return civilFactory;
}]);