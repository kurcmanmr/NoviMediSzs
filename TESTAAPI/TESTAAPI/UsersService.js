UsersApp.factory('UsersService', ['$http', function ($http) {



    var UsersService = {};

    UsersService.getUsers = function () {

        return $http.get('http://localhost:5121/Api/Users');

    };

    return UsersService;



}]);

UsersApp.factory('UsersCurrentsService', ['$http', function ($http) {



    var UsersCurrentsService = {};

    UsersCurrentsService.getUsersCurrents = function () {

        return $http.get('http://localhost:5121/Api/UsersCurrents');

    };

    return UsersCurrentsService;



}]);

UsersApp.factory('AccountsService', ['$http', function ($http) {



    var AccountsService = {};

    AccountsService.getAccounts = function () {

        return $http.get('http://localhost:5121/Api/Accounts');

    };

    return AccountsService;



}]);