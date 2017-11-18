app.controller("homecontroller", function ($scope) {
    $scope.usuarios = [];
    $scope.usuarios.push('leandro');

    $scope.minhaVariavel = 'teste01!';

    $scope.adicionarUsuario = function (nomeUsuario)
    {
        $scope.usuarios.push(nomeUsuario);
    }

});