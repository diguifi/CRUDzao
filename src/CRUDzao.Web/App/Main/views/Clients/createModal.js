(function () {
    angular.module('app').controller('app.views.clients.createModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.client',
        function ($scope, $uibModalInstance, clientService) {
            var vm = this;

            vm.role = {};
            vm.permissions = [];

            vm.save = function () {
                var assignedPermissions = [];
                for (var i = 0; i < vm.permissions.length; i++) {
                    var permission = vm.permissions[i];
                    if (!permission.isAssigned) {
                        continue;
                    }

                    assignedPermissions.push(permission.name);
                }
                
                vm.role.permissions = assignedPermissions;
                roleService.create(vm.role)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };

            getPermissions();
        }
    ]);
})();