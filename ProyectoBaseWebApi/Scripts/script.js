
var url = "http://localhost:63876/api/Usuario";
var app = angular.module("app", []);

var MainController = function ($scope, $http) {

    var onSuccess = function (response) {
        $scope.usuarios = response.data;
    };

    var onFailure = function (reason) {
        $scope.error = reason;
    }

    var getAllUsuario = function () {

        $http.get(url)
            .then(onSuccess, onFailure)
    };

    getAllUsuario();
};

app.controller("MainController", MainController);