angular.module('appBase').factory('comercialFactory', ['$http', '$q', 
    function ($http, $q) {

        var urlBase = '/api/comercial';
        var comercialFactory = {};

        return comercialFactory;
}]);