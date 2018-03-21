(function () {
    angular.module('app').controller('app.views.clients.createModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.client',
        function ($scope, $uibModalInstance, clientService) {
            var vm = this;

            vm.client = {};

            vm.save = function () {
                clientService.createClient(vm.client)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };

        }
    ]);
})();