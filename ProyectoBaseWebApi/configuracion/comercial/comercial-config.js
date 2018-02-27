angular.module('appBase').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider
    .state('app.comercial', {
        url: '/comercial',
        views: {
            'content@': {
                templateUrl: 'configuracion/comercial/comercial.html',
                controller: 'comercialController',
                controllerAs: 'vm',
                resolve: {
                    parameters: ['$q', '$stateParams', 'comercialFactory', 
                        function ($q, $stateParams, comercialFactory) {
                            return { mode: 'view' };
                        }]
                }
            }
        }
    });
}]);