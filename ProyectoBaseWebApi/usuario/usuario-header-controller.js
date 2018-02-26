angular.module('appBase').controller('usuarioHeaderController', ['$scope', '$state',
    function ($scope, $state) {

        var vm = this;
        //vm.queryUI = muebleFactory.getQueryUI();

        vm.init = function () {
            //vm.mode = parameters.mode;
            //vm.rules = parameters.dataRules;
            //if (!vm.queryUI.initialized) vm.setDefaultModel();
        }

        //vm.setDefaultModel = function () {
        //    vm.queryUI.clear();
        //    vm.queryUI.query.order = [{ property: 'nombre', descending: false }, { Property: 'activo', descending: false }];
        //    vm.queryUI.query.activo = null;
        //    vm.queryUI.query.nombre = null;
        //    vm.queryUI.initialized = true;
        //}

        $scope.go = function(state){
            $state.go(state);
        }

        vm.init();
    }]);
