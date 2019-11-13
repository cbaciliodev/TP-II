$(document).ready(function () {
   // mostarFormularioRegistroUsuario();
    getListaCategoria();
});


var getListaCategoria = function () {

    $.ajax({
        url: "/RegistarUsuarioAdmin/GetListaCategoria",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectCategoria = $('#categoria');
            selectCategoria.find('option').remove();
            selectCategoria.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.categoria, function (key, value) {
                selectCategoria.append('<option value=' + value.codigo + '>' + value.nombre + '</option>');                
            });
        },
        error: function (response) {
        }
    });
};

function calcularEdadUsuario() {

    var fecha = document.getElementById("nacimiento").value;

    if (fecha != "") {

        document.getElementById("nacimiento_result").innerHTML = ``;

        var hoy = new Date();

        var cumpleanos = new Date(fecha);

        var edad = hoy.getFullYear() - cumpleanos.getFullYear();
        console.log(edad);
        var m = hoy.getMonth() - cumpleanos.getMonth();

        if (m < 0 || (m === 0 && hoy.getDate() < cumpleanos.getDate())) {
            console.log(edad);
            edad--;
        }

        var categoria = document.getElementById("categoria");

        console.log(edad);
        if (4 <= edad && edad <= 6) {
            categoria.selectedIndex = 3;
        }
        else if (7 <= edad && edad <= 9) {
            categoria.selectedIndex = 2;
        }
        else if (10 <= edad && edad <= 13) {
            categoria.selectedIndex = 4;
        }
        else if (14 <= edad && edad <= 17) {
            categoria.selectedIndex = 5;
        }
        else if (18 <= edad && edad <= 21) {
            alert(edad);
            çategoria.selectedIndex = 6;
        }
        else if (22 <= edad && edad <= 34) {
            categoria.selectedIndex = 7;
        }
        else if (35 <= edad && edad <= 49) {
            categoria.selectedIndex = 8;
        }
        else if (50 <= edad && edad <= 62) {
            categoria.selectedIndex = 1;
        }
        else {
            edad = 0;
            categoria.selectedIndex = 0;
        }

        console.log(edad);

    } 
  
    return edad;
}


function validarIdentificacion(numero) {

    if (!/^([0-9])*$/.test(numero)) {
        
        document.getElementById("ident_result").innerHTML = `El valor ${numero}  no es un dni valido`;
        $('#identificacion').focus();
    }
    else if (numero == '') {
       
        document.getElementById("ident_result").innerHTML = `Este Campo es requerido`;
        $('#identificacion').focus();
    }
    else {
        document.getElementById("ident_result").innerHTML = ``;
    }
}

function validarNombre(nombre) {
    if (nombre != "") {
        document.getElementById("nomb_result").innerHTML = ``;
    }
}

function validarApaterno(apaterno) {
    if (apaterno != "") {
        document.getElementById("paterno_result").innerHTML = ``;
    }
}

function validarAmaterno(amaterno) {
    if (amaterno != "") {
        document.getElementById("materno_result").innerHTML = ``;
    }
}

function validarPassword(password) {
    if (password != "") {
        document.getElementById("pass_result").innerHTML = ``;
    }
}

function validarSexo(sexo) {
    if (sexo != "") {
        document.getElementById("sexo_result").innerHTML = ``;
    }
}

function validarImagen(imagen) {
    if (imagen != "") {
        document.getElementById("imagen_result").innerHTML = ``;
    }
}

function validarAcademia(academia) {
    if (academia != "") {
        document.getElementById("academia_result").innerHTML = ``;
    }
}