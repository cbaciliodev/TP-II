$(document).ready(function () {

    getListaConcurso_Gestor();
    //getListaPareja_Gestor();
    getListaParticipantes_Gestor();
    getListarModaliad_Gestor();
});

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

        if (this.accion_participante == "") {
            //console.log("No ingrese accion");
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
                            document.getElementById('data_VmUmArchivoDni_participante').focus();
                            document.getElementById("dni_result").innerHTML = `Este Campo es requerido`;
                        } else {
                            if (this.VmUmArchivoB == "") {
                                document.getElementById('recibo_archivoPago_participante').focus();
                                document.getElementById("recibo_result").innerHTML = `Este Campo es requerido`;
                            } else {
                                if (this.FkIeEstado == "") {
                                   // console.log('Ingrese el estado');
                                } else {

                                   // console.log(this.accion_participante + " this.accion_participante");

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

                                            //console.log(response[0].code);

                                            if ("Save" == response[0].code) {
                                                swal('Participante', `El Participante: ${FkIuDni} fue Registrado correctamente.`, 'success');
                                                this.restablecer();
                                            } else if ("Existe" == response[0].code) {
                                                //console.log(response[0].code);
                                                swal('Participante', `El Participante ${FkIuDni} ya existe en la Base de datos.`, 'info');
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

        document.getElementById('usuario').selectedIndex = 0;
        document.getElementById('codigoConcurso').selectedIndex = 0;
        document.getElementById('modalidadConcurso').selectedIndex = 0;
        document.getElementById('faseModalidad').selectedIndex = 0;
        document.getElementById('pareja').selectedIndex = 0;
        document.getElementById('fechaIncripcion').value = "";
        document.getElementById('VmUmArchivoDni_participante').value = "";
        document.getElementById('archivoPago_participante').value = "";
        document.getElementById('data_VmUmArchivoDni_participante').value = "";
        document.getElementById('recibo_archivoPago_participante').value = "";
        
        
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

function validarDniParticipante(dni) {
    //alert(dni)
    if (dni != "") {
        encodeDni();
        document.getElementById("dni_result").innerHTML = ``;
    }
};

function validarPagoParticipante(pago) {
    //alert(pago)
    if (pago != "") {
        encodePago();
        document.getElementById("recibo_result").innerHTML = ``;
    }
};

function habilitar_Fase() {

    var valor = document.getElementById("modalidadConcurso").value;

    if (valor == 1) {

        var letra = "Final Uno"
        //document.getElementById("fase").value = letra;
        document.getElementById("faseModalidad").value = letra;
        document.getElementById("pareja").disabled = true;

    } else if (valor == 2) {

        var todos = "Eliminatorio"
        //document.getElementById("fase").value = todos;
        document.getElementById("faseModalidad").value = todos;
        getListaPareja_Gestor();
        document.getElementById("pareja").disabled = false;

    } else {

        if (valor == 0) {
            document.getElementById("faseModalidad").value = "";
            document.getElementById("pareja").value = "";

            var selectPareja = $('#pareja');
            selectPareja.html('<option value= 0 >' + 'Seleccione' + '</option>');
        }

        document.getElementById("pareja").disabled = true;
    }
}

var getListaConcurso_Gestor = function () {

    $.ajax({
        url: "/AdministarParticipante/GetConcurso",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectConcurso = $('#codigoConcurso');
            selectConcurso.find('option').remove();
            selectConcurso.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.concurso, function (key, value) {
                selectConcurso.append('<option value=' + value.codigo + '>' + value.nombre + '</option>');
            });
        },
        error: function (response) {
        }
    });
};

var getListarModaliad_Gestor = function () {

    $.ajax({
        url: "/AdministarParticipante/GetModalidad",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            //console.log(response.modalidad)

            var selectConcurso = $('#modalidadConcurso');
            selectConcurso.find('option').remove();
            selectConcurso.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.modalidad, function (key, value) {
                selectConcurso.append('<option value=' + value.codigo + '>' + value.nombre + '</option>');
            });
        },
        error: function (response) {
        }        
    });
};


//var getListaPareja_Gestor = function () {
function getListaPareja_Gestor() {

    var sexo = document.getElementById('sexo_pareja').value;
   // console.log(sexo +  " sexo participante");
    $.ajax({
        url: "/AdministarParticipante/GetPareja",
        type: "GET",
        data: { ssexo: sexo },
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            var selectPareja = $('#pareja');

            selectPareja.find('option').remove();
            selectPareja.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.parejaLista, function (key, value) { //temp es la lista que va recorrer 
                selectPareja.append('<option value=' + value.codigo + '>' + value.nombre + ' ' + value.paterno + ' ' + value.materno + '</option>');
            });
        },
        error: function (response) {
        }
    });
};

var getListaParticipantes_Gestor = function () {

    $.ajax({
        url: "/AdministarParticipante/GetParticipante",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var selectPareja = $('#usuario');
            selectPareja.find('option').remove();
            selectPareja.append('<option value= 0 >' + 'Seleccione' + '</option>');

            $.each(response.participanteLista, function (key, value) {
                selectPareja.append('<option value=' + value.codigo + '>' + value.nombre + ' ' + value.paterno + ' ' + value.materno + '</option>');
            });
        },
        error: function (response) {
        }
    });
};

function obtenerInfoParticipante() {

    var dni = document.getElementById("usuario").value;

    if (dni == 0) {
        //console.log(dni + " cuando es 0");
        document.getElementById('modalidadConcurso').selectedIndex = 0;
        document.getElementById('faseModalidad').selectedIndex = 0;
        document.getElementById('pareja').selectedIndex=0;

    } else if (dni != 0) {

        document.getElementById('modalidadConcurso').selectedIndex = 0;
        document.getElementById('faseModalidad').selectedIndex = 0;
        document.getElementById('pareja').selectedIndex = 0;
        //console.log(dni + " cuando es diferente a 0");

        $.ajax({
            url: "/AdministarParticipante/GetParticipanteDatos",
            type: "GET",
            data: { ddni: dni },
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                document.getElementById("codigo_ajax").innerHTML = response.usuarioDatosRegistro[0].codigo;
                document.getElementById("nombre_ajax").innerHTML = response.usuarioDatosRegistro[0].nombre;
                document.getElementById("apaterno_ajax").innerHTML = response.usuarioDatosRegistro[0].paterno;
                document.getElementById("amaterno_ajax").innerHTML = response.usuarioDatosRegistro[0].materno;
                document.getElementById("sexo_ajax").innerHTML = response.usuarioDatosRegistro[0].sexo;
                document.getElementById("sexo_pareja").value = response.usuarioDatosRegistro[0].sexo;

                //console.log(response.usuarioDatosRegistro);
            },
            error: function (response) {
            }
    });
    }
    document.getElementById("usuario_result").innerHTML = ``;
}


function validar() {
    var selectedFileDni = document.getElementById("data").value;
    var selectedFileRecibo = document.getElementById("recibo").value;
}

function openModal() {

    $('#OpenModalRegistroUsuario').modal({ show: true, backdrop: 'static', keyboard: false });
}

function encodeDni() {

    var selectedfile = document.getElementById("VmUmArchivoDni_participante").files;
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
            document.getElementById("data_VmUmArchivoDni_participante").value = srcData;
            //console.log(srcData)
        }
        fileReader.readAsDataURL(imageFile);
    }
}

function encodePago() {

    var selectedfile = document.getElementById("archivoPago_participante").files;

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
            document.getElementById("recibo_archivoPago_participante").value = srcData;
            //console.log(srcData)
        }

        fileReader.readAsDataURL(imageFile);
    }
}
