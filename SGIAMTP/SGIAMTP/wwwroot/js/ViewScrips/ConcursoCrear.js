$(document).ready(function (e) {
    locationGoogleAutocomplete();
});

function locationGoogleAutocomplete(){

    var apikey = "AIzaSyA4JCFrlbrz6hZ8yEsaKgJKV20UGVqn6CI";
    $('#locationid').autocomplete({
        minLength: 1,
        delay: 10,
        autofill: false,
        inputFocus: true,
        selectFirst: true,
        source: function (request, response, options) {
            const proxyurl = "https://cors-anywhere.herokuapp.com/";
            var xmlhttp = new XMLHttpRequest();
            var url = "https://maps.googleapis.com/maps/api/place/autocomplete/json?input=" + request.term + " && key=" + apikey;
            
            xmlhttp.onreadystatechange = function () {
                if (this.readyState === 4 && this.status === 200) {
                    var data = JSON.parse(this.responseText);
                    response($.map(data.predictions, function (value, key) {
                        return {
                            data: value.id,
                            value: value.description
                        };
                    }));
                }
            };
            xmlhttp.open("GET", proxyurl + url, true);
            xmlhttp.send();
        },
        create: function () {
            $(this).data('ui-autocomplete')._renderItem = function (ul, item) {
                return $('<li class="autocomplete-li" style="color:#636f84;font-size:13px;background-color:#ffffff">').attr('title', item.value).append('<div style="max-width:267px">' + '<span style="width:auto;margin-left:6%;margin-rigth:6% !important;text-overflow: ellipsis;white-space: nowrap;display:block;overflow:hidden">' + item.value + '</span></div>')
                    .appendTo(ul);
            };
        },
        select: function (event, ui) {
            console.log(event);
            //$(event.target).parent().find('[data-id="latitud"]').val(ui.item.geometry.lat);
            //$(event.target).parent().find('[data-id="longitud"]').val(ui.item.geometry.lng);
        }
       
    }).focus(function (input) {
        $(this).autocomplete("search");
        $('#locationid').autocomplete("option", "appendTo", $(input.target).parent());
    });

}