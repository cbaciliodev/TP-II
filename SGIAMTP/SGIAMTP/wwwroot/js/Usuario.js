var promesa = new Promise((resolve, reject) => {

});
class Usuario {

    constructor(
        accion,
        PkIuDni,
        VuNombre,
        VuApaterno,
        VuAmaterno,
        DuFechaNacimiento,
        VuContraseña,
        VuSexo,
        VuNacademia,
        FkIuCodCategoria,
        FkItuTipoUsuario,
        VuFoto) {

        console.log(accion + " 1");
        this.accion = accion;
        this.PkIuDni = PkIuDni;
        this.VuNombre = VuNombre;
        this.VuApaterno = VuApaterno;
        this.VuAmaterno = VuAmaterno;
        this.DuFechaNacimiento = DuFechaNacimiento;
        this.VuContraseña = VuContraseña;
        this.VuSexo = VuSexo;
        this.VuNacademia = VuNacademia;
        this.FkIuCodCategoria = FkIuCodCategoria;
        this.FkItuTipoUsuario = FkItuTipoUsuario;
        this.VuFoto = VuFoto;

        console.log('Usuario INICIO');
        console.log(accion + ' accion ');
        console.log(PkIuDni + ' PkIuDni ');
        console.log(VuNombre + ' VuNombre ');
        console.log(VuApaterno + ' VuApaterno ');
        console.log(VuAmaterno + ' VuAmaterno ');
        console.log(DuFechaNacimiento + ' DuFechaNacimiento ');
        console.log(VuContraseña + ' VuContraseña ');
        console.log(VuSexo + ' VuSexo ');
        console.log(VuNacademia + ' VuNacademia ');
        console.log(FkIuCodCategoria + ' FkIuCodCategoria ');
        console.log(FkItuTipoUsuario + ' FkItuTipoUsuario ');
        console.log(VuFoto + ' VuFoto ');

        console.log(this.accion + ' accion ');
        console.log(this.PkIuDni + ' PkIuDni ');
        console.log(this.VuNombre + ' VuNombre ');
        console.log(this.VuApaterno + ' VuApaterno ');
        console.log(this.VuAmaterno + ' VuAmaterno ');
        console.log(this.DuFechaNacimiento + ' DuFechaNacimiento ');
        console.log(this.VuContraseña + ' VuContraseña ');
        console.log(this.VuSexo + ' VuSexo ');
        console.log(this.VuNacademia + ' VuNacademia ');
        console.log(this.FkIuCodCategoria + ' FkIuCodCategoria ');
        console.log(this.FkItuTipoUsuario + ' FkItuTipoUsuario ');
        console.log(this.VuFoto + ' VuFoto ');
        console.log('Usuario Fin');
    }



