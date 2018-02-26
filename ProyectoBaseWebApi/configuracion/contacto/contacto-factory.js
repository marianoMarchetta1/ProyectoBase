angular.module('appBase').factory('contactoFactory', ['$http', '$q', 'handleErrorService',
    function ($http, $q, handleErrorService) {

        var urlBase = '/api/contacto';
        var contactoFactory = {};

        contactoFactory.send = function (mail) {
            var deferred = $q.defer();
            $http.post(urlBase + '/' + 'send', mail)
                .then(function (response) {
                    deferred.resolve({ list: response.data});
                }).catch(function (response) {
                    deferred.reject(handleErrorService.rejectHttpError(response.data, response.status));
                });
            return deferred.promise;
        };

        return contactoFactory;
}]);