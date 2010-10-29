var viewport_width;
var viewport_height;
var usable_height;

$(document).ready(function() {
    calculateUsableHeight();

    updateContainerSizes();

    $(window).resize(function() {
        updateContainerSizes();
    });
});

function calculateUsableHeight() {
    if (window.innerWidth != 'undefined') {
        viewport_width = window.innerWidth;
        viewport_height = window.innerHeight;
        usable_height = viewport_height - $('#top-container').innerHeight();
    }
}

function updateContainerSizes() {
    calculateUsableHeight();

    $('#search-container').height(usable_height);
}