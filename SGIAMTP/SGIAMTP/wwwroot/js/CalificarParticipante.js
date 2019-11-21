var count = 0;
$(document).ready(function () {
    //$("#codt").text(localStorage.getItem("ct"));
    //$("#categoria").text(localStorage.getItem("cat"));
    //$("#modalidad").text(localStorage.getItem("mod"));
    getModalidad();
    getCategoria();
    getListaParticipante();
    getListaPartand();

    $('#selectParticipante').on('change', function () {
        // Para asignar un nuevo valor a la variable global "a" no se usa var, 
        // solo el nombre de la variable
        a = $("#selectParticipante option:selected").text();
        var selectPar = $("#partTan");
        var codt = document.getElementById('codt').value;
        var codtp = a + codt;
        $("#codtp").val(codtp);
        selectPar.val(codtp);
    });
});
var getListaParticipante = function () {

    var codt = document.getElementById('codt').value;
    console.log(codt, ' codt');

    $.ajax({
        url: "/TPuntajes/GetParticipante",
        type: "GET",
        data: { codt: codt },
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectParticipante = $('#selectParticipante');

            selectParticipante.find('option').remove();
            if (count === 0)//cambie 
                selectParticipante.append('<option value="0" selected>--Seleccione</option>');
            var listatemporal = response.participanteLista;
            $.each(listatemporal, function (key, value) { //temp es la lista que va recorrer 
                selectParticipante.append('<option value=' + value.codigo + '>' + value.codigo + '</option>');
            });
        },
        error: function (response) {
            console.log(codt);
        }
    });
};
var concatenar = function () {
    var codp = document.getElementById('selectParticipante').value;
    var codt = document.getElementById('codt').value;
    var codtp = codp + codt;
}
var getModalidad = function () {

    var codt = document.getElementById('codt').value;
    console.log(codt, ' codt');

    $.ajax({
        url: "/TPuntajes/GetModalidad",
        type: "GET",
        data: { codt: codt },
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectModalidad = $('#modalidad');

            selectModalidad.find('option').remove();

            var listatemporal = response.modalidadLista;
            $.each(listatemporal, function (key, value) { //temp es la lista que va recorrer 
                selectModalidad.append('<option value=' + value.nombrem + '>' + value.nombrem + '</option>');
            });
        },
        error: function (response) {
            console.log(codt);
        }
    });
};
var getCategoria = function () {

    var codt = document.getElementById('codt').value;
    console.log(codt, ' codt');

    $.ajax({
        url: "/TPuntajes/GetCategoria",
        type: "GET",
        data: { codt: codt },
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectCategoria = $('#categoria');

            selectCategoria.find('option').remove();

            var listatemporal = response.categoriaLista;
            $.each(listatemporal, function (key, value) { //temp es la lista que va recorrer 
                selectCategoria.append('<option value=' + value.nombrec + '>' + value.nombrec + '</option>');
            });
        },
        error: function (response) {
            console.log(codt)
        }
    });
};
var getListaPartand = function () {

    var codt = document.getElementById('codt').value;
    console.log(codt, ' codt');

    $.ajax({
        url: "/TPuntajes/GetPartand",
        type: "GET",
        data: { codt: codt },
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectPartan = $('#partTan');

            selectPartan.find('option').remove();
            if (count === 0)//cambie 
                selectPartan.append('<option value="0" selected>--Seleccione</option>');
            var listatemporal = response.partanLista;
            $.each(listatemporal, function (key, value) { //temp es la lista que va recorrer 
                selectPartan.append('<option value=' + value.codigo + '>' + value.codigo + '</option>');
            });
        },
        error: function (response) {
            console.log(codt);
        }
    });
};