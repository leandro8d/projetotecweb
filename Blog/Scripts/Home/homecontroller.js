app.controller("homecontroller", function ($scope, $http) {
    $scope.usuarios = [];
    $scope.usuarios.push('leandro');

    $scope.minhaVariavel = 'teste01!';

    $scope.adicionarUsuario = function (nomeUsuario) {
        $scope.usuarios.push(nomeUsuario);
    }

   
        $http({
            method: 'GET',
            url: 'http://localhost:50210/Postagem/ListAll'

        }).then(function successCallback(response) {
            $scope.postagens = response.data;
        }, function errorCallback(response) {
            console.log(response);
        }
            );




});