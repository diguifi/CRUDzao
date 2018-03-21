(function () {
    angular.module('app').controller('app.views.clients.clients', [
        '$scope', '$timeout', '$uibModal', 'abp.services.app.client',
        function ($scope, $timeout, $uibModal, clientService) {
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
                    controller: 'app.views.clients.createModal as vm',
                    backdrop: 'static'
                });

                modalInstance.rendered.then(function () {
                    $.AdminBSB.input.activate();
                });

                modalInstance.result.then(function () {
                    getClients();
                });
            };

            vm.openClientEditModal = function (client) {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/clients/editModal.cshtml',
                    controller: 'app.views.clients.editModal as vm',
                    backdrop: 'static',
                    resolve: {
                        id: function () {
                            return client.id;
                        }
                    }
                });

                modalInstance.rendered.then(function () {
                    $timeout(function () {
                        $.AdminBSB.input.activate();
                    }, 0);
                });

                modalInstance.result.then(function () {
                    getClients();
                });
            };

            vm.delete = function (client) {
                abp.message.confirm(
                    "Delete client '" + client.firstName + "'?",
                    function (result) {
                        if (result) {
                            clientService.deleteClient(client.id)
                                .then(function () {
                                    abp.notify.info("Deleted user: " + client.fisrtName);
                                    getClients();
                                });
                        }
                    });
            }

            vm.refresh = function () {
                getClients();
            };

            getClients();
        }
    ]);
})();