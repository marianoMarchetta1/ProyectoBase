angular.module('appBase').controller('penalViewController', ['$scope', 'penalFactory', 'parameters',
    function ($scope, penalFactory, parameters) {

        var vm = this;

        vm.init = function () {
            vm.mode = parameters.mode;
        }

        vm.setDefaultModel = function () {
        }

        vm.init();
}]);
