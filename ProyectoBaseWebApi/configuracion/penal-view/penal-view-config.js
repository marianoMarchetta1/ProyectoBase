angular.module('appBase').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
    $stateProvider
    .state('app.penal-view', {
        url: '/penal',
        views: {
            'content@': {
                templateUrl: 'configuracion/penal-view/penal-view.html',
                controller: 'penalViewController',
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