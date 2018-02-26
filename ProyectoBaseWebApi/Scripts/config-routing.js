angular.module('appBase').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise(function ($injector, $location) {
        var $state = $injector.get("$state");

        if ($location.$$path == '' || $location.$$path == '/')
            $state.go('app.home', {}, {
                location: false
            });
        else    
            $state.go("pagenotfound", {}, {
                location: false
            });
    });

   // $urlRouterProvider.otherwise('/');
  //  $urlRouterProvider.when('', '/index.html');

    $stateProvider
        .state('pagenotfound', {          
            url: '/pagenotfound',
            views: {
                'header': {
                    templateUrl: 'anonymous-layout/anonymous-header.html'
                },
                'content': {
                    templateUrl: 'anonymous-layout/pagenotfound.html' 
                },
                'footer': {
                    templateUrl: 'anonymous-layout/anonymous-footer.html'
                }
            }
        })
        .state('app', {
            url: '/informacion',
            views: {
                'header': {
                    templateUrl: '../usuario/usuario-header.html',
                    controller: 'usuarioHeaderController'
                },
                'content': {
                    templateUrl: '../usuario/usuario-content.html',
                    controller: 'usuarioContentController'
                },
                'footer': {
                    templateUrl: '../usuario/usuario-footer.html',
                    controller: 'usuarioFooterController'
                }
            }
        })
            //abstract: true,
            //views: {
            //    'header': {
            //        templateUrl: 'layout/header.html?' + versionProvider.versionGuid,
            //        controller: 'headerController',
            //        resolve: {

            //            parameters: ['$q', '$stateParams', 'blockUI', 'securityFactory', function ($q, $stateParams, blockUI, securityFactory) {
            //                var myBlockUI = blockUI.instances.get('myBlockUI');
            //                if (myBlockUI._refs == 0)
            //                    myBlockUI = blockUI;
            //                myBlockUI.start();
            //                return securityFactory.get()
            //                    .catch(function (error) {
            //                        return $q.reject('');
            //                    })
            //                    .finally(function () {
            //                        myBlockUI.stop();
            //                    });

            //            }]
            //        }

            //    },
            //    'content': {
            //        templateUrl: 'layout/content.html?' + versionProvider.versionGuid
            //    },
            //    'footer': {
            //        templateUrl: 'layout/footer.html?' + versionProvider.versionGuid
            //    }
            //}
        .state('app.home', {
            url: '/inicio',
            views: {
                'header': {
                    templateUrl: '../usuario/usuario-header.html',
                    controller: 'usuarioHeaderController'
                },
                'content': {
                    templateUrl: '../usuario/usuario-content.html',
                    controller: 'usuarioContentController'
                },
                'footer': {
                    templateUrl: '../usuario/usuario-footer.html',
                    controller: 'usuarioFooterController'
                }
            }
        });
}]);