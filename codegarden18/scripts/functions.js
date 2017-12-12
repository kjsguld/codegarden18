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

    $('#popUp').click(function () {
        $(this).toggleClass('open');
        $(".schedulePopUp").toggleClass('open');
    });

    function addSession(thisObj) {
        var session = thisObj.parents(".timeBox");

        var time = session.find("h4").html();
        var sessionTitle = session.find("#presentationHeadline").html();
        var speakerName = session.find("#speakerName").html();

        var sessionHtml = "<div class='createdScheduleBox'> <h4>" + time + "</h4> <p>" + sessionTitle + "</p> <small>" + speakerName + "</small> </div>";

        console.log(sessionHtml);

        $(".createYourOwnContent").append(sessionHtml);

    }

    $(".addSession").click(function (e) {

        e.preventDefault();
        addSession($(this));

    });

    function downloadYourOwnSchedule() {

        var doc = new jsPDF();
        var specialElementHandlers = {
            '#editor': function (element, renderer) {
                return true;
            }
        };

        var scrollWidth = $('#createYourOwnContent').prop('scrollWidth'); //document.getElementById("primary").style.width;
        var scrollHeight = $('#screateYourOwnContent').prop('scrollHeight'); //document.getElementById("primary").style.height;
        var width = $('#createYourOwnContent').width();
        var height = $('#createYourOwnContent').height();

        html2canvas(document.getElementById("createYourOwnContent"), { width: width, height: height, scrollY: scrollHeight, scrollX: scrollWidth, backgroundColor: '#ffffff' }).then(function (canvas) {

            var image = canvas.toDataURL("image/jpeg").replace("image/png", "image/octet-stream");  // here is the most important part because if you dont replace you will get a DOM 18 exception.

            var width = $("#createYourOwnContent").width() / 6;
            var height = $("#createYourOwnContent").height() / 5;
            doc.addImage(image, 'JPEG', 45, 55, width, height);
            doc.save('sample-file.pdf');
        });

    };

    $('.downloadYourSchedule').click(function (e) {
        e.preventDefault();
        downloadYourOwnSchedule();
    });

});
