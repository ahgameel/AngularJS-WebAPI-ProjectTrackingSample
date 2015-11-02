
    // Create the module and define its dependencies.
    var app = angular.module('projecttrackingapp', [
        // Angular modules
        'ngRoute' // routing

        
    ]);

    // config always runs before the services are ready.
    // basically the first thing our module does.
    app.config(function ($routeProvider) {
        $routeProvider
         
           .when('/members', { templateUrl: 'views/MembersList.html' })
           .when('/projects', { templateUrl: 'views/Projectlist.html' })
           .otherwise({ redirectTo: '/' }); // go to the welcome page
    }
    );
    

