var promesa = new Promise((resolve, reject) => {

});

class UsuarioModalidad {

    constructor(
        accion,
        PkIumCodUm,
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
        console.log(accion + " 1");
        console.log(PkIumCodUm + " PkIumCodUm");
        this.accion = accion;
        this.PkIumCodUm = PkIumCodUm;
        this.FkIuDni = FkIuDni;
        this.FkIcIdConcurso = FkIcIdConcurso;
        this.FkImIdModalidad = FkImIdModalidad;
        this.IumFase = IumFase;
        this.FkIuDniPareja = FkIuDniPareja;
        this.DumFechaIns = DumFechaIns;
        this.VmUmArchivoDni = VmUmArchivoDni;
        this.VmUmArchivoB = VmUmArchivoB;
        this.FkIeEstado = FkIeEstado;
        console.log(this.accion + " 2");

        console.log(FkIuDni + " FkIuDni");
    }

    

    guardarParticipante() {

        console.log("entro")

        //if (this.accion = "") {
        //    console.log("No ingrese accion");
        //} else {
        //    if (this.PkIumCodUm == "") {

        //    } else {
        //        if (this.FkIuDni == "") {

        //        } else {
        //            if (this.FkIcIdConcurso == "") {

        //            } else {
        //                if (this.FkImIdModalidad == "") {

        //                } else {
        //                    if (this.IumFase == "") {

        //                    } else {
        //                        if (this.FkIuDniPareja == "") {

        //                        } else {
        //                            if (this.DumFechaIns == "") {

        //                            } else {

        //                                if (this.VmUmArchivoDni == "") {

        //                                } else {
        //                                    if (this.VmUmArchivoB == "") {

        //                                    } else {
        //                                        if (this.FkIeEstado == "") {

        //                                        } else {

        //                                            console.log('aqui entra el post ' + this.accion);

        //                                            var _accion = this.accion;
        //                                            var PkIumCodUm = this.PkIumCodUm;
        //                                            var FkIuDni = this.FkIuDni;
        //                                            var FkIcIdConcurso = this.FkIcIdConcurso;
        //                                            var FkImIdModalidad = this.FkImIdModalidad;
        //                                            var IumFase = this.IumFase;
        //                                            var FkIuDniPareja = this.FkIuDniPareja;
        //                                            var DumFechaIns = this.DumFechaIns;
        //                                            var VmUmArchivoDni = this.VmUmArchivoDni;
        //                                            var VmUmArchivoB = this.VmUmArchivoB;
        //                                            var FkIeEstado = this.FkIeEstado;

        //                                            console.log('aqui sale el post ' + _accion);

        //                                            $.ajax({

        //                                                type: "POST",
        //                                                url: _accion,
        //                                                data: {

        //                                                    PkIumCodUm,
        //                                                    FkIuDni,
        //                                                    FkIcIdConcurso,
        //                                                    FkImIdModalidad,
        //                                                    IumFase,
        //                                                    FkIuDniPareja,
        //                                                    DumFechaIns,
        //                                                    VmUmArchivoDni,
        //                                                    VmUmArchivoB,
        //                                                    FkIeEstado
        //                                                }, success: (response) => {

        //                                                    if ("Save" == response[0].code) {
        //                                                        swal('Participante', 'Registrado correctamente.', 'success');
        //                                                        this.restablecer();
        //                                                    } else if ("Existe" == response[0].code) {
        //                                                        console.log(response[0].code);
        //                                                        swal('Usuario', `El usuario ${PkIuDni} ya existe en la Base de datos.`, 'info');
        //                                                    } else {
        //                                                        swal('Error', `Ocurrio un error en el servidor.`, 'error');
        //                                                    }
        //                                                }
        //                                            });
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

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







