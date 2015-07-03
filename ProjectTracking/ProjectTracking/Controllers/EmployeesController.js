(function() {
    app.controller('EmployeesController', function ($scope) {
        var employees = {
            employeeName: "John Richard",
            designation: "Project Manager",
            contactNo: "+333 3888389",
            eMailID: "john@projects.com",
            skillSets: "ASP.NET, ASP.NET MVC"
        };


        $scope.title = 'Employee Detail Page';
        $scope.employees = employees;

    });
}())