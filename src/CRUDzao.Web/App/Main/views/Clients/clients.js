(function () {
    angular.module('app').controller('app.views.clients.clients', [
        '$scope', '$uibModal', 'abp.services.app.client',
        function ($scope, $uibModal, clientService) {
            var vm = this;

            vm.clients = [];

            function getClients() {
                clientService.getAll({}).then(function (result) {
                    vm.clients = result.data.items;
                });
            }

            vm.refresh = function () {
                getClients();
            };

            getClients();
        }
    ]);
})();