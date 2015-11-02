
app.controller('memberController', function ($scope, $http) {

    //declare variable for mainain ajax load and entry or edit mode
    $scope.loading = true;
    $scope.addMode = false;
    //get all projects
    //get all members
    $http.get('/api/Project/').success(function (data) {
        $scope.projects = data;
        $scope.loading = false;
    });
    //get all members
    $http.get('/api/Member/').success(function (data) {
        $scope.members = data;
        $scope.loading = false;
    })
    .error(function () {
        $scope.error = "An Error has occured while loading members!";
        $scope.loading = false;
    });
    $scope.CreateMember = function () {
        $http.get('@Url.Action("CreateMember")', { params: { pro_id: parseInt($scope.selectedItem.Proj_Id), memName: $scope.CreateMember.Name, title: $scope.CreateMember.CreatedData } })
                .success(function (data) { })
                .error(function (err) { console.log(err); });
    };

})