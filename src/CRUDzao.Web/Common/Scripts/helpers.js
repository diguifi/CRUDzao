var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('CRUDzao');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);