var xompoll = angular.module("XomPoll", ['ngRoute', 'ui.materialize']);

xompoll.config(['$locationProvider', '$routeProvider' , function ($locationProvider, $routeProvider) {
    $routeProvider
    .when('/', {
        templateUrl: '/Home/Home',
        controller: 'HomeController'
    })
    .when('/Login', {
        templateUrl: '/Home/Login',
        controller: 'LoginController'
    })
    .when('/PollManagement', {
        templateUrl: '/Event/Event',
        controller: 'EventController'
    });
}]);


xompoll.controller('HomeController', ['$scope', '$location', function ($scope, $location) {
    $scope.login = function () {
        $location.path('/Login');
    };
}]);

xompoll.controller('LoginController', ['$scope', '$location', function ($scope, $location) {
    $scope.login = function () {
        $location.path('/PollManagement');
    }

    $scope.create = function () {
        alert('create new user');
    }
}]);


xompoll.controller('EventController', ['$scope', 'EventService', function ($scope, EventService) {

    $scope.poll = {};

    $scope.init = function () {
        EventService.myEvents().then(function (response) {
            console.log(response);
        });
    };

    $scope.openCreateEventModal = function () {
        $('#create-event-modal').openModal();
    };

    $scope.createPoll = function () {

        EventService.createEvent($scope.poll).then(function (response) {
            console.log(response);
        });
    }

    /**/
    var currentTime = new Date();
    $scope.poll.startDate = currentTime;
    $scope.poll.endDate = currentTime;


    $scope.month = ['Januar', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
    $scope.monthShort = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    $scope.weekdaysFull = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
    $scope.weekdaysLetter = ['S', 'M', 'T', 'W', 'T', 'F', 'S'];
    $scope.disable = [false, 1, 7];
    $scope.today = 'Today';
    $scope.clear = 'Clear';
    $scope.close = 'Close';
    var days = 15;
    //$scope.minDate = (new Date($scope.currentTime.getTime() - (1000 * 60 * 60 * 24 * days))).toISOString();
    //$scope.maxDate = (new Date($scope.currentTime.getTime() + (1000 * 60 * 60 * 24 * days))).toISOString();
    $scope.onStart = function () {
        console.log('onStart');
    };
    $scope.onRender = function () {
        console.log('onRender');
    };
    $scope.onOpen = function () {
        console.log('onOpen');
    };
    $scope.onClose = function () {
        console.log('onClose');
    };
    $scope.onSet = function () {
        console.log('onSet');
    };
    $scope.onStop = function () {
        console.log('onStop');
    };

    $scope.init();
}]);

xompoll.service('EventService', ['XomPollFactory', '$q', function (XomPollFactory, $q) {
    this.myEvents = function () {
        var deferred = $q.defer();
        XomPollFactory.Get('/Event/GetEventByUrl', 'url=test').then(function (response) {
            deferred.resolve(response)
        });
        return deferred.promise;
    };
    this.createEvent = function (event) {
        var deferred = $q.defer();
        XomPollFactory.Post('/Event/Create', event).then(function (response) {
            deferred.resolve(response);
        });
        return deferred.promise;
    };
}]);

xompoll.factory('XomPollFactory', ['$http', '$q', function ($http, $q) {
    return {
        Get: function (controller, filter) {
            var deferred = $q.defer();
            filter = filter || "";
            var url = controller + "?" + filter;
            $http.get(url)
            .success(function (data, status, header) {
                deferred.resolve(data);
            })
            .error(function (data, status, header) {
                deferred.reject(data);
            });
            return deferred.promise;
        },
        Post: function (controller, object) {
            var deferred = $q.defer();
            $http.post(controller, object)
            .success(function (data, status, header) {
                deferred.resolve(data);
            })
            .error(function (data, status, header) {
                deferred.reject(data);
            });
            return deferred.promise;
        }
    }
}]);