(function () {
    angular
        .module('app')
        .controller('app.views.clients.editModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.client', 'id',
        function ($scope, $uibModalInstance, clientService, id) {
            var vm = this;

            vm.client = {
                isActive: true
            };

            vm.client = [];

            var init = function () {
                clientService.getById(id)
                    .then(function (result) {
                        vm.client = result.data;

                        clientService.get(id)
                            .then(function (result) {
                                vm.client = result.data;
                            });
                    });
            }

            vm.save = function () {
                clientService.updateClient(vm.client)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };

            init();
        }
    ]);
})();