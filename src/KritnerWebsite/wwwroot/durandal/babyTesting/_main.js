// _main.js

var basePathLib = '/lib/';

// require.js locations config
require.config({
    paths: {
        'text': basePathLib + 'requirejs-text/text',
        'durandal': basePathLib + 'durandal/js',
        'plugins': basePathLib + 'durandal/js/plugins',
        'transitions': basePathLib + 'durandal/js/transitions'
    }
});

define('jquery', function () { return jQuery; })
define('knockout', ko);

define(['durandal/system', 'durandal/app', 'durandal/viewLocator'],
    function (system, app, viewLocator) {

        //>>excludeStart("build", true);
        system.debug(true);
        //>>excludeEnd("build");

        app.title = 'Baby Tracking';

        app.configurePlugins({
            router: true,
            dialog: true,
            widget: true
        });

        app.start().then(function () {
            viewLocator.useConvention();

            app.setRoot('viewModels/shell', 'entrance');
        });

    })