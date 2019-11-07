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

function calcularEdad() {

    var fecha = document.getElementById("nacimiento").value;
    var hoy = new Date();
    var cumpleanos = new Date(fecha);
    var edad = hoy.getFullYear() - cumpleanos.getFullYear();
    var m = hoy.getMonth() - cumpleanos.getMonth();

    if (m < 0 || (m === 0 && hoy.getDate() < cumpleanos.getDate())) {
        edad--;
    }

    var categoria = document.getElementById("categoria");

    console.log(categoria);

    var categoria = document.getElementById("categoria");

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
        categoria.selectedIndex = 0;
    }

    console.log(edad)
    document.getElementById("resultado").innerHTML = `Tienes ${edad} años.`;
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

    if (nombre == '') {
        document.getElementById("nomb_result").innerHTML = `Este Campo es requerido`;
    } else {
        document.getElementById("nomb_result").innerHTML = ``;
    }
}
function validarApaterno(paterno) {

    if (paterno == '') {
        document.getElementById("paterno_result").innerHTML = `Este Campo es requerido`;
    } else {
        document.getElementById("paterno_result").innerHTML = ``;
    }
}
function validarAmaterno(materno) {

    if (materno == '') {
        document.getElementById("materno_result").innerHTML = `Este Campo es requerido`;
    } else {
        document.getElementById("materno_result").innerHTML = ``;
    }
}
function validarPassword(password) {

    if (password == '') {
        document.getElementById("pass_result").innerHTML = `Este Campo es requerido`;
    } else {
        document.getElementById("pass_result").innerHTML = ``;
    }
}
function validarSexo(sexo) {

    if (sexo == '') {
        document.getElementById("sexo_result").innerHTML = `Este Campo es requerido`;
    } else {
        document.getElementById("sexo_result").innerHTML = ``;
    }
}
function validarImagen(imagen) {

    if (imagen == '') {
        document.getElementById("imagen_result").innerHTML = `Este Campo es requerido`;
    } else {
        document.getElementById("imagen_result").innerHTML = ``;
    }
}

function validarAcademia(academia) {

    if (academia == '') {
        document.getElementById("academia_result").innerHTML = `Este Campo es requerido`;
    } else {
        document.getElementById("academia_result").innerHTML = ``;
    }
}


var funcion = 0;

Usuario newUsuario = new Usuario();

function guardarRegistroUsuario() {

    var identificacion = document.getElementById('identificacion').value;
    var nombre = document.getElementById('nombre').value;
    var apaterno = document.getElementById('apaterno').value;
    var amaterno = document.getElementById('amaterno').value;
    var nacimiento = document.getElementById('nacimiento').value;
    var password = document.getElementById('password').value;
    var sexo = document.getElementById('sexo').value;
    var categoria = document.getElementById('categoria').value;
    var imagen = document.getElementById('imagen').value;
    var academia = document.getElementById('academia').value;
   
    if (identificacion == '') {
        $('#identificacion').focus();
        document.getElementById("ident_result").innerHTML = `Este Campo es requerido`;
        console.log(identificacion);
    }
    else if (nombre == '') {
        $('#nombre').focus();
        document.getElementById("nomb_result").innerHTML = `Este Campo es requerido`;
        console.log(nombre);
    }
    else if (apaterno == '') {
        $('#apaterno').focus();
        document.getElementById("paterno_result").innerHTML = `Este Campo es requerido`;
        console.log(apaterno);
    }
    else if (amaterno == '') {
        $('#amaterno').focus();
        document.getElementById("materno_result").innerHTML = `Este Campo es requerido`;
        console.log(amaterno);
    }
    else if (nacimiento == '') {
        document.getElementById("resultado").innerHTML = `Este Campo es requerido`;
        $('#nacimiento').focus();
        console.log(nacimiento);
    }
    else if (password == '') {
        $('#password').focus();
        document.getElementById("pass_result").innerHTML = `Este Campo es requerido`;
        console.log(password);
    }
    else if (sexo == '') {
        $('#sexo').focus();
        document.getElementById("sexo_result").innerHTML = `Este Campo es requerido`;
        console.log(sexo);
    }
    else if (categoria == '') {
        $('#categoria').focus();
        console.log(categoria);
    }
    else if (imagen == '') {
        $('#imagen').focus();
        document.getElementById("imagen_result").innerHTML = `Este Campo es requerido`;
        console.log(imagen);
    }
    else if (academia == '') {
        $('#academia').focus();
        console.log(academia);
    } else {

        console.log(identificacion);
        console.log(nombre);
        console.log(apaterno);
        console.log(amaterno);
        console.log(nacimiento);
        console.log(password);
        console.log(sexo);
        console.log(categoria);
        console.log(imagen);
        console.log(academia);

        var action_user = 'AdministarParticipante/guardarUsuario'
        var identificacion_user = identificacion;
        var nombre_user = nombre;
        var apaterno_user = apaterno;
        var amaterno_user = amaterno;
        var nacimiento_user = nacimiento;
        var password_user = password;
        var sexo_user = sexo;
        var categoria_user = categoria
        var imagen_user = imagen;
        var academia_user = academia;

        alert(identificacion_user);

       

        usuario.guardarUsuarioRegistro(funcion,
            action_user,
            identificacion_user,
            nombre_user,
            apaterno_user,
            amaterno_user,
            nacimiento_user,
            password_user,
            sexo_user,
            categoria_user,
            imagen_user,
            academia_user);
    }                                                                 
}