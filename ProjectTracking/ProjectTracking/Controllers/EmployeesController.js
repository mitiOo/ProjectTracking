(function () {
    var EmployeesController = function ($scope, employeeService, $log) {
        var employees = function (data) {
            $scope.Employees = data;
        };
        $scope.SearchEmployees = function (employeeName) {
            employeeService.searchEmployees(employeeName)
            .then(employees, errorDetails);
            $log.info('Found Employee which contains - ' + employeeName);
        };
        var errorDetails = function () {
            $scope.Error = "Something went wrong ??";
        };
        employeeService.employees().then(employees, errorDetails);
        $scope.Title = "Employee Details Page";
        $scope.EmployeeName = null;
    };

    app.controller("EmployeesController", ["$scope", "employeeService", "$log", EmployeesController]);

}());

//(function() {
//    app.controller('EmployeesController', function ($scope,$http,$log) {
        
//        var employees = function (serviceResp) {
//            $scope.Employees = serviceResp.data;
//        };

//        $scope.SearchedEmployees = function(EmployeeName) {
//            $http.get("http://localhost:1501/api/ptemployees/" + EmployeeName)
//           .then(employees, errorDetails);
//            $log.info('Found Employee which contains - ' + EmployeeName);
//        };

//        var errorDetails = function () {
//            $scope.Error = "Something went wrong ??";
//        };

//        $http.get("http://localhost:1501/api/ptemployees")
//            .then(employees, errorDetails);

//        $scope.Title = "Employee Details Page";
//        $scope.EmployeeName = null;
//    });
//}())