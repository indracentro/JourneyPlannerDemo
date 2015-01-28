$(document).ready(function() {


    $('.toggleable').hide();

    $('#iMobility').click(
        function() {
            $('#divMobility').slideToggle();
        }
    );
    $('#iTravelOpts').click(
        function () {
            $('#divTravelOpts').slideToggle();
        }
    );

    $('.datepicker').datetimepicker();
});