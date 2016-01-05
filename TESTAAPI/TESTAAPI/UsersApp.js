var UsersApp = angular.module('UsersApp', [])



UsersApp.controller('UsersController', function ($scope, $http, UsersService) {

    getUsers1();
    function getUsers1() {

        UsersService.getUsers()
        .success(function (data) {


            $scope.users = data;
            console.log($scope.users);

        })
        .error(function (error) {


            $scope.status = 'Ne mogu da ucitam user jer sam glup' + error.message;
            console.log($scope.status);

        });


    }

    //$scope.message = "Infrgistics";

    ShowUsers = function () {


        $http.get('api/Users')

        .success(function (data1) {

            $scope.korisnici = data1;


        })
        .error(function (error1) {

            $scope.status1 = 'Ne mogu da ucitam user jer sam glup';
            console.log($scope.status1);



        });


        



    }

});

//UsersApp.factory('UsersService', ['$http', function ($http) {



//    var UsersService = {};

//    UsersService.getUsers = function () {

//        return $http.get('http://localhost:5121/Api/Users');

//    };

//    return UsersService;



//}]);