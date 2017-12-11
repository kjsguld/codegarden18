jQuery(document).ready(function ($) {

    $(document).ready(function () {
        $('#nav-icon1,#nav-icon2,#nav-icon3,#nav-icon4').click(function () {
            $(this).toggleClass('open');
            $(".nav").toggleClass('open');
        });
        $('.contextButton').click(function () {
            var target = $(this).attr('data-target');
            var self = $(this).attr('data-self');
            target = $('#' + target);
            self = $('#' + self);
            self.addClass('hiddenBox');
            target.removeClass('hiddenBox');
        });
    });
});
                