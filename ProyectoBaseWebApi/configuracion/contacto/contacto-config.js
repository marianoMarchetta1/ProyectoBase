angular.module('appBase').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider
        .state('app.contacto', {
            url: '/contacto',
        views: {
            'content@': {
                templateUrl: 'configuracion/contacto/contacto.html',
                controller: 'contactoController',
                controllerAs: 'vm',
                resolve: {
                    parameters: ['$q', '$stateParams', 'contactoFactory', 
                        function ($q, $stateParams, contactoFactory) {
                            return { mode: 'view' };
                        }]
                }
            }
        }
    });
}]);