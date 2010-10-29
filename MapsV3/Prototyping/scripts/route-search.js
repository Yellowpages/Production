$(document).ready(function() {
    updateTabCarContainerSizes();

    $(window).resize(function() {
        updateTabCarContainerSizes();
    });
});

function updateTabCarContainerSizes() {
    if ($('#ctl00_mainArea_ContSearchOpts_tabCar').length > 0) {
        temp = window.innerHeight - $("#ctl00_mainArea_ContSearchOpts_tabCar").position().top;
        $('#ctl00_mainArea_ContSearchOpts_tabCar').height(temp - 5);
    }
}