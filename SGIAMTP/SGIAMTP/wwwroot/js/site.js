﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//var funcion = 0;
//var usuario = new Usuario();

var guardarRegistroUsuario = () => {

    var accion = "RegistarUsuarioAdmin/AgregarUsuario";
    var PkIuDni = document.getElementById('identificacion').value;
    var VuNombre = document.getElementById('nombre').value;
    var VuApaterno = document.getElementById('apaterno').value;
    var VuAmaterno = document.getElementById('amaterno').value;
    var DuFechaNacimiento = document.getElementById('nacimiento').value;
    var VuContraseña = document.getElementById('password').value;
    var VuSexo = document.getElementById('sexo').value;
    var FkIuCodCategoria = document.getElementById('categoria').value;
    var VuFoto = document.getElementById('imagen').value;
    var VuNacademia = document.getElementById('academia').value;
    var FkItuTipoUsuario = 1;

    console.log('SiTE INICIO');
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
    console.log('SiTE fin');

    var usuario = new Usuario(
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
        VuFoto
    );

    usuario.agregarUsuario();
}


var guardarRegistroParticipante = () => {

    var accion_participante = "AdministarParticipante/AgregarUsuarioParticipante";
    var FkIuDni = document.getElementById('usuario').value;
    var FkIcIdConcurso = document.getElementById('codigoConcurso').value;
    var FkImIdModalidad = document.getElementById('modalidadConcurso').value;
    var IumFase = document.getElementById('faseModalidad').value;
    var FkIuDniPareja = document.getElementById('pareja').value;
    var DumFechaIns = document.getElementById('fechaIncripcion').value;
    var VmUmArchivoDni = document.getElementById('VmUmArchivoDni').value;
    var VmUmArchivoB = document.getElementById('archivoPago').value;
    var FkIeEstado = 3;


    var usuarioModalidad = new UsuarioModalidad(
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
    );
    usuarioModalidad.guardarParticipante();
};

