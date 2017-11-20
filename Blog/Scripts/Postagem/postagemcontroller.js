
app.controller("postagemcontroller", function ($scope,$http) {
    $scope.criar = function () {
        $http({
            method: 'POST',
            url: 'http://localhost:50210/Postagem/CriarPostagem',
            data: { post: $scope.post }
        }).then(function successCallback(response) {
        }, function errorCallback(response) {
            console.log(response);
        }
            );
    }

});