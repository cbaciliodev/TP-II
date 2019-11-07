
class Usuario {

    constructor() {
    }

    guardarUsuarioRegistro(funcion, ...data) {
        var action = data[0];
        var response = new Array({

            identificacion_user: data[1],
            nombre_user: data[2],
            apaterno_user: data[3],
            amaterno_user: data[4],
            nacimiento_user: data[5],
            password_user: data[6],
            sexo_user: data[7],
            categoria_user: data[8],
            imagen_user: data[9],
            academia_user: data[10]
        });

        alert(action)
        $.post(
            action,
            {
                response, funcion
            }, (response) => {
                if ("1" == response[0].code) {
                    this.restablecer()
                } else {
                    document.getElementById("mensaje").innerHTML = "No se puede guardar el usuario";
                }
            }
        );

    }


    restablecer() {
        document.getElementById('identificacion').value = "";
        document.getElementById('nombre').value = "";
        document.getElementById('apaterno').value = "";
        document.getElementById('amaterno').value = "";
        document.getElementById('nacimiento').value = "";
        document.getElementById('password').value = "";
        document.getElementById('sexo').value = "";
        document.getElementById('categoria').value = "";
        document.getElementById('imagen').value = "";
        document.getElementById('academia').value = "";
    }
}