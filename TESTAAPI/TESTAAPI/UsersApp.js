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

UsersApp.controller('UsersCurrentsController', function ($scope, $http, UsersCurrentsService) {

    getUsersCurrents1();
    function getUsersCurrents1() {

        UsersCurrentsService.getUsersCurrents()
        .success(function (data) {


            $scope.usersCurrents = data;
            console.log($scope.usersCurrents);

        })
        .error(function (error) {


            $scope.status = 'Ne mogu da ucitam user jer sam glup' + error.message;
            console.log($scope.status);

        });


    }

    ShowUsersCurrents = function () {


        $http.get('api/UsersCurrents')

        .success(function (data1) {

            $scope.korisnici = data1;


        })
        .error(function (error1) {

            $scope.status1 = 'Ne mogu da ucitam user jer sam glup';
            console.log($scope.status1);



        });
    }

});

UsersApp.controller('AccountsController', function ($scope, $http, AccountsService) {

    getAccounts1();
    function getAccounts1() {

        AccountsService.getAccounts()
        .success(function (data) {


            $scope.accounts = data;
            console.log($scope.accounts);

        })
        .error(function (error) {


            $scope.status = 'Ne mogu da ucitam user jer sam glup' + error.message;
            console.log($scope.status);

        });


    }

    ShowAccounts = function () {


        $http.get('api/Accounts')

        .success(function (data1) {

            $scope.korisnici = data1;


        })
        .error(function (error1) {

            $scope.status1 = 'Ne mogu da ucitam user jer sam glup';
            console.log($scope.status1);



        });






    }

});

