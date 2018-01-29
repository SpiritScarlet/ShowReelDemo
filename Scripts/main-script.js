$(document).ready(function () {
    
    if ($(document).find('.home').length > 0) {
        $('.particle-container').removeClass('hidden');
    }

    $('#particles').particleground({
        dotColor: 'rgba(255,255,255, 0.5)',
        lineColor: 'rgba(255,255,255, 0.5)',
        parallaxMultiplier: 8
    });

    $('.dropdown li').on('click', function () {
        var genre = $(this).attr('id');
        $(this).addClass('selected');
        $('.dropdown button').attr('id', genre).html(genre + ' <i class="fa fa-angle-down"></i>');
    });

    $(document).bind('.js-track','click', function (e) {
        //e.preventDefault();
        var showId = $(this).attr('id');
        var url = " http://api.tvmaze.com/shows?page=1";
        xmlhttp.onreadystatechange = function () {
            var $obj = JSON.parse(this.responseText);
            for (var i = 0; i < $obj.length - 1; i++) {
                if ($obj[i].id == showId) {
                    alert($obj[i].name);
                }
            }
        }

        xmlhttp.open("GET", $url, true);
        xmlhttp.send();
      
    });

});