    agregarUsuario() {

        if (this.accion == "") {
            console.log("No ingrese accion");

        } else {

            if (this.PkIuDni == "") {
                document.getElementById('identificacion').focus();
                document.getElementById("ident_result").innerHTML = `Este Campo es requerido`;
            } else {

                if (this.VuNombre == "") {
                    document.getElementById('nombre').focus();
                    document.getElementById("nomb_result").innerHTML = `Este Campo es requerido`;
                } else {
                    if (this.VuApaterno == "") {
                        document.getElementById('apaterno').focus();
                        document.getElementById("paterno_result").innerHTML = `Este Campo es requerido`;
                    } else {

                        if (this.VuAmaterno == "") {
                            document.getElementById('amaterno').focus();
                            document.getElementById("materno_result").innerHTML = `Este Campo es requerido`;
                        } else {
                            if (this.DuFechaNacimiento == "") {
                                document.getElementById('nacimiento').focus();
                                document.getElementById("nacimiento_result").innerHTML = `Este Campo es requerido`;
                            } else {
                                if (this.VuContraseña == "") {
                                    document.getElementById('password').focus();
                                    document.getElementById("pass_result").innerHTML = `Este Campo es requerido`;
                                } else {
                                    if (this.VuSexo == "") {
                                        document.getElementById('sexo').focus();
                                        document.getElementById("sexo_result").innerHTML = `Este Campo es requerido`;
                                    } else {
                                        if (this.FkIuCodCategoria == "") {
                                            document.getElementById('categoria').focus();
                                        } else {
                                            if (this.VuFoto == "") {
                                                document.getElementById('imagen').focus();
                                                document.getElementById("imagen_result").innerHTML = `Este Campo es requerido`;
                                            } else {
                                                if (this.VuNacademia == "") {
                                                    document.getElementById('academia').focus();
                                                    document.getElementById("academia_result").innerHTML = `Este Campo es requerido`;
                                                } else {
                                                    if (this.FkItuTipoUsuario == "") {
                                                        console.log("#Agregar tipo de usuario");
                                                    } else {

                                                        //aqui entra el post
                                                        console.log('aqui entra el post' + this.accion);

                                                        var _accion = this.accion;
                                                        var PkIuDni = this.PkIuDni;
                                                        var VuNombre = this.VuNombre;
                                                        var VuApaterno = this.VuApaterno;
                                                        var VuAmaterno = this.VuAmaterno;
                                                        var DuFechaNacimiento = this.DuFechaNacimiento;
                                                        var VuContraseña = this.VuContraseña;
                                                        var VuSexo = this.VuSexo;
                                                        var VuNacademia = this.VuNacademia;
                                                        var FkIuCodCategoria = this.FkIuCodCategoria;
                                                        var FkItuTipoUsuario = this.FkItuTipoUsuario;
                                                        var VuFoto = this.VuFoto;

                                                        console.log('AJAx INICIO');
                                                        console.log(_accion + " _accion")
                                                        console.log(PkIuDni + ' PkIuDni ');
                                                        console.log(VuNombre + ' VuNombre ');
                                                        console.log(VuApaterno + ' VuApaterno ');
                                                        console.log(VuAmaterno + ' VuAmaterno ');
                                                        console.log(DuFechaNacimiento + ' DuFechaNacimiento ');
                                                        console.log(VuContraseña + ' VuContraseña ');
                                                        console.log(VuSexo + ' VuSexo ');
                                                        console.log(VuNacademia + ' VuNacademia ');
                                                        console.log(FkIuCodCategoria + ' FkIuCodCategoria ');
                                                        console.log(FkItuTipoUsuario + ' FkItuTipoUsuario ');
                                                        console.log(VuFoto + ' VuFoto ');
                                                        console.log('AJax fin');

                                                        $.ajax({
                                                            type: "POST",
                                                            url: _accion,
                                                            data: {
                                                                PkIuDni,
                                                                VuNombre,
                                                                VuApaterno,
                                                                VuAmaterno,
                                                                DuFechaNacimiento,
                                                                VuContraseña,
                                                                VuSexo,
                                                                VuNacademia,
                                                                FkIuCodCategoria,
                                                                FkItuTipoUsuario,
                                                                VuFoto

                                                            }, success: (response) => {
                                                                if ("Save" == response[0].code) {
                                                                    console.log(response)

                                                                    swal('Usuario', 'Registrado correctamente.', 'success');

                                                                    this.restablecer();
                                                                } else if ("Existe" == response[0].code) {
                                                                    console.log(response[0].code)
                                                                    swal('Usuario', `El usuario ${PkIuDni} ya existe en la Base de datos.`, 'info');
                                                                } else {
                                                                    console.log(response)
                                                                    swal('Error', `Ocurrio un error en el servidor.`, 'error');
                                                                }
                                                            }
                                                        });
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    restablecer() {

        document.getElementById('identificacion').value = "";
        document.getElementById('nombre').value = "";
        document.getElementById('apaterno').value = "";
        document.getElementById('amaterno').value = "";
        document.getElementById('nacimiento').value = "";
        document.getElementById('password').value = "";
        document.getElementById('sexo').value = "";
        document.getElementById('categoria').selectedIndex = 0;
        document.getElementById('imagen').value = "";
        document.getElementById('academia').value = "";
        document.getElementById('codigoFoto').value="";
    };
}

$(document).ready(function () {
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
        encode()
        document.getElementById("imagen_result").innerHTML = ``;
    }
}

function validarAcademia(academia) {
    if (academia != "") {
        document.getElementById("academia_result").innerHTML = ``;
    }
}


function encode() {

    var selectedfile = document.getElementById("imagen").files;
    if (selectedfile.length > 0) {
        var imageFile = selectedfile[0];
        var fileReader = new FileReader();

        fileReader.onload = function (fileLoadedEvent) {

            var srcData = fileLoadedEvent.target.result;

            var newImage = document.createElement('img');
            newImage.src = srcData;
            newImage.style.height = "100px";
            newImage.style.width = "100px";
            //document.getElementById("verFoto").innerHTML = newImage.outerHTML;
            //document.getElementById("codigoFoto").value = document.getElementById("verFoto").innerHTML;
            document.getElementById("codigoFoto").value = srcData;
            console.log(srcData)
        }
        fileReader.readAsDataURL(imageFile);
    }
}
