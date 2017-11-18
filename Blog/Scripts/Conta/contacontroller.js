
app.controller("contacontroller", function ($scope,$http) {
    $scope.criar = function () {
        $http({
            method: 'POST',
            url: 'http://localhost:50210/Account/CriarUsuario',
            data: { usuario: $scope.usuario }
        }).then(function successCallback(response) {
        }, function errorCallback(response) {
            console.log(response);
        }
            );
    }

});