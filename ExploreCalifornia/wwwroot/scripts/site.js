$(function () {

    // Whenever any link is clicked in the navigation section
    // of the blog page, request that content via AJAX
    $('#mainContent').on('click', '.pager a', function() {
        var url = $(this).attr('href');

        $('#mainContent').load(url);

        return false;
    })
})