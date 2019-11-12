var promesa = new Promise((resolve, reject) => {

});
class Usuario {

    constructor(accion,
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
                                                                    swal('Usuario', 'Registrado correctamente.', 'success');

                                                                    this.restablecer();
                                                                } else if ("Existe" == response[0].code) {
                                                                    console.log(response[0].code)
                                                                    swal('Usuario', `El usuario ${PkIuDni} ya existe en la Base de datos.`, 'info');
                                                                } else {
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
    };
}

