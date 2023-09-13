// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//$(document).ready(function () {
//    $(document).on('click', '.pBody', function () {
//        $(this).hide();
//    });
//});
//function toggleDiv(element) {
//    if ($(element).is(":visible")) {
//        $(element).hide();
//    } else {
//        $(element).show();
//    }
//}
$(document).ready(function () {
    $("button").click(function () {
        if ($(".pBody").is(":visible")) {
            $(".pBody").hide()
        } else {
            $(".pBody").show()
        }
    })
})

$(document).ready(function () {
    var div = $("div.stick");
    for (let i = 0; i <= 100; i++) {
        div.animate({ width: '300px', opacity: '0.8' }, "slow");
        div.animate({ height: '300px', opacity: '0.4' }, "slow");
        div.animate({ height: '100px', opacity: '0.4' }, "slow");
        div.animate({ width: '100px', opacity: '0.8' }, "slow");
    }
    
});