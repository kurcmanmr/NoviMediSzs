UsersApp.factory('UsersService', ['$http', function ($http) {



    var UsersService = {};

    UsersService.getUsers = function () {

        return $http.get('http://localhost:5121/Api/Users');

    };

    return UsersService;



}]);