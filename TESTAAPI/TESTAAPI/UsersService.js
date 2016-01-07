UsersApp.factory('UsersService', ['$http', function ($http) {



    var UsersService = {};

    UsersService.getUsers = function () {

        return $http.get('http://localhost:5121/Api/Users');

    };

    return UsersService;



}]);

UsersApp.factory('UsersLogService', ['$http', function ($http) {



    var UsersLogService = {};

    UsersLogService.getUsersLog = function () {

        return $http.get('http://localhost:5121/Api/UsersLog');

    };

    return UsersLogService;



}]);

UsersApp.factory('UsersPermissionsService', ['$http', function ($http) {



    var UsersPermissionsService = {};

    UsersPermissionsService.getUsersPermissions = function () {

        return $http.get('http://localhost:5121/Api/UsersPermissions');

    };

    return UsersPermissionsService;



}]);