angular.module('appBase').controller('contactoController', ['$scope', 'contactoFactory', 'parameters', 'blockUI', 'entityUI', 'modalDialogService','handleErrorService',
    function ($scope, contactoFactory, parameters, blockUI, entityUI, modalDialogService, handleErrorService) {

        var vm = this;

        vm.init = function () {
            vm.mode = parameters.mode;
            vm.mail = {};
        }

        vm.send = function () {
            //validar length de la consulta
            blockUI.start();
            contactoFactory.send(vm.mail)
                .then(function (value) {
                    if (value && value.list && value.list == "1") {
                        modalDialogService.showModalMessage('El mail ha sido enviado exitosamente.');
                        vm.mail.nombre = '';
                        vm.mail.consulta = '';
                    }
                    else
                        modalDialogService.showModalFormErrors(["Error al enviar el mail."]);
                })
                .catch(function (error) {
                    handleErrorService.handleErrorConfig(error);
                })
                .finally(function () {
                    blockUI.stop();
                });
        }

        vm.setDefaultModel = function () {
        }

        vm.init();
}]);
