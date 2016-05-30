var xompoll = angular.module("XomPoll", ['ngRoute']);

xompoll.config(function ($locationProvider, $routeProvider) {
    $routeProvider
    .when('/', {
        templateUrl: '/Home/Home',
        controller: 'HomeController'
    })
    .when('/Login', {
        templateUrl: '/Home/Login',
        controller: 'LoginController'
    });
});


xompoll.controller('HomeController', ['$scope', '$location', function ($scope, $location) {
    $scope.login = function () {
        $location.path('/Login');
    };
}]);

xompoll.controller('LoginController', ['$scope', function ($scope) {
    
}]);