angular.module('appBase').controller('comercialController', ['$scope', 'comercialFactory', 'parameters',
    function ($scope, comercialFactory, parameters) {

        var vm = this;

        vm.init = function () {
            vm.mode = parameters.mode;
        }

        vm.setDefaultModel = function () {
        }

        vm.init();
}]);
