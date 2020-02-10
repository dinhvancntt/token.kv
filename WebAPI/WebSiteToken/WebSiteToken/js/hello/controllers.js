/* global angular */
(function () {
    "use strict";

    var app = angular.module('helloApp.controllers', []);

    app.controller('helloCtrl', ['$scope', '$http',
        function($scope, $http) {
            $http.get('http://token.somee.com/gettoken')
                .success(function(response) {
                    $scope.name = response;
                    
                });
        }
    ]);
})();

