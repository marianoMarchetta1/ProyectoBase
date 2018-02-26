angular.module('appBase', ['ui.router', 'ngSanitize'])
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