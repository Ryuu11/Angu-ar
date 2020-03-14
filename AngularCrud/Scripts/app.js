var app = angular.module("CRUD", ["CRUD.controllers", "ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
        when("/",{ templateUrl: "/Partials/Proveedor.html", controller: "MainController" }).
        otherwise({ redirectTo: "/" });
}])
