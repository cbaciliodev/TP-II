$(document).ready(function () {
    mostarFormularioRegistroUsuario();
});

function mostarFormularioRegistroUsuario() {

    var dataHtml = `<div class="form-group">
                         <form method="post">
                             <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                                    <div class="row col-xs-12 col-md-12 col-lg-12">
                                        <!--Codigo de Participante - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">
                                            <label for="identificacion" class="control-label">Documento:</label>
                                           <input type="text" class="form-control" placeholder="DNI" id="identificacion"/>
                                            <input type="text" value="" hidden />
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Codigo de Participante - Fin -->
                                        <!--Concurso - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">               
                                           <label for="nombre" class="control-label">Nombre:</label>
                                           <input type="text" class="form-control" placeholder="Nombre de usuario" id="nombre" value=""/>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Concurso - Fin -->
                                    </div>
                                    
                                    <div class="row col-xs-12 col-md-12 col-lg-12">
                                        <!--Codigo de Participante - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">
                                            <label for="apaterno" class="control-label">Apellido Paterno:</label>
                                           <input type="text" class="form-control" placeholder="Apellido Paterno" id="apaterno"/>
                                            <input type="text" value="" hidden />
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Codigo de Participante - Fin -->
                                        <!--Concurso - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">               
                                           <label for="amaterno" class="control-label">Apellido Materno:</label>
                                           <input type="text" class="form-control" placeholder="Apellido Materno" id="amaterno" value=""/>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Concurso - Fin -->
                                    </div>

      
                                    <div class="row col-xs-12 col-md-12 col-lg-12">
                                        <div class="form-group  col-xs-4 col-md-4 col-lg-4">
                                            <button type="button" value="Create" class="btn btn-primary form-control" 
                                                     onclick="javascript:guardarRegistroUsuario();">Registrar</button>
                                        </div>
                                    </div>
                                </form>
                            </div>`;

    $("#RegistroUsuario").html(dataHtml);


    
}


function guardarRegistroUsuario() {

    var identificacion = document.getElementById('identificacion').value;
    var nombre = document.getElementById('nombre').value;
    var apaterno = document.getElementById('apaterno').value;
    var amaterno = document.getElementById('amaterno').value;

    if (identificacion == '') {
        $('#identificacion').focus();
        console.log(identificacion);
    }
    else if (nombre == '') {
        $('#nombre').focus();
        console.log(nombre);
    }
    else if (apaterno == '') {
        $('#apaterno').focus();
        console.log(apaterno);
    }
    else if (amaterno == '') {
        $('#amaterno').focus();
        console.log(amaterno);
    } else {
        console.log(identificacion);
        console.log(nombre);
        console.log(apaterno);
        console.log(amaterno);
    }                                                                 
}