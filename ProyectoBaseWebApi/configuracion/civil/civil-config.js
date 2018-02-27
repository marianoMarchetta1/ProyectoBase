angular.module('appBase').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider
        .state('app.civil', {
            url: '/civil',
        views: {
            'content@': {
                templateUrl: 'configuracion/civil/civil.html',
                controller: 'civilController',
                controllerAs: 'vm',
                resolve: {
                    parameters: ['$q', '$stateParams', 'civilFactory', 
                        function ($q, $stateParams, civilFactory) {
                            return { mode: 'view' };
                        }]
                }
            }
        }
    });
}]);