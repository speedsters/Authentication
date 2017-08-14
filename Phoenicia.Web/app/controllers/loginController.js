'use strict';
app.controller('loginController', ['$scope', '$location', 'authService', 'ngAuthSettings', function ($scope, $location, loginService, ngAuthSettings) {

    $scope.loginData = {
        userName: "",
        password: "",
        useRefreshTokens: false
    };

    $scope.message = "";
    $scope.show = false;
    $scope.getpasscode = function() {
        loginService.getpasscode($scope.loginData.userName).then(function(response) {
                $scope.show = true;
            },
            function(err) {
                $scope.message = err.error_description;
            }
        );
    };

    $scope.login = function () {

        loginService.login($scope.loginData).then(function (response) {

            $location.path('/orders');

        },
         function (err) {
             $scope.message = err.error_description;
         });
    };


    
}]);
