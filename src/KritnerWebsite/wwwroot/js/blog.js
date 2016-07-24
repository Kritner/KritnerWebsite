// blog.js
function vm() {
    var self = this;

    // Properties
    self.blogs = ko.observableArray([]);
    self.isLoading = ko.observable(true);
    self.errorMessage = ko.observable('');
    
    // Load data
    $.getJSON("/api/blog")
        .success(function (data) {
            self.blogs(data);
        })
        .error(function (err) {
            self.errorMessage(err);
        })
        .complete(function () {
            self.isLoading(false);
        });
}
ko.applyBindings(new vm());