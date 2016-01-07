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


UsersApp.controller('UsersLogController', function ($scope, $http, UsersLogService) {

    getUsersLog1();
    function getUsersLog1() {
        
        UsersLogService.getUsersLog()
        .success(function (data) {
           

            $scope.usersLog = data;
            console.log($scope.usersLog);

        })
        .error(function (error) {


            $scope.status = 'Ne mogu da ucitam user jer sam glup' + error.message;
            console.log($scope.status);

        });


    }

    //$scope.message = "Infrgistics";

    ShowUsersLog = function () {


        $http.get('api/UsersLogs')

        .success(function (data1) {

            $scope.korisnici = data1;


        })
        .error(function (error1) {

            $scope.status1 = 'Ne mogu da ucitam user jer sam glup';
            console.log($scope.status1);



        });
        
    }

});


UsersApp.controller('UsersPermissionsController', function ($scope, $http, UsersPermissionsService) {

    getUsersPermissions1();
    function getUsersPermissions1() {

        UsersPermissionsService.getUsersPermissions()
        .success(function (data) {


            $scope.usersPermissions = data;
            console.log($scope.usersPermissions);

        })
        .error(function (error) {


            $scope.status = 'Ne mogu da ucitam user jer sam glup' + error.message;
            console.log($scope.status);

        });


    }

    //$scope.message = "Infrgistics";

    ShowUsersPermissions = function () {


        $http.get('api/UsersPermissions')

        .success(function (data1) {

            $scope.korisnici = data1;


        })
        .error(function (error1) {

            $scope.status1 = 'Ne mogu da ucitam user jer sam glup';
            console.log($scope.status1);



        });

    }

});

