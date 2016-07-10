// Write your Javascript code.

// Add active class to active navigation link
$(document).ready(function () {
    $('ul.nav.navbar-nav').find('a[href="' + location.pathname + '"]')
        .closest('li').addClass('active');
});
