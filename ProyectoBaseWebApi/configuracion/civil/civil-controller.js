angular.module('appBase').controller('civilController', ['$scope', 'civilFactory', 'parameters',
    function ($scope, civilFactory, parameters) {

        var vm = this;

        vm.init = function () {
            vm.mode = parameters.mode;
        }

        vm.setDefaultModel = function () {
        }

        vm.init();
}]);
