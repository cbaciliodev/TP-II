var promesa = new Promise((resolve, reject) => {

});

class UsuarioModalidad {

    constructor(
        accion_participante,
        FkIuDni,
        FkIcIdConcurso,
        FkImIdModalidad,
        IumFase,
        FkIuDniPareja,
        DumFechaIns,
        VmUmArchivoDni,
        VmUmArchivoB,
        FkIeEstado
    ) {

        this.accion_participante = accion_participante;
        this.FkIuDni = FkIuDni;
        this.FkIcIdConcurso = FkIcIdConcurso;
        this.FkImIdModalidad = FkImIdModalidad;
        this.IumFase = IumFase;
        this.FkIuDniPareja = FkIuDniPareja;
        this.DumFechaIns = DumFechaIns;
        this.VmUmArchivoDni = VmUmArchivoDni;
        this.VmUmArchivoB = VmUmArchivoB;
        this.FkIeEstado = FkIeEstado;
    }



    guardarParticipante() {

        if (this.accion_participante = "") {
            console.log("No ingrese accion");
        } else {

            if (this.FkIuDni == 0) {
                document.getElementById('usuario').focus();
                document.getElementById("usuario_result").innerHTML = `Este Campo es requerido`;
            } else {

                if (this.FkIcIdConcurso == 0) {
                    document.getElementById('codigoConcurso').focus();
                    document.getElementById("codigoConcurso_result").innerHTML = `Este Campo es requerido`;
                } else {

                    if (this.DumFechaIns == "") {
                        document.getElementById('fechaIncripcion').focus();
                        document.getElementById("fecha_result").innerHTML = `Este Campo es requerido`;
                    } else {

                        if (this.VmUmArchivoDni == "") {
                            document.getElementById('VmUmArchivoDni').focus();
                            document.getElementById("dni_result").innerHTML = `Este Campo es requerido`;
                        } else {

                            if (this.VmUmArchivoB == "") {
                                document.getElementById('archivoPago').focus();
                                document.getElementById("recibo_result").innerHTML = `Este Campo es requerido`;
                            } else {

                                if (this.FkIeEstado == "") {
                                    console.log('Ingrese el estado');
                                } else {

                                   

                                    var _accion_participante = this.accion_participante;                                   
                                    var FkIuDni = this.FkIuDni;
                                    var FkIcIdConcurso = this.FkIcIdConcurso;
                                    var FkImIdModalidad = this.FkImIdModalidad;
                                    var IumFase = this.IumFase;
                                    var FkIuDniPareja = this.FkIuDniPareja;
                                    var DumFechaIns = this.DumFechaIns;
                                    var VmUmArchivoDni = this.VmUmArchivoDni;
                                    var VmUmArchivoB = this.VmUmArchivoB;
                                    var FkIeEstado = this.FkIeEstado;

                                    console.log('aqui sale el post ' + _accion_participante);

                                    $.ajax({

                                        type: "POST",
                                        url: _accion_participante,
                                        data: {
                                            FkIuDni,
                                            FkIcIdConcurso,
                                            FkImIdModalidad,
                                            IumFase,
                                            FkIuDniPareja,
                                            DumFechaIns,
                                            VmUmArchivoDni,
                                            VmUmArchivoB,
                                            FkIeEstado
                                        }, success: (response) => {

                                            if ("Save" == response[0].code) {
                                                swal('Participante', 'Registrado correctamente.', 'success');
                                                this.restablecer();
                                            } else if ("Existe" == response[0].code) {
                                                console.log(response[0].code);
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



function validarConcurso(concurso) {
    if (concurso != "") {
        document.getElementById("codigoConcurso_result").innerHTML = ``;
    }
}

function validarFecha(fecha) {
    if (fecha != "") {
        document.getElementById("fecha_result").innerHTML = ``;
    }
}




