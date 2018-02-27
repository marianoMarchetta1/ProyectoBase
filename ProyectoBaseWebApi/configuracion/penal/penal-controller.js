angular.module('appBase').controller('penalController', ['$scope', 'penalFactory', 'parameters',
    function ($scope, penalFactory, parameters) {

        var vm = this;

        vm.init = function () {
            vm.mode = parameters.mode;
        }

        vm.setDefaultModel = function () {
        }

        vm.init();
}]);
