/*window.onload = function () {

    var codigoUsuario = document.getElementById("usuarioCodigo").value;

    $('#usuario option[value=' + codigoUsuario + ']').attr("selected", true);

    document.getElementById("FkIuDni").value = codigoUsuario;

}*/


$(document).ready(function () {
   
    getListaConcurso();
    getListaPareja();

    var codigoUsuario = document.getElementById("usuarioCodigo").value;

    $('#usuario option[value=' + codigoUsuario + ']').attr("selected", true);

    document.getElementById("codigo_ajax").value = codigoUsuario;
});


function archivoDnipdf() {

    var selectedFile = document.getElementById("VmUmArchivoDni").files;

    if (selectedFile.length > 0) {

        var fileToLoad = selectedFile[0];
        var fileReader = new FileReader();
        var base64;

        fileReader.onload = function (fileLoadedEvent) {
            base64 = fileLoadedEvent.target.result;
            document.getElementById("data").innerHTML = base64;
        }
    };

    fileReader.readAsDataURL(fileToLoad);
};


function reciboPago() {

    var selectedFile = document.getElementById("archivoPago").files;

    if (selectedFile.length > 0) {

        var fileToLoad = selectedFile[0];
        var fileReader = new FileReader();
        var base64;

        fileReader.onload = function (fileLoadedEvent) {
            base64 = fileLoadedEvent.target.result;
            document.getElementById("recibo").innerHTML = base64;
        }
    };

    fileReader.readAsDataURL(fileToLoad);
};

function habilitar() {

    var valor = document.getElementById("modalidadConcurso").value;
    console.log(valor, ' modalidad')

    if (valor == 1) {

        var letra = "Final Uno"
        document.getElementById("fase").value = letra;
        document.getElementById("faseModalidad").value = letra;
        document.getElementById("pareja").disabled = true;

    } else if (valor == 2) {

        var todos = "Eliminatorio"
        document.getElementById("fase").value = todos;
        document.getElementById("faseModalidad").value = todos;
        document.getElementById("pareja").disabled = false;
        getListaPareja();

    } else {

        if (valor == "") {
            document.getElementById("faseModalidad").value = "";
            document.getElementById("pareja").value = "";

            var selectPareja = $('#pareja');
            selectPareja.html('<option value= 0 >' + 'Seleccione' + '</option>');
        }

        document.getElementById("pareja").disabled = true;
    }
}


var getListaConcurso = function () {

    $.ajax({
        url: "/TUsuarioModalidad/GetConcurso",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectConcurso = $('#codigoConcurso');
            selectConcurso.find('option').remove();
            selectConcurso.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.concurso, function (key, value) { 
                selectConcurso.append('<option value=' + value.Codigo + '>' + value.Nombre + '</option>');
            });
           },
        error: function (response) {
        }
    });
};

var getListaPareja = function () {

    var sexo = document.getElementById('sexoParticipante').value;
    console.log(sexo, ' sexo');

    $.ajax({
        url: "/TUsuarioModalidad/GetPareja",
        type: "GET",
        data: { ssexo: sexo },
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectPareja = $('#pareja');

            selectPareja.find('option').remove();
            selectPareja.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.parejaLista, function (key, value) { //temp es la lista que va recorrer 
                selectPareja.append('<option value=' + value.Codigo + '>' + value.Nombre + ' ' + value.Paterno + ' ' + value.Materno + '</option>');
            });
        },
        error: function (response) {
        }
    });
};

var getListaParticipante = function () {

    $.ajax({
        url: "/TUsuarioModalidad/GetPareja",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var selectPareja = $('#usuario');
            selectPareja.find('option').remove();
            selectPareja.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.parejaLista, function (key, value) {
                selectPareja.append('<option value=' + value.Codigo + '>' + value.Nombre + ' ' + value.Materno + ' ' + value.Materno + '</option>');
            });
        },
        error: function (response) {
        }
    });
};


function validar() {


    var selectedFileDni = document.getElementById("data").value;
    var selectedFileRecibo = document.getElementById("recibo").value;

}
