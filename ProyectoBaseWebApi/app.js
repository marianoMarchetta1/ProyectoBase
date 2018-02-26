angular.module('appBase', ['ui.router', 'ngSanitize', 'ui.bootstrap', 'blockUI'])
.run(['$rootScope', '$location', '$state', '$stateParams', '$timeout', 
    function ($rootScope, $location, $state, $stateParams, $timeout ) {

        $state.go('app.home');

        //authServiceFactory.fillAuthData();

        //$rootScope.$on("$stateChangeStart",
        //    function (event, toState, toParams, fromState, fromParams) {

        //        if (toState.name !== 'appan.login' &&
        //            toState.name !== 'appan.resetpassExitoso' &&
        //            toState.name !== 'appan.resetpassError' &&
        //            toState.name !== 'appan.cambiarPasswordAnonimo' &&
        //            !authServiceFactory.authentication.isAuth) {
        //            event.preventDefault();
                    
        //        }
        //    });
}])
.constant('constants', {
    apiServiceBaseUri: document.location.protocol + '//' + document.location.host + '/',
    clientId: 'estudioBrown',
    applicationName: 'Estudio Brown',
    clientName: 'Estudio Brown'
})