(function () {
    angular.module('app').controller('app.views.clients.clients', [
        '$scope', '$uibModal', 'abp.services.app.client',
        function ($scope, $uibModal, clientService) {
            var vm = this;

            vm.clients = [];

            function getClients() {
                clientService.getAllClients({}).then(function (result) {
                    vm.clients = result.data.clients;
                });
            }

            vm.openClientCreationModal = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/clients/createModal.cshtml',
                    controller: 'app.views.users.createModal as vm',
                    backdrop: 'static'
                });
            }

            vm.refresh = function () {
                getClients();
            };

            getClients();
        }
    ]);
})();