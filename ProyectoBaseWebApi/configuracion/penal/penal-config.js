angular.module('appBase').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider
    .state('app.penal', {
        url: '/penal',
        views: {
            'content@': {
                templateUrl: 'configuracion/penal/penal.html',
                controller: 'penalController',
                controllerAs: 'vm',
                resolve: {
                    parameters: ['$q', '$stateParams', 'penalFactory', 
                        function ($q, $stateParams, penalFactory) {
                            return { mode: 'view' };
                        }]
                }
            }
        }
    });
}]);