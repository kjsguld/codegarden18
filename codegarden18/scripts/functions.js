$(document).ready(function () {

    // ------ Navigation ------ //
    
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

    // ------ Category (vote) ------ //

    $('.dots-container').click(function () {
        if ($(this).hasClass('active')) {
            $(this).removeClass('active');
            $(this).animate({ right: '0' });
            $(this).find(".vote").empty();
        } else {
            $(this).addClass('active');
            $(this).animate({ right: '10%' });
            $(this).find(".vote").html("vote");
        }
        
        
    });

    // ------ Schedule ------ //

    $('#popUp').click(function () {
        $(this).toggleClass('open');
        $(".schedulePopUp").toggleClass('open');
    });

    function addSession(thisObj) {
        var session = thisObj.parents(".timeBox");


        var time = session.find("h4").html();
        var sessionTitle = session.find("#presentationHeadline").html();
        var speakerName = session.find("#speakerName").html();
        var day;

        var sessions = [];

        thisObj.addClass("added");

        $(".timeBox").each(function (e) {
            if ($(this).find(".addSession").hasClass("added")) {



                time = $(this).find("h4").html();
                sessionTitle = $(this).find("#presentationHeadline").html();
                speakerName = $(this).find("#speakerName").html();
                day = $(this).parents(".day").find("h3").html();
                sessionObj = {};

                sessionObj.Time = time;
                sessionObj.Title = sessionTitle;
                sessionObj.Speaker = speakerName;
                sessionObj.Day = day;

                sessions.push(sessionObj);
            }



        });

        $(".createYourOwnContent").html("");

        sessions.forEach(function (sessionItem) {
            var sessionHtml = "<div class='createdScheduleBox'><a class='removeContent' href=''> <i class='material-icons'>clear</i></a > <h4>" + sessionItem.Time + "</h4> <p>" + sessionItem.Title + "</p> </div > ";

            if ($(".createYourOwnContent").find("h3").last().html() != sessionItem.Day) {
                $(".createYourOwnContent").append("<h3 class='day'>" + sessionItem.Day + "</h3>");
            }

            $(".createYourOwnContent").append(sessionHtml);

        });

    }

    $(".addSession").click(function (e) {
        $(this).toggleClass('added');
        e.preventDefault();
        addSession($(this));

    });


    //function of download your schedule, creates a variable for a new javascript pdf. canvas2html creates from the variable "image" an canvas(an image) and then makes it to an html image that javascript can copy into the pdf file
    // the variable width and heights tells the size of the image it tranfers to the jsPDF.
    function downloadYourOwnSchedule() {

        var doc = new jsPDF();
        

        html2canvas(document.getElementById("createYourOwnContent"), { logging: true }).then(function (canvas) {

            var image = canvas.toDataURL("image/jpeg").replace("image/png", "image/octet-stream");  // here is the most important part because if you dont replace you will get a DOM 18 exception.

            var width = $("#createYourOwnContent").width() / 3.5;
            var height = $("#createYourOwnContent").height() / 4 ;
            doc.addImage(image, 'JPEG', 50, 30, width, height);

            //saves document 
            doc.save('Your-Awesome-Schedule.pdf');
        });
    
    }

    //this calls the function  "downloadYourOwnSchedule" when the user clicks .downloadYourOwnSchedule



    $(".downloadYourSchedule").click(function (e) {
        e.preventDefault();
        downloadYourOwnSchedule();
    });

    $('#popUp').click(function ( e ) {
        var $this = $(this);

        if ($this.hasClass('close')) { 
            $this.text('Open your schedule');
            $this.removeClass('close');
        } else {
            $this.addClass('close');
            $this.html('<i class="material-icons">clear</i>');
           
            
        }
    });


    //function that looks for same dublicated content (removetitle == getRemoveSession)

    function removeSession(thisObj) {
        var getRemoveSession = thisObj.parents(".createdScheduleBox").find("p").html();
       
        $(".createdScheduleBox").each(function () {
            removeTitle = $(this).find("p").html();
            
            if (removeTitle === getRemoveSession) {
                $(this).remove();
            }
        });



    }

    //this calls the fucntion "removeSession" by clicking the a tag (removeContent) and then it sees that there is dublicants and cant add then.

    $(".createYourOwnContent").on("click", ".removeContent", function ( e ) {
        e.preventDefault();
        removeSession($(this));
        
    });

});